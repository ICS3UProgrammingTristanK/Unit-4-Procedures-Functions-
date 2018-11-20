using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefTristanK
{
    public partial class frmPassByRef : Form
    {
        public frmPassByRef()
        {
            InitializeComponent();
        }

        private void RoundDecimal(ref double numberUsed, int numberDecimals)
        {
            //Multiply by 10 to the power of the number of decimals
            numberUsed = (numberUsed) * Math.Pow(10, numberDecimals);
            //Add 0.5
            numberUsed = numberUsed + 0.5;
            //Get rid of the numbers following the decimal
            numberUsed = Math.Truncate(numberUsed);
            //Move the decimal back to its original place
            numberUsed = numberUsed / Math.Pow(10, numberDecimals);
            //Display messagebox
            MessageBox.Show("The rounded number is: " + numberUsed);

        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Declare variables
            double userNumber;
            int userNumbDecimals;

            //Get the number and the number of decimals from the textfield
            userNumbDecimals = Convert.ToInt16(this.nudDecimalNumber.Value);
            userNumber = Convert.ToDouble(this.txtUserNumber.Text);

            //Call the procedure
            this.RoundDecimal(ref userNumber, userNumbDecimals);
        }
    }
}
