namespace MagusTools
{
    partial class mainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCharacterExportAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCharacterGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionsToolsDiceroller = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpViewhelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.stlblFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabSkills = new System.Windows.Forms.TabPage();
            this.tlpSkills = new System.Windows.Forms.TableLayoutPanel();
            this.btSkillsExpand = new System.Windows.Forms.Button();
            this.btSkillExpandAll = new System.Windows.Forms.Button();
            this.lblSK01 = new System.Windows.Forms.Label();
            this.twSkillTree = new System.Windows.Forms.TreeView();
            this.lblAD00 = new System.Windows.Forms.Label();
            this.lblAD01 = new System.Windows.Forms.Label();
            this.lblSK00 = new System.Windows.Forms.Label();
            this.dgSelectedSkills = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSkillsCollapse = new System.Windows.Forms.Button();
            this.tabSecondaryAttributes = new System.Windows.Forms.TabPage();
            this.tlpSecondaryAttributesOld = new System.Windows.Forms.TableLayoutPanel();
            this.lblCMT03 = new System.Windows.Forms.Label();
            this.lblCMT02 = new System.Windows.Forms.Label();
            this.lblCMT01 = new System.Windows.Forms.Label();
            this.lblCMT00 = new System.Windows.Forms.Label();
            this.updM03 = new MagusTools.NumericUpDownExt();
            this.updB13 = new MagusTools.NumericUpDownExt();
            this.updM02 = new MagusTools.NumericUpDownExt();
            this.updB12 = new MagusTools.NumericUpDownExt();
            this.updM01 = new MagusTools.NumericUpDownExt();
            this.updB11 = new MagusTools.NumericUpDownExt();
            this.updM00 = new MagusTools.NumericUpDownExt();
            this.lblCT16 = new System.Windows.Forms.Label();
            this.lblCT19 = new System.Windows.Forms.Label();
            this.lblCT18 = new System.Windows.Forms.Label();
            this.lblCT17 = new System.Windows.Forms.Label();
            this.lblCT15 = new System.Windows.Forms.Label();
            this.lblCT14 = new System.Windows.Forms.Label();
            this.lblCT13 = new System.Windows.Forms.Label();
            this.lblCT12 = new System.Windows.Forms.Label();
            this.lblCT11 = new System.Windows.Forms.Label();
            this.lblCT10 = new System.Windows.Forms.Label();
            this.pbD01 = new System.Windows.Forms.PictureBox();
            this.lblMCV01 = new System.Windows.Forms.Label();
            this.lblMCV02 = new System.Windows.Forms.Label();
            this.lblMCT02 = new System.Windows.Forms.Label();
            this.lblAV18 = new System.Windows.Forms.Label();
            this.lblCV18 = new System.Windows.Forms.Label();
            this.lblAV19 = new System.Windows.Forms.Label();
            this.lblCV19 = new System.Windows.Forms.Label();
            this.lblAV15 = new System.Windows.Forms.Label();
            this.lblCV15 = new System.Windows.Forms.Label();
            this.lblAV16 = new System.Windows.Forms.Label();
            this.lblCV16 = new System.Windows.Forms.Label();
            this.lblAV17 = new System.Windows.Forms.Label();
            this.lblCV17 = new System.Windows.Forms.Label();
            this.lblAV14 = new System.Windows.Forms.Label();
            this.lblCV14 = new System.Windows.Forms.Label();
            this.lblAV13 = new System.Windows.Forms.Label();
            this.lblCV13 = new System.Windows.Forms.Label();
            this.lblAV12 = new System.Windows.Forms.Label();
            this.lblCV12 = new System.Windows.Forms.Label();
            this.lblAT16 = new System.Windows.Forms.Label();
            this.lblAT11 = new System.Windows.Forms.Label();
            this.lblAV11 = new System.Windows.Forms.Label();
            this.lblCV11 = new System.Windows.Forms.Label();
            this.lblCV10 = new System.Windows.Forms.Label();
            this.lblAT17 = new System.Windows.Forms.Label();
            this.lblAT18 = new System.Windows.Forms.Label();
            this.lblAT19 = new System.Windows.Forms.Label();
            this.lblAT15 = new System.Windows.Forms.Label();
            this.lblAT14 = new System.Windows.Forms.Label();
            this.lblAT12 = new System.Windows.Forms.Label();
            this.lblAT13 = new System.Windows.Forms.Label();
            this.updB19 = new MagusTools.NumericUpDownExt();
            this.updB18 = new MagusTools.NumericUpDownExt();
            this.updB16 = new MagusTools.NumericUpDownExt();
            this.updB15 = new MagusTools.NumericUpDownExt();
            this.updB17 = new MagusTools.NumericUpDownExt();
            this.updB14 = new MagusTools.NumericUpDownExt();
            this.pbM19 = new System.Windows.Forms.PictureBox();
            this.pbM18 = new System.Windows.Forms.PictureBox();
            this.pbM16 = new System.Windows.Forms.PictureBox();
            this.pbM17 = new System.Windows.Forms.PictureBox();
            this.pbM15 = new System.Windows.Forms.PictureBox();
            this.pbM14 = new System.Windows.Forms.PictureBox();
            this.pbM13 = new System.Windows.Forms.PictureBox();
            this.pbM12 = new System.Windows.Forms.PictureBox();
            this.pbM11 = new System.Windows.Forms.PictureBox();
            this.lblMAT19 = new System.Windows.Forms.Label();
            this.lblMAT18 = new System.Windows.Forms.Label();
            this.lblMAT17 = new System.Windows.Forms.Label();
            this.lblMAT16 = new System.Windows.Forms.Label();
            this.lblMAT15 = new System.Windows.Forms.Label();
            this.lblMCT01 = new System.Windows.Forms.Label();
            this.lblMAT14 = new System.Windows.Forms.Label();
            this.lblMAT13 = new System.Windows.Forms.Label();
            this.lblMAT12 = new System.Windows.Forms.Label();
            this.lblMAT11 = new System.Windows.Forms.Label();
            this.lblMAT10 = new System.Windows.Forms.Label();
            this.lblAT10 = new System.Windows.Forms.Label();
            this.pbM10 = new System.Windows.Forms.PictureBox();
            this.updB10 = new MagusTools.NumericUpDownExt();
            this.lblAV10 = new System.Windows.Forms.Label();
            this.tabPrimaryAttributes = new System.Windows.Forms.TabPage();
            this.tlpPrimaryAttributesOld = new System.Windows.Forms.TableLayoutPanel();
            this.updB00 = new MagusTools.NumericUpDownExt();
            this.updB01 = new MagusTools.NumericUpDownExt();
            this.updB02 = new MagusTools.NumericUpDownExt();
            this.updB03 = new MagusTools.NumericUpDownExt();
            this.lblCT06 = new System.Windows.Forms.Label();
            this.lblCT09 = new System.Windows.Forms.Label();
            this.lblCT08 = new System.Windows.Forms.Label();
            this.lblCT07 = new System.Windows.Forms.Label();
            this.lblCT05 = new System.Windows.Forms.Label();
            this.lblCT04 = new System.Windows.Forms.Label();
            this.lblCT03 = new System.Windows.Forms.Label();
            this.lblCT02 = new System.Windows.Forms.Label();
            this.lblCT01 = new System.Windows.Forms.Label();
            this.lblCT00 = new System.Windows.Forms.Label();
            this.pbD00 = new System.Windows.Forms.PictureBox();
            this.lblMSV00 = new System.Windows.Forms.Label();
            this.lblMCV00 = new System.Windows.Forms.Label();
            this.lblMCT00 = new System.Windows.Forms.Label();
            this.lblAV08 = new System.Windows.Forms.Label();
            this.lblCV08 = new System.Windows.Forms.Label();
            this.lblAV09 = new System.Windows.Forms.Label();
            this.lblCV09 = new System.Windows.Forms.Label();
            this.lblAV05 = new System.Windows.Forms.Label();
            this.lblCV05 = new System.Windows.Forms.Label();
            this.lblAV06 = new System.Windows.Forms.Label();
            this.lblCV06 = new System.Windows.Forms.Label();
            this.lblAV07 = new System.Windows.Forms.Label();
            this.lblCV07 = new System.Windows.Forms.Label();
            this.lblAV04 = new System.Windows.Forms.Label();
            this.lblCV04 = new System.Windows.Forms.Label();
            this.lblAV03 = new System.Windows.Forms.Label();
            this.lblCV03 = new System.Windows.Forms.Label();
            this.lblAV02 = new System.Windows.Forms.Label();
            this.lblCV02 = new System.Windows.Forms.Label();
            this.lblAT06 = new System.Windows.Forms.Label();
            this.lblAT01 = new System.Windows.Forms.Label();
            this.lblAV01 = new System.Windows.Forms.Label();
            this.lblCV01 = new System.Windows.Forms.Label();
            this.lblCV00 = new System.Windows.Forms.Label();
            this.lblAT07 = new System.Windows.Forms.Label();
            this.lblAT08 = new System.Windows.Forms.Label();
            this.lblAT09 = new System.Windows.Forms.Label();
            this.lblAT05 = new System.Windows.Forms.Label();
            this.lblAT04 = new System.Windows.Forms.Label();
            this.lblAT02 = new System.Windows.Forms.Label();
            this.lblAT03 = new System.Windows.Forms.Label();
            this.updB09 = new MagusTools.NumericUpDownExt();
            this.updB08 = new MagusTools.NumericUpDownExt();
            this.updB06 = new MagusTools.NumericUpDownExt();
            this.updB05 = new MagusTools.NumericUpDownExt();
            this.updB07 = new MagusTools.NumericUpDownExt();
            this.updB04 = new MagusTools.NumericUpDownExt();
            this.pbM09 = new System.Windows.Forms.PictureBox();
            this.pbM08 = new System.Windows.Forms.PictureBox();
            this.pbM06 = new System.Windows.Forms.PictureBox();
            this.pbM07 = new System.Windows.Forms.PictureBox();
            this.pbM05 = new System.Windows.Forms.PictureBox();
            this.pbM04 = new System.Windows.Forms.PictureBox();
            this.pbM03 = new System.Windows.Forms.PictureBox();
            this.pbM02 = new System.Windows.Forms.PictureBox();
            this.pbM01 = new System.Windows.Forms.PictureBox();
            this.lblMAT09 = new System.Windows.Forms.Label();
            this.lblMAT08 = new System.Windows.Forms.Label();
            this.lblMAT07 = new System.Windows.Forms.Label();
            this.lblMAT06 = new System.Windows.Forms.Label();
            this.lblMAT05 = new System.Windows.Forms.Label();
            this.lblMST00 = new System.Windows.Forms.Label();
            this.lblMAT04 = new System.Windows.Forms.Label();
            this.lblMAT03 = new System.Windows.Forms.Label();
            this.lblMAT02 = new System.Windows.Forms.Label();
            this.lblMAT01 = new System.Windows.Forms.Label();
            this.lblMAT00 = new System.Windows.Forms.Label();
            this.lblAT00 = new System.Windows.Forms.Label();
            this.pbM00 = new System.Windows.Forms.PictureBox();
            this.lblAV00 = new System.Windows.Forms.Label();
            this.tabBasicInfo = new System.Windows.Forms.TabPage();
            this.tlpBasicInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblOV05 = new System.Windows.Forms.Label();
            this.lblOV06 = new System.Windows.Forms.Label();
            this.lblCharPSYperLevel = new System.Windows.Forms.Label();
            this.lblCharPsy = new System.Windows.Forms.Label();
            this.updCharLevel = new MagusTools.NumericUpDownExt();
            this.lblCharName = new System.Windows.Forms.Label();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.lblCharGender = new System.Windows.Forms.Label();
            this.lblCharAge = new System.Windows.Forms.Label();
            this.lblCharRace = new System.Windows.Forms.Label();
            this.lblCharLevel = new System.Windows.Forms.Label();
            this.cbCharGender = new System.Windows.Forms.ComboBox();
            this.updCharAge = new MagusTools.NumericUpDownExt();
            this.cbCharRace = new System.Windows.Forms.ComboBox();
            this.lblCharClass = new System.Windows.Forms.Label();
            this.lblCharAlignment = new System.Windows.Forms.Label();
            this.cbCharAlignment = new System.Windows.Forms.ComboBox();
            this.lblCharBirthplace = new System.Windows.Forms.Label();
            this.cbCharClass = new System.Windows.Forms.ComboBox();
            this.cbCharBirthplace = new System.Windows.Forms.ComboBox();
            this.lblCharReligion = new System.Windows.Forms.Label();
            this.lblCharRealms = new System.Windows.Forms.Label();
            this.cbCharReligion = new System.Windows.Forms.ComboBox();
            this.lblCharRealmsList = new System.Windows.Forms.Label();
            this.lblCharAvailableCCP = new System.Windows.Forms.Label();
            this.lblCharCCP = new System.Windows.Forms.Label();
            this.lblMiscHypen = new System.Windows.Forms.Label();
            this.pbD02 = new System.Windows.Forms.PictureBox();
            this.lblOV01 = new System.Windows.Forms.Label();
            this.lblOV02 = new System.Windows.Forms.Label();
            this.lblCharMP = new System.Windows.Forms.Label();
            this.lblOV03 = new System.Windows.Forms.Label();
            this.lblCharMPperLevel = new System.Windows.Forms.Label();
            this.lblOV04 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOV00 = new System.Windows.Forms.Label();
            this.lblCharAMR = new System.Windows.Forms.Label();
            this.lblCharOtherStats = new System.Windows.Forms.Label();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.lblCharMMR = new System.Windows.Forms.Label();
            this.lblCharDamagebonus = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.tabSkills.SuspendLayout();
            this.tlpSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedSkills)).BeginInit();
            this.tabSecondaryAttributes.SuspendLayout();
            this.tlpSecondaryAttributesOld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updM03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updM02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updM01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updM00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB10)).BeginInit();
            this.tabPrimaryAttributes.SuspendLayout();
            this.tlpPrimaryAttributesOld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updB00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM00)).BeginInit();
            this.tabBasicInfo.SuspendLayout();
            this.tlpBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCharLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCharAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD02)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCharacter,
            this.mnuOptions,
            this.mnuHelp});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(684, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.BackColor = System.Drawing.Color.Transparent;
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.mnuFileSeparator1,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.mnuFileSeparator2,
            this.mnuFileQuit});
            this.mnuFile.Image = global::MagusTools.Icons.MENU_FileMenu;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(53, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Image = global::MagusTools.Icons.MENU_NewChar;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(123, 22);
            this.mnuFileNew.Text = "New";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = global::MagusTools.Icons.MENU_LoadChar;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(123, 22);
            this.mnuFileOpen.Text = "Open";
            // 
            // mnuFileSeparator1
            // 
            this.mnuFileSeparator1.Name = "mnuFileSeparator1";
            this.mnuFileSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = global::MagusTools.Icons.MENU_SaveChar;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(123, 22);
            this.mnuFileSave.Text = "Save";
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Image = global::MagusTools.Icons.MENU_SaveAsChar;
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(123, 22);
            this.mnuFileSaveAs.Text = "Save As...";
            // 
            // mnuFileSeparator2
            // 
            this.mnuFileSeparator2.Name = "mnuFileSeparator2";
            this.mnuFileSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // mnuFileQuit
            // 
            this.mnuFileQuit.Image = global::MagusTools.Icons.MENU_Exit;
            this.mnuFileQuit.Name = "mnuFileQuit";
            this.mnuFileQuit.Size = new System.Drawing.Size(123, 22);
            this.mnuFileQuit.Text = "Quit";
            // 
            // mnuCharacter
            // 
            this.mnuCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCharacterExportAsText,
            this.mnuCharacterGenerate});
            this.mnuCharacter.Image = global::MagusTools.Icons.MENU_CharMenu;
            this.mnuCharacter.Name = "mnuCharacter";
            this.mnuCharacter.Size = new System.Drawing.Size(86, 20);
            this.mnuCharacter.Text = "Character";
            // 
            // mnuCharacterExportAsText
            // 
            this.mnuCharacterExportAsText.Image = global::MagusTools.Icons.MENU_Text;
            this.mnuCharacterExportAsText.Name = "mnuCharacterExportAsText";
            this.mnuCharacterExportAsText.Size = new System.Drawing.Size(145, 22);
            this.mnuCharacterExportAsText.Text = "Export as Text";
            // 
            // mnuCharacterGenerate
            // 
            this.mnuCharacterGenerate.Image = global::MagusTools.Icons.MENU_Generate;
            this.mnuCharacterGenerate.Name = "mnuCharacterGenerate";
            this.mnuCharacterGenerate.Size = new System.Drawing.Size(145, 22);
            this.mnuCharacterGenerate.Text = "Generate";
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsSettings,
            this.mnuOptionsLanguage,
            this.mnuOptionsTools});
            this.mnuOptions.Image = global::MagusTools.Icons.MENU_Settings;
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(77, 20);
            this.mnuOptions.Text = "Options";
            // 
            // mnuOptionsSettings
            // 
            this.mnuOptionsSettings.Name = "mnuOptionsSettings";
            this.mnuOptionsSettings.Size = new System.Drawing.Size(126, 22);
            this.mnuOptionsSettings.Text = "Settings";
            // 
            // mnuOptionsLanguage
            // 
            this.mnuOptionsLanguage.Name = "mnuOptionsLanguage";
            this.mnuOptionsLanguage.Size = new System.Drawing.Size(126, 22);
            this.mnuOptionsLanguage.Text = "Language";
            // 
            // mnuOptionsTools
            // 
            this.mnuOptionsTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsToolsDiceroller});
            this.mnuOptionsTools.Name = "mnuOptionsTools";
            this.mnuOptionsTools.Size = new System.Drawing.Size(126, 22);
            this.mnuOptionsTools.Text = "Tools";
            // 
            // mnuOptionsToolsDiceroller
            // 
            this.mnuOptionsToolsDiceroller.Image = global::MagusTools.Icons.MENU_Dice;
            this.mnuOptionsToolsDiceroller.Name = "mnuOptionsToolsDiceroller";
            this.mnuOptionsToolsDiceroller.Size = new System.Drawing.Size(124, 22);
            this.mnuOptionsToolsDiceroller.Text = "Diceroller";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpViewhelp,
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            // 
            // mnuHelpViewhelp
            // 
            this.mnuHelpViewhelp.Name = "mnuHelpViewhelp";
            this.mnuHelpViewhelp.Size = new System.Drawing.Size(174, 22);
            this.mnuHelpViewhelp.Text = "View Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(174, 22);
            this.mnuHelpAbout.Text = "About MagusTools";
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblFileName});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 740);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(684, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "mainStatusStrip";
            // 
            // stlblFileName
            // 
            this.stlblFileName.Name = "stlblFileName";
            this.stlblFileName.Size = new System.Drawing.Size(0, 17);
            // 
            // tabSkills
            // 
            this.tabSkills.Controls.Add(this.tlpSkills);
            this.tabSkills.Location = new System.Drawing.Point(4, 24);
            this.tabSkills.Name = "tabSkills";
            this.tabSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabSkills.Size = new System.Drawing.Size(676, 688);
            this.tabSkills.TabIndex = 3;
            this.tabSkills.Text = "Skills";
            this.tabSkills.UseVisualStyleBackColor = true;
            // 
            // tlpSkills
            // 
            this.tlpSkills.ColumnCount = 8;
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpSkills.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpSkills.Controls.Add(this.btSkillsExpand, 4, 0);
            this.tlpSkills.Controls.Add(this.btSkillExpandAll, 3, 0);
            this.tlpSkills.Controls.Add(this.lblSK01, 6, 0);
            this.tlpSkills.Controls.Add(this.twSkillTree, 1, 1);
            this.tlpSkills.Controls.Add(this.lblAD00, 1, 2);
            this.tlpSkills.Controls.Add(this.lblAD01, 1, 3);
            this.tlpSkills.Controls.Add(this.lblSK00, 1, 0);
            this.tlpSkills.Controls.Add(this.dgSelectedSkills, 6, 1);
            this.tlpSkills.Controls.Add(this.btSkillsCollapse, 2, 0);
            this.tlpSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSkills.Location = new System.Drawing.Point(3, 3);
            this.tlpSkills.Name = "tlpSkills";
            this.tlpSkills.RowCount = 4;
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSkills.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSkills.Size = new System.Drawing.Size(670, 682);
            this.tlpSkills.TabIndex = 0;
            // 
            // btSkillsExpand
            // 
            this.btSkillsExpand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSkillsExpand.Image = global::MagusTools.Icons.TreeViewExpandSecondaryNodes;
            this.btSkillsExpand.Location = new System.Drawing.Point(266, 3);
            this.btSkillsExpand.Name = "btSkillsExpand";
            this.btSkillsExpand.Size = new System.Drawing.Size(26, 18);
            this.btSkillsExpand.TabIndex = 12;
            this.btSkillsExpand.UseVisualStyleBackColor = true;
            this.btSkillsExpand.Click += new System.EventHandler(this.btSkillsExpand_Click);
            // 
            // btSkillExpandAll
            // 
            this.btSkillExpandAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSkillExpandAll.Image = global::MagusTools.Icons.TreeViewExpand;
            this.btSkillExpandAll.Location = new System.Drawing.Point(234, 3);
            this.btSkillExpandAll.Name = "btSkillExpandAll";
            this.btSkillExpandAll.Size = new System.Drawing.Size(26, 18);
            this.btSkillExpandAll.TabIndex = 11;
            this.btSkillExpandAll.UseVisualStyleBackColor = true;
            this.btSkillExpandAll.Click += new System.EventHandler(this.btSkillExpandAll_Click);
            // 
            // lblSK01
            // 
            this.lblSK01.AutoSize = true;
            this.lblSK01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSK01.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSK01.Location = new System.Drawing.Point(319, 0);
            this.lblSK01.Margin = new System.Windows.Forms.Padding(0);
            this.lblSK01.Name = "lblSK01";
            this.lblSK01.Size = new System.Drawing.Size(325, 24);
            this.lblSK01.TabIndex = 7;
            this.lblSK01.Text = "Selected skills";
            this.lblSK01.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // twSkillTree
            // 
            this.tlpSkills.SetColumnSpan(this.twSkillTree, 4);
            this.twSkillTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twSkillTree.Location = new System.Drawing.Point(24, 24);
            this.twSkillTree.Margin = new System.Windows.Forms.Padding(0);
            this.twSkillTree.Name = "twSkillTree";
            this.twSkillTree.Size = new System.Drawing.Size(271, 626);
            this.twSkillTree.TabIndex = 0;
            this.twSkillTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.twSkillTree_ItemDrag);
            // 
            // lblAD00
            // 
            this.lblAD00.AutoSize = true;
            this.tlpSkills.SetColumnSpan(this.lblAD00, 6);
            this.lblAD00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAD00.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAD00.Location = new System.Drawing.Point(27, 650);
            this.lblAD00.Name = "lblAD00";
            this.lblAD00.Size = new System.Drawing.Size(614, 16);
            this.lblAD00.TabIndex = 1;
            this.lblAD00.Text = "label1";
            // 
            // lblAD01
            // 
            this.lblAD01.AutoSize = true;
            this.tlpSkills.SetColumnSpan(this.lblAD01, 6);
            this.lblAD01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAD01.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAD01.Location = new System.Drawing.Point(27, 666);
            this.lblAD01.Name = "lblAD01";
            this.lblAD01.Size = new System.Drawing.Size(614, 16);
            this.lblAD01.TabIndex = 2;
            this.lblAD01.Text = "label2";
            // 
            // lblSK00
            // 
            this.lblSK00.AutoSize = true;
            this.lblSK00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSK00.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSK00.Location = new System.Drawing.Point(24, 0);
            this.lblSK00.Margin = new System.Windows.Forms.Padding(0);
            this.lblSK00.Name = "lblSK00";
            this.lblSK00.Size = new System.Drawing.Size(175, 24);
            this.lblSK00.TabIndex = 3;
            this.lblSK00.Text = "Available Skills";
            this.lblSK00.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgSelectedSkills
            // 
            this.dgSelectedSkills.AllowDrop = true;
            this.dgSelectedSkills.AllowUserToAddRows = false;
            this.dgSelectedSkills.AllowUserToDeleteRows = false;
            this.dgSelectedSkills.AllowUserToResizeColumns = false;
            this.dgSelectedSkills.AllowUserToResizeRows = false;
            this.dgSelectedSkills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSelectedSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSelectedSkills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colLevel,
            this.colPrice});
            this.dgSelectedSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSelectedSkills.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgSelectedSkills.Location = new System.Drawing.Point(319, 24);
            this.dgSelectedSkills.Margin = new System.Windows.Forms.Padding(0);
            this.dgSelectedSkills.Name = "dgSelectedSkills";
            this.dgSelectedSkills.RowHeadersVisible = false;
            this.dgSelectedSkills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSelectedSkills.Size = new System.Drawing.Size(325, 626);
            this.dgSelectedSkills.TabIndex = 8;
            this.dgSelectedSkills.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgSelectedSkills_DragDrop);
            this.dgSelectedSkills.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgSelectedSkills_DragEnter);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Skill name";
            this.colName.Name = "colName";
            // 
            // colLevel
            // 
            this.colLevel.HeaderText = "Lv/%";
            this.colLevel.Name = "colLevel";
            this.colLevel.ReadOnly = true;
            this.colLevel.Width = 40;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            this.colPrice.Width = 50;
            // 
            // btSkillsCollapse
            // 
            this.btSkillsCollapse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSkillsCollapse.Image = global::MagusTools.Icons.TreeViewCollapse;
            this.btSkillsCollapse.Location = new System.Drawing.Point(202, 3);
            this.btSkillsCollapse.Name = "btSkillsCollapse";
            this.btSkillsCollapse.Size = new System.Drawing.Size(26, 18);
            this.btSkillsCollapse.TabIndex = 10;
            this.btSkillsCollapse.UseVisualStyleBackColor = true;
            this.btSkillsCollapse.Click += new System.EventHandler(this.btSkillsCollapse_Click);
            // 
            // tabSecondaryAttributes
            // 
            this.tabSecondaryAttributes.Controls.Add(this.tlpSecondaryAttributesOld);
            this.tabSecondaryAttributes.Location = new System.Drawing.Point(4, 24);
            this.tabSecondaryAttributes.Name = "tabSecondaryAttributes";
            this.tabSecondaryAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecondaryAttributes.Size = new System.Drawing.Size(676, 688);
            this.tabSecondaryAttributes.TabIndex = 7;
            this.tabSecondaryAttributes.Text = "Secondary Attributes";
            this.tabSecondaryAttributes.UseVisualStyleBackColor = true;
            // 
            // tlpSecondaryAttributesOld
            // 
            this.tlpSecondaryAttributesOld.BackColor = System.Drawing.SystemColors.Window;
            this.tlpSecondaryAttributesOld.ColumnCount = 15;
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpSecondaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCMT03, 2, 30);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCMT02, 2, 22);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCMT01, 2, 14);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCMT00, 2, 6);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updM03, 2, 29);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB13, 2, 27);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updM02, 2, 21);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB12, 2, 19);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updM01, 2, 13);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB11, 2, 11);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updM00, 2, 5);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT16, 13, 14);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT19, 13, 38);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT18, 13, 30);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT17, 13, 22);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT15, 13, 6);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT14, 5, 38);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT13, 5, 30);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT12, 5, 22);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT11, 5, 14);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCT10, 5, 6);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbD01, 7, 1);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMCV01, 5, 40);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMCV02, 13, 40);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMCT02, 9, 40);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV18, 13, 27);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV18, 13, 29);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV19, 13, 35);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV19, 13, 37);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV15, 13, 3);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV15, 13, 5);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV16, 13, 11);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV16, 13, 13);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV17, 13, 19);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV17, 13, 21);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV14, 5, 35);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV14, 5, 37);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV13, 5, 27);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV13, 5, 29);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV12, 5, 19);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV12, 5, 21);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT16, 13, 10);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT11, 5, 10);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV11, 5, 11);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV11, 5, 13);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblCV10, 5, 5);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT17, 13, 18);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT18, 13, 26);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT19, 13, 34);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT15, 13, 2);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT14, 5, 34);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT12, 5, 18);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT13, 5, 26);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB19, 10, 35);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB18, 10, 27);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB16, 10, 11);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB15, 10, 3);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB17, 10, 19);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB14, 2, 35);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM19, 9, 35);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM18, 9, 27);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM16, 9, 11);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM17, 9, 19);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM15, 9, 3);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM14, 1, 35);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM13, 1, 27);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM12, 1, 19);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM11, 1, 11);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT19, 9, 33);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT18, 9, 25);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT17, 9, 17);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT16, 9, 9);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT15, 9, 1);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMCT01, 1, 40);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT14, 1, 33);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT13, 1, 25);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT12, 1, 17);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT11, 1, 9);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblMAT10, 1, 1);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAT10, 5, 2);
            this.tlpSecondaryAttributesOld.Controls.Add(this.pbM10, 1, 3);
            this.tlpSecondaryAttributesOld.Controls.Add(this.updB10, 2, 3);
            this.tlpSecondaryAttributesOld.Controls.Add(this.lblAV10, 5, 3);
            this.tlpSecondaryAttributesOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecondaryAttributesOld.Location = new System.Drawing.Point(3, 3);
            this.tlpSecondaryAttributesOld.Name = "tlpSecondaryAttributesOld";
            this.tlpSecondaryAttributesOld.RowCount = 42;
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpSecondaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpSecondaryAttributesOld.Size = new System.Drawing.Size(670, 682);
            this.tlpSecondaryAttributesOld.TabIndex = 1;
            // 
            // lblCMT03
            // 
            this.lblCMT03.AutoSize = true;
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblCMT03, 2);
            this.lblCMT03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCMT03.Location = new System.Drawing.Point(83, 480);
            this.lblCMT03.Name = "lblCMT03";
            this.lblCMT03.Size = new System.Drawing.Size(90, 16);
            this.lblCMT03.TabIndex = 113;
            this.lblCMT03.Text = "CM";
            this.lblCMT03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCMT02
            // 
            this.lblCMT02.AutoSize = true;
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblCMT02, 2);
            this.lblCMT02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCMT02.Location = new System.Drawing.Point(83, 356);
            this.lblCMT02.Name = "lblCMT02";
            this.lblCMT02.Size = new System.Drawing.Size(90, 16);
            this.lblCMT02.TabIndex = 112;
            this.lblCMT02.Text = "CM";
            this.lblCMT02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCMT01
            // 
            this.lblCMT01.AutoSize = true;
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblCMT01, 2);
            this.lblCMT01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCMT01.Location = new System.Drawing.Point(83, 232);
            this.lblCMT01.Name = "lblCMT01";
            this.lblCMT01.Size = new System.Drawing.Size(90, 16);
            this.lblCMT01.TabIndex = 111;
            this.lblCMT01.Text = "CM";
            this.lblCMT01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCMT00
            // 
            this.lblCMT00.AutoSize = true;
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblCMT00, 2);
            this.lblCMT00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCMT00.Location = new System.Drawing.Point(83, 108);
            this.lblCMT00.Name = "lblCMT00";
            this.lblCMT00.Size = new System.Drawing.Size(90, 16);
            this.lblCMT00.TabIndex = 110;
            this.lblCMT00.Text = "CM";
            this.lblCMT00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updM03
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updM03, 2);
            this.updM03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updM03.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updM03.Location = new System.Drawing.Point(88, 452);
            this.updM03.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updM03.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updM03.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updM03.Name = "updM03";
            this.updM03.Size = new System.Drawing.Size(88, 27);
            this.updM03.TabIndex = 109;
            this.updM03.Tag = "";
            this.updM03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updM03.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB13
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB13, 2);
            this.updB13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB13.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB13.Location = new System.Drawing.Point(88, 416);
            this.updB13.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB13.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB13.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB13.Name = "updB13";
            this.updB13.Size = new System.Drawing.Size(88, 27);
            this.updB13.TabIndex = 108;
            this.updB13.Tag = "";
            this.updB13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB13.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updM02
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updM02, 2);
            this.updM02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updM02.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updM02.Location = new System.Drawing.Point(88, 328);
            this.updM02.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updM02.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updM02.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updM02.Name = "updM02";
            this.updM02.Size = new System.Drawing.Size(88, 27);
            this.updM02.TabIndex = 107;
            this.updM02.Tag = "";
            this.updM02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updM02.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB12
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB12, 2);
            this.updB12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB12.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB12.Location = new System.Drawing.Point(88, 292);
            this.updB12.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB12.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB12.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB12.Name = "updB12";
            this.updB12.Size = new System.Drawing.Size(88, 27);
            this.updB12.TabIndex = 106;
            this.updB12.Tag = "";
            this.updB12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB12.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updM01
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updM01, 2);
            this.updM01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updM01.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updM01.Location = new System.Drawing.Point(88, 204);
            this.updM01.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updM01.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updM01.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updM01.Name = "updM01";
            this.updM01.Size = new System.Drawing.Size(88, 27);
            this.updM01.TabIndex = 105;
            this.updM01.Tag = "";
            this.updM01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updM01.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB11
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB11, 2);
            this.updB11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB11.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB11.Location = new System.Drawing.Point(88, 168);
            this.updB11.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB11.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB11.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB11.Name = "updB11";
            this.updB11.Size = new System.Drawing.Size(88, 27);
            this.updB11.TabIndex = 104;
            this.updB11.Tag = "";
            this.updB11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB11.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updM00
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updM00, 2);
            this.updM00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updM00.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updM00.Location = new System.Drawing.Point(88, 80);
            this.updM00.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updM00.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updM00.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updM00.Name = "updM00";
            this.updM00.Size = new System.Drawing.Size(88, 27);
            this.updM00.TabIndex = 103;
            this.updM00.Tag = "";
            this.updM00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updM00.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblCT16
            // 
            this.lblCT16.AutoSize = true;
            this.lblCT16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT16.Location = new System.Drawing.Point(592, 232);
            this.lblCT16.Name = "lblCT16";
            this.lblCT16.Size = new System.Drawing.Size(58, 16);
            this.lblCT16.TabIndex = 102;
            this.lblCT16.Text = "CCP";
            this.lblCT16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT19
            // 
            this.lblCT19.AutoSize = true;
            this.lblCT19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT19.Location = new System.Drawing.Point(592, 604);
            this.lblCT19.Name = "lblCT19";
            this.lblCT19.Size = new System.Drawing.Size(58, 16);
            this.lblCT19.TabIndex = 101;
            this.lblCT19.Text = "CCP";
            this.lblCT19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT18
            // 
            this.lblCT18.AutoSize = true;
            this.lblCT18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT18.Location = new System.Drawing.Point(592, 480);
            this.lblCT18.Name = "lblCT18";
            this.lblCT18.Size = new System.Drawing.Size(58, 16);
            this.lblCT18.TabIndex = 100;
            this.lblCT18.Text = "CCP";
            this.lblCT18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT17
            // 
            this.lblCT17.AutoSize = true;
            this.lblCT17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT17.Location = new System.Drawing.Point(592, 356);
            this.lblCT17.Name = "lblCT17";
            this.lblCT17.Size = new System.Drawing.Size(58, 16);
            this.lblCT17.TabIndex = 99;
            this.lblCT17.Text = "CCP";
            this.lblCT17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT15
            // 
            this.lblCT15.AutoSize = true;
            this.lblCT15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT15.Location = new System.Drawing.Point(592, 108);
            this.lblCT15.Name = "lblCT15";
            this.lblCT15.Size = new System.Drawing.Size(58, 16);
            this.lblCT15.TabIndex = 98;
            this.lblCT15.Text = "CCP";
            this.lblCT15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT14
            // 
            this.lblCT14.AutoSize = true;
            this.lblCT14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT14.Location = new System.Drawing.Point(209, 604);
            this.lblCT14.Name = "lblCT14";
            this.lblCT14.Size = new System.Drawing.Size(58, 16);
            this.lblCT14.TabIndex = 97;
            this.lblCT14.Text = "CCP";
            this.lblCT14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT13
            // 
            this.lblCT13.AutoSize = true;
            this.lblCT13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT13.Location = new System.Drawing.Point(209, 480);
            this.lblCT13.Name = "lblCT13";
            this.lblCT13.Size = new System.Drawing.Size(58, 16);
            this.lblCT13.TabIndex = 96;
            this.lblCT13.Text = "CCP";
            this.lblCT13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT12
            // 
            this.lblCT12.AutoSize = true;
            this.lblCT12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT12.Location = new System.Drawing.Point(209, 356);
            this.lblCT12.Name = "lblCT12";
            this.lblCT12.Size = new System.Drawing.Size(58, 16);
            this.lblCT12.TabIndex = 95;
            this.lblCT12.Text = "CCP";
            this.lblCT12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT11
            // 
            this.lblCT11.AutoSize = true;
            this.lblCT11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT11.Location = new System.Drawing.Point(209, 232);
            this.lblCT11.Name = "lblCT11";
            this.lblCT11.Size = new System.Drawing.Size(58, 16);
            this.lblCT11.TabIndex = 94;
            this.lblCT11.Text = "CCP";
            this.lblCT11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT10
            // 
            this.lblCT10.AutoSize = true;
            this.lblCT10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT10.Location = new System.Drawing.Point(209, 108);
            this.lblCT10.Name = "lblCT10";
            this.lblCT10.Size = new System.Drawing.Size(58, 16);
            this.lblCT10.TabIndex = 93;
            this.lblCT10.Text = "CCP";
            this.lblCT10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbD01
            // 
            this.pbD01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbD01.Image = global::MagusTools.Decals.DECAL_SideBarA;
            this.pbD01.Location = new System.Drawing.Point(319, 16);
            this.pbD01.Margin = new System.Windows.Forms.Padding(0);
            this.pbD01.Name = "pbD01";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbD01, 40);
            this.pbD01.Size = new System.Drawing.Size(31, 652);
            this.pbD01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD01.TabIndex = 92;
            this.pbD01.TabStop = false;
            // 
            // lblMCV01
            // 
            this.lblMCV01.AutoSize = true;
            this.lblMCV01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMCV01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMCV01.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCV01.Location = new System.Drawing.Point(209, 644);
            this.lblMCV01.Name = "lblMCV01";
            this.lblMCV01.Size = new System.Drawing.Size(58, 24);
            this.lblMCV01.TabIndex = 91;
            this.lblMCV01.Tag = "";
            this.lblMCV01.Text = "12";
            this.lblMCV01.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMCV02
            // 
            this.lblMCV02.AutoSize = true;
            this.lblMCV02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMCV02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMCV02.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCV02.Location = new System.Drawing.Point(592, 644);
            this.lblMCV02.Name = "lblMCV02";
            this.lblMCV02.Size = new System.Drawing.Size(58, 24);
            this.lblMCV02.TabIndex = 90;
            this.lblMCV02.Tag = "";
            this.lblMCV02.Text = "12";
            this.lblMCV02.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMCT02
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMCT02, 4);
            this.lblMCT02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMCT02.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMCT02.Font = new System.Drawing.Font("Bookman Old Style", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMCT02.Location = new System.Drawing.Point(399, 644);
            this.lblMCT02.Margin = new System.Windows.Forms.Padding(0);
            this.lblMCT02.Name = "lblMCT02";
            this.lblMCT02.Size = new System.Drawing.Size(190, 24);
            this.lblMCT02.TabIndex = 89;
            this.lblMCT02.Text = "Spent CCP";
            this.lblMCT02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAV18
            // 
            this.lblAV18.AutoSize = true;
            this.lblAV18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV18.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV18.Location = new System.Drawing.Point(592, 416);
            this.lblAV18.Name = "lblAV18";
            this.lblAV18.Size = new System.Drawing.Size(58, 28);
            this.lblAV18.TabIndex = 88;
            this.lblAV18.Tag = "";
            this.lblAV18.Text = "12";
            this.lblAV18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV18
            // 
            this.lblCV18.AutoSize = true;
            this.lblCV18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV18.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV18.Location = new System.Drawing.Point(592, 452);
            this.lblCV18.Name = "lblCV18";
            this.lblCV18.Size = new System.Drawing.Size(58, 28);
            this.lblCV18.TabIndex = 87;
            this.lblCV18.Tag = "";
            this.lblCV18.Text = "12";
            this.lblCV18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV19
            // 
            this.lblAV19.AutoSize = true;
            this.lblAV19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV19.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV19.Location = new System.Drawing.Point(592, 540);
            this.lblAV19.Name = "lblAV19";
            this.lblAV19.Size = new System.Drawing.Size(58, 28);
            this.lblAV19.TabIndex = 86;
            this.lblAV19.Tag = "";
            this.lblAV19.Text = "12";
            this.lblAV19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV19
            // 
            this.lblCV19.AutoSize = true;
            this.lblCV19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV19.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV19.Location = new System.Drawing.Point(592, 576);
            this.lblCV19.Name = "lblCV19";
            this.lblCV19.Size = new System.Drawing.Size(58, 28);
            this.lblCV19.TabIndex = 85;
            this.lblCV19.Tag = "";
            this.lblCV19.Text = "12";
            this.lblCV19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV15
            // 
            this.lblAV15.AutoSize = true;
            this.lblAV15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV15.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV15.Location = new System.Drawing.Point(592, 44);
            this.lblAV15.Name = "lblAV15";
            this.lblAV15.Size = new System.Drawing.Size(58, 28);
            this.lblAV15.TabIndex = 84;
            this.lblAV15.Tag = "";
            this.lblAV15.Text = "12";
            this.lblAV15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV15
            // 
            this.lblCV15.AutoSize = true;
            this.lblCV15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV15.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV15.Location = new System.Drawing.Point(592, 80);
            this.lblCV15.Name = "lblCV15";
            this.lblCV15.Size = new System.Drawing.Size(58, 28);
            this.lblCV15.TabIndex = 83;
            this.lblCV15.Tag = "";
            this.lblCV15.Text = "12";
            this.lblCV15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV16
            // 
            this.lblAV16.AutoSize = true;
            this.lblAV16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV16.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV16.Location = new System.Drawing.Point(592, 168);
            this.lblAV16.Name = "lblAV16";
            this.lblAV16.Size = new System.Drawing.Size(58, 28);
            this.lblAV16.TabIndex = 82;
            this.lblAV16.Tag = "";
            this.lblAV16.Text = "12";
            this.lblAV16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV16
            // 
            this.lblCV16.AutoSize = true;
            this.lblCV16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV16.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV16.Location = new System.Drawing.Point(592, 204);
            this.lblCV16.Name = "lblCV16";
            this.lblCV16.Size = new System.Drawing.Size(58, 28);
            this.lblCV16.TabIndex = 81;
            this.lblCV16.Tag = "";
            this.lblCV16.Text = "12";
            this.lblCV16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV17
            // 
            this.lblAV17.AutoSize = true;
            this.lblAV17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV17.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV17.Location = new System.Drawing.Point(592, 292);
            this.lblAV17.Name = "lblAV17";
            this.lblAV17.Size = new System.Drawing.Size(58, 28);
            this.lblAV17.TabIndex = 80;
            this.lblAV17.Tag = "";
            this.lblAV17.Text = "12";
            this.lblAV17.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV17
            // 
            this.lblCV17.AutoSize = true;
            this.lblCV17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV17.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV17.Location = new System.Drawing.Point(592, 328);
            this.lblCV17.Name = "lblCV17";
            this.lblCV17.Size = new System.Drawing.Size(58, 28);
            this.lblCV17.TabIndex = 79;
            this.lblCV17.Tag = "";
            this.lblCV17.Text = "12";
            this.lblCV17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV14
            // 
            this.lblAV14.AutoSize = true;
            this.lblAV14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV14.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV14.Location = new System.Drawing.Point(209, 540);
            this.lblAV14.Name = "lblAV14";
            this.lblAV14.Size = new System.Drawing.Size(58, 28);
            this.lblAV14.TabIndex = 78;
            this.lblAV14.Tag = "";
            this.lblAV14.Text = "12";
            this.lblAV14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV14
            // 
            this.lblCV14.AutoSize = true;
            this.lblCV14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV14.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV14.Location = new System.Drawing.Point(209, 576);
            this.lblCV14.Name = "lblCV14";
            this.lblCV14.Size = new System.Drawing.Size(58, 28);
            this.lblCV14.TabIndex = 77;
            this.lblCV14.Tag = "";
            this.lblCV14.Text = "12";
            this.lblCV14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV13
            // 
            this.lblAV13.AutoSize = true;
            this.lblAV13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV13.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV13.Location = new System.Drawing.Point(209, 416);
            this.lblAV13.Name = "lblAV13";
            this.lblAV13.Size = new System.Drawing.Size(58, 28);
            this.lblAV13.TabIndex = 76;
            this.lblAV13.Tag = "";
            this.lblAV13.Text = "12";
            this.lblAV13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV13
            // 
            this.lblCV13.AutoSize = true;
            this.lblCV13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV13.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV13.Location = new System.Drawing.Point(209, 452);
            this.lblCV13.Name = "lblCV13";
            this.lblCV13.Size = new System.Drawing.Size(58, 28);
            this.lblCV13.TabIndex = 75;
            this.lblCV13.Tag = "";
            this.lblCV13.Text = "12";
            this.lblCV13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV12
            // 
            this.lblAV12.AutoSize = true;
            this.lblAV12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV12.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV12.Location = new System.Drawing.Point(209, 292);
            this.lblAV12.Name = "lblAV12";
            this.lblAV12.Size = new System.Drawing.Size(58, 28);
            this.lblAV12.TabIndex = 74;
            this.lblAV12.Tag = "";
            this.lblAV12.Text = "12";
            this.lblAV12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV12
            // 
            this.lblCV12.AutoSize = true;
            this.lblCV12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV12.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV12.Location = new System.Drawing.Point(209, 328);
            this.lblCV12.Name = "lblCV12";
            this.lblCV12.Size = new System.Drawing.Size(58, 28);
            this.lblCV12.TabIndex = 73;
            this.lblCV12.Tag = "";
            this.lblCV12.Text = "12";
            this.lblCV12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAT16
            // 
            this.lblAT16.AutoSize = true;
            this.lblAT16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT16.Location = new System.Drawing.Point(592, 152);
            this.lblAT16.Name = "lblAT16";
            this.lblAT16.Size = new System.Drawing.Size(58, 16);
            this.lblAT16.TabIndex = 72;
            this.lblAT16.Text = "Actual";
            this.lblAT16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT11
            // 
            this.lblAT11.AutoSize = true;
            this.lblAT11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT11.Location = new System.Drawing.Point(209, 152);
            this.lblAT11.Name = "lblAT11";
            this.lblAT11.Size = new System.Drawing.Size(58, 16);
            this.lblAT11.TabIndex = 71;
            this.lblAT11.Text = "Actual";
            this.lblAT11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAV11
            // 
            this.lblAV11.AutoSize = true;
            this.lblAV11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV11.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV11.Location = new System.Drawing.Point(209, 168);
            this.lblAV11.Name = "lblAV11";
            this.lblAV11.Size = new System.Drawing.Size(58, 28);
            this.lblAV11.TabIndex = 70;
            this.lblAV11.Tag = "";
            this.lblAV11.Text = "12";
            this.lblAV11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV11
            // 
            this.lblCV11.AutoSize = true;
            this.lblCV11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV11.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV11.Location = new System.Drawing.Point(209, 204);
            this.lblCV11.Name = "lblCV11";
            this.lblCV11.Size = new System.Drawing.Size(58, 28);
            this.lblCV11.TabIndex = 69;
            this.lblCV11.Tag = "";
            this.lblCV11.Text = "12";
            this.lblCV11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCV10
            // 
            this.lblCV10.AutoSize = true;
            this.lblCV10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV10.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV10.Location = new System.Drawing.Point(209, 80);
            this.lblCV10.Name = "lblCV10";
            this.lblCV10.Size = new System.Drawing.Size(58, 28);
            this.lblCV10.TabIndex = 68;
            this.lblCV10.Tag = "";
            this.lblCV10.Text = "12";
            this.lblCV10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAT17
            // 
            this.lblAT17.AutoSize = true;
            this.lblAT17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT17.Location = new System.Drawing.Point(592, 276);
            this.lblAT17.Name = "lblAT17";
            this.lblAT17.Size = new System.Drawing.Size(58, 16);
            this.lblAT17.TabIndex = 66;
            this.lblAT17.Text = "Actual";
            this.lblAT17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT18
            // 
            this.lblAT18.AutoSize = true;
            this.lblAT18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT18.Location = new System.Drawing.Point(592, 400);
            this.lblAT18.Name = "lblAT18";
            this.lblAT18.Size = new System.Drawing.Size(58, 16);
            this.lblAT18.TabIndex = 64;
            this.lblAT18.Text = "Actual";
            this.lblAT18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT19
            // 
            this.lblAT19.AutoSize = true;
            this.lblAT19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT19.Location = new System.Drawing.Point(592, 524);
            this.lblAT19.Name = "lblAT19";
            this.lblAT19.Size = new System.Drawing.Size(58, 16);
            this.lblAT19.TabIndex = 63;
            this.lblAT19.Text = "Actual";
            this.lblAT19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT15
            // 
            this.lblAT15.AutoSize = true;
            this.lblAT15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT15.Location = new System.Drawing.Point(592, 28);
            this.lblAT15.Name = "lblAT15";
            this.lblAT15.Size = new System.Drawing.Size(58, 16);
            this.lblAT15.TabIndex = 62;
            this.lblAT15.Text = "Actual";
            this.lblAT15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT14
            // 
            this.lblAT14.AutoSize = true;
            this.lblAT14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT14.Location = new System.Drawing.Point(206, 524);
            this.lblAT14.Margin = new System.Windows.Forms.Padding(0);
            this.lblAT14.Name = "lblAT14";
            this.lblAT14.Size = new System.Drawing.Size(64, 16);
            this.lblAT14.TabIndex = 61;
            this.lblAT14.Text = "Remaining";
            this.lblAT14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT12
            // 
            this.lblAT12.AutoSize = true;
            this.lblAT12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT12.Location = new System.Drawing.Point(209, 276);
            this.lblAT12.Name = "lblAT12";
            this.lblAT12.Size = new System.Drawing.Size(58, 16);
            this.lblAT12.TabIndex = 60;
            this.lblAT12.Text = "Actual";
            this.lblAT12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT13
            // 
            this.lblAT13.AutoSize = true;
            this.lblAT13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT13.Location = new System.Drawing.Point(209, 400);
            this.lblAT13.Name = "lblAT13";
            this.lblAT13.Size = new System.Drawing.Size(58, 16);
            this.lblAT13.TabIndex = 59;
            this.lblAT13.Text = "Actual";
            this.lblAT13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updB19
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB19, 2);
            this.updB19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB19.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB19.Location = new System.Drawing.Point(471, 540);
            this.updB19.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB19.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB19.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB19.Name = "updB19";
            this.updB19.Size = new System.Drawing.Size(88, 64);
            this.updB19.TabIndex = 57;
            this.updB19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB19.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB18
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB18, 2);
            this.updB18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB18.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB18.Location = new System.Drawing.Point(471, 416);
            this.updB18.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB18.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB18.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB18.Name = "updB18";
            this.updB18.Size = new System.Drawing.Size(88, 64);
            this.updB18.TabIndex = 56;
            this.updB18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB18.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB16
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB16, 2);
            this.updB16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB16.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB16.Location = new System.Drawing.Point(471, 168);
            this.updB16.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB16.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB16.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB16.Name = "updB16";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.updB16, 3);
            this.updB16.Size = new System.Drawing.Size(88, 64);
            this.updB16.TabIndex = 55;
            this.updB16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB16.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB15
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB15, 2);
            this.updB15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB15.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB15.Location = new System.Drawing.Point(471, 44);
            this.updB15.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB15.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB15.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB15.Name = "updB15";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.updB15, 3);
            this.updB15.Size = new System.Drawing.Size(88, 64);
            this.updB15.TabIndex = 54;
            this.updB15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB15.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB17
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB17, 2);
            this.updB17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB17.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB17.Location = new System.Drawing.Point(471, 292);
            this.updB17.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB17.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB17.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB17.Name = "updB17";
            this.updB17.Size = new System.Drawing.Size(88, 64);
            this.updB17.TabIndex = 53;
            this.updB17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB17.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB14
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB14, 2);
            this.updB14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB14.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB14.Location = new System.Drawing.Point(88, 540);
            this.updB14.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB14.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB14.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB14.Name = "updB14";
            this.updB14.Size = new System.Drawing.Size(88, 64);
            this.updB14.TabIndex = 52;
            this.updB14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB14.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // pbM19
            // 
            this.pbM19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM19.Image = global::MagusTools.Icons.ICON_ATTR_KPperLevel;
            this.pbM19.Location = new System.Drawing.Point(399, 540);
            this.pbM19.Margin = new System.Windows.Forms.Padding(0);
            this.pbM19.Name = "pbM19";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM19, 3);
            this.pbM19.Size = new System.Drawing.Size(64, 64);
            this.pbM19.TabIndex = 37;
            this.pbM19.TabStop = false;
            // 
            // pbM18
            // 
            this.pbM18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM18.Image = global::MagusTools.Icons.ICON_ATTR_KP;
            this.pbM18.Location = new System.Drawing.Point(399, 416);
            this.pbM18.Margin = new System.Windows.Forms.Padding(0);
            this.pbM18.Name = "pbM18";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM18, 3);
            this.pbM18.Size = new System.Drawing.Size(64, 64);
            this.pbM18.TabIndex = 36;
            this.pbM18.TabStop = false;
            // 
            // pbM16
            // 
            this.pbM16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM16.Image = global::MagusTools.Icons.ICON_ATTR_PR;
            this.pbM16.Location = new System.Drawing.Point(399, 168);
            this.pbM16.Margin = new System.Windows.Forms.Padding(0);
            this.pbM16.Name = "pbM16";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM16, 3);
            this.pbM16.Size = new System.Drawing.Size(64, 64);
            this.pbM16.TabIndex = 35;
            this.pbM16.TabStop = false;
            // 
            // pbM17
            // 
            this.pbM17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM17.Image = global::MagusTools.Icons.ICON_ATTR_PRperLevel;
            this.pbM17.Location = new System.Drawing.Point(399, 292);
            this.pbM17.Margin = new System.Windows.Forms.Padding(0);
            this.pbM17.Name = "pbM17";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM17, 3);
            this.pbM17.Size = new System.Drawing.Size(64, 64);
            this.pbM17.TabIndex = 34;
            this.pbM17.TabStop = false;
            // 
            // pbM15
            // 
            this.pbM15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM15.Image = global::MagusTools.Icons.ICON_ATTR_HP;
            this.pbM15.Location = new System.Drawing.Point(399, 44);
            this.pbM15.Margin = new System.Windows.Forms.Padding(0);
            this.pbM15.Name = "pbM15";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM15, 3);
            this.pbM15.Size = new System.Drawing.Size(64, 64);
            this.pbM15.TabIndex = 33;
            this.pbM15.TabStop = false;
            // 
            // pbM14
            // 
            this.pbM14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM14.Image = global::MagusTools.Icons.ICON_ATTR_CMperLevel;
            this.pbM14.Location = new System.Drawing.Point(16, 540);
            this.pbM14.Margin = new System.Windows.Forms.Padding(0);
            this.pbM14.Name = "pbM14";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM14, 3);
            this.pbM14.Size = new System.Drawing.Size(64, 64);
            this.pbM14.TabIndex = 32;
            this.pbM14.TabStop = false;
            // 
            // pbM13
            // 
            this.pbM13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM13.Image = global::MagusTools.Icons.ICON_ATTR_Aim;
            this.pbM13.Location = new System.Drawing.Point(16, 416);
            this.pbM13.Margin = new System.Windows.Forms.Padding(0);
            this.pbM13.Name = "pbM13";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM13, 3);
            this.pbM13.Size = new System.Drawing.Size(64, 64);
            this.pbM13.TabIndex = 31;
            this.pbM13.TabStop = false;
            // 
            // pbM12
            // 
            this.pbM12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM12.Image = global::MagusTools.Icons.ICON_ATTR_Defense;
            this.pbM12.Location = new System.Drawing.Point(16, 292);
            this.pbM12.Margin = new System.Windows.Forms.Padding(0);
            this.pbM12.Name = "pbM12";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM12, 3);
            this.pbM12.Size = new System.Drawing.Size(64, 64);
            this.pbM12.TabIndex = 30;
            this.pbM12.TabStop = false;
            // 
            // pbM11
            // 
            this.pbM11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM11.Image = global::MagusTools.Icons.ICON_ATTR_Attack;
            this.pbM11.Location = new System.Drawing.Point(16, 168);
            this.pbM11.Margin = new System.Windows.Forms.Padding(0);
            this.pbM11.Name = "pbM11";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM11, 3);
            this.pbM11.Size = new System.Drawing.Size(64, 64);
            this.pbM11.TabIndex = 29;
            this.pbM11.TabStop = false;
            // 
            // lblMAT19
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT19, 3);
            this.lblMAT19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT19.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT19.Location = new System.Drawing.Point(402, 512);
            this.lblMAT19.Name = "lblMAT19";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT19, 2);
            this.lblMAT19.Size = new System.Drawing.Size(154, 28);
            this.lblMAT19.TabIndex = 27;
            this.lblMAT19.Text = "KP / Level";
            this.lblMAT19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT18
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT18, 3);
            this.lblMAT18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT18.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT18.Location = new System.Drawing.Point(402, 388);
            this.lblMAT18.Name = "lblMAT18";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT18, 2);
            this.lblMAT18.Size = new System.Drawing.Size(154, 28);
            this.lblMAT18.TabIndex = 26;
            this.lblMAT18.Text = "KP";
            this.lblMAT18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT17
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT17, 3);
            this.lblMAT17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT17.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT17.Location = new System.Drawing.Point(402, 264);
            this.lblMAT17.Name = "lblMAT17";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT17, 2);
            this.lblMAT17.Size = new System.Drawing.Size(154, 28);
            this.lblMAT17.TabIndex = 25;
            this.lblMAT17.Text = "PR / Level";
            this.lblMAT17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT16
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT16, 3);
            this.lblMAT16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT16.Location = new System.Drawing.Point(402, 140);
            this.lblMAT16.Name = "lblMAT16";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT16, 2);
            this.lblMAT16.Size = new System.Drawing.Size(154, 28);
            this.lblMAT16.TabIndex = 24;
            this.lblMAT16.Text = "PR";
            this.lblMAT16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT15
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT15, 3);
            this.lblMAT15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT15.Location = new System.Drawing.Point(402, 16);
            this.lblMAT15.Name = "lblMAT15";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT15, 2);
            this.lblMAT15.Size = new System.Drawing.Size(154, 28);
            this.lblMAT15.TabIndex = 23;
            this.lblMAT15.Text = "HP";
            this.lblMAT15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMCT01
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMCT01, 4);
            this.lblMCT01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMCT01.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMCT01.Font = new System.Drawing.Font("Bookman Old Style", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMCT01.Location = new System.Drawing.Point(16, 644);
            this.lblMCT01.Margin = new System.Windows.Forms.Padding(0);
            this.lblMCT01.Name = "lblMCT01";
            this.lblMCT01.Size = new System.Drawing.Size(190, 24);
            this.lblMCT01.TabIndex = 22;
            this.lblMCT01.Text = "Spent CCP";
            this.lblMCT01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT14
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT14, 3);
            this.lblMAT14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT14.Location = new System.Drawing.Point(19, 512);
            this.lblMAT14.Name = "lblMAT14";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT14, 2);
            this.lblMAT14.Size = new System.Drawing.Size(154, 28);
            this.lblMAT14.TabIndex = 21;
            this.lblMAT14.Text = "CM / Level";
            this.lblMAT14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT13
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT13, 3);
            this.lblMAT13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT13.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT13.Location = new System.Drawing.Point(19, 388);
            this.lblMAT13.Name = "lblMAT13";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT13, 2);
            this.lblMAT13.Size = new System.Drawing.Size(154, 28);
            this.lblMAT13.TabIndex = 20;
            this.lblMAT13.Text = "Aim";
            this.lblMAT13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT12
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT12, 3);
            this.lblMAT12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT12.Location = new System.Drawing.Point(19, 264);
            this.lblMAT12.Name = "lblMAT12";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT12, 2);
            this.lblMAT12.Size = new System.Drawing.Size(154, 28);
            this.lblMAT12.TabIndex = 19;
            this.lblMAT12.Text = "Defense";
            this.lblMAT12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT11
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT11, 3);
            this.lblMAT11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT11.Location = new System.Drawing.Point(19, 140);
            this.lblMAT11.Name = "lblMAT11";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT11, 2);
            this.lblMAT11.Size = new System.Drawing.Size(154, 28);
            this.lblMAT11.TabIndex = 18;
            this.lblMAT11.Text = "Attack";
            this.lblMAT11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT10
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.lblMAT10, 3);
            this.lblMAT10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT10.Location = new System.Drawing.Point(16, 16);
            this.lblMAT10.Margin = new System.Windows.Forms.Padding(0);
            this.lblMAT10.Name = "lblMAT10";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.lblMAT10, 2);
            this.lblMAT10.Size = new System.Drawing.Size(160, 28);
            this.lblMAT10.TabIndex = 16;
            this.lblMAT10.Text = "Initiative";
            this.lblMAT10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAT10
            // 
            this.lblAT10.AutoSize = true;
            this.lblAT10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT10.Location = new System.Drawing.Point(209, 28);
            this.lblAT10.Name = "lblAT10";
            this.lblAT10.Size = new System.Drawing.Size(58, 16);
            this.lblAT10.TabIndex = 17;
            this.lblAT10.Text = "Actual";
            this.lblAT10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbM10
            // 
            this.pbM10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM10.Image = global::MagusTools.Icons.ICON_ATTR_Initiative;
            this.pbM10.Location = new System.Drawing.Point(16, 44);
            this.pbM10.Margin = new System.Windows.Forms.Padding(0);
            this.pbM10.Name = "pbM10";
            this.tlpSecondaryAttributesOld.SetRowSpan(this.pbM10, 3);
            this.pbM10.Size = new System.Drawing.Size(64, 64);
            this.pbM10.TabIndex = 28;
            this.pbM10.TabStop = false;
            // 
            // updB10
            // 
            this.tlpSecondaryAttributesOld.SetColumnSpan(this.updB10, 2);
            this.updB10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB10.Font = new System.Drawing.Font("Harrington", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB10.Location = new System.Drawing.Point(88, 44);
            this.updB10.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB10.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB10.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB10.Name = "updB10";
            this.updB10.Size = new System.Drawing.Size(88, 27);
            this.updB10.TabIndex = 48;
            this.updB10.Tag = "";
            this.updB10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB10.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblAV10
            // 
            this.lblAV10.AutoSize = true;
            this.lblAV10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV10.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV10.Location = new System.Drawing.Point(209, 44);
            this.lblAV10.Name = "lblAV10";
            this.lblAV10.Size = new System.Drawing.Size(58, 28);
            this.lblAV10.TabIndex = 67;
            this.lblAV10.Tag = "";
            this.lblAV10.Text = "12";
            this.lblAV10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPrimaryAttributes
            // 
            this.tabPrimaryAttributes.Controls.Add(this.tlpPrimaryAttributesOld);
            this.tabPrimaryAttributes.Location = new System.Drawing.Point(4, 24);
            this.tabPrimaryAttributes.Name = "tabPrimaryAttributes";
            this.tabPrimaryAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrimaryAttributes.Size = new System.Drawing.Size(676, 688);
            this.tabPrimaryAttributes.TabIndex = 10;
            this.tabPrimaryAttributes.Text = "Primary Attributes";
            this.tabPrimaryAttributes.UseVisualStyleBackColor = true;
            // 
            // tlpPrimaryAttributesOld
            // 
            this.tlpPrimaryAttributesOld.BackColor = System.Drawing.SystemColors.Window;
            this.tlpPrimaryAttributesOld.ColumnCount = 15;
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpPrimaryAttributesOld.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB00, 2, 3);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB01, 2, 11);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB02, 2, 19);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB03, 2, 27);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT06, 13, 14);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT09, 13, 38);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT08, 13, 30);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT07, 13, 22);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT05, 13, 6);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT04, 5, 38);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT03, 5, 30);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT02, 5, 22);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT01, 5, 14);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCT00, 5, 6);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbD00, 7, 1);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMSV00, 5, 40);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMCV00, 13, 40);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMCT00, 9, 40);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV08, 13, 27);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV08, 13, 29);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV09, 13, 35);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV09, 13, 37);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV05, 13, 3);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV05, 13, 5);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV06, 13, 11);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV06, 13, 13);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV07, 13, 19);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV07, 13, 21);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV04, 5, 35);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV04, 5, 37);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV03, 5, 27);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV03, 5, 29);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV02, 5, 19);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV02, 5, 21);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT06, 13, 10);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT01, 5, 10);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV01, 5, 11);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV01, 5, 13);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblCV00, 5, 5);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT07, 13, 18);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT08, 13, 26);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT09, 13, 34);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT05, 13, 2);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT04, 5, 34);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT02, 5, 18);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT03, 5, 26);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB09, 10, 35);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB08, 10, 27);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB06, 10, 11);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB05, 10, 3);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB07, 10, 19);
            this.tlpPrimaryAttributesOld.Controls.Add(this.updB04, 2, 35);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM09, 9, 35);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM08, 9, 27);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM06, 9, 11);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM07, 9, 19);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM05, 9, 3);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM04, 1, 35);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM03, 1, 27);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM02, 1, 19);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM01, 1, 11);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT09, 9, 33);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT08, 9, 25);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT07, 9, 17);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT06, 9, 9);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT05, 9, 1);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMST00, 1, 40);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT04, 1, 33);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT03, 1, 25);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT02, 1, 17);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT01, 1, 9);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblMAT00, 1, 1);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAT00, 5, 2);
            this.tlpPrimaryAttributesOld.Controls.Add(this.pbM00, 1, 3);
            this.tlpPrimaryAttributesOld.Controls.Add(this.lblAV00, 5, 3);
            this.tlpPrimaryAttributesOld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrimaryAttributesOld.Location = new System.Drawing.Point(3, 3);
            this.tlpPrimaryAttributesOld.Name = "tlpPrimaryAttributesOld";
            this.tlpPrimaryAttributesOld.RowCount = 42;
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpPrimaryAttributesOld.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tlpPrimaryAttributesOld.Size = new System.Drawing.Size(670, 682);
            this.tlpPrimaryAttributesOld.TabIndex = 2;
            // 
            // updB00
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB00, 2);
            this.updB00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB00.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB00.Location = new System.Drawing.Point(88, 44);
            this.updB00.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB00.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB00.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB00.Name = "updB00";
            this.updB00.Size = new System.Drawing.Size(88, 64);
            this.updB00.TabIndex = 106;
            this.updB00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB00.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB01
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB01, 2);
            this.updB01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB01.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB01.Location = new System.Drawing.Point(88, 168);
            this.updB01.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB01.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB01.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB01.Name = "updB01";
            this.updB01.Size = new System.Drawing.Size(88, 64);
            this.updB01.TabIndex = 105;
            this.updB01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB01.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB02
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB02, 2);
            this.updB02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB02.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB02.Location = new System.Drawing.Point(88, 292);
            this.updB02.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB02.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB02.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB02.Name = "updB02";
            this.updB02.Size = new System.Drawing.Size(88, 64);
            this.updB02.TabIndex = 104;
            this.updB02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB02.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB03
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB03, 2);
            this.updB03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB03.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB03.Location = new System.Drawing.Point(88, 416);
            this.updB03.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB03.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB03.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB03.Name = "updB03";
            this.updB03.Size = new System.Drawing.Size(88, 64);
            this.updB03.TabIndex = 103;
            this.updB03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB03.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblCT06
            // 
            this.lblCT06.AutoSize = true;
            this.lblCT06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT06.Location = new System.Drawing.Point(592, 232);
            this.lblCT06.Name = "lblCT06";
            this.lblCT06.Size = new System.Drawing.Size(58, 16);
            this.lblCT06.TabIndex = 102;
            this.lblCT06.Text = "CCP";
            this.lblCT06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT09
            // 
            this.lblCT09.AutoSize = true;
            this.lblCT09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT09.Location = new System.Drawing.Point(592, 604);
            this.lblCT09.Name = "lblCT09";
            this.lblCT09.Size = new System.Drawing.Size(58, 16);
            this.lblCT09.TabIndex = 101;
            this.lblCT09.Text = "CCP";
            this.lblCT09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT08
            // 
            this.lblCT08.AutoSize = true;
            this.lblCT08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT08.Location = new System.Drawing.Point(592, 480);
            this.lblCT08.Name = "lblCT08";
            this.lblCT08.Size = new System.Drawing.Size(58, 16);
            this.lblCT08.TabIndex = 100;
            this.lblCT08.Text = "CCP";
            this.lblCT08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT07
            // 
            this.lblCT07.AutoSize = true;
            this.lblCT07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT07.Location = new System.Drawing.Point(592, 356);
            this.lblCT07.Name = "lblCT07";
            this.lblCT07.Size = new System.Drawing.Size(58, 16);
            this.lblCT07.TabIndex = 99;
            this.lblCT07.Text = "CCP";
            this.lblCT07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT05
            // 
            this.lblCT05.AutoSize = true;
            this.lblCT05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT05.Location = new System.Drawing.Point(592, 108);
            this.lblCT05.Name = "lblCT05";
            this.lblCT05.Size = new System.Drawing.Size(58, 16);
            this.lblCT05.TabIndex = 98;
            this.lblCT05.Text = "CCP";
            this.lblCT05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT04
            // 
            this.lblCT04.AutoSize = true;
            this.lblCT04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT04.Location = new System.Drawing.Point(209, 604);
            this.lblCT04.Name = "lblCT04";
            this.lblCT04.Size = new System.Drawing.Size(58, 16);
            this.lblCT04.TabIndex = 97;
            this.lblCT04.Text = "CCP";
            this.lblCT04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT03
            // 
            this.lblCT03.AutoSize = true;
            this.lblCT03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT03.Location = new System.Drawing.Point(209, 480);
            this.lblCT03.Name = "lblCT03";
            this.lblCT03.Size = new System.Drawing.Size(58, 16);
            this.lblCT03.TabIndex = 96;
            this.lblCT03.Text = "CCP";
            this.lblCT03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT02
            // 
            this.lblCT02.AutoSize = true;
            this.lblCT02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT02.Location = new System.Drawing.Point(209, 356);
            this.lblCT02.Name = "lblCT02";
            this.lblCT02.Size = new System.Drawing.Size(58, 16);
            this.lblCT02.TabIndex = 95;
            this.lblCT02.Text = "CCP";
            this.lblCT02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT01
            // 
            this.lblCT01.AutoSize = true;
            this.lblCT01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT01.Location = new System.Drawing.Point(209, 232);
            this.lblCT01.Name = "lblCT01";
            this.lblCT01.Size = new System.Drawing.Size(58, 16);
            this.lblCT01.TabIndex = 94;
            this.lblCT01.Text = "CCP";
            this.lblCT01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCT00
            // 
            this.lblCT00.AutoSize = true;
            this.lblCT00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCT00.Location = new System.Drawing.Point(209, 108);
            this.lblCT00.Name = "lblCT00";
            this.lblCT00.Size = new System.Drawing.Size(58, 16);
            this.lblCT00.TabIndex = 93;
            this.lblCT00.Text = "CCP";
            this.lblCT00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbD00
            // 
            this.pbD00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbD00.Image = global::MagusTools.Decals.DECAL_SideBarA;
            this.pbD00.Location = new System.Drawing.Point(319, 16);
            this.pbD00.Margin = new System.Windows.Forms.Padding(0);
            this.pbD00.Name = "pbD00";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbD00, 40);
            this.pbD00.Size = new System.Drawing.Size(31, 652);
            this.pbD00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD00.TabIndex = 92;
            this.pbD00.TabStop = false;
            // 
            // lblMSV00
            // 
            this.lblMSV00.AutoSize = true;
            this.lblMSV00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSV00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMSV00.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSV00.Location = new System.Drawing.Point(209, 644);
            this.lblMSV00.Name = "lblMSV00";
            this.lblMSV00.Size = new System.Drawing.Size(58, 24);
            this.lblMSV00.TabIndex = 91;
            this.lblMSV00.Tag = "";
            this.lblMSV00.Text = "12";
            this.lblMSV00.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblMCV00
            // 
            this.lblMCV00.AutoSize = true;
            this.lblMCV00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMCV00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMCV00.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMCV00.Location = new System.Drawing.Point(592, 644);
            this.lblMCV00.Name = "lblMCV00";
            this.lblMCV00.Size = new System.Drawing.Size(58, 24);
            this.lblMCV00.TabIndex = 90;
            this.lblMCV00.Tag = "";
            this.lblMCV00.Text = "12";
            this.lblMCV00.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMCT00
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMCT00, 4);
            this.lblMCT00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMCT00.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMCT00.Font = new System.Drawing.Font("Bookman Old Style", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMCT00.Location = new System.Drawing.Point(399, 644);
            this.lblMCT00.Margin = new System.Windows.Forms.Padding(0);
            this.lblMCT00.Name = "lblMCT00";
            this.lblMCT00.Size = new System.Drawing.Size(190, 24);
            this.lblMCT00.TabIndex = 89;
            this.lblMCT00.Text = "Spent CCP";
            this.lblMCT00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAV08
            // 
            this.lblAV08.AutoSize = true;
            this.lblAV08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV08.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV08.Location = new System.Drawing.Point(592, 416);
            this.lblAV08.Name = "lblAV08";
            this.lblAV08.Size = new System.Drawing.Size(58, 28);
            this.lblAV08.TabIndex = 88;
            this.lblAV08.Tag = "";
            this.lblAV08.Text = "12";
            this.lblAV08.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV08
            // 
            this.lblCV08.AutoSize = true;
            this.lblCV08.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV08.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV08.Location = new System.Drawing.Point(592, 452);
            this.lblCV08.Name = "lblCV08";
            this.lblCV08.Size = new System.Drawing.Size(58, 28);
            this.lblCV08.TabIndex = 87;
            this.lblCV08.Tag = "";
            this.lblCV08.Text = "12";
            this.lblCV08.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV09
            // 
            this.lblAV09.AutoSize = true;
            this.lblAV09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV09.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV09.Location = new System.Drawing.Point(592, 540);
            this.lblAV09.Name = "lblAV09";
            this.lblAV09.Size = new System.Drawing.Size(58, 28);
            this.lblAV09.TabIndex = 86;
            this.lblAV09.Tag = "";
            this.lblAV09.Text = "12";
            this.lblAV09.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV09
            // 
            this.lblCV09.AutoSize = true;
            this.lblCV09.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV09.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV09.Location = new System.Drawing.Point(592, 576);
            this.lblCV09.Name = "lblCV09";
            this.lblCV09.Size = new System.Drawing.Size(58, 28);
            this.lblCV09.TabIndex = 85;
            this.lblCV09.Tag = "";
            this.lblCV09.Text = "12";
            this.lblCV09.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV05
            // 
            this.lblAV05.AutoSize = true;
            this.lblAV05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV05.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV05.Location = new System.Drawing.Point(592, 44);
            this.lblAV05.Name = "lblAV05";
            this.lblAV05.Size = new System.Drawing.Size(58, 28);
            this.lblAV05.TabIndex = 84;
            this.lblAV05.Tag = "";
            this.lblAV05.Text = "12";
            this.lblAV05.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV05
            // 
            this.lblCV05.AutoSize = true;
            this.lblCV05.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV05.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV05.Location = new System.Drawing.Point(592, 80);
            this.lblCV05.Name = "lblCV05";
            this.lblCV05.Size = new System.Drawing.Size(58, 28);
            this.lblCV05.TabIndex = 83;
            this.lblCV05.Tag = "";
            this.lblCV05.Text = "12";
            this.lblCV05.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV06
            // 
            this.lblAV06.AutoSize = true;
            this.lblAV06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV06.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV06.Location = new System.Drawing.Point(592, 168);
            this.lblAV06.Name = "lblAV06";
            this.lblAV06.Size = new System.Drawing.Size(58, 28);
            this.lblAV06.TabIndex = 82;
            this.lblAV06.Tag = "";
            this.lblAV06.Text = "12";
            this.lblAV06.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV06
            // 
            this.lblCV06.AutoSize = true;
            this.lblCV06.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV06.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV06.Location = new System.Drawing.Point(592, 204);
            this.lblCV06.Name = "lblCV06";
            this.lblCV06.Size = new System.Drawing.Size(58, 28);
            this.lblCV06.TabIndex = 81;
            this.lblCV06.Tag = "";
            this.lblCV06.Text = "12";
            this.lblCV06.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV07
            // 
            this.lblAV07.AutoSize = true;
            this.lblAV07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV07.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV07.Location = new System.Drawing.Point(592, 292);
            this.lblAV07.Name = "lblAV07";
            this.lblAV07.Size = new System.Drawing.Size(58, 28);
            this.lblAV07.TabIndex = 80;
            this.lblAV07.Tag = "";
            this.lblAV07.Text = "12";
            this.lblAV07.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV07
            // 
            this.lblCV07.AutoSize = true;
            this.lblCV07.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV07.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV07.Location = new System.Drawing.Point(592, 328);
            this.lblCV07.Name = "lblCV07";
            this.lblCV07.Size = new System.Drawing.Size(58, 28);
            this.lblCV07.TabIndex = 79;
            this.lblCV07.Tag = "";
            this.lblCV07.Text = "12";
            this.lblCV07.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV04
            // 
            this.lblAV04.AutoSize = true;
            this.lblAV04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV04.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV04.Location = new System.Drawing.Point(209, 540);
            this.lblAV04.Name = "lblAV04";
            this.lblAV04.Size = new System.Drawing.Size(58, 28);
            this.lblAV04.TabIndex = 78;
            this.lblAV04.Tag = "";
            this.lblAV04.Text = "12";
            this.lblAV04.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV04
            // 
            this.lblCV04.AutoSize = true;
            this.lblCV04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV04.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV04.Location = new System.Drawing.Point(209, 576);
            this.lblCV04.Name = "lblCV04";
            this.lblCV04.Size = new System.Drawing.Size(58, 28);
            this.lblCV04.TabIndex = 77;
            this.lblCV04.Tag = "";
            this.lblCV04.Text = "12";
            this.lblCV04.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV03
            // 
            this.lblAV03.AutoSize = true;
            this.lblAV03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV03.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV03.Location = new System.Drawing.Point(209, 416);
            this.lblAV03.Name = "lblAV03";
            this.lblAV03.Size = new System.Drawing.Size(58, 28);
            this.lblAV03.TabIndex = 76;
            this.lblAV03.Tag = "";
            this.lblAV03.Text = "12";
            this.lblAV03.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV03
            // 
            this.lblCV03.AutoSize = true;
            this.lblCV03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV03.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV03.Location = new System.Drawing.Point(209, 452);
            this.lblCV03.Name = "lblCV03";
            this.lblCV03.Size = new System.Drawing.Size(58, 28);
            this.lblCV03.TabIndex = 75;
            this.lblCV03.Tag = "";
            this.lblCV03.Text = "12";
            this.lblCV03.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAV02
            // 
            this.lblAV02.AutoSize = true;
            this.lblAV02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV02.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV02.Location = new System.Drawing.Point(209, 292);
            this.lblAV02.Name = "lblAV02";
            this.lblAV02.Size = new System.Drawing.Size(58, 28);
            this.lblAV02.TabIndex = 74;
            this.lblAV02.Tag = "";
            this.lblAV02.Text = "12";
            this.lblAV02.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV02
            // 
            this.lblCV02.AutoSize = true;
            this.lblCV02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV02.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV02.Location = new System.Drawing.Point(209, 328);
            this.lblCV02.Name = "lblCV02";
            this.lblCV02.Size = new System.Drawing.Size(58, 28);
            this.lblCV02.TabIndex = 73;
            this.lblCV02.Tag = "";
            this.lblCV02.Text = "12";
            this.lblCV02.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAT06
            // 
            this.lblAT06.AutoSize = true;
            this.lblAT06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT06.Location = new System.Drawing.Point(592, 152);
            this.lblAT06.Name = "lblAT06";
            this.lblAT06.Size = new System.Drawing.Size(58, 16);
            this.lblAT06.TabIndex = 72;
            this.lblAT06.Text = "Actual";
            this.lblAT06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT01
            // 
            this.lblAT01.AutoSize = true;
            this.lblAT01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT01.Location = new System.Drawing.Point(209, 152);
            this.lblAT01.Name = "lblAT01";
            this.lblAT01.Size = new System.Drawing.Size(58, 16);
            this.lblAT01.TabIndex = 71;
            this.lblAT01.Text = "Actual";
            this.lblAT01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAV01
            // 
            this.lblAV01.AutoSize = true;
            this.lblAV01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV01.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV01.Location = new System.Drawing.Point(209, 168);
            this.lblAV01.Name = "lblAV01";
            this.lblAV01.Size = new System.Drawing.Size(58, 28);
            this.lblAV01.TabIndex = 70;
            this.lblAV01.Tag = "";
            this.lblAV01.Text = "12";
            this.lblAV01.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCV01
            // 
            this.lblCV01.AutoSize = true;
            this.lblCV01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV01.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV01.Location = new System.Drawing.Point(209, 204);
            this.lblCV01.Name = "lblCV01";
            this.lblCV01.Size = new System.Drawing.Size(58, 28);
            this.lblCV01.TabIndex = 69;
            this.lblCV01.Tag = "";
            this.lblCV01.Text = "12";
            this.lblCV01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCV00
            // 
            this.lblCV00.AutoSize = true;
            this.lblCV00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCV00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCV00.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV00.Location = new System.Drawing.Point(209, 80);
            this.lblCV00.Name = "lblCV00";
            this.lblCV00.Size = new System.Drawing.Size(58, 28);
            this.lblCV00.TabIndex = 68;
            this.lblCV00.Tag = "";
            this.lblCV00.Text = "12";
            this.lblCV00.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblAT07
            // 
            this.lblAT07.AutoSize = true;
            this.lblAT07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT07.Location = new System.Drawing.Point(592, 276);
            this.lblAT07.Name = "lblAT07";
            this.lblAT07.Size = new System.Drawing.Size(58, 16);
            this.lblAT07.TabIndex = 66;
            this.lblAT07.Text = "Actual";
            this.lblAT07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT08
            // 
            this.lblAT08.AutoSize = true;
            this.lblAT08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT08.Location = new System.Drawing.Point(592, 400);
            this.lblAT08.Name = "lblAT08";
            this.lblAT08.Size = new System.Drawing.Size(58, 16);
            this.lblAT08.TabIndex = 64;
            this.lblAT08.Text = "Actual";
            this.lblAT08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT09
            // 
            this.lblAT09.AutoSize = true;
            this.lblAT09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT09.Location = new System.Drawing.Point(592, 524);
            this.lblAT09.Name = "lblAT09";
            this.lblAT09.Size = new System.Drawing.Size(58, 16);
            this.lblAT09.TabIndex = 63;
            this.lblAT09.Text = "Actual";
            this.lblAT09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT05
            // 
            this.lblAT05.AutoSize = true;
            this.lblAT05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT05.Location = new System.Drawing.Point(592, 28);
            this.lblAT05.Name = "lblAT05";
            this.lblAT05.Size = new System.Drawing.Size(58, 16);
            this.lblAT05.TabIndex = 62;
            this.lblAT05.Text = "Actual";
            this.lblAT05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT04
            // 
            this.lblAT04.AutoSize = true;
            this.lblAT04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT04.Location = new System.Drawing.Point(209, 524);
            this.lblAT04.Name = "lblAT04";
            this.lblAT04.Size = new System.Drawing.Size(58, 16);
            this.lblAT04.TabIndex = 61;
            this.lblAT04.Text = "Actual";
            this.lblAT04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT02
            // 
            this.lblAT02.AutoSize = true;
            this.lblAT02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT02.Location = new System.Drawing.Point(209, 276);
            this.lblAT02.Name = "lblAT02";
            this.lblAT02.Size = new System.Drawing.Size(58, 16);
            this.lblAT02.TabIndex = 60;
            this.lblAT02.Text = "Actual";
            this.lblAT02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAT03
            // 
            this.lblAT03.AutoSize = true;
            this.lblAT03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT03.Location = new System.Drawing.Point(209, 400);
            this.lblAT03.Name = "lblAT03";
            this.lblAT03.Size = new System.Drawing.Size(58, 16);
            this.lblAT03.TabIndex = 59;
            this.lblAT03.Text = "Actual";
            this.lblAT03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updB09
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB09, 2);
            this.updB09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB09.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB09.Location = new System.Drawing.Point(471, 540);
            this.updB09.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB09.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB09.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB09.Name = "updB09";
            this.updB09.Size = new System.Drawing.Size(88, 64);
            this.updB09.TabIndex = 57;
            this.updB09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB09.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB08
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB08, 2);
            this.updB08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB08.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB08.Location = new System.Drawing.Point(471, 416);
            this.updB08.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB08.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB08.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB08.Name = "updB08";
            this.updB08.Size = new System.Drawing.Size(88, 64);
            this.updB08.TabIndex = 56;
            this.updB08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB08.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB06
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB06, 2);
            this.updB06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB06.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB06.Location = new System.Drawing.Point(471, 168);
            this.updB06.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB06.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB06.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB06.Name = "updB06";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.updB06, 3);
            this.updB06.Size = new System.Drawing.Size(88, 64);
            this.updB06.TabIndex = 55;
            this.updB06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB06.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB05
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB05, 2);
            this.updB05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB05.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB05.Location = new System.Drawing.Point(471, 44);
            this.updB05.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB05.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB05.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB05.Name = "updB05";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.updB05, 3);
            this.updB05.Size = new System.Drawing.Size(88, 64);
            this.updB05.TabIndex = 54;
            this.updB05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB05.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB07
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB07, 2);
            this.updB07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB07.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB07.Location = new System.Drawing.Point(471, 292);
            this.updB07.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB07.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB07.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB07.Name = "updB07";
            this.updB07.Size = new System.Drawing.Size(88, 64);
            this.updB07.TabIndex = 53;
            this.updB07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB07.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // updB04
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.updB04, 2);
            this.updB04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updB04.Font = new System.Drawing.Font("Harrington", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updB04.Location = new System.Drawing.Point(88, 540);
            this.updB04.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updB04.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updB04.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updB04.Name = "updB04";
            this.updB04.Size = new System.Drawing.Size(88, 64);
            this.updB04.TabIndex = 52;
            this.updB04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updB04.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // pbM09
            // 
            this.pbM09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM09.Image = global::MagusTools.Icons.ICON_ATTR_Perception;
            this.pbM09.Location = new System.Drawing.Point(399, 540);
            this.pbM09.Margin = new System.Windows.Forms.Padding(0);
            this.pbM09.Name = "pbM09";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM09, 3);
            this.pbM09.Size = new System.Drawing.Size(64, 64);
            this.pbM09.TabIndex = 37;
            this.pbM09.TabStop = false;
            // 
            // pbM08
            // 
            this.pbM08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM08.Image = global::MagusTools.Icons.ICON_ATTR_Astral;
            this.pbM08.Location = new System.Drawing.Point(399, 416);
            this.pbM08.Margin = new System.Windows.Forms.Padding(0);
            this.pbM08.Name = "pbM08";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM08, 3);
            this.pbM08.Size = new System.Drawing.Size(64, 64);
            this.pbM08.TabIndex = 36;
            this.pbM08.TabStop = false;
            // 
            // pbM06
            // 
            this.pbM06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM06.Image = global::MagusTools.Icons.ICON_ATTR_Intelligence;
            this.pbM06.Location = new System.Drawing.Point(399, 168);
            this.pbM06.Margin = new System.Windows.Forms.Padding(0);
            this.pbM06.Name = "pbM06";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM06, 3);
            this.pbM06.Size = new System.Drawing.Size(64, 64);
            this.pbM06.TabIndex = 35;
            this.pbM06.TabStop = false;
            // 
            // pbM07
            // 
            this.pbM07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM07.Image = global::MagusTools.Icons.ICON_ATTR_Willpower;
            this.pbM07.Location = new System.Drawing.Point(399, 292);
            this.pbM07.Margin = new System.Windows.Forms.Padding(0);
            this.pbM07.Name = "pbM07";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM07, 3);
            this.pbM07.Size = new System.Drawing.Size(64, 64);
            this.pbM07.TabIndex = 34;
            this.pbM07.TabStop = false;
            // 
            // pbM05
            // 
            this.pbM05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM05.Image = global::MagusTools.Icons.ICON_ATTR_Charisma;
            this.pbM05.Location = new System.Drawing.Point(399, 44);
            this.pbM05.Margin = new System.Windows.Forms.Padding(0);
            this.pbM05.Name = "pbM05";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM05, 3);
            this.pbM05.Size = new System.Drawing.Size(64, 64);
            this.pbM05.TabIndex = 33;
            this.pbM05.TabStop = false;
            // 
            // pbM04
            // 
            this.pbM04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM04.Image = global::MagusTools.Icons.ICON_ATTR_Health;
            this.pbM04.Location = new System.Drawing.Point(16, 540);
            this.pbM04.Margin = new System.Windows.Forms.Padding(0);
            this.pbM04.Name = "pbM04";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM04, 3);
            this.pbM04.Size = new System.Drawing.Size(64, 64);
            this.pbM04.TabIndex = 32;
            this.pbM04.TabStop = false;
            // 
            // pbM03
            // 
            this.pbM03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM03.Image = global::MagusTools.Icons.ICON_ATTR_Endurance;
            this.pbM03.Location = new System.Drawing.Point(16, 416);
            this.pbM03.Margin = new System.Windows.Forms.Padding(0);
            this.pbM03.Name = "pbM03";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM03, 3);
            this.pbM03.Size = new System.Drawing.Size(64, 64);
            this.pbM03.TabIndex = 31;
            this.pbM03.TabStop = false;
            // 
            // pbM02
            // 
            this.pbM02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM02.Image = global::MagusTools.Icons.ICON_ATTR_Agility;
            this.pbM02.Location = new System.Drawing.Point(16, 292);
            this.pbM02.Margin = new System.Windows.Forms.Padding(0);
            this.pbM02.Name = "pbM02";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM02, 3);
            this.pbM02.Size = new System.Drawing.Size(64, 64);
            this.pbM02.TabIndex = 30;
            this.pbM02.TabStop = false;
            // 
            // pbM01
            // 
            this.pbM01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM01.Image = global::MagusTools.Icons.ICON_ATTR_Speed;
            this.pbM01.Location = new System.Drawing.Point(16, 168);
            this.pbM01.Margin = new System.Windows.Forms.Padding(0);
            this.pbM01.Name = "pbM01";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM01, 3);
            this.pbM01.Size = new System.Drawing.Size(64, 64);
            this.pbM01.TabIndex = 29;
            this.pbM01.TabStop = false;
            // 
            // lblMAT09
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT09, 3);
            this.lblMAT09.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT09.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT09.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT09.Location = new System.Drawing.Point(402, 512);
            this.lblMAT09.Name = "lblMAT09";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT09, 2);
            this.lblMAT09.Size = new System.Drawing.Size(154, 28);
            this.lblMAT09.TabIndex = 27;
            this.lblMAT09.Text = "Perception";
            this.lblMAT09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT08
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT08, 3);
            this.lblMAT08.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT08.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT08.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT08.Location = new System.Drawing.Point(402, 388);
            this.lblMAT08.Name = "lblMAT08";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT08, 2);
            this.lblMAT08.Size = new System.Drawing.Size(154, 28);
            this.lblMAT08.TabIndex = 26;
            this.lblMAT08.Text = "Astral";
            this.lblMAT08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT07
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT07, 3);
            this.lblMAT07.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT07.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT07.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT07.Location = new System.Drawing.Point(402, 264);
            this.lblMAT07.Name = "lblMAT07";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT07, 2);
            this.lblMAT07.Size = new System.Drawing.Size(154, 28);
            this.lblMAT07.TabIndex = 25;
            this.lblMAT07.Text = "Willpower";
            this.lblMAT07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT06
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT06, 3);
            this.lblMAT06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT06.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT06.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT06.Location = new System.Drawing.Point(402, 140);
            this.lblMAT06.Name = "lblMAT06";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT06, 2);
            this.lblMAT06.Size = new System.Drawing.Size(154, 28);
            this.lblMAT06.TabIndex = 24;
            this.lblMAT06.Text = "Intelligence";
            this.lblMAT06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT05
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT05, 3);
            this.lblMAT05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT05.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT05.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT05.Location = new System.Drawing.Point(402, 16);
            this.lblMAT05.Name = "lblMAT05";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT05, 2);
            this.lblMAT05.Size = new System.Drawing.Size(154, 28);
            this.lblMAT05.TabIndex = 23;
            this.lblMAT05.Text = "Charisma";
            this.lblMAT05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMST00
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMST00, 4);
            this.lblMST00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMST00.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMST00.Font = new System.Drawing.Font("Bookman Old Style", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMST00.Location = new System.Drawing.Point(16, 644);
            this.lblMST00.Margin = new System.Windows.Forms.Padding(0);
            this.lblMST00.Name = "lblMST00";
            this.lblMST00.Size = new System.Drawing.Size(190, 24);
            this.lblMST00.TabIndex = 22;
            this.lblMST00.Text = "Stat Average";
            this.lblMST00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT04
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT04, 3);
            this.lblMAT04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT04.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT04.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT04.Location = new System.Drawing.Point(19, 512);
            this.lblMAT04.Name = "lblMAT04";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT04, 2);
            this.lblMAT04.Size = new System.Drawing.Size(154, 28);
            this.lblMAT04.TabIndex = 21;
            this.lblMAT04.Text = "Health";
            this.lblMAT04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT03
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT03, 3);
            this.lblMAT03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT03.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT03.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT03.Location = new System.Drawing.Point(19, 388);
            this.lblMAT03.Name = "lblMAT03";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT03, 2);
            this.lblMAT03.Size = new System.Drawing.Size(154, 28);
            this.lblMAT03.TabIndex = 20;
            this.lblMAT03.Text = "Endurance";
            this.lblMAT03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT02
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT02, 3);
            this.lblMAT02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT02.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT02.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT02.Location = new System.Drawing.Point(19, 264);
            this.lblMAT02.Name = "lblMAT02";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT02, 2);
            this.lblMAT02.Size = new System.Drawing.Size(154, 28);
            this.lblMAT02.TabIndex = 19;
            this.lblMAT02.Text = "Agility";
            this.lblMAT02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT01
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT01, 3);
            this.lblMAT01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT01.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT01.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT01.Location = new System.Drawing.Point(19, 140);
            this.lblMAT01.Name = "lblMAT01";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT01, 2);
            this.lblMAT01.Size = new System.Drawing.Size(154, 28);
            this.lblMAT01.TabIndex = 18;
            this.lblMAT01.Text = "Speed";
            this.lblMAT01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMAT00
            // 
            this.tlpPrimaryAttributesOld.SetColumnSpan(this.lblMAT00, 3);
            this.lblMAT00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMAT00.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMAT00.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMAT00.Location = new System.Drawing.Point(16, 16);
            this.lblMAT00.Margin = new System.Windows.Forms.Padding(0);
            this.lblMAT00.Name = "lblMAT00";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.lblMAT00, 2);
            this.lblMAT00.Size = new System.Drawing.Size(160, 28);
            this.lblMAT00.TabIndex = 16;
            this.lblMAT00.Text = "Strength";
            this.lblMAT00.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAT00
            // 
            this.lblAT00.AutoSize = true;
            this.lblAT00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAT00.Location = new System.Drawing.Point(209, 28);
            this.lblAT00.Name = "lblAT00";
            this.lblAT00.Size = new System.Drawing.Size(58, 16);
            this.lblAT00.TabIndex = 17;
            this.lblAT00.Text = "Actual";
            this.lblAT00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbM00
            // 
            this.pbM00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbM00.Image = global::MagusTools.Icons.ICON_ATTR_Strength;
            this.pbM00.Location = new System.Drawing.Point(16, 44);
            this.pbM00.Margin = new System.Windows.Forms.Padding(0);
            this.pbM00.Name = "pbM00";
            this.tlpPrimaryAttributesOld.SetRowSpan(this.pbM00, 3);
            this.pbM00.Size = new System.Drawing.Size(64, 64);
            this.pbM00.TabIndex = 28;
            this.pbM00.TabStop = false;
            // 
            // lblAV00
            // 
            this.lblAV00.AutoSize = true;
            this.lblAV00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAV00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAV00.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAV00.Location = new System.Drawing.Point(209, 44);
            this.lblAV00.Name = "lblAV00";
            this.lblAV00.Size = new System.Drawing.Size(58, 28);
            this.lblAV00.TabIndex = 67;
            this.lblAV00.Tag = "";
            this.lblAV00.Text = "12";
            this.lblAV00.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabBasicInfo
            // 
            this.tabBasicInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabBasicInfo.Controls.Add(this.tlpBasicInfo);
            this.tabBasicInfo.Location = new System.Drawing.Point(4, 24);
            this.tabBasicInfo.Name = "tabBasicInfo";
            this.tabBasicInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasicInfo.Size = new System.Drawing.Size(676, 688);
            this.tabBasicInfo.TabIndex = 0;
            this.tabBasicInfo.Text = "BasicInformation";
            this.tabBasicInfo.UseVisualStyleBackColor = true;
            // 
            // tlpBasicInfo
            // 
            this.tlpBasicInfo.ColumnCount = 13;
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tlpBasicInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpBasicInfo.Controls.Add(this.lblOV05, 3, 16);
            this.tlpBasicInfo.Controls.Add(this.lblOV06, 3, 17);
            this.tlpBasicInfo.Controls.Add(this.lblCharPSYperLevel, 1, 17);
            this.tlpBasicInfo.Controls.Add(this.lblCharPsy, 1, 16);
            this.tlpBasicInfo.Controls.Add(this.updCharLevel, 11, 1);
            this.tlpBasicInfo.Controls.Add(this.lblCharName, 1, 0);
            this.tlpBasicInfo.Controls.Add(this.txtCharName, 1, 1);
            this.tlpBasicInfo.Controls.Add(this.lblCharGender, 1, 2);
            this.tlpBasicInfo.Controls.Add(this.lblCharAge, 7, 2);
            this.tlpBasicInfo.Controls.Add(this.lblCharRace, 9, 2);
            this.tlpBasicInfo.Controls.Add(this.lblCharLevel, 11, 0);
            this.tlpBasicInfo.Controls.Add(this.cbCharGender, 1, 3);
            this.tlpBasicInfo.Controls.Add(this.updCharAge, 7, 3);
            this.tlpBasicInfo.Controls.Add(this.cbCharRace, 9, 3);
            this.tlpBasicInfo.Controls.Add(this.lblCharClass, 1, 4);
            this.tlpBasicInfo.Controls.Add(this.lblCharAlignment, 3, 2);
            this.tlpBasicInfo.Controls.Add(this.cbCharAlignment, 3, 3);
            this.tlpBasicInfo.Controls.Add(this.lblCharBirthplace, 5, 4);
            this.tlpBasicInfo.Controls.Add(this.cbCharClass, 1, 5);
            this.tlpBasicInfo.Controls.Add(this.cbCharBirthplace, 5, 5);
            this.tlpBasicInfo.Controls.Add(this.lblCharReligion, 1, 6);
            this.tlpBasicInfo.Controls.Add(this.lblCharRealms, 5, 6);
            this.tlpBasicInfo.Controls.Add(this.cbCharReligion, 1, 7);
            this.tlpBasicInfo.Controls.Add(this.lblCharRealmsList, 5, 7);
            this.tlpBasicInfo.Controls.Add(this.lblCharAvailableCCP, 11, 4);
            this.tlpBasicInfo.Controls.Add(this.lblCharCCP, 11, 5);
            this.tlpBasicInfo.Controls.Add(this.lblMiscHypen, 4, 7);
            this.tlpBasicInfo.Controls.Add(this.pbD02, 1, 9);
            this.tlpBasicInfo.Controls.Add(this.lblOV01, 3, 12);
            this.tlpBasicInfo.Controls.Add(this.lblOV02, 3, 13);
            this.tlpBasicInfo.Controls.Add(this.lblCharMP, 1, 14);
            this.tlpBasicInfo.Controls.Add(this.lblOV03, 3, 14);
            this.tlpBasicInfo.Controls.Add(this.lblCharMPperLevel, 1, 15);
            this.tlpBasicInfo.Controls.Add(this.lblOV04, 3, 15);
            this.tlpBasicInfo.Controls.Add(this.tableLayoutPanel1, 7, 11);
            this.tlpBasicInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBasicInfo.Location = new System.Drawing.Point(3, 3);
            this.tlpBasicInfo.Name = "tlpBasicInfo";
            this.tlpBasicInfo.RowCount = 19;
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpBasicInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBasicInfo.Size = new System.Drawing.Size(670, 682);
            this.tlpBasicInfo.TabIndex = 0;
            // 
            // lblOV05
            // 
            this.lblOV05.AutoSize = true;
            this.lblOV05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV05.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV05.Location = new System.Drawing.Point(146, 559);
            this.lblOV05.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV05.Name = "lblOV05";
            this.lblOV05.Size = new System.Drawing.Size(60, 36);
            this.lblOV05.TabIndex = 65;
            this.lblOV05.Text = "0";
            this.lblOV05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOV06
            // 
            this.lblOV06.AutoSize = true;
            this.lblOV06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV06.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV06.Location = new System.Drawing.Point(146, 595);
            this.lblOV06.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV06.Name = "lblOV06";
            this.lblOV06.Size = new System.Drawing.Size(60, 36);
            this.lblOV06.TabIndex = 66;
            this.lblOV06.Text = "0";
            this.lblOV06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharPSYperLevel
            // 
            this.lblCharPSYperLevel.AutoSize = true;
            this.lblCharPSYperLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharPSYperLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharPSYperLevel.Location = new System.Drawing.Point(26, 595);
            this.lblCharPSYperLevel.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharPSYperLevel.Name = "lblCharPSYperLevel";
            this.lblCharPSYperLevel.Size = new System.Drawing.Size(107, 36);
            this.lblCharPSYperLevel.TabIndex = 64;
            this.lblCharPSYperLevel.Text = "Psy / Level";
            this.lblCharPSYperLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharPsy
            // 
            this.lblCharPsy.AutoSize = true;
            this.lblCharPsy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharPsy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharPsy.Location = new System.Drawing.Point(26, 559);
            this.lblCharPsy.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharPsy.Name = "lblCharPsy";
            this.lblCharPsy.Size = new System.Drawing.Size(107, 36);
            this.lblCharPsy.TabIndex = 63;
            this.lblCharPsy.Text = "Psy";
            this.lblCharPsy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updCharLevel
            // 
            this.updCharLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updCharLevel.Font = new System.Drawing.Font("Harrington", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updCharLevel.Location = new System.Drawing.Point(505, 36);
            this.updCharLevel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.updCharLevel.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updCharLevel.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.updCharLevel.Name = "updCharLevel";
            this.tlpBasicInfo.SetRowSpan(this.updCharLevel, 3);
            this.updCharLevel.Size = new System.Drawing.Size(132, 102);
            this.updCharLevel.TabIndex = 49;
            this.updCharLevel.Tag = "";
            this.updCharLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updCharLevel.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.updCharLevel.ValueChanged += new System.EventHandler(this.updCharLevel_ValueChanged);
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharName, 3);
            this.lblCharName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharName.Location = new System.Drawing.Point(26, 0);
            this.lblCharName.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(180, 36);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Character\'s name";
            this.lblCharName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCharName
            // 
            this.tlpBasicInfo.SetColumnSpan(this.txtCharName, 9);
            this.txtCharName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCharName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCharName.Location = new System.Drawing.Point(29, 39);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(419, 29);
            this.txtCharName.TabIndex = 1;
            // 
            // lblCharGender
            // 
            this.lblCharGender.AutoSize = true;
            this.lblCharGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharGender.Location = new System.Drawing.Point(26, 72);
            this.lblCharGender.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharGender.Name = "lblCharGender";
            this.lblCharGender.Size = new System.Drawing.Size(107, 36);
            this.lblCharGender.TabIndex = 2;
            this.lblCharGender.Text = "Gender";
            this.lblCharGender.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCharAge
            // 
            this.lblCharAge.AutoSize = true;
            this.lblCharAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharAge.Location = new System.Drawing.Point(285, 72);
            this.lblCharAge.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharAge.Name = "lblCharAge";
            this.lblCharAge.Size = new System.Drawing.Size(53, 36);
            this.lblCharAge.TabIndex = 4;
            this.lblCharAge.Text = "Age";
            this.lblCharAge.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCharRace
            // 
            this.lblCharRace.AutoSize = true;
            this.lblCharRace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharRace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharRace.Location = new System.Drawing.Point(351, 72);
            this.lblCharRace.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharRace.Name = "lblCharRace";
            this.lblCharRace.Size = new System.Drawing.Size(100, 36);
            this.lblCharRace.TabIndex = 5;
            this.lblCharRace.Text = "Race";
            this.lblCharRace.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCharLevel
            // 
            this.lblCharLevel.AutoSize = true;
            this.lblCharLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharLevel.Location = new System.Drawing.Point(500, 0);
            this.lblCharLevel.Name = "lblCharLevel";
            this.lblCharLevel.Size = new System.Drawing.Size(134, 36);
            this.lblCharLevel.TabIndex = 6;
            this.lblCharLevel.Text = "Level";
            this.lblCharLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbCharGender
            // 
            this.cbCharGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCharGender.FormattingEnabled = true;
            this.cbCharGender.Location = new System.Drawing.Point(29, 111);
            this.cbCharGender.Name = "cbCharGender";
            this.cbCharGender.Size = new System.Drawing.Size(101, 29);
            this.cbCharGender.TabIndex = 7;
            // 
            // updCharAge
            // 
            this.updCharAge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updCharAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updCharAge.Location = new System.Drawing.Point(288, 111);
            this.updCharAge.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.updCharAge.Name = "updCharAge";
            this.updCharAge.Size = new System.Drawing.Size(47, 29);
            this.updCharAge.TabIndex = 9;
            // 
            // cbCharRace
            // 
            this.cbCharRace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharRace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCharRace.FormattingEnabled = true;
            this.cbCharRace.Items.AddRange(new object[] {
            "Race On!",
            "I\'m Racist!",
            "Fun Racing!"});
            this.cbCharRace.Location = new System.Drawing.Point(354, 111);
            this.cbCharRace.Name = "cbCharRace";
            this.cbCharRace.Size = new System.Drawing.Size(94, 29);
            this.cbCharRace.TabIndex = 10;
            // 
            // lblCharClass
            // 
            this.lblCharClass.AutoSize = true;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharClass, 3);
            this.lblCharClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharClass.Location = new System.Drawing.Point(26, 144);
            this.lblCharClass.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharClass.Name = "lblCharClass";
            this.lblCharClass.Size = new System.Drawing.Size(180, 36);
            this.lblCharClass.TabIndex = 12;
            this.lblCharClass.Text = "Class";
            this.lblCharClass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCharAlignment
            // 
            this.lblCharAlignment.AutoSize = true;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharAlignment, 3);
            this.lblCharAlignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharAlignment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharAlignment.Location = new System.Drawing.Point(146, 72);
            this.lblCharAlignment.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharAlignment.Name = "lblCharAlignment";
            this.lblCharAlignment.Size = new System.Drawing.Size(126, 36);
            this.lblCharAlignment.TabIndex = 3;
            this.lblCharAlignment.Text = "Alignment";
            this.lblCharAlignment.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbCharAlignment
            // 
            this.tlpBasicInfo.SetColumnSpan(this.cbCharAlignment, 3);
            this.cbCharAlignment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharAlignment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCharAlignment.FormattingEnabled = true;
            this.cbCharAlignment.Location = new System.Drawing.Point(149, 111);
            this.cbCharAlignment.Name = "cbCharAlignment";
            this.cbCharAlignment.Size = new System.Drawing.Size(120, 29);
            this.cbCharAlignment.TabIndex = 8;
            // 
            // lblCharBirthplace
            // 
            this.lblCharBirthplace.AutoSize = true;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharBirthplace, 3);
            this.lblCharBirthplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharBirthplace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharBirthplace.Location = new System.Drawing.Point(226, 144);
            this.lblCharBirthplace.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharBirthplace.Name = "lblCharBirthplace";
            this.lblCharBirthplace.Size = new System.Drawing.Size(112, 36);
            this.lblCharBirthplace.TabIndex = 13;
            this.lblCharBirthplace.Text = "Birthplace";
            this.lblCharBirthplace.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbCharClass
            // 
            this.tlpBasicInfo.SetColumnSpan(this.cbCharClass, 3);
            this.cbCharClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCharClass.FormattingEnabled = true;
            this.cbCharClass.Location = new System.Drawing.Point(29, 183);
            this.cbCharClass.Name = "cbCharClass";
            this.cbCharClass.Size = new System.Drawing.Size(174, 29);
            this.cbCharClass.TabIndex = 14;
            // 
            // cbCharBirthplace
            // 
            this.tlpBasicInfo.SetColumnSpan(this.cbCharBirthplace, 5);
            this.cbCharBirthplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharBirthplace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCharBirthplace.FormattingEnabled = true;
            this.cbCharBirthplace.Location = new System.Drawing.Point(229, 183);
            this.cbCharBirthplace.Name = "cbCharBirthplace";
            this.cbCharBirthplace.Size = new System.Drawing.Size(219, 29);
            this.cbCharBirthplace.TabIndex = 15;
            // 
            // lblCharReligion
            // 
            this.lblCharReligion.AutoSize = true;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharReligion, 3);
            this.lblCharReligion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharReligion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharReligion.Location = new System.Drawing.Point(26, 216);
            this.lblCharReligion.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharReligion.Name = "lblCharReligion";
            this.lblCharReligion.Size = new System.Drawing.Size(180, 36);
            this.lblCharReligion.TabIndex = 16;
            this.lblCharReligion.Text = "Religion";
            this.lblCharReligion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCharRealms
            // 
            this.lblCharRealms.AutoSize = true;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharRealms, 3);
            this.lblCharRealms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharRealms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharRealms.Location = new System.Drawing.Point(226, 216);
            this.lblCharRealms.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharRealms.Name = "lblCharRealms";
            this.lblCharRealms.Size = new System.Drawing.Size(112, 36);
            this.lblCharRealms.TabIndex = 17;
            this.lblCharRealms.Text = "Realms";
            this.lblCharRealms.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbCharReligion
            // 
            this.tlpBasicInfo.SetColumnSpan(this.cbCharReligion, 3);
            this.cbCharReligion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCharReligion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCharReligion.FormattingEnabled = true;
            this.cbCharReligion.Location = new System.Drawing.Point(29, 255);
            this.cbCharReligion.Name = "cbCharReligion";
            this.cbCharReligion.Size = new System.Drawing.Size(174, 29);
            this.cbCharReligion.TabIndex = 18;
            // 
            // lblCharRealmsList
            // 
            this.lblCharRealmsList.AutoSize = true;
            this.lblCharRealmsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpBasicInfo.SetColumnSpan(this.lblCharRealmsList, 5);
            this.lblCharRealmsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharRealmsList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharRealmsList.Location = new System.Drawing.Point(230, 256);
            this.lblCharRealmsList.Margin = new System.Windows.Forms.Padding(4);
            this.lblCharRealmsList.Name = "lblCharRealmsList";
            this.lblCharRealmsList.Size = new System.Drawing.Size(217, 28);
            this.lblCharRealmsList.TabIndex = 19;
            this.lblCharRealmsList.Text = "Life";
            this.lblCharRealmsList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharAvailableCCP
            // 
            this.lblCharAvailableCCP.AutoSize = true;
            this.lblCharAvailableCCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharAvailableCCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharAvailableCCP.Location = new System.Drawing.Point(500, 144);
            this.lblCharAvailableCCP.Name = "lblCharAvailableCCP";
            this.lblCharAvailableCCP.Size = new System.Drawing.Size(134, 36);
            this.lblCharAvailableCCP.TabIndex = 21;
            this.lblCharAvailableCCP.Text = "Available CCP";
            this.lblCharAvailableCCP.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCharCCP
            // 
            this.lblCharCCP.AutoSize = true;
            this.lblCharCCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCharCCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharCCP.Font = new System.Drawing.Font("Harrington", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCCP.Location = new System.Drawing.Point(505, 180);
            this.lblCharCCP.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblCharCCP.Name = "lblCharCCP";
            this.tlpBasicInfo.SetRowSpan(this.lblCharCCP, 3);
            this.lblCharCCP.Size = new System.Drawing.Size(132, 108);
            this.lblCharCCP.TabIndex = 22;
            this.lblCharCCP.Text = "375";
            this.lblCharCCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiscHypen
            // 
            this.lblMiscHypen.AutoSize = true;
            this.lblMiscHypen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMiscHypen.Location = new System.Drawing.Point(209, 252);
            this.lblMiscHypen.Name = "lblMiscHypen";
            this.lblMiscHypen.Size = new System.Drawing.Size(14, 36);
            this.lblMiscHypen.TabIndex = 23;
            this.lblMiscHypen.Text = "-";
            this.lblMiscHypen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbD02
            // 
            this.tlpBasicInfo.SetColumnSpan(this.pbD02, 11);
            this.pbD02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbD02.Image = global::MagusTools.Decals.DECAL_SideBarB;
            this.pbD02.Location = new System.Drawing.Point(26, 312);
            this.pbD02.Margin = new System.Windows.Forms.Padding(0);
            this.pbD02.Name = "pbD02";
            this.pbD02.Size = new System.Drawing.Size(611, 31);
            this.pbD02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbD02.TabIndex = 51;
            this.pbD02.TabStop = false;
            // 
            // lblOV01
            // 
            this.lblOV01.AutoSize = true;
            this.lblOV01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV01.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV01.Location = new System.Drawing.Point(146, 415);
            this.lblOV01.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV01.Name = "lblOV01";
            this.lblOV01.Size = new System.Drawing.Size(60, 36);
            this.lblOV01.TabIndex = 56;
            this.lblOV01.Text = "0";
            this.lblOV01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOV02
            // 
            this.lblOV02.AutoSize = true;
            this.lblOV02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV02.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV02.Location = new System.Drawing.Point(146, 451);
            this.lblOV02.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV02.Name = "lblOV02";
            this.lblOV02.Size = new System.Drawing.Size(60, 36);
            this.lblOV02.TabIndex = 58;
            this.lblOV02.Text = "0";
            this.lblOV02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharMP
            // 
            this.lblCharMP.AutoSize = true;
            this.lblCharMP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharMP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharMP.Location = new System.Drawing.Point(26, 487);
            this.lblCharMP.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharMP.Name = "lblCharMP";
            this.lblCharMP.Size = new System.Drawing.Size(107, 36);
            this.lblCharMP.TabIndex = 59;
            this.lblCharMP.Text = "Mana";
            this.lblCharMP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOV03
            // 
            this.lblOV03.AutoSize = true;
            this.lblOV03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV03.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV03.Location = new System.Drawing.Point(146, 487);
            this.lblOV03.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV03.Name = "lblOV03";
            this.lblOV03.Size = new System.Drawing.Size(60, 36);
            this.lblOV03.TabIndex = 60;
            this.lblOV03.Text = "0";
            this.lblOV03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharMPperLevel
            // 
            this.lblCharMPperLevel.AutoSize = true;
            this.lblCharMPperLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharMPperLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharMPperLevel.Location = new System.Drawing.Point(26, 523);
            this.lblCharMPperLevel.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharMPperLevel.Name = "lblCharMPperLevel";
            this.lblCharMPperLevel.Size = new System.Drawing.Size(107, 36);
            this.lblCharMPperLevel.TabIndex = 61;
            this.lblCharMPperLevel.Text = "Mana / Level";
            this.lblCharMPperLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOV04
            // 
            this.lblOV04.AutoSize = true;
            this.lblOV04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV04.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV04.Location = new System.Drawing.Point(146, 523);
            this.lblOV04.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV04.Name = "lblOV04";
            this.lblOV04.Size = new System.Drawing.Size(60, 36);
            this.lblOV04.TabIndex = 62;
            this.lblOV04.Text = "0";
            this.lblOV04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tlpBasicInfo.SetColumnSpan(this.tableLayoutPanel1, 5);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblCharDamagebonus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCharMMR, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOV00, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCharAMR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCharOtherStats, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(288, 382);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tlpBasicInfo.SetRowSpan(this.tableLayoutPanel1, 7);
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(346, 246);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // lblOV00
            // 
            this.lblOV00.AutoSize = true;
            this.lblOV00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOV00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOV00.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOV00.Location = new System.Drawing.Point(173, 30);
            this.lblOV00.Margin = new System.Windows.Forms.Padding(0);
            this.lblOV00.Name = "lblOV00";
            this.lblOV00.Size = new System.Drawing.Size(173, 30);
            this.lblOV00.TabIndex = 55;
            this.lblOV00.Text = "0";
            this.lblOV00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCharAMR
            // 
            this.lblCharAMR.AutoSize = true;
            this.lblCharAMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharAMR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharAMR.Location = new System.Drawing.Point(0, 30);
            this.lblCharAMR.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharAMR.Name = "lblCharAMR";
            this.lblCharAMR.Size = new System.Drawing.Size(173, 30);
            this.lblCharAMR.TabIndex = 54;
            this.lblCharAMR.Text = "AMR";
            this.lblCharAMR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharOtherStats
            // 
            this.lblCharOtherStats.AutoSize = true;
            this.lblCharOtherStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharOtherStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharOtherStats.Location = new System.Drawing.Point(0, 0);
            this.lblCharOtherStats.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharOtherStats.Name = "lblCharOtherStats";
            this.lblCharOtherStats.Size = new System.Drawing.Size(173, 30);
            this.lblCharOtherStats.TabIndex = 53;
            this.lblCharOtherStats.Text = "Other stats";
            this.lblCharOtherStats.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabBasicInfo);
            this.mainTabControl.Controls.Add(this.tabPrimaryAttributes);
            this.mainTabControl.Controls.Add(this.tabSecondaryAttributes);
            this.mainTabControl.Controls.Add(this.tabSkills);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(684, 716);
            this.mainTabControl.TabIndex = 0;
            // 
            // lblCharMMR
            // 
            this.lblCharMMR.AutoSize = true;
            this.lblCharMMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharMMR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharMMR.Location = new System.Drawing.Point(0, 60);
            this.lblCharMMR.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharMMR.Name = "lblCharMMR";
            this.lblCharMMR.Size = new System.Drawing.Size(173, 30);
            this.lblCharMMR.TabIndex = 57;
            this.lblCharMMR.Text = "MMR";
            this.lblCharMMR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharDamagebonus
            // 
            this.lblCharDamagebonus.AutoSize = true;
            this.lblCharDamagebonus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCharDamagebonus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCharDamagebonus.Location = new System.Drawing.Point(0, 90);
            this.lblCharDamagebonus.Margin = new System.Windows.Forms.Padding(0);
            this.lblCharDamagebonus.Name = "lblCharDamagebonus";
            this.lblCharDamagebonus.Size = new System.Drawing.Size(173, 30);
            this.lblCharDamagebonus.TabIndex = 58;
            this.lblCharDamagebonus.Text = "Damagebonus";
            this.lblCharDamagebonus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 762);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "MagusTools Karakterszerkesztő";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.tabSkills.ResumeLayout(false);
            this.tlpSkills.ResumeLayout(false);
            this.tlpSkills.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSelectedSkills)).EndInit();
            this.tabSecondaryAttributes.ResumeLayout(false);
            this.tlpSecondaryAttributesOld.ResumeLayout(false);
            this.tlpSecondaryAttributesOld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updM03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updM02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updM01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updM00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB10)).EndInit();
            this.tabPrimaryAttributes.ResumeLayout(false);
            this.tlpPrimaryAttributesOld.ResumeLayout(false);
            this.tlpPrimaryAttributesOld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updB00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updB04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbM00)).EndInit();
            this.tabBasicInfo.ResumeLayout(false);
            this.tlpBasicInfo.ResumeLayout(false);
            this.tlpBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCharLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updCharAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbD02)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator mnuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mnuOptionsSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuCharacter;
        private System.Windows.Forms.ToolStripMenuItem mnuCharacterExportAsText;
        private System.Windows.Forms.ToolStripMenuItem mnuCharacterGenerate;
        private System.Windows.Forms.ToolStripMenuItem mnuOptionsTools;
        private System.Windows.Forms.ToolStripMenuItem mnuOptionsToolsDiceroller;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpViewhelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuOptionsLanguage;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel stlblFileName;
        private System.Windows.Forms.TabPage tabSkills;
        private System.Windows.Forms.TableLayoutPanel tlpSkills;
        private System.Windows.Forms.Button btSkillsExpand;
        private System.Windows.Forms.Button btSkillExpandAll;
        private System.Windows.Forms.Label lblSK01;
        private System.Windows.Forms.TreeView twSkillTree;
        private System.Windows.Forms.Label lblAD00;
        private System.Windows.Forms.Label lblAD01;
        private System.Windows.Forms.Label lblSK00;
        private System.Windows.Forms.DataGridView dgSelectedSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Button btSkillsCollapse;
        private System.Windows.Forms.TabPage tabSecondaryAttributes;
        private System.Windows.Forms.TableLayoutPanel tlpSecondaryAttributesOld;
        private System.Windows.Forms.Label lblCMT03;
        private System.Windows.Forms.Label lblCMT02;
        private System.Windows.Forms.Label lblCMT01;
        private System.Windows.Forms.Label lblCMT00;
        private NumericUpDownExt updM03;
        private NumericUpDownExt updB13;
        private NumericUpDownExt updM02;
        private NumericUpDownExt updB12;
        private NumericUpDownExt updM01;
        private NumericUpDownExt updB11;
        private NumericUpDownExt updM00;
        private System.Windows.Forms.Label lblCT16;
        private System.Windows.Forms.Label lblCT19;
        private System.Windows.Forms.Label lblCT18;
        private System.Windows.Forms.Label lblCT17;
        private System.Windows.Forms.Label lblCT15;
        private System.Windows.Forms.Label lblCT14;
        private System.Windows.Forms.Label lblCT13;
        private System.Windows.Forms.Label lblCT12;
        private System.Windows.Forms.Label lblCT11;
        private System.Windows.Forms.Label lblCT10;
        private System.Windows.Forms.PictureBox pbD01;
        private System.Windows.Forms.Label lblMCV01;
        private System.Windows.Forms.Label lblMCV02;
        private System.Windows.Forms.Label lblMCT02;
        private System.Windows.Forms.Label lblAV18;
        private System.Windows.Forms.Label lblCV18;
        private System.Windows.Forms.Label lblAV19;
        private System.Windows.Forms.Label lblCV19;
        private System.Windows.Forms.Label lblAV15;
        private System.Windows.Forms.Label lblCV15;
        private System.Windows.Forms.Label lblAV16;
        private System.Windows.Forms.Label lblCV16;
        private System.Windows.Forms.Label lblAV17;
        private System.Windows.Forms.Label lblCV17;
        private System.Windows.Forms.Label lblAV14;
        private System.Windows.Forms.Label lblCV14;
        private System.Windows.Forms.Label lblAV13;
        private System.Windows.Forms.Label lblCV13;
        private System.Windows.Forms.Label lblAV12;
        private System.Windows.Forms.Label lblCV12;
        private System.Windows.Forms.Label lblAT16;
        private System.Windows.Forms.Label lblAT11;
        private System.Windows.Forms.Label lblAV11;
        private System.Windows.Forms.Label lblCV11;
        private System.Windows.Forms.Label lblCV10;
        private System.Windows.Forms.Label lblAT17;
        private System.Windows.Forms.Label lblAT18;
        private System.Windows.Forms.Label lblAT19;
        private System.Windows.Forms.Label lblAT15;
        private System.Windows.Forms.Label lblAT14;
        private System.Windows.Forms.Label lblAT12;
        private System.Windows.Forms.Label lblAT13;
        private NumericUpDownExt updB19;
        private NumericUpDownExt updB18;
        private NumericUpDownExt updB16;
        private NumericUpDownExt updB15;
        private NumericUpDownExt updB17;
        private NumericUpDownExt updB14;
        private System.Windows.Forms.PictureBox pbM19;
        private System.Windows.Forms.PictureBox pbM18;
        private System.Windows.Forms.PictureBox pbM16;
        private System.Windows.Forms.PictureBox pbM17;
        private System.Windows.Forms.PictureBox pbM15;
        private System.Windows.Forms.PictureBox pbM14;
        private System.Windows.Forms.PictureBox pbM13;
        private System.Windows.Forms.PictureBox pbM12;
        private System.Windows.Forms.PictureBox pbM11;
        private System.Windows.Forms.Label lblMAT19;
        private System.Windows.Forms.Label lblMAT18;
        private System.Windows.Forms.Label lblMAT17;
        private System.Windows.Forms.Label lblMAT16;
        private System.Windows.Forms.Label lblMAT15;
        private System.Windows.Forms.Label lblMCT01;
        private System.Windows.Forms.Label lblMAT14;
        private System.Windows.Forms.Label lblMAT13;
        private System.Windows.Forms.Label lblMAT12;
        private System.Windows.Forms.Label lblMAT11;
        private System.Windows.Forms.Label lblMAT10;
        private System.Windows.Forms.Label lblAT10;
        private System.Windows.Forms.PictureBox pbM10;
        private NumericUpDownExt updB10;
        private System.Windows.Forms.Label lblAV10;
        private System.Windows.Forms.TabPage tabPrimaryAttributes;
        private System.Windows.Forms.TableLayoutPanel tlpPrimaryAttributesOld;
        private NumericUpDownExt updB00;
        private NumericUpDownExt updB01;
        private NumericUpDownExt updB02;
        private NumericUpDownExt updB03;
        private System.Windows.Forms.Label lblCT06;
        private System.Windows.Forms.Label lblCT09;
        private System.Windows.Forms.Label lblCT08;
        private System.Windows.Forms.Label lblCT07;
        private System.Windows.Forms.Label lblCT05;
        private System.Windows.Forms.Label lblCT04;
        private System.Windows.Forms.Label lblCT03;
        private System.Windows.Forms.Label lblCT02;
        private System.Windows.Forms.Label lblCT01;
        private System.Windows.Forms.Label lblCT00;
        private System.Windows.Forms.PictureBox pbD00;
        private System.Windows.Forms.Label lblMSV00;
        private System.Windows.Forms.Label lblMCV00;
        private System.Windows.Forms.Label lblMCT00;
        private System.Windows.Forms.Label lblAV08;
        private System.Windows.Forms.Label lblCV08;
        private System.Windows.Forms.Label lblAV09;
        private System.Windows.Forms.Label lblCV09;
        private System.Windows.Forms.Label lblAV05;
        private System.Windows.Forms.Label lblCV05;
        private System.Windows.Forms.Label lblAV06;
        private System.Windows.Forms.Label lblCV06;
        private System.Windows.Forms.Label lblAV07;
        private System.Windows.Forms.Label lblCV07;
        private System.Windows.Forms.Label lblAV04;
        private System.Windows.Forms.Label lblCV04;
        private System.Windows.Forms.Label lblAV03;
        private System.Windows.Forms.Label lblCV03;
        private System.Windows.Forms.Label lblAV02;
        private System.Windows.Forms.Label lblCV02;
        private System.Windows.Forms.Label lblAT06;
        private System.Windows.Forms.Label lblAT01;
        private System.Windows.Forms.Label lblAV01;
        private System.Windows.Forms.Label lblCV01;
        private System.Windows.Forms.Label lblCV00;
        private System.Windows.Forms.Label lblAT07;
        private System.Windows.Forms.Label lblAT08;
        private System.Windows.Forms.Label lblAT09;
        private System.Windows.Forms.Label lblAT05;
        private System.Windows.Forms.Label lblAT04;
        private System.Windows.Forms.Label lblAT02;
        private System.Windows.Forms.Label lblAT03;
        private NumericUpDownExt updB09;
        private NumericUpDownExt updB08;
        private NumericUpDownExt updB06;
        private NumericUpDownExt updB05;
        private NumericUpDownExt updB07;
        private NumericUpDownExt updB04;
        private System.Windows.Forms.PictureBox pbM09;
        private System.Windows.Forms.PictureBox pbM08;
        private System.Windows.Forms.PictureBox pbM06;
        private System.Windows.Forms.PictureBox pbM07;
        private System.Windows.Forms.PictureBox pbM05;
        private System.Windows.Forms.PictureBox pbM04;
        private System.Windows.Forms.PictureBox pbM03;
        private System.Windows.Forms.PictureBox pbM02;
        private System.Windows.Forms.PictureBox pbM01;
        private System.Windows.Forms.Label lblMAT09;
        private System.Windows.Forms.Label lblMAT08;
        private System.Windows.Forms.Label lblMAT07;
        private System.Windows.Forms.Label lblMAT06;
        private System.Windows.Forms.Label lblMAT05;
        private System.Windows.Forms.Label lblMST00;
        private System.Windows.Forms.Label lblMAT04;
        private System.Windows.Forms.Label lblMAT03;
        private System.Windows.Forms.Label lblMAT02;
        private System.Windows.Forms.Label lblMAT01;
        private System.Windows.Forms.Label lblMAT00;
        private System.Windows.Forms.Label lblAT00;
        private System.Windows.Forms.PictureBox pbM00;
        private System.Windows.Forms.Label lblAV00;
        private System.Windows.Forms.TabPage tabBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tlpBasicInfo;
        private NumericUpDownExt updCharLevel;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox txtCharName;
        private System.Windows.Forms.Label lblCharGender;
        private System.Windows.Forms.Label lblCharAge;
        private System.Windows.Forms.Label lblCharRace;
        private System.Windows.Forms.Label lblCharLevel;
        private System.Windows.Forms.ComboBox cbCharGender;
        private NumericUpDownExt updCharAge;
        private System.Windows.Forms.ComboBox cbCharRace;
        private System.Windows.Forms.Label lblCharClass;
        private System.Windows.Forms.Label lblCharAlignment;
        private System.Windows.Forms.ComboBox cbCharAlignment;
        private System.Windows.Forms.Label lblCharBirthplace;
        private System.Windows.Forms.ComboBox cbCharClass;
        private System.Windows.Forms.ComboBox cbCharBirthplace;
        private System.Windows.Forms.Label lblCharReligion;
        private System.Windows.Forms.Label lblCharRealms;
        private System.Windows.Forms.ComboBox cbCharReligion;
        private System.Windows.Forms.Label lblCharRealmsList;
        private System.Windows.Forms.Label lblCharAvailableCCP;
        private System.Windows.Forms.Label lblCharCCP;
        private System.Windows.Forms.Label lblMiscHypen;
        private System.Windows.Forms.PictureBox pbD02;
        private System.Windows.Forms.Label lblOV01;
        private System.Windows.Forms.Label lblOV02;
        private System.Windows.Forms.Label lblCharMP;
        private System.Windows.Forms.Label lblOV03;
        private System.Windows.Forms.Label lblCharMPperLevel;
        private System.Windows.Forms.Label lblOV04;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.Label lblCharPSYperLevel;
        private System.Windows.Forms.Label lblCharPsy;
        private System.Windows.Forms.Label lblOV05;
        private System.Windows.Forms.Label lblOV06;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblOV00;
        private System.Windows.Forms.Label lblCharAMR;
        private System.Windows.Forms.Label lblCharOtherStats;
        private System.Windows.Forms.Label lblCharDamagebonus;
        private System.Windows.Forms.Label lblCharMMR;
    }
}

