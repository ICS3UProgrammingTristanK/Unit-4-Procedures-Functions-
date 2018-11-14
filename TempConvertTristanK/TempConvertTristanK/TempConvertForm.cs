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
            double Farenheight;
            double celcius;

            //Calculate the temperature in Farenheight
            Farenheight = (double) (9) / (double)(5) * celcius + 32;

            //Display temperature in a Messagebox
            MessageBox.Show(celcius + "degrees Celcius is: " + Farenheight + "degrees Farenheight");
        }

        private void btnConvertToF_Click(object sender, EventArgs e)
        {
            //Declare local variable
            int userCelcius;

            //Convert the usercelcius to int and assign to variables
            userCelcius = Convert.ToInt16(this.txtCelcius.Text);
            //Call function
            this.ConvertToF(celcius);
        }
    }
}
