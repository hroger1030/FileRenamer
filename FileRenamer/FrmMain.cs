using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace FileRenamer
{
    public partial class FrmMain : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern int GetLongPathName
        (
            [MarshalAs(UnmanagedType.LPTStr)]
                string path,
            [MarshalAs(UnmanagedType.LPTStr)]
                StringBuilder longPath,
            int longPathLength
        );

        protected static string s_OutputFilename = "RenameLog ({0}).txt";
        protected static string s_ObjectsRenamed = "Objects changed: {0}, Errors: {1}";
        protected static string s_RenameStart = "Processing...";

        // Notes 
        // http://www.ivankristianto.com/os/windows/howto-add-item-to-context-menu-on-windows/1206/

        protected List<string> _FindStingList;
        protected List<string> _ReplaceStringList;
        protected List<string> _DirectoryList;
        protected List<string> _ScriptList;
        protected bool _DisableEvents;

        public FrmMain(string[] args)
        {
            InitializeComponent();

            _FindStingList = new List<string>();
            _ReplaceStringList = new List<string>();
            _DirectoryList = new List<string>();
            _ScriptList = new List<string>();

            // set up case combo box
            this.cboCase.Items.Add(cFileRenamer.CASE_NO_CHANGE);
            this.cboCase.Items.Add(cFileRenamer.CASE_ALL_UPPER);
            this.cboCase.Items.Add(cFileRenamer.CASE_ALL_LOWER);
            this.cboCase.Items.Add(cFileRenamer.CASE_TITLE_CASE);
            this.cboCase.Text = cFileRenamer.CASE_NO_CHANGE;

            // set up filter combo box
            this.cboFileTypes.Items.Add(cFileRenamer.FILE_FILTER_ALL_FILES);
            this.cboFileTypes.Text = cFileRenamer.FILE_FILTER_ALL_FILES;

            // create tool tips for controls
            CreateToolTip(this.chkCaseSensitive, "Case Sensitive Search", "This option forces the find and replace string to perform a case sensitive search. Matching is by default non-case sensitive.");
            CreateToolTip(this.chkLogChanges, "Generate Change Log", "This option creates a text log file of all the changes that are made in the selected directory.");
            CreateToolTip(this.chkLowerExtensions, "Standardize File Extension Case", "This option converts all the file extensions to lower case.");
            CreateToolTip(this.chkPreserveExtensions, "Preserve File Extensions From Changes", "This option causes the original file extension to be preserved, regardless of other changes that are applied.");
            CreateToolTip(this.chkRecursive, "Perform Recursive Processing of Subdirectories", "Selecting this option causes all subdirectories under the selected directory to be processed in addition to the selected directory. Be careful with this option, as it can affect many files.");
            CreateToolTip(this.rbtRemoveLeadingCharacter, "Remove Leading Character of File Name", "This removes the first character of filename. This is useful for removing ordinals from the beginning of filenames, since they are difficult to match without using a regular expression.");
            CreateToolTip(this.rbtRemoveTrailingCharacter, "Remove Trailing Character of File Name", "This removes the last character of filename that isn't part of the file extension.");
            CreateToolTip(this.rbtTruncateWhiteSpace, "Truncate Extra White Spaces", "This removes all extra whitespace in a file name, trimming all leading or trailing whitespace and reducing any consecuitively repeated whitespaces to a single white space.");
            CreateToolTip(this.rbtRemoveUrlEncoding, "Remove URL Encoding", "Selecting this option will remove any URL encoding in the filename. It is applied before any other processing is done.");
            CreateToolTip(this.chkUseRegex, "Use Regular Expression", "This option allows you to use regular expressions in your search string. This is only reccomended for advanced users.");
            CreateToolTip(this.chkProcessDirectories, "Process Directories", "This option will cause directory names to be processed.");
            CreateToolTip(this.chkProcessFiles, "Process Files", "This option will process directory names to be processed along with files.");
            CreateToolTip(this.chkCreatePlaylist, "Create Playlist", "This option will create a .m3u playlist from all the file in the directory.");
            CreateToolTip(this.chkStandardizeFileProperties, "Standardize File Properties", "This option will remove all file properties, such as read-only or hidden from a file.");

            CreateToolTip(this.cboCase, "File Name Case", "This drop down allows you to select the casing applied to the output file name.");
            CreateToolTip(this.cboFileTypes, "File Type Filter", "This allows you to to restrict the types of files that are searched for matchs.");
            CreateToolTip(this.cboFind, "Find String", "Enter the string that you wish to replace here. A history of search strings is stored, should you wish to repeat a replacement.");
            CreateToolTip(this.cboReplace, "Replace String", "Enter the string that you wish to replace here. A history of search strings is stored, should you wish to repeat a replacement.");
            CreateToolTip(this.cboSelectedDirectory, "Selected Directory", "This is the directory that will be searched for file name replacements. Note that the 'process files' button is disabled if you enter an invalid directory path.");
            CreateToolTip(this.txtPrefix, "Append to beginning", "Append this string to the beginning of the file name.");
            CreateToolTip(this.txtSuffix, "Append to end", "Append this string to the end of the file name.");

            this.lblFilesRenamed.Text = string.Empty;

            ResetToDefaultState();

            if (args.Length > 0)
            {
                // args gives us a strange dos formatted path name, fix with win32 api call
                StringBuilder fixed_path = new StringBuilder(1024);
                GetLongPathName(args[0], fixed_path, fixed_path.Capacity);

                string buffer = fixed_path.ToString();

                // break apart the directory from the file
                string directory_path = buffer;
                string file_name = buffer.Substring(directory_path.LastIndexOf('\\') + 1);

                // if the path doesnt exist as passed in, it probably needs to have the filename removed...
                if (!Directory.Exists(directory_path))
                    directory_path = directory_path.Substring(0, directory_path.LastIndexOf('\\'));

                this.cboSelectedDirectory.Text = directory_path;
                this.cboFind.Text = file_name;
                this.cboReplace.Text = file_name;

                // cleanup needed here?
                fixed_path = null;
            }

            this.Text = Application.ProductName + " V" + Application.ProductVersion + " By Roger Hill";
            this.cboFind.Focus();
        }

        protected void ResetToDefaultState()
        {
            _DisableEvents = false;

            foreach (var control in this.flpOptions.Controls)
            {
                if (control is Panel)
                    ((Panel)control).Visible = false;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
            }

            foreach (var control in this.flpOptions.Controls)
            {
                if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
            }

            foreach (var control in this.panTrimCharacters.Controls)
            {
                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
            }

            this.chkProcessFiles.Checked = true;
            this.cboFind.Text = string.Empty;
            this.cboReplace.Text = string.Empty;
            this.cboCase.SelectedIndex = 0;
            this.cboFileTypes.SelectedIndex = 0;
            this.nudMaxNameLength.Value = 0;
            this.nudRemoveLeadingCharacters.Value = 0;
            this.nudRemoveTrailingCharacters.Value = 0;
            this.txtPrefix.Text = string.Empty;
            this.txtSuffix.Text = string.Empty;
            this.cboScriptList.Text = string.Empty;
            this.lblFilesRenamed.Text = string.Empty;

            this.cboFind.Focus();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected async void btnProcessFiles_Click(object sender, EventArgs e)
        {
            cSettings settings = GetCurrentSettings();

            try
            {
                this.UseWaitCursor = true;
                this.lblFilesRenamed.Text = s_RenameStart;

                if (string.IsNullOrEmpty(settings.ScriptPath))
                {
                    // update combo box history
                    ManageHistoryList(this.cboFind, _FindStingList);
                    ManageHistoryList(this.cboReplace, _ReplaceStringList);
                    ManageHistoryList(this.cboSelectedDirectory, _DirectoryList);
                    ManageHistoryList(this.cboScriptList, _ScriptList);

                    await Task.Run(() =>
                    {
                        cFileRenamer.ProcessFolder(settings.Path, settings);
                    });
                }
                else
                {
                    await Task.Run(() =>
                    {
                        cFileRenamer.RunScript(settings.ScriptPath, ref settings);
                    });
                }

                if (settings.LogChanges)
                {
                    // Write Out list of changes
                    string output_name = string.Format(s_OutputFilename, DateTime.Now.ToFileTime());
                    string directory_name = Path.Combine(this.cboSelectedDirectory.Text, output_name);
                    FileIo.WriteToFile(directory_name, settings.ChangeList);
                }

            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
            finally
            {
                UpdateUIWithRenameResults(settings.ChangeList.Count, settings.ErrorList.Count);
                this.UseWaitCursor = false;
            }
        }

        protected void btnRunScript_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file_browser = new OpenFileDialog())
            {
                file_browser.Filter = "File Rename Scripts|*.txt";

                // set start point
                if (Directory.Exists(this.cboScriptList.Text))
                    file_browser.InitialDirectory = this.cboScriptList.Text;

                // display selected path
                if (file_browser.ShowDialog() == DialogResult.OK)
                    this.cboScriptList.Text = file_browser.FileName;
            }
        }

        protected void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder_browser = new FolderBrowserDialog())
            {
                folder_browser.ShowNewFolderButton = false;
                folder_browser.Description = "Please select the directory you wish to perform file replacements in.";

                // set start point
                if (Directory.Exists(cboSelectedDirectory.Text))
                    folder_browser.SelectedPath = cboSelectedDirectory.Text;

                // display selected path
                if (folder_browser.ShowDialog() == DialogResult.OK)
                    cboSelectedDirectory.Text = folder_browser.SelectedPath;
            }
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Application.ProductName + " V" + Application.ProductVersion);
            sb.AppendLine("By Roger Hill");
            sb.AppendLine();
            sb.Append("The program is written as freeware and distributed by Global Conquest Games. ");
            sb.Append("Provided that it not sold for profit, it is 100% free for anyone to use and redistribute at will. ");
            sb.AppendLine("Please visit our website (http://GlobalConquestGames.Net) for updates. ");

            MessageBox.Show(sb.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ResetToDefaultState();
        }

        protected void cboSelectedDirectory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(this.cboSelectedDirectory.Text))
                {
                    this.btnProcessFiles.Enabled = false;
                    return;
                }

                this.btnProcessFiles.Enabled = true;

                List<string> file_types = GetFileExtensionList(cboSelectedDirectory.Text);

                file_types.Add(cFileRenamer.FILE_FILTER_ALL_FILES);
                file_types.Sort();

                cboFileTypes.Items.Clear();
                cboFileTypes.Items.AddRange(file_types.ToArray());
                cboFileTypes.Text = cFileRenamer.FILE_FILTER_ALL_FILES;
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }

        protected void chkUseRegex_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCaseSensitive.Checked)
                this.chkCaseSensitive.Checked = false;

            this.chkCaseSensitive.Enabled = !this.chkUseRegex.Checked;
        }

        protected void DisplayErrorMessage(string error_message)
        {
            MessageBox.Show(error_message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        protected void DisplayErrorMessage()
        {
            DisplayErrorMessage("You have caused some sort of error. The program was working fine, until you started monkeying with things. I can't even give you a real error message. Nice going.");
        }

        protected List<string> GetFileExtensionList(string directory)
        {
            var file_extensions = new List<string>();

            foreach (string file_name in Directory.GetFiles(directory))
            {
                string file_type = Path.GetExtension(file_name);

                if (!file_extensions.Contains(file_type) && !string.IsNullOrWhiteSpace(file_type))
                    file_extensions.Add(file_type);
            }

            return file_extensions;
        }

        protected void ManageHistoryList(ComboBox input, List<string> list)
        {
            int index = list.IndexOf(input.Text);

            if (index != -1)
                list.RemoveAt(index);

            list.Insert(0, input.Text);

            input.Items.Clear();

            foreach (var item in list)
                input.Items.Add(item);
        }

        protected void UpdateUIWithRenameResults(int objects_renamed, int error_count)
        {
            this.lblFilesRenamed.Text = string.Format(s_ObjectsRenamed, objects_renamed, error_count);
            SystemSounds.Exclamation.Play();

            this.cboFind.Focus();
        }

        protected void CreateToolTip(Control control, string title, string text)
        {
            ToolTip tool_tip = new ToolTip();

            tool_tip.SetToolTip(control, text);
            tool_tip.ToolTipTitle = title;
            tool_tip.UseFading = true;
            tool_tip.ToolTipIcon = ToolTipIcon.Info;
            tool_tip.UseAnimation = true;
            tool_tip.AutoPopDelay = int.MaxValue;
        }

        protected cSettings GetCurrentSettings()
        {
            cSettings settings = new cSettings();

            settings.Path = this.cboSelectedDirectory.Text;
            settings.FileTypes = this.cboFileTypes.Text;

            settings.ProcessDirectories = this.chkProcessDirectories.Checked;
            settings.ProcessFiles = this.chkProcessFiles.Checked;
            settings.LogChanges = this.chkLogChanges.Checked;
            settings.LowerExtensions = this.chkLowerExtensions.Checked;
            settings.PreserveExtensions = this.chkPreserveExtensions.Checked;
            settings.Recursive = this.chkRecursive.Checked;
            settings.CreatePlaylist = this.chkCreatePlaylist.Checked;
            settings.FixFileProperties = this.chkStandardizeFileProperties.Checked;

            if (rbtFindAndReplace.Checked)
            {
                settings.Find = this.cboFind.Text;
                settings.Replace = this.cboReplace.Text;
                settings.CaseSensitive = this.chkCaseSensitive.Checked;
                settings.UseRegex = this.chkUseRegex.Checked;
            }

            if (rbtRunScript.Checked)
            {
                settings.ScriptPath = this.cboScriptList.Text;
            }

            if (rbtAppend.Checked)
            {
                settings.Prefix = this.txtPrefix.Text;
                settings.Suffix = this.txtSuffix.Text;
            }

            if (rbtTrimCharacters.Checked)
            {
                if (rbtRemoveLeadingCharacter.Checked)
                    settings.RemoveLeadingCharacter = (int)this.nudRemoveLeadingCharacters.Value;

                if (rbtRemoveTrailingCharacter.Checked)
                    settings.RemoveTrailingCharacter = (int)this.nudRemoveTrailingCharacters.Value;

                if (rbtTruncateWhiteSpace.Checked)
                    settings.RemoveSpace = this.rbtTruncateWhiteSpace.Checked;

                if (rbtRemoveUrlEncoding.Checked)
                    settings.RemoveURL = this.rbtRemoveUrlEncoding.Checked;
            }

            if (rbtRestrictLength.Checked)
            {
                settings.MaxNameLength = (int)this.nudMaxNameLength.Value;
            }

            if (rbtChangeCase.Checked)
            {
                settings.Case = this.cboCase.Text;
            }

            return settings;
        }

        private void rbtFindAndReplace_CheckedChanged(object sender, EventArgs e)
        {
            this.panFindAndReplace.Visible = rbtFindAndReplace.Checked;
        }

        private void rbtAppend_CheckedChanged(object sender, EventArgs e)
        {
            this.panAppend.Visible = rbtAppend.Checked;
        }

        private void rbtTrimCharacters_CheckedChanged(object sender, EventArgs e)
        {
            this.panTrimCharacters.Visible = rbtTrimCharacters.Checked;
        }

        private void rbtRestrictLength_CheckedChanged(object sender, EventArgs e)
        {
            this.panRestrictLength.Visible = rbtRestrictLength.Checked;
        }

        private void rbtChangeCase_CheckedChanged(object sender, EventArgs e)
        {
            this.panChangeCase.Visible = rbtChangeCase.Checked;
        }

        private void rbtRunScript_CheckedChanged(object sender, EventArgs e)
        {
            this.panRunScript.Visible = rbtRunScript.Checked;
        }

        private void chkLowerExtensions_CheckedChanged(object sender, EventArgs e)
        {
            if (_DisableEvents)
                return;

            _DisableEvents = true;

            if (this.chkPreserveExtensions.Checked)
                this.chkPreserveExtensions.Checked = false;

            _DisableEvents = false;
        }

        private void chkPreserveExtensions_CheckedChanged(object sender, EventArgs e)
        {
            if (_DisableEvents)
                return;

            _DisableEvents = true;

            if (this.chkLowerExtensions.Checked)
                this.chkLowerExtensions.Checked = false;

            _DisableEvents = false;
        }
    }
}