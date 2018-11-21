/*
 * Created by: Tristan Kalabric
 * Created on: November 21, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program displays the users address that they input by using multiple procedures with the same name 
 * but different arguments
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

namespace AddressTristanK
{
    public partial class frmAddress : Form
    {
        public frmAddress()
        {
            InitializeComponent();
        }

        public void PrintAddress(String aptNumber,String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your Address Is: " + aptNumber + " " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        public void PrintAddress(String streetAddress, String city, String province, String postalCode)
        {
            MessageBox.Show("Your Address Is: " + streetAddress + " " + city + " " + province + " " + postalCode);
        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            //Declare local variables
            String userAptNumber,userStreetAddress, userCity, userProvince, userPostalCode;

            //Get the apt number, address, city, province, and postal code from the textboxes
            userAptNumber = this.txtAptNumber.Text;
            userStreetAddress = this.txtStreetAddress.Text;
            userCity = this.txtCity.Text;
            userProvince = this.txtProvince.Text;
            userPostalCode = this.txtPostalCode.Text;

            //make the user enter a street address
            if (userStreetAddress == "")
            {
                MessageBox.Show("Please enter your street address.");
            }
            //Make the user enter a city
            else if (userCity == "")
            {
                MessageBox.Show("Please enter your city.");
            }
            //Make the user enter a province
            else if (userProvince == "")
            {
                MessageBox.Show("Please enter your province.");
            }
            //make the user enter a postal code
            else if (userPostalCode == "")
            {
                MessageBox.Show("Please enter your postal code.");
            }
            //if the user doesnt enter an apt number, call the procedure that doesnt need the apt number
            else if(userAptNumber == "")
            {
                PrintAddress(userStreetAddress, userCity, userProvince, userPostalCode);
            }
            //If the user entered everything call the ither procedure
            else
            {
                PrintAddress(userAptNumber, userStreetAddress, userCity, userProvince, userPostalCode);
            }
        }
    }
}
