using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MagusTools
{
    /// <summary>
    /// Extends the NumericUpDown control by providing a property to 
    /// set the number of steps that are added to or subtracted from
    /// the value when the mouse wheel is scrolled.
    /// </summary>
    public class NumericUpDownExt : NumericUpDown
    {
        private int wheelDelta = 0;
        private int mouseWheelScrollLines = 1;

        /// <summary>
        /// Gets or sets the number of step sizes to increment or 
        /// decrement from the value when the mouse wheel is scrolled.
        /// Set this value to -1 to use the system default.
        /// </summary>
        [DefaultValue(1)]
        [Description("Gets or sets the number of step sizes to increment or decrement from the value when the mouse wheel is scrolled. Set this value to -1 to use the system default.")]
        public Int32 MouseWheelScrollLines
        {
            get { return mouseWheelScrollLines; }
            set
            {
                if (value < -1)
                    throw new ArgumentOutOfRangeException("Value must be greater than or equal to -1.");
                if (value == -1)
                    mouseWheelScrollLines = SystemInformation.MouseWheelScrollLines;
                else
                    mouseWheelScrollLines = value;
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            HandledMouseEventArgs args = e as HandledMouseEventArgs;
            if (args != null)
            {
                if (args.Handled)
                {
                    base.OnMouseWheel(e);
                    return;
                }
                args.Handled = true;
            }

            base.OnMouseWheel(e);

            if ((Control.ModifierKeys & (Keys.Alt | Keys.Shift)) == Keys.None && Control.MouseButtons == MouseButtons.None)
            {
                if (mouseWheelScrollLines != 0)
                {
                    this.wheelDelta += e.Delta;
                    float wd = (float)this.wheelDelta / 120f;
                    if (mouseWheelScrollLines == -1)
                        mouseWheelScrollLines = 1;
                    int move = (int)(mouseWheelScrollLines * wd);
                    if (move != 0)
                    {
                        int cv;
                        if (move > 0)
                        {
                            for (cv = move; cv > 0; cv--)
                                this.UpButton();
                            this.wheelDelta -= (int)(move * (120f / (float)mouseWheelScrollLines));
                        }
                        else
                        {
                            for (cv = -move; cv > 0; cv--)
                                this.DownButton();
                            this.wheelDelta -= (int)(move * (120f / (float)mouseWheelScrollLines));
                        }
                    }
                }
            }
        }
    }
}
