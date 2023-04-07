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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.usernameErrorLbl = new System.Windows.Forms.Label();
            this.passwordErrorLbl = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.createAccountLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(369, 44);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(35, 13);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "label1";
            this.usernameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(268, 71);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(249, 20);
            this.usernameTextbox.TabIndex = 1;
            // 
            // usernameErrorLbl
            // 
            this.usernameErrorLbl.AutoSize = true;
            this.usernameErrorLbl.Location = new System.Drawing.Point(369, 109);
            this.usernameErrorLbl.Name = "usernameErrorLbl";
            this.usernameErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.usernameErrorLbl.TabIndex = 2;
            this.usernameErrorLbl.Text = "label1";
            // 
            // passwordErrorLbl
            // 
            this.passwordErrorLbl.AutoSize = true;
            this.passwordErrorLbl.Location = new System.Drawing.Point(369, 213);
            this.passwordErrorLbl.Name = "passwordErrorLbl";
            this.passwordErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.passwordErrorLbl.TabIndex = 5;
            this.passwordErrorLbl.Text = "label1";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(268, 175);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(249, 20);
            this.passwordTextbox.TabIndex = 4;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(369, 148);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(35, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "label1";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(268, 273);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(249, 50);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "button1";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLbl.Location = new System.Drawing.Point(369, 213);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(35, 13);
            this.errorLbl.TabIndex = 7;
            this.errorLbl.Text = "label1";
            // 
            // createAccountLbl
            // 
            this.createAccountLbl.AutoSize = true;
            this.createAccountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createAccountLbl.Location = new System.Drawing.Point(369, 343);
            this.createAccountLbl.Name = "createAccountLbl";
            this.createAccountLbl.Size = new System.Drawing.Size(35, 13);
            this.createAccountLbl.TabIndex = 8;
            this.createAccountLbl.Text = "label1";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccountLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordErrorLbl);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameErrorLbl);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.usernameLbl);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label usernameErrorLbl;
        private System.Windows.Forms.Label passwordErrorLbl;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Label createAccountLbl;
    }
}

