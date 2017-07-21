namespace cashforwork
{
    partial class report
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.num_batch = new System.Windows.Forms.NumericUpDown();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.date_from = new MetroFramework.Controls.MetroDateTime();
            this.date_to = new MetroFramework.Controls.MetroDateTime();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbo_barangay = new MetroFramework.Controls.MetroComboBox();
            this.rdn_male = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdn_female = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdn_none = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.num_batch)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cashforwork.CfwReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(708, 394);
            this.reportViewer1.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(-1, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(68, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "FILTER\'S";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 23);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(49, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "FROM";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(236, 22);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(28, 19);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "TO";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(445, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(58, 19);
            this.materialLabel4.TabIndex = 37;
            this.materialLabel4.Text = "BATCH";
            // 
            // num_batch
            // 
            this.num_batch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.num_batch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_batch.Location = new System.Drawing.Point(449, 20);
            this.num_batch.Name = "num_batch";
            this.num_batch.Size = new System.Drawing.Size(120, 26);
            this.num_batch.TabIndex = 38;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(582, 4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(129, 77);
            this.materialRaisedButton1.TabIndex = 39;
            this.materialRaisedButton1.Text = "show result";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // date_from
            // 
            this.date_from.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_from.Checked = false;
            this.date_from.Location = new System.Drawing.Point(58, 20);
            this.date_from.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_from.MISText = "2000-01-01";
            this.date_from.Name = "date_from";
            this.date_from.Size = new System.Drawing.Size(177, 29);
            this.date_from.TabIndex = 41;
            this.date_from.Value = new System.DateTime(2017, 6, 6, 0, 0, 0, 0);
            // 
            // date_to
            // 
            this.date_to.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_to.Location = new System.Drawing.Point(266, 20);
            this.date_to.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_to.MISText = "2017-06-09";
            this.date_to.Name = "date_to";
            this.date_to.Size = new System.Drawing.Size(177, 29);
            this.date_to.TabIndex = 40;
            this.date_to.Value = new System.DateTime(2017, 6, 9, 0, 0, 0, 0);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(298, 56);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(87, 19);
            this.materialLabel5.TabIndex = 42;
            this.materialLabel5.Text = "BARANGAY";
            // 
            // cbo_barangay
            // 
            this.cbo_barangay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_barangay.FormattingEnabled = true;
            this.cbo_barangay.ItemHeight = 23;
            this.cbo_barangay.Items.AddRange(new object[] {
            "ALL",
            "Bagbaguin",
            "Balasing",
            "Buenavista",
            "Bulac",
            "Camangyanan",
            "Catmon",
            "Cay Pombo",
            "Caysio",
            "Guyong",
            "Lalakhan",
            "Manggahan",
            "Mag-asawang Sapa",
            "Mahabang Parang",
            "Parada",
            "Poblacion",
            "Pulong Buhangin",
            "San Gabriel",
            "San Jose Patag",
            "San Vicente",
            "Silangan",
            "Sta. Clara",
            "Sta. Cruz",
            "Sto. Tomas",
            "Tumana"});
            this.cbo_barangay.Location = new System.Drawing.Point(391, 52);
            this.cbo_barangay.Name = "cbo_barangay";
            this.cbo_barangay.Size = new System.Drawing.Size(178, 29);
            this.cbo_barangay.TabIndex = 43;
            this.cbo_barangay.UseSelectable = true;
            // 
            // rdn_male
            // 
            this.rdn_male.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdn_male.AutoSize = true;
            this.rdn_male.Depth = 0;
            this.rdn_male.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdn_male.Location = new System.Drawing.Point(74, 52);
            this.rdn_male.Margin = new System.Windows.Forms.Padding(0);
            this.rdn_male.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdn_male.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdn_male.Name = "rdn_male";
            this.rdn_male.Ripple = true;
            this.rdn_male.Size = new System.Drawing.Size(59, 30);
            this.rdn_male.TabIndex = 44;
            this.rdn_male.TabStop = true;
            this.rdn_male.Text = "Male";
            this.rdn_male.UseVisualStyleBackColor = true;
            // 
            // rdn_female
            // 
            this.rdn_female.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdn_female.AutoSize = true;
            this.rdn_female.Depth = 0;
            this.rdn_female.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdn_female.Location = new System.Drawing.Point(136, 52);
            this.rdn_female.Margin = new System.Windows.Forms.Padding(0);
            this.rdn_female.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdn_female.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdn_female.Name = "rdn_female";
            this.rdn_female.Ripple = true;
            this.rdn_female.Size = new System.Drawing.Size(74, 30);
            this.rdn_female.TabIndex = 45;
            this.rdn_female.TabStop = true;
            this.rdn_female.Text = "Female";
            this.rdn_female.UseVisualStyleBackColor = true;
            // 
            // rdn_none
            // 
            this.rdn_none.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdn_none.AutoSize = true;
            this.rdn_none.Depth = 0;
            this.rdn_none.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdn_none.Location = new System.Drawing.Point(211, 52);
            this.rdn_none.Margin = new System.Windows.Forms.Padding(0);
            this.rdn_none.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdn_none.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdn_none.Name = "rdn_none";
            this.rdn_none.Ripple = true;
            this.rdn_none.Size = new System.Drawing.Size(45, 30);
            this.rdn_none.TabIndex = 46;
            this.rdn_none.TabStop = true;
            this.rdn_none.Text = "All";
            this.rdn_none.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(282, 52);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1, 36);
            this.materialDivider1.TabIndex = 47;
            this.materialDivider1.Text = "materialDivider1";
            this.materialDivider1.Click += new System.EventHandler(this.materialDivider1_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 57);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 19);
            this.materialLabel6.TabIndex = 48;
            this.materialLabel6.Text = "GENDER";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.rdn_none);
            this.Controls.Add(this.rdn_female);
            this.Controls.Add(this.rdn_male);
            this.Controls.Add(this.cbo_barangay);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.date_from);
            this.Controls.Add(this.date_to);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.num_batch);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Size = new System.Drawing.Size(714, 489);
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_batch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.NumericUpDown num_batch;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MetroFramework.Controls.MetroDateTime date_to;
        private MetroFramework.Controls.MetroDateTime date_from;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MetroFramework.Controls.MetroComboBox cbo_barangay;
        private MaterialSkin.Controls.MaterialRadioButton rdn_male;
        private MaterialSkin.Controls.MaterialRadioButton rdn_female;
        private MaterialSkin.Controls.MaterialRadioButton rdn_none;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}
