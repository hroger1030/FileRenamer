using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

using AutoCodeGenLibrary;

namespace FileRenamer
{
    public class FileRenamer
    {
        public const string FILE_FILTER_ALL_FILES = "(all files)";
        public const string CASE_NO_CHANGE = "(no changes)";
        public const string CASE_ALL_UPPER = "all upper case";
        public const string CASE_ALL_LOWER = "all lower case";
        public const string CASE_TITLE_CASE = "title case";

        public static async Task<Settings> ProcessFolder(string path, Settings settings)
        {
            try
            {
                if (settings.ProcessFiles)
                {
                    string[] fileNames = Directory.GetFiles(path);

#if DEBUG
                    foreach (var fileName in fileNames)
                    {
                        if (settings.FileTypes == FILE_FILTER_ALL_FILES || settings.FileTypes == Path.GetExtension(fileName))
                            await ProcessFilename(fileName, settings);
                    }
#else
                    Parallel.ForEach(fileNames, new ParallelOptions { MaxDegreeOfParallelism = 8 }, fileName =>
                    {
                        if (settings.FileTypes == FILE_FILTER_ALL_FILES || settings.FileTypes == Path.GetExtension(fileName))
                            ProcessFilename(fileName, settings);
                    });
#endif
                }

                // after all the files have been renamed, check and see if we need to build a play list of .mp3 files in directory.
                if (settings.CreatePlaylist)
                {
                    var sb = new StringBuilder();

                    string[] songs = Directory.GetFiles(path, "*.mp3");

                    if (songs.Length > 0)
                    {
                        string playlist = Path.Combine("~" + path.Substring(path.LastIndexOf('\\') + 1) + ".m3u");

                        foreach (string song in songs)
                            sb.AppendLine(song.Replace(path + "\\", string.Empty));

                        await FileIo.WriteToFile(path + "\\" + playlist, sb.ToString());
                        settings.ChangeList.Add("Created M3u file " + playlist);
                    }
                }

                string[] directories = Directory.GetDirectories(path);

                foreach (string directory in directories)
                {
                    // do this in reverse order, deepest directory first so upstream changes don't cause havoc.
                    if (settings.Recursive)
                        await ProcessFolder(directory, settings);

                    if (settings.ProcessDirectories)
                        await ProcessFoldername(directory, settings);
                }
            }
            catch (Exception ex)
            {
                settings.ErrorList.Add(ex.Message);
            }

            return settings;
        }

        private static async Task ProcessFoldername(string inputPath, Settings settings)
        {
            try
            {
                string inputDirectoryName = inputPath.Substring(inputPath.LastIndexOf('\\') + 1);
                string outputDirectoryName = inputDirectoryName;
                string currentPath = inputPath.Substring(0, inputPath.LastIndexOf('\\') + 1);

                if (settings.RemoveURL)
                    outputDirectoryName = HttpUtility.UrlDecode(outputDirectoryName);

                // main find and replace
                if (!string.IsNullOrEmpty(settings.Find))
                {
                    if (settings.UseRegex)
                    {
                        outputDirectoryName = Regex.Replace(outputDirectoryName, settings.Find, settings.Replace);
                    }
                    else
                    {
                        if (settings.CaseSensitive)
                            outputDirectoryName = outputDirectoryName.Replace(settings.Find, settings.Replace);
                        else
                            outputDirectoryName = ReplaceCaseInsensitive(outputDirectoryName, settings.Find, settings.Replace);
                    }
                }

                if (!string.IsNullOrWhiteSpace(settings.Prefix) || !string.IsNullOrWhiteSpace(settings.Suffix))
                    outputDirectoryName = settings.Prefix + outputDirectoryName + settings.Suffix;

                if (settings.RemoveSpace)
                {
                    while (outputDirectoryName.Contains("  "))
                        outputDirectoryName = outputDirectoryName.Replace("  ", " ");

                    outputDirectoryName = outputDirectoryName.Trim();
                }

                // do any changes of case here
                switch (settings.Case.ToLower())
                {
                    case CASE_ALL_LOWER: outputDirectoryName = outputDirectoryName.ToLower(); break;
                    case CASE_ALL_UPPER: outputDirectoryName = outputDirectoryName.ToUpper(); break;
                    case CASE_TITLE_CASE: outputDirectoryName = ToTitleCase(outputDirectoryName); break;

                    default:
                        // else do nothing.
                        break;
                }

                if (settings.RemoveLeadingCharacter > 0 && outputDirectoryName.Length > settings.RemoveLeadingCharacter)
                    outputDirectoryName = outputDirectoryName.Substring(settings.RemoveLeadingCharacter);

                if (settings.RemoveTrailingCharacter > 0 && outputDirectoryName.Length > settings.RemoveTrailingCharacter)
                    outputDirectoryName = outputDirectoryName.Substring(0, outputDirectoryName.Length - settings.RemoveTrailingCharacter);

                if (settings.MaxNameLength > 0 && outputDirectoryName.Length > settings.MaxNameLength)
                    outputDirectoryName = outputDirectoryName.Substring(0, settings.MaxNameLength);

                // make sure that the new directory name doesn't already exist.
                if (outputDirectoryName != inputDirectoryName && !string.IsNullOrEmpty(outputDirectoryName))
                {
                    outputDirectoryName = currentPath + outputDirectoryName;

                    if (Directory.Exists(outputDirectoryName) && (outputDirectoryName.ToLower() != inputPath.ToLower()))
                    {
                        settings.ErrorList.Add("Cannot rename " + inputPath + " -> " + outputDirectoryName + ", directory already exists.");
                        return;
                    }

                    await FileIo.RenameDirectory(inputPath, outputDirectoryName);
                    settings.ChangeList.Add(inputPath + " -> " + outputDirectoryName);
                }

                return;
            }
            catch (Exception ex)
            {
                settings.ErrorList.Add(ex.Message);
            }
        }

