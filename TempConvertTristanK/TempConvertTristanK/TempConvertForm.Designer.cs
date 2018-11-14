namespace TempConvertTristanK
{
    partial class frmTempConvert
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
            this.lblEnterCelcius = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.btnConvertToF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterCelcius
            // 
            this.lblEnterCelcius.AutoSize = true;
            this.lblEnterCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCelcius.Location = new System.Drawing.Point(3, 30);
            this.lblEnterCelcius.Name = "lblEnterCelcius";
            this.lblEnterCelcius.Size = new System.Drawing.Size(253, 24);
            this.lblEnterCelcius.TabIndex = 0;
            this.lblEnterCelcius.Text = "Enter degrees in Celcius: ";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(262, 35);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 20);
            this.txtCelcius.TabIndex = 1;
            // 
            // btnConvertToF
            // 
            this.btnConvertToF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertToF.Location = new System.Drawing.Point(54, 86);
            this.btnConvertToF.Name = "btnConvertToF";
            this.btnConvertToF.Size = new System.Drawing.Size(275, 33);
            this.btnConvertToF.TabIndex = 2;
            this.btnConvertToF.Text = "Convert To Farenheight";
            this.btnConvertToF.UseVisualStyleBackColor = true;
            this.btnConvertToF.Click += new System.EventHandler(this.btnConvertToF_Click);
            // 
            // frmTempConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 213);
            this.Controls.Add(this.btnConvertToF);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.lblEnterCelcius);
            this.Name = "frmTempConvert";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterCelcius;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Button btnConvertToF;
    }
}

