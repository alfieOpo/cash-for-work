using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashforwork
{
    public partial class CustomMessageForm : MaterialForm
    {
 SoundPlayer player;
 
        bool valid = false;
       public string action = "";
        public CustomMessageForm()
        {
            InitializeComponent();
        }

        public CustomMessageForm(string title, string description, MaterialForm form)
        {
            InitializeComponent();

            this.Text = title;
            this.lbl_message.Text = description;
            try
            {
                this.Width = form.Width;
            }
            catch (Exception xx) { }
            switch(this.Text.ToLower()){
                case "warning":
                    
                    lbl_message.BackColor = Color.Goldenrod;
                    lbl_symbol.Text = "!";
                    ShowCancel = false;
                    break;
                case "warning confirmation":
                    lbl_message.BackColor = Color.Goldenrod;
                    lbl_symbol.Text = "!?";
                    ShowCancel = true;
                    break;
                case "message":
                    lbl_message.BackColor = Color.ForestGreen;
                    lbl_symbol.Text = "i";
                    ShowCancel = false;
                    break;
                case "error":
                    lbl_message.BackColor = Color.Tomato;
                    lbl_symbol.Text = "";
                    ShowCancel = false;
                    break;
                default:
                    lbl_symbol.Text = "?";
                    ShowCancel = true;
                    lbl_message.BackColor = Color.DarkCyan;
                    break;

            }
        }
        public bool ShowCancel {
            set {

                if (value)
                {
                    btn_no.Text = "no";
                    btn_yes.Text = "yes";
                    btn_yes.Visible = value;
                    btn_no.Visible = value;
                }
                else {
                    btn_no.Text = "no";
                    btn_yes.Text = "OK";
                    btn_yes.Visible =! value;
                    btn_no.Visible = value;
                }
            }
        }
        public static class CustomMessageBox
        {
            public static void Show(string title, string description,MaterialForm _form)
            {
                // using construct ensures the resources are freed when form is closed
                 
                using (var form = new CustomMessageForm(title, description, _form))
                {                    
                    form.ShowDialog();
                }
                
            }
            public static bool Confirm(string title, string description, MaterialForm _form)
            {
                // using construct ensures the resources are freed when form is closed

                using (var form = new CustomMessageForm(title, description, _form))
                {
                    form.ShowDialog();
                    return form.Valid;
                }

            }
            public static bool WarConfirm(string title, string description, MaterialForm _form)
            {
                // using construct ensures the resources are freed when form is closed

                using (var form = new CustomMessageForm(title, description, _form))
                {
                    form.ShowDialog();
                    return form.Valid;
                }

            } 
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            valid = false; ;
            this.Close();
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            valid = true;
            this.Close();
        }
        public bool Valid { get { return valid; } }
        private void PlaySound() {
           
        }
    }
    
}
