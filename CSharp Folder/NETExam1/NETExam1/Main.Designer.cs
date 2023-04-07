namespace NETExam1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.File = new System.Windows.Forms.ToolStripDropDownButton();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInsertStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeUpdateStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDeleteStip = new System.Windows.Forms.ToolStripMenuItem();
            this.customerStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.customerUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.numTextbox = new System.Windows.Forms.TextBox();
            this.numLbl = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailError = new System.Windows.Forms.Label();
            this.numError = new System.Windows.Forms.Label();
            this.addressError = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.Label();
            this.idError = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.empEmailError = new System.Windows.Forms.Label();
            this.empIdLbl = new System.Windows.Forms.Label();
            this.empSalaryError = new System.Windows.Forms.Label();
            this.empIdTextbox = new System.Windows.Forms.TextBox();
            this.empPositionError = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.empNameError = new System.Windows.Forms.Label();
            this.empPositionTextbox = new System.Windows.Forms.TextBox();
            this.empIdError = new System.Windows.Forms.Label();
            this.empEmailTextbox = new System.Windows.Forms.TextBox();
            this.empNameLbl = new System.Windows.Forms.Label();
            this.empEmailLbl = new System.Windows.Forms.Label();
            this.empNameTextbox = new System.Windows.Forms.TextBox();
            this.empSalaryTextbox = new System.Windows.Forms.TextBox();
            this.empPositionLbl = new System.Windows.Forms.Label();
            this.empSalaryLbl = new System.Windows.Forms.Label();
            this.employeeSelectStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.customerSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(865, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // File
            // 
            this.File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.customerStripMenuItem,
            this.exitToolStripMenuItem});
            this.File.Image = ((System.Drawing.Image)(resources.GetObject("File.Image")));
            this.File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(38, 22);
            this.File.Text = "File";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeSelectStrip,
            this.employeeInsertStrip,
            this.employeeUpdateStrip,
            this.employeeDeleteStip});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeInsertStrip
            // 
            this.employeeInsertStrip.Name = "employeeInsertStrip";
            this.employeeInsertStrip.Size = new System.Drawing.Size(180, 22);
            this.employeeInsertStrip.Text = "Insert";
            this.employeeInsertStrip.Click += new System.EventHandler(this.employeeInsertStrip_Click);
            // 
            // employeeUpdateStrip
            // 
            this.employeeUpdateStrip.Name = "employeeUpdateStrip";
            this.employeeUpdateStrip.Size = new System.Drawing.Size(180, 22);
            this.employeeUpdateStrip.Text = "Update";
            this.employeeUpdateStrip.Click += new System.EventHandler(this.employeeUpdateStrip_Click);
            // 
            // employeeDeleteStip
            // 
            this.employeeDeleteStip.Name = "employeeDeleteStip";
            this.employeeDeleteStip.Size = new System.Drawing.Size(180, 22);
            this.employeeDeleteStip.Text = "Delete";
            this.employeeDeleteStip.Click += new System.EventHandler(this.employeeDeleteStip_Click);
            // 
            // customerStripMenuItem
            // 
            this.customerStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerSelect,
            this.customerInsert,
            this.customerUpdate,
            this.customerDelete});
            this.customerStripMenuItem.Name = "customerStripMenuItem";
            this.customerStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customerStripMenuItem.Text = "Customer";
            // 
            // customerInsert
            // 
            this.customerInsert.Name = "customerInsert";
            this.customerInsert.Size = new System.Drawing.Size(180, 22);
            this.customerInsert.Text = "Insert";
            this.customerInsert.Click += new System.EventHandler(this.customerInsert_Click);
            // 
            // customerUpdate
            // 
            this.customerUpdate.Name = "customerUpdate";
            this.customerUpdate.Size = new System.Drawing.Size(180, 22);
            this.customerUpdate.Text = "Update";
            this.customerUpdate.Click += new System.EventHandler(this.customerUpdate_Click);
            // 
            // customerDelete
            // 
            this.customerDelete.Name = "customerDelete";
            this.customerDelete.Size = new System.Drawing.Size(180, 22);
            this.customerDelete.Text = "Delete";
            this.customerDelete.Click += new System.EventHandler(this.customerDelete_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(26, 80);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(35, 13);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "label1";
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(94, 80);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(100, 20);
            this.nameTextbox.TabIndex = 2;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(94, 106);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 20);
            this.addressTextbox.TabIndex = 4;
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(26, 106);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(35, 13);
            this.addressLbl.TabIndex = 3;
            this.addressLbl.Text = "label1";
            // 
            // numTextbox
            // 
            this.numTextbox.Location = new System.Drawing.Point(94, 132);
            this.numTextbox.Name = "numTextbox";
            this.numTextbox.Size = new System.Drawing.Size(100, 20);
            this.numTextbox.TabIndex = 6;
            // 
            // numLbl
            // 
            this.numLbl.AutoSize = true;
            this.numLbl.Location = new System.Drawing.Point(26, 132);
            this.numLbl.Name = "numLbl";
            this.numLbl.Size = new System.Drawing.Size(35, 13);
            this.numLbl.TabIndex = 5;
            this.numLbl.Text = "label1";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(94, 158);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(100, 20);
            this.emailTextbox.TabIndex = 8;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(26, 158);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 7;
            this.emailLbl.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.emailError);
            this.panel1.Controls.Add(this.numError);
            this.panel1.Controls.Add(this.addressError);
            this.panel1.Controls.Add(this.nameError);
            this.panel1.Controls.Add(this.idError);
            this.panel1.Controls.Add(this.idLbl);
            this.panel1.Controls.Add(this.idTextbox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addressTextbox);
            this.panel1.Controls.Add(this.emailTextbox);
            this.panel1.Controls.Add(this.nameLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.nameTextbox);
            this.panel1.Controls.Add(this.numTextbox);
            this.panel1.Controls.Add(this.addressLbl);
            this.panel1.Controls.Add(this.numLbl);
            this.panel1.Location = new System.Drawing.Point(517, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 294);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // emailError
            // 
            this.emailError.AutoSize = true;
            this.emailError.Location = new System.Drawing.Point(221, 158);
            this.emailError.Name = "emailError";
            this.emailError.Size = new System.Drawing.Size(35, 13);
            this.emailError.TabIndex = 16;
            this.emailError.Text = "label1";
            // 
            // numError
            // 
            this.numError.AutoSize = true;
            this.numError.Location = new System.Drawing.Point(221, 132);
            this.numError.Name = "numError";
            this.numError.Size = new System.Drawing.Size(35, 13);
            this.numError.TabIndex = 15;
            this.numError.Text = "label1";
            // 
            // addressError
            // 
            this.addressError.AutoSize = true;
            this.addressError.Location = new System.Drawing.Point(221, 106);
            this.addressError.Name = "addressError";
            this.addressError.Size = new System.Drawing.Size(35, 13);
            this.addressError.TabIndex = 14;
            this.addressError.Text = "label1";
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Location = new System.Drawing.Point(221, 80);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(35, 13);
            this.nameError.TabIndex = 13;
            this.nameError.Text = "label1";
            // 
            // idError
            // 
            this.idError.AutoSize = true;
            this.idError.Location = new System.Drawing.Point(221, 54);
            this.idError.Name = "idError";
            this.idError.Size = new System.Drawing.Size(35, 13);
            this.idError.TabIndex = 12;
            this.idError.Text = "label1";
            this.idError.Click += new System.EventHandler(this.label1_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(26, 54);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(35, 13);
            this.idLbl.TabIndex = 10;
            this.idLbl.Text = "label1";
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(94, 54);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(100, 20);
            this.idTextbox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(29, 172);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(443, 150);
            this.customerDataGridView.TabIndex = 10;
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Location = new System.Drawing.Point(29, 172);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(443, 150);
            this.employeeDataGridView.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.empEmailError);
            this.panel2.Controls.Add(this.empIdLbl);
            this.panel2.Controls.Add(this.empSalaryError);
            this.panel2.Controls.Add(this.empIdTextbox);
            this.panel2.Controls.Add(this.empPositionError);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.empNameError);
            this.panel2.Controls.Add(this.empPositionTextbox);
            this.panel2.Controls.Add(this.empIdError);
            this.panel2.Controls.Add(this.empEmailTextbox);
            this.panel2.Controls.Add(this.empNameLbl);
            this.panel2.Controls.Add(this.empEmailLbl);
            this.panel2.Controls.Add(this.empNameTextbox);
            this.panel2.Controls.Add(this.empSalaryTextbox);
            this.panel2.Controls.Add(this.empPositionLbl);
            this.panel2.Controls.Add(this.empSalaryLbl);
            this.panel2.Location = new System.Drawing.Point(514, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 294);
            this.panel2.TabIndex = 12;
            // 
            // empEmailError
            // 
            this.empEmailError.AutoSize = true;
            this.empEmailError.Location = new System.Drawing.Point(220, 158);
            this.empEmailError.Name = "empEmailError";
            this.empEmailError.Size = new System.Drawing.Size(35, 13);
            this.empEmailError.TabIndex = 21;
            this.empEmailError.Text = "label1";
            // 
            // empIdLbl
            // 
            this.empIdLbl.AutoSize = true;
            this.empIdLbl.Location = new System.Drawing.Point(26, 54);
            this.empIdLbl.Name = "empIdLbl";
            this.empIdLbl.Size = new System.Drawing.Size(35, 13);
            this.empIdLbl.TabIndex = 10;
            this.empIdLbl.Text = "label1";
            // 
            // empSalaryError
            // 
            this.empSalaryError.AutoSize = true;
            this.empSalaryError.Location = new System.Drawing.Point(220, 132);
            this.empSalaryError.Name = "empSalaryError";
            this.empSalaryError.Size = new System.Drawing.Size(35, 13);
            this.empSalaryError.TabIndex = 20;
            this.empSalaryError.Text = "label1";
            // 
            // empIdTextbox
            // 
            this.empIdTextbox.Location = new System.Drawing.Point(94, 54);
            this.empIdTextbox.Name = "empIdTextbox";
            this.empIdTextbox.Size = new System.Drawing.Size(100, 20);
            this.empIdTextbox.TabIndex = 11;
            // 
            // empPositionError
            // 
            this.empPositionError.AutoSize = true;
            this.empPositionError.Location = new System.Drawing.Point(220, 106);
            this.empPositionError.Name = "empPositionError";
            this.empPositionError.Size = new System.Drawing.Size(35, 13);
            this.empPositionError.TabIndex = 19;
            this.empPositionError.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // empNameError
            // 
            this.empNameError.AutoSize = true;
            this.empNameError.Location = new System.Drawing.Point(220, 80);
            this.empNameError.Name = "empNameError";
            this.empNameError.Size = new System.Drawing.Size(35, 13);
            this.empNameError.TabIndex = 18;
            this.empNameError.Text = "label1";
            // 
            // empPositionTextbox
            // 
            this.empPositionTextbox.Location = new System.Drawing.Point(94, 106);
            this.empPositionTextbox.Name = "empPositionTextbox";
            this.empPositionTextbox.Size = new System.Drawing.Size(100, 20);
            this.empPositionTextbox.TabIndex = 4;
            // 
            // empIdError
            // 
            this.empIdError.AutoSize = true;
            this.empIdError.Location = new System.Drawing.Point(220, 54);
            this.empIdError.Name = "empIdError";
            this.empIdError.Size = new System.Drawing.Size(35, 13);
            this.empIdError.TabIndex = 17;
            this.empIdError.Text = "label1";
            // 
            // empEmailTextbox
            // 
            this.empEmailTextbox.Location = new System.Drawing.Point(94, 158);
            this.empEmailTextbox.Name = "empEmailTextbox";
            this.empEmailTextbox.Size = new System.Drawing.Size(100, 20);
            this.empEmailTextbox.TabIndex = 8;
            // 
            // empNameLbl
            // 
            this.empNameLbl.AutoSize = true;
            this.empNameLbl.Location = new System.Drawing.Point(26, 80);
            this.empNameLbl.Name = "empNameLbl";
            this.empNameLbl.Size = new System.Drawing.Size(35, 13);
            this.empNameLbl.TabIndex = 1;
            this.empNameLbl.Text = "label1";
            // 
            // empEmailLbl
            // 
            this.empEmailLbl.AutoSize = true;
            this.empEmailLbl.Location = new System.Drawing.Point(26, 158);
            this.empEmailLbl.Name = "empEmailLbl";
            this.empEmailLbl.Size = new System.Drawing.Size(35, 13);
            this.empEmailLbl.TabIndex = 7;
            this.empEmailLbl.Text = "label1";
            // 
            // empNameTextbox
            // 
            this.empNameTextbox.Location = new System.Drawing.Point(94, 80);
            this.empNameTextbox.Name = "empNameTextbox";
            this.empNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.empNameTextbox.TabIndex = 2;
            // 
            // empSalaryTextbox
            // 
            this.empSalaryTextbox.Location = new System.Drawing.Point(94, 132);
            this.empSalaryTextbox.Name = "empSalaryTextbox";
            this.empSalaryTextbox.Size = new System.Drawing.Size(100, 20);
            this.empSalaryTextbox.TabIndex = 6;
            // 
            // empPositionLbl
            // 
            this.empPositionLbl.AutoSize = true;
            this.empPositionLbl.Location = new System.Drawing.Point(26, 106);
            this.empPositionLbl.Name = "empPositionLbl";
            this.empPositionLbl.Size = new System.Drawing.Size(35, 13);
            this.empPositionLbl.TabIndex = 3;
            this.empPositionLbl.Text = "label1";
            // 
            // empSalaryLbl
            // 
            this.empSalaryLbl.AutoSize = true;
            this.empSalaryLbl.Location = new System.Drawing.Point(26, 132);
            this.empSalaryLbl.Name = "empSalaryLbl";
            this.empSalaryLbl.Size = new System.Drawing.Size(35, 13);
            this.empSalaryLbl.TabIndex = 5;
            this.empSalaryLbl.Text = "label1";
            // 
            // employeeSelectStrip
            // 
            this.employeeSelectStrip.Name = "employeeSelectStrip";
            this.employeeSelectStrip.Size = new System.Drawing.Size(180, 22);
            this.employeeSelectStrip.Text = "Select";
            this.employeeSelectStrip.Click += new System.EventHandler(this.employeeSelectStrip_Click);
            // 
            // customerSelect
            // 
            this.customerSelect.Name = "customerSelect";
            this.customerSelect.Size = new System.Drawing.Size(180, 22);
            this.customerSelect.Text = "Select";
            this.customerSelect.Click += new System.EventHandler(this.customerSelect_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(98, 119);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(210, 20);
            this.searchBox.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(347, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.employeeDataGridView);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton File;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox numTextbox;
        private System.Windows.Forms.Label numLbl;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInsertStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeUpdateStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeDeleteStip;
        private System.Windows.Forms.ToolStripMenuItem customerStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerInsert;
        private System.Windows.Forms.ToolStripMenuItem customerUpdate;
        private System.Windows.Forms.ToolStripMenuItem customerDelete;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label empIdLbl;
        private System.Windows.Forms.TextBox empIdTextbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox empPositionTextbox;
        private System.Windows.Forms.TextBox empEmailTextbox;
        private System.Windows.Forms.Label empNameLbl;
        private System.Windows.Forms.Label empEmailLbl;
        private System.Windows.Forms.TextBox empNameTextbox;
        private System.Windows.Forms.TextBox empSalaryTextbox;
        private System.Windows.Forms.Label empPositionLbl;
        private System.Windows.Forms.Label empSalaryLbl;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.Label idError;
        private System.Windows.Forms.Label emailError;
        private System.Windows.Forms.Label numError;
        private System.Windows.Forms.Label addressError;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label empEmailError;
        private System.Windows.Forms.Label empSalaryError;
        private System.Windows.Forms.Label empPositionError;
        private System.Windows.Forms.Label empNameError;
        private System.Windows.Forms.Label empIdError;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem employeeSelectStrip;
        private System.Windows.Forms.ToolStripMenuItem customerSelect;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button3;
    }
}