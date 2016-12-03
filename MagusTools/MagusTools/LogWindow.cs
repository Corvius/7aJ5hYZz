using System.Drawing;
using System.Windows.Forms;

namespace LogWindow
{
    public static class LogExtension
    {
        public static void Log(this Control source, string message)
        {
            source.Log(message, null);
        }
        public static void Log(this Control source, string message, object[] args)
        {

        }
    }

    public class LogWindow : Form
    {
        private RichTextBoxExt rtb = new RichTextBoxExt();

        public LogWindow(Form pOwner)
        {
            Owner = pOwner;
            InitializeComponent();
            Load += LogWindow_Load;
            FormClosing += LogWindow_FormClosing;
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel =
                e.CloseReason != CloseReason.FormOwnerClosing
                &&
                MessageBox.Show
                    ("Do you really want to close the debug window?",
                    "Closing debugform",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No;
        }

        private void LogWindow_Load(object sender, System.EventArgs e)
        {
            if (Owner != null)
            {
                Point newPos = Owner.Location;
                newPos.Offset(Owner.Width, 0);
                Location = newPos;
            }
        }

        private void InitializeComponent()
        {
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 400);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            Name = "debugForm";
            Text = "Debug Information";

            rtb.BackColor = SystemColors.ControlDark;
            rtb.Dock = DockStyle.Fill;
            rtb.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            rtb.Location = new Point(3, 93);
            rtb.Name = "debug_textBox";
            rtb.TabIndex = 1;
            rtb.ReadOnly = true;
            rtb.Text = "";
            Padding = new Padding(4);

            Controls.Add(rtb);
        }

        public void Log(object[] args)
        {
            Color textColor = Color.Black;

            foreach (var item in args)
            {
                if (item is Color)
                    textColor = (Color)item;
                else if (item is string)
                    rtb.AppendText((string)item, textColor);
            }

            rtb.AppendText("\n");
        }

    }

    public class RichTextBoxExt : RichTextBox
    {
        public int m_MaxLines { get; }

        public RichTextBoxExt()
        {
            m_MaxLines = 50;
        }

        public void AppendText(string p_text, Color p_color)
        {
            SelectionStart = TextLength;
            SelectionLength = 0;

            SelectionColor = p_color;
            AppendText(p_text);
            SelectionColor = ForeColor;
           
            if (Lines.Length > m_MaxLines)
            {
                SelectionStart = GetFirstCharIndexFromLine(0);
                SelectionLength = Lines[0].Length + 1;
                SelectedText = System.String.Empty;
            }
        }
    }
}
