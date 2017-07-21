namespace cashforwork
{
    partial class minimalAdapter
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_full_name = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_barangay = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_contacnumber = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_batch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_full_name
            // 
            this.lbl_full_name.AutoSize = true;
            this.lbl_full_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_full_name.Depth = 0;
            this.lbl_full_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_full_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_full_name.Location = new System.Drawing.Point(145, 41);
            this.lbl_full_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_full_name.Name = "lbl_full_name";
            this.lbl_full_name.Size = new System.Drawing.Size(67, 19);
            this.lbl_full_name.TabIndex = 116;
            this.lbl_full_name.Text = "fullname";
            // 
            // lbl_barangay
            // 
            this.lbl_barangay.AutoSize = true;
            this.lbl_barangay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_barangay.Depth = 0;
            this.lbl_barangay.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_barangay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_barangay.Location = new System.Drawing.Point(142, 76);
            this.lbl_barangay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_barangay.Name = "lbl_barangay";
            this.lbl_barangay.Size = new System.Drawing.Size(70, 19);
            this.lbl_barangay.TabIndex = 117;
            this.lbl_barangay.Text = "Barangay";
            // 
            // lbl_contacnumber
            // 
            this.lbl_contacnumber.AutoSize = true;
            this.lbl_contacnumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contacnumber.Depth = 0;
            this.lbl_contacnumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_contacnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_contacnumber.Location = new System.Drawing.Point(142, 106);
            this.lbl_contacnumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_contacnumber.Name = "lbl_contacnumber";
            this.lbl_contacnumber.Size = new System.Drawing.Size(105, 19);
            this.lbl_contacnumber.TabIndex = 118;
            this.lbl_contacnumber.Text = "contacnumber";
            // 
            // lbl_batch
            // 
            this.lbl_batch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_batch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_batch.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_batch.ForeColor = System.Drawing.Color.White;
            this.lbl_batch.Location = new System.Drawing.Point(396, -1);
            this.lbl_batch.Name = "lbl_batch";
            this.lbl_batch.Size = new System.Drawing.Size(30, 30);
            this.lbl_batch.TabIndex = 120;
            this.lbl_batch.Text = "0";
            this.lbl_batch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimalAdapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_batch);
            this.Controls.Add(this.lbl_contacnumber);
            this.Controls.Add(this.lbl_barangay);
            this.Controls.Add(this.lbl_full_name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "minimalAdapter";
            this.Size = new System.Drawing.Size(424, 133);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lbl_full_name;
        private MaterialSkin.Controls.MaterialLabel lbl_barangay;
        private MaterialSkin.Controls.MaterialLabel lbl_contacnumber;
        private System.Windows.Forms.Label lbl_batch;
    }
}
