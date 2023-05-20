/*
The MIT License (MIT)

Copyright (c) 2007 Roger Hill

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files 
(the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, 
publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do 
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE 
FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN 
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AutoCodeGenLibrary
{
    public static class FileIo
    {
        /// <summary>
        /// This method writes a string to disk. Overwrites any files with same name an path that already exist.
        /// </summary>
        public static async Task WriteToFile(string filePath, string outputData)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty");

            if (outputData == null)
                throw new ArgumentException("File path cannot be null");

            await Task.Run(async () =>
            {
                string directoryName = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(directoryName))
                    Directory.CreateDirectory(directoryName);

                if (File.Exists(filePath) && File.GetAttributes(filePath) != FileAttributes.Normal)
                    File.SetAttributes(filePath, FileAttributes.Normal);

                File.WriteAllText(filePath, outputData);

                using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var bytes = Encoding.UTF8.GetBytes(outputData);
                    await stream.WriteAsync(bytes);
                }
            });
        }

        /// <summary>
        /// This method writes a collection of strings to disk. Overwrites any files with same name an path that already exist.
        /// </summary>
        public static async Task WriteToFile(string filePath, IEnumerable<string> outputData)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty");

            if (await ContainsInvalidCharacters(filePath))
                throw new ArgumentException("File path contains one or more invalid characters");

            if (outputData == null)
                throw new ArgumentException("File path cannot be null");

            await Task.Run(async () =>
            {
                string directoryName = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(directoryName))
                    Directory.CreateDirectory(directoryName);

                if (File.Exists(filePath) && File.GetAttributes(filePath) != FileAttributes.Normal)
                    File.SetAttributes(filePath, FileAttributes.Normal);

                using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    foreach (var line in outputData)
                    {
                        var bytes = Encoding.UTF8.GetBytes(line + Environment.NewLine);
                        await stream.WriteAsync(bytes);
                    }
                }
            });
        }

        /// <summary>
        /// This method writes a byte array to disk. Overwrites any files with same name an path that already exist.
        /// </summary>
        public static async Task WriteToFile(string filePath, byte[] bytes)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty");

            if (bytes == null)
                throw new ArgumentException("Bytes cannot be null");

            await Task.Run(async () =>
            {
                string directory_name = Path.GetDirectoryName(filePath);

                if (!Directory.Exists(directory_name))
                    Directory.CreateDirectory(directory_name);

                if (File.Exists(filePath) && File.GetAttributes(filePath) != FileAttributes.Normal)
                    File.SetAttributes(filePath, FileAttributes.Normal);

                using (var stream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                    await stream.WriteAsync(bytes);
            });
        }

        /// <summary>
        /// Method to move files that overwrites any existing files.
        /// </summary>
        public static async Task MoveFile(string filePath, string fileDestination)
        {
            if (string.IsNullOrWhiteSpace(filePath))
                throw new ArgumentException("File path cannot be null or empty");

            if (!File.Exists(filePath))
                throw new ArgumentException("File does not exist");

            if (string.IsNullOrWhiteSpace(fileDestination))
                throw new ArgumentException("Destination path cannot be null or empty");

            await Task.Run(() =>
            {
                string directory_name = Path.GetDirectoryName(fileDestination);

                if (!Directory.Exists(directory_name))
                    Directory.CreateDirectory(directory_name);

                if (File.Exists(fileDestination))
                {

                    if (File.GetAttributes(fileDestination) != FileAttributes.Normal)
                        File.SetAttributes(fileDestination, FileAttributes.Normal);

                    File.Delete(fileDestination);

                }

                Directory.Move(filePath, fileDestination);
            });
        }

        /// <summary>
        /// Deletes a file.
        /// </summary>
        public static async Task DeleteFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new ArgumentException("File does not exist");

            await Task.Run(() =>
            {
                if (File.GetAttributes(filePath) != FileAttributes.Normal)
                    File.SetAttributes(filePath, FileAttributes.Normal);

                File.Delete(filePath);
            });
        }

        /// <summary>
        /// Mimics renaming a file in the file system. 
        /// </summary>
        /// <param name="oldFilePath">source file name</param>
        /// <param name="newFilePath">new file name</param>
        public static async Task RenameFile(string oldFilePath, string newFilePath)
        {
            if (string.IsNullOrWhiteSpace(oldFilePath))
                throw new ArgumentException("Old path cannot be null or empty");

            if (string.IsNullOrWhiteSpace(newFilePath))
                throw new ArgumentException("New path cannot be null or empty");

            await Task.Run(() =>
            {
                // changes that are only filename case related need special treatment
                if (oldFilePath.ToLower() == newFilePath.ToLower())
                {
                    string tempName = GenerateTemporaryFilename(Path.GetDirectoryName(oldFilePath));

                    File.Move(oldFilePath, tempName);
                    File.Move(tempName, newFilePath);
                }
                else
                {
                    File.Move(oldFilePath, newFilePath);
                }
            });
        }

        /// <summary>
        /// Renames a directory the file system. 
        /// </summary>
        public static async Task RenameDirectory(string oldDirectoryPath, string newDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(oldDirectoryPath))
                throw new ArgumentException("Old directory name cannot be null or empty");

            if (string.IsNullOrWhiteSpace(newDirectoryPath))
                throw new ArgumentException("New directory name cannot be null or empty");

            if (!Directory.Exists(oldDirectoryPath))
                throw new ArgumentException($"No directory named '{oldDirectoryPath}' exists");

            if (Directory.Exists(newDirectoryPath))
                throw new ArgumentException($"A directory named '{newDirectoryPath}' already exists");

            await Task.Run(() =>
            {
                if (oldDirectoryPath.ToLower() == newDirectoryPath.ToLower())
                {
                    string tempName = GenerateTemporaryDirectoryname(oldDirectoryPath);

                    Directory.Move(oldDirectoryPath, tempName);
                    Directory.Move(tempName, newDirectoryPath);
                }
                else
                {
                    Directory.Move(oldDirectoryPath, newDirectoryPath);
                }
            });
        }

        /// <summary>
        /// Function copies a entire directory's content into a new directory, creating it if it does not exist.
        /// </summary>
        public static async Task CopyDirectory(string sourceDirectory, string destinationDirectory)
        {
            if (string.IsNullOrWhiteSpace(sourceDirectory))
                throw new ArgumentException("Source directory name cannot be null or empty");

            if (string.IsNullOrWhiteSpace(destinationDirectory))
                throw new ArgumentException("New directory name cannot be null or empty");

            if (!Directory.Exists(sourceDirectory))
                throw new ArgumentException($"No directory named '{sourceDirectory}' exists");

            if (Directory.Exists(destinationDirectory))
                throw new ArgumentException($"A directory named '{destinationDirectory}' already exists");

            if (!Directory.Exists(destinationDirectory))
                Directory.CreateDirectory(destinationDirectory);

            await Task.Run(async () =>
            {
                // Recursively add subdirectories
                foreach (string subdirectory in Directory.GetDirectories(sourceDirectory))
                {
                    string destination = subdirectory.Replace(sourceDirectory, destinationDirectory);
                    await CopyDirectory(subdirectory, destination);
                }

                // copy all files 
                foreach (string file in Directory.GetFiles(sourceDirectory))
                {
                    string newFile = file.Replace(sourceDirectory, destinationDirectory);

                    if (File.Exists(newFile) && File.GetAttributes(newFile) != FileAttributes.Normal)
                        File.SetAttributes(newFile, FileAttributes.Normal);

                    File.Copy(file, newFile, true);
                }
            });
        }

        /// <summary>
        /// Deletes all files and subdirectories in a tree.
        /// </summary>
        public static async Task DeleteDirectoryTree(string directory)
        {
            if (!Directory.Exists(directory))
                throw new ArgumentException("Directory does not exist");

            await Task.Run(() =>
            {
                var files = Directory.GetFiles(directory);

                foreach (string fileName in files)
                {
                    if (File.GetAttributes(fileName) != FileAttributes.Normal)
                        File.SetAttributes(fileName, FileAttributes.Normal);

                    File.Delete(fileName);
                }

                Directory.Delete(directory, true);
            });
        }

        /// <summary>
        /// Determines if a string contains characters are invalid to be used as a path.
        /// </summary>
        public static async Task<bool> ContainsInvalidPathCharacters(string input)
        {
            return await Task.Run(() =>
            {
                return input.IndexOfAny(Path.GetInvalidPathChars()) != -1;
            });
        }

        /// <summary>
        /// Determines if a string contains characters that are invalid to be used as a file name.
        /// </summary>
        public static async Task<bool> ContainsInvalidFileNameCharacters(string input)
        {
            return await Task.Run(() =>
            {
                return input.IndexOfAny(Path.GetInvalidFileNameChars()) != -1;
            });
        }

        /// <summary>
        /// Determines if a full path contains characters that are invalid in either the path or
        /// file name.
        /// </summary>
        public static async Task<bool> ContainsInvalidCharacters(string input)
        {
            try
            {
                string path = Path.GetDirectoryName(input);
                string file = Path.GetFileName(input);

                if (await ContainsInvalidPathCharacters(path))
                    return true;

                if (await ContainsInvalidFileNameCharacters(file))
                    return true;
            }
            catch (ArgumentException ex)
            {
                if (ex.Message == "Illegal characters in path.")
                    return true;
                else
                    throw;
            }

            return false;
        }

        /// <summary>
        /// Generates a random unique name for a file in a given directory.
        /// </summary>
        public static string GenerateTemporaryFilename(string path)
        {
            string tempName = Path.Combine(path, Path.GetRandomFileName());

            while (File.Exists(tempName))
                tempName = Path.Combine(path, Path.GetRandomFileName());

            return tempName;
        }

        /// <summary>
        /// Generates a random unique name for a given directory.
        /// </summary>
        public static string GenerateTemporaryDirectoryname(string path)
        {
            string tempName = string.Empty;

            while (File.Exists(tempName))
                tempName = path + Guid.NewGuid().ToString("N");

            return tempName;
        }
    }
}