        private static async Task ProcessFilename(string inputPath, Settings settings)
        {
            if (string.IsNullOrWhiteSpace(inputPath))
                throw new Exception("File path is null or empty");

            if (!File.Exists(inputPath))
                throw new Exception($"File '{inputPath}' does not exist");

            if (settings == null)
                throw new Exception("Settings object is null");

            string input_filename = Path.GetFileName(inputPath);
            string output_path = Path.GetDirectoryName(inputPath);
            string output_filename = input_filename;

            try
            {
                // check to see if we need to reset file properties
                if (settings.FixFileProperties && File.GetAttributes(inputPath) != FileAttributes.Normal)
                    File.SetAttributes(inputPath, FileAttributes.Normal);

                // make sure we don't accidentally nuke file extension with changes
                if (settings.PreserveExtensions)
                    output_filename = Path.GetFileNameWithoutExtension(output_filename);

                if (settings.RemoveURL)
                    output_filename = HttpUtility.UrlDecode(output_filename);

                // main find and replace
                if (!string.IsNullOrEmpty(settings.Find))
                {
                    if (settings.UseRegex)
                    {
                        output_filename = Regex.Replace(output_filename, settings.Find, settings.Replace);
                    }
                    else
                    {
                        if (settings.CaseSensitive)
                            output_filename = output_filename.Replace(settings.Find, settings.Replace);
                        else
                            output_filename = ReplaceCaseInsensitive(output_filename, settings.Find, settings.Replace);
                    }
                }

                if (!string.IsNullOrWhiteSpace(settings.Prefix) || !string.IsNullOrWhiteSpace(settings.Suffix))
                    output_filename = settings.Prefix + output_filename + settings.Suffix;

                if (settings.RemoveSpace)
                {
                    while (output_filename.Contains("  "))
                        output_filename = output_filename.Replace("  ", " ");

                    string file_name = Path.GetFileNameWithoutExtension(output_filename).Trim();
                    string file_extension = Path.GetExtension(output_filename).Trim();

                    output_filename = file_name + file_extension;
                }

                // do any changes of case here
                switch (settings.Case.ToLower())
                {
                    case CASE_ALL_LOWER: output_filename = output_filename.ToLower(); break;
                    case CASE_ALL_UPPER: output_filename = output_filename.ToUpper(); break;
                    case CASE_TITLE_CASE: output_filename = ToTitleCase(output_filename); break;

                    default:
                        // else do nothing.
                        break;
                }

                if (settings.RemoveLeadingCharacter > 0 && Path.GetFileNameWithoutExtension(output_filename).Length > settings.RemoveLeadingCharacter)
                {
                    string file_name = Path.GetFileNameWithoutExtension(output_filename);
                    output_filename = file_name.Substring(settings.RemoveLeadingCharacter) + Path.GetExtension(output_filename);
                }

                if (settings.RemoveTrailingCharacter > 0 && Path.GetFileNameWithoutExtension(output_filename).Length > settings.RemoveTrailingCharacter)
                {
                    string file_name = Path.GetFileNameWithoutExtension(output_filename);
                    output_filename = file_name.Substring(0, file_name.Length - settings.RemoveTrailingCharacter) + Path.GetExtension(output_filename);
                }

                if (settings.MaxNameLength > 0 && Path.GetFileNameWithoutExtension(output_filename).Length > settings.MaxNameLength)
                {
                    string file_name = Path.GetFileNameWithoutExtension(output_filename);
                    output_filename = file_name.Substring(0, settings.MaxNameLength) + Path.GetExtension(output_filename);
                }

                // preserve file extension. this prevents any replacement operations or case changes to make things odd looking. 
                if (settings.PreserveExtensions)
                    output_filename = Path.GetFileNameWithoutExtension(output_filename) + Path.GetExtension(input_filename);

                // lowercase file extension
                if (settings.LowerExtensions)
                    output_filename = Path.GetFileNameWithoutExtension(output_filename) + Path.GetExtension(output_filename).ToLower();

                // any changes? If so, do the rename.
                if (input_filename != output_filename && !string.IsNullOrEmpty(output_filename))
                {
                    output_path += "\\" + output_filename;

                    // make sure that the new filename isn't already in use.
                    if (File.Exists(output_path) && (input_filename.ToLower() != output_filename.ToLower()))
                    {
                        settings.ErrorList.Add("Cannot rename " + inputPath + " -> " + output_path + ", file already exists.");
                        return;
                    }

                    await FileIo.RenameFile(inputPath, output_path);
                    settings.ChangeList.Add(inputPath + " -> " + output_path);
                }
            }
            catch (Exception ex)
            {
                settings.ErrorList.Add(string.Format("Cannot rename {0} -> {1}, exception: {2}", inputPath, output_path, ex.Message));
            }
        }

