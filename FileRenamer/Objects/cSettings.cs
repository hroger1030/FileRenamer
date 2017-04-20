using System;
using System.Collections.Generic;

namespace FileRenamer
{
    public class cSettings
    {
        public bool CaseSensitive;
        public bool LogChanges;
        public bool LowerExtensions;
        public bool PreserveExtensions;
        public bool Recursive;
        public int RemoveLeadingCharacter;
        public int RemoveTrailingCharacter;
        public bool RemoveSpace;
        public bool RemoveURL;
        public bool UseRegex;
        public bool CreatePlaylist;
        public bool FixFileProperties;
        public bool ProcessFiles;
        public bool ProcessDirectories;
        public int MaxNameLength;

        public string FileTypes;
        public string Case;
        public string Find;
        public string Replace;
        public string Prefix;
        public string Suffix;
        public string Path;
        public string ScriptPath;

        public List<string> ChangeList;
        public List<string> ErrorList;

        public cSettings()
        {
            ChangeList      = new List<string>();
            ErrorList       = new List<string>();
            Case            = cFileRenamer.CASE_NO_CHANGE;
        }
    }
}
