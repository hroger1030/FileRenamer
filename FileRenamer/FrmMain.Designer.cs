namespace FileRenamer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            btnExit = new Button();
            btnSelectDirectory = new Button();
            cboCase = new ComboBox();
            lblCase = new Label();
            btnProcessFiles = new Button();
            lblFileTypeFilter = new Label();
            lblSuffix = new Label();
            txtSuffix = new TextBox();
            lblPrefix = new Label();
            txtPrefix = new TextBox();
            cboReplace = new ComboBox();
            cboSelectedDirectory = new ComboBox();
            lblReplace = new Label();
            lblFind = new Label();
            lblFilesRenamed = new Label();
            chkCaseSensitive = new CheckBox();
            cboFileTypes = new ComboBox();
            btnReset = new Button();
            flpOptions = new FlowLayoutPanel();
            lblTargetText = new Label();
            rbtFindAndReplace = new RadioButton();
            panFindAndReplace = new Panel();
            chkUseRegex = new CheckBox();
            ddlFind = new ComboBox();
            rbtAppend = new RadioButton();
            panAppend = new Panel();
            rbtTrimCharacters = new RadioButton();
            panTrimCharacters = new Panel();
            nudRemoveTrailingCharacters = new NumericUpDown();
            nudRemoveLeadingCharacters = new NumericUpDown();
            rbtRemoveUrlEncoding = new RadioButton();
            rbtTruncateWhiteSpace = new RadioButton();
            rbtRemoveTrailingCharacter = new RadioButton();
            rbtRemoveLeadingCharacter = new RadioButton();
            rbtRestrictLength = new RadioButton();
            panRestrictLength = new Panel();
            nudMaxNameLength = new NumericUpDown();
            label1 = new Label();
            rbtChangeCase = new RadioButton();
            panChangeCase = new Panel();
            rbtRunScript = new RadioButton();
            panRunScript = new Panel();
            btnSelectScript = new Button();
            cboScriptList = new ComboBox();
            chkRecursive = new CheckBox();
            chkLogChanges = new CheckBox();
            chkLowerExtensions = new CheckBox();
            btnAbout = new Button();
            chkCreatePlaylist = new CheckBox();
            chkStandardizeFileProperties = new CheckBox();
            chkProcessFiles = new CheckBox();
            chkProcessDirectories = new CheckBox();
            flpCheckBoxGrid = new FlowLayoutPanel();
            chkPreserveExtensions = new CheckBox();
            flpOptions.SuspendLayout();
            panFindAndReplace.SuspendLayout();
            panAppend.SuspendLayout();
            panTrimCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudRemoveTrailingCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRemoveLeadingCharacters).BeginInit();
            panRestrictLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxNameLength).BeginInit();
            panChangeCase.SuspendLayout();
            panRunScript.SuspendLayout();
            flpCheckBoxGrid.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(514, 488);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 26);
            btnExit.TabIndex = 25;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSelectDirectory
            // 
            btnSelectDirectory.Location = new Point(14, 14);
            btnSelectDirectory.Margin = new Padding(4);
            btnSelectDirectory.Name = "btnSelectDirectory";
            btnSelectDirectory.Size = new Size(122, 24);
            btnSelectDirectory.TabIndex = 4;
            btnSelectDirectory.Text = "Select Directory";
            btnSelectDirectory.UseVisualStyleBackColor = true;
            btnSelectDirectory.Click += btnSelectDirectory_Click;
            // 
            // cboCase
            // 
            cboCase.FormattingEnabled = true;
            cboCase.Location = new Point(126, 17);
            cboCase.Margin = new Padding(4);
            cboCase.Name = "cboCase";
            cboCase.Size = new Size(192, 23);
            cboCase.TabIndex = 7;
            // 
            // lblCase
            // 
            lblCase.AutoSize = true;
            lblCase.Location = new Point(46, 21);
            lblCase.Margin = new Padding(4, 0, 4, 0);
            lblCase.Name = "lblCase";
            lblCase.Size = new Size(67, 15);
            lblCase.TabIndex = 0;
            lblCase.Text = "Name Case";
            // 
            // btnProcessFiles
            // 
            btnProcessFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnProcessFiles.Enabled = false;
            btnProcessFiles.Location = new Point(230, 488);
            btnProcessFiles.Margin = new Padding(4);
            btnProcessFiles.Name = "btnProcessFiles";
            btnProcessFiles.Size = new Size(88, 26);
            btnProcessFiles.TabIndex = 22;
            btnProcessFiles.Text = "Process";
            btnProcessFiles.UseVisualStyleBackColor = true;
            btnProcessFiles.Click += btnProcessFiles_Click;
            // 
            // lblFileTypeFilter
            // 
            lblFileTypeFilter.AutoSize = true;
            lblFileTypeFilter.Location = new Point(57, 49);
            lblFileTypeFilter.Margin = new Padding(4, 0, 4, 0);
            lblFileTypeFilter.Name = "lblFileTypeFilter";
            lblFileTypeFilter.Size = new Size(77, 15);
            lblFileTypeFilter.TabIndex = 0;
            lblFileTypeFilter.Text = "Filetype Filter";
            // 
            // lblSuffix
            // 
            lblSuffix.AutoSize = true;
            lblSuffix.Location = new Point(29, 49);
            lblSuffix.Margin = new Padding(4, 0, 4, 0);
            lblSuffix.Name = "lblSuffix";
            lblSuffix.Size = new Size(86, 15);
            lblSuffix.TabIndex = 3;
            lblSuffix.Tag = "";
            lblSuffix.Text = "Append to end";
            // 
            // txtSuffix
            // 
            txtSuffix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSuffix.Location = new Point(126, 45);
            txtSuffix.Margin = new Padding(4);
            txtSuffix.Name = "txtSuffix";
            txtSuffix.Size = new Size(406, 23);
            txtSuffix.TabIndex = 3;
            // 
            // lblPrefix
            // 
            lblPrefix.AutoSize = true;
            lblPrefix.Location = new Point(25, 19);
            lblPrefix.Margin = new Padding(4, 0, 4, 0);
            lblPrefix.Name = "lblPrefix";
            lblPrefix.Size = new Size(92, 15);
            lblPrefix.TabIndex = 2;
            lblPrefix.Tag = "";
            lblPrefix.Text = "Append to front";
            // 
            // txtPrefix
            // 
            txtPrefix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrefix.Location = new Point(126, 15);
            txtPrefix.Margin = new Padding(4);
            txtPrefix.Name = "txtPrefix";
            txtPrefix.Size = new Size(406, 23);
            txtPrefix.TabIndex = 2;
            // 
            // cboReplace
            // 
            cboReplace.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboReplace.FormattingEnabled = true;
            cboReplace.Location = new Point(126, 45);
            cboReplace.Margin = new Padding(4);
            cboReplace.Name = "cboReplace";
            cboReplace.Size = new Size(406, 23);
            cboReplace.TabIndex = 1;
            // 
            // cboSelectedDirectory
            // 
            cboSelectedDirectory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboSelectedDirectory.FormattingEnabled = true;
            cboSelectedDirectory.Location = new Point(144, 14);
            cboSelectedDirectory.Margin = new Padding(4);
            cboSelectedDirectory.Name = "cboSelectedDirectory";
            cboSelectedDirectory.Size = new Size(457, 23);
            cboSelectedDirectory.TabIndex = 5;
            cboSelectedDirectory.TextChanged += cboSelectedDirectory_TextChanged;
            // 
            // lblReplace
            // 
            lblReplace.AutoSize = true;
            lblReplace.Location = new Point(38, 49);
            lblReplace.Margin = new Padding(4, 0, 4, 0);
            lblReplace.Name = "lblReplace";
            lblReplace.Size = new Size(74, 15);
            lblReplace.TabIndex = 1;
            lblReplace.Tag = "";
            lblReplace.Text = "Replace with";
            // 
            // lblFind
            // 
            lblFind.AutoSize = true;
            lblFind.Location = new Point(88, 17);
            lblFind.Margin = new Padding(4, 0, 4, 0);
            lblFind.Name = "lblFind";
            lblFind.Size = new Size(30, 15);
            lblFind.TabIndex = 0;
            lblFind.Text = "Find";
            // 
            // lblFilesRenamed
            // 
            lblFilesRenamed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFilesRenamed.Location = new Point(10, 493);
            lblFilesRenamed.Margin = new Padding(4, 0, 4, 0);
            lblFilesRenamed.Name = "lblFilesRenamed";
            lblFilesRenamed.Size = new Size(213, 21);
            lblFilesRenamed.TabIndex = 0;
            lblFilesRenamed.Text = "lblFilesRenamed";
            // 
            // chkCaseSensitive
            // 
            chkCaseSensitive.AutoSize = true;
            chkCaseSensitive.Location = new Point(126, 75);
            chkCaseSensitive.Margin = new Padding(4);
            chkCaseSensitive.Name = "chkCaseSensitive";
            chkCaseSensitive.Size = new Size(100, 19);
            chkCaseSensitive.TabIndex = 8;
            chkCaseSensitive.Text = "Case Sensitive";
            chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cboFileTypes
            // 
            cboFileTypes.FormattingEnabled = true;
            cboFileTypes.Location = new Point(144, 45);
            cboFileTypes.Margin = new Padding(4);
            cboFileTypes.Name = "cboFileTypes";
            cboFileTypes.Size = new Size(214, 23);
            cboFileTypes.TabIndex = 6;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.Location = new Point(325, 488);
            btnReset.Margin = new Padding(4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(88, 26);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // flpOptions
            // 
            flpOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpOptions.AutoScroll = true;
            flpOptions.Controls.Add(lblTargetText);
            flpOptions.Controls.Add(rbtFindAndReplace);
            flpOptions.Controls.Add(panFindAndReplace);
            flpOptions.Controls.Add(rbtAppend);
            flpOptions.Controls.Add(panAppend);
            flpOptions.Controls.Add(rbtTrimCharacters);
            flpOptions.Controls.Add(panTrimCharacters);
            flpOptions.Controls.Add(rbtRestrictLength);
            flpOptions.Controls.Add(panRestrictLength);
            flpOptions.Controls.Add(rbtChangeCase);
            flpOptions.Controls.Add(panChangeCase);
            flpOptions.Controls.Add(rbtRunScript);
            flpOptions.Controls.Add(panRunScript);
            flpOptions.FlowDirection = FlowDirection.TopDown;
            flpOptions.Location = new Point(14, 170);
            flpOptions.Margin = new Padding(4);
            flpOptions.Name = "flpOptions";
            flpOptions.Size = new Size(587, 311);
            flpOptions.TabIndex = 9;
            // 
            // lblTargetText
            // 
            lblTargetText.AutoSize = true;
            lblTargetText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTargetText.Location = new Point(4, 0);
            lblTargetText.Margin = new Padding(4, 0, 4, 0);
            lblTargetText.Name = "lblTargetText";
            lblTargetText.Size = new Size(69, 13);
            lblTargetText.TabIndex = 28;
            lblTargetText.Text = "I want to...";
            // 
            // rbtFindAndReplace
            // 
            rbtFindAndReplace.AutoSize = true;
            rbtFindAndReplace.Location = new Point(4, 17);
            rbtFindAndReplace.Margin = new Padding(4);
            rbtFindAndReplace.Name = "rbtFindAndReplace";
            rbtFindAndReplace.Size = new Size(234, 19);
            rbtFindAndReplace.TabIndex = 30;
            rbtFindAndReplace.TabStop = true;
            rbtFindAndReplace.Text = "Find and replace characters in file name";
            rbtFindAndReplace.UseVisualStyleBackColor = true;
            rbtFindAndReplace.CheckedChanged += rbtFindAndReplace_CheckedChanged;
            // 
            // panFindAndReplace
            // 
            panFindAndReplace.Controls.Add(chkUseRegex);
            panFindAndReplace.Controls.Add(chkCaseSensitive);
            panFindAndReplace.Controls.Add(lblReplace);
            panFindAndReplace.Controls.Add(cboReplace);
            panFindAndReplace.Controls.Add(lblFind);
            panFindAndReplace.Controls.Add(ddlFind);
            panFindAndReplace.Location = new Point(4, 44);
            panFindAndReplace.Margin = new Padding(4);
            panFindAndReplace.Name = "panFindAndReplace";
            panFindAndReplace.Size = new Size(550, 125);
            panFindAndReplace.TabIndex = 33;
            // 
            // chkUseRegex
            // 
            chkUseRegex.AutoSize = true;
            chkUseRegex.Location = new Point(126, 101);
            chkUseRegex.Margin = new Padding(4);
            chkUseRegex.Name = "chkUseRegex";
            chkUseRegex.Size = new Size(80, 19);
            chkUseRegex.TabIndex = 9;
            chkUseRegex.Text = "Use Regex";
            chkUseRegex.UseVisualStyleBackColor = true;
            chkUseRegex.CheckedChanged += chkUseRegex_CheckedChanged;
            // 
            // ddlFind
            // 
            ddlFind.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ddlFind.FormattingEnabled = true;
            ddlFind.Location = new Point(126, 14);
            ddlFind.Margin = new Padding(4);
            ddlFind.Name = "ddlFind";
            ddlFind.Size = new Size(407, 23);
            ddlFind.TabIndex = 0;
            // 
            // rbtAppend
            // 
            rbtAppend.AutoSize = true;
            rbtAppend.Location = new Point(4, 177);
            rbtAppend.Margin = new Padding(4);
            rbtAppend.Name = "rbtAppend";
            rbtAppend.Size = new Size(222, 19);
            rbtAppend.TabIndex = 31;
            rbtAppend.TabStop = true;
            rbtAppend.Text = "Append to beginning or end of name";
            rbtAppend.UseVisualStyleBackColor = true;
            rbtAppend.CheckedChanged += rbtAppend_CheckedChanged;
            // 
            // panAppend
            // 
            panAppend.Controls.Add(txtSuffix);
            panAppend.Controls.Add(txtPrefix);
            panAppend.Controls.Add(lblPrefix);
            panAppend.Controls.Add(lblSuffix);
            panAppend.Location = new Point(4, 204);
            panAppend.Margin = new Padding(4);
            panAppend.Name = "panAppend";
            panAppend.Size = new Size(550, 80);
            panAppend.TabIndex = 32;
            // 
            // rbtTrimCharacters
            // 
            rbtTrimCharacters.AutoSize = true;
            rbtTrimCharacters.Location = new Point(562, 4);
            rbtTrimCharacters.Margin = new Padding(4);
            rbtTrimCharacters.Name = "rbtTrimCharacters";
            rbtTrimCharacters.Size = new Size(167, 19);
            rbtTrimCharacters.TabIndex = 35;
            rbtTrimCharacters.TabStop = true;
            rbtTrimCharacters.Text = "Trim characters from name";
            rbtTrimCharacters.UseVisualStyleBackColor = true;
            rbtTrimCharacters.CheckedChanged += rbtTrimCharacters_CheckedChanged;
            // 
            // panTrimCharacters
            // 
            panTrimCharacters.Controls.Add(nudRemoveTrailingCharacters);
            panTrimCharacters.Controls.Add(nudRemoveLeadingCharacters);
            panTrimCharacters.Controls.Add(rbtRemoveUrlEncoding);
            panTrimCharacters.Controls.Add(rbtTruncateWhiteSpace);
            panTrimCharacters.Controls.Add(rbtRemoveTrailingCharacter);
            panTrimCharacters.Controls.Add(rbtRemoveLeadingCharacter);
            panTrimCharacters.Location = new Point(562, 31);
            panTrimCharacters.Margin = new Padding(4);
            panTrimCharacters.Name = "panTrimCharacters";
            panTrimCharacters.Size = new Size(550, 124);
            panTrimCharacters.TabIndex = 34;
            // 
            // nudRemoveTrailingCharacters
            // 
            nudRemoveTrailingCharacters.Location = new Point(319, 68);
            nudRemoveTrailingCharacters.Margin = new Padding(4);
            nudRemoveTrailingCharacters.Name = "nudRemoveTrailingCharacters";
            nudRemoveTrailingCharacters.Size = new Size(84, 23);
            nudRemoveTrailingCharacters.TabIndex = 41;
            nudRemoveTrailingCharacters.TextAlign = HorizontalAlignment.Right;
            // 
            // nudRemoveLeadingCharacters
            // 
            nudRemoveLeadingCharacters.Location = new Point(319, 41);
            nudRemoveLeadingCharacters.Margin = new Padding(4);
            nudRemoveLeadingCharacters.Name = "nudRemoveLeadingCharacters";
            nudRemoveLeadingCharacters.Size = new Size(84, 23);
            nudRemoveLeadingCharacters.TabIndex = 40;
            nudRemoveLeadingCharacters.TextAlign = HorizontalAlignment.Right;
            // 
            // rbtRemoveUrlEncoding
            // 
            rbtRemoveUrlEncoding.AutoSize = true;
            rbtRemoveUrlEncoding.Location = new Point(126, 95);
            rbtRemoveUrlEncoding.Margin = new Padding(4);
            rbtRemoveUrlEncoding.Name = "rbtRemoveUrlEncoding";
            rbtRemoveUrlEncoding.Size = new Size(145, 19);
            rbtRemoveUrlEncoding.TabIndex = 39;
            rbtRemoveUrlEncoding.Text = "Remove URL Encoding";
            rbtRemoveUrlEncoding.UseVisualStyleBackColor = true;
            // 
            // rbtTruncateWhiteSpace
            // 
            rbtTruncateWhiteSpace.AutoSize = true;
            rbtTruncateWhiteSpace.Checked = true;
            rbtTruncateWhiteSpace.Location = new Point(126, 15);
            rbtTruncateWhiteSpace.Margin = new Padding(4);
            rbtTruncateWhiteSpace.Name = "rbtTruncateWhiteSpace";
            rbtTruncateWhiteSpace.Size = new Size(138, 19);
            rbtTruncateWhiteSpace.TabIndex = 38;
            rbtTruncateWhiteSpace.TabStop = true;
            rbtTruncateWhiteSpace.Text = "Truncate White Space";
            rbtTruncateWhiteSpace.UseVisualStyleBackColor = true;
            // 
            // rbtRemoveTrailingCharacter
            // 
            rbtRemoveTrailingCharacter.AutoSize = true;
            rbtRemoveTrailingCharacter.Location = new Point(126, 68);
            rbtRemoveTrailingCharacter.Margin = new Padding(4);
            rbtRemoveTrailingCharacter.Name = "rbtRemoveTrailingCharacter";
            rbtRemoveTrailingCharacter.Size = new Size(163, 19);
            rbtRemoveTrailingCharacter.TabIndex = 37;
            rbtRemoveTrailingCharacter.Text = "Remove Trailing Character";
            rbtRemoveTrailingCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtRemoveLeadingCharacter
            // 
            rbtRemoveLeadingCharacter.AutoSize = true;
            rbtRemoveLeadingCharacter.Location = new Point(126, 41);
            rbtRemoveLeadingCharacter.Margin = new Padding(4);
            rbtRemoveLeadingCharacter.Name = "rbtRemoveLeadingCharacter";
            rbtRemoveLeadingCharacter.Size = new Size(172, 19);
            rbtRemoveLeadingCharacter.TabIndex = 36;
            rbtRemoveLeadingCharacter.Text = "Remove Leading Characters";
            rbtRemoveLeadingCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtRestrictLength
            // 
            rbtRestrictLength.AutoSize = true;
            rbtRestrictLength.Location = new Point(562, 163);
            rbtRestrictLength.Margin = new Padding(4);
            rbtRestrictLength.Name = "rbtRestrictLength";
            rbtRestrictLength.Size = new Size(153, 19);
            rbtRestrictLength.TabIndex = 36;
            rbtRestrictLength.TabStop = true;
            rbtRestrictLength.Text = "Restrict file name length";
            rbtRestrictLength.UseVisualStyleBackColor = true;
            rbtRestrictLength.CheckedChanged += rbtRestrictLength_CheckedChanged;
            // 
            // panRestrictLength
            // 
            panRestrictLength.Controls.Add(nudMaxNameLength);
            panRestrictLength.Controls.Add(label1);
            panRestrictLength.Location = new Point(562, 190);
            panRestrictLength.Margin = new Padding(4);
            panRestrictLength.Name = "panRestrictLength";
            panRestrictLength.Size = new Size(550, 45);
            panRestrictLength.TabIndex = 37;
            // 
            // nudMaxNameLength
            // 
            nudMaxNameLength.Location = new Point(129, 10);
            nudMaxNameLength.Margin = new Padding(4);
            nudMaxNameLength.Name = "nudMaxNameLength";
            nudMaxNameLength.Size = new Size(84, 23);
            nudMaxNameLength.TabIndex = 1;
            nudMaxNameLength.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Maximum Length";
            // 
            // rbtChangeCase
            // 
            rbtChangeCase.AutoSize = true;
            rbtChangeCase.Location = new Point(562, 243);
            rbtChangeCase.Margin = new Padding(4);
            rbtChangeCase.Name = "rbtChangeCase";
            rbtChangeCase.Size = new Size(144, 19);
            rbtChangeCase.TabIndex = 38;
            rbtChangeCase.TabStop = true;
            rbtChangeCase.Text = "Change file name case";
            rbtChangeCase.UseVisualStyleBackColor = true;
            rbtChangeCase.CheckedChanged += rbtChangeCase_CheckedChanged;
            // 
            // panChangeCase
            // 
            panChangeCase.Controls.Add(cboCase);
            panChangeCase.Controls.Add(lblCase);
            panChangeCase.Location = new Point(1120, 4);
            panChangeCase.Margin = new Padding(4);
            panChangeCase.Name = "panChangeCase";
            panChangeCase.Size = new Size(550, 49);
            panChangeCase.TabIndex = 39;
            // 
            // rbtRunScript
            // 
            rbtRunScript.AutoSize = true;
            rbtRunScript.Location = new Point(1120, 61);
            rbtRunScript.Margin = new Padding(4);
            rbtRunScript.Name = "rbtRunScript";
            rbtRunScript.Size = new Size(130, 19);
            rbtRunScript.TabIndex = 40;
            rbtRunScript.TabStop = true;
            rbtRunScript.Text = "Run a rename script";
            rbtRunScript.UseVisualStyleBackColor = true;
            rbtRunScript.CheckedChanged += rbtRunScript_CheckedChanged;
            // 
            // panRunScript
            // 
            panRunScript.Controls.Add(btnSelectScript);
            panRunScript.Controls.Add(cboScriptList);
            panRunScript.Location = new Point(1120, 88);
            panRunScript.Margin = new Padding(4);
            panRunScript.Name = "panRunScript";
            panRunScript.Size = new Size(550, 62);
            panRunScript.TabIndex = 41;
            // 
            // btnSelectScript
            // 
            btnSelectScript.Location = new Point(24, 14);
            btnSelectScript.Margin = new Padding(4);
            btnSelectScript.Name = "btnSelectScript";
            btnSelectScript.Size = new Size(94, 26);
            btnSelectScript.TabIndex = 21;
            btnSelectScript.Text = "Select Script";
            btnSelectScript.UseVisualStyleBackColor = true;
            btnSelectScript.Click += btnRunScript_Click;
            // 
            // cboScriptList
            // 
            cboScriptList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboScriptList.FormattingEnabled = true;
            cboScriptList.Location = new Point(126, 16);
            cboScriptList.Margin = new Padding(4);
            cboScriptList.Name = "cboScriptList";
            cboScriptList.Size = new Size(406, 23);
            cboScriptList.TabIndex = 22;
            // 
            // chkRecursive
            // 
            chkRecursive.AutoSize = true;
            chkRecursive.Location = new Point(4, 58);
            chkRecursive.Margin = new Padding(4);
            chkRecursive.Name = "chkRecursive";
            chkRecursive.Size = new Size(144, 19);
            chkRecursive.TabIndex = 10;
            chkRecursive.Text = "Process Subdirectories";
            chkRecursive.UseVisualStyleBackColor = true;
            // 
            // chkLogChanges
            // 
            chkLogChanges.AutoSize = true;
            chkLogChanges.Location = new Point(331, 4);
            chkLogChanges.Margin = new Padding(4);
            chkLogChanges.Name = "chkLogChanges";
            chkLogChanges.Size = new Size(140, 19);
            chkLogChanges.TabIndex = 12;
            chkLogChanges.Text = "Generate Change Log";
            chkLogChanges.UseVisualStyleBackColor = true;
            // 
            // chkLowerExtensions
            // 
            chkLowerExtensions.AutoSize = true;
            chkLowerExtensions.Location = new Point(156, 4);
            chkLowerExtensions.Margin = new Padding(4);
            chkLowerExtensions.Name = "chkLowerExtensions";
            chkLowerExtensions.Size = new Size(167, 19);
            chkLowerExtensions.TabIndex = 15;
            chkLowerExtensions.Text = "Standardize File Extensions";
            chkLowerExtensions.UseVisualStyleBackColor = true;
            chkLowerExtensions.CheckedChanged += chkLowerExtensions_CheckedChanged;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAbout.Location = new Point(419, 488);
            btnAbout.Margin = new Padding(4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(88, 26);
            btnAbout.TabIndex = 24;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // chkCreatePlaylist
            // 
            chkCreatePlaylist.AutoSize = true;
            chkCreatePlaylist.Location = new Point(331, 31);
            chkCreatePlaylist.Margin = new Padding(4);
            chkCreatePlaylist.Name = "chkCreatePlaylist";
            chkCreatePlaylist.Size = new Size(100, 19);
            chkCreatePlaylist.TabIndex = 28;
            chkCreatePlaylist.Tag = "";
            chkCreatePlaylist.Text = "Create Playlist";
            chkCreatePlaylist.UseVisualStyleBackColor = true;
            // 
            // chkStandardizeFileProperties
            // 
            chkStandardizeFileProperties.AutoSize = true;
            chkStandardizeFileProperties.Location = new Point(156, 58);
            chkStandardizeFileProperties.Margin = new Padding(4);
            chkStandardizeFileProperties.Name = "chkStandardizeFileProperties";
            chkStandardizeFileProperties.Size = new Size(164, 19);
            chkStandardizeFileProperties.TabIndex = 29;
            chkStandardizeFileProperties.Tag = "";
            chkStandardizeFileProperties.Text = "Standardize File Properties";
            chkStandardizeFileProperties.UseVisualStyleBackColor = true;
            // 
            // chkProcessFiles
            // 
            chkProcessFiles.AutoSize = true;
            chkProcessFiles.Location = new Point(4, 31);
            chkProcessFiles.Margin = new Padding(4);
            chkProcessFiles.Name = "chkProcessFiles";
            chkProcessFiles.Size = new Size(92, 19);
            chkProcessFiles.TabIndex = 30;
            chkProcessFiles.Tag = "";
            chkProcessFiles.Text = "Process Files";
            chkProcessFiles.UseVisualStyleBackColor = true;
            // 
            // chkProcessDirectories
            // 
            chkProcessDirectories.AutoSize = true;
            chkProcessDirectories.Location = new Point(4, 4);
            chkProcessDirectories.Margin = new Padding(4);
            chkProcessDirectories.Name = "chkProcessDirectories";
            chkProcessDirectories.Size = new Size(125, 19);
            chkProcessDirectories.TabIndex = 31;
            chkProcessDirectories.Tag = "";
            chkProcessDirectories.Text = "Process Directories";
            chkProcessDirectories.UseVisualStyleBackColor = true;
            // 
            // flpCheckBoxGrid
            // 
            flpCheckBoxGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpCheckBoxGrid.Controls.Add(chkProcessDirectories);
            flpCheckBoxGrid.Controls.Add(chkProcessFiles);
            flpCheckBoxGrid.Controls.Add(chkRecursive);
            flpCheckBoxGrid.Controls.Add(chkLowerExtensions);
            flpCheckBoxGrid.Controls.Add(chkPreserveExtensions);
            flpCheckBoxGrid.Controls.Add(chkStandardizeFileProperties);
            flpCheckBoxGrid.Controls.Add(chkLogChanges);
            flpCheckBoxGrid.Controls.Add(chkCreatePlaylist);
            flpCheckBoxGrid.FlowDirection = FlowDirection.TopDown;
            flpCheckBoxGrid.Location = new Point(14, 76);
            flpCheckBoxGrid.Margin = new Padding(4);
            flpCheckBoxGrid.Name = "flpCheckBoxGrid";
            flpCheckBoxGrid.Size = new Size(587, 86);
            flpCheckBoxGrid.TabIndex = 30;
            // 
            // chkPreserveExtensions
            // 
            chkPreserveExtensions.AutoSize = true;
            chkPreserveExtensions.Location = new Point(156, 31);
            chkPreserveExtensions.Margin = new Padding(4);
            chkPreserveExtensions.Name = "chkPreserveExtensions";
            chkPreserveExtensions.Size = new Size(145, 19);
            chkPreserveExtensions.TabIndex = 31;
            chkPreserveExtensions.Tag = "";
            chkPreserveExtensions.Text = "Preserve File Extension";
            chkPreserveExtensions.UseVisualStyleBackColor = true;
            chkPreserveExtensions.CheckedChanged += chkPreserveExtensions_CheckedChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 531);
            Controls.Add(cboFileTypes);
            Controls.Add(flpCheckBoxGrid);
            Controls.Add(lblFileTypeFilter);
            Controls.Add(flpOptions);
            Controls.Add(lblFilesRenamed);
            Controls.Add(btnReset);
            Controls.Add(cboSelectedDirectory);
            Controls.Add(btnProcessFiles);
            Controls.Add(btnExit);
            Controls.Add(btnSelectDirectory);
            Controls.Add(btnAbout);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(633, 570);
            Name = "FrmMain";
            Text = "Assembly Name Here";
            flpOptions.ResumeLayout(false);
            flpOptions.PerformLayout();
            panFindAndReplace.ResumeLayout(false);
            panFindAndReplace.PerformLayout();
            panAppend.ResumeLayout(false);
            panAppend.PerformLayout();
            panTrimCharacters.ResumeLayout(false);
            panTrimCharacters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudRemoveTrailingCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRemoveLeadingCharacters).EndInit();
            panRestrictLength.ResumeLayout(false);
            panRestrictLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxNameLength).EndInit();
            panChangeCase.ResumeLayout(false);
            panChangeCase.PerformLayout();
            panRunScript.ResumeLayout(false);
            flpCheckBoxGrid.ResumeLayout(false);
            flpCheckBoxGrid.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.ComboBox cboCase;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.Button btnProcessFiles;
        private System.Windows.Forms.Label lblFileTypeFilter;
        private System.Windows.Forms.ComboBox cboFileTypes;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblFilesRenamed;
        private System.Windows.Forms.CheckBox chkCaseSensitive;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cboReplace;
        private System.Windows.Forms.ComboBox cboSelectedDirectory;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.CheckBox chkLogChanges;
        private System.Windows.Forms.FlowLayoutPanel flpOptions;
        private System.Windows.Forms.CheckBox chkLowerExtensions;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Button btnSelectScript;
        private System.Windows.Forms.Label lblTargetText;
        private System.Windows.Forms.RadioButton rbtFindAndReplace;
        private System.Windows.Forms.RadioButton rbtAppend;
        private System.Windows.Forms.Panel panAppend;
        private System.Windows.Forms.Panel panFindAndReplace;
        private System.Windows.Forms.Panel panTrimCharacters;
        private System.Windows.Forms.RadioButton rbtTrimCharacters;
        private System.Windows.Forms.RadioButton rbtTruncateWhiteSpace;
        private System.Windows.Forms.RadioButton rbtRemoveTrailingCharacter;
        private System.Windows.Forms.RadioButton rbtRemoveLeadingCharacter;
        private System.Windows.Forms.RadioButton rbtRestrictLength;
        private System.Windows.Forms.Panel panRestrictLength;
        private System.Windows.Forms.NumericUpDown nudMaxNameLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtRemoveUrlEncoding;
        private System.Windows.Forms.RadioButton rbtChangeCase;
        private System.Windows.Forms.Panel panChangeCase;
        private System.Windows.Forms.RadioButton rbtRunScript;
        private System.Windows.Forms.Panel panRunScript;
        private System.Windows.Forms.CheckBox chkCreatePlaylist;
        private System.Windows.Forms.CheckBox chkStandardizeFileProperties;
        private System.Windows.Forms.CheckBox chkProcessFiles;
        private System.Windows.Forms.CheckBox chkProcessDirectories;
        private System.Windows.Forms.FlowLayoutPanel flpCheckBoxGrid;
        private System.Windows.Forms.NumericUpDown nudRemoveTrailingCharacters;
        private System.Windows.Forms.NumericUpDown nudRemoveLeadingCharacters;
        private System.Windows.Forms.CheckBox chkPreserveExtensions;
        private System.Windows.Forms.ComboBox cboScriptList;
        private System.Windows.Forms.CheckBox chkUseRegex;
        private System.Windows.Forms.ComboBox ddlFind;
    }
}

