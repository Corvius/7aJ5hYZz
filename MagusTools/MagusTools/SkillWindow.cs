using System.Windows.Forms;

namespace MagusTools
{
    public class SkillWindow : Form
    {
        private RichTextBoxExt rtb = new RichTextBoxExt();
        private Point startLocation = new Point(100, 100);

        public SkillWindow(string skillName)
        {
            startLocation = pStartLocation;
            InitializeComponent();
            Load += LogWindow_Load;
            FormClosing += LogWindow_FormClosing;
        }
    }

    }
}
