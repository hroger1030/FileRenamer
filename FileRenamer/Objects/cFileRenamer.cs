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
    public class cFileRenamer
    {
        public const string FILE_FILTER_ALL_FILES = "(all files)";
        public const string CASE_NO_CHANGE = "(no changes)";
        public const string CASE_ALL_UPPER = "all upper case";
        public const string CASE_ALL_LOWER = "all lower case";
        public const string CASE_TITLE_CASE = "title case";

        public static void ProcessFolder(string path, cSettings settings)
        {
            try
            {
                if (settings.ProcessFiles)
                {
                    string[] file_names = Directory.GetFiles(path);

                    Parallel.ForEach(file_names, new ParallelOptions { MaxDegreeOfParallelism = 8 }, file_name =>
                    {
                        // process files matching our filter criteria
                        if (settings.FileTypes == FILE_FILTER_ALL_FILES || settings.FileTypes == Path.GetExtension(file_name))
                            ProcessFilename(file_name, settings);
                    });
                }

                // after all the files have been renamed, check and see if we need to build a playlist of .mp3 files in directory.
                if (settings.CreatePlaylist)
                {
                    var sb = new StringBuilder();

                    string[] music_files = Directory.GetFiles(path, "*.mp3");

                    if (music_files.Length > 0)
                    {
                        string playlist_name = Path.Combine("~" + path.Substring(path.LastIndexOf('\\') + 1) + ".m3u");

                        // format all the mp3 filenames correctly
                        foreach (string music_file in music_files)
                        {
                            sb.AppendLine(music_file.Replace(path + "\\", string.Empty));
                            FileIo.WriteToFile(path + "\\" + playlist_name, sb.ToString());
                        }
                        settings.ChangeList.Add("Created M3u file " + playlist_name);
                    }
                }

                string[] folder_names = Directory.GetDirectories(path);

                foreach (string folder_name in folder_names)
                {
                    // do this in reverse order, deepest directory first so upstream changes don't cause havok.
                    if (settings.Recursive)
                        ProcessFolder(folder_name, settings);

                    if (settings.ProcessDirectories)
                        ProcessFoldername(folder_name, settings);
                }
            }
            catch (Exception ex)
            {
                settings.ErrorList.Add(ex.Message);
            }
        }

        private static void ProcessFoldername(string inputPath, cSettings settings)
        {
            try
            {
                string input_directory_name = inputPath.Substring(inputPath.LastIndexOf('\\') + 1);
                string output_directory_name = input_directory_name;
                string current_path = inputPath.Substring(0, inputPath.LastIndexOf('\\') + 1);

                if (settings.RemoveURL)
                    output_directory_name = HttpUtility.UrlDecode(output_directory_name);

                // main find and replace
                if (!string.IsNullOrEmpty(settings.Find))
                {
                    if (settings.UseRegex)
                    {
                        output_directory_name = Regex.Replace(output_directory_name, settings.Find, settings.Replace);
                    }
                    else
                    {
                        if (settings.CaseSensitive)
                            output_directory_name = output_directory_name.Replace(settings.Find, settings.Replace);
                        else
                            output_directory_name = ReplaceCaseInsensitive(output_directory_name, settings.Find, settings.Replace);
                    }
                }

                if (!string.IsNullOrWhiteSpace(settings.Prefix) || !string.IsNullOrWhiteSpace(settings.Suffix))
                    output_directory_name = settings.Prefix + output_directory_name + settings.Suffix;

                if (settings.RemoveSpace)
                {
                    while (output_directory_name.Contains("  "))
                        output_directory_name = output_directory_name.Replace("  ", " ");

                    output_directory_name = output_directory_name.Trim();
                }

                // do any changes of case here
                switch (settings.Case.ToLower())
                {
                    case CASE_ALL_LOWER: output_directory_name = output_directory_name.ToLower(); break;
                    case CASE_ALL_UPPER: output_directory_name = output_directory_name.ToUpper(); break;
                    case CASE_TITLE_CASE: output_directory_name = ToTitleCase(output_directory_name); break;

                    default:
                        // else do nothing.
                        break;
                }

                if (settings.RemoveLeadingCharacter > 0 && output_directory_name.Length > settings.RemoveLeadingCharacter)
                    output_directory_name = output_directory_name.Substring(settings.RemoveLeadingCharacter);

                if (settings.RemoveTrailingCharacter > 0 && output_directory_name.Length > settings.RemoveTrailingCharacter)
                    output_directory_name = output_directory_name.Substring(0, output_directory_name.Length - settings.RemoveTrailingCharacter);

                if (settings.MaxNameLength > 0 && output_directory_name.Length > settings.MaxNameLength)
                    output_directory_name = output_directory_name.Substring(0, settings.MaxNameLength);

                // make sure that the new directory name doesn't already exist.
                if (output_directory_name != input_directory_name && !string.IsNullOrEmpty(output_directory_name))
                {
                    output_directory_name = current_path + output_directory_name;

                    if (Directory.Exists(output_directory_name) && (output_directory_name.ToLower() != inputPath.ToLower()))
                    {
                        settings.ErrorList.Add("Cannot rename " + inputPath + " -> " + output_directory_name + ", directory already exists.");
                        return;
                    }

                    FileIo.RenameDirectory(inputPath, output_directory_name);
                    settings.ChangeList.Add(inputPath + " -> " + output_directory_name);
                }

                return;
            }
            catch (Exception ex)
            {
                settings.ErrorList.Add(ex.Message);
            }
        }

        private static void ProcessFilename(string inputPath, cSettings settings)
        {
            if (string.IsNullOrWhiteSpace(inputPath))
                throw new Exception("File path is null or empty");

            if (!File.Exists(inputPath))
                throw new Exception(string.Format("File '{0}' does not exist", inputPath));

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

                // make sure we dont accidentally nuke file extension with changes
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

                    FileIo.RenameFile(inputPath, output_path);
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
            bool first_char_flag = true;
            var ignored_chars = new char[] { ' ', '"', '~', '-', '.', '&', '(', ')', '{', '}', '[', ']' };

            // path might be of a full file path, such as 'c:\temp\stuff\foo.txt', we only want to process the file name.
            int last_character_to_process = input.LastIndexOf(Path.GetExtension(input));

            if (last_character_to_process == -1)
                last_character_to_process = input.Length;

            int first_character_to_process = input.LastIndexOf('\\');

            if (first_character_to_process == -1)
                first_character_to_process = 0;
            else if (first_character_to_process < input.Length - 1)
                first_character_to_process++;

            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = input[i];
            }

            for (int i = first_character_to_process; i < last_character_to_process; i++)
            {
                if (Char.IsLetter(input[i]) && i > 0 && ignored_chars.Contains(input[i - 1]))
                    first_char_flag = true;

                if (first_char_flag)
                {
                    // last character was a space. Uppercase
                    output[i] = Convert.ToChar(input[i].ToString().ToUpper());
                    first_char_flag = false;
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

        public static void RunScript(string scriptPath, ref cSettings settings)
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

                    string instruction;
                    string[] arguments;

                    ParseInstruction(buffer, out instruction, out arguments);

                    switch (instruction)
                    {
                        // configuration settings
                        case "setcasesensitive": settings.CaseSensitive = Boolean.Parse(arguments[0]); break;
                        case "setlogchanges": settings.LogChanges = Boolean.Parse(arguments[0]); break;
                        case "setlowerextensions": settings.LowerExtensions = Boolean.Parse(arguments[0]); break;
                        case "setrecursive": settings.Recursive = Boolean.Parse(arguments[0]); break;
                        case "setremoveleadingcharacter": settings.RemoveLeadingCharacter = int.Parse(arguments[0]); break;
                        case "setremovetrailingcharacter": settings.RemoveTrailingCharacter = int.Parse(arguments[0]); break;
                        case "setremovespace": settings.RemoveSpace = Boolean.Parse(arguments[0]); break;
                        case "setremoveurl": settings.RemoveURL = Boolean.Parse(arguments[0]); break;
                        case "setuseregex": settings.UseRegex = Boolean.Parse(arguments[0]); break;
                        case "setcreateplaylist": settings.CreatePlaylist = Boolean.Parse(arguments[0]); break;
                        case "setfixfileproperties": settings.FixFileProperties = Boolean.Parse(arguments[0]); break;
                        case "setprocessdirectories": settings.ProcessDirectories = Boolean.Parse(arguments[0]); break;
                        case "setprocessfiles": settings.ProcessFiles = Boolean.Parse(arguments[0]); break;
                        case "setmaxnamelength": settings.MaxNameLength = int.Parse(arguments[0]); break;

                        // todo - fix quotes in parse instructions?

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

                            ProcessFolder(settings.Path, settings);

                            break;

                        case "remove":

                            settings.Find = arguments[0];
                            settings.Replace = string.Empty;

                            ProcessFolder(settings.Path, settings);

                            break;

                        default:
                            throw new Exception(string.Format("Unrecognized instruction '{0}'", instruction));
                    }
                }
                catch (Exception ex)
                {
                    settings.ErrorList.Add(string.Format("Exception encountered: {0}", ex.Message));
                    continue;
                }
            }
        }

        private static void ParseInstruction(string input, out string instruction, out string[] arguments)
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

            // advance one character so we dont include the '('
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
        /// Gets all the file names in a directory path
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
