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
    public partial class Login : MaterialForm
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (valid)
            {
                Mainform form = new Mainform();
                form.Show();
                this.Visible = false;
            }
            else {

                CustomMessageForm.CustomMessageBox.Show("Error", "Invalid log in", this);
            
                return;
            }
        }
        private bool valid {
            get {
                Program.da.createCommand("select * from users where username='"+txt_username.Text+"' and password='"+txt_password.Text+"'");
                if(Program.da.fillCommand()){
                    DataTable dt = new DataTable();
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    userinfo.first_name=dr["f_name"].ToString();
                    userinfo.middle_name = dr["m_name"].ToString();
                    userinfo.last_name = dr["l_name"].ToString();
                    userinfo.id = dr["id"].ToString();
                    userinfo.username = dr["username"].ToString();
                    userinfo.isadmin = dr["isadmin"].ToString();
                    return true;
                }
                return false;
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode) {
                if (valid)
                {
                    Mainform form = new Mainform();
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    CustomMessageForm.CustomMessageBox.Show("Error", "Invalid log in", this);
            
                    return;
                }
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                if (valid)
                {
                    Mainform form = new Mainform();
                    form.Show();
                    this.Visible = false;
                }
                else
                {
                    CustomMessageForm.CustomMessageBox.Show("Error", "Invalid log in", this);
            
                    return;
                }
            }
        }
        
    }
}
