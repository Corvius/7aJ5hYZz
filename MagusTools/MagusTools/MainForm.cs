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
        private Dictionary<NumericUpDownExt, ControlIDTag> updControls = new Dictionary<NumericUpDownExt, ControlIDTag>();
        private Dictionary<Label, ControlIDTag> lblControls = new Dictionary<Label, ControlIDTag>();

        // Main character object
        public Character character;

        // MainForm's Constructor
        public mainForm()
        {
            // Auto-generated code.
            InitializeComponent();
        }

        // When the form first loads, prepare all controls
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Set up elements of the UI
            PrepareUI();

            // Set the initial language.
            ChangeLanguage("hu-HU");

            // Refresh all strings with the selected language.
            LoadLocalizedStrings();

            character = new Character();

            // Debug
            MTDebug.FillTreeView(twSkillTree, 15, 3);
            MTDebug.FillDataGrid(dgSelectedSkills);

            //Program.logger = new LogWindow.LogWindow(this);
            //Program.logger.Show();
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
                //
                // Tab PrimaryAttributes & Tab SecondaryAttributes - Dictionary controls
                //
                foreach (var entry in lblControls)
                {
                    ControlIDTag tag = entry.Value;
                    switch (tag.m_Description)
                    {
                        case ControlIDTag.TagDescription.Main:
                            {
                                string tabName = tag.m_OwnerTab.Name.Replace("tab", "");
                                ((Label)entry.Key).Text = Properties.Resources.ResourceManager.GetString("ATTR_" + tabName + "_" + tag.m_Name);
                            }
                            break;
                        case ControlIDTag.TagDescription.Text:
                            switch (tag.m_Name)
                            {
                                case "Actual":
                                    ((Label)entry.Key).Text = Properties.Resources.MISC_Text_Actual;
                                    break;

                                case "Ccp":
                                    ((Label)entry.Key).Text = Properties.Resources.MISC_Text_CCP;
                                    break;

                                case "AddedCM":
                                    ((Label)entry.Key).Text = Properties.Resources.MISC_SecondaryAttributes_Text_SpentCM;
                                    break;

                                case "SpentCcp":
                                    ((Label)entry.Key).Text = Properties.Resources.MISC_Text_TotalSpentCCPOnTab;
                                    break;

                                case "StatAverage":
                                    ((Label)entry.Key).Text = Properties.Resources.MISC_Text_AbilityAverage;
                                    break;

                                case "Remaining":
                                    ((Label)entry.Key).Text = Properties.Resources.MISC_Text_Remaining;
                                    break;
                            }
                            break;
                        default:
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
            updControls.Add(this.updB00, new ControlIDTag("Strength", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 0));
            updControls.Add(this.updB01, new ControlIDTag("Speed", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 1));
            updControls.Add(this.updB02, new ControlIDTag("Agility", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 2));
            updControls.Add(this.updB03, new ControlIDTag("Endurance", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 3));
            updControls.Add(this.updB04, new ControlIDTag("Health", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 4));
            updControls.Add(this.updB05, new ControlIDTag("Charisma", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 5));
            updControls.Add(this.updB06, new ControlIDTag("Intelligence", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 6));
            updControls.Add(this.updB07, new ControlIDTag("Willpower", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 7));
            updControls.Add(this.updB08, new ControlIDTag("Astral", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 8));
            updControls.Add(this.updB09, new ControlIDTag("Perception", ControlIDTag.TagDescription.BaseTypeE, mainTabControl.TabPages[1], 9));

            updControls.Add(this.updB10, new ControlIDTag("Initiative", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 0));
            updControls.Add(this.updB11, new ControlIDTag("Attack", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 1));
            updControls.Add(this.updB12, new ControlIDTag("Defense", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 2));
            updControls.Add(this.updB13, new ControlIDTag("Aim", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 3));
            updControls.Add(this.updB14, new ControlIDTag("CMperLevel", ControlIDTag.TagDescription.BaseTypeB, mainTabControl.TabPages[2], 4));
            updControls.Add(this.updB15, new ControlIDTag("HP", ControlIDTag.TagDescription.BaseTypeC, mainTabControl.TabPages[2], 5));
            updControls.Add(this.updB16, new ControlIDTag("PR", ControlIDTag.TagDescription.BaseTypeC, mainTabControl.TabPages[2], 6));
            updControls.Add(this.updB17, new ControlIDTag("PRperLevel", ControlIDTag.TagDescription.BaseTypeB, mainTabControl.TabPages[2], 7));
            updControls.Add(this.updB18, new ControlIDTag("KP", ControlIDTag.TagDescription.BaseTypeB, mainTabControl.TabPages[2], 8));
            updControls.Add(this.updB19, new ControlIDTag("KPperLevel", ControlIDTag.TagDescription.BaseTypeB, mainTabControl.TabPages[2], 9));

            updControls.Add(this.updM00, new ControlIDTag("InitiativeCM", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 0));
            updControls.Add(this.updM01, new ControlIDTag("AttackCM", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 1));
            updControls.Add(this.updM02, new ControlIDTag("DefenseCM", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 2));
            updControls.Add(this.updM03, new ControlIDTag("AimCM", ControlIDTag.TagDescription.BaseTypeA, mainTabControl.TabPages[2], 3));

            updControls.Add(this.updCharLevel, new ControlIDTag("CharLevel", ControlIDTag.TagDescription.BaseTypeC, mainTabControl.TabPages[0], 0));
            updControls.Add(this.updCharAge, new ControlIDTag("CharAge", ControlIDTag.TagDescription.BaseTypeD, mainTabControl.TabPages[0], 0));
            #endregion

            #region Setup NumericUpDownExt Properties
            foreach (var entry in updControls)
            {
                ControlIDTag tag = entry.Value;
                NumericUpDownExt upd = entry.Key;

                switch (tag.m_Description)
                {
                    case ControlIDTag.TagDescription.BaseTypeA:
                        {
                            upd.Maximum = 100;
                            upd.Minimum = 0;
                            upd.Value = 0;
                        }
                        break;
                    case ControlIDTag.TagDescription.BaseTypeB:
                        {
                            upd.Maximum = 20;
                            upd.Minimum = 0;
                            upd.Value = 0;
                        }
                        break;
                    case ControlIDTag.TagDescription.BaseTypeC:
                        {
                            upd.Maximum = 20;
                            upd.Minimum = 1;
                            upd.Value = 1;
                        }
                        break;
                    case ControlIDTag.TagDescription.BaseTypeD:
                        {
                            upd.Maximum = 30;
                            upd.Minimum = 16;
                            upd.Value = 18;
                        }
                        break;
                    case ControlIDTag.TagDescription.BaseTypeE:
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
            #region Add Labels to Dictionary
            lblControls.Add(this.lblMAT00, new ControlIDTag("Strength", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblMAT01, new ControlIDTag("Speed", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 1));
            lblControls.Add(this.lblMAT02, new ControlIDTag("Agility", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 2));
            lblControls.Add(this.lblMAT03, new ControlIDTag("Endurance", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 3));
            lblControls.Add(this.lblMAT04, new ControlIDTag("Health", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 4));
            lblControls.Add(this.lblMAT05, new ControlIDTag("Charisma", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 5));
            lblControls.Add(this.lblMAT06, new ControlIDTag("Intelligence", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 6));
            lblControls.Add(this.lblMAT07, new ControlIDTag("Willpower", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 7));
            lblControls.Add(this.lblMAT08, new ControlIDTag("Astral", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 8));
            lblControls.Add(this.lblMAT09, new ControlIDTag("Perception", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[1], 9));

            lblControls.Add(this.lblMAT10, new ControlIDTag("Initiative", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 0));
            lblControls.Add(this.lblMAT11, new ControlIDTag("Attack", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblMAT12, new ControlIDTag("Defense", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblMAT13, new ControlIDTag("Aim", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 3));
            lblControls.Add(this.lblMAT14, new ControlIDTag("CMperLevel", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 4));
            lblControls.Add(this.lblMAT15, new ControlIDTag("HP", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 5));
            lblControls.Add(this.lblMAT16, new ControlIDTag("PR", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 6));
            lblControls.Add(this.lblMAT17, new ControlIDTag("PRperLevel", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 7));
            lblControls.Add(this.lblMAT18, new ControlIDTag("KP", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 8));
            lblControls.Add(this.lblMAT19, new ControlIDTag("KPperLevel", ControlIDTag.TagDescription.Main, mainTabControl.TabPages[2], 9));

            lblControls.Add(this.lblAV00, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblAV01, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 1));
            lblControls.Add(this.lblAV02, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 2));
            lblControls.Add(this.lblAV03, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 3));
            lblControls.Add(this.lblAV04, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 4));
            lblControls.Add(this.lblAV05, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 5));
            lblControls.Add(this.lblAV06, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 6));
            lblControls.Add(this.lblAV07, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 7));
            lblControls.Add(this.lblAV08, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 8));
            lblControls.Add(this.lblAV09, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 9));

            lblControls.Add(this.lblAV10, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 0));
            lblControls.Add(this.lblAV11, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblAV12, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblAV13, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 3));
            lblControls.Add(this.lblAV14, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 4));
            lblControls.Add(this.lblAV15, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 5));
            lblControls.Add(this.lblAV16, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 6));
            lblControls.Add(this.lblAV17, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 7));
            lblControls.Add(this.lblAV18, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 8));
            lblControls.Add(this.lblAV19, new ControlIDTag("Actual", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 9));

            lblControls.Add(this.lblCV00, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblCV01, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 1));
            lblControls.Add(this.lblCV02, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 2));
            lblControls.Add(this.lblCV03, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 3));
            lblControls.Add(this.lblCV04, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 4));
            lblControls.Add(this.lblCV05, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 5));
            lblControls.Add(this.lblCV06, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 6));
            lblControls.Add(this.lblCV07, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 7));
            lblControls.Add(this.lblCV08, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 8));
            lblControls.Add(this.lblCV09, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 9));

            lblControls.Add(this.lblCV10, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 0));
            lblControls.Add(this.lblCV11, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblCV12, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblCV13, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 3));
            lblControls.Add(this.lblCV14, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 4));
            lblControls.Add(this.lblCV15, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 5));
            lblControls.Add(this.lblCV16, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 6));
            lblControls.Add(this.lblCV17, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 7));
            lblControls.Add(this.lblCV18, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 8));
            lblControls.Add(this.lblCV19, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 9));

            lblControls.Add(this.lblAT00, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblAT01, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 1));
            lblControls.Add(this.lblAT02, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 2));
            lblControls.Add(this.lblAT03, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 3));
            lblControls.Add(this.lblAT04, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 4));
            lblControls.Add(this.lblAT05, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 5));
            lblControls.Add(this.lblAT06, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 6));
            lblControls.Add(this.lblAT07, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 7));
            lblControls.Add(this.lblAT08, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 8));
            lblControls.Add(this.lblAT09, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 9));

            lblControls.Add(this.lblAT10, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 0));
            lblControls.Add(this.lblAT11, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblAT12, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblAT13, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 3));
            lblControls.Add(this.lblAT14, new ControlIDTag("Remaining", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 4));
            lblControls.Add(this.lblAT15, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 5));
            lblControls.Add(this.lblAT16, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 6));
            lblControls.Add(this.lblAT17, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 7));
            lblControls.Add(this.lblAT18, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 8));
            lblControls.Add(this.lblAT19, new ControlIDTag("Actual", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 9));

            lblControls.Add(this.lblCT00, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblCT01, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 1));
            lblControls.Add(this.lblCT02, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 2));
            lblControls.Add(this.lblCT03, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 3));
            lblControls.Add(this.lblCT04, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 4));
            lblControls.Add(this.lblCT05, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 5));
            lblControls.Add(this.lblCT06, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 6));
            lblControls.Add(this.lblCT07, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 7));
            lblControls.Add(this.lblCT08, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 8));
            lblControls.Add(this.lblCT09, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 9));

            lblControls.Add(this.lblCT10, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 0));
            lblControls.Add(this.lblCT11, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblCT12, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblCT13, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 3));
            lblControls.Add(this.lblCT14, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 4));
            lblControls.Add(this.lblCT15, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 5));
            lblControls.Add(this.lblCT16, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 6));
            lblControls.Add(this.lblCT17, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 7));
            lblControls.Add(this.lblCT18, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 8));
            lblControls.Add(this.lblCT19, new ControlIDTag("Ccp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 9));

            lblControls.Add(this.lblCMT00, new ControlIDTag("AddedCM", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 0));
            lblControls.Add(this.lblCMT01, new ControlIDTag("AddedCM", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblCMT02, new ControlIDTag("AddedCM", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblCMT03, new ControlIDTag("AddedCM", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 3));

            lblControls.Add(this.lblMCT00, new ControlIDTag("SpentCcp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblMCT01, new ControlIDTag("SpentCcp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblMCT02, new ControlIDTag("SpentCcp", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblMST00, new ControlIDTag("StatAverage", ControlIDTag.TagDescription.Text, mainTabControl.TabPages[1], 3));

            lblControls.Add(this.lblMCV00, new ControlIDTag("SpentCcp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 0));
            lblControls.Add(this.lblMCV01, new ControlIDTag("SpentCcp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 1));
            lblControls.Add(this.lblMCV02, new ControlIDTag("SpentCcp", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[2], 2));
            lblControls.Add(this.lblMSV00, new ControlIDTag("StatAverage", ControlIDTag.TagDescription.Value, mainTabControl.TabPages[1], 3));

            #endregion

            // Event Handlers
            #region Assign Event Handlers
            foreach (var upd in updControls)
            {
                ((NumericUpDownExt)upd.Key).ValueChanged += userEvent_UpDownChanged;
            }

            cbCharRace.SelectionChangeCommitted += userEvent_ComboBoxChanged;
            cbCharClass.SelectionChangeCommitted += userEvent_ComboBoxChanged;

            #endregion
        }

        /// <summary>
        /// Custom struct to better identify controls stored in a Dictionary
        /// </summary>
        private struct ControlIDTag
        {
            // BaseTypeA - Refers to NumericUpDowns that have min = 0, max = 100, value = 0
            // BaseTypeB - Refers to NumericUpDowns that have min = 0, max = 20, value = 0
            // BaseTypeC - Refers to NumericUpDowns that have min = 1, max = 20, value = 1
            // BaseTypeD - Refers to NumericUpDowns that have min = 16, max = 30, value = 16
            // BaseTypeE - Refers to NumericUpDowns that have min = 3, max = 20, value = 12
            // Main - Refers to Labels that display attributes names
            // Text - Refers to Labels that display information about Value type Labels
            // Value - Refers to Labels that display the value property of an attribute
            public enum TagDescription { BaseTypeA, BaseTypeB, BaseTypeC, BaseTypeD, BaseTypeE, Main, Text, Value }

            public TabPage m_OwnerTab { get; }
            public string m_Name { get; }
            public TagDescription m_Description { get; }
            public int m_OrderValue { get; }

            /// <summary>
            /// Stores additional info of a dictionary object
            /// </summary>
            /// <param name="p_name">The name of the object</param>
            /// <param name="p_description">Description tag of the object</param>
            /// <param name="p_owner">Owning TabPage control</param>
            /// <param name="p_orderValue">The closer this value to 0 is, the closer the object gets to the start of the list when sorting</param>
            public ControlIDTag(string p_name, TagDescription p_description, TabPage p_owner, int p_orderValue)
            {
                this.m_Name = p_name;
                this.m_Description = p_description;
                this.m_OwnerTab = p_owner;
                this.m_OrderValue = p_orderValue;
            }
        }

        /// <summary>
        /// This is necessary for the Dictionary class to work with the ControlIDTag class
        /// </summary>
        private class ControlIDTagEqualityComparer : IEqualityComparer<ControlIDTag>
        {
            public bool Equals(ControlIDTag p_first, ControlIDTag p_second)
            {
                return 
                    (
                        (p_first.m_Name == p_second.m_Name) && 
                        (p_first.m_Description == p_second.m_Description) &&
                        (p_first.m_OwnerTab == p_second.m_OwnerTab) &&
                        (p_first.m_OrderValue == p_second.m_OrderValue)
                    );
            }

            public int GetHashCode(ControlIDTag p_tag)
            {
                string combined = p_tag.m_Name + "|" + p_tag.m_Description.ToString() + "|" + p_tag.m_OrderValue.ToString();
                return (combined.GetHashCode());
            }
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

        #region NumericUpDown Eventhandlers
        public void userEvent_UpDownChanged(object sender, EventArgs e)
        {
            ControlIDTag cidt = new ControlIDTag();
            NumericUpDownExt upd = (NumericUpDownExt)sender;

            try
            {
                updControls.TryGetValue(upd, out cidt);
                Program.logger.Log(new object[] { Color.Blue, cidt.m_Name, Color.Black, " has changed it's value to ", Color.Cyan, upd.Value.ToString() });
            }
            catch (Exception ex)
            {
                Program.logger.Log(new object[] { Color.Orange, cidt.m_Name, Color.Black, " has thrown the following error:\n", Color.IndianRed, ex.Message });
            }
        }

        public void userEvent_ComboBoxChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            Program.logger.Log(new object[] { Color.Blue, cb.Name, Color.Black, " has changed it's value to ", Color.Cyan, cb.SelectedItem.ToString() });
        }
        #endregion

        // DEBUG CONTROLS
        private void debug_comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLanguage((string)debug_comboBox7.SelectedItem);
            LoadLocalizedStrings();
        }
    }
}