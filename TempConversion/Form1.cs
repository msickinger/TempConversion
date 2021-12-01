using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_none;
        }

        decimal temp;
       
        private void numberboxTempValue_ValueChanged(object sender, EventArgs e)
        {
            temp = numberboxTempValue.Value;
            if (comboUnits.SelectedItem.ToString() == "Fahrenheit")
            {
                convertF(temp);
               
            }
           else if (comboUnits.SelectedItem.ToString() == "Celsius")
            {
                convertC(temp);
            }
           else if( comboUnits.SelectedItem.ToString() == "Kelvin")
            {
                try
                {
                    if (temp >= 0)
                        convertK(temp);
                    else if (temp < 0)
                    {
                        throw new Exception("Kelvin Temperature cannot be below 0");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    numberboxTempValue.Value = 0;
                }
            }
            
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void convertF(decimal temp)
        {
            decimal convertToC;
            decimal convertToK;

            convertToC = (5/9)* (temp - 32);
            convertToK = convertToC+273.15M;

            lblConversion1Value.Text = convertToC.ToString() + '°' + 'C';
            lblConversion2Value.Text = convertToK.ToString() + '°' + 'K';

            changeTempGauge(temp);
        }

        public void convertC(decimal temp)
        {
            decimal convertToF;
            decimal convertToK;
            
            convertToK = temp + 273.15M;
            convertToF = temp * (9 / 5) + 32;

            lblConversion1Value.Text = convertToF.ToString() + '°' + 'F';
            lblConversion2Value.Text = convertToK.ToString() + '°' + 'K';

            changeTempGauge(convertToF);
        }
        public void convertK(decimal temp)
        {
            decimal convertToF;
           
            decimal convertToC;

            

            convertToF = (temp - 273.15M) * (9 / 5) + 32;
            convertToC = temp - 273.15M;

            lblConversion1Value.Text =convertToF.ToString() + '°'+'F';
            lblConversion2Value.Text = convertToC.ToString() + '°'+'C';

            changeTempGauge(convertToF);

        }

        public void changeTempGauge(decimal tempF)
        {
            if (tempF > 95 )
            {
                ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_hot;
            }
            else if(tempF <=95 && tempF > 75)
            {
                ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_warm;
            }
            else if( tempF <=75 && tempF >= 55)
            {
                ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_mild;
            }
            else if(tempF <55 && tempF >=33)
            {
                ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_cold;
            }
            else if(tempF <33 )
            {
                ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_freezing;
            }
            //else if(numberboxTempValue.Value==null )
           // {
            //    ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_none;
            //}
        }
    }
}
