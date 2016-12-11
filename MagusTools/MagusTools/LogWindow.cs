using System.Drawing;
using System.Windows.Forms;

namespace LogWindow
{
    // TODO: Finish LogExtension, so all Control types can call
    //       .Log() instead of maintaining separate, global objects
    //       Make Logger a static class, figure out if multi-threading is neccesary
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
        private Point startLocation = new Point(100, 100);

        public LogWindow(Form pOwner, Point pStartLocation)
        {
            Owner = pOwner;
            startLocation = pStartLocation;
            InitializeComponent();
            Load += LogWindow_Load;
            FormClosing += LogWindow_FormClosing;
        }

        public void Clear()
        {
            rtb.Clear();
        }

        private void LogWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = e.CloseReason != CloseReason.FormOwnerClosing;

            //e.Cancel =
            //    e.CloseReason != CloseReason.FormOwnerClosing
            //    &&
            //    MessageBox.Show
            //        ("Do you really want to close the debug window?",
            //        "Closing debugform",
            //        MessageBoxButtons.YesNo,
            //        MessageBoxIcon.Question,
            //        MessageBoxDefaultButton.Button2) == DialogResult.No;
        }

        private void LogWindow_Load(object sender, System.EventArgs e)
        {
            Location = startLocation;
        }

        private void InitializeComponent()
        {
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(238)));
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            MaximizeBox = false;
            Name = "debugForm";
            if (Text == "") Text = "Generic Debug Information";

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

        [System.Diagnostics.Conditional("DEBUG")]
        public void Log(object[] args, bool newLine = true)
        {
            Color textColor = Color.Black;

            foreach (var item in args)
            {
                if (item is Color)
                    textColor = (Color)item;
                else if (item is string)
                    rtb.AppendText((string)item, textColor);
                else
                    rtb.AppendText(item.ToString(), textColor);
            }

            if (newLine)
                rtb.AppendText("\n");

            rtb.ScrollToCaret();
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

