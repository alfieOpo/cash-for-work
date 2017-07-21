namespace cashforwork
{
    partial class cashUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_error = new MaterialSkin.Controls.MaterialLabel();
            this.btn_cancel = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_save = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_edit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_add = new MaterialSkin.Controls.MaterialFlatButton();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_confirm_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_last_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mgrid = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_search = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_middle_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.chk_admin = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Depth = 0;
            this.lbl_error.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_error.Location = new System.Drawing.Point(301, 352);
            this.lbl_error.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(108, 19);
            this.lbl_error.TabIndex = 92;
            this.lbl_error.Text = "materialLabel1";
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSize = true;
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.BackColor = System.Drawing.Color.White;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Location = new System.Drawing.Point(616, 410);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Primary = false;
            this.btn_cancel.Size = new System.Drawing.Size(64, 36);
            this.btn_cancel.TabIndex = 91;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Depth = 0;
            this.btn_save.Location = new System.Drawing.Point(548, 409);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = false;
            this.btn_save.Size = new System.Drawing.Size(46, 36);
            this.btn_save.TabIndex = 90;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoSize = true;
            this.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Depth = 0;
            this.btn_delete.Location = new System.Drawing.Point(441, 411);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = false;
            this.btn_delete.Size = new System.Drawing.Size(60, 36);
            this.btn_delete.TabIndex = 89;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AutoSize = true;
            this.btn_edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.Depth = 0;
            this.btn_edit.Location = new System.Drawing.Point(373, 410);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Primary = false;
            this.btn_edit.Size = new System.Drawing.Size(41, 36);
            this.btn_edit.TabIndex = 88;
            this.btn_edit.Text = "edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Depth = 0;
            this.btn_add.Location = new System.Drawing.Point(305, 411);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_add.Name = "btn_add";
            this.btn_add.Primary = false;
            this.btn_add.Size = new System.Drawing.Size(39, 36);
            this.btn_add.TabIndex = 87;
            this.btn_add.Text = "add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "Password";
            this.txt_password.Location = new System.Drawing.Point(305, 297);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(375, 23);
            this.txt_password.TabIndex = 85;
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.BackColor = System.Drawing.Color.White;
            this.txt_confirm_password.Depth = 0;
            this.txt_confirm_password.Hint = "Confirm Password";
            this.txt_confirm_password.Location = new System.Drawing.Point(305, 326);
            this.txt_confirm_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.PasswordChar = '*';
            this.txt_confirm_password.SelectedText = "";
            this.txt_confirm_password.SelectionLength = 0;
            this.txt_confirm_password.SelectionStart = 0;
            this.txt_confirm_password.Size = new System.Drawing.Size(375, 23);
            this.txt_confirm_password.TabIndex = 86;
            this.txt_confirm_password.UseSystemPasswordChar = false;
            this.txt_confirm_password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_confirm_password_KeyUp_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Depth = 0;
            this.label7.Font = new System.Drawing.Font("Roboto", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(301, 57);
            this.label7.MouseState = MaterialSkin.MouseState.HOVER;
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 19);
            this.label7.TabIndex = 84;
            this.label7.Text = "First name";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.Depth = 0;
            this.txt_username.Hint = "Username";
            this.txt_username.Location = new System.Drawing.Point(305, 209);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(375, 23);
            this.txt_username.TabIndex = 83;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // txt_last_name
            // 
            this.txt_last_name.BackColor = System.Drawing.Color.White;
            this.txt_last_name.Depth = 0;
            this.txt_last_name.Hint = "Last Name";
            this.txt_last_name.Location = new System.Drawing.Point(305, 167);
            this.txt_last_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_last_name.Name = "txt_last_name";
            this.txt_last_name.PasswordChar = '\0';
            this.txt_last_name.SelectedText = "";
            this.txt_last_name.SelectionLength = 0;
            this.txt_last_name.SelectionStart = 0;
            this.txt_last_name.Size = new System.Drawing.Size(375, 23);
            this.txt_last_name.TabIndex = 82;
            this.txt_last_name.UseSystemPasswordChar = false;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Depth = 0;
            this.txt_name.Hint = "First Name";
            this.txt_name.Location = new System.Drawing.Point(305, 90);
            this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.Size = new System.Drawing.Size(375, 23);
            this.txt_name.TabIndex = 80;
            this.txt_name.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mgrid);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 479);
            this.panel1.TabIndex = 79;
            // 
            // mgrid
            // 
            this.mgrid.AllowUserToResizeRows = false;
            this.mgrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mgrid.EnableHeadersVisualStyles = false;
            this.mgrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgrid.Location = new System.Drawing.Point(0, 0);
            this.mgrid.MultiSelect = false;
            this.mgrid.Name = "mgrid";
            this.mgrid.ReadOnly = true;
            this.mgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgrid.RowHeadersVisible = false;
            this.mgrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mgrid.RowTemplate.Height = 30;
            this.mgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgrid.Size = new System.Drawing.Size(272, 456);
            this.mgrid.TabIndex = 57;
            this.mgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellContentClick);
            this.mgrid.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgrid_CellEnter);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.White;
            this.txt_search.Depth = 0;
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_search.Hint = "Search";
            this.txt_search.Location = new System.Drawing.Point(0, 456);
            this.txt_search.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.Size = new System.Drawing.Size(272, 23);
            this.txt_search.TabIndex = 56;
            this.txt_search.UseSystemPasswordChar = false;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // txt_middle_name
            // 
            this.txt_middle_name.BackColor = System.Drawing.Color.White;
            this.txt_middle_name.Depth = 0;
            this.txt_middle_name.Hint = "Middle Name";
            this.txt_middle_name.Location = new System.Drawing.Point(305, 128);
            this.txt_middle_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_middle_name.Name = "txt_middle_name";
            this.txt_middle_name.PasswordChar = '\0';
            this.txt_middle_name.SelectedText = "";
            this.txt_middle_name.SelectionLength = 0;
            this.txt_middle_name.SelectionStart = 0;
            this.txt_middle_name.Size = new System.Drawing.Size(375, 23);
            this.txt_middle_name.TabIndex = 81;
            this.txt_middle_name.UseSystemPasswordChar = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(301, 274);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(144, 20);
            this.linkLabel1.TabIndex = 93;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "EDIT PASSWORD";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // chk_admin
            // 
            this.chk_admin.AutoSize = true;
            this.chk_admin.Depth = 0;
            this.chk_admin.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk_admin.Location = new System.Drawing.Point(305, 235);
            this.chk_admin.Margin = new System.Windows.Forms.Padding(0);
            this.chk_admin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk_admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk_admin.Name = "chk_admin";
            this.chk_admin.Ripple = true;
            this.chk_admin.Size = new System.Drawing.Size(70, 30);
            this.chk_admin.TabIndex = 94;
            this.chk_admin.Text = "Admin";
            this.chk_admin.UseVisualStyleBackColor = true;
            // 
            // cashUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chk_admin);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_last_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_middle_name);
            this.Name = "cashUsers";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(714, 489);
            this.Load += new System.EventHandler(this.cashUsers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_error;
        private MaterialSkin.Controls.MaterialFlatButton btn_cancel;
        private MaterialSkin.Controls.MaterialFlatButton btn_save;
        private MaterialSkin.Controls.MaterialFlatButton btn_delete;
        private MaterialSkin.Controls.MaterialFlatButton btn_edit;
        private MaterialSkin.Controls.MaterialFlatButton btn_add;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_confirm_password;
        private MaterialSkin.Controls.MaterialLabel label7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_last_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_name;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroGrid mgrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_search;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_middle_name;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MaterialSkin.Controls.MaterialCheckBox chk_admin;
    }
}
