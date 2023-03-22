namespace LoginForm
{
    partial class Form1
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
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.userErrorLbl = new System.Windows.Forms.Label();
            this.passErrorLbl = new System.Windows.Forms.Label();
            this.forgotPassLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.forgotPassLbl);
            this.panel1.Controls.Add(this.passErrorLbl);
            this.panel1.Controls.Add(this.userErrorLbl);
            this.panel1.Controls.Add(this.submit);
            this.panel1.Controls.Add(this.passTxtBox);
            this.panel1.Controls.Add(this.userTxtBox);
            this.panel1.Controls.Add(this.passwordLbl);
            this.panel1.Controls.Add(this.usernameLbl);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 426);
            this.panel1.TabIndex = 1;
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(49, 140);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(324, 20);
            this.userTxtBox.TabIndex = 3;
            this.userTxtBox.TextChanged += new System.EventHandler(this.userTxtBox_TextChanged);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(179, 210);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(35, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "label1";
            this.passwordLbl.Click += new System.EventHandler(this.passwordLbl_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(179, 96);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(35, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "label1";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(179, 26);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(35, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "label1";
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(49, 252);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(324, 20);
            this.passTxtBox.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(78, 319);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(251, 44);
            this.submit.TabIndex = 5;
            this.submit.Text = "button1";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // userErrorLbl
            // 
            this.userErrorLbl.AutoSize = true;
            this.userErrorLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.userErrorLbl.Location = new System.Drawing.Point(182, 167);
            this.userErrorLbl.Name = "userErrorLbl";
            this.userErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.userErrorLbl.TabIndex = 6;
            this.userErrorLbl.Text = "label1";
            // 
            // passErrorLbl
            // 
            this.passErrorLbl.AutoSize = true;
            this.passErrorLbl.ForeColor = System.Drawing.Color.IndianRed;
            this.passErrorLbl.Location = new System.Drawing.Point(182, 279);
            this.passErrorLbl.Name = "passErrorLbl";
            this.passErrorLbl.Size = new System.Drawing.Size(35, 13);
            this.passErrorLbl.TabIndex = 7;
            this.passErrorLbl.Text = "label1";
            // 
            // forgotPassLbl
            // 
            this.forgotPassLbl.AutoSize = true;
            this.forgotPassLbl.Location = new System.Drawing.Point(311, 279);
            this.forgotPassLbl.Name = "forgotPassLbl";
            this.forgotPassLbl.Size = new System.Drawing.Size(35, 13);
            this.forgotPassLbl.TabIndex = 8;
            this.forgotPassLbl.Text = "label1";
            this.forgotPassLbl.Click += new System.EventHandler(this.forgotPassLbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label passErrorLbl;
        private System.Windows.Forms.Label userErrorLbl;
        private System.Windows.Forms.Label forgotPassLbl;
    }
}

