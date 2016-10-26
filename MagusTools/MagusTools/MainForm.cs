using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MagusTools
{
    public partial class MainForm : Form
    {
        // These Lists are used to quickly access the identical labels
        // And change their text when localization changes.

        // A list of labels that have the text 'Actual'
        private List<Label> listLabelActual = new List<Label>();
        // A list of labels that have the text 'Base'
        private List<Label> listLabelBase = new List<Label>();
        // A list of labels that have the text 'CCP' - Characer Customization Points
        private List<Label> listLabelCCP = new List<Label>();
        
        // A list of updowns that are used to control the characters aspects with a custom identifier class
        private class UpDownID
        {
            private NumericUpDown _updown;
            private string _name;

            public UpDownID(NumericUpDown updown, string name)
            {
                this._updown = updown;
                this._name = name;
            }
        }
        private List<UpDownID> listNumUpDown = new List<UpDownID>();

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
            ChangeLanguage("en");

            // Refresh all strings with the selected language.
            LoadLocalizedStrings();

            // Do some debugging on the XML file
//            XMLChecker.Check();
        }

        /// <summary>
        /// This method changes the current culture settings, and loading
        /// a different language resource file for the program.
        /// </summary>
        /// <param name="cultureName">Specifies the new culture's shortened name. ex.: 'en' for english</param>
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
        /// This method updates all stings to the proper language version.
        /// </summary>
        private void LoadLocalizedStrings()
        {
            try
                {
                // Title
                this.Text = Properties.Resources.TITLE;
                // Menu items - File Menu
                this.mnuFile.Text = Properties.Resources.MM_File;
                this.mnuFileNew.Text = Properties.Resources.MM_File_New;
                this.mnuFileNewNPC.Text = Properties.Resources.MM_File_New_NPC;
                this.mnuFileNewPC.Text = Properties.Resources.MM_File_New_PC;
                this.mnuFileOpen.Text = Properties.Resources.MM_File_Open;
                this.mnuFileSave.Text = Properties.Resources.MM_File_Save;
                this.mnuFileSaveAs.Text = Properties.Resources.MM_File_SaveAs;
                this.mnuFileQuit.Text = Properties.Resources.MM_File_Quit;
                this.mnuFile.Text = Properties.Resources.MM_File;
                this.mnuFile.Text = Properties.Resources.MM_File;
                this.mnuFile.Text = Properties.Resources.MM_File;
                // Menu items - Character Menu
                this.mnuCharacter.Text = Properties.Resources.MM_Character;
                this.mnuCharacterExportAsText.Text = Properties.Resources.MM_Character_ExportAsText;
                this.mnuCharacterGenerate.Text = Properties.Resources.MM_Character_Generate;
                // Menu items - Options Menu
                this.mnuOptions.Text = Properties.Resources.MM_Options;
                this.mnuOptionsSettings.Text = Properties.Resources.MM_Options_Settings;
                this.mnuOptionsLanguage.Text = Properties.Resources.MM_Options_Language;
                this.mnuOptionsTools.Text = Properties.Resources.MM_Options_Tools;
                this.mnuOptionsToolsDiceroller.Text = Properties.Resources.MM_Options_Tools_Diceroller;
                // Menu items - Help Menu
                this.mnuHelp.Text = Properties.Resources.MM_Help;
                this.mnuHelpViewhelp.Text = Properties.Resources.MM_Help_ViewHelp;
                this.mnuHelpAbout.Text = Properties.Resources.MM_Help_About;
                // Tabs
                this.tabBasicInfo.Text = Properties.Resources.TAB_BasicInfo;
                this.tabPrimaryAttributes.Text = Properties.Resources.TAB_PrimaryAttributes;
                this.tabSecondaryAttributes.Text = Properties.Resources.TAB_SecondaryAttributes;
                this.tabSkills.Text = Properties.Resources.TAB_Skills;
                this.tabArmory.Text = Properties.Resources.TAB_Armory;
                this.tabEquipment.Text = Properties.Resources.TAB_Equipment;
                this.tabSummary.Text = Properties.Resources.TAB_Summary;
                // Attributes
                this.lblStrength.Text = Properties.Resources.ATTR_Strength;
                this.lblSpeed.Text = Properties.Resources.ATTR_Speed;
                this.lblAgility.Text = Properties.Resources.ATTR_Agility;
                this.lblEndurance.Text = Properties.Resources.ATTR_Endurance;
                this.lblHealth.Text = Properties.Resources.ATTR_Health;
                this.lblCharisma.Text = Properties.Resources.ATTR_Charisma;
                this.lblIntelligence.Text = Properties.Resources.ATTR_Intelligence;
                this.lblWillpower.Text = Properties.Resources.ATTR_Willpower;
                this.lblAstral.Text = Properties.Resources.ATTR_Astral;
                this.lblPerception.Text = Properties.Resources.ATTR_Perception;
                // Misc labels
                this.lblMiscPrimaryAverage.Text = Properties.Resources.MISC_Text_AbilityAverage;
                foreach (var lblItem in this.listLabelActual)
                {
                    lblItem.Text = Properties.Resources.MISC_Text_Actual;
                }
                foreach (var lblItem in this.listLabelBase)
                {
                    lblItem.Text = Properties.Resources.MISC_Text_Base;
                }
                foreach (var lblItem in this.listLabelCCP)
                {
                    lblItem.Text = Properties.Resources.MISC_Text_CCP;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to load localized strings from resource. " + ex.Message);
                throw;
            }
        }

        /// <summary>
        /// This method prepares the list variables and adds the dynamically created controls to them to help with localization.
        /// </summary>
        private void PrepareUI()
        {
            // Fill the Options - Language menu with the available languages
            //mnuOptionsLanguage.

            
            // Ensure all 'Actual' labels are in the list.
            //
            // TODO: Figure out a way to add them using less lines of code
            listLabelActual.Add(lblMiscActual00);
            listLabelActual.Add(lblMiscActual01);
            listLabelActual.Add(lblMiscActual02);
            listLabelActual.Add(lblMiscActual03);
            listLabelActual.Add(lblMiscActual04);
            listLabelActual.Add(lblMiscActual05);
            listLabelActual.Add(lblMiscActual06);
            listLabelActual.Add(lblMiscActual07);
            listLabelActual.Add(lblMiscActual08);
            listLabelActual.Add(lblMiscActual09);

            // Ensure all 'Base' labels are in the list.

            // Ensure all 'CCP' labels are in the list.

            // Ensure all NumericUpDown controls are in the list.
            listNumUpDown.Add(new UpDownID(updBaseStrength, Stats.statNames[0]));
            listNumUpDown.Add(new UpDownID(updBaseSpeed, Stats.statNames[1]));
            listNumUpDown.Add(new UpDownID(updBaseAgility, Stats.statNames[2]));
            listNumUpDown.Add(new UpDownID(updBaseEndurance, Stats.statNames[3]));
            listNumUpDown.Add(new UpDownID(updBaseHealth, Stats.statNames[4]));
            listNumUpDown.Add(new UpDownID(updBaseCharisma, Stats.statNames[5]));
            listNumUpDown.Add(new UpDownID(updBaseIntelligence, Stats.statNames[6]));
            listNumUpDown.Add(new UpDownID(updBaseWillpower, Stats.statNames[7]));
            listNumUpDown.Add(new UpDownID(updBaseAstral, Stats.statNames[8]));
            listNumUpDown.Add(new UpDownID(updBasePerception, Stats.statNames[9]));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 5 + (Szint - 1) * 4 ( Mesterfokú pszí )

        }
    }
}
