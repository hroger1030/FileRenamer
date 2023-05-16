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

namespace FileRenamer
{
    public class Settings : RenameResults
    {
        public bool CaseSensitive { get; set; }
        public bool LogChanges { get; set; }
        public bool LowerExtensions { get; set; }
        public bool PreserveExtensions { get; set; }
        public bool Recursive { get; set; }
        public int RemoveLeadingCharacter { get; set; }
        public int RemoveTrailingCharacter { get; set; }
        public bool RemoveSpace { get; set; }
        public bool RemoveURL { get; set; }
        public bool UseRegex { get; set; }
        public bool CreatePlaylist { get; set; }
        public bool FixFileProperties { get; set; }
        public bool ProcessFiles { get; set; }
        public bool ProcessDirectories { get; set; }
        public int MaxNameLength { get; set; }

        public string FileTypes { get; set; }
        public string Case { get; set; } = FileRenamer.CASE_NO_CHANGE;
        public string Find { get; set; }
        public string Replace { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Path { get; set; }
        public string ScriptPath { get; set; }
    }
}
