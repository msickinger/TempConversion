/*

Author: Megan Sickinger

Program Title: Test 2 : Temperature Conversion

File Description:

<Convert each temperature as the user changes the value and type of conversion.>

*/


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
            //load with no temperature displayed for gauge
            ImageTempGauge.Image = TempConversion.Properties.Resources.temperaturegauge_none;
        }

        decimal temp;
       
        private void numberboxTempValue_ValueChanged(object sender, EventArgs e)
        {
            temp = numberboxTempValue.Value;
         
            //check which type in order to convert to others
                if (comboUnits.SelectedItem.ToString() == "Fahrenheit")
                {
                    convertF(temp);

                }
                else if (comboUnits.SelectedItem.ToString() == "Celsius")
                {
                    convertC(temp);
                }
                else if (comboUnits.SelectedItem.ToString() == "Kelvin")
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
                    catch (Exception ex) //if kelvin is below 0 show error message
                    {
                        MessageBox.Show(ex.Message);
                        numberboxTempValue.Value = 0;//switch value to 0
                    }
                }
            
            
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void convertF(decimal temp) //converting fahrenheit to celsius and kelvin
        {
            decimal convertToC;
            decimal convertToK;
            //for some unknown reason, when i use the formula 5/9*(temp-32) the label text does not change!
            convertToC =temp*5/9-160/9;
            convertToK = convertToC+273.15M;

            lblConversion1Value.Text = convertToC.ToString("0.00") + '°' + 'C';
            lblConversion2Value.Text = convertToK.ToString("0.00") + '°' + 'K';

            changeTempGauge(temp);
        }

        public void convertC(decimal temp)//convert celsius to fahrenheit and kelvin
        {
            decimal convertToF =0M;
            decimal convertToK = 0M;
            MessageBox.Show(temp.ToString());
            convertToK = temp + 273.15M;
            convertToF = (temp *9 / 5) + 32;

            lblConversion1Value.Text = convertToF.ToString("0.00") + '°' + 'F';
            lblConversion2Value.Text = convertToK.ToString("0.00") + '°' + 'K';

            changeTempGauge(convertToF);
        }
        public void convertK(decimal temp)//convert kelvin to celsius and fahrenheit
        {
            decimal convertToF;
           
            decimal convertToC;
           
            convertToC = temp - 273.15M;
            convertToF =( convertToC *9 / 5) + 32;

            lblConversion1Value.Text =convertToF.ToString("0.00") + '°'+'F';
            lblConversion2Value.Text = convertToC.ToString("0.00") + '°'+'C';

            changeTempGauge(convertToF);

        }

        public void changeTempGauge(decimal tempF)//change the image of temp gauge when temp changes
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
