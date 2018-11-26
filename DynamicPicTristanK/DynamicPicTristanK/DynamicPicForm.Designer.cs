namespace DynamicPicTristanK
{
    partial class frmDynamicPic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblClickOnPic = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClickOnPic
            // 
            this.lblClickOnPic.AutoSize = true;
            this.lblClickOnPic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickOnPic.Location = new System.Drawing.Point(199, 9);
            this.lblClickOnPic.Name = "lblClickOnPic";
            this.lblClickOnPic.Size = new System.Drawing.Size(398, 25);
            this.lblClickOnPic.TabIndex = 0;
            this.lblClickOnPic.Text = "Click on a picture to make the man walk.";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(332, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = global::DynamicPicTristanK.Properties.Resources.walk10;
            this.PictureBox.Location = new System.Drawing.Point(577, 241);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(100, 115);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 2;
            this.PictureBox.TabStop = false;
            this.PictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDynamicPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 562);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblClickOnPic);
            this.Name = "frmDynamicPic";
            this.Text = "Dynamic Pictureboxes";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClickOnPic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

