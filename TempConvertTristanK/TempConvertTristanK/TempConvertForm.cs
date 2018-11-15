/*
 * Created by: Tristan Kalabric
 * Created on: November 15, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Temperature Converter
 * This program converts celcius to farenheight by calling a procedure
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

namespace TempConvertTristanK
{
    public partial class frmTempConvert : Form
    {
        public frmTempConvert()
        {
            InitializeComponent();
        }

        public void ConvertToF(int celcius)
        {
            //Create variables
            double farenheight;
            celcius = Convert.ToInt16(this.txtCelcius.Text);

            //Calculate the temperature in Farenheight
            farenheight = (double) (9) / (double)(5) * celcius + 32;

            //Display temperature in a Messagebox
            MessageBox.Show(celcius + " degrees Celcius is: " + farenheight + " degrees Farenheight");
        }

        private void btnConvertToF_Click(object sender, EventArgs e)
        {
            //Declare local variable
            int userCelcius;

            //Convert the usercelcius to int and assign to variables
            userCelcius = Convert.ToInt16(this.txtCelcius.Text);
            //Call function ConvertToF
            this.ConvertToF(userCelcius);
        }
    }
}
