namespace Exam1
{
    partial class Login
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
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.passowrdTextbox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(260, 111);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(263, 20);
            this.loginTextbox.TabIndex = 0;
            // 
            // passowrdTextbox
            // 
            this.passowrdTextbox.Location = new System.Drawing.Point(260, 255);
            this.passowrdTextbox.Name = "passowrdTextbox";
            this.passowrdTextbox.Size = new System.Drawing.Size(263, 20);
            this.passowrdTextbox.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(377, 82);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(35, 13);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "label1";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(377, 224);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(35, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "label2";
            // 
            // usernameErrorLbl
            // 
            this.usernameErrorLbl.AutoSize = true;
            this.usernameErrorLbl.Location = new System.Drawing.Point(377, 134);
            this.usernameErrorLbl.Name = "usernameErrorLbl";
            this.usernameErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.usernameErrorLbl.TabIndex = 4;
            this.usernameErrorLbl.Text = "label1";
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Location = new System.Drawing.Point(377, 278);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.passwordErrorLbl.TabIndex = 5;
            this.passwordErrorLbl.Text = "label1";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(321, 367);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(158, 23);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "button1";
            this.loginBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.usernameErrorLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.passowrdTextbox);
            this.Controls.Add(this.loginTextbox);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.TextBox passowrdTextbox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameErrorLbl;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.Button loginBtn;
    }
}