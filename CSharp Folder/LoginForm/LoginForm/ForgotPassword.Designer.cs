namespace LoginForm
{
    partial class ForgotPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.confirmPassLbl = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmErrorLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmErrorLbl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.userTextBox);
            this.panel1.Controls.Add(this.confirmTextBox);
            this.panel1.Controls.Add(this.passTextBox);
            this.panel1.Controls.Add(this.confirmPassLbl);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 426);
            this.panel1.TabIndex = 0;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(48, 31);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(35, 13);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "label1";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(51, 115);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(35, 13);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "label2";
            // 
            // confirmPassLbl
            // 
            this.confirmPassLbl.AutoSize = true;
            this.confirmPassLbl.Location = new System.Drawing.Point(51, 206);
            this.confirmPassLbl.Name = "confirmPassLbl";
            this.confirmPassLbl.Size = new System.Drawing.Size(35, 13);
            this.confirmPassLbl.TabIndex = 2;
            this.confirmPassLbl.Text = "label3";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(51, 148);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(283, 20);
            this.passTextBox.TabIndex = 3;
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.Location = new System.Drawing.Point(51, 242);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(283, 20);
            this.confirmTextBox.TabIndex = 4;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(51, 63);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(283, 20);
            this.userTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(185, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmErrorLbl
            // 
            this.confirmErrorLbl.AutoSize = true;
            this.confirmErrorLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.confirmErrorLbl.Location = new System.Drawing.Point(54, 269);
            this.confirmErrorLbl.Name = "confirmErrorLbl";
            this.confirmErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.confirmErrorLbl.TabIndex = 7;
            this.confirmErrorLbl.Text = "label1";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label confirmPassLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label confirmErrorLbl;
    }
}