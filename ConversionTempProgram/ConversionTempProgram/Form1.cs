/*
Author: Quentin Thomas

Program Title: <Tempature Converter Program>

File Description:

                In this program you will be able to convert Fahrenheit to Celsius
                and Kelvin, convert Celsius to Fahrenheit and Kelvin, and convert
                Kelvin to Fahrenheit and Celsius. As well as if a certain tempature
                is calculated, a picture will show if it is freezing, cold, mild, warm,
                or hot.
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

namespace ConversionTempProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal Fah_Cel;
            decimal Fah_Kel;

            decimal Cel_Fah;
            decimal Cel_Kel;

            decimal Kel_Fah;
            decimal Kel_Cel;

            Fah_Cel = (numberboxTempValue.Value - 32M) * (5M / 9M);
            Fah_Kel = (numberboxTempValue.Value + 273.15M);

            Cel_Fah = (numberboxTempValue.Value * (9M / 5M) + 32);
            Cel_Kel = (numberboxTempValue.Value + 273.15M);

            Kel_Fah = (numberboxTempValue.Value - 273.15M) * 9M / 5M + 32;
            Kel_Cel = (numberboxTempValue.Value - 273.15M);

            if (comboUnits.Text == "Fahrenheit")
           {
               lblConversion1Value.Text = String.Format("{0:F2}", Fah_Cel) + " Celsius";
               lblConversion2Value.Text = String.Format("{0:F2}", Fah_Kel) + " Kelvin";
           }
           else if (comboUnits.Text == "Celsius")
           {
                lblConversion1Value.Text = String.Format("{0:F2}", Cel_Fah) + " Fahrenheit";
                lblConversion2Value.Text = String.Format("{0:F2}", Cel_Kel) + " Kelvin";
           }
           else if (comboUnits.Text == "Kelvin")
           {
               lblConversion1Value.Text = String.Format("{0:F2}", Kel_Fah) + " Fahrenheit";
               lblConversion2Value.Text = String.Format("{0:F2}", Kel_Cel) + " Celsius";
           }


        }

        private void numberboxTempValue_ValueChanged(object sender, EventArgs e)
        {

            if (numberboxTempValue.Value > 94)
            {
                imageTempGuage.Image = Properties.Resources.hot_temp;
            }
            else if (numberboxTempValue.Value > 74)
            {
                imageTempGuage.Image = Properties.Resources.warm_temp;
            }
            else if (numberboxTempValue.Value > 54)
            {
                imageTempGuage.Image = Properties.Resources.mild_temp;
            }
            else if (numberboxTempValue.Value > 32)
            {
                imageTempGuage.Image = Properties.Resources.cold_temp;
            }
            else if (numberboxTempValue.Value < 31)
            {
                imageTempGuage.Image = Properties.Resources.freezing_temp;
            }
           

        }
    }
}
