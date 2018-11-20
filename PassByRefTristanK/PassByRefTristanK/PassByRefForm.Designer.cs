namespace PassByRefTristanK
{
    partial class frmPassByRef
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
            this.lblEnterNumber = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lblDecimalMunber = new System.Windows.Forms.Label();
            this.nudDecimalNumber = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterNumber
            // 
            this.lblEnterNumber.AutoSize = true;
            this.lblEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumber.Location = new System.Drawing.Point(12, 32);
            this.lblEnterNumber.Name = "lblEnterNumber";
            this.lblEnterNumber.Size = new System.Drawing.Size(204, 20);
            this.lblEnterNumber.TabIndex = 0;
            this.lblEnterNumber.Text = "Enter a decimal number:";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(222, 34);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(111, 20);
            this.txtUserNumber.TabIndex = 1;
            // 
            // lblDecimalMunber
            // 
            this.lblDecimalMunber.AutoSize = true;
            this.lblDecimalMunber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimalMunber.Location = new System.Drawing.Point(12, 87);
            this.lblDecimalMunber.Name = "lblDecimalMunber";
            this.lblDecimalMunber.Size = new System.Drawing.Size(373, 18);
            this.lblDecimalMunber.TabIndex = 2;
            this.lblDecimalMunber.Text = "How many decimals would you like to round to?:";
            // 
            // nudDecimalNumber
            // 
            this.nudDecimalNumber.Location = new System.Drawing.Point(395, 89);
            this.nudDecimalNumber.Name = "nudDecimalNumber";
            this.nudDecimalNumber.Size = new System.Drawing.Size(120, 20);
            this.nudDecimalNumber.TabIndex = 3;
            // 
            // btnRound
            // 
            this.btnRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRound.Location = new System.Drawing.Point(197, 140);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(136, 39);
            this.btnRound.TabIndex = 4;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 281);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.nudDecimalNumber);
            this.Controls.Add(this.lblDecimalMunber);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.lblEnterNumber);
            this.Name = "frmPassByRef";
            this.Text = "Pass By Reference";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimalNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterNumber;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label lblDecimalMunber;
        private System.Windows.Forms.NumericUpDown nudDecimalNumber;
        private System.Windows.Forms.Button btnRound;
    }
}

