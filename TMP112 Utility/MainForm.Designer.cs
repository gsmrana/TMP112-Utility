namespace TMP112_Utility
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDigitalHex = new System.Windows.Forms.TextBox();
            this.textBoxDigitalBinary = new System.Windows.Forms.TextBox();
            this.textBoxTempCelcius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTempFahrenheit = new System.Windows.Forms.TextBox();
            this.labelException = new System.Windows.Forms.Label();
            this.textBoxDigitalDecimal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStFormatHex = new System.Windows.Forms.TextBox();
            this.textBoxStFormatDec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "16 bit Sample 0x";
            // 
            // textBoxDigitalHex
            // 
            this.textBoxDigitalHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDigitalHex.Location = new System.Drawing.Point(102, 18);
            this.textBoxDigitalHex.Name = "textBoxDigitalHex";
            this.textBoxDigitalHex.Size = new System.Drawing.Size(66, 20);
            this.textBoxDigitalHex.TabIndex = 0;
            this.textBoxDigitalHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDigitalHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxDigitalHex_KeyUp);
            // 
            // textBoxDigitalBinary
            // 
            this.textBoxDigitalBinary.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDigitalBinary.Location = new System.Drawing.Point(102, 44);
            this.textBoxDigitalBinary.Name = "textBoxDigitalBinary";
            this.textBoxDigitalBinary.Size = new System.Drawing.Size(162, 20);
            this.textBoxDigitalBinary.TabIndex = 2;
            this.textBoxDigitalBinary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDigitalBinary.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxDigitalBinary_KeyUp);
            // 
            // textBoxTempCelcius
            // 
            this.textBoxTempCelcius.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTempCelcius.Location = new System.Drawing.Point(102, 70);
            this.textBoxTempCelcius.Name = "textBoxTempCelcius";
            this.textBoxTempCelcius.Size = new System.Drawing.Size(162, 20);
            this.textBoxTempCelcius.TabIndex = 3;
            this.textBoxTempCelcius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTempCelcius.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxTempCelcius_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "16 bit sample 0b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celcius (°C)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fahrenheit (°F)";
            // 
            // textBoxTempFahrenheit
            // 
            this.textBoxTempFahrenheit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxTempFahrenheit.Location = new System.Drawing.Point(102, 96);
            this.textBoxTempFahrenheit.Name = "textBoxTempFahrenheit";
            this.textBoxTempFahrenheit.Size = new System.Drawing.Size(162, 20);
            this.textBoxTempFahrenheit.TabIndex = 4;
            this.textBoxTempFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTempFahrenheit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxTempFahrenheit_KeyUp);
            // 
            // labelException
            // 
            this.labelException.ForeColor = System.Drawing.Color.DarkRed;
            this.labelException.Location = new System.Drawing.Point(3, 152);
            this.labelException.Name = "labelException";
            this.labelException.Size = new System.Drawing.Size(261, 13);
            this.labelException.TabIndex = 9;
            this.labelException.Text = "Error Message";
            this.labelException.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDigitalDecimal
            // 
            this.textBoxDigitalDecimal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDigitalDecimal.Location = new System.Drawing.Point(174, 18);
            this.textBoxDigitalDecimal.Name = "textBoxDigitalDecimal";
            this.textBoxDigitalDecimal.Size = new System.Drawing.Size(90, 20);
            this.textBoxDigitalDecimal.TabIndex = 1;
            this.textBoxDigitalDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDigitalDecimal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxDigitalDecimal_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ST Mem Format";
            // 
            // textBoxStFormatHex
            // 
            this.textBoxStFormatHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStFormatHex.Location = new System.Drawing.Point(102, 122);
            this.textBoxStFormatHex.Name = "textBoxStFormatHex";
            this.textBoxStFormatHex.Size = new System.Drawing.Size(66, 20);
            this.textBoxStFormatHex.TabIndex = 10;
            this.textBoxStFormatHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStFormatHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxStMemFormat_KeyUp);
            // 
            // textBoxStFormatDec
            // 
            this.textBoxStFormatDec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxStFormatDec.Location = new System.Drawing.Point(174, 122);
            this.textBoxStFormatDec.Name = "textBoxStFormatDec";
            this.textBoxStFormatDec.Size = new System.Drawing.Size(90, 20);
            this.textBoxStFormatDec.TabIndex = 12;
            this.textBoxStFormatDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxStFormatDec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxStFormatDec_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 185);
            this.Controls.Add(this.textBoxStFormatDec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStFormatHex);
            this.Controls.Add(this.textBoxDigitalDecimal);
            this.Controls.Add(this.labelException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTempFahrenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTempCelcius);
            this.Controls.Add(this.textBoxDigitalBinary);
            this.Controls.Add(this.textBoxDigitalHex);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TMP112 Utility";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDigitalHex;
        private System.Windows.Forms.TextBox textBoxDigitalBinary;
        private System.Windows.Forms.TextBox textBoxTempCelcius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTempFahrenheit;
        private System.Windows.Forms.Label labelException;
        private System.Windows.Forms.TextBox textBoxDigitalDecimal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStFormatHex;
        private System.Windows.Forms.TextBox textBoxStFormatDec;
    }
}

