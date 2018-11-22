﻿/*
 * Created by: Tristan Kalabric
 * Created on: November 22, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program converts the users grade level to a percent and displays it in a messagebox
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

namespace PercentTristanK
{
    public partial class frmPercent : Form
    {
        public frmPercent()
        {
            InitializeComponent();
        }

        private int ConvertPercent(String level)
        {
            int percentage;

            switch (level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 85;
                    break;
                case "4-":
                    percentage = 80;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                case "0----":
                    percentage = 10;
                    break;
                default:
                    percentage = -1;
                    break;
            }

            return percentage;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declare variables
            String userLevel;
            int userPercentage;

            //Get the users grade and percentage
            userLevel = this.txtGrade.Text;
            userPercentage = this.ConvertPercent(userLevel);

            //Display messagebox
            MessageBox.Show("Level " + userLevel + " is equal to: " + userPercentage + "%");
        }
    }
}
