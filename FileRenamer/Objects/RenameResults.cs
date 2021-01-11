using System.Collections.Generic;

namespace FileRenamer
{
    public class RenameResults
    {
        public List<string> ChangeList { get; set; }
        public List<string> ErrorList { get; set; }

        public RenameResults()
        {
            ChangeList = new List<string>();
            ErrorList = new List<string>();
        }
    }
}
