namespace TempConversion
{
    partial class Form1
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
            this.comboUnits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConversion1Value = new System.Windows.Forms.Label();
            this.numberboxTempValue = new System.Windows.Forms.NumericUpDown();
            this.lblConversion2Value = new System.Windows.Forms.Label();
            this.ImageTempGauge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTempGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // comboUnits
            // 
            this.comboUnits.Font = new System.Drawing.Font("Courier New", 12F);
            this.comboUnits.FormattingEnabled = true;
            this.comboUnits.Items.AddRange(new object[] {
            "Fahrenheit",
            "Celsius",
            "Kelvin"});
            this.comboUnits.Location = new System.Drawing.Point(667, 71);
            this.comboUnits.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboUnits.Name = "comboUnits";
            this.comboUnits.Size = new System.Drawing.Size(199, 26);
            this.comboUnits.TabIndex = 0;
            this.comboUnits.SelectedIndexChanged += new System.EventHandler(this.comboUnits_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F);
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Temperature:";
            // 
            // lblConversion1Value
            // 
            this.lblConversion1Value.AutoSize = true;
            this.lblConversion1Value.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblConversion1Value.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConversion1Value.Location = new System.Drawing.Point(662, 152);
            this.lblConversion1Value.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConversion1Value.Name = "lblConversion1Value";
            this.lblConversion1Value.Size = new System.Drawing.Size(68, 18);
            this.lblConversion1Value.TabIndex = 2;
            this.lblConversion1Value.Text = "value1";
            this.lblConversion1Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numberboxTempValue
            // 
            this.numberboxTempValue.DecimalPlaces = 2;
            this.numberboxTempValue.Font = new System.Drawing.Font("Courier New", 12F);
            this.numberboxTempValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numberboxTempValue.Location = new System.Drawing.Point(433, 71);
            this.numberboxTempValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.numberboxTempValue.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numberboxTempValue.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numberboxTempValue.Name = "numberboxTempValue";
            this.numberboxTempValue.Size = new System.Drawing.Size(200, 26);
            this.numberboxTempValue.TabIndex = 3;
            this.numberboxTempValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberboxTempValue.ValueChanged += new System.EventHandler(this.numberboxTempValue_ValueChanged);
            // 
            // lblConversion2Value
            // 
            this.lblConversion2Value.AutoSize = true;
            this.lblConversion2Value.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblConversion2Value.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblConversion2Value.Location = new System.Drawing.Point(662, 226);
            this.lblConversion2Value.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblConversion2Value.Name = "lblConversion2Value";
            this.lblConversion2Value.Size = new System.Drawing.Size(68, 18);
            this.lblConversion2Value.TabIndex = 4;
            this.lblConversion2Value.Text = "value2";
            this.lblConversion2Value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImageTempGauge
            // 
            this.ImageTempGauge.Location = new System.Drawing.Point(25, 126);
            this.ImageTempGauge.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ImageTempGauge.Name = "ImageTempGauge";
            this.ImageTempGauge.Size = new System.Drawing.Size(358, 141);
            this.ImageTempGauge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageTempGauge.TabIndex = 5;
            this.ImageTempGauge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 302);
            this.Controls.Add(this.ImageTempGauge);
            this.Controls.Add(this.lblConversion2Value);
            this.Controls.Add(this.numberboxTempValue);
            this.Controls.Add(this.lblConversion1Value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUnits);
            this.Font = new System.Drawing.Font("Courier New", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Temperature Conversion Program";
            ((System.ComponentModel.ISupportInitialize)(this.numberboxTempValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTempGauge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConversion1Value;
        private System.Windows.Forms.NumericUpDown numberboxTempValue;
        private System.Windows.Forms.Label lblConversion2Value;
        private System.Windows.Forms.PictureBox ImageTempGauge;
    }
}

