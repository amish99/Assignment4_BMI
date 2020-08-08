namespace assignmentBMI4
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialBMIButton = new System.Windows.Forms.RadioButton();
            this.MetricBMIButton = new System.Windows.Forms.RadioButton();
            this.InchOrMeterBMILabel = new System.Windows.Forms.Label();
            this.HeightBMITextBox = new System.Windows.Forms.TextBox();
            this.WeightBMITextBox = new System.Windows.Forms.TextBox();
            this.WeightBMILabel = new System.Windows.Forms.Label();
            this.PoundOrKGBMILabel = new System.Windows.Forms.Label();
            this.OutputBMITextBox = new System.Windows.Forms.TextBox();
            this.ResetBMIButton = new System.Windows.Forms.Button();
            this.ScaleBMITextBox = new System.Windows.Forms.TextBox();
            this.HeightBMILabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.UITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UITableLayoutPanel
            // 
            this.UITableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.UITableLayoutPanel.ColumnCount = 2;
            this.UITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.UITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UITableLayoutPanel.Controls.Add(this.ImperialBMIButton, 0, 0);
            this.UITableLayoutPanel.Controls.Add(this.MetricBMIButton, 1, 0);
            this.UITableLayoutPanel.Controls.Add(this.InchOrMeterBMILabel, 0, 2);
            this.UITableLayoutPanel.Controls.Add(this.HeightBMITextBox, 0, 3);
            this.UITableLayoutPanel.Controls.Add(this.WeightBMITextBox, 0, 6);
            this.UITableLayoutPanel.Controls.Add(this.WeightBMILabel, 0, 4);
            this.UITableLayoutPanel.Controls.Add(this.PoundOrKGBMILabel, 0, 5);
            this.UITableLayoutPanel.Controls.Add(this.OutputBMITextBox, 0, 8);
            this.UITableLayoutPanel.Controls.Add(this.ResetBMIButton, 1, 7);
            this.UITableLayoutPanel.Controls.Add(this.ScaleBMITextBox, 0, 9);
            this.UITableLayoutPanel.Controls.Add(this.HeightBMILabel, 0, 1);
            this.UITableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 7);
            this.UITableLayoutPanel.Location = new System.Drawing.Point(1, -1);
            this.UITableLayoutPanel.Name = "UITableLayoutPanel";
            this.UITableLayoutPanel.RowCount = 11;
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.601873F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07026F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UITableLayoutPanel.Size = new System.Drawing.Size(299, 429);
            this.UITableLayoutPanel.TabIndex = 0;
            // 
            // ImperialBMIButton
            // 
            this.ImperialBMIButton.BackColor = System.Drawing.Color.Blue;
            this.ImperialBMIButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialBMIButton.ForeColor = System.Drawing.Color.White;
            this.ImperialBMIButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialBMIButton.Name = "ImperialBMIButton";
            this.ImperialBMIButton.Size = new System.Drawing.Size(136, 35);
            this.ImperialBMIButton.TabIndex = 0;
            this.ImperialBMIButton.TabStop = true;
            this.ImperialBMIButton.Text = "Imperial";
            this.ImperialBMIButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialBMIButton.UseVisualStyleBackColor = false;
            this.ImperialBMIButton.CheckedChanged += new System.EventHandler(this.ImperialBMIButton_CheckedChanged);
            // 
            // MetricBMIButton
            // 
            this.MetricBMIButton.BackColor = System.Drawing.Color.Blue;
            this.MetricBMIButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricBMIButton.ForeColor = System.Drawing.Color.White;
            this.MetricBMIButton.Location = new System.Drawing.Point(150, 3);
            this.MetricBMIButton.Name = "MetricBMIButton";
            this.MetricBMIButton.Size = new System.Drawing.Size(146, 34);
            this.MetricBMIButton.TabIndex = 1;
            this.MetricBMIButton.TabStop = true;
            this.MetricBMIButton.Text = "Metric";
            this.MetricBMIButton.UseVisualStyleBackColor = false;
            this.MetricBMIButton.CheckedChanged += new System.EventHandler(this.MetricBMIButton_CheckedChanged);
            // 
            // InchOrMeterBMILabel
            // 
            this.InchOrMeterBMILabel.BackColor = System.Drawing.Color.Blue;
            this.UITableLayoutPanel.SetColumnSpan(this.InchOrMeterBMILabel, 2);
            this.InchOrMeterBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InchOrMeterBMILabel.ForeColor = System.Drawing.Color.White;
            this.InchOrMeterBMILabel.Location = new System.Drawing.Point(3, 82);
            this.InchOrMeterBMILabel.Name = "InchOrMeterBMILabel";
            this.InchOrMeterBMILabel.Size = new System.Drawing.Size(293, 39);
            this.InchOrMeterBMILabel.TabIndex = 3;
            this.InchOrMeterBMILabel.Text = "Inches";
            this.InchOrMeterBMILabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HeightBMITextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.HeightBMITextBox, 2);
            this.HeightBMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBMITextBox.Location = new System.Drawing.Point(3, 126);
            this.HeightBMITextBox.Name = "HeightBMITextBox";
            this.HeightBMITextBox.Size = new System.Drawing.Size(293, 38);
            this.HeightBMITextBox.TabIndex = 4;
            this.HeightBMITextBox.Text = "0";
            this.HeightBMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightBMITextBox.TextChanged += new System.EventHandler(this.HeightBMITextBox_TextChanged);
            this.HeightBMITextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightBMITextBox_KeyPress);
            // 
            // WeightBMITextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.WeightBMITextBox, 2);
            this.WeightBMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightBMITextBox.Location = new System.Drawing.Point(3, 247);
            this.WeightBMITextBox.Name = "WeightBMITextBox";
            this.WeightBMITextBox.Size = new System.Drawing.Size(293, 38);
            this.WeightBMITextBox.TabIndex = 5;
            this.WeightBMITextBox.Text = "0";
            this.WeightBMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightBMITextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightBMITextBox_KeyPress);
            // 
            // WeightBMILabel
            // 
            this.WeightBMILabel.BackColor = System.Drawing.Color.Blue;
            this.UITableLayoutPanel.SetColumnSpan(this.WeightBMILabel, 2);
            this.WeightBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightBMILabel.ForeColor = System.Drawing.Color.White;
            this.WeightBMILabel.Location = new System.Drawing.Point(3, 162);
            this.WeightBMILabel.Name = "WeightBMILabel";
            this.WeightBMILabel.Size = new System.Drawing.Size(293, 41);
            this.WeightBMILabel.TabIndex = 6;
            this.WeightBMILabel.Text = "My Weight";
            this.WeightBMILabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PoundOrKGBMILabel
            // 
            this.PoundOrKGBMILabel.BackColor = System.Drawing.Color.Blue;
            this.UITableLayoutPanel.SetColumnSpan(this.PoundOrKGBMILabel, 2);
            this.PoundOrKGBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundOrKGBMILabel.ForeColor = System.Drawing.Color.White;
            this.PoundOrKGBMILabel.Location = new System.Drawing.Point(3, 203);
            this.PoundOrKGBMILabel.Name = "PoundOrKGBMILabel";
            this.PoundOrKGBMILabel.Size = new System.Drawing.Size(293, 39);
            this.PoundOrKGBMILabel.TabIndex = 7;
            this.PoundOrKGBMILabel.Text = "Pounds";
            this.PoundOrKGBMILabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // OutputBMITextBox
            // 
            this.OutputBMITextBox.BackColor = System.Drawing.Color.MistyRose;
            this.UITableLayoutPanel.SetColumnSpan(this.OutputBMITextBox, 2);
            this.OutputBMITextBox.Enabled = false;
            this.OutputBMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBMITextBox.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.OutputBMITextBox.Location = new System.Drawing.Point(3, 329);
            this.OutputBMITextBox.Name = "OutputBMITextBox";
            this.OutputBMITextBox.ReadOnly = true;
            this.OutputBMITextBox.Size = new System.Drawing.Size(293, 38);
            this.OutputBMITextBox.TabIndex = 8;
            this.OutputBMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ResetBMIButton
            // 
            this.ResetBMIButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ResetBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBMIButton.Location = new System.Drawing.Point(150, 288);
            this.ResetBMIButton.Name = "ResetBMIButton";
            this.ResetBMIButton.Size = new System.Drawing.Size(146, 34);
            this.ResetBMIButton.TabIndex = 10;
            this.ResetBMIButton.Text = "Reset";
            this.ResetBMIButton.UseVisualStyleBackColor = false;
            this.ResetBMIButton.Click += new System.EventHandler(this.ResetBMIButton_Click);
            // 
            // ScaleBMITextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.ScaleBMITextBox, 2);
            this.ScaleBMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleBMITextBox.Location = new System.Drawing.Point(3, 370);
            this.ScaleBMITextBox.Multiline = true;
            this.ScaleBMITextBox.Name = "ScaleBMITextBox";
            this.UITableLayoutPanel.SetRowSpan(this.ScaleBMITextBox, 2);
            this.ScaleBMITextBox.Size = new System.Drawing.Size(293, 56);
            this.ScaleBMITextBox.TabIndex = 11;
            this.ScaleBMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // HeightBMILabel
            // 
            this.HeightBMILabel.BackColor = System.Drawing.Color.Blue;
            this.UITableLayoutPanel.SetColumnSpan(this.HeightBMILabel, 2);
            this.HeightBMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightBMILabel.ForeColor = System.Drawing.Color.White;
            this.HeightBMILabel.Location = new System.Drawing.Point(3, 41);
            this.HeightBMILabel.Name = "HeightBMILabel";
            this.HeightBMILabel.Size = new System.Drawing.Size(293, 40);
            this.HeightBMILabel.TabIndex = 2;
            this.HeightBMILabel.Text = "My Height";
            this.HeightBMILabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.SkyBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 288);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(141, 34);
            this.CalculateBMIButton.TabIndex = 9;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.UITableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.UITableLayoutPanel.ResumeLayout(false);
            this.UITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UITableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialBMIButton;
        private System.Windows.Forms.RadioButton MetricBMIButton;
        private System.Windows.Forms.Label HeightBMILabel;
        private System.Windows.Forms.Label InchOrMeterBMILabel;
        private System.Windows.Forms.TextBox HeightBMITextBox;
        private System.Windows.Forms.TextBox WeightBMITextBox;
        private System.Windows.Forms.Label WeightBMILabel;
        private System.Windows.Forms.Label PoundOrKGBMILabel;
        private System.Windows.Forms.TextBox OutputBMITextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetBMIButton;
        private System.Windows.Forms.TextBox ScaleBMITextBox;
    }
}
