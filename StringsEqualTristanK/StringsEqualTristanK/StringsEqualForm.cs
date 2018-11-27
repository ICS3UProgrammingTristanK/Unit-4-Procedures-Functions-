/*
 * Created by: Tristan Kalabric
 * Created on: November 27, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks if the 2 strings the user enters are equal to each other.
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

namespace StringsEqualTristanK
{
    public partial class frmStringsEqual : Form
    {
        public frmStringsEqual()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Set variables
            string userString1 = txtString1.Text;
            string userString2 = txtString2.Text;

            if (StringsAreEqual(userString1, userString2))
            {
                MessageBox.Show(userString1 + " and " + userString2 + " are equal.");
            }
            else
            {
                MessageBox.Show(userString1 + " and " + userString2 + " are not equal.");
            }
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            bool isEqual = false;

            if (string1 == string2)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

            return isEqual;
        }
    }
}
