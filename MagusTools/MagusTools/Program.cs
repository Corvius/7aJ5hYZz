using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagusTools
{
    static class Program
    {
        // Logger object
        public static LogWindow.LogWindow logger;

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
            mainForm main = new mainForm();

            // Create and show debug window
            logger = new LogWindow.LogWindow(main);
            logger.Show();

            // Run application
            Application.Run(main);
        }
    }
}
