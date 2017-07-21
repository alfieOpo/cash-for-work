using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashforwork
{
    public partial class passwordvalidator : MaterialForm
    {
        string password = "";
        bool valid = false;
        public passwordvalidator(string _password)
        {
            InitializeComponent();
            this.password = _password;
        }

        private void materialSingleLineTextField1_KeyDown(object sender, KeyEventArgs e)
        {

            lbl_error.Visible = false;
            if (Keys.Enter == e.KeyCode)
            {
                if (materialSingleLineTextField1.Text.Equals(password))
                {
                    valid = true;
                    this.Close();
                }
                else
                {
                    valid = false;
                    lbl_error.Visible = true;
                    lbl_error.ForeColor = Color.Red;
                }
            }
        }

        private void passwordvalidator_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }
        public bool Valid {
            get { return valid; }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            valid = false;
            this.Close();
        }

    }
}
