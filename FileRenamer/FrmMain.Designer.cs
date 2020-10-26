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
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblFilesRenamed = new System.Windows.Forms.Label();
            this.chkCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cboFileTypes = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.flpOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTargetText = new System.Windows.Forms.Label();
            this.rbtFindAndReplace = new System.Windows.Forms.RadioButton();
            this.panFindAndReplace = new System.Windows.Forms.Panel();
            this.chkUseRegex = new System.Windows.Forms.CheckBox();
            this.ddlFind = new System.Windows.Forms.ComboBox();
            this.rbtAppend = new System.Windows.Forms.RadioButton();
            this.panAppend = new System.Windows.Forms.Panel();
            this.rbtTrimCharacters = new System.Windows.Forms.RadioButton();
            this.panTrimCharacters = new System.Windows.Forms.Panel();
            this.nudRemoveTrailingCharacters = new System.Windows.Forms.NumericUpDown();
            this.nudRemoveLeadingCharacters = new System.Windows.Forms.NumericUpDown();
            this.rbtRemoveUrlEncoding = new System.Windows.Forms.RadioButton();
            this.rbtTruncateWhiteSpace = new System.Windows.Forms.RadioButton();
            this.rbtRemoveTrailingCharacter = new System.Windows.Forms.RadioButton();
            this.rbtRemoveLeadingCharacter = new System.Windows.Forms.RadioButton();
            this.rbtRestrictLength = new System.Windows.Forms.RadioButton();
            this.panRestrictLength = new System.Windows.Forms.Panel();
            this.nudMaxNameLength = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtChangeCase = new System.Windows.Forms.RadioButton();
            this.panChangeCase = new System.Windows.Forms.Panel();
            this.rbtRunScript = new System.Windows.Forms.RadioButton();
            this.panRunScript = new System.Windows.Forms.Panel();
            this.btnSelectScript = new System.Windows.Forms.Button();
            this.cboScriptList = new System.Windows.Forms.ComboBox();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.chkLogChanges = new System.Windows.Forms.CheckBox();
            this.chkLowerExtensions = new System.Windows.Forms.CheckBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.chkCreatePlaylist = new System.Windows.Forms.CheckBox();
            this.chkStandardizeFileProperties = new System.Windows.Forms.CheckBox();
            this.chkProcessFiles = new System.Windows.Forms.CheckBox();
            this.chkProcessDirectories = new System.Windows.Forms.CheckBox();
            this.flpCheckBoxGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.chkPreserveExtensions = new System.Windows.Forms.CheckBox();
            this.flpOptions.SuspendLayout();
            this.panFindAndReplace.SuspendLayout();
            this.panAppend.SuspendLayout();
            this.panTrimCharacters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTrailingCharacters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveLeadingCharacters)).BeginInit();
            this.panRestrictLength.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNameLength)).BeginInit();
            this.panChangeCase.SuspendLayout();
            this.panRunScript.SuspendLayout();
            this.flpCheckBoxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(587, 520);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(16, 15);
            this.btnSelectDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(140, 26);
            this.btnSelectDirectory.TabIndex = 4;
            this.btnSelectDirectory.Text = "Select Directory";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // cboCase
            // 
            this.cboCase.FormattingEnabled = true;
            this.cboCase.Location = new System.Drawing.Point(144, 18);
            this.cboCase.Margin = new System.Windows.Forms.Padding(4);
            this.cboCase.Name = "cboCase";
            this.cboCase.Size = new System.Drawing.Size(219, 24);
            this.cboCase.TabIndex = 7;
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Location = new System.Drawing.Point(53, 22);
            this.lblCase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(81, 17);
            this.lblCase.TabIndex = 0;
            this.lblCase.Text = "Name Case";
            // 
            // btnProcessFiles
            // 
            this.btnProcessFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessFiles.Enabled = false;
            this.btnProcessFiles.Location = new System.Drawing.Point(263, 520);
            this.btnProcessFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcessFiles.Name = "btnProcessFiles";
            this.btnProcessFiles.Size = new System.Drawing.Size(100, 28);
            this.btnProcessFiles.TabIndex = 22;
            this.btnProcessFiles.Text = "Process";
            this.btnProcessFiles.UseVisualStyleBackColor = true;
            this.btnProcessFiles.Click += new System.EventHandler(this.btnProcessFiles_Click);
            // 
            // lblFileTypeFilter
            // 
            this.lblFileTypeFilter.AutoSize = true;
            this.lblFileTypeFilter.Location = new System.Drawing.Point(65, 52);
            this.lblFileTypeFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileTypeFilter.Name = "lblFileTypeFilter";
            this.lblFileTypeFilter.Size = new System.Drawing.Size(92, 17);
            this.lblFileTypeFilter.TabIndex = 0;
            this.lblFileTypeFilter.Text = "Filetype Filter";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(33, 52);
            this.lblSuffix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(101, 17);
            this.lblSuffix.TabIndex = 3;
            this.lblSuffix.Tag = "";
            this.lblSuffix.Text = "Append to end";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuffix.Location = new System.Drawing.Point(144, 48);
            this.txtSuffix.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(464, 22);
            this.txtSuffix.TabIndex = 3;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(29, 20);
            this.lblPrefix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(106, 17);
            this.lblPrefix.TabIndex = 2;
            this.lblPrefix.Tag = "";
            this.lblPrefix.Text = "Append to front";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrefix.Location = new System.Drawing.Point(144, 16);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(464, 22);
            this.txtPrefix.TabIndex = 2;
            // 
            // cboReplace
            // 
            this.cboReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReplace.FormattingEnabled = true;
            this.cboReplace.Location = new System.Drawing.Point(144, 48);
            this.cboReplace.Margin = new System.Windows.Forms.Padding(4);
            this.cboReplace.Name = "cboReplace";
            this.cboReplace.Size = new System.Drawing.Size(464, 24);
            this.cboReplace.TabIndex = 1;
            // 
            // cboSelectedDirectory
            // 
            this.cboSelectedDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSelectedDirectory.FormattingEnabled = true;
            this.cboSelectedDirectory.Location = new System.Drawing.Point(164, 15);
            this.cboSelectedDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.cboSelectedDirectory.Name = "cboSelectedDirectory";
            this.cboSelectedDirectory.Size = new System.Drawing.Size(522, 24);
            this.cboSelectedDirectory.TabIndex = 5;
            this.cboSelectedDirectory.TextChanged += new System.EventHandler(this.cboSelectedDirectory_TextChanged);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(44, 52);
            this.lblReplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(88, 17);
            this.lblReplace.TabIndex = 1;
            this.lblReplace.Tag = "";
            this.lblReplace.Text = "Replace with";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(100, 18);
            this.lblFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(35, 17);
            this.lblFind.TabIndex = 0;
            this.lblFind.Text = "Find";
            // 
            // lblFilesRenamed
            // 
            this.lblFilesRenamed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilesRenamed.Location = new System.Drawing.Point(12, 526);
            this.lblFilesRenamed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilesRenamed.Name = "lblFilesRenamed";
            this.lblFilesRenamed.Size = new System.Drawing.Size(243, 22);
            this.lblFilesRenamed.TabIndex = 0;
            this.lblFilesRenamed.Text = "lblFilesRenamed";
            // 
            // chkCaseSensitive
            // 
            this.chkCaseSensitive.AutoSize = true;
            this.chkCaseSensitive.Location = new System.Drawing.Point(144, 80);
            this.chkCaseSensitive.Margin = new System.Windows.Forms.Padding(4);
            this.chkCaseSensitive.Name = "chkCaseSensitive";
            this.chkCaseSensitive.Size = new System.Drawing.Size(123, 21);
            this.chkCaseSensitive.TabIndex = 8;
            this.chkCaseSensitive.Text = "Case Sensitive";
            this.chkCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cboFileTypes
            // 
            this.cboFileTypes.FormattingEnabled = true;
            this.cboFileTypes.Location = new System.Drawing.Point(164, 48);
            this.cboFileTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cboFileTypes.Name = "cboFileTypes";
            this.cboFileTypes.Size = new System.Drawing.Size(244, 24);
            this.cboFileTypes.TabIndex = 6;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(371, 520);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
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
            this.flpOptions.Location = new System.Drawing.Point(16, 181);
            this.flpOptions.Margin = new System.Windows.Forms.Padding(4);
            this.flpOptions.Name = "flpOptions";
            this.flpOptions.Size = new System.Drawing.Size(671, 332);
            this.flpOptions.TabIndex = 9;
            // 
            // lblTargetText
            // 
            this.lblTargetText.AutoSize = true;
            this.lblTargetText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetText.Location = new System.Drawing.Point(4, 0);
            this.lblTargetText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTargetText.Name = "lblTargetText";
            this.lblTargetText.Size = new System.Drawing.Size(84, 17);
            this.lblTargetText.TabIndex = 28;
            this.lblTargetText.Text = "I want to...";
            // 
            // rbtFindAndReplace
            // 
            this.rbtFindAndReplace.AutoSize = true;
            this.rbtFindAndReplace.Location = new System.Drawing.Point(4, 21);
            this.rbtFindAndReplace.Margin = new System.Windows.Forms.Padding(4);
            this.rbtFindAndReplace.Name = "rbtFindAndReplace";
            this.rbtFindAndReplace.Size = new System.Drawing.Size(282, 21);
            this.rbtFindAndReplace.TabIndex = 30;
            this.rbtFindAndReplace.TabStop = true;
            this.rbtFindAndReplace.Text = "Find and replace characters in file name";
            this.rbtFindAndReplace.UseVisualStyleBackColor = true;
            this.rbtFindAndReplace.CheckedChanged += new System.EventHandler(this.rbtFindAndReplace_CheckedChanged);
            // 
            // panFindAndReplace
            // 
            this.panFindAndReplace.Controls.Add(this.chkUseRegex);
            this.panFindAndReplace.Controls.Add(this.chkCaseSensitive);
            this.panFindAndReplace.Controls.Add(this.lblReplace);
            this.panFindAndReplace.Controls.Add(this.cboReplace);
            this.panFindAndReplace.Controls.Add(this.lblFind);
            this.panFindAndReplace.Controls.Add(this.ddlFind);
            this.panFindAndReplace.Location = new System.Drawing.Point(4, 50);
            this.panFindAndReplace.Margin = new System.Windows.Forms.Padding(4);
            this.panFindAndReplace.Name = "panFindAndReplace";
            this.panFindAndReplace.Size = new System.Drawing.Size(629, 133);
            this.panFindAndReplace.TabIndex = 33;
            // 
            // chkUseRegex
            // 
            this.chkUseRegex.AutoSize = true;
            this.chkUseRegex.Location = new System.Drawing.Point(144, 108);
            this.chkUseRegex.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseRegex.Name = "chkUseRegex";
            this.chkUseRegex.Size = new System.Drawing.Size(99, 21);
            this.chkUseRegex.TabIndex = 9;
            this.chkUseRegex.Text = "Use Regex";
            this.chkUseRegex.UseVisualStyleBackColor = true;
            this.chkUseRegex.CheckedChanged += new System.EventHandler(this.chkUseRegex_CheckedChanged);
            // 
            // ddlFind
            // 
            this.ddlFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFind.FormattingEnabled = true;
            this.ddlFind.Location = new System.Drawing.Point(144, 15);
            this.ddlFind.Margin = new System.Windows.Forms.Padding(4);
            this.ddlFind.Name = "ddlFind";
            this.ddlFind.Size = new System.Drawing.Size(465, 24);
            this.ddlFind.TabIndex = 0;
            // 
            // rbtAppend
            // 
            this.rbtAppend.AutoSize = true;
            this.rbtAppend.Location = new System.Drawing.Point(4, 191);
            this.rbtAppend.Margin = new System.Windows.Forms.Padding(4);
            this.rbtAppend.Name = "rbtAppend";
            this.rbtAppend.Size = new System.Drawing.Size(260, 21);
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
            this.panAppend.Location = new System.Drawing.Point(4, 220);
            this.panAppend.Margin = new System.Windows.Forms.Padding(4);
            this.panAppend.Name = "panAppend";
            this.panAppend.Size = new System.Drawing.Size(629, 85);
            this.panAppend.TabIndex = 32;
            // 
            // rbtTrimCharacters
            // 
            this.rbtTrimCharacters.AutoSize = true;
            this.rbtTrimCharacters.Location = new System.Drawing.Point(641, 4);
            this.rbtTrimCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.rbtTrimCharacters.Name = "rbtTrimCharacters";
            this.rbtTrimCharacters.Size = new System.Drawing.Size(199, 21);
            this.rbtTrimCharacters.TabIndex = 35;
            this.rbtTrimCharacters.TabStop = true;
            this.rbtTrimCharacters.Text = "Trim characters from name";
            this.rbtTrimCharacters.UseVisualStyleBackColor = true;
            this.rbtTrimCharacters.CheckedChanged += new System.EventHandler(this.rbtTrimCharacters_CheckedChanged);
            // 
            // panTrimCharacters
            // 
            this.panTrimCharacters.Controls.Add(this.nudRemoveTrailingCharacters);
            this.panTrimCharacters.Controls.Add(this.nudRemoveLeadingCharacters);
            this.panTrimCharacters.Controls.Add(this.rbtRemoveUrlEncoding);
            this.panTrimCharacters.Controls.Add(this.rbtTruncateWhiteSpace);
            this.panTrimCharacters.Controls.Add(this.rbtRemoveTrailingCharacter);
            this.panTrimCharacters.Controls.Add(this.rbtRemoveLeadingCharacter);
            this.panTrimCharacters.Location = new System.Drawing.Point(641, 33);
            this.panTrimCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.panTrimCharacters.Name = "panTrimCharacters";
            this.panTrimCharacters.Size = new System.Drawing.Size(629, 132);
            this.panTrimCharacters.TabIndex = 34;
            // 
            // nudRemoveTrailingCharacters
            // 
            this.nudRemoveTrailingCharacters.Location = new System.Drawing.Point(365, 73);
            this.nudRemoveTrailingCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.nudRemoveTrailingCharacters.Name = "nudRemoveTrailingCharacters";
            this.nudRemoveTrailingCharacters.Size = new System.Drawing.Size(96, 22);
            this.nudRemoveTrailingCharacters.TabIndex = 41;
            this.nudRemoveTrailingCharacters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudRemoveLeadingCharacters
            // 
            this.nudRemoveLeadingCharacters.Location = new System.Drawing.Point(365, 44);
            this.nudRemoveLeadingCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.nudRemoveLeadingCharacters.Name = "nudRemoveLeadingCharacters";
            this.nudRemoveLeadingCharacters.Size = new System.Drawing.Size(96, 22);
            this.nudRemoveLeadingCharacters.TabIndex = 40;
            this.nudRemoveLeadingCharacters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbtRemoveUrlEncoding
            // 
            this.rbtRemoveUrlEncoding.AutoSize = true;
            this.rbtRemoveUrlEncoding.Location = new System.Drawing.Point(144, 101);
            this.rbtRemoveUrlEncoding.Margin = new System.Windows.Forms.Padding(4);
            this.rbtRemoveUrlEncoding.Name = "rbtRemoveUrlEncoding";
            this.rbtRemoveUrlEncoding.Size = new System.Drawing.Size(176, 21);
            this.rbtRemoveUrlEncoding.TabIndex = 39;
            this.rbtRemoveUrlEncoding.TabStop = true;
            this.rbtRemoveUrlEncoding.Text = "Remove URL Encoding";
            this.rbtRemoveUrlEncoding.UseVisualStyleBackColor = true;
            // 
            // rbtTruncateWhiteSpace
            // 
            this.rbtTruncateWhiteSpace.AutoSize = true;
            this.rbtTruncateWhiteSpace.Location = new System.Drawing.Point(144, 16);
            this.rbtTruncateWhiteSpace.Margin = new System.Windows.Forms.Padding(4);
            this.rbtTruncateWhiteSpace.Name = "rbtTruncateWhiteSpace";
            this.rbtTruncateWhiteSpace.Size = new System.Drawing.Size(170, 21);
            this.rbtTruncateWhiteSpace.TabIndex = 38;
            this.rbtTruncateWhiteSpace.TabStop = true;
            this.rbtTruncateWhiteSpace.Text = "Truncate White Space";
            this.rbtTruncateWhiteSpace.UseVisualStyleBackColor = true;
            // 
            // rbtRemoveTrailingCharacter
            // 
            this.rbtRemoveTrailingCharacter.AutoSize = true;
            this.rbtRemoveTrailingCharacter.Location = new System.Drawing.Point(144, 73);
            this.rbtRemoveTrailingCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.rbtRemoveTrailingCharacter.Name = "rbtRemoveTrailingCharacter";
            this.rbtRemoveTrailingCharacter.Size = new System.Drawing.Size(198, 21);
            this.rbtRemoveTrailingCharacter.TabIndex = 37;
            this.rbtRemoveTrailingCharacter.TabStop = true;
            this.rbtRemoveTrailingCharacter.Text = "Remove Trailing Character";
            this.rbtRemoveTrailingCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtRemoveLeadingCharacter
            // 
            this.rbtRemoveLeadingCharacter.AutoSize = true;
            this.rbtRemoveLeadingCharacter.Location = new System.Drawing.Point(144, 44);
            this.rbtRemoveLeadingCharacter.Margin = new System.Windows.Forms.Padding(4);
            this.rbtRemoveLeadingCharacter.Name = "rbtRemoveLeadingCharacter";
            this.rbtRemoveLeadingCharacter.Size = new System.Drawing.Size(209, 21);
            this.rbtRemoveLeadingCharacter.TabIndex = 36;
            this.rbtRemoveLeadingCharacter.TabStop = true;
            this.rbtRemoveLeadingCharacter.Text = "Remove Leading Characters";
            this.rbtRemoveLeadingCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtRestrictLength
            // 
            this.rbtRestrictLength.AutoSize = true;
            this.rbtRestrictLength.Location = new System.Drawing.Point(641, 173);
            this.rbtRestrictLength.Margin = new System.Windows.Forms.Padding(4);
            this.rbtRestrictLength.Name = "rbtRestrictLength";
            this.rbtRestrictLength.Size = new System.Drawing.Size(181, 21);
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
            this.panRestrictLength.Location = new System.Drawing.Point(641, 202);
            this.panRestrictLength.Margin = new System.Windows.Forms.Padding(4);
            this.panRestrictLength.Name = "panRestrictLength";
            this.panRestrictLength.Size = new System.Drawing.Size(629, 48);
            this.panRestrictLength.TabIndex = 37;
            // 
            // nudMaxNameLength
            // 
            this.nudMaxNameLength.Location = new System.Drawing.Point(147, 11);
            this.nudMaxNameLength.Margin = new System.Windows.Forms.Padding(4);
            this.nudMaxNameLength.Name = "nudMaxNameLength";
            this.nudMaxNameLength.Size = new System.Drawing.Size(96, 22);
            this.nudMaxNameLength.TabIndex = 1;
            this.nudMaxNameLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maximum Length";
            // 
            // rbtChangeCase
            // 
            this.rbtChangeCase.AutoSize = true;
            this.rbtChangeCase.Location = new System.Drawing.Point(641, 258);
            this.rbtChangeCase.Margin = new System.Windows.Forms.Padding(4);
            this.rbtChangeCase.Name = "rbtChangeCase";
            this.rbtChangeCase.Size = new System.Drawing.Size(173, 21);
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
            this.panChangeCase.Location = new System.Drawing.Point(1278, 4);
            this.panChangeCase.Margin = new System.Windows.Forms.Padding(4);
            this.panChangeCase.Name = "panChangeCase";
            this.panChangeCase.Size = new System.Drawing.Size(629, 52);
            this.panChangeCase.TabIndex = 39;
            // 
            // rbtRunScript
            // 
            this.rbtRunScript.AutoSize = true;
            this.rbtRunScript.Location = new System.Drawing.Point(1278, 64);
            this.rbtRunScript.Margin = new System.Windows.Forms.Padding(4);
            this.rbtRunScript.Name = "rbtRunScript";
            this.rbtRunScript.Size = new System.Drawing.Size(157, 21);
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
            this.panRunScript.Location = new System.Drawing.Point(1278, 93);
            this.panRunScript.Margin = new System.Windows.Forms.Padding(4);
            this.panRunScript.Name = "panRunScript";
            this.panRunScript.Size = new System.Drawing.Size(629, 66);
            this.panRunScript.TabIndex = 41;
            // 
            // btnSelectScript
            // 
            this.btnSelectScript.Location = new System.Drawing.Point(28, 15);
            this.btnSelectScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectScript.Name = "btnSelectScript";
            this.btnSelectScript.Size = new System.Drawing.Size(108, 28);
            this.btnSelectScript.TabIndex = 21;
            this.btnSelectScript.Text = "Select Script";
            this.btnSelectScript.UseVisualStyleBackColor = true;
            this.btnSelectScript.Click += new System.EventHandler(this.btnRunScript_Click);
            // 
            // cboScriptList
            // 
            this.cboScriptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboScriptList.FormattingEnabled = true;
            this.cboScriptList.Location = new System.Drawing.Point(144, 17);
            this.cboScriptList.Margin = new System.Windows.Forms.Padding(4);
            this.cboScriptList.Name = "cboScriptList";
            this.cboScriptList.Size = new System.Drawing.Size(464, 24);
            this.cboScriptList.TabIndex = 22;
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Location = new System.Drawing.Point(4, 62);
            this.chkRecursive.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(176, 21);
            this.chkRecursive.TabIndex = 10;
            this.chkRecursive.Text = "Process Subdirectories";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // chkLogChanges
            // 
            this.chkLogChanges.AutoSize = true;
            this.chkLogChanges.Location = new System.Drawing.Point(400, 4);
            this.chkLogChanges.Margin = new System.Windows.Forms.Padding(4);
            this.chkLogChanges.Name = "chkLogChanges";
            this.chkLogChanges.Size = new System.Drawing.Size(171, 21);
            this.chkLogChanges.TabIndex = 12;
            this.chkLogChanges.Text = "Generate Change Log";
            this.chkLogChanges.UseVisualStyleBackColor = true;
            // 
            // chkLowerExtensions
            // 
            this.chkLowerExtensions.AutoSize = true;
            this.chkLowerExtensions.Location = new System.Drawing.Point(188, 4);
            this.chkLowerExtensions.Margin = new System.Windows.Forms.Padding(4);
            this.chkLowerExtensions.Name = "chkLowerExtensions";
            this.chkLowerExtensions.Size = new System.Drawing.Size(204, 21);
            this.chkLowerExtensions.TabIndex = 15;
            this.chkLowerExtensions.Text = "Standardize File Extensions";
            this.chkLowerExtensions.UseVisualStyleBackColor = true;
            this.chkLowerExtensions.CheckedChanged += new System.EventHandler(this.chkLowerExtensions_CheckedChanged);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(479, 520);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 28);
            this.btnAbout.TabIndex = 24;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // chkCreatePlaylist
            // 
            this.chkCreatePlaylist.AutoSize = true;
            this.chkCreatePlaylist.Location = new System.Drawing.Point(400, 33);
            this.chkCreatePlaylist.Margin = new System.Windows.Forms.Padding(4);
            this.chkCreatePlaylist.Name = "chkCreatePlaylist";
            this.chkCreatePlaylist.Size = new System.Drawing.Size(120, 21);
            this.chkCreatePlaylist.TabIndex = 28;
            this.chkCreatePlaylist.Tag = "";
            this.chkCreatePlaylist.Text = "Create Playlist";
            this.chkCreatePlaylist.UseVisualStyleBackColor = true;
            // 
            // chkStandardizeFileProperties
            // 
            this.chkStandardizeFileProperties.AutoSize = true;
            this.chkStandardizeFileProperties.Location = new System.Drawing.Point(188, 62);
            this.chkStandardizeFileProperties.Margin = new System.Windows.Forms.Padding(4);
            this.chkStandardizeFileProperties.Name = "chkStandardizeFileProperties";
            this.chkStandardizeFileProperties.Size = new System.Drawing.Size(201, 21);
            this.chkStandardizeFileProperties.TabIndex = 29;
            this.chkStandardizeFileProperties.Tag = "";
            this.chkStandardizeFileProperties.Text = "Standardize File Properties";
            this.chkStandardizeFileProperties.UseVisualStyleBackColor = true;
            // 
            // chkProcessFiles
            // 
            this.chkProcessFiles.AutoSize = true;
            this.chkProcessFiles.Location = new System.Drawing.Point(4, 33);
            this.chkProcessFiles.Margin = new System.Windows.Forms.Padding(4);
            this.chkProcessFiles.Name = "chkProcessFiles";
            this.chkProcessFiles.Size = new System.Drawing.Size(114, 21);
            this.chkProcessFiles.TabIndex = 30;
            this.chkProcessFiles.Tag = "";
            this.chkProcessFiles.Text = "Process Files";
            this.chkProcessFiles.UseVisualStyleBackColor = true;
            // 
            // chkProcessDirectories
            // 
            this.chkProcessDirectories.AutoSize = true;
            this.chkProcessDirectories.Location = new System.Drawing.Point(4, 4);
            this.chkProcessDirectories.Margin = new System.Windows.Forms.Padding(4);
            this.chkProcessDirectories.Name = "chkProcessDirectories";
            this.chkProcessDirectories.Size = new System.Drawing.Size(153, 21);
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
            this.flpCheckBoxGrid.Location = new System.Drawing.Point(16, 81);
            this.flpCheckBoxGrid.Margin = new System.Windows.Forms.Padding(4);
            this.flpCheckBoxGrid.Name = "flpCheckBoxGrid";
            this.flpCheckBoxGrid.Size = new System.Drawing.Size(671, 92);
            this.flpCheckBoxGrid.TabIndex = 30;
            // 
            // chkPreserveExtensions
            // 
            this.chkPreserveExtensions.AutoSize = true;
            this.chkPreserveExtensions.Location = new System.Drawing.Point(188, 33);
            this.chkPreserveExtensions.Margin = new System.Windows.Forms.Padding(4);
            this.chkPreserveExtensions.Name = "chkPreserveExtensions";
            this.chkPreserveExtensions.Size = new System.Drawing.Size(178, 21);
            this.chkPreserveExtensions.TabIndex = 31;
            this.chkPreserveExtensions.Tag = "";
            this.chkPreserveExtensions.Text = "Preserve File Extension";
            this.chkPreserveExtensions.UseVisualStyleBackColor = true;
            this.chkPreserveExtensions.CheckedChanged += new System.EventHandler(this.chkPreserveExtensions_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 560);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(721, 605);
            this.Name = "FrmMain";
            this.Text = "Assembly Name Here";
            this.flpOptions.ResumeLayout(false);
            this.flpOptions.PerformLayout();
            this.panFindAndReplace.ResumeLayout(false);
            this.panFindAndReplace.PerformLayout();
            this.panAppend.ResumeLayout(false);
            this.panAppend.PerformLayout();
            this.panTrimCharacters.ResumeLayout(false);
            this.panTrimCharacters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveTrailingCharacters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRemoveLeadingCharacters)).EndInit();
            this.panRestrictLength.ResumeLayout(false);
            this.panRestrictLength.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNameLength)).EndInit();
            this.panChangeCase.ResumeLayout(false);
            this.panChangeCase.PerformLayout();
            this.panRunScript.ResumeLayout(false);
            this.flpCheckBoxGrid.ResumeLayout(false);
            this.flpCheckBoxGrid.PerformLayout();
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

