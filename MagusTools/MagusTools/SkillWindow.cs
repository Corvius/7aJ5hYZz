using System.Windows.Forms;

namespace MagusTools
{
    public class SkillWindow : Form
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel tlpSelectSkill;
        private Label lblSkillNameText;
        private Label lblSkillName;
        private Label lblLevel;
        private NumericUpDownExt updLevel;
        private CheckBox chkUseCCP;
        private Label lblReqList;
        private ListBox lbReqList;
        private Label lblSubType;
        private ComboBox cbSubType;
        private TableLayoutPanel tlpButtons;
        private Button btOk;
        private Button btCancel;

        public SkillWindow(string skillName)
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
        }

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

        private void InitializeComponent()
        {
            this.tlpSelectSkill = new TableLayoutPanel();
            this.lblSkillNameText = new Label();
            this.lblSkillName = new Label();
            this.lblLevel = new Label();
            this.updLevel = new NumericUpDownExt();
            this.chkUseCCP = new CheckBox();
            this.lblReqList = new Label();
            this.lbReqList = new ListBox();
            this.lblSubType = new Label();
            this.cbSubType = new ComboBox();
            this.tlpButtons = new TableLayoutPanel();
            this.btCancel = new Button();
            this.btOk = new Button();
            this.tlpSelectSkill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLevel)).BeginInit();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSelectSkill
            // 
            this.tlpSelectSkill.ColumnCount = 5;
            this.tlpSelectSkill.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            this.tlpSelectSkill.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            this.tlpSelectSkill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tlpSelectSkill.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            this.tlpSelectSkill.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12F));
            this.tlpSelectSkill.Controls.Add(this.lblSkillNameText, 1, 1);
            this.tlpSelectSkill.Controls.Add(this.lblSkillName, 1, 2);
            this.tlpSelectSkill.Controls.Add(this.lblLevel, 1, 3);
            this.tlpSelectSkill.Controls.Add(this.updLevel, 1, 4);
            this.tlpSelectSkill.Controls.Add(this.chkUseCCP, 1, 5);
            this.tlpSelectSkill.Controls.Add(this.lblReqList, 3, 1);
            this.tlpSelectSkill.Controls.Add(this.lbReqList, 3, 2);
            this.tlpSelectSkill.Controls.Add(this.lblSubType, 3, 5);
            this.tlpSelectSkill.Controls.Add(this.cbSubType, 3, 6);
            this.tlpSelectSkill.Controls.Add(this.tlpButtons, 1, 7);
            this.tlpSelectSkill.Dock = DockStyle.Fill;
            this.tlpSelectSkill.Location = new System.Drawing.Point(0, 0);
            this.tlpSelectSkill.Margin = new Padding(3, 4, 3, 4);
            this.tlpSelectSkill.Name = "tlpSelectSkill";
            this.tlpSelectSkill.RowCount = 9;
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tlpSelectSkill.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            this.tlpSelectSkill.Size = new System.Drawing.Size(393, 322);
            this.tlpSelectSkill.TabIndex = 0;
            // 
            // lblSkillNameText
            // 
            this.lblSkillNameText.AutoSize = true;
            this.lblSkillNameText.Dock = DockStyle.Fill;
            this.lblSkillNameText.Location = new System.Drawing.Point(12, 16);
            this.lblSkillNameText.Margin = new Padding(0);
            this.lblSkillNameText.Name = "lblSkillNameText";
            this.lblSkillNameText.Size = new System.Drawing.Size(140, 16);
            this.lblSkillNameText.TabIndex = 0;
            this.lblSkillNameText.Text = "Képzettség neve";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.BorderStyle = BorderStyle.Fixed3D;
            this.lblSkillName.Dock = DockStyle.Fill;
            this.lblSkillName.Location = new System.Drawing.Point(12, 32);
            this.lblSkillName.Margin = new Padding(0);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(140, 48);
            this.lblSkillName.TabIndex = 1;
            this.lblSkillName.Text = "<SkillName><SkillName>";
            this.lblSkillName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Dock = DockStyle.Fill;
            this.lblLevel.Location = new System.Drawing.Point(12, 80);
            this.lblLevel.Margin = new Padding(0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(140, 24);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Fok / %";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // updLevel
            // 
            this.updLevel.Dock = DockStyle.Fill;
            this.updLevel.Font = new System.Drawing.Font("Harrington", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updLevel.Location = new System.Drawing.Point(12, 104);
            this.updLevel.Margin = new Padding(0);
            this.updLevel.Name = "updLevel";
            this.updLevel.Size = new System.Drawing.Size(140, 86);
            this.updLevel.TabIndex = 3;
            this.updLevel.TextAlign = HorizontalAlignment.Center;
            this.updLevel.Value = new decimal(new int[] {
            0, // TODO: Add min/max here!
            0,
            0,
            0});
            // 
            // chkUseCCP
            // 
            this.chkUseCCP.AutoSize = true;
            this.chkUseCCP.Dock = DockStyle.Fill;
            this.chkUseCCP.Location = new System.Drawing.Point(12, 204);
            this.chkUseCCP.Margin = new Padding(0);
            this.chkUseCCP.Name = "chkUseCCP";
            this.chkUseCCP.Size = new System.Drawing.Size(140, 24);
            this.chkUseCCP.TabIndex = 4;
            this.chkUseCCP.Text = "KAP felhasználás";
            this.chkUseCCP.UseVisualStyleBackColor = true;
            // 
            // lblReqList
            // 
            this.lblReqList.AutoSize = true;
            this.lblReqList.Dock = DockStyle.Fill;
            this.lblReqList.Location = new System.Drawing.Point(201, 16);
            this.lblReqList.Margin = new Padding(0);
            this.lblReqList.Name = "lblReqList";
            this.lblReqList.Size = new System.Drawing.Size(180, 16);
            this.lblReqList.TabIndex = 7;
            this.lblReqList.Text = "Követelménylista";
            // 
            // lbReqList
            // 
            this.lbReqList.Dock = DockStyle.Fill;
            this.lbReqList.FormattingEnabled = true;
            this.lbReqList.ItemHeight = 17;
            this.lbReqList.Location = new System.Drawing.Point(201, 32);
            this.lbReqList.Margin = new Padding(0);
            this.lbReqList.Name = "lbReqList";
            this.tlpSelectSkill.SetRowSpan(this.lbReqList, 3);
            this.lbReqList.ScrollAlwaysVisible = true;
            this.lbReqList.Size = new System.Drawing.Size(180, 172);
            this.lbReqList.TabIndex = 8;
            // 
            // lblSubType
            // 
            this.lblSubType.AutoSize = true;
            this.lblSubType.Dock = DockStyle.Fill;
            this.lblSubType.Location = new System.Drawing.Point(201, 204);
            this.lblSubType.Margin = new Padding(0);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(180, 24);
            this.lblSubType.TabIndex = 9;
            this.lblSubType.Text = "Altípus";
            this.lblSubType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cbSubType
            // 
            this.cbSubType.Dock = DockStyle.Fill;
            this.cbSubType.FormattingEnabled = true;
            this.cbSubType.Location = new System.Drawing.Point(201, 228);
            this.cbSubType.Margin = new Padding(0);
            this.cbSubType.Name = "cbSubType";
            this.cbSubType.Size = new System.Drawing.Size(180, 25);
            this.cbSubType.TabIndex = 10;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpSelectSkill.SetColumnSpan(this.tlpButtons, 3);
            this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            this.tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.tlpButtons.Controls.Add(this.btOk, 2, 0);
            this.tlpButtons.Controls.Add(this.btCancel, 0, 0);
            this.tlpButtons.Dock = DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(15, 279);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tlpButtons.Size = new System.Drawing.Size(363, 28);
            this.tlpButtons.TabIndex = 11;
            // 
            // btCancel
            // 
            this.btCancel.Dock = DockStyle.Fill;
            this.btCancel.Location = new System.Drawing.Point(0, 0);
            this.btCancel.Margin = new Padding(0);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(145, 28);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Mégsem";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.Dock = DockStyle.Fill;
            this.btOk.Location = new System.Drawing.Point(217, 0);
            this.btOk.Margin = new Padding(0);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(146, 28);
            this.btOk.TabIndex = 7;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // frmSelectSkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.tlpSelectSkill);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Margin = new Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectSkill";
            this.Text = "[ Képzettségszint ]";
            this.tlpSelectSkill.ResumeLayout(false);
            this.tlpSelectSkill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updLevel)).EndInit();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
