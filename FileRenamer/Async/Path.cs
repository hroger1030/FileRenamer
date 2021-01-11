using System.Security;
using System.Threading.Tasks;

namespace System.IO.Async
{
    /// <summary>
    /// Performs operations on System.String instances that contain file or directory
    /// path information. These operations are performed in a cross-platform manner.
    /// </summary>
    public static class PathAsync
    {
        /// <summary>
        /// Provides a platform-specific character used to separate directory levels in a
        /// path string that reflects a hierarchical file system organization.
        /// </summary>
        public static char DirectorySeparatorChar => Path.DirectorySeparatorChar;

        /// <summary>
        /// Provides a platform-specific alternate character used to separate directory levels
        /// in a path string that reflects a hierarchical file system organization.    
        /// </summary>
        public static char AltDirectorySeparatorChar => Path.AltDirectorySeparatorChar;

        /// <summary>
        /// Provides a platform-specific volume separator character.
        /// </summary>
        public static char VolumeSeparatorChar => Path.VolumeSeparatorChar;

        /// <summary>
        /// Provides a platform-specific array of characters that cannot be specified in
        /// path string arguments passed to members of the System.IO.Path class.
        /// </summary>
        [Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public static char[] InvalidPathChars => Path.InvalidPathChars;

        /// <summary>
        /// A platform-specific separator character used to separate path strings in environment
        /// variables.
        /// </summary>
        public static char PathSeparator => Path.PathSeparator;

        /// <summary>
        ///  Changes the extension of a path string.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path information to modify. The path cannot contain any of the characters
        ///     defined in System.IO.Path.GetInvalidPathChars.
        ///
        ///   extension:
        ///     The new extension (with or without a leading period). Specify null to remove
        ///     an existing extension from path.
        ///
        /// Returns:
        ///     The modified path information. On Windows-based desktop platforms, if path is
        ///     null or an empty string (""), the path information is returned unmodified. If
        ///     extension is null, the returned string contains the specified path with its extension
        ///     removed. If path has no extension, and extension is not null, the returned path
        ///     string contains extension appended to the end of path.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        public static async Task<string> ChangeExtension(string path, string extension)
        {
            return await Task.Run(() => { return Path.ChangeExtension(path, extension); });
        }

        /// <summary>
        /// Combines three strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <param name="path3">The third path to combine.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">path1, path2, or path3 contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.</exception>
        /// <exception cref="ArgumentNullException">path1, path2, or path3 is null.</exception>
        public static async Task<string> Combine(string path1, string path2, string path3)
        {
            return await Task.Run(() => { return Path.Combine(path1, path2, path3); });
        }

        /// <summary>
        /// Combines two strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">path1 or path2 contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.</exception>
        /// <exception cref="ArgumentNullException">path1 or path2 is null.</exception>
        public static async Task<string> Combine(string path1, string path2)
        {
            return await Task.Run(() => { return Path.Combine(path1, path2); });
        }

        /// <summary>
        ///     Combines four strings into a path.
        /// </summary>
        /// Parameters:
        ///   path1:
        ///     The first path to combine.
        ///
        ///   path2:
        ///     The second path to combine.
        ///
        ///   path3:
        ///     The third path to combine.
        ///
        ///   path4:
        ///     The fourth path to combine.
        ///
        /// Returns:
        ///     The combined paths.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path1, path2, path3, or path4 contains one or more of the invalid characters
        ///     defined in System.IO.Path.GetInvalidPathChars.
        ///
        ///   T:System.ArgumentNullException:
        ///     path1, path2, path3, or path4 is null.
        public static async Task<string> Combine(string path1, string path2, string path3, string path4)
        {
            return await Task.Run(() => { return Path.Combine(path1, path2, path3, path4); });
        }

        /// <summary>
        ///     Combines an array of strings into a path.
        /// </summary>
        /// Parameters:
        ///   paths:
        ///     An array of parts of the path.
        ///
        /// Returns:
        ///     The combined paths.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     One of the strings in the array contains one or more of the invalid characters
        ///     defined in System.IO.Path.GetInvalidPathChars.
        ///
        ///   T:System.ArgumentNullException:
        ///     One of the strings in the array is null.
        public static async Task<string> Combine(params string[] paths)
        {
            return await Task.Run(() => { return Path.Combine(paths); });
        }

        /// <summary>
        ///     Returns the directory information for the specified path string.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path of a file or directory.
        ///
        /// Returns:
        ///     Directory information for path, or null if path denotes a root directory or is
        ///     null. Returns System.String.Empty if path does not contain directory information.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     The path parameter contains invalid characters, is empty, or contains only white
        ///     spaces.
        ///
        ///   T:System.IO.PathTooLongException:
        ///     In the .NET for Windows Store apps or the Portable Class Library, catch the base
        ///     class exception, System.IO.IOException, instead. The path parameter is longer
        ///     than the system-defined maximum length.
        public static async Task<string> GetDirectoryName(string path)
        {
            return await Task.Run(() => { return Path.GetDirectoryName(path); });
        }

        ///
        /// <summary>
        ///     Returns the extension of the specified path string.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path string from which to get the extension.
        ///
        /// Returns:
        ///     The extension of the specified path (including the period "."), or null, or System.String.Empty.
        ///     If path is null, System.IO.Path.GetExtension(System.String) returns null. If
        ///     path does not have extension information, System.IO.Path.GetExtension(System.String)
        ///     returns System.String.Empty.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        public static async Task<string> GetExtension(string path)
        {
            return await Task.Run(() => { return Path.GetExtension(path); });
        }

        ///
        /// <summary>
        ///     Returns the file name and extension of the specified path string.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path string from which to obtain the file name and extension.
        ///
        /// Returns:
        ///     The characters after the last directory character in path. If the last character
        ///     of path is a directory or volume separator character, this method returns System.String.Empty.
        ///     If path is null, this method returns null.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        public static async Task<string> GetFileName(string path)
        {
            return await Task.Run(() => { return Path.GetFileName(path); });
        }

        ///
        /// <summary>
        ///     Returns the file name of the specified path string without the extension.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path of the file.
        ///
        /// Returns:
        ///     The string returned by System.IO.Path.GetFileName(System.String), minus the last
        ///     period (.) and all characters following it.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        public static async Task<string> GetFileNameWithoutExtension(string path)
        {
            return await Task.Run(() => { return Path.GetFileNameWithoutExtension(path); });
        }

        ///
        /// <summary>
        ///     Returns the absolute path for the specified path string.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The file or directory for which to obtain absolute path information.
        ///
        /// Returns:
        ///     The fully qualified location of path, such as "C:\MyFile.txt".
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path is a zero-length string, contains only white space, or contains one or more
        ///     of the invalid characters defined in System.IO.Path.GetInvalidPathChars. -or-
        ///     The system could not retrieve the absolute path.
        ///
        ///   T:System.Security.SecurityException:
        ///     The caller does not have the required permissions.
        ///
        ///   T:System.ArgumentNullException:
        ///     path is null.
        ///
        ///   T:System.NotSupportedException:
        ///     path contains a colon (":") that is not part of a volume identifier (for example,
        ///     "c:\").
        ///
        ///   T:System.IO.PathTooLongException:
        ///     The specified path, file name, or both exceed the system-defined maximum length.
        //[SecuritySafeCritical]
        public static async Task<string> GetFullPath(string path)
        {
            return await Task.Run(() => { return Path.GetFullPath(path); });
        }

        ///
        /// <summary>
        ///     Gets an array containing the characters that are not allowed in file names.
        /// </summary>
        /// Returns:
        ///     An array containing the characters that are not allowed in file names.
        public static async Task<char[]> GetInvalidFileNameChars()
        {
            return await Task.Run(() => { return Path.GetInvalidFileNameChars(); });
        }

        ///
        /// <summary>
        ///     Gets an array containing the characters that are not allowed in path names.
        /// </summary>
        /// Returns:
        ///     An array containing the characters that are not allowed in path names.
        public static async Task<char[]> GetInvalidPathChars()
        {
            return await Task.Run(() => { return Path.GetInvalidPathChars(); });
        }

        ///
        /// <summary>
        ///     Gets the root directory information of the specified path.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path from which to obtain root directory information.
        ///
        /// Returns:
        ///     The root directory of path, or null if path is null, or an empty string if path
        ///     does not contain root directory information.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        ///     -or- System.String.Empty was passed to path.
        public static async Task<string> GetPathRoot(string path)
        {
            return await Task.Run(() => { return Path.GetPathRoot(path); });
        }

        ///
        /// <summary>
        ///     Returns a random folder name or file name.
        /// </summary>
        /// Returns:
        ///     A random folder name or file name.
        public static async Task<string> GetRandomFileName()
        {
            return await Task.Run(() => { return Path.GetRandomFileName(); });
        }

        ///
        /// <summary>
        ///     Creates a uniquely named, zero-byte temporary file on disk and returns the full
        ///     path of that file.
        /// </summary>
        /// Returns:
        ///     The full path of the temporary file.
        ///
        /// Exceptions:
        ///   T:System.IO.IOException:
        ///     An I/O error occurs, such as no unique temporary file name is available. -or-
        ///     This method was unable to create a temporary file.
        //[SecuritySafeCritical]
        public static async Task<string> GetTempFileName()
        {
            return await Task.Run(() => { return Path.GetTempFileName(); });
        }

        ///
        /// <summary>
        ///     Returns the path of the current user's temporary folder.
        /// </summary>
        /// Returns:
        ///     The path to the temporary folder, ending with a backslash.
        ///
        /// Exceptions:
        ///   T:System.Security.SecurityException:
        ///     The caller does not have the required permissions.
        //[SecuritySafeCritical]
        public static async Task<string> GetTempPath()
        {
            return await Task.Run(() => { return Path.GetTempPath(); });
        }

        ///
        /// <summary>
        ///     Determines whether a path includes a file name extension.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path to search for an extension.
        ///
        /// Returns:
        ///     true if the characters that follow the last directory separator (\\ or /) or
        ///     volume separator (:) in the path include a period (.) followed by one or more
        ///     characters; otherwise, false.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        public static async Task<bool> HasExtension(string path)
        {
            return await Task.Run(() => { return Path.HasExtension(path); });
        }

        ///
        /// <summary>
        ///     Gets a value indicating whether the specified path string contains a root.
        /// </summary>
        /// Parameters:
        ///   path:
        ///     The path to test.
        ///
        /// Returns:
        ///     true if path contains a root; otherwise, false.
        ///
        /// Exceptions:
        ///   T:System.ArgumentException:
        ///     path contains one or more of the invalid characters defined in System.IO.Path.GetInvalidPathChars.
        public static async Task<bool> IsPathRooted(string path)
        {
            return await Task.Run(() => { return Path.IsPathRooted(path); });
        }
    }
}