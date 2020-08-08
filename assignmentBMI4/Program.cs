using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmentBMI4
{
    static class Program
    {
        public static BMICalculator bmicalculator;
        private static SplashForm splashscreen;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bmicalculator = new BMICalculator();
            splashscreen = new SplashForm();

            Application.Run(splashscreen);
        }
    }
}
