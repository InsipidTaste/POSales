namespace POSales
{
    partial class UserAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccount));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.btnAccSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.txtRePass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnPassCancel = new System.Windows.Forms.Button();
            this.btnPassSave = new System.Windows.Forms.Button();
            this.txtRePass2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPass2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassUsername = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Setting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(16, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(956, 434);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.White;
            this.metroTabPage1.Controls.Add(this.btnAccCancel);
            this.metroTabPage1.Controls.Add(this.btnAccSave);
            this.metroTabPage1.Controls.Add(this.txtName);
            this.metroTabPage1.Controls.Add(this.label6);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.cbRole);
            this.metroTabPage1.Controls.Add(this.txtRePass);
            this.metroTabPage1.Controls.Add(this.txtPass);
            this.metroTabPage1.Controls.Add(this.txtUsername);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 4;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(948, 392);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Create Account";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 5;
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAccCancel.FlatAppearance.BorderSize = 0;
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.ForeColor = System.Drawing.Color.Black;
            this.btnAccCancel.Location = new System.Drawing.Point(762, 316);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(88, 36);
            this.btnAccCancel.TabIndex = 36;
            this.btnAccCancel.Text = "Cancel";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // btnAccSave
            // 
            this.btnAccSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnAccSave.FlatAppearance.BorderSize = 0;
            this.btnAccSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccSave.ForeColor = System.Drawing.Color.White;
            this.btnAccSave.Location = new System.Drawing.Point(642, 316);
            this.btnAccSave.Name = "btnAccSave";
            this.btnAccSave.Size = new System.Drawing.Size(103, 36);
            this.btnAccSave.TabIndex = 35;
            this.btnAccSave.Text = "Save";
            this.btnAccSave.UseVisualStyleBackColor = false;
            this.btnAccSave.Click += new System.EventHandler(this.btnAccSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(237, 255);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(613, 26);
            this.txtName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Full Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Role :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Re-Type Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password :";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Administrator",
            "Cashier"});
            this.cbRole.Location = new System.Drawing.Point(237, 205);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(613, 28);
            this.cbRole.TabIndex = 6;
            // 
            // txtRePass
            // 
            this.txtRePass.Location = new System.Drawing.Point(237, 157);
            this.txtRePass.Name = "txtRePass";
            this.txtRePass.Size = new System.Drawing.Size(613, 26);
            this.txtRePass.TabIndex = 5;
            this.txtRePass.UseSystemPasswordChar = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(237, 109);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(613, 26);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(237, 61);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(613, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username :";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.dgvUser);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 4;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(948, 392);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Activate/UnActivate Account";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 5;
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeight = 30;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Edit,
            this.Delete});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.Size = new System.Drawing.Size(948, 392);
            this.dgvUser.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.Width = 53;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            this.Column2.Width = 49;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Brand";
            this.Column3.Name = "Column3";
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.BackColor = System.Drawing.Color.White;
            this.metroTabPage2.Controls.Add(this.btnPassCancel);
            this.metroTabPage2.Controls.Add(this.btnPassSave);
            this.metroTabPage2.Controls.Add(this.txtRePass2);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.txtNPass);
            this.metroTabPage2.Controls.Add(this.label9);
            this.metroTabPage2.Controls.Add(this.txtPass2);
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.txtPassUsername);
            this.metroTabPage2.Controls.Add(this.label7);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 4;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(948, 392);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Change Password";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 5;
            // 
            // btnPassCancel
            // 
            this.btnPassCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPassCancel.FlatAppearance.BorderSize = 0;
            this.btnPassCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassCancel.ForeColor = System.Drawing.Color.Black;
            this.btnPassCancel.Location = new System.Drawing.Point(759, 272);
            this.btnPassCancel.Name = "btnPassCancel";
            this.btnPassCancel.Size = new System.Drawing.Size(88, 36);
            this.btnPassCancel.TabIndex = 38;
            this.btnPassCancel.Text = "Cancel";
            this.btnPassCancel.UseVisualStyleBackColor = false;
            // 
            // btnPassSave
            // 
            this.btnPassSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPassSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnPassSave.FlatAppearance.BorderSize = 0;
            this.btnPassSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassSave.ForeColor = System.Drawing.Color.White;
            this.btnPassSave.Location = new System.Drawing.Point(639, 272);
            this.btnPassSave.Name = "btnPassSave";
            this.btnPassSave.Size = new System.Drawing.Size(103, 36);
            this.btnPassSave.TabIndex = 37;
            this.btnPassSave.Text = "Save";
            this.btnPassSave.UseVisualStyleBackColor = false;
            // 
            // txtRePass2
            // 
            this.txtRePass2.Location = new System.Drawing.Point(234, 206);
            this.txtRePass2.Name = "txtRePass2";
            this.txtRePass2.Size = new System.Drawing.Size(613, 26);
            this.txtRePass2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Re-Type Password :";
            // 
            // txtNPass
            // 
            this.txtNPass.Location = new System.Drawing.Point(234, 150);
            this.txtNPass.Name = "txtNPass";
            this.txtNPass.Size = new System.Drawing.Size(613, 26);
            this.txtNPass.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "New Password :";
            // 
            // txtPass2
            // 
            this.txtPass2.Location = new System.Drawing.Point(234, 97);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(613, 26);
            this.txtPass2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Current Password :";
            // 
            // txtPassUsername
            // 
            this.txtPassUsername.Location = new System.Drawing.Point(234, 48);
            this.txtPassUsername.Name = "txtPassUsername";
            this.txtPassUsername.Size = new System.Drawing.Size(613, 26);
            this.txtPassUsername.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Username :";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.panel1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtRePass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        public System.Windows.Forms.Button btnAccCancel;
        public System.Windows.Forms.Button btnAccSave;
        public System.Windows.Forms.Button btnPassCancel;
        public System.Windows.Forms.Button btnPassSave;
        private System.Windows.Forms.TextBox txtRePass2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPass2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassUsername;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}