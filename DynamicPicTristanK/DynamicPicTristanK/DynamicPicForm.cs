/*
 * Created by: Tristan Kalabric
 * Created on: November 23, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Name of Program
 * This program lets the user click on a picture box and make it seem like the man is moving
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
using System.Threading;

namespace DynamicPicTristanK
{
    public partial class frmDynamicPic : Form
    {

        private void GeneratePictureBoxes()
        {
            //Generate each of the picture boxes on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);

        }

        private void GeneratePictureBox(int x, int y)
        {
            //Dynamically generate a new picture box and a new point at the given location(x,y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //Set the location of the picture box
            tmpPicMan.Location = pntPic;

            //Assign the image to the picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            //Stretch the image to the size of the picture box
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //Make the picture box width and height to be the same a the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //Add the event listener
            tmpPicMan.Click += new System.EventHandler(pictureBox1_Click);

            //Add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }



        public frmDynamicPic()
        {
            InitializeComponent();
            lblClickOnPic.Hide();
            PictureBox.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Display label
            lblClickOnPic.Show();

            //Generate the picture boxes with their event listeners
            GeneratePictureBoxes();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Cast the sender object into a picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            //Write a message to the console to check which picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //Declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //Continue this loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }
                //Incement counter by 1
                pictureFrameCounter = pictureFrameCounter + 1;
                this.Refresh();

                //Pause the loop for 100 milliseconds
                Thread.Sleep(100);
            }
        }
    }
    }

