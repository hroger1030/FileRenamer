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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.cboCase = new System.Windows.Forms.ComboBox();
            this.lblCase = new System.Windows.Forms.Label();
            this.btnProcessFiles = new System.Windows.Forms.Button();
            this.lblFileTypeFilter = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.cboReplace = new System.Windows.Forms.ComboBox();
            this.cboSelectedDirectory = new System.Windows.Forms.ComboBox();
            this.cboFind = new System.Windows.Forms.ComboBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblFilesRenamed = new System.Windows.Forms.Label();
            this.chkUseRegex = new System.Windows.Forms.CheckBox();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cboFileTypes = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.chkLogChanges = new System.Windows.Forms.CheckBox();
            this.chkLowerExtensions = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSelectScript = new System.Windows.Forms.Button();
            this.lblTargetText = new System.Windows.Forms.Label();
            this.rbtFindAndReplace = new System.Windows.Forms.RadioButton();
            this.rbtAppend = new System.Windows.Forms.RadioButton();
            this.panAppend = new System.Windows.Forms.Panel();
            this.panFindAndReplace = new System.Windows.Forms.Panel();
            this.panTrimCharacters = new System.Windows.Forms.Panel();
            this.rbtTrimCharacters = new System.Windows.Forms.RadioButton();
            this.rbtRemoveLeadingCharacter = new System.Windows.Forms.RadioButton();
            this.rbtRemoveTrailingCharacter = new System.Windows.Forms.RadioButton();
            this.rbtTruncateWhiteSpace = new System.Windows.Forms.RadioButton();
            this.rbtRestrictLength = new System.Windows.Forms.RadioButton();
            this.panRestrictLength = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxNameLength = new System.Windows.Forms.NumericUpDown();
            this.rbtChangeCase = new System.Windows.Forms.RadioButton();
            this.panChangeCase = new System.Windows.Forms.Panel();
            this.rbtRemoveUrlEncoding = new System.Windows.Forms.RadioButton();
            this.rbtRunScript = new System.Windows.Forms.RadioButton();
            this.panRunScript = new System.Windows.Forms.Panel();
            this.chkCreatePlaylist = new System.Windows.Forms.CheckBox();
            this.chkStandardizeFileProperties = new System.Windows.Forms.CheckBox();
            this.chkProcessFiles = new System.Windows.Forms.CheckBox();
            this.chkProcessDirectories = new System.Windows.Forms.CheckBox();
            this.flpCheckBoxGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.nudRemoveLeadingCharacters = new System.Windows.Forms.NumericUpDown();
            this.nudRemoveTrailingCharacters = new System.Windows.Forms.NumericUpDown();
            this.chkPreserveExtensions = new System.Windows.Forms.CheckBox();
            this.cboScriptList = new System.Windows.Forms.ComboBox();
            this.flpOptions.SuspendLayout();
            this.panAppend.SuspendLayout();
            this.panFindAndReplace.SuspendLayout();
            this.panTrimCharacters.SuspendLayout();
            this.panRestrictLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNameLength)).BeginInit();
            this.panChangeCase.SuspendLayout();
            this.panRunScript.SuspendLayout();
            this.flpCheckBoxGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveLeadingCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTrailingCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(442, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(12, 12);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(105, 21);
            this.btnSelectDirectory.TabIndex = 4;
            this.btnSelectDirectory.Text = "Select Directory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // cboCase
            // 
            this.cboCase.FormattingEnabled = true;
            this.cboCase.Location = new System.Drawing.Point(108, 15);
            this.cboCase.Name = "cboCase";
            this.cboCase.Size = new System.Drawing.Size(165, 21);
            this.cboCase.TabIndex = 7;
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Location = new System.Drawing.Point(40, 18);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(62, 13);
            this.lblCase.TabIndex = 0;
            this.lblCase.Text = "Name Case";
            // 
            // btnProcessFiles
            // 
            this.btnProcessFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessFiles.Enabled = false;
            this.btnProcessFiles.Location = new System.Drawing.Point(199, 430);
            this.btnProcessFiles.Name = "btnProcessFiles";
            this.btnProcessFiles.Size = new System.Drawing.Size(75, 23);
            this.btnProcessFiles.TabIndex = 22;
            this.btnProcessFiles.Text = "Process";
            this.btnProcessFiles.UseVisualStyleBackColor = true;
            this.btnProcessFiles.Click += new System.EventHandler(this.btnProcessFiles_Click);
            // 
            // lblFileTypeFilter
            // 
            this.lblFileTypeFilter.AutoSize = true;
            this.lblFileTypeFilter.Location = new System.Drawing.Point(49, 42);
            this.lblFileTypeFilter.Name = "lblFileTypeFilter";
            this.lblFileTypeFilter.Size = new System.Drawing.Size(68, 13);
            this.lblFileTypeFilter.TabIndex = 0;
            this.lblFileTypeFilter.Text = "Filetype Filter";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(25, 42);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(77, 13);
            this.lblSuffix.TabIndex = 3;
            this.lblSuffix.Tag = "";
            this.lblSuffix.Text = "Append to end";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuffix.Location = new System.Drawing.Point(108, 39);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(349, 20);
            this.txtSuffix.TabIndex = 3;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(22, 16);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(80, 13);
            this.lblPrefix.TabIndex = 2;
            this.lblPrefix.Tag = "";
            this.lblPrefix.Text = "Append to front";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefix.Location = new System.Drawing.Point(108, 13);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(349, 20);
            this.txtPrefix.TabIndex = 2;
            // 
            // cboReplace
            // 
            this.cboReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReplace.FormattingEnabled = true;
            this.cboReplace.Location = new System.Drawing.Point(108, 39);
            this.cboReplace.Name = "cboReplace";
            this.cboReplace.Size = new System.Drawing.Size(349, 21);
            this.cboReplace.TabIndex = 1;
            // 
            // cboSelectedDirectory
            // 
            this.cboSelectedDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectedDirectory.FormattingEnabled = true;
            this.cboSelectedDirectory.Location = new System.Drawing.Point(123, 12);
            this.cboSelectedDirectory.Name = "cboSelectedDirectory";
            this.cboSelectedDirectory.Size = new System.Drawing.Size(394, 21);
            this.cboSelectedDirectory.TabIndex = 5;
            this.cboSelectedDirectory.TextChanged += new System.EventHandler(this.cboSelectedDirectory_TextChanged);
            // 
            // cboFind
            // 
            this.cboFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFind.FormattingEnabled = true;
            this.cboFind.Location = new System.Drawing.Point(108, 12);
            this.cboFind.Name = "cboFind";
            this.cboFind.Size = new System.Drawing.Size(350, 21);
            this.cboFind.TabIndex = 0;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(33, 42);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(69, 13);
            this.lblReplace.TabIndex = 1;
            this.lblReplace.Tag = "";
            this.lblReplace.Text = "Replace with";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(75, 15);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(27, 13);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find";
            // 
            // lblFilesRenamed
            // 
            this.lblFilesRenamed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilesRenamed.Location = new System.Drawing.Point(9, 435);
            this.lblFilesRenamed.Name = "lblFilesRenamed";
            this.lblFilesRenamed.Size = new System.Drawing.Size(184, 18);
            this.lblFilesRenamed.TabIndex = 0;
            this.lblFilesRenamed.Text = "lblFilesRenamed";
            // 
            // chkUseRegex
            // 
            this.chkUseRegex.AutoSize = true;
            this.chkUseRegex.Location = new System.Drawing.Point(108, 88);
            this.chkUseRegex.Name = "chkUseRegex";
            this.chkUseRegex.Size = new System.Drawing.Size(79, 17);
            this.chkUseRegex.TabIndex = 9;
            this.chkUseRegex.Text = "Use Regex";
            this.chkUseRegex.UseVisualStyleBackColor = true;
            this.chkUseRegex.CheckedChanged += new System.EventHandler(this.chkUseRegex_CheckedChanged);
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(108, 65);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(96, 17);
            this.chkCaseSensitive.TabIndex = 8;
            this.chkCaseSensitive.Text = "Case Sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cboFileTypes
            // 
            this.cboFileTypes.FormattingEnabled = true;
            this.cboFileTypes.Location = new System.Drawing.Point(123, 39);
            this.cboFileTypes.Name = "cboFileTypes";
            this.cboFileTypes.Size = new System.Drawing.Size(184, 21);
            this.cboFileTypes.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(280, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flpOptions
            // 
            this.flpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpOptions.AutoScroll = true;
            this.flpOptions.Controls.Add(this.lblTargetText);
            this.flpOptions.Controls.Add(this.rbtFindAndReplace);
            this.flpOptions.Controls.Add(this.panFindAndReplace);
            this.flpOptions.Controls.Add(this.rbtAppend);
            this.flpOptions.Controls.Add(this.panAppend);
            this.flpOptions.Controls.Add(this.rbtTrimCharacters);
            this.flpOptions.Controls.Add(this.panTrimCharacters);
            this.flpOptions.Controls.Add(this.rbtRestrictLength);
            this.flpOptions.Controls.Add(this.panRestrictLength);
            this.flpOptions.Controls.Add(this.rbtChangeCase);
            this.flpOptions.Controls.Add(this.panChangeCase);
            this.flpOptions.Controls.Add(this.rbtRunScript);
            this.flpOptions.Controls.Add(this.panRunScript);
            this.flpOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOptions.Location = new System.Drawing.Point(12, 147);
            this.flpOptions.Name = "flpOptions";
            this.flpOptions.Size = new System.Drawing.Size(505, 277);
            this.flpOptions.TabIndex = 9;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(3, 49);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(134, 17);
            this.chkRecursive.TabIndex = 10;
            this.chkRecursive.Text = "Process Subdirectories";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // chkLogChanges
            // 
            this.chkLogChanges.AutoSize = true;
            this.chkLogChanges.Location = new System.Drawing.Point(304, 3);
            this.chkLogChanges.Name = "chkLogChanges";
            this.chkLogChanges.Size = new System.Drawing.Size(131, 17);
            this.chkLogChanges.TabIndex = 12;
            this.chkLogChanges.Text = "Generate Change Log";
            this.chkLogChanges.UseVisualStyleBackColor = true;
            // 
            // chkLowerExtensions
            // 
            this.chkLowerExtensions.AutoSize = true;
            this.chkLowerExtensions.Location = new System.Drawing.Point(143, 3);
            this.chkLowerExtensions.Name = "chkLowerExtensions";
            this.chkLowerExtensions.Size = new System.Drawing.Size(155, 17);
            this.chkLowerExtensions.TabIndex = 15;
            this.chkLowerExtensions.Text = "Standardize File Extensions";
            this.chkLowerExtensions.UseVisualStyleBackColor = true;
            this.chkLowerExtensions.CheckedChanged += new System.EventHandler(this.chkLowerExtensions_CheckedChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(361, 430);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 24;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSelectScript
            // 
            this.btnSelectScript.Location = new System.Drawing.Point(21, 12);
            this.btnSelectScript.Name = "btnSelectScript";
            this.btnSelectScript.Size = new System.Drawing.Size(81, 23);
            this.btnSelectScript.TabIndex = 21;
            this.btnSelectScript.Text = "Select Script";
            this.btnSelectScript.UseVisualStyleBackColor = true;
            this.btnSelectScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // lblTargetText
            // 
            this.lblTargetText.AutoSize = true;
            this.lblTargetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetText.Location = new System.Drawing.Point(3, 0);
            this.lblTargetText.Name = "lblTargetText";
            this.lblTargetText.Size = new System.Drawing.Size(69, 13);
            this.lblTargetText.TabIndex = 28;
            this.lblTargetText.Text = "I want to...";
            // 
            // rbtFindAndReplace
            // 
            this.rbtFindAndReplace.AutoSize = true;
            this.rbtFindAndReplace.Location = new System.Drawing.Point(3, 16);
            this.rbtFindAndReplace.Name = "rbtFindAndReplace";
            this.rbtFindAndReplace.Size = new System.Drawing.Size(213, 17);
            this.rbtFindAndReplace.TabIndex = 30;
            this.rbtFindAndReplace.TabStop = true;
            this.rbtFindAndReplace.Text = "Find and replace characters in file name";
            this.rbtFindAndReplace.UseVisualStyleBackColor = true;
            this.rbtFindAndReplace.CheckedChanged += new System.EventHandler(this.rbtFindAndReplace_CheckedChanged);
            // 
            // rbtAppend
            // 
            this.rbtAppend.AutoSize = true;
            this.rbtAppend.Location = new System.Drawing.Point(3, 153);
            this.rbtAppend.Name = "rbtAppend";
            this.rbtAppend.Size = new System.Drawing.Size(197, 17);
            this.rbtAppend.TabIndex = 31;
            this.rbtAppend.TabStop = true;
            this.rbtAppend.Text = "Append to beginning or end of name";
            this.rbtAppend.UseVisualStyleBackColor = true;
            this.rbtAppend.CheckedChanged += new System.EventHandler(this.rbtAppend_CheckedChanged);
            // 
            // panAppend
            // 
            this.panAppend.Controls.Add(this.txtSuffix);
            this.panAppend.Controls.Add(this.txtPrefix);
            this.panAppend.Controls.Add(this.lblPrefix);
            this.panAppend.Controls.Add(this.lblSuffix);
            this.panAppend.Location = new System.Drawing.Point(3, 176);
            this.panAppend.Name = "panAppend";
            this.panAppend.Size = new System.Drawing.Size(472, 69);
            this.panAppend.TabIndex = 32;
            // 
            // panFindAndReplace
            // 
            this.panFindAndReplace.Controls.Add(this.chkUseRegex);
            this.panFindAndReplace.Controls.Add(this.chkCaseSensitive);
            this.panFindAndReplace.Controls.Add(this.lblReplace);
            this.panFindAndReplace.Controls.Add(this.cboReplace);
            this.panFindAndReplace.Controls.Add(this.lblFind);
            this.panFindAndReplace.Controls.Add(this.cboFind);
            this.panFindAndReplace.Location = new System.Drawing.Point(3, 39);
            this.panFindAndReplace.Name = "panFindAndReplace";
            this.panFindAndReplace.Size = new System.Drawing.Size(472, 108);
            this.panFindAndReplace.TabIndex = 33;
            // 
            // panTrimCharacters
            // 
            this.panTrimCharacters.Controls.Add(this.nudRemoveTrailingCharacters);
            this.panTrimCharacters.Controls.Add(this.nudRemoveLeadingCharacters);
            this.panTrimCharacters.Controls.Add(this.rbtRemoveUrlEncoding);
            this.panTrimCharacters.Controls.Add(this.rbtTruncateWhiteSpace);
            this.panTrimCharacters.Controls.Add(this.rbtRemoveTrailingCharacter);
            this.panTrimCharacters.Controls.Add(this.rbtRemoveLeadingCharacter);
            this.panTrimCharacters.Location = new System.Drawing.Point(3, 274);
            this.panTrimCharacters.Name = "panTrimCharacters";
            this.panTrimCharacters.Size = new System.Drawing.Size(472, 107);
            this.panTrimCharacters.TabIndex = 34;
            // 
            // rbtTrimCharacters
            // 
            this.rbtTrimCharacters.AutoSize = true;
            this.rbtTrimCharacters.Location = new System.Drawing.Point(3, 251);
            this.rbtTrimCharacters.Name = "rbtTrimCharacters";
            this.rbtTrimCharacters.Size = new System.Drawing.Size(150, 17);
            this.rbtTrimCharacters.TabIndex = 35;
            this.rbtTrimCharacters.TabStop = true;
            this.rbtTrimCharacters.Text = "Trim characters from name";
            this.rbtTrimCharacters.UseVisualStyleBackColor = true;
            this.rbtTrimCharacters.CheckedChanged += new System.EventHandler(this.rbtTrimCharacters_CheckedChanged);
            // 
            // rbtRemoveLeadingCharacter
            // 
            this.rbtRemoveLeadingCharacter.AutoSize = true;
            this.rbtRemoveLeadingCharacter.Location = new System.Drawing.Point(108, 36);
            this.rbtRemoveLeadingCharacter.Name = "rbtRemoveLeadingCharacter";
            this.rbtRemoveLeadingCharacter.Size = new System.Drawing.Size(160, 17);
            this.rbtRemoveLeadingCharacter.TabIndex = 36;
            this.rbtRemoveLeadingCharacter.TabStop = true;
            this.rbtRemoveLeadingCharacter.Text = "Remove Leading Characters";
            this.rbtRemoveLeadingCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtRemoveTrailingCharacter
            // 
            this.rbtRemoveTrailingCharacter.AutoSize = true;
            this.rbtRemoveTrailingCharacter.Location = new System.Drawing.Point(108, 59);
            this.rbtRemoveTrailingCharacter.Name = "rbtRemoveTrailingCharacter";
            this.rbtRemoveTrailingCharacter.Size = new System.Drawing.Size(151, 17);
            this.rbtRemoveTrailingCharacter.TabIndex = 37;
            this.rbtRemoveTrailingCharacter.TabStop = true;
            this.rbtRemoveTrailingCharacter.Text = "Remove Trailing Character";
            this.rbtRemoveTrailingCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtTruncateWhiteSpace
            // 
            this.rbtTruncateWhiteSpace.AutoSize = true;
            this.rbtTruncateWhiteSpace.Location = new System.Drawing.Point(108, 13);
            this.rbtTruncateWhiteSpace.Name = "rbtTruncateWhiteSpace";
            this.rbtTruncateWhiteSpace.Size = new System.Drawing.Size(133, 17);
            this.rbtTruncateWhiteSpace.TabIndex = 38;
            this.rbtTruncateWhiteSpace.TabStop = true;
            this.rbtTruncateWhiteSpace.Text = "Truncate White Space";
            this.rbtTruncateWhiteSpace.UseVisualStyleBackColor = true;
            // 
            // rbtRestrictLength
            // 
            this.rbtRestrictLength.AutoSize = true;
            this.rbtRestrictLength.Location = new System.Drawing.Point(3, 387);
            this.rbtRestrictLength.Name = "rbtRestrictLength";
            this.rbtRestrictLength.Size = new System.Drawing.Size(138, 17);
            this.rbtRestrictLength.TabIndex = 36;
            this.rbtRestrictLength.TabStop = true;
            this.rbtRestrictLength.Text = "Restrict file name length";
            this.rbtRestrictLength.UseVisualStyleBackColor = true;
            this.rbtRestrictLength.CheckedChanged += new System.EventHandler(this.rbtRestrictLength_CheckedChanged);
            // 
            // panRestrictLength
            // 
            this.panRestrictLength.Controls.Add(this.nudMaxNameLength);
            this.panRestrictLength.Controls.Add(this.label1);
            this.panRestrictLength.Location = new System.Drawing.Point(3, 410);
            this.panRestrictLength.Name = "panRestrictLength";
            this.panRestrictLength.Size = new System.Drawing.Size(472, 39);
            this.panRestrictLength.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Length";
            // 
            // nudMaxNameLength
            // 
            this.nudMaxNameLength.Location = new System.Drawing.Point(110, 9);
            this.nudMaxNameLength.Name = "nudMaxNameLength";
            this.nudMaxNameLength.Size = new System.Drawing.Size(72, 20);
            this.nudMaxNameLength.TabIndex = 1;
            this.nudMaxNameLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtChangeCase
            // 
            this.rbtChangeCase.AutoSize = true;
            this.rbtChangeCase.Location = new System.Drawing.Point(481, 3);
            this.rbtChangeCase.Name = "rbtChangeCase";
            this.rbtChangeCase.Size = new System.Drawing.Size(133, 17);
            this.rbtChangeCase.TabIndex = 38;
            this.rbtChangeCase.TabStop = true;
            this.rbtChangeCase.Text = "Change file name case";
            this.rbtChangeCase.UseVisualStyleBackColor = true;
            this.rbtChangeCase.CheckedChanged += new System.EventHandler(this.rbtChangeCase_CheckedChanged);
            // 
            // panChangeCase
            // 
            this.panChangeCase.Controls.Add(this.cboCase);
            this.panChangeCase.Controls.Add(this.lblCase);
            this.panChangeCase.Location = new System.Drawing.Point(481, 26);
            this.panChangeCase.Name = "panChangeCase";
            this.panChangeCase.Size = new System.Drawing.Size(472, 42);
            this.panChangeCase.TabIndex = 39;
            // 
            // rbtRemoveUrlEncoding
            // 
            this.rbtRemoveUrlEncoding.AutoSize = true;
            this.rbtRemoveUrlEncoding.Location = new System.Drawing.Point(108, 82);
            this.rbtRemoveUrlEncoding.Name = "rbtRemoveUrlEncoding";
            this.rbtRemoveUrlEncoding.Size = new System.Drawing.Size(138, 17);
            this.rbtRemoveUrlEncoding.TabIndex = 39;
            this.rbtRemoveUrlEncoding.TabStop = true;
            this.rbtRemoveUrlEncoding.Text = "Remove URL Encoding";
            this.rbtRemoveUrlEncoding.UseVisualStyleBackColor = true;
            // 
            // rbtRunScript
            // 
            this.rbtRunScript.AutoSize = true;
            this.rbtRunScript.Location = new System.Drawing.Point(481, 74);
            this.rbtRunScript.Name = "rbtRunScript";
            this.rbtRunScript.Size = new System.Drawing.Size(120, 17);
            this.rbtRunScript.TabIndex = 40;
            this.rbtRunScript.TabStop = true;
            this.rbtRunScript.Text = "Run a rename script";
            this.rbtRunScript.UseVisualStyleBackColor = true;
            this.rbtRunScript.CheckedChanged += new System.EventHandler(this.rbtRunScript_CheckedChanged);
            // 
            // panRunScript
            // 
            this.panRunScript.Controls.Add(this.btnSelectScript);
            this.panRunScript.Controls.Add(this.cboScriptList);
            this.panRunScript.Location = new System.Drawing.Point(481, 97);
            this.panRunScript.Name = "panRunScript";
            this.panRunScript.Size = new System.Drawing.Size(472, 54);
            this.panRunScript.TabIndex = 41;
            // 
            // chkCreatePlaylist
            // 
            this.chkCreatePlaylist.AutoSize = true;
            this.chkCreatePlaylist.Location = new System.Drawing.Point(304, 26);
            this.chkCreatePlaylist.Name = "chkCreatePlaylist";
            this.chkCreatePlaylist.Size = new System.Drawing.Size(92, 17);
            this.chkCreatePlaylist.TabIndex = 28;
            this.chkCreatePlaylist.Tag = "";
            this.chkCreatePlaylist.Text = "Create Playlist";
            this.chkCreatePlaylist.UseVisualStyleBackColor = true;
            // 
            // chkStandardizeFileProperties
            // 
            this.chkStandardizeFileProperties.AutoSize = true;
            this.chkStandardizeFileProperties.Location = new System.Drawing.Point(143, 49);
            this.chkStandardizeFileProperties.Name = "chkStandardizeFileProperties";
            this.chkStandardizeFileProperties.Size = new System.Drawing.Size(151, 17);
            this.chkStandardizeFileProperties.TabIndex = 29;
            this.chkStandardizeFileProperties.Tag = "";
            this.chkStandardizeFileProperties.Text = "Standardize File Properties";
            this.chkStandardizeFileProperties.UseVisualStyleBackColor = true;
            // 
            // chkProcessFiles
            // 
            this.chkProcessFiles.AutoSize = true;
            this.chkProcessFiles.Location = new System.Drawing.Point(3, 26);
            this.chkProcessFiles.Name = "chkProcessFiles";
            this.chkProcessFiles.Size = new System.Drawing.Size(88, 17);
            this.chkProcessFiles.TabIndex = 30;
            this.chkProcessFiles.Tag = "";
            this.chkProcessFiles.Text = "Process Files";
            this.chkProcessFiles.UseVisualStyleBackColor = true;
            // 
            // chkProcessDirectories
            // 
            this.chkProcessDirectories.AutoSize = true;
            this.chkProcessDirectories.Location = new System.Drawing.Point(3, 3);
            this.chkProcessDirectories.Name = "chkProcessDirectories";
            this.chkProcessDirectories.Size = new System.Drawing.Size(117, 17);
            this.chkProcessDirectories.TabIndex = 31;
            this.chkProcessDirectories.Tag = "";
            this.chkProcessDirectories.Text = "Process Directories";
            this.chkProcessDirectories.UseVisualStyleBackColor = true;
            // 
            // flpCheckBoxGrid
            // 
            this.flpCheckBoxGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCheckBoxGrid.Controls.Add(this.chkProcessDirectories);
            this.flpCheckBoxGrid.Controls.Add(this.chkProcessFiles);
            this.flpCheckBoxGrid.Controls.Add(this.chkRecursive);
            this.flpCheckBoxGrid.Controls.Add(this.chkLowerExtensions);
            this.flpCheckBoxGrid.Controls.Add(this.chkPreserveExtensions);
            this.flpCheckBoxGrid.Controls.Add(this.chkStandardizeFileProperties);
            this.flpCheckBoxGrid.Controls.Add(this.chkLogChanges);
            this.flpCheckBoxGrid.Controls.Add(this.chkCreatePlaylist);
            this.flpCheckBoxGrid.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCheckBoxGrid.Location = new System.Drawing.Point(12, 66);
            this.flpCheckBoxGrid.Name = "flpCheckBoxGrid";
            this.flpCheckBoxGrid.Size = new System.Drawing.Size(505, 75);
            this.flpCheckBoxGrid.TabIndex = 30;
            // 
            // nudRemoveLeadingCharacters
            // 
            this.nudRemoveLeadingCharacters.Location = new System.Drawing.Point(274, 36);
            this.nudRemoveLeadingCharacters.Name = "nudRemoveLeadingCharacters";
            this.nudRemoveLeadingCharacters.Size = new System.Drawing.Size(72, 20);
            this.nudRemoveLeadingCharacters.TabIndex = 40;
            this.nudRemoveLeadingCharacters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudRemoveTrailingCharacters
            // 
            this.nudRemoveTrailingCharacters.Location = new System.Drawing.Point(274, 59);
            this.nudRemoveTrailingCharacters.Name = "nudRemoveTrailingCharacters";
            this.nudRemoveTrailingCharacters.Size = new System.Drawing.Size(72, 20);
            this.nudRemoveTrailingCharacters.TabIndex = 41;
            this.nudRemoveTrailingCharacters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkPreserveExtensions
            // 
            this.chkPreserveExtensions.AutoSize = true;
            this.chkPreserveExtensions.Location = new System.Drawing.Point(143, 26);
            this.chkPreserveExtensions.Name = "chkPreserveExtensions";
            this.chkPreserveExtensions.Size = new System.Drawing.Size(136, 17);
            this.chkPreserveExtensions.TabIndex = 31;
            this.chkPreserveExtensions.Tag = "";
            this.chkPreserveExtensions.Text = "Preserve File Extension";
            this.chkPreserveExtensions.UseVisualStyleBackColor = true;
            this.chkPreserveExtensions.CheckedChanged += new System.EventHandler(this.chkPreserveExtensions_CheckedChanged);
            // 
            // cboScriptList
            // 
            this.cboScriptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboScriptList.FormattingEnabled = true;
            this.cboScriptList.Location = new System.Drawing.Point(108, 14);
            this.cboScriptList.Name = "cboScriptList";
            this.cboScriptList.Size = new System.Drawing.Size(349, 21);
            this.cboScriptList.TabIndex = 22;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 462);
            this.Controls.Add(this.cboFileTypes);
            this.Controls.Add(this.flpCheckBoxGrid);
            this.Controls.Add(this.lblFileTypeFilter);
            this.Controls.Add(this.flpOptions);
            this.Controls.Add(this.lblFilesRenamed);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboSelectedDirectory);
            this.Controls.Add(this.btnProcessFiles);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelectDirectory);
            this.Controls.Add(this.btnAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(545, 500);
            this.Name = "FrmMain";
            this.Text = "Assembly Name Here";
            this.flpOptions.ResumeLayout(false);
            this.flpOptions.PerformLayout();
            this.panAppend.ResumeLayout(false);
            this.panAppend.PerformLayout();
            this.panFindAndReplace.ResumeLayout(false);
            this.panFindAndReplace.PerformLayout();
            this.panTrimCharacters.ResumeLayout(false);
            this.panTrimCharacters.PerformLayout();
            this.panRestrictLength.ResumeLayout(false);
            this.panRestrictLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNameLength)).EndInit();
            this.panChangeCase.ResumeLayout(false);
            this.panChangeCase.PerformLayout();
            this.panRunScript.ResumeLayout(false);
            this.flpCheckBoxGrid.ResumeLayout(false);
            this.flpCheckBoxGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveLeadingCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTrailingCharacters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.CheckBox chkUseRegex;
        private System.Windows.Forms.ComboBox cboFind;
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
    }
}

