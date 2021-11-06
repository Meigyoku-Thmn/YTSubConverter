namespace YTSubConverter.UI.Win
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._spltStyleOptions = new System.Windows.Forms.SplitContainer();
            this._lstStyles = new System.Windows.Forms.ListBox();
            this._btnBackgroundImage = new System.Windows.Forms.Button();
            this._brwPreview = new System.Windows.Forms.WebBrowser();
            this._pnlOptions = new System.Windows.Forms.Panel();
            this._pnlKaraokeType = new System.Windows.Forms.Panel();
            this._chkClearFontSize = new System.Windows.Forms.CheckBox();
            this._chkKeepFontName = new System.Windows.Forms.CheckBox();
            this._lblAdvancedConfig = new System.Windows.Forms.Label();
            this._chkNoSpacePadding = new System.Windows.Forms.CheckBox();
            this._chkClearBGAndFGStyle = new System.Windows.Forms.CheckBox();
            this._btnCurrentWordShadowColor = new System.Windows.Forms.Button();
            this._btnCurrentWordOutlineColor = new System.Windows.Forms.Button();
            this._btnCurrentWordTextColor = new System.Windows.Forms.Button();
            this._txtCurrentWordShadowColor = new System.Windows.Forms.TextBox();
            this._txtCurrentWordOutlineColor = new System.Windows.Forms.TextBox();
            this._txtCurrentWordTextColor = new System.Windows.Forms.TextBox();
            this._lblCurrentWordShadowColor = new System.Windows.Forms.Label();
            this._lblCurrentWordOutlineColor = new System.Windows.Forms.Label();
            this._lblCurrentWordTextColor = new System.Windows.Forms.Label();
            this._chkHighlightCurrentWord = new System.Windows.Forms.CheckBox();
            this._chkKaraoke = new System.Windows.Forms.CheckBox();
            this._pnlShadowType = new System.Windows.Forms.Panel();
            this._chkHardShadow = new System.Windows.Forms.CheckBox();
            this._chkSoftShadow = new System.Windows.Forms.CheckBox();
            this._chkBevel = new System.Windows.Forms.CheckBox();
            this._chkGlow = new System.Windows.Forms.CheckBox();
            this._lblShadowTypes = new System.Windows.Forms.Label();
            this._txtInputFile = new System.Windows.Forms.TextBox();
            this._grpStyleOptions = new System.Windows.Forms.GroupBox();
            this._dlgOpenSubtitles = new System.Windows.Forms.OpenFileDialog();
            this._btnConvert = new System.Windows.Forms.Button();
            this._lblConversionSuccess = new System.Windows.Forms.Label();
            this._btnBrowse = new System.Windows.Forms.Button();
            this._chkStyleOptions = new System.Windows.Forms.CheckBox();
            this._dlgColor = new System.Windows.Forms.ColorDialog();
            this._dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._chkAutoConvert = new System.Windows.Forms.CheckBox();
            this._subtitleRenameWatcher = new System.IO.FileSystemWatcher();
            this._subtitleModifyWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this._spltStyleOptions)).BeginInit();
            this._spltStyleOptions.Panel1.SuspendLayout();
            this._spltStyleOptions.Panel2.SuspendLayout();
            this._spltStyleOptions.SuspendLayout();
            this._pnlOptions.SuspendLayout();
            this._pnlKaraokeType.SuspendLayout();
            this._pnlShadowType.SuspendLayout();
            this._grpStyleOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._subtitleRenameWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._subtitleModifyWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // _spltStyleOptions
            // 
            this._spltStyleOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this._spltStyleOptions.Location = new System.Drawing.Point(7, 27);
            this._spltStyleOptions.Margin = new System.Windows.Forms.Padding(4);
            this._spltStyleOptions.Name = "_spltStyleOptions";
            // 
            // _spltStyleOptions.Panel1
            // 
            this._spltStyleOptions.Panel1.Controls.Add(this._lstStyles);
            // 
            // _spltStyleOptions.Panel2
            // 
            this._spltStyleOptions.Panel2.Controls.Add(this._btnBackgroundImage);
            this._spltStyleOptions.Panel2.Controls.Add(this._brwPreview);
            this._spltStyleOptions.Panel2.Controls.Add(this._pnlOptions);
            this._spltStyleOptions.Size = new System.Drawing.Size(1202, 438);
            this._spltStyleOptions.SplitterDistance = 396;
            this._spltStyleOptions.SplitterWidth = 5;
            this._spltStyleOptions.TabIndex = 5;
            // 
            // _lstStyles
            // 
            this._lstStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lstStyles.FormattingEnabled = true;
            this._lstStyles.IntegralHeight = false;
            this._lstStyles.ItemHeight = 16;
            this._lstStyles.Location = new System.Drawing.Point(0, 0);
            this._lstStyles.Margin = new System.Windows.Forms.Padding(4);
            this._lstStyles.Name = "_lstStyles";
            this._lstStyles.Size = new System.Drawing.Size(396, 438);
            this._lstStyles.TabIndex = 0;
            this._lstStyles.SelectedIndexChanged += new System.EventHandler(this._lstStyles_SelectedIndexChanged);
            // 
            // _btnBackgroundImage
            // 
            this._btnBackgroundImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBackgroundImage.Location = new System.Drawing.Point(745, 175);
            this._btnBackgroundImage.Margin = new System.Windows.Forms.Padding(4);
            this._btnBackgroundImage.Name = "_btnBackgroundImage";
            this._btnBackgroundImage.Size = new System.Drawing.Size(39, 28);
            this._btnBackgroundImage.TabIndex = 7;
            this._btnBackgroundImage.Text = "...";
            this._btnBackgroundImage.UseVisualStyleBackColor = true;
            this._btnBackgroundImage.Click += new System.EventHandler(this._btnBackgroundImage_Click);
            // 
            // _brwPreview
            // 
            this._brwPreview.AllowWebBrowserDrop = false;
            this._brwPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._brwPreview.IsWebBrowserContextMenuEnabled = false;
            this._brwPreview.Location = new System.Drawing.Point(0, 168);
            this._brwPreview.Margin = new System.Windows.Forms.Padding(4);
            this._brwPreview.MinimumSize = new System.Drawing.Size(27, 24);
            this._brwPreview.Name = "_brwPreview";
            this._brwPreview.Size = new System.Drawing.Size(801, 270);
            this._brwPreview.TabIndex = 0;
            this._brwPreview.WebBrowserShortcutsEnabled = false;
            // 
            // _pnlOptions
            // 
            this._pnlOptions.Controls.Add(this._pnlKaraokeType);
            this._pnlOptions.Controls.Add(this._pnlShadowType);
            this._pnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlOptions.Location = new System.Drawing.Point(0, 0);
            this._pnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this._pnlOptions.Name = "_pnlOptions";
            this._pnlOptions.Size = new System.Drawing.Size(801, 168);
            this._pnlOptions.TabIndex = 6;
            // 
            // _pnlKaraokeType
            // 
            this._pnlKaraokeType.Controls.Add(this._chkClearFontSize);
            this._pnlKaraokeType.Controls.Add(this._chkKeepFontName);
            this._pnlKaraokeType.Controls.Add(this._lblAdvancedConfig);
            this._pnlKaraokeType.Controls.Add(this._chkNoSpacePadding);
            this._pnlKaraokeType.Controls.Add(this._chkClearBGAndFGStyle);
            this._pnlKaraokeType.Controls.Add(this._btnCurrentWordShadowColor);
            this._pnlKaraokeType.Controls.Add(this._btnCurrentWordOutlineColor);
            this._pnlKaraokeType.Controls.Add(this._btnCurrentWordTextColor);
            this._pnlKaraokeType.Controls.Add(this._txtCurrentWordShadowColor);
            this._pnlKaraokeType.Controls.Add(this._txtCurrentWordOutlineColor);
            this._pnlKaraokeType.Controls.Add(this._txtCurrentWordTextColor);
            this._pnlKaraokeType.Controls.Add(this._lblCurrentWordShadowColor);
            this._pnlKaraokeType.Controls.Add(this._lblCurrentWordOutlineColor);
            this._pnlKaraokeType.Controls.Add(this._lblCurrentWordTextColor);
            this._pnlKaraokeType.Controls.Add(this._chkHighlightCurrentWord);
            this._pnlKaraokeType.Controls.Add(this._chkKaraoke);
            this._pnlKaraokeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlKaraokeType.Location = new System.Drawing.Point(187, 0);
            this._pnlKaraokeType.Margin = new System.Windows.Forms.Padding(4);
            this._pnlKaraokeType.Name = "_pnlKaraokeType";
            this._pnlKaraokeType.Size = new System.Drawing.Size(614, 168);
            this._pnlKaraokeType.TabIndex = 6;
            // 
            // _chkClearFontSize
            // 
            this._chkClearFontSize.AutoSize = true;
            this._chkClearFontSize.Location = new System.Drawing.Point(303, 61);
            this._chkClearFontSize.Name = "_chkClearFontSize";
            this._chkClearFontSize.Size = new System.Drawing.Size(120, 21);
            this._chkClearFontSize.TabIndex = 16;
            this._chkClearFontSize.Text = "Clear font size";
            this._chkClearFontSize.UseVisualStyleBackColor = true;
            this._chkClearFontSize.CheckedChanged += new System.EventHandler(this._chkClearFontSize_CheckedChanged);
            // 
            // _chkKeepFontName
            // 
            this._chkKeepFontName.AutoSize = true;
            this._chkKeepFontName.Location = new System.Drawing.Point(303, 34);
            this._chkKeepFontName.Name = "_chkKeepFontName";
            this._chkKeepFontName.Size = new System.Drawing.Size(274, 21);
            this._chkKeepFontName.TabIndex = 15;
            this._chkKeepFontName.Text = "Pin font name to avoid being overriden";
            this._chkKeepFontName.UseVisualStyleBackColor = true;
            this._chkKeepFontName.CheckedChanged += new System.EventHandler(this._chkKeepFontName_CheckedChanged);
            // 
            // _lblAdvancedConfig
            // 
            this._lblAdvancedConfig.AutoSize = true;
            this._lblAdvancedConfig.Location = new System.Drawing.Point(285, 10);
            this._lblAdvancedConfig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblAdvancedConfig.Name = "_lblAdvancedConfig";
            this._lblAdvancedConfig.Size = new System.Drawing.Size(254, 17);
            this._lblAdvancedConfig.TabIndex = 4;
            this._lblAdvancedConfig.Text = "Advanced configuration for *.ytt output:";
            // 
            // _chkNoSpacePadding
            // 
            this._chkNoSpacePadding.AutoSize = true;
            this._chkNoSpacePadding.Location = new System.Drawing.Point(303, 115);
            this._chkNoSpacePadding.Name = "_chkNoSpacePadding";
            this._chkNoSpacePadding.Size = new System.Drawing.Size(202, 21);
            this._chkNoSpacePadding.TabIndex = 14;
            this._chkNoSpacePadding.Text = "Don\'t use space in padding";
            this._chkNoSpacePadding.UseVisualStyleBackColor = true;
            this._chkNoSpacePadding.CheckedChanged += new System.EventHandler(this._chkNoSpacePadding_CheckedChanged);
            // 
            // _chkClearBGAndFGStyle
            // 
            this._chkClearBGAndFGStyle.AutoSize = true;
            this._chkClearBGAndFGStyle.Location = new System.Drawing.Point(303, 88);
            this._chkClearBGAndFGStyle.Name = "_chkClearBGAndFGStyle";
            this._chkClearBGAndFGStyle.Size = new System.Drawing.Size(277, 21);
            this._chkClearBGAndFGStyle.TabIndex = 12;
            this._chkClearBGAndFGStyle.Text = "Clear background and foreground style";
            this._chkClearBGAndFGStyle.UseVisualStyleBackColor = true;
            this._chkClearBGAndFGStyle.CheckedChanged += new System.EventHandler(this._chkClearBGAndFGStyle_CheckedChanged);
            // 
            // _btnCurrentWordShadowColor
            // 
            this._btnCurrentWordShadowColor.Enabled = false;
            this._btnCurrentWordShadowColor.Location = new System.Drawing.Point(233, 130);
            this._btnCurrentWordShadowColor.Margin = new System.Windows.Forms.Padding(4);
            this._btnCurrentWordShadowColor.Name = "_btnCurrentWordShadowColor";
            this._btnCurrentWordShadowColor.Size = new System.Drawing.Size(47, 25);
            this._btnCurrentWordShadowColor.TabIndex = 10;
            this._btnCurrentWordShadowColor.UseVisualStyleBackColor = true;
            this._btnCurrentWordShadowColor.Click += new System.EventHandler(this._btnCurrentWordShadowColor_Click);
            // 
            // _btnCurrentWordOutlineColor
            // 
            this._btnCurrentWordOutlineColor.Enabled = false;
            this._btnCurrentWordOutlineColor.Location = new System.Drawing.Point(233, 95);
            this._btnCurrentWordOutlineColor.Margin = new System.Windows.Forms.Padding(4);
            this._btnCurrentWordOutlineColor.Name = "_btnCurrentWordOutlineColor";
            this._btnCurrentWordOutlineColor.Size = new System.Drawing.Size(47, 25);
            this._btnCurrentWordOutlineColor.TabIndex = 8;
            this._btnCurrentWordOutlineColor.UseVisualStyleBackColor = true;
            this._btnCurrentWordOutlineColor.Click += new System.EventHandler(this._btnCurrentWordOutlineColor_Click);
            // 
            // _btnCurrentWordTextColor
            // 
            this._btnCurrentWordTextColor.Enabled = false;
            this._btnCurrentWordTextColor.Location = new System.Drawing.Point(233, 61);
            this._btnCurrentWordTextColor.Margin = new System.Windows.Forms.Padding(4);
            this._btnCurrentWordTextColor.Name = "_btnCurrentWordTextColor";
            this._btnCurrentWordTextColor.Size = new System.Drawing.Size(47, 25);
            this._btnCurrentWordTextColor.TabIndex = 6;
            this._btnCurrentWordTextColor.UseVisualStyleBackColor = true;
            this._btnCurrentWordTextColor.Click += new System.EventHandler(this._btnCurrentWordTextColor_Click);
            // 
            // _txtCurrentWordShadowColor
            // 
            this._txtCurrentWordShadowColor.Enabled = false;
            this._txtCurrentWordShadowColor.Location = new System.Drawing.Point(140, 131);
            this._txtCurrentWordShadowColor.Margin = new System.Windows.Forms.Padding(4);
            this._txtCurrentWordShadowColor.Name = "_txtCurrentWordShadowColor";
            this._txtCurrentWordShadowColor.Size = new System.Drawing.Size(85, 22);
            this._txtCurrentWordShadowColor.TabIndex = 9;
            this._txtCurrentWordShadowColor.TextChanged += new System.EventHandler(this._txtCurrentWordShadowColor_TextChanged);
            // 
            // _txtCurrentWordOutlineColor
            // 
            this._txtCurrentWordOutlineColor.Enabled = false;
            this._txtCurrentWordOutlineColor.Location = new System.Drawing.Point(140, 96);
            this._txtCurrentWordOutlineColor.Margin = new System.Windows.Forms.Padding(4);
            this._txtCurrentWordOutlineColor.Name = "_txtCurrentWordOutlineColor";
            this._txtCurrentWordOutlineColor.Size = new System.Drawing.Size(85, 22);
            this._txtCurrentWordOutlineColor.TabIndex = 7;
            this._txtCurrentWordOutlineColor.TextChanged += new System.EventHandler(this._txtCurrentWordOutlineColor_TextChanged);
            // 
            // _txtCurrentWordTextColor
            // 
            this._txtCurrentWordTextColor.Enabled = false;
            this._txtCurrentWordTextColor.Location = new System.Drawing.Point(140, 62);
            this._txtCurrentWordTextColor.Margin = new System.Windows.Forms.Padding(4);
            this._txtCurrentWordTextColor.Name = "_txtCurrentWordTextColor";
            this._txtCurrentWordTextColor.Size = new System.Drawing.Size(85, 22);
            this._txtCurrentWordTextColor.TabIndex = 5;
            this._txtCurrentWordTextColor.TextChanged += new System.EventHandler(this._txtCurrentWordTextColor_TextChanged);
            // 
            // _lblCurrentWordShadowColor
            // 
            this._lblCurrentWordShadowColor.AutoSize = true;
            this._lblCurrentWordShadowColor.Enabled = false;
            this._lblCurrentWordShadowColor.Location = new System.Drawing.Point(22, 134);
            this._lblCurrentWordShadowColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCurrentWordShadowColor.Name = "_lblCurrentWordShadowColor";
            this._lblCurrentWordShadowColor.Size = new System.Drawing.Size(97, 17);
            this._lblCurrentWordShadowColor.TabIndex = 4;
            this._lblCurrentWordShadowColor.Text = "Shadow color:";
            // 
            // _lblCurrentWordOutlineColor
            // 
            this._lblCurrentWordOutlineColor.AutoSize = true;
            this._lblCurrentWordOutlineColor.Enabled = false;
            this._lblCurrentWordOutlineColor.Location = new System.Drawing.Point(22, 99);
            this._lblCurrentWordOutlineColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCurrentWordOutlineColor.Name = "_lblCurrentWordOutlineColor";
            this._lblCurrentWordOutlineColor.Size = new System.Drawing.Size(92, 17);
            this._lblCurrentWordOutlineColor.TabIndex = 3;
            this._lblCurrentWordOutlineColor.Text = "Outline color:";
            // 
            // _lblCurrentWordTextColor
            // 
            this._lblCurrentWordTextColor.AutoSize = true;
            this._lblCurrentWordTextColor.Enabled = false;
            this._lblCurrentWordTextColor.Location = new System.Drawing.Point(22, 65);
            this._lblCurrentWordTextColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblCurrentWordTextColor.Name = "_lblCurrentWordTextColor";
            this._lblCurrentWordTextColor.Size = new System.Drawing.Size(74, 17);
            this._lblCurrentWordTextColor.TabIndex = 2;
            this._lblCurrentWordTextColor.Text = "Text color:";
            // 
            // _chkHighlightCurrentWord
            // 
            this._chkHighlightCurrentWord.AutoSize = true;
            this._chkHighlightCurrentWord.Enabled = false;
            this._chkHighlightCurrentWord.Location = new System.Drawing.Point(8, 34);
            this._chkHighlightCurrentWord.Margin = new System.Windows.Forms.Padding(4);
            this._chkHighlightCurrentWord.Name = "_chkHighlightCurrentWord";
            this._chkHighlightCurrentWord.Size = new System.Drawing.Size(168, 21);
            this._chkHighlightCurrentWord.TabIndex = 1;
            this._chkHighlightCurrentWord.Text = "Highlight current word";
            this._chkHighlightCurrentWord.UseVisualStyleBackColor = true;
            this._chkHighlightCurrentWord.CheckedChanged += new System.EventHandler(this._chkHighlightCurrentWord_CheckedChanged);
            // 
            // _chkKaraoke
            // 
            this._chkKaraoke.AutoSize = true;
            this._chkKaraoke.Location = new System.Drawing.Point(8, 9);
            this._chkKaraoke.Margin = new System.Windows.Forms.Padding(4);
            this._chkKaraoke.Name = "_chkKaraoke";
            this._chkKaraoke.Size = new System.Drawing.Size(131, 21);
            this._chkKaraoke.TabIndex = 0;
            this._chkKaraoke.Text = "Use for karaoke";
            this._chkKaraoke.UseVisualStyleBackColor = true;
            this._chkKaraoke.CheckedChanged += new System.EventHandler(this._chkKaraoke_CheckedChanged);
            // 
            // _pnlShadowType
            // 
            this._pnlShadowType.Controls.Add(this._chkHardShadow);
            this._pnlShadowType.Controls.Add(this._chkSoftShadow);
            this._pnlShadowType.Controls.Add(this._chkBevel);
            this._pnlShadowType.Controls.Add(this._chkGlow);
            this._pnlShadowType.Controls.Add(this._lblShadowTypes);
            this._pnlShadowType.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlShadowType.Location = new System.Drawing.Point(0, 0);
            this._pnlShadowType.Margin = new System.Windows.Forms.Padding(4);
            this._pnlShadowType.Name = "_pnlShadowType";
            this._pnlShadowType.Size = new System.Drawing.Size(187, 168);
            this._pnlShadowType.TabIndex = 5;
            // 
            // _chkHardShadow
            // 
            this._chkHardShadow.AutoSize = true;
            this._chkHardShadow.Location = new System.Drawing.Point(41, 131);
            this._chkHardShadow.Margin = new System.Windows.Forms.Padding(4);
            this._chkHardShadow.Name = "_chkHardShadow";
            this._chkHardShadow.Size = new System.Drawing.Size(113, 21);
            this._chkHardShadow.TabIndex = 3;
            this._chkHardShadow.Text = "Hard shadow";
            this._chkHardShadow.UseVisualStyleBackColor = true;
            this._chkHardShadow.CheckedChanged += new System.EventHandler(this._chkHardShadow_CheckedChanged);
            // 
            // _chkSoftShadow
            // 
            this._chkSoftShadow.AutoSize = true;
            this._chkSoftShadow.Location = new System.Drawing.Point(41, 102);
            this._chkSoftShadow.Margin = new System.Windows.Forms.Padding(4);
            this._chkSoftShadow.Name = "_chkSoftShadow";
            this._chkSoftShadow.Size = new System.Drawing.Size(107, 21);
            this._chkSoftShadow.TabIndex = 2;
            this._chkSoftShadow.Text = "Soft shadow";
            this._chkSoftShadow.UseVisualStyleBackColor = true;
            this._chkSoftShadow.CheckedChanged += new System.EventHandler(this._chkSoftShadow_CheckedChanged);
            // 
            // _chkBevel
            // 
            this._chkBevel.AutoSize = true;
            this._chkBevel.Location = new System.Drawing.Point(41, 73);
            this._chkBevel.Margin = new System.Windows.Forms.Padding(4);
            this._chkBevel.Name = "_chkBevel";
            this._chkBevel.Size = new System.Drawing.Size(65, 21);
            this._chkBevel.TabIndex = 1;
            this._chkBevel.Text = "Bevel";
            this._chkBevel.UseVisualStyleBackColor = true;
            this._chkBevel.CheckedChanged += new System.EventHandler(this._chkBevel_CheckedChanged);
            // 
            // _chkGlow
            // 
            this._chkGlow.AutoSize = true;
            this._chkGlow.Location = new System.Drawing.Point(41, 44);
            this._chkGlow.Margin = new System.Windows.Forms.Padding(4);
            this._chkGlow.Name = "_chkGlow";
            this._chkGlow.Size = new System.Drawing.Size(61, 21);
            this._chkGlow.TabIndex = 0;
            this._chkGlow.Text = "Glow";
            this._chkGlow.UseVisualStyleBackColor = true;
            this._chkGlow.CheckedChanged += new System.EventHandler(this._chkGlow_CheckedChanged);
            // 
            // _lblShadowTypes
            // 
            this._lblShadowTypes.AutoSize = true;
            this._lblShadowTypes.Location = new System.Drawing.Point(11, 11);
            this._lblShadowTypes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblShadowTypes.Name = "_lblShadowTypes";
            this._lblShadowTypes.Size = new System.Drawing.Size(100, 17);
            this._lblShadowTypes.TabIndex = 3;
            this._lblShadowTypes.Text = "Shadow types:";
            // 
            // _txtInputFile
            // 
            this._txtInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtInputFile.Location = new System.Drawing.Point(27, 8);
            this._txtInputFile.Margin = new System.Windows.Forms.Padding(4);
            this._txtInputFile.Name = "_txtInputFile";
            this._txtInputFile.ReadOnly = true;
            this._txtInputFile.Size = new System.Drawing.Size(1145, 22);
            this._txtInputFile.TabIndex = 2;
            // 
            // _grpStyleOptions
            // 
            this._grpStyleOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._grpStyleOptions.Controls.Add(this._spltStyleOptions);
            this._grpStyleOptions.Location = new System.Drawing.Point(20, 52);
            this._grpStyleOptions.Margin = new System.Windows.Forms.Padding(4);
            this._grpStyleOptions.Name = "_grpStyleOptions";
            this._grpStyleOptions.Padding = new System.Windows.Forms.Padding(7, 12, 7, 7);
            this._grpStyleOptions.Size = new System.Drawing.Size(1216, 472);
            this._grpStyleOptions.TabIndex = 4;
            this._grpStyleOptions.TabStop = false;
            // 
            // _dlgOpenSubtitles
            // 
            this._dlgOpenSubtitles.Filter = "Advanced SubStation Alpha|*.ass|YouTube subtitles|*.sbv";
            // 
            // _btnConvert
            // 
            this._btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnConvert.Location = new System.Drawing.Point(1064, 532);
            this._btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this._btnConvert.Name = "_btnConvert";
            this._btnConvert.Size = new System.Drawing.Size(172, 51);
            this._btnConvert.TabIndex = 5;
            this._btnConvert.Text = "Convert";
            this._btnConvert.UseVisualStyleBackColor = true;
            this._btnConvert.Click += new System.EventHandler(this._btnConvert_Click);
            // 
            // _lblConversionSuccess
            // 
            this._lblConversionSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lblConversionSuccess.ForeColor = System.Drawing.Color.Green;
            this._lblConversionSuccess.Location = new System.Drawing.Point(205, 532);
            this._lblConversionSuccess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._lblConversionSuccess.Name = "_lblConversionSuccess";
            this._lblConversionSuccess.Size = new System.Drawing.Size(671, 51);
            this._lblConversionSuccess.TabIndex = 6;
            this._lblConversionSuccess.Text = "Status label";
            this._lblConversionSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._lblConversionSuccess.Visible = false;
            // 
            // _btnBrowse
            // 
            this._btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBrowse.Location = new System.Drawing.Point(1180, 7);
            this._btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(56, 25);
            this._btnBrowse.TabIndex = 0;
            this._btnBrowse.Text = "...";
            this._btnBrowse.UseVisualStyleBackColor = true;
            this._btnBrowse.Click += new System.EventHandler(this._btnBrowse_Click);
            // 
            // _chkStyleOptions
            // 
            this._chkStyleOptions.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkStyleOptions.AutoSize = true;
            this._chkStyleOptions.Location = new System.Drawing.Point(32, 44);
            this._chkStyleOptions.Margin = new System.Windows.Forms.Padding(4);
            this._chkStyleOptions.Name = "_chkStyleOptions";
            this._chkStyleOptions.Size = new System.Drawing.Size(99, 27);
            this._chkStyleOptions.TabIndex = 0;
            this._chkStyleOptions.Text = "Style options";
            this._chkStyleOptions.UseVisualStyleBackColor = true;
            this._chkStyleOptions.CheckedChanged += new System.EventHandler(this._chkStyleOptions_CheckedChanged);
            // 
            // _chkAutoConvert
            // 
            this._chkAutoConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._chkAutoConvert.Appearance = System.Windows.Forms.Appearance.Button;
            this._chkAutoConvert.Location = new System.Drawing.Point(884, 532);
            this._chkAutoConvert.Margin = new System.Windows.Forms.Padding(4);
            this._chkAutoConvert.Name = "_chkAutoConvert";
            this._chkAutoConvert.Size = new System.Drawing.Size(172, 51);
            this._chkAutoConvert.TabIndex = 7;
            this._chkAutoConvert.Text = "Autoconvert";
            this._chkAutoConvert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._chkAutoConvert.UseVisualStyleBackColor = true;
            this._chkAutoConvert.CheckedChanged += new System.EventHandler(this._chkAutoConvert_CheckedChanged);
            // 
            // _subtitleRenameWatcher
            // 
            this._subtitleRenameWatcher.EnableRaisingEvents = true;
            this._subtitleRenameWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this._subtitleRenameWatcher.SynchronizingObject = this;
            this._subtitleRenameWatcher.Renamed += new System.IO.RenamedEventHandler(this.HandleTmpFileRenamed);
            // 
            // _subtitleModifyWatcher
            // 
            this._subtitleModifyWatcher.EnableRaisingEvents = true;
            this._subtitleModifyWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this._subtitleModifyWatcher.SynchronizingObject = this;
            this._subtitleModifyWatcher.Changed += new System.IO.FileSystemEventHandler(this.HandleFileModified);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 599);
            this.Controls.Add(this._chkAutoConvert);
            this.Controls.Add(this._btnConvert);
            this.Controls.Add(this._chkStyleOptions);
            this.Controls.Add(this._grpStyleOptions);
            this.Controls.Add(this._btnBrowse);
            this.Controls.Add(this._txtInputFile);
            this.Controls.Add(this._lblConversionSuccess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YTSubConverter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this._spltStyleOptions.Panel1.ResumeLayout(false);
            this._spltStyleOptions.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._spltStyleOptions)).EndInit();
            this._spltStyleOptions.ResumeLayout(false);
            this._pnlOptions.ResumeLayout(false);
            this._pnlKaraokeType.ResumeLayout(false);
            this._pnlKaraokeType.PerformLayout();
            this._pnlShadowType.ResumeLayout(false);
            this._pnlShadowType.PerformLayout();
            this._grpStyleOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._subtitleRenameWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._subtitleModifyWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser _brwPreview;
        private System.Windows.Forms.TextBox _txtInputFile;
        private System.Windows.Forms.GroupBox _grpStyleOptions;
        private System.Windows.Forms.ListBox _lstStyles;
        private System.Windows.Forms.OpenFileDialog _dlgOpenSubtitles;
        private System.Windows.Forms.SplitContainer _spltStyleOptions;
        private System.Windows.Forms.Label _lblShadowTypes;
        private System.Windows.Forms.Button _btnConvert;
        private System.Windows.Forms.Label _lblConversionSuccess;
        private System.Windows.Forms.Panel _pnlShadowType;
        private System.Windows.Forms.Button _btnBrowse;
        private System.Windows.Forms.Panel _pnlOptions;
        private System.Windows.Forms.Panel _pnlKaraokeType;
        private System.Windows.Forms.TextBox _txtCurrentWordOutlineColor;
        private System.Windows.Forms.TextBox _txtCurrentWordTextColor;
        private System.Windows.Forms.Label _lblCurrentWordOutlineColor;
        private System.Windows.Forms.Label _lblCurrentWordTextColor;
        private System.Windows.Forms.CheckBox _chkHighlightCurrentWord;
        private System.Windows.Forms.CheckBox _chkKaraoke;
        private System.Windows.Forms.CheckBox _chkHardShadow;
        private System.Windows.Forms.CheckBox _chkSoftShadow;
        private System.Windows.Forms.CheckBox _chkGlow;
        private System.Windows.Forms.CheckBox _chkStyleOptions;
        private System.Windows.Forms.TextBox _txtCurrentWordShadowColor;
        private System.Windows.Forms.Label _lblCurrentWordShadowColor;
        private System.Windows.Forms.Button _btnCurrentWordShadowColor;
        private System.Windows.Forms.Button _btnCurrentWordOutlineColor;
        private System.Windows.Forms.Button _btnCurrentWordTextColor;
        private System.Windows.Forms.ColorDialog _dlgColor;
        private System.Windows.Forms.CheckBox _chkBevel;
        private System.Windows.Forms.OpenFileDialog _dlgOpenImage;
        private System.Windows.Forms.ToolTip _toolTip;
        private System.Windows.Forms.Button _btnBackgroundImage;
        private System.Windows.Forms.CheckBox _chkAutoConvert;
        private System.IO.FileSystemWatcher _subtitleRenameWatcher;
        private System.IO.FileSystemWatcher _subtitleModifyWatcher;
        private System.Windows.Forms.CheckBox _chkClearBGAndFGStyle;
        private System.Windows.Forms.CheckBox _chkNoSpacePadding;
        private System.Windows.Forms.Label _lblAdvancedConfig;
        private System.Windows.Forms.CheckBox _chkKeepFontName;
        private System.Windows.Forms.CheckBox _chkClearFontSize;
    }
}