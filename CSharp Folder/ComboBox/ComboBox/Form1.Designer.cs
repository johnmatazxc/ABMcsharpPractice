namespace ComboBox
{
    partial class form
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
            this.areaBox = new System.Windows.Forms.ComboBox();
            this.provinceBox = new System.Windows.Forms.ComboBox();
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.countryLBl = new System.Windows.Forms.Label();
            this.provinceLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // areaBox
            // 
            this.areaBox.FormattingEnabled = true;
            this.areaBox.Location = new System.Drawing.Point(93, 158);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(121, 21);
            this.areaBox.TabIndex = 0;
            this.areaBox.Text = "--Select Country--";
            this.areaBox.SelectedIndexChanged += new System.EventHandler(this.areaBox_SelectedIndexChanged);
            // 
            // provinceBox
            // 
            this.provinceBox.FormattingEnabled = true;
            this.provinceBox.Location = new System.Drawing.Point(328, 158);
            this.provinceBox.Name = "provinceBox";
            this.provinceBox.Size = new System.Drawing.Size(121, 21);
            this.provinceBox.TabIndex = 1;
            this.provinceBox.Text = "--Select Province--";
            this.provinceBox.SelectedIndexChanged += new System.EventHandler(this.provinceBox_SelectedIndexChanged);
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(578, 158);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 21);
            this.cityBox.TabIndex = 2;
            this.cityBox.Text = "--Select City--";
            // 
            // countryLBl
            // 
            this.countryLBl.AutoSize = true;
            this.countryLBl.Location = new System.Drawing.Point(93, 123);
            this.countryLBl.Name = "countryLBl";
            this.countryLBl.Size = new System.Drawing.Size(35, 13);
            this.countryLBl.TabIndex = 3;
            this.countryLBl.Text = "label1";
            // 
            // provinceLbl
            // 
            this.provinceLbl.AutoSize = true;
            this.provinceLbl.Location = new System.Drawing.Point(328, 122);
            this.provinceLbl.Name = "provinceLbl";
            this.provinceLbl.Size = new System.Drawing.Size(35, 13);
            this.provinceLbl.TabIndex = 4;
            this.provinceLbl.Text = "label1";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(578, 121);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(35, 13);
            this.cityLbl.TabIndex = 5;
            this.cityLbl.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.provinceLbl);
            this.Controls.Add(this.countryLBl);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.provinceBox);
            this.Controls.Add(this.areaBox);
            this.Name = "form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox areaBox;
        private System.Windows.Forms.ComboBox provinceBox;
        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.Label countryLBl;
        private System.Windows.Forms.Label provinceLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Button button1;
    }
}