        private static string ToTitleCase(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] output = new char[input.Length];
            bool firstFlag = true;
            var ignoredChars = new char[] { ' ', '"', '~', '-', '.', '&', '(', ')', '{', '}', '[', ']' };

            // path might be of a full file path, such as 'c:\temp\stuff\foo.txt', we only want to process the file name.
            int lastCharacter = input.LastIndexOf(Path.GetExtension(input));

            if (lastCharacter == -1)
                lastCharacter = input.Length;

            int firstCharacter = input.LastIndexOf('\\');

            if (firstCharacter == -1)
                firstCharacter = 0;
            else if (firstCharacter < input.Length - 1)
                firstCharacter++;

            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i];
            }

            for (int i = firstCharacter; i < lastCharacter; i++)
            {
                if (char.IsLetter(input[i]) && i > 0 && ignoredChars.Contains(input[i - 1]))
                    firstFlag = true;

                if (firstFlag)
                {
                    // last character was a space. Uppercase
                    output[i] = Convert.ToChar(input[i].ToString().ToUpper());
                    firstFlag = false;
                }
                else
                {
                    output[i] = input[i];
                }
            }

            return new string(output);
        }

        private static string ReplaceCaseInsensitive(string input, string pattern, string replacement)
        {
            // fast case insensitive string replacement 
            // http://www.codeproject.com/KB/string/fastestcscaseinsstringrep.aspx

            // make sure we have valid input 
            if (input.Length == 0 || pattern.Length == 0)
                return input;

            int count = 0;
            int position0 = 0;
            int position1 = 0;
            string upper_string = input.ToUpper();
            string upper_pattern = pattern.ToUpper();

            int inc = (input.Length / pattern.Length) * (replacement.Length - pattern.Length);

            char[] chars = new char[input.Length + Math.Max(0, inc)];

            while ((position1 = upper_string.IndexOf(upper_pattern, position0)) != -1)
            {
                for (int i = position0; i < position1; ++i)
                    chars[count++] = input[i];

                for (int i = 0; i < replacement.Length; ++i)
                    chars[count++] = replacement[i];

                position0 = position1 + pattern.Length;
            }

            if (position0 == 0)
                return input;

            for (int i = position0; i < input.Length; ++i)
                chars[count++] = input[i];

            return new string(chars, 0, count);
        }

        public static async Task<Settings> RunScript(string scriptPath, Settings settings)
        {
            var script_instructions = File.ReadAllLines(scriptPath);

            foreach (var line in script_instructions)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string buffer = line.Trim();

                    if (buffer[0] == '#')
                        continue;

                    ParseInstruction(buffer, out string instruction, out string[] arguments);

                    switch (instruction)
                    {
                        // configuration settings
                        case "setcasesensitive": settings.CaseSensitive = bool.Parse(arguments[0]); break;
                        case "setlogchanges": settings.LogChanges = bool.Parse(arguments[0]); break;
                        case "setlowerextensions": settings.LowerExtensions = bool.Parse(arguments[0]); break;
                        case "setrecursive": settings.Recursive = bool.Parse(arguments[0]); break;
                        case "setremoveleadingcharacter": settings.RemoveLeadingCharacter = int.Parse(arguments[0]); break;
                        case "setremovetrailingcharacter": settings.RemoveTrailingCharacter = int.Parse(arguments[0]); break;
                        case "setremovespace": settings.RemoveSpace = bool.Parse(arguments[0]); break;
                        case "setremoveurl": settings.RemoveURL = bool.Parse(arguments[0]); break;
                        case "setuseregex": settings.UseRegex = bool.Parse(arguments[0]); break;
                        case "setcreateplaylist": settings.CreatePlaylist = bool.Parse(arguments[0]); break;
                        case "setfixfileproperties": settings.FixFileProperties = bool.Parse(arguments[0]); break;
                        case "setprocessdirectories": settings.ProcessDirectories = bool.Parse(arguments[0]); break;
                        case "setprocessfiles": settings.ProcessFiles = bool.Parse(arguments[0]); break;
                        case "setmaxnamelength": settings.MaxNameLength = int.Parse(arguments[0]); break;

                        // to-do - fix quotes in parse instructions?

                        case "setfiletypes": settings.FileTypes = arguments[0]; break;
                        case "setcase": settings.Case = arguments[0]; break;
                        case "setfind": settings.Find = arguments[0]; break;
                        case "setreplace": settings.Replace = arguments[0]; break;
                        case "setprefix": settings.Prefix = arguments[0]; break;
                        case "setsuffix": settings.Suffix = arguments[0]; break;
                        case "setpath": settings.Path = arguments[0]; break;

                        // instructions
                        case "replace":

                            settings.Find = arguments[0];
                            settings.Replace = arguments[1];

                            await ProcessFolder(settings.Path, settings);

                            break;

                        case "remove":

                            settings.Find = arguments[0];
                            settings.Replace = string.Empty;

                            await ProcessFolder(settings.Path, settings);

                            break;

                        default:
                            throw new Exception(string.Format($"Unrecognized instruction '{instruction}'"));
                    }
                }
                catch (Exception ex)
                {
                    settings.ErrorList.Add(string.Format($"Exception encountered: {ex.Message}"));
                    continue;
                }
            }

            return settings;
        }

        public static void ParseInstruction(string input, out string instruction, out string[] arguments)
        {
            // pareses an input string that looks like: DoSomething('foo','bar')

            instruction = string.Empty;
            arguments = new string[0];

            int start = input.IndexOf('(');

            if (start == -1)
                throw new Exception("Syntax error, instruction has unbalanced argument brackets");

            int end = input.LastIndexOf(')');

            if (end == -1)
                throw new Exception("Syntax error, instruction has unbalanced argument brackets");

            instruction = input.Substring(0, start).ToLower().Trim();

            // advance one character so we don't include the '('
            start++;

            string buffer = input.Substring(start, end - start);
            buffer = buffer.Replace("\"", string.Empty);
            buffer = buffer.Replace("'", string.Empty);
            arguments = buffer.Split(new char[] { ',' });
        }

        public static void WriteToFile(string filePath, string outputData)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new Exception("file path cannot be null or empty");

            if (outputData == null)
                throw new Exception("Output data cannot be null");

            // Does directory exist?
            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            // Are attributes set properly?
            if (File.Exists(filePath) && File.GetAttributes(filePath) != FileAttributes.Normal)
                File.SetAttributes(filePath, FileAttributes.Normal);

            File.WriteAllText(filePath, outputData);
        }

        /// <summary>
        /// Gets all the file names in a directory path and breaks all the unique words in the name into a single list
        /// </summary>
        public static string[] BreakFilenames(string path, bool recursive)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path cannot be null or empty");

            var options = (recursive) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            var files = Directory.GetFiles(path, "*", options);
            var output = new HashSet<string>();

            foreach (var file in files)
            {
                var buffer = Path.GetFileName(file);
                var fragments = buffer.Split(new char[] { '.', ' ', '-', '[', ']', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var fragment in fragments)
                    output.Add(fragment);
            }

            return output.OrderBy(x => x).ToArray();
        }
    }
}
