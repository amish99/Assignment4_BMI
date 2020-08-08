using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            Program.bmicalculator.Show();
            this.Hide();

            SplashFormTimer.Enabled = false;
        }
    }
}
