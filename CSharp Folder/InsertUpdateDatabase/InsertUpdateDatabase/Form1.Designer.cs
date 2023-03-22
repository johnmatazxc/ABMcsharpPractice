namespace InsertUpdateDatabase
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
            this.insert = new System.Windows.Forms.Button();
            this.userLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.updateUserLbl = new System.Windows.Forms.Label();
            this.updateUserTxtBox = new System.Windows.Forms.TextBox();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.updatePassLbl = new System.Windows.Forms.Label();
            this.updatePassTxtBox = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.deleteIdTxtBox = new System.Windows.Forms.TextBox();
            this.idDeleteLbl = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(54, 285);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(170, 65);
            this.insert.TabIndex = 0;
            this.insert.Text = "button1";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(51, 63);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(35, 13);
            this.userLbl.TabIndex = 1;
            this.userLbl.Text = "label1";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(51, 171);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(35, 13);
            this.passLbl.TabIndex = 2;
            this.passLbl.Text = "label2";
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(54, 88);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(170, 20);
            this.userTxtBox.TabIndex = 3;
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(54, 202);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.Size = new System.Drawing.Size(170, 20);
            this.passTxtBox.TabIndex = 4;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(256, 63);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(35, 13);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "label1";
            // 
            // updateUserLbl
            // 
            this.updateUserLbl.AutoSize = true;
            this.updateUserLbl.Location = new System.Drawing.Point(256, 128);
            this.updateUserLbl.Name = "updateUserLbl";
            this.updateUserLbl.Size = new System.Drawing.Size(35, 13);
            this.updateUserLbl.TabIndex = 6;
            this.updateUserLbl.Text = "label2";
            // 
            // updateUserTxtBox
            // 
            this.updateUserTxtBox.Location = new System.Drawing.Point(259, 144);
            this.updateUserTxtBox.Multiline = true;
            this.updateUserTxtBox.Name = "updateUserTxtBox";
            this.updateUserTxtBox.Size = new System.Drawing.Size(151, 20);
            this.updateUserTxtBox.TabIndex = 7;
            this.updateUserTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(259, 88);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(151, 20);
            this.idTxtBox.TabIndex = 8;
            // 
            // updatePassLbl
            // 
            this.updatePassLbl.AutoSize = true;
            this.updatePassLbl.Location = new System.Drawing.Point(256, 185);
            this.updatePassLbl.Name = "updatePassLbl";
            this.updatePassLbl.Size = new System.Drawing.Size(35, 13);
            this.updatePassLbl.TabIndex = 9;
            this.updatePassLbl.Text = "label3";
            // 
            // updatePassTxtBox
            // 
            this.updatePassTxtBox.Location = new System.Drawing.Point(259, 202);
            this.updatePassTxtBox.Name = "updatePassTxtBox";
            this.updatePassTxtBox.Size = new System.Drawing.Size(151, 20);
            this.updatePassTxtBox.TabIndex = 10;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(259, 285);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(151, 65);
            this.update.TabIndex = 11;
            this.update.Text = "button1";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // deleteIdTxtBox
            // 
            this.deleteIdTxtBox.Location = new System.Drawing.Point(449, 88);
            this.deleteIdTxtBox.Name = "deleteIdTxtBox";
            this.deleteIdTxtBox.Size = new System.Drawing.Size(151, 20);
            this.deleteIdTxtBox.TabIndex = 13;
            // 
            // idDeleteLbl
            // 
            this.idDeleteLbl.AutoSize = true;
            this.idDeleteLbl.Location = new System.Drawing.Point(446, 63);
            this.idDeleteLbl.Name = "idDeleteLbl";
            this.idDeleteLbl.Size = new System.Drawing.Size(35, 13);
            this.idDeleteLbl.TabIndex = 12;
            this.idDeleteLbl.Text = "label1";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(449, 128);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(151, 65);
            this.delete.TabIndex = 14;
            this.delete.Text = "button1";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.PasswordData,
            this.isActive});
            this.dataGridView1.Location = new System.Drawing.Point(39, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(458, 234);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PasswordData
            // 
            this.PasswordData.DataPropertyName = "password";
            this.PasswordData.HeaderText = "password";
            this.PasswordData.Name = "PasswordData";
            this.PasswordData.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.Name = "isActive";
            this.isActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 679);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.deleteIdTxtBox);
            this.Controls.Add(this.idDeleteLbl);
            this.Controls.Add(this.update);
            this.Controls.Add(this.updatePassTxtBox);
            this.Controls.Add(this.updatePassLbl);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.updateUserTxtBox);
            this.Controls.Add(this.updateUserLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.insert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox passTxtBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label updateUserLbl;
        private System.Windows.Forms.TextBox updateUserTxtBox;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Label updatePassLbl;
        private System.Windows.Forms.TextBox updatePassTxtBox;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox deleteIdTxtBox;
        private System.Windows.Forms.Label idDeleteLbl;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordData;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
    }
}

