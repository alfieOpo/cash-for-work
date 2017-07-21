namespace cashforwork
{
    partial class CustomMessageForm
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
            this.lbl_symbol = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_no = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_yes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_message = new System.Windows.Forms.Label();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_symbol
            // 
            this.lbl_symbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_symbol.AutoSize = true;
            this.lbl_symbol.BackColor = System.Drawing.Color.Transparent;
            this.lbl_symbol.Font = new System.Drawing.Font("Calibri", 25F);
            this.lbl_symbol.ForeColor = System.Drawing.Color.White;
            this.lbl_symbol.Location = new System.Drawing.Point(638, 20);
            this.lbl_symbol.Name = "lbl_symbol";
            this.lbl_symbol.Size = new System.Drawing.Size(29, 41);
            this.lbl_symbol.TabIndex = 1;
            this.lbl_symbol.Text = "!";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.metroPanel1.Controls.Add(this.btn_no);
            this.metroPanel1.Controls.Add(this.btn_yes);
            this.metroPanel1.Controls.Add(this.lbl_message);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(670, 168);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_no
            // 
            this.btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_no.Depth = 0;
            this.btn_no.Location = new System.Drawing.Point(502, 131);
            this.btn_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_no.Name = "btn_no";
            this.btn_no.Primary = true;
            this.btn_no.Size = new System.Drawing.Size(75, 23);
            this.btn_no.TabIndex = 4;
            this.btn_no.Text = "cancel";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_yes.Depth = 0;
            this.btn_yes.Location = new System.Drawing.Point(583, 131);
            this.btn_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Primary = true;
            this.btn_yes.Size = new System.Drawing.Size(75, 23);
            this.btn_yes.TabIndex = 3;
            this.btn_yes.Text = "OK";
            this.btn_yes.UseVisualStyleBackColor = true;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.BackColor = System.Drawing.Color.Tomato;
            this.lbl_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_message.Font = new System.Drawing.Font("Calibri", 14F);
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(0, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(670, 168);
            this.lbl_message.TabIndex = 2;
            this.lbl_message.Text = "Successfully Saved";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 230);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_symbol);
            this.Controls.Add(this.metroPanel1);
            this.MinimumSize = new System.Drawing.Size(306, 212);
            this.Name = "CustomMessageForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageForm";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_no;
        private MaterialSkin.Controls.MaterialRaisedButton btn_yes;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Label lbl_symbol;
    }
}