using System;
using System.Drawing;
using System.Windows.Forms;

namespace MagusTools
{
    static class Program
    {

        [System.Diagnostics.Conditional("DEBUG")]
        static void setupLoggers(Form ownerForm)
        {
            // Relocate ownerform
            ownerForm.StartPosition = FormStartPosition.Manual;
            ownerForm.Location = new Point(100, 100);

            // Create and show event debug window
            Point eventLoggerOffset = ownerForm.Location;
            eventLoggerOffset.Offset(ownerForm.Width, 0);
            eventLogger = new LogWindow.LogWindow(ownerForm, eventLoggerOffset)
            {
                Text = "Event Information",
                ClientSize = new Size(800, 400)
            };
            eventLogger.Show();

            // Create and show character debug window
            Point charLoggerOffset = ownerForm.Location;
            charLoggerOffset.Offset(ownerForm.Width, eventLogger.Height);
            charLogger = new LogWindow.LogWindow(ownerForm, charLoggerOffset)
            {
                Text = "Character Information",
                ClientSize = new Size(400, 400)
            };
            charLogger.Show();
        }

        // Logger object
        public static LogWindow.LogWindow eventLogger;
        public static LogWindow.LogWindow charLogger;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configure application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initailize form
            mainForm main = new mainForm() { StartPosition = FormStartPosition.CenterScreen };

            // Configure loggers
            setupLoggers(main);

            // Run application
            Application.Run(main);
        }
    }
}
