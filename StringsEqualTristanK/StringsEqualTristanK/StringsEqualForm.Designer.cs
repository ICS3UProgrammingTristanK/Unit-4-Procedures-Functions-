namespace StringsEqualTristanK
{
    partial class frmStringsEqual
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
            this.lblEnterStrings = new System.Windows.Forms.Label();
            this.lblCaseDoesntMatter = new System.Windows.Forms.Label();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterStrings
            // 
            this.lblEnterStrings.AutoSize = true;
            this.lblEnterStrings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterStrings.Location = new System.Drawing.Point(12, 9);
            this.lblEnterStrings.Name = "lblEnterStrings";
            this.lblEnterStrings.Size = new System.Drawing.Size(280, 20);
            this.lblEnterStrings.TabIndex = 0;
            this.lblEnterStrings.Text = "Enter 2 strings to see if they are equal.";
            // 
            // lblCaseDoesntMatter
            // 
            this.lblCaseDoesntMatter.AutoSize = true;
            this.lblCaseDoesntMatter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaseDoesntMatter.Location = new System.Drawing.Point(12, 38);
            this.lblCaseDoesntMatter.Name = "lblCaseDoesntMatter";
            this.lblCaseDoesntMatter.Size = new System.Drawing.Size(166, 20);
            this.lblCaseDoesntMatter.TabIndex = 1;
            this.lblCaseDoesntMatter.Text = "(Case doesn\'t matter.)";
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString1.Location = new System.Drawing.Point(12, 88);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(68, 20);
            this.lblString1.TabIndex = 2;
            this.lblString1.Text = "String 1:";
            this.lblString1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(12, 130);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(68, 20);
            this.lblString2.TabIndex = 3;
            this.lblString2.Text = "String 2:";
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(86, 130);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(191, 20);
            this.txtString2.TabIndex = 4;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(86, 88);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(191, 20);
            this.txtString1.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(115, 169);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(80, 40);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // frmStringsEqual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 232);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.lblCaseDoesntMatter);
            this.Controls.Add(this.lblEnterStrings);
            this.Name = "frmStringsEqual";
            this.Text = "Strings Are Equal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterStrings;
        private System.Windows.Forms.Label lblCaseDoesntMatter;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Button btnCheck;
    }
}

