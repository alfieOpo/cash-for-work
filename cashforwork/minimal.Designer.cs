namespace cashforwork
{
    partial class minimal
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
            this.txt_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.main_panel = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Depth = 0;
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_name.Hint = "First Name";
            this.txt_name.Location = new System.Drawing.Point(0, 514);
            this.txt_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.Size = new System.Drawing.Size(381, 23);
            this.txt_name.TabIndex = 102;
            this.txt_name.Tag = "f_name";
            this.txt_name.UseSystemPasswordChar = false;
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.AutoScroll = true;
            this.main_panel.HorizontalScrollbar = true;
            this.main_panel.HorizontalScrollbarBarColor = true;
            this.main_panel.HorizontalScrollbarHighlightOnWheel = false;
            this.main_panel.HorizontalScrollbarSize = 10;
            this.main_panel.Location = new System.Drawing.Point(0, 64);
            this.main_panel.Name = "main_panel";
            this.main_panel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.main_panel.Size = new System.Drawing.Size(381, 444);
            this.main_panel.TabIndex = 103;
            this.main_panel.VerticalScrollbar = true;
            this.main_panel.VerticalScrollbarBarColor = true;
            this.main_panel.VerticalScrollbarHighlightOnWheel = true;
            this.main_panel.VerticalScrollbarSize = 20;
            // 
            // minimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 537);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.txt_name);
            this.Name = "minimal";
            this.Text = "Cash for Work";
            this.Load += new System.EventHandler(this.minimal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_name;
        private MetroFramework.Controls.MetroPanel main_panel;
    }
}