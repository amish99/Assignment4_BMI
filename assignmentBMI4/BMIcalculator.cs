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
    public partial class BMICalculator : Form
    {
        // PRIVATE INSTANCE VARIABLES
        private double _result;
        private bool _imperial;
        private bool _metric;


        // PUBLIC PROPERTIES
        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        public bool Imperial
        {
            get
            {
                return this._imperial;
            }
            set
            {
                this._imperial = value;
            }
        }

        public bool Metric
        {
            get
            {
                return this._metric;
            }
            set
            {
                this._metric = value;
            }
        }



        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor of the BMICalculator Form
        /// </summary>
        public BMICalculator()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS
        /// <summary>
        /// This private method determines the output in which units (calculation switches) of the BMI calculate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (InchOrMeterBMILabel.Text == "Inches")
            {
                Result = (Convert.ToDouble(WeightBMITextBox.Text) * 703) / (Convert.ToDouble(HeightBMITextBox.Text) * Convert.ToDouble(HeightBMITextBox.Text));
                OutputBMITextBox.Text = Convert.ToString(Result);
            }
            else
            {
                Result = (Convert.ToDouble(WeightBMITextBox.Text)) / (Convert.ToDouble(HeightBMITextBox.Text) * Convert.ToDouble(HeightBMITextBox.Text));
                OutputBMITextBox.Text = Convert.ToString(Result);
            }

            if (Result < 18.5)
            {
                ScaleBMITextBox.Text = "Your BMI is underweight.";
            }
            if (Result >= 18.5 && Result <= 24.9)
            {
                ScaleBMITextBox.Text = "Your BMI is normal.";
            }
            if (Result >= 25 && Result <= 29.9)
            {
                ScaleBMITextBox.Text = "Your BMI is overweight.";
            }
            if (Result >= 30)
            {
                ScaleBMITextBox.Text = "Your BMI is obese.";
            }
        }


        /// <summary>
        /// These private methods determine which unit is used when the button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialBMIButton_CheckedChanged(object sender, EventArgs e)
        {
            InchOrMeterBMILabel.Text = "Inches";
            PoundOrKGBMILabel.Text = "Pounds";
        }

        private void MetricBMIButton_CheckedChanged(object sender, EventArgs e)
        {
            InchOrMeterBMILabel.Text = "Meters";
            PoundOrKGBMILabel.Text = "Kilograms";
        }


        /// <summary>
        /// This method resets the form back to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBMIButton_Click(object sender, EventArgs e)
        {
            HeightBMITextBox.Text = "0";
            WeightBMITextBox.Text = "0";
            OutputBMITextBox.Text = "";
            ScaleBMITextBox.Text = "";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightBMITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void WeightBMITextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void HeightBMITextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
