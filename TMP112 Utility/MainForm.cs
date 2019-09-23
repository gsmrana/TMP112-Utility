using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMP112_Utility
{
    public partial class MainForm : Form
    {
        #region Data

        const double TMP112CelciusConst = 0.0625; // 1/16
        const double FahrenheitConst = 1.8;       // 9/5
        short _digitalValue = 0;
        double _celciusValue = 0;
        double _fahrenheitValue = 0;
        short _stMemFormat = 0;

        #endregion

        #region ctor

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                labelException.Text = "";
                textBoxTempCelcius.Text = "-40";
                ConvertNumbers(InputType.TempCelcius);
            }
            catch (Exception ex)
            {
                labelException.Text = ex.Message;
            }
        }

        #endregion

        #region Internal Methods

        private void ClearNumbers(InputType inputtype)
        {
            if (inputtype != InputType.DigitalHex) textBoxDigitalHex.Clear();
            if (inputtype != InputType.DigitalDecimal) textBoxDigitalDecimal.Clear();
            if (inputtype != InputType.DigitalBinary) textBoxDigitalBinary.Clear();
            if (inputtype != InputType.TempCelcius) textBoxTempCelcius.Clear();
            if (inputtype != InputType.TempFahrenheit) textBoxTempFahrenheit.Clear();
            if (inputtype != InputType.StFormatHex) textBoxStFormatHex.Clear();
            if (inputtype != InputType.StFormatDec) textBoxStFormatDec.Clear();
        }

        private void DisplayNumbers(InputType inputtype)
        {
            if (inputtype != InputType.DigitalHex) textBoxDigitalHex.Text = _digitalValue.ToString("X4");
            if (inputtype != InputType.DigitalDecimal) textBoxDigitalDecimal.Text = _digitalValue.ToString();
            if (inputtype != InputType.DigitalBinary) textBoxDigitalBinary.Text = Convert.ToString(_digitalValue, 2);
            if (inputtype != InputType.TempCelcius) textBoxTempCelcius.Text = _celciusValue.ToString("0.##");
            if (inputtype != InputType.TempFahrenheit) textBoxTempFahrenheit.Text = _fahrenheitValue.ToString("0.##");
            if (inputtype != InputType.StFormatHex) textBoxStFormatHex.Text = _stMemFormat.ToString("X4");
            if (inputtype != InputType.StFormatDec) textBoxStFormatDec.Text = _stMemFormat.ToString();
        }

        private void ConvertNumbers(InputType inputtype)
        {
            try
            {
                labelException.Text = "";
                ClearNumbers(inputtype);
                Debug.WriteLine("InputType: " + inputtype);

                if (inputtype == InputType.DigitalHex)
                {
                    _digitalValue = Convert.ToInt16(textBoxDigitalHex.Text, 16);
                    _celciusValue = _digitalValue * TMP112CelciusConst;
                    _fahrenheitValue = (_celciusValue * FahrenheitConst) + 32;
                }
                if (inputtype == InputType.DigitalDecimal)
                {
                    _digitalValue = Convert.ToInt16(textBoxDigitalDecimal.Text, 10);
                    _celciusValue = _digitalValue * TMP112CelciusConst;
                    _fahrenheitValue = (_celciusValue * FahrenheitConst) + 32;
                }
                else if (inputtype == InputType.DigitalBinary)
                {
                    _digitalValue = Convert.ToInt16(textBoxDigitalBinary.Text, 2);
                    _celciusValue = _digitalValue * TMP112CelciusConst;
                    _fahrenheitValue = (_celciusValue * FahrenheitConst) + 32;
                }
                else if (inputtype == InputType.TempCelcius)
                {
                    _celciusValue = double.Parse(textBoxTempCelcius.Text);
                    _fahrenheitValue = (_celciusValue * FahrenheitConst) + 32;
                    _digitalValue = (short)(_celciusValue / TMP112CelciusConst);
                }
                else if (inputtype == InputType.TempFahrenheit)
                {
                    _fahrenheitValue = double.Parse(textBoxTempFahrenheit.Text);
                    _celciusValue = (_fahrenheitValue - 32) / FahrenheitConst;
                    _digitalValue = (short)(_celciusValue / TMP112CelciusConst);
                }
                else if (inputtype == InputType.StFormatHex)
                {
                    _fahrenheitValue = Convert.ToInt16(textBoxStFormatHex.Text, 16) / 10.0;
                    _celciusValue = (_fahrenheitValue - 32) / FahrenheitConst;
                    _digitalValue = (short)(_celciusValue / TMP112CelciusConst);
                }
                else if (inputtype == InputType.StFormatDec)
                {
                    _fahrenheitValue = int.Parse(textBoxStFormatDec.Text) / 10.0;
                    _celciusValue = (_fahrenheitValue - 32) / FahrenheitConst;
                    _digitalValue = (short)(_celciusValue / TMP112CelciusConst);
                }

                _stMemFormat = (short)(_fahrenheitValue * 10);
                DisplayNumbers(inputtype);
            }
            catch (Exception ex)
            {
                labelException.Text = ex.Message;
            }
        }

        #endregion

        #region Form Events

        private void TextBoxDigitalHex_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.DigitalHex);
        }

        private void TextBoxDigitalDecimal_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.DigitalDecimal);
        }

        private void TextBoxDigitalBinary_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.DigitalBinary);
        }

        private void TextBoxTempCelcius_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.TempCelcius);
        }

        private void TextBoxTempFahrenheit_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.TempFahrenheit);
        }

        private void TextBoxStMemFormat_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.StFormatHex);
        }

        private void TextBoxStFormatDec_KeyUp(object sender, KeyEventArgs e)
        {
            ConvertNumbers(InputType.StFormatDec);
        }

        #endregion

    }

    public enum InputType
    {
        None,
        DigitalHex,
        DigitalDecimal,
        DigitalBinary,
        TempCelcius,
        TempFahrenheit,
        StFormatHex,
        StFormatDec
    }
}
