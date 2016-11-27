using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MagusTools
{
    public partial class MainForm : Form
    {
        // Control dictionaries
        private Dictionary<ControlIDTag, NumericUpDown> updControls = new Dictionary<ControlIDTag, NumericUpDown>(new ControlIDTagEqualityComparer());
        private Dictionary<ControlIDTag, Label> lblControls = new Dictionary<ControlIDTag, Label>(new ControlIDTagEqualityComparer());

        // MainForm's Constructor
        public MainForm()
        {
            // Auto-generated code.
            InitializeComponent();

            // Initialize static lists.
            Stats.Initialize();

            // Set up elements of the UI
            PrepareUI();

            // Set the initial language.
            ChangeLanguage("hu-HU");

            // Refresh all strings with the selected language.
            LoadLocalizedStrings();

            // Do some debugging on the XML file
            //            XMLChecker.Check();
            
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
                this.lblCharCharacteristic.Text = Properties.Resources.TAB_BasicInfo_CharCharacteristicLabel;
                this.lblCharAge.Text = Properties.Resources.TAB_BasicInfo_CharAgeLabel;
                this.lblCharRace.Text = Properties.Resources.TAB_BasicInfo_CharRaceLabel;
                this.lblCharLevel.Text = Properties.Resources.TAB_BasicInfo_CharLevelLabel;
                this.lblCharClass.Text = Properties.Resources.TAB_BasicInfo_CharClassLabel;
                this.lblCharBirthplace.Text = Properties.Resources.TAB_BasicInfo_CharBirthplaceLabel;
                this.lblCharReligion.Text = Properties.Resources.TAB_BasicInfo_CharReligionLabel;
                this.lblCharRealms.Text = Properties.Resources.TAB_BasicInfo_CharRealmsLabel;
                this.lblCharAvailableCCP.Text = Properties.Resources.TAB_BasicInfo_AvailableCCPLabel;
                //
                // Tab PrimaryAttributes & Tab SecondaryAttributes - Dictionary controls
                //
                foreach (var entry in lblControls)
                {
                    ControlIDTag tag = entry.Key;
                    if (tag.Description == "Main")
                    {
                        string tabName = tag.OwnerTab.Name.Replace("tab", "");
                        ((Label)entry.Value).Text = Properties.Resources.ResourceManager.GetString("ATTR_" + tabName + "_" + tag.Name);
                    }

                    if (tag.Description == "Text")
                    {
                        if (tag.Name == "Actual")
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_Actual;

                        if (tag.Name == "Ccp")
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_CCP;

                        if (tag.Name == "AddedCM")
                            ((Label)entry.Value).Text = Properties.Resources.MISC_SecondaryAttributes_Text_SpentCM;

                        if (tag.Name == "SpentCcp")
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_TotalSpentCCPOnTab;

                        if (tag.Name == "StatAverage")
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_AbilityAverage;

                        if (tag.Name == "Remaining")
                            ((Label)entry.Value).Text = Properties.Resources.MISC_Text_Remaining;
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
            // NumericUpDowns
            #region Add NumericUpDowns to Dictionary
            updControls.Add(new ControlIDTag("Strength", "Base", mainTabControl.TabPages[1], 0), this.updB00);
            updControls.Add(new ControlIDTag("Speed", "Base", mainTabControl.TabPages[1], 1), this.updB01);
            updControls.Add(new ControlIDTag("Agility", "Base", mainTabControl.TabPages[1], 2), this.updB02);
            updControls.Add(new ControlIDTag("Endurance", "Base", mainTabControl.TabPages[1], 3), this.updB03);
            updControls.Add(new ControlIDTag("Health", "Base", mainTabControl.TabPages[1], 4), this.updB04);
            updControls.Add(new ControlIDTag("Charisma", "Base", mainTabControl.TabPages[1], 5), this.updB05);
            updControls.Add(new ControlIDTag("Intelligence", "Base", mainTabControl.TabPages[1], 6), this.updB06);
            updControls.Add(new ControlIDTag("Willpower", "Base", mainTabControl.TabPages[1], 7), this.updB07);
            updControls.Add(new ControlIDTag("Astral", "Base", mainTabControl.TabPages[1], 8), this.updB08);
            updControls.Add(new ControlIDTag("Perception", "Base", mainTabControl.TabPages[1], 9), this.updB09);

            updControls.Add(new ControlIDTag("Initiative", "Base", mainTabControl.TabPages[2], 0), this.updB10);
            updControls.Add(new ControlIDTag("Attack", "Base", mainTabControl.TabPages[2], 1), this.updB11);
            updControls.Add(new ControlIDTag("Defense", "Base", mainTabControl.TabPages[2], 2), this.updB12);
            updControls.Add(new ControlIDTag("Aim", "Base", mainTabControl.TabPages[2], 3), this.updB13);
            updControls.Add(new ControlIDTag("CMperLevel", "Base", mainTabControl.TabPages[2], 4), this.updB14);
            updControls.Add(new ControlIDTag("HP", "Base", mainTabControl.TabPages[2], 5), this.updB15);
            updControls.Add(new ControlIDTag("PR", "Base", mainTabControl.TabPages[2], 6), this.updB16);
            updControls.Add(new ControlIDTag("PRperLevel", "Base", mainTabControl.TabPages[2], 7), this.updB17);
            updControls.Add(new ControlIDTag("KP", "Base", mainTabControl.TabPages[2], 8), this.updB18);
            updControls.Add(new ControlIDTag("KPperLevel", "Base", mainTabControl.TabPages[2], 9), this.updB19);

            updControls.Add(new ControlIDTag("Initiative", "Mod", mainTabControl.TabPages[2], 0), this.updM00);
            updControls.Add(new ControlIDTag("Attack", "Mod", mainTabControl.TabPages[2], 1), this.updM01);
            updControls.Add(new ControlIDTag("Defense", "Mod", mainTabControl.TabPages[2], 2), this.updM02);
            updControls.Add(new ControlIDTag("Aim", "Mod", mainTabControl.TabPages[2], 3), this.updM03);

            updControls.Add(new ControlIDTag("CharLevel", "Base", mainTabControl.TabPages[0], 0), this.updCharLevel);
            updControls.Add(new ControlIDTag("CharAge", "Base", mainTabControl.TabPages[0], 0), this.updCharAge);
            #endregion

            #region Setup NumericUpDown Properties
            foreach (var entry in updControls)
            {
                ControlIDTag tag = entry.Key;
                NumericUpDown upd = entry.Value;

                upd.Increment = 1m / SystemInformation.MouseWheelScrollLines;

                if (tag.Name == "Initiative" || tag.Name == "Attack" || tag.Name == "Defense" || tag.Name == "Aim")
                {
                    upd.Maximum = 100;
                    upd.Minimum = 0;
                    upd.Value = 0;
                }
                else if (tag.Name == "CMperLevel" || tag.Name == "PRperLevel" || tag.Name == "KP" || tag.Name == "KPperLevel")
                {
                    upd.Maximum = 20;
                    upd.Minimum = 0;
                    upd.Value = 0;
                }
                else if (tag.Name == "HP" || tag.Name == "PR" || tag.Name == "CharLevel")
                {
                    upd.Maximum = 20;
                    upd.Minimum = 1;
                    upd.Value = 1;
                }
                else if (tag.Name == "CharAge")
                {
                    upd.Maximum = 30;
                    upd.Minimum = 16;
                    upd.Value = 18;
                }
                else
                {
                    upd.Maximum = 20;
                    upd.Minimum = 3;
                    upd.Value = 12;
                }
            }
            #endregion

            // Labels
            #region Add Labels to Dictionary
            lblControls.Add(new ControlIDTag("Strength", "Main", mainTabControl.TabPages[1], 0), this.lblMAT00);
            lblControls.Add(new ControlIDTag("Speed", "Main", mainTabControl.TabPages[1], 1), this.lblMAT01);
            lblControls.Add(new ControlIDTag("Agility", "Main", mainTabControl.TabPages[1], 2), this.lblMAT02);
            lblControls.Add(new ControlIDTag("Endurance", "Main", mainTabControl.TabPages[1], 3), this.lblMAT03);
            lblControls.Add(new ControlIDTag("Health", "Main", mainTabControl.TabPages[1], 4), this.lblMAT04);
            lblControls.Add(new ControlIDTag("Charisma", "Main", mainTabControl.TabPages[1], 5), this.lblMAT05);
            lblControls.Add(new ControlIDTag("Intelligence", "Main", mainTabControl.TabPages[1], 6), this.lblMAT06);
            lblControls.Add(new ControlIDTag("Willpower", "Main", mainTabControl.TabPages[1], 7), this.lblMAT07);
            lblControls.Add(new ControlIDTag("Astral", "Main", mainTabControl.TabPages[1], 8), this.lblMAT08);
            lblControls.Add(new ControlIDTag("Perception", "Main", mainTabControl.TabPages[1], 9), this.lblMAT09);

            lblControls.Add(new ControlIDTag("Initiative", "Main", mainTabControl.TabPages[2], 0), this.lblMAT10);
            lblControls.Add(new ControlIDTag("Attack", "Main", mainTabControl.TabPages[2], 1), this.lblMAT11);
            lblControls.Add(new ControlIDTag("Defense", "Main", mainTabControl.TabPages[2], 2), this.lblMAT12);
            lblControls.Add(new ControlIDTag("Aim", "Main", mainTabControl.TabPages[2], 3), this.lblMAT13);
            lblControls.Add(new ControlIDTag("CMperLevel", "Main", mainTabControl.TabPages[2], 4), this.lblMAT14);
            lblControls.Add(new ControlIDTag("HP", "Main", mainTabControl.TabPages[2], 5), this.lblMAT15);
            lblControls.Add(new ControlIDTag("PR", "Main", mainTabControl.TabPages[2], 6), this.lblMAT16);
            lblControls.Add(new ControlIDTag("PRperLevel", "Main", mainTabControl.TabPages[2], 7), this.lblMAT17);
            lblControls.Add(new ControlIDTag("KP", "Main", mainTabControl.TabPages[2], 8), this.lblMAT18);
            lblControls.Add(new ControlIDTag("KPperLevel", "Main", mainTabControl.TabPages[2], 9), this.lblMAT19);

            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 0), this.lblAV00);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 1), this.lblAV01);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 2), this.lblAV02);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 3), this.lblAV03);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 4), this.lblAV04);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 5), this.lblAV05);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 6), this.lblAV06);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 7), this.lblAV07);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 8), this.lblAV08);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[1], 9), this.lblAV09);

            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 0), this.lblAV10);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 1), this.lblAV11);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 2), this.lblAV12);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 3), this.lblAV13);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 4), this.lblAV14);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 5), this.lblAV15);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 6), this.lblAV16);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 7), this.lblAV17);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 8), this.lblAV18);
            lblControls.Add(new ControlIDTag("Actual", "Value", mainTabControl.TabPages[2], 9), this.lblAV19);

            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 0), this.lblCV00);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 1), this.lblCV01);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 2), this.lblCV02);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 3), this.lblCV03);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 4), this.lblCV04);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 5), this.lblCV05);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 6), this.lblCV06);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 7), this.lblCV07);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 8), this.lblCV08);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[1], 9), this.lblCV09);

            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 0), this.lblCV10);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 1), this.lblCV11);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 2), this.lblCV12);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 3), this.lblCV13);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 4), this.lblCV14);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 5), this.lblCV15);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 6), this.lblCV16);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 7), this.lblCV17);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 8), this.lblCV18);
            lblControls.Add(new ControlIDTag("Ccp", "Value", mainTabControl.TabPages[2], 9), this.lblCV19);

            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 0), this.lblAT00);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 1), this.lblAT01);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 2), this.lblAT02);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 3), this.lblAT03);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 4), this.lblAT04);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 5), this.lblAT05);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 6), this.lblAT06);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 7), this.lblAT07);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 8), this.lblAT08);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[1], 9), this.lblAT09);

            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 0), this.lblAT10);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 1), this.lblAT11);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 2), this.lblAT12);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 3), this.lblAT13);
            lblControls.Add(new ControlIDTag("Remaining", "Text", mainTabControl.TabPages[2], 4), this.lblAT14);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 5), this.lblAT15);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 6), this.lblAT16);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 7), this.lblAT17);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 8), this.lblAT18);
            lblControls.Add(new ControlIDTag("Actual", "Text", mainTabControl.TabPages[2], 9), this.lblAT19);

            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 0), this.lblCT00);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 1), this.lblCT01);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 2), this.lblCT02);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 3), this.lblCT03);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 4), this.lblCT04);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 5), this.lblCT05);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 6), this.lblCT06);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 7), this.lblCT07);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 8), this.lblCT08);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[1], 9), this.lblCT09);

            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 0), this.lblCT10);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 1), this.lblCT11);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 2), this.lblCT12);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 3), this.lblCT13);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 4), this.lblCT14);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 5), this.lblCT15);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 6), this.lblCT16);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 7), this.lblCT17);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 8), this.lblCT18);
            lblControls.Add(new ControlIDTag("Ccp", "Text", mainTabControl.TabPages[2], 9), this.lblCT19);

            lblControls.Add(new ControlIDTag("AddedCM", "Text", mainTabControl.TabPages[2], 0), this.lblCMT00);
            lblControls.Add(new ControlIDTag("AddedCM", "Text", mainTabControl.TabPages[2], 1), this.lblCMT01);
            lblControls.Add(new ControlIDTag("AddedCM", "Text", mainTabControl.TabPages[2], 2), this.lblCMT02);
            lblControls.Add(new ControlIDTag("AddedCM", "Text", mainTabControl.TabPages[2], 3), this.lblCMT03);

            lblControls.Add(new ControlIDTag("SpentCcp", "Text", mainTabControl.TabPages[1], 0), this.lblMCT00);
            lblControls.Add(new ControlIDTag("SpentCcp", "Text", mainTabControl.TabPages[2], 1), this.lblMCT01);
            lblControls.Add(new ControlIDTag("SpentCcp", "Text", mainTabControl.TabPages[2], 2), this.lblMCT02);
            lblControls.Add(new ControlIDTag("StatAverage", "Text", mainTabControl.TabPages[1], 3), this.lblMST00);

            lblControls.Add(new ControlIDTag("SpentCcp", "Value", mainTabControl.TabPages[1], 0), this.lblMCV00);
            lblControls.Add(new ControlIDTag("SpentCcp", "Value", mainTabControl.TabPages[2], 1), this.lblMCV01);
            lblControls.Add(new ControlIDTag("SpentCcp", "Value", mainTabControl.TabPages[2], 2), this.lblMCV02);
            lblControls.Add(new ControlIDTag("StatAverage", "Value", mainTabControl.TabPages[1], 3), this.lblMSV00);

            #endregion

        }

        /// <summary>
        /// Custom class to better identify controls stored in a Dictionary
        /// </summary>
        private class ControlIDTag
        {
            public TabPage OwnerTab { get; }
            public string Description { get; }
            public string Name { get; }
            public int OrderValue { get; }

            /// <summary>
            /// Stores additional info of a dictionary object
            /// </summary>
            /// <param name="name">The name of the object</param>
            /// <param name="description">Description tag of the object</param>
            /// <param name="owner">Owning TabPage control</param>
            /// <param name="orderValue">The closer this value to 0 is, the closer the object gets to the start of the list when sorting</param>
            public ControlIDTag(string name, string description, TabPage owner, int orderValue)
            {
                this.Name = name;
                this.Description = description;
                this.OwnerTab = owner;
                this.OrderValue = orderValue;
            }
        }

        /// <summary>
        /// This is necessary for the Dictionary class to work with the ControlIDTag class
        /// </summary>
        private class ControlIDTagEqualityComparer : IEqualityComparer<ControlIDTag>
        {
            public bool Equals(ControlIDTag first, ControlIDTag second)
            {
                return 
                    (
                        (first.Name == second.Name) && 
                        (first.Description == second.Description) &&
                        (first.OwnerTab == second.OwnerTab) &&
                        (first.OrderValue == second.OrderValue)
                    );
            }

            public int GetHashCode(ControlIDTag tag)
            {
                string combined = tag.Name + "|" + tag.Description.ToString() + "|" + tag.OrderValue.ToString();
                return (combined.GetHashCode());
            }
        }


        // DEBUG CONTROLS
        private void debug_comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeLanguage((string)debug_comboBox7.SelectedItem);
            LoadLocalizedStrings();
        }
    }
}