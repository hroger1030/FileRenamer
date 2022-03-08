using AutoCodeGenLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

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

        protected static string OUTPUT_FILE_NAME = "RenameLog ({0}).txt";
        protected static string OBJECTS_RENAMED_LABEL = "Objects changed: {0}, Errors: {1}";
        protected static string RENAME_STARTING_LABEL = "Processing...";

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
            cboCase.Items.Add(FileRenamer.CASE_NO_CHANGE);
            cboCase.Items.Add(FileRenamer.CASE_ALL_UPPER);
            cboCase.Items.Add(FileRenamer.CASE_ALL_LOWER);
            cboCase.Items.Add(FileRenamer.CASE_TITLE_CASE);
            cboCase.Text = FileRenamer.CASE_NO_CHANGE;

            // set up filter combo box
            cboFileTypes.Items.Add(FileRenamer.FILE_FILTER_ALL_FILES);
            cboFileTypes.Text = FileRenamer.FILE_FILTER_ALL_FILES;

            // create tool tips for controls
            CreateToolTip(chkCaseSensitive, "Case Sensitive Search", "This option forces the find and replace string to perform a case sensitive search. Matching is by default non-case sensitive.");
            CreateToolTip(chkLogChanges, "Generate Change Log", "This option creates a text log file of all the changes that are made in the selected directory.");
            CreateToolTip(chkLowerExtensions, "Standardize File Extension Case", "This option converts all the file extensions to lower case.");
            CreateToolTip(chkPreserveExtensions, "Preserve File Extensions From Changes", "This option causes the original file extension to be preserved, regardless of other changes that are applied.");
            CreateToolTip(chkRecursive, "Perform Recursive Processing of Subdirectories", "Selecting this option causes all subdirectories under the selected directory to be processed in addition to the selected directory. Be careful with this option, as it can affect many files.");
            CreateToolTip(rbtRemoveLeadingCharacter, "Remove Leading Character of File Name", "This removes the first character of filename. This is useful for removing ordinals from the beginning of filenames, since they are difficult to match without using a regular expression.");
            CreateToolTip(rbtRemoveTrailingCharacter, "Remove Trailing Character of File Name", "This removes the last character of filename that isn't part of the file extension.");
            CreateToolTip(rbtTruncateWhiteSpace, "Truncate Extra White Spaces", "This removes all extra whitespace in a file name, trimming all leading or trailing whitespace and reducing any consecutively repeated whitespace to a single white space.");
            CreateToolTip(rbtRemoveUrlEncoding, "Remove URL Encoding", "Selecting this option will remove any URL encoding in the filename. It is applied before any other processing is done.");
            CreateToolTip(chkUseRegex, "Use Regular Expression", "This option allows you to use regular expressions in your search string. This is only recommended for advanced users.");
            CreateToolTip(chkProcessDirectories, "Process Directories", "This option will cause directory names to be processed.");
            CreateToolTip(chkProcessFiles, "Process Files", "This option will process directory names to be processed along with files.");
            CreateToolTip(chkCreatePlaylist, "Create a play list", "This option will create a .m3u play list from all the file in the directory.");
            CreateToolTip(chkStandardizeFileProperties, "Standardize File Properties", "This option will remove all file properties, such as read-only or hidden from a file.");

            CreateToolTip(cboCase, "File Name Case", "This drop down allows you to select the casing applied to the output file name.");
            CreateToolTip(cboFileTypes, "File Type Filter", "This allows you to restrict the types of files that are searched for match.");
            CreateToolTip(ddlFind, "Find String", "Enter the string that you wish to replace here. A history of search strings is stored, should you wish to repeat a replacement.");
            CreateToolTip(cboReplace, "Replace String", "Enter the string that you wish to replace here. A history of search strings is stored, should you wish to repeat a replacement.");
            CreateToolTip(cboSelectedDirectory, "Selected Directory", "This is the directory that will be searched for file name replacements. Note that the 'process files' button is disabled if you enter an invalid directory path.");
            CreateToolTip(txtPrefix, "Append to beginning", "Append this string to the beginning of the file name.");
            CreateToolTip(txtSuffix, "Append to end", "Append this string to the end of the file name.");

            lblFilesRenamed.Text = string.Empty;

            ResetToDefaultState();

            if (args.Length > 0)
            {
                // arguments gives us a strange dos formatted path name, fix with win32 api call
                var fixed_path = new StringBuilder(1024);
                GetLongPathName(args[0], fixed_path, fixed_path.Capacity);

                string buffer = fixed_path.ToString();

                // break apart the directory from the file
                string directory_path = buffer;
                string file_name = buffer.Substring(directory_path.LastIndexOf('\\') + 1);

                // if the path doesn't exist as passed in, it probably needs to have the filename removed...
                if (!Directory.Exists(directory_path))
                    directory_path = directory_path.Substring(0, directory_path.LastIndexOf('\\'));

                cboSelectedDirectory.Text = directory_path;
                ddlFind.Text = file_name;
                cboReplace.Text = file_name;
            }

            Text = Application.ProductName + " V" + Application.ProductVersion + " By Roger Hill";
            ddlFind.Focus();
        }

        protected void ResetToDefaultState()
        {
            _DisableEvents = false;

            foreach (var control in flpOptions.Controls)
            {
                if (control is Panel)
                    ((Panel)control).Visible = false;
                else if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
            }

            foreach (var control in flpOptions.Controls)
            {
                if (control is CheckBox)
                    ((CheckBox)control).Checked = false;
            }

            foreach (var control in panTrimCharacters.Controls)
            {
                if (control is RadioButton)
                    ((RadioButton)control).Checked = false;
            }

            chkProcessFiles.Checked = true;
            ddlFind.Text = string.Empty;
            cboReplace.Text = string.Empty;
            cboCase.SelectedIndex = 0;
            cboFileTypes.SelectedIndex = 0;
            nudMaxNameLength.Value = 0;
            nudRemoveLeadingCharacters.Value = 0;
            nudRemoveTrailingCharacters.Value = 0;
            txtPrefix.Text = string.Empty;
            txtSuffix.Text = string.Empty;
            cboScriptList.Text = string.Empty;
            lblFilesRenamed.Text = string.Empty;
            rbtTruncateWhiteSpace.Checked = true;

            ddlFind.Focus();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected async void btnProcessFiles_Click(object sender, EventArgs e)
        {
            var settings = GetCurrentSettings();

            try
            {
                UseWaitCursor = true;
                lblFilesRenamed.Text = RENAME_STARTING_LABEL;

                if (string.IsNullOrEmpty(settings.ScriptPath))
                {
                    // update combo box history
                    ManageHistoryList(ddlFind, _FindStingList);
                    ManageHistoryList(cboReplace, _ReplaceStringList);
                    ManageHistoryList(cboSelectedDirectory, _DirectoryList);
                    ManageHistoryList(cboScriptList, _ScriptList);

                    settings = await FileRenamer.ProcessFolder(settings.Path, settings);
                }
                else
                {
                    settings = await FileRenamer.RunScript(settings.ScriptPath, settings);
                }

                if (settings.LogChanges)
                {
                    // Write Out list of changes
                    string outputName = string.Format(OUTPUT_FILE_NAME, DateTime.Now.ToFileTime());
                    string pathName = Path.Combine(cboSelectedDirectory.Text, outputName);

                    await FileIo.WriteToFile(pathName, settings.ChangeList);
                }

            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
            finally
            {
                UpdateUiWithRenameResults(settings.ChangeList.Count, settings.ErrorList.Count);
                UseWaitCursor = false;
            }
        }

        protected void btnRunScript_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file_browser = new OpenFileDialog())
            {
                file_browser.Filter = "File Rename Scripts|*.txt";

                // set start point
                if (Directory.Exists(cboScriptList.Text))
                    file_browser.InitialDirectory = cboScriptList.Text;

                // display selected path
                if (file_browser.ShowDialog() == DialogResult.OK)
                    cboScriptList.Text = file_browser.FileName;
            }
        }

        protected void btnSelectDirectory_Click(object sender, EventArgs e)
        {
            using (var folder_browser = new FolderBrowserDialog())
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
                if (!Directory.Exists(cboSelectedDirectory.Text))
                {
                    btnProcessFiles.Enabled = false;
                    return;
                }

                btnProcessFiles.Enabled = true;

                var file_types = GetFileExtensionList(cboSelectedDirectory.Text);

                file_types.Add(FileRenamer.FILE_FILTER_ALL_FILES);
                file_types.Sort();

                cboFileTypes.Items.Clear();
                cboFileTypes.Items.AddRange(file_types.ToArray());
                cboFileTypes.Text = FileRenamer.FILE_FILTER_ALL_FILES;

                // find name fragments
                var name_fragments = FileRenamer.BreakFilenames(cboSelectedDirectory.Text, chkRecursive.Checked);

                ddlFind.Items.Clear();
                ddlFind.Items.AddRange(name_fragments);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }

        protected void chkUseRegex_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCaseSensitive.Checked)
                chkCaseSensitive.Checked = false;

            chkCaseSensitive.Enabled = !chkUseRegex.Checked;
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

        protected void UpdateUiWithRenameResults(int objects_renamed, int error_count)
        {
            lblFilesRenamed.Text = string.Format(OBJECTS_RENAMED_LABEL, objects_renamed, error_count);
            SystemSounds.Exclamation.Play();

            ddlFind.Focus();
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

        protected Settings GetCurrentSettings()
        {
            Settings settings = new Settings
            {
                Path = cboSelectedDirectory.Text,
                FileTypes = cboFileTypes.Text,

                ProcessDirectories = chkProcessDirectories.Checked,
                ProcessFiles = chkProcessFiles.Checked,
                LogChanges = chkLogChanges.Checked,
                LowerExtensions = chkLowerExtensions.Checked,
                PreserveExtensions = chkPreserveExtensions.Checked,
                Recursive = chkRecursive.Checked,
                CreatePlaylist = chkCreatePlaylist.Checked,
                FixFileProperties = chkStandardizeFileProperties.Checked,
            };

            if (rbtFindAndReplace.Checked)
            {
                settings.Find = ddlFind.Text;
                settings.Replace = cboReplace.Text;
                settings.CaseSensitive = chkCaseSensitive.Checked;
                settings.UseRegex = chkUseRegex.Checked;
            }

            if (rbtRunScript.Checked)
            {
                settings.ScriptPath = cboScriptList.Text;
            }

            if (rbtAppend.Checked)
            {
                settings.Prefix = txtPrefix.Text;
                settings.Suffix = txtSuffix.Text;
            }

            if (rbtTrimCharacters.Checked)
            {
                if (rbtRemoveLeadingCharacter.Checked)
                    settings.RemoveLeadingCharacter = (int)nudRemoveLeadingCharacters.Value;

                if (rbtRemoveTrailingCharacter.Checked)
                    settings.RemoveTrailingCharacter = (int)nudRemoveTrailingCharacters.Value;

                if (rbtTruncateWhiteSpace.Checked)
                    settings.RemoveSpace = rbtTruncateWhiteSpace.Checked;

                if (rbtRemoveUrlEncoding.Checked)
                    settings.RemoveURL = rbtRemoveUrlEncoding.Checked;
            }

            if (rbtRestrictLength.Checked)
            {
                settings.MaxNameLength = (int)nudMaxNameLength.Value;
            }

            if (rbtChangeCase.Checked)
            {
                settings.Case = cboCase.Text;
            }

            return settings;
        }

        private void rbtFindAndReplace_CheckedChanged(object sender, EventArgs e)
        {
            panFindAndReplace.Visible = rbtFindAndReplace.Checked;
        }

        private void rbtAppend_CheckedChanged(object sender, EventArgs e)
        {
            panAppend.Visible = rbtAppend.Checked;
        }

        private void rbtTrimCharacters_CheckedChanged(object sender, EventArgs e)
        {
            panTrimCharacters.Visible = rbtTrimCharacters.Checked;
        }

        private void rbtRestrictLength_CheckedChanged(object sender, EventArgs e)
        {
            panRestrictLength.Visible = rbtRestrictLength.Checked;
        }

        private void rbtChangeCase_CheckedChanged(object sender, EventArgs e)
        {
            panChangeCase.Visible = rbtChangeCase.Checked;
        }

        private void rbtRunScript_CheckedChanged(object sender, EventArgs e)
        {
            panRunScript.Visible = rbtRunScript.Checked;
        }

        private void chkLowerExtensions_CheckedChanged(object sender, EventArgs e)
        {
            if (_DisableEvents)
                return;

            _DisableEvents = true;

            if (chkPreserveExtensions.Checked)
                chkPreserveExtensions.Checked = false;

            _DisableEvents = false;
        }

        private void chkPreserveExtensions_CheckedChanged(object sender, EventArgs e)
        {
            if (_DisableEvents)
                return;

            _DisableEvents = true;

            if (chkLowerExtensions.Checked)
                chkLowerExtensions.Checked = false;

            _DisableEvents = false;
        }
    }
}