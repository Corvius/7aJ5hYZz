using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Windows;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MagusTools
{
    public partial class mainForm : Form
    {
        // Control dictionaries
        private Dictionary<NumericUpDownExt, string> updControls = new Dictionary<NumericUpDownExt, string>();
        private Dictionary<string, Label> textLabels = new Dictionary<string, Label>();
        private Dictionary<string, Label> valueLabels = new Dictionary<string, Label>();

        // Main character object
        public Character character;

        // Main skill-handling object
        public XMLHandler skillHandler;

        // MainForm's Constructor
        public mainForm()
        {
            // Auto-generated code.
            InitializeComponent();
        }

        // When the form first loads, prepare all controls
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Initailize objects
            character = new Character();
            skillHandler = new XMLHandler();

            // Set up elements of the UI
            PrepareUI();

            // Set the initial language.
            ChangeLanguage("hu-HU");

            // Refresh all strings with the selected language.
            LoadLocalizedStrings();
        }

        /// <summary>
        /// This method changes the current culture settings, and loading
        /// a different language resource file for the program.
        /// </summary>
        /// <param name="cultureName">Specifies the new culture's shortened name. ex.: 'en-EN' for english</param>
        private void ChangeLanguage(string cultureName)
        {
            try
            {
                // Get the new culture or generate an exception of it doesn't exist.
                CultureInfo newCulture = new CultureInfo(cultureName);

                // If everything's fine, set the new culture.
                Thread.CurrentThread.CurrentCulture = newCulture;
                Thread.CurrentThread.CurrentUICulture = newCulture;
            }
            catch (CultureNotFoundException e)
            {
                Console.WriteLine("Unable to instantiate culture {0}", e.InvalidCultureName);
            }
        }

        /// <summary>
        /// This method updates all strings to the proper language version.
        /// </summary>
        private void LoadLocalizedStrings()
        {
            try
            {
                //
                // Title
                //
                this.Text = Properties.Resources.TITLE;
                //
                // Menu items - File Menu
                //
                this.mnuFile.Text = Properties.Resources.MM_File;
                this.mnuFileNew.Text = Properties.Resources.MM_File_New;
                this.mnuFileOpen.Text = Properties.Resources.MM_File_Open;
                this.mnuFileSave.Text = Properties.Resources.MM_File_Save;
                this.mnuFileSaveAs.Text = Properties.Resources.MM_File_SaveAs;
                this.mnuFileQuit.Text = Properties.Resources.MM_File_Quit;
                this.mnuFile.Text = Properties.Resources.MM_File;
                this.mnuFile.Text = Properties.Resources.MM_File;
                this.mnuFile.Text = Properties.Resources.MM_File;
                //
                // Menu items - Character Menu
                //
                this.mnuCharacter.Text = Properties.Resources.MM_Character;
                this.mnuCharacterExportAsText.Text = Properties.Resources.MM_Character_ExportAsText;
                this.mnuCharacterGenerate.Text = Properties.Resources.MM_Character_Generate;
                //
                // Menu items - Options Menu
                //
                this.mnuOptions.Text = Properties.Resources.MM_Options;
                this.mnuOptionsSettings.Text = Properties.Resources.MM_Options_Specials;
                this.mnuOptionsLanguage.Text = Properties.Resources.MM_Options_Language;
                this.mnuOptionsTools.Text = Properties.Resources.MM_Options_Tools;
                this.mnuOptionsToolsDiceroller.Text = Properties.Resources.MM_Options_Tools_Diceroller;
                //
                // Menu items - Help Menu
                //
                this.mnuHelp.Text = Properties.Resources.MM_Help;
                this.mnuHelpViewhelp.Text = Properties.Resources.MM_Help_ViewHelp;
                this.mnuHelpAbout.Text = Properties.Resources.MM_Help_About;
                //
                // Tabs
                //
                this.tabBasicInfo.Text = Properties.Resources.TAB_BasicInfo;
                this.tabPrimaryAttributes.Text = Properties.Resources.TAB_PrimaryAttributes;
                this.tabSecondaryAttributes.Text = Properties.Resources.TAB_SecondaryAttributes;
                this.tabSkills.Text = Properties.Resources.TAB_Skills;
                //this.tabArmory.Text = Properties.Resources.TAB_Armory;
                //this.tabEquipment.Text = Properties.Resources.TAB_Equipment;
                //
                // Tab BasicInfo - Labels
                //
                this.lblCharName.Text = Properties.Resources.TAB_BasicInfo_CharNameLabel;
                this.lblCharGender.Text = Properties.Resources.TAB_BasicInfo_CharGenderLabel;
                this.lblCharAlignment.Text = Properties.Resources.TAB_BasicInfo_CharAlignmentLabel;
                this.lblCharAge.Text = Properties.Resources.TAB_BasicInfo_CharAgeLabel;
                this.lblCharRace.Text = Properties.Resources.TAB_BasicInfo_CharRaceLabel;
                this.lblCharLevel.Text = Properties.Resources.TAB_BasicInfo_CharLevelLabel;
                this.lblCharClass.Text = Properties.Resources.TAB_BasicInfo_CharClassLabel;
                this.lblCharBirthplace.Text = Properties.Resources.TAB_BasicInfo_CharBirthplaceLabel;
                this.lblCharReligion.Text = Properties.Resources.TAB_BasicInfo_CharReligionLabel;
                this.lblCharRealms.Text = Properties.Resources.TAB_BasicInfo_CharRealmsLabel;
                this.lblCharAvailableCCP.Text = Properties.Resources.TAB_BasicInfo_AvailableCCPLabel;
                this.lblCharOtherStats.Text = Properties.Resources.TAB_BasicInfo_OtherStatsLabel;
                this.lblCharAMR.Text = Properties.Resources.TAB_BasicInfo_AMRLabel;
                this.lblCharMMR.Text = Properties.Resources.TAB_BasicInfo_MMRLabel;
                this.lblCharDamagebonus.Text = Properties.Resources.TAB_BasicInfo_DamageBonusLabel;
                this.lblCharMP.Text = Properties.Resources.TAB_BasicInfo_MPLabel;
                this.lblCharMPperLevel.Text = Properties.Resources.TAB_BasicInfo_MPperLevelLabel;
                this.lblCharPsy.Text = Properties.Resources.TAB_BasicInfo_PSYLabel;
                this.lblCharPSYperLevel.Text = Properties.Resources.TAB_BasicInfo_PSYperLevelLabel;
                //
                // Tab PrimaryAttributes & Tab SecondaryAttributes - Dictionary controls
                //
                foreach (var entry in textLabels)
                {
                    string name = System.Text.RegularExpressions.Regex.Replace(entry.Key, @"\d.", "");

                    switch (name)
                    {
                        case "Actual":
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_Actual;
                            break;

                        case "Ccp":
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_CCP;
                            break;

                        case "AddedCM":
                            ((Label)entry.Value).Text = Properties.Resources.MISC_SecondaryAttributes_Text_SpentCM;
                            break;

                        case "SpentCcp":
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_TotalSpentCCPOnTab;
                            break;

                        case "StatAverage":
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_AbilityAverage;
                            break;

                        case "Remaining":
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_Remaining;
                            break;

                        default:
                            string labelName = "ATTR_" + name;
                            ((Label)entry.Value).Text = Properties.Resources.ResourceManager.GetString(labelName);
                            break;
                    }
                }
                //
                // Tab Skills
                //
                this.lblSK00.Text = Properties.Resources.TAB_Skills_AvailableSkillsLabel;
                this.lblSK00.Text = Properties.Resources.TAB_Skills_SelectedSkillsLabel;
                this.lblAD00.Text = Properties.Resources.TAB_Skills_Hint_A;
                this.lblAD01.Text = Properties.Resources.TAB_Skills_Hint_B;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to load localized strings from resource. " + ex.Message);
                throw;
            }
        }

        /// <summary>
        /// This method prepares the list variables and adds existing controls to them to help with localization and management.
        /// </summary>
        private void PrepareUI()
        {
            // NumericUpDownExts
            #region Add NumericUpDownExts to Dictionary
            updControls.Add(this.updB00, "Strength_BaseTypeE");
            updControls.Add(this.updB01, "Speed_BaseTypeE");
            updControls.Add(this.updB02, "Agility_BaseTypeE");
            updControls.Add(this.updB03, "Endurance_BaseTypeE");
            updControls.Add(this.updB04, "Health_BaseTypeE");
            updControls.Add(this.updB05, "Charisma_BaseTypeE");
            updControls.Add(this.updB06, "Intelligence_BaseTypeE");
            updControls.Add(this.updB07, "Willpower_BaseTypeE");
            updControls.Add(this.updB08, "Astral_BaseTypeE");
            updControls.Add(this.updB09, "Perception_BaseTypeE");

            updControls.Add(this.updB10, "Initiative_BaseTypeA");
            updControls.Add(this.updB11, "Attack_BaseTypeA");
            updControls.Add(this.updB12, "Defense_BaseTypeA");
            updControls.Add(this.updB13, "Aim_BaseTypeA");
            updControls.Add(this.updB14, "CMperLevel_BaseTypeB");
            updControls.Add(this.updB15, "HP_BaseTypeC");
            updControls.Add(this.updB16, "PR_BaseTypeC");
            updControls.Add(this.updB17, "PRperLevel_BaseTypeB");
            updControls.Add(this.updB18, "KP_BaseTypeB");
            updControls.Add(this.updB19, "KPperLevel_BaseTypeB");

            updControls.Add(this.updM00, "InitiativeCM_BaseTypeA");
            updControls.Add(this.updM01, "AttackCM_BaseTypeA");
            updControls.Add(this.updM02, "DefenseCM_BaseTypeA");
            updControls.Add(this.updM03, "AimCM_BaseTypeA");

            updControls.Add(this.updCharLevel, "CharLevel_BaseTypeC");
            updControls.Add(this.updCharAge, "CharAge_BaseTypeD");
            #endregion

            #region Setup NumericUpDownExt Properties
            foreach (var entry in updControls)
            {
                string updType = System.Text.RegularExpressions.Regex.Replace(entry.Value, @"^.*?(?=_)_", "");
                NumericUpDownExt upd = entry.Key;

                switch (updType)
                {
                    case "BaseTypeA":
                        {
                            upd.Maximum = 100;
                            upd.Minimum = 0;
                            upd.Value = 0;
                        }
                        break;
                    case "BaseTypeB":
                        {
                            upd.Maximum = 20;
                            upd.Minimum = 0;
                            upd.Value = 0;
                        }
                        break;
                    case "BaseTypeC":
                        {
                            upd.Maximum = 20;
                            upd.Minimum = 1;
                            upd.Value = 1;
                        }
                        break;
                    case "BaseTypeD":
                        {
                            upd.Maximum = 30;
                            upd.Minimum = 16;
                            upd.Value = 18;
                        }
                        break;
                    case "BaseTypeE":
                    default:
                        {
                            upd.Maximum = 20;
                            upd.Minimum = 3;
                            upd.Value = 12;
                        }
                        break;
                }
            }
            #endregion

            // Labels
            #region Add Text Labels to Dictionary
            textLabels.Add("Strength", this.lblMAT00);
            textLabels.Add("Speed", this.lblMAT01);
            textLabels.Add("Agility", this.lblMAT02);
            textLabels.Add("Endurance", this.lblMAT03);
            textLabels.Add("Health", this.lblMAT04);
            textLabels.Add("Charisma", this.lblMAT05);
            textLabels.Add("Intelligence", this.lblMAT06);
            textLabels.Add("Willpower", this.lblMAT07);
            textLabels.Add("Astral", this.lblMAT08);
            textLabels.Add("Perception", this.lblMAT09);

            textLabels.Add("Initiative", this.lblMAT10);
            textLabels.Add("Attack", this.lblMAT11);
            textLabels.Add("Defense", this.lblMAT12);
            textLabels.Add("Aim", this.lblMAT13);
            textLabels.Add("CMperLevel", this.lblMAT14);
            textLabels.Add("HP", this.lblMAT15);
            textLabels.Add("PR", this.lblMAT16);
            textLabels.Add("PRperLevel", this.lblMAT17);
            textLabels.Add("KP", this.lblMAT18);
            textLabels.Add("KPperLevel", this.lblMAT19);

            textLabels.Add("Actual00", this.lblAT00);
            textLabels.Add("Actual01", this.lblAT01);
            textLabels.Add("Actual02", this.lblAT02);
            textLabels.Add("Actual03", this.lblAT03);
            textLabels.Add("Actual04", this.lblAT04);
            textLabels.Add("Actual05", this.lblAT05);
            textLabels.Add("Actual06", this.lblAT06);
            textLabels.Add("Actual07", this.lblAT07);
            textLabels.Add("Actual08", this.lblAT08);
            textLabels.Add("Actual09", this.lblAT09);

            textLabels.Add("Actual10", this.lblAT10);
            textLabels.Add("Actual11", this.lblAT11);
            textLabels.Add("Actual12", this.lblAT12);
            textLabels.Add("Actual13", this.lblAT13);
            textLabels.Add("Remaining", this.lblAT14);
            textLabels.Add("Actual14", this.lblAT15);
            textLabels.Add("Actual15", this.lblAT16);
            textLabels.Add("Actual16", this.lblAT17);
            textLabels.Add("Actual17", this.lblAT18);
            textLabels.Add("Actual18", this.lblAT19);

            textLabels.Add("Ccp00", this.lblCT00);
            textLabels.Add("Ccp01", this.lblCT01);
            textLabels.Add("Ccp02", this.lblCT02);
            textLabels.Add("Ccp03", this.lblCT03);
            textLabels.Add("Ccp04", this.lblCT04);
            textLabels.Add("Ccp05", this.lblCT05);
            textLabels.Add("Ccp06", this.lblCT06);
            textLabels.Add("Ccp07", this.lblCT07);
            textLabels.Add("Ccp08", this.lblCT08);
            textLabels.Add("Ccp09", this.lblCT09);

            textLabels.Add("Ccp10", this.lblCT10);
            textLabels.Add("Ccp11", this.lblCT11);
            textLabels.Add("Ccp12", this.lblCT12);
            textLabels.Add("Ccp13", this.lblCT13);
            textLabels.Add("Ccp14", this.lblCT14);
            textLabels.Add("Ccp15", this.lblCT15);
            textLabels.Add("Ccp16", this.lblCT16);
            textLabels.Add("Ccp17", this.lblCT17);
            textLabels.Add("Ccp18", this.lblCT18);
            textLabels.Add("Ccp19", this.lblCT19);

            textLabels.Add("AddedCM00", this.lblCMT00);
            textLabels.Add("AddedCM01", this.lblCMT01);
            textLabels.Add("AddedCM02", this.lblCMT02);
            textLabels.Add("AddedCM03", this.lblCMT03);

            textLabels.Add("SpentCcp00", this.lblMCT00);
            textLabels.Add("SpentCcp01", this.lblMCT01);
            textLabels.Add("SpentCcp02", this.lblMCT02);
            textLabels.Add("StatAverage", this.lblMST00);
            #endregion

            #region Add Value Labels to Dictionary
            valueLabels.Add("StrengthActual", this.lblAV00);
            valueLabels.Add("SpeedActual", this.lblAV01);
            valueLabels.Add("AgilityActual", this.lblAV02);
            valueLabels.Add("EnduranceActual", this.lblAV03);
            valueLabels.Add("HealthActual", this.lblAV04);
            valueLabels.Add("CharismaActual", this.lblAV05);
            valueLabels.Add("IntelligenceActual", this.lblAV06);
            valueLabels.Add("WillpowerActual", this.lblAV07);
            valueLabels.Add("AstralActual", this.lblAV08);
            valueLabels.Add("PerceptionActual", this.lblAV09);

            valueLabels.Add("InitiativeActual", this.lblAV10);
            valueLabels.Add("AttackActual", this.lblAV11);
            valueLabels.Add("DefenseActual", this.lblAV12);
            valueLabels.Add("AimActual", this.lblAV13);
            valueLabels.Add("CMperLevelActual", this.lblAV14);
            valueLabels.Add("HPActual", this.lblAV15);
            valueLabels.Add("PRActual", this.lblAV16);
            valueLabels.Add("PRperLevelActual", this.lblAV17);
            valueLabels.Add("KPActual", this.lblAV18);
            valueLabels.Add("KPperLevelActual", this.lblAV19);

            valueLabels.Add("StrengthCcp", this.lblCV00);
            valueLabels.Add("SpeedCcp", this.lblCV01);
            valueLabels.Add("AgilityCcp", this.lblCV02);
            valueLabels.Add("EnduranceCcp", this.lblCV03);
            valueLabels.Add("HealthCcp", this.lblCV04);
            valueLabels.Add("CharismaCcp", this.lblCV05);
            valueLabels.Add("IntelligenceCcp", this.lblCV06);
            valueLabels.Add("WillpowerCcp", this.lblCV07);
            valueLabels.Add("AstralCcp", this.lblCV08);
            valueLabels.Add("PerceptionCcp", this.lblCV09);

            valueLabels.Add("InitiativeCcp", this.lblCV10);
            valueLabels.Add("AttackCcp", this.lblCV11);
            valueLabels.Add("DefenseCcp", this.lblCV12);
            valueLabels.Add("AimCcp", this.lblCV13);
            valueLabels.Add("CMperLevelCcp", this.lblCV14);
            valueLabels.Add("HPCcp", this.lblCV15);
            valueLabels.Add("PRCcp", this.lblCV16);
            valueLabels.Add("PRperLevelCcp", this.lblCV17);
            valueLabels.Add("KPCcp", this.lblCV18);
            valueLabels.Add("KPperLevelCcp", this.lblCV19);

            valueLabels.Add("SpentCcp00", this.lblMCV00);
            valueLabels.Add("SpentCcp01", this.lblMCV01);
            valueLabels.Add("SpentCcp02", this.lblMCV02);
            valueLabels.Add("StatAverage", this.lblMSV00);

            valueLabels.Add("AMR", this.lblOV00);
            valueLabels.Add("MMR", this.lblOV01);
            valueLabels.Add("DamageBonus", this.lblOV02);
            valueLabels.Add("Mana", this.lblOV03);
            valueLabels.Add("ManaPerLevel", this.lblOV04);
            valueLabels.Add("Psy", this.lblOV05);
            valueLabels.Add("PsyPerLevel", this.lblOV06);
            #endregion

            // Event handlers
            #region Attach NumericUpDownExt event handlers
            this.updB00.ValueChanged += updB00_ValueChanged;
            this.updB01.ValueChanged += updB01_ValueChanged;
            this.updB02.ValueChanged += updB02_ValueChanged;
            this.updB03.ValueChanged += updB03_ValueChanged;
            this.updB04.ValueChanged += updB04_ValueChanged;
            this.updB05.ValueChanged += updB05_ValueChanged;
            this.updB06.ValueChanged += updB06_ValueChanged;
            this.updB07.ValueChanged += updB07_ValueChanged;
            this.updB08.ValueChanged += updB08_ValueChanged;
            this.updB09.ValueChanged += updB09_ValueChanged;

            this.updB10.ValueChanged += updB10_ValueChanged;
            this.updB11.ValueChanged += updB11_ValueChanged;
            this.updB12.ValueChanged += updB12_ValueChanged;
            this.updB13.ValueChanged += updB13_ValueChanged;
            this.updB14.ValueChanged += updB14_ValueChanged;
            this.updB15.ValueChanged += updB15_ValueChanged;
            this.updB16.ValueChanged += updB16_ValueChanged;
            this.updB17.ValueChanged += updB17_ValueChanged;
            this.updB18.ValueChanged += updB18_ValueChanged;
            this.updB19.ValueChanged += updB19_ValueChanged;

            this.updM00.ValueChanged += updM00_ValueChanged;
            this.updM01.ValueChanged += updM01_ValueChanged;
            this.updM02.ValueChanged += updM02_ValueChanged;
            this.updM03.ValueChanged += updM03_ValueChanged;

            this.updCharLevel.ValueChanged += updCharLevel_ValueChanged;
            #endregion

            #region Fire Event handlers to set every value to default
            updB00_ValueChanged(updB00, new EventArgs());
            updB01_ValueChanged(updB01, new EventArgs());
            updB02_ValueChanged(updB02, new EventArgs());
            updB03_ValueChanged(updB03, new EventArgs());
            updB04_ValueChanged(updB04, new EventArgs());
            updB05_ValueChanged(updB05, new EventArgs());
            updB06_ValueChanged(updB06, new EventArgs());
            updB07_ValueChanged(updB07, new EventArgs());
            updB08_ValueChanged(updB08, new EventArgs());
            updB09_ValueChanged(updB09, new EventArgs());

            updB10_ValueChanged(updB10, new EventArgs());
            updB11_ValueChanged(updB11, new EventArgs());
            updB12_ValueChanged(updB12, new EventArgs());
            updB13_ValueChanged(updB13, new EventArgs());
            updB14_ValueChanged(updB14, new EventArgs());
            updB15_ValueChanged(updB15, new EventArgs());
            updB16_ValueChanged(updB16, new EventArgs());
            updB17_ValueChanged(updB17, new EventArgs());
            updB18_ValueChanged(updB18, new EventArgs());
            updB19_ValueChanged(updB19, new EventArgs());

            updM00_ValueChanged(updM00, new EventArgs());
            updM01_ValueChanged(updM01, new EventArgs());
            updM02_ValueChanged(updM02, new EventArgs());
            updM03_ValueChanged(updM03, new EventArgs());

            updCharLevel_ValueChanged(updCharLevel, new EventArgs());
            #endregion

            // SkillTree setup
            twSkillTree.Nodes.AddRange(skillHandler.GetSkillTree());
        }

        #region TreeView Control Buttons' Events
        private void btSkillsCollapse_Click(object sender, EventArgs e)
        {
            twSkillTree.CollapseAll();
        }

        private void btSkillsExpand_Click(object sender, EventArgs e)
        {
            twSkillTree.CollapseAll();

            foreach (TreeNode node in twSkillTree.Nodes)
            {
                node.Expand();
            }
        }

        private void btSkillExpandAll_Click(object sender, EventArgs e)
        {
            twSkillTree.ExpandAll();
        }
        #endregion

        #region TreeView's DragDrop Operations
        private void twSkillTree_ItemDrag(object sender, ItemDragEventArgs e)
        {
            this.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void dgSelectedSkills_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dgSelectedSkills_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                TreeNode draggedNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                DataGridView dragTarget = (DataGridView)sender;

                Console.WriteLine("Dragged " + draggedNode.Text + " to " + dragTarget.Name);
            }
        }
        #endregion

        private void updCharLevel_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Level, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["CMperLevelActual"]).Text = character.GetStat(Character.Stats.CMperLevel).ToString();
        }

        private void updB00_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Strength, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["StrengthActual"]).Text = character.GetStat(Character.Stats.Strength).ToString();
            ((Label)valueLabels["AttackActual"]).Text = character.GetStat(Character.Stats.Attack).ToString();
            ((Label)valueLabels["DamageBonus"]).Text = character.GetStat(Character.Stats.DamageBonus).ToString();
        }

        private void updB01_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Speed, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["SpeedActual"]).Text = character.GetStat(Character.Stats.Speed).ToString();
            ((Label)valueLabels["InitiativeActual"]).Text = character.GetStat(Character.Stats.Initiative).ToString();
            ((Label)valueLabels["AttackActual"]).Text = character.GetStat(Character.Stats.Attack).ToString();
            ((Label)valueLabels["DefenseActual"]).Text = character.GetStat(Character.Stats.Defense).ToString();
        }

        private void updB02_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Agility, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["AgilityActual"]).Text = character.GetStat(Character.Stats.Agility).ToString();
            ((Label)valueLabels["StrengthActual"]).Text = character.GetStat(Character.Stats.Strength).ToString();
            ((Label)valueLabels["AttackActual"]).Text = character.GetStat(Character.Stats.Attack).ToString();
            ((Label)valueLabels["DefenseActual"]).Text = character.GetStat(Character.Stats.DamageBonus).ToString();
        }

        private void updB03_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Endurance, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["EnduranceActual"]).Text = character.GetStat(Character.Stats.Endurance).ToString();
            ((Label)valueLabels["PRActual"]).Text = character.GetStat(Character.Stats.PR).ToString();
        }

        private void updB04_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Health, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["HealthActual"]).Text = character.GetStat(Character.Stats.Health).ToString();
            ((Label)valueLabels["HPActual"]).Text = character.GetStat(Character.Stats.HP).ToString();
        }

        private void updB05_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Charisma, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["CharismaActual"]).Text = character.GetStat(Character.Stats.Charisma).ToString();
        }

        private void updB06_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Intelligence, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["IntelligenceActual"]).Text = character.GetStat(Character.Stats.Intelligence).ToString();
            ((Label)valueLabels["Mana"]).Text = character.GetStat(Character.Stats.MP).ToString();
            ((Label)valueLabels["Psy"]).Text = character.GetStat(Character.Stats.Psy).ToString();
        }

        private void updB07_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Willpower, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["WillpowerActual"]).Text = character.GetStat(Character.Stats.Willpower).ToString();
            ((Label)valueLabels["PRActual"]).Text = character.GetStat(Character.Stats.PR).ToString();
            ((Label)valueLabels["MMR"]).Text = character.GetStat(Character.Stats.MMR).ToString();
        }

        private void updB08_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Astral, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["AstralActual"]).Text = character.GetStat(Character.Stats.Astral).ToString();
            ((Label)valueLabels["AMR"]).Text = character.GetStat(Character.Stats.AMR).ToString();
        }

        private void updB09_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Perception, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["PerceptionActual"]).Text = character.GetStat(Character.Stats.Perception).ToString();
        }

        private void updB10_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Initiative, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["InitiativeActual"]).Text = character.GetStat(Character.Stats.Initiative).ToString();
        }

        private void updB11_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Attack, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["AttackActual"]).Text = character.GetStat(Character.Stats.Attack).ToString();
        }

        private void updB12_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Defense, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["DefenseActual"]).Text = character.GetStat(Character.Stats.Defense).ToString();
        }

        private void updB13_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.Aim, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["AimActual"]).Text = character.GetStat(Character.Stats.Aim).ToString();
        }

        private void updB14_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.CMperLevel, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["CMperLevelActual"]).Text = character.GetStat(Character.Stats.CMperLevel).ToString();
        }

        private void updB15_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.HP, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["HPActual"]).Text = character.GetStat(Character.Stats.HP).ToString();
        }

        private void updB16_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.PR, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["PRActual"]).Text = character.GetStat(Character.Stats.PR).ToString();
        }

        private void updB17_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.PRperLevel, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["PRperLevelActual"]).Text = character.GetStat(Character.Stats.PRperLevel).ToString();
        }

        private void updB18_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.KP, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["KPActual"]).Text = character.GetStat(Character.Stats.KP).ToString();
        }

        private void updB19_ValueChanged(object sender, EventArgs e)
        {
            character.SetStat(Character.Stats.KPperLevel, (int)((NumericUpDownExt)sender).Value);

            ((Label)valueLabels["KPperLevelActual"]).Text = character.GetStat(Character.Stats.KPperLevel).ToString();
        }

        private void updM00_ValueChanged(object sender, EventArgs e)
        {
        }

        private void updM01_ValueChanged(object sender, EventArgs e)
        {
        }

        private void updM02_ValueChanged(object sender, EventArgs e)
        {
        }

        private void updM03_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}