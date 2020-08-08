using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignmentBMI4
{
    /*
 * Name: amish tangri
 * Student ID: 301108446
 * Date: August 7, 2020
 * Program Description: This is a BMI(body mass index) calculator which whill show your bmi after you filled your height and weight.
 */
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
