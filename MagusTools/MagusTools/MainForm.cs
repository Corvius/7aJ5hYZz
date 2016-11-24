﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
            ChangeLanguage("hu");

            // Refresh all strings with the selected language.
            LoadLocalizedStrings();

            // Do some debugging on the XML file
            //            XMLChecker.Check();

            // Do some debugging on the control generator
            Debug_FillTabs();
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
                this.mnuOptionsSettings.Text = Properties.Resources.MM_Options_Specials;
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
                //this.tabArmory.Text = Properties.Resources.TAB_Armory;
                //this.tabEquipment.Text = Properties.Resources.TAB_Equipment;
                this.tabSummary.Text = Properties.Resources.TAB_Summary;
                // Tab BasicInfo - Labels
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
                // Tab PrimaryAttributes - Attributes
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
                this.lblMiscPrimaryAvg.Text = Properties.Resources.MISC_Text_AbilityAverage;
                this.lblMiscCCPSpent.Text = Properties.Resources.MISC_PrimaryAttributes_SpentCCP;
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
            listLabelCCP.Add(lblMiscCCP00);
            listLabelCCP.Add(lblMiscCCP01);
            listLabelCCP.Add(lblMiscCCP02);
            listLabelCCP.Add(lblMiscCCP03);
            listLabelCCP.Add(lblMiscCCP04);
            listLabelCCP.Add(lblMiscCCP05);
            listLabelCCP.Add(lblMiscCCP06);
            listLabelCCP.Add(lblMiscCCP07);
            listLabelCCP.Add(lblMiscCCP08);
            listLabelCCP.Add(lblMiscCCP09);

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

        // Control dictionaries
        private Dictionary<string, NumericUpDown> updControls = new Dictionary<string, NumericUpDown>();
        private Dictionary<string, PictureBox> pbControls = new Dictionary<string, PictureBox>();
        private Dictionary<string, Label> lblControls = new Dictionary<string, Label>();

        private void Debug_FillTabs()
        {
            #region Primary Attributes' Tab setup            
            // Primary Attributes' Tab
            string[] controlNamesPA = { "Strength", "Speed", "Agility", "Endurance", "Health", "Charisma", "Intelligence", "Willpower", "Astral", "Perception" };
            string location = "tabPA";

            // Pictureboxes
            Debug_AddControls(controlNamesPA, location, "", typeof(PictureBox), 8, new Point(1, 3), new Size(1, 3));
            // Updown controls
            Debug_AddControls(controlNamesPA, location, "", typeof(NumericUpDown), 8, new Point(2, 3), new Size(2, 3));
            // 'Main' text labels
            Debug_AddControls(controlNamesPA, location, "Main", typeof(Label), 8, new Point(1, 1), new Size(3, 2));
            // 'Actual' text labels
            Debug_AddControls(controlNamesPA, location, "TextActual", typeof(Label), 8, new Point(5, 2), new Size(1, 1));
            // 'Ccp' text labels
            Debug_AddControls(controlNamesPA, location, "TextCcp", typeof(Label), 8, new Point(5, 6), new Size(1, 1));
            // 'Actual' value labels
            Debug_AddControls(controlNamesPA, location, "ValueActual", typeof(Label), 8, new Point(5, 3), new Size(1, 1));
            // 'Ccp' value labels
            Debug_AddControls(controlNamesPA, location, "ValueCcp", typeof(Label), 8, new Point(5, 5), new Size(1, 1));
            #endregion

            #region Secondary Attributes' Tab setup
            // Secondary Attributes' Tab
            string[] controlNamesSA = { "Initiative", "Attack", "Defence", "Aim", "CM", "HP", "PR", "PR / Level", "KP", "KP / Level" };
            #endregion

            #region Final Control Adjustments
            // Finally set all values on the controls
            foreach (PictureBox pb in pbControls.Values)
            {
                pb.Dock = DockStyle.Fill;
                pb.Margin = new Padding(0);
            }

            foreach (NumericUpDown upd in updControls.Values)
            {
                upd.Font = new Font("Harrington", 36, FontStyle.Regular);
                upd.Dock = DockStyle.Fill;
                upd.Margin = new Padding(8, 0, 0, 0);
                upd.TextAlign = HorizontalAlignment.Center;
                upd.Value = 12;
                upd.Maximum = 20;
                upd.Minimum = 3;
                upd.Increment = 1m / SystemInformation.MouseWheelScrollLines;
            }

            foreach (Label lbl in lblControls.Values)
            {
                if (lbl.Name.Contains("_Main_"))
                {
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                    lbl.Dock = DockStyle.Fill;
                    lbl.Margin = new Padding(0);
                    lbl.FlatStyle = FlatStyle.System;
                    lbl.TextAlign = ContentAlignment.MiddleLeft;
                    lbl.Text = lbl.Name.Substring(lbl.Name.LastIndexOf('_') + 1);
                }

                if (lbl.Name.Contains("_TextActual_") || lbl.Name.Contains("_TextCcp_"))
                {
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                    lbl.Dock = DockStyle.Fill;
                    lbl.Margin = new Padding(0);
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Text = (lbl.Name.Contains("_TextActual_")) ? Properties.Resources.MISC_Text_Actual : Properties.Resources.MISC_Text_CCP;
                }

                if (lbl.Name.Contains("_ValueActual_") || lbl.Name.Contains("_ValueCcp_"))
                {
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Harrington", 18, FontStyle.Regular);
                    lbl.Dock = DockStyle.Fill;
                    lbl.Margin = new Padding(3, 0, 3, 0);
                    lbl.BorderStyle = BorderStyle.Fixed3D;
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Text = "12";
                }
            }
            #endregion
        }

        #region Addcontrols
        /// <summary>
        /// Adds specified controls to the relevant dictionary
        /// </summary>
        /// <param name="controlNames">List of names for the controls</param>
        /// <param name="tabPageName">Name of the tab-page the control will be on</param>
        /// <param name="namePrefix">To uniquely distinguish a control from the rest of it's kind</param>
        /// <param name="control">The control object to be added</param>
        /// <param name="controlDist">Distance (in grid cells) between two controls of the same type</param>
        /// <param name="offset">Control's offset (in grid cells) from (0, 0)</param>
        /// <param name="span">How many cells does the control fill up (ColumnSpan = Width, RowSpan = Height)</param>
        void Debug_AddControls(string[] controlNames, string tabPageName, string namePrefix, Type controlType, int controlDist, Point offset, Size span)
        {
            // A controls's location on the layoutgrid
            Point ctrlPos = new Point(0, 0);

            // References
            int loopMid = controlNames.Length / 2;

            // Positioning loop
            for (int loopVar = 0; loopVar < controlNames.Length; loopVar++)
            {
                Control control;

                if (controlType == typeof(PictureBox))
                    control = new PictureBox();
                else if (controlType == typeof(NumericUpDown))
                    control = new NumericUpDown();
                else if (controlType == typeof(Label))
                    control = new Label();
                else
                {
                    throw new Exception("Unrecognizable control type! Cannot add to dictionary!");
                    //return;
                }

                // Base position for the Controls on the left
                if (loopVar < loopMid)
                {
                    ctrlPos.X = 0;
                    ctrlPos.Y = 0 + controlDist * loopVar;
                }
                // Base position for the Controls on the right
                else
                {
                    ctrlPos.X = 0 + controlDist;
                    ctrlPos.Y = 0 + controlDist * (loopVar - loopMid);
                }

                // Add and set position of the picturebox in the layout
                tlpDebug.Controls.Add(control, ctrlPos.X + offset.X, ctrlPos.Y + offset.Y);
                tlpDebug.SetRowSpan(control, span.Height);
                tlpDebug.SetColumnSpan(control, span.Width);

                // Add control to the correct dictionary
                if (control is NumericUpDown)
                {
                    control.Name = "upd_" + tabPageName + "_" + namePrefix + "_" + controlNames[loopVar];
                    updControls.Add(control.Name, (NumericUpDown)control);
                }
                else if (control is PictureBox)
                {
                    control.Name = "pb_" + tabPageName + "_" + namePrefix + "_" + controlNames[loopVar];
                    (control as PictureBox).Image = (Image)Icons.ResourceManager.GetObject("ICON_ATTR_" + controlNames[loopVar]);
                    pbControls.Add(control.Name, (PictureBox)control);
                }
                else if (control is Label)
                {
                    control.Name = "lbl_" + tabPageName + "_" + namePrefix + "_" + controlNames[loopVar];
                    lblControls.Add(control.Name, (Label)control);
                }
            }
        }
        #endregion

        void GRAVEYARD(string[] controlNames, int ctrlDist, string tabName)
        {
            int loopVar = 0;
            Point ctrlPos = new Point(0, 0);

            #region NumericUpDowns
            // Offset for 'base' NumericUpDowns
            Point updBaseOffset = new Point(2, 3);
            if (true)
            {
                // Offset for 'cm' NumericUpDowns
                Point updCmOffset = new Point(2, 5);
                // Set up the 'base' NumericUpDown
                NumericUpDown updCm = new NumericUpDown()
                {
                    Font = new Font("Harrington", 36, FontStyle.Regular),
                    Dock = DockStyle.Fill,
                    Margin = new Padding(8, 0, 0, 0),
                    TextAlign = HorizontalAlignment.Center,
                    Value = 12,
                    Maximum = 20,
                    Minimum = 3,
                    Increment = 1m / SystemInformation.MouseWheelScrollLines,
                    Name = "upd" + tabName + controlNames[loopVar],
                };
            }
            // Set up the 'base' NumericUpDown
            NumericUpDown updBase = new NumericUpDown()
            {
                Font = new Font("Harrington", 36, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Margin = new Padding(8, 0, 0, 0),
                TextAlign = HorizontalAlignment.Center,
                Value = 12,
                Maximum = 20,
                Minimum = 3,
                Increment = 1m / SystemInformation.MouseWheelScrollLines,
                Name = "upd" + tabName + controlNames[loopVar],
            };

            // Add and set position of the picturebox in the layout
            tlpDebug.Controls.Add(updBase, ctrlPos.X + updBaseOffset.X, ctrlPos.Y + updBaseOffset.Y);
            tlpDebug.SetRowSpan(updBase, 3);
            tlpDebug.SetColumnSpan(updBase, 2);

            // Add control to the dictionary
            updControls.Add(updBase.Name, updBase);
            #endregion

            #region Text Labels
            // Offset for 'main' text Labels
            Point lblTextMainOffset = new Point(1, 1);
            // Offset for 'actual' text Labels
            Point lblTextActualOffset = new Point(5, 2);
            // Offset for 'ccp' text Labels
            Point lblTextCcpOffset = new Point(5, 6);

            // Set up the 'actual' text Label
            Label lblTextMain = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 15, FontStyle.Bold),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Text = controlNames[loopVar],
                Name = "lblTextMain" + tabName + controlNames[loopVar],
            };
            // Set up the 'actual' text Label
            Label lblTextActual = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = Properties.Resources.MISC_Text_Actual,
                Name = "lblTextActual" + tabName + controlNames[loopVar],
            };
            // Set up the 'ccp' text Label
            Label lblTextCcp = new Label()
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = Properties.Resources.MISC_Text_CCP,
                Name = "lblTextCCP" + tabName + controlNames[loopVar],
            };

            // Add and set position of the Label in the layout
            tlpDebug.Controls.Add(lblTextMain, ctrlPos.X + lblTextMainOffset.X, ctrlPos.Y + lblTextMainOffset.Y);
            tlpDebug.Controls.Add(lblTextActual, ctrlPos.X + lblTextActualOffset.X, ctrlPos.Y + lblTextActualOffset.Y);
            tlpDebug.Controls.Add(lblTextCcp, ctrlPos.X + lblTextCcpOffset.X, ctrlPos.Y + lblTextCcpOffset.Y);
            tlpDebug.SetRowSpan(lblTextMain, 2);
            tlpDebug.SetColumnSpan(lblTextMain, 3);

            // Add control to the dictionary
            lblControls.Add(lblTextMain.Name, lblTextMain);
            lblControls.Add(lblTextActual.Name, lblTextActual);
            lblControls.Add(lblTextCcp.Name, lblTextCcp);
            #endregion

            #region Labels
            // LABELS
            // Offset for 'actual' Labels
            Point lblActualOffset = new Point(5, 3);
            // Offset for 'ccp' Labels
            Point lblCcpOffset = new Point(5, 5);

            // Set up the 'actual' Label
            Label lblActual = new Label()
            {
                AutoSize = true,
                Font = new Font("Harrington", 18, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Margin = new Padding(3, 0, 3, 0),
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "12",
                Name = "lblActual" + tabName + controlNames[loopVar],
            };
            // Set up the 'ccp' Label
            Label lblCcp = new Label()
            {
                AutoSize = true,
                Font = new Font("Harrington", 18, FontStyle.Regular),
                Dock = DockStyle.Fill,
                Margin = new Padding(3, 0, 3, 0),
                BorderStyle = BorderStyle.Fixed3D,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "12",
                Name = "lblCCP" + tabName + controlNames[loopVar],
            };

            // Add and set position of the Label in the layout
            tlpDebug.Controls.Add(lblActual, ctrlPos.X + lblActualOffset.X, ctrlPos.Y + lblActualOffset.Y);
            tlpDebug.Controls.Add(lblCcp, ctrlPos.X + lblCcpOffset.X, ctrlPos.Y + lblCcpOffset.Y);

            // Add control to the dictionary
            lblControls.Add(lblActual.Name, lblActual);
            lblControls.Add(lblCcp.Name, lblCcp);
            #endregion
        }
    }
}
