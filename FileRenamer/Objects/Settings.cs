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
        public string Case { get; set; }
        public string Find { get; set; }
        public string Replace { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public string Path { get; set; }
        public string ScriptPath { get; set; }

        public Settings()
        {
            Case = FileRenamer.CASE_NO_CHANGE;
        }
    }
}
