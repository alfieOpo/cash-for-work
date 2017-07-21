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
    public partial class Mainform : MaterialForm
    {
        public Mainform()
        {
            InitializeComponent();
        }
        cashUsers users = new cashUsers();
        cashforwork cfw = new cashforwork();
        report rep = new report();
        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (userinfo.isadmin.Equals("1"))
            {
                this.WindowState = FormWindowState.Normal;
                AddFrame(users);
                this.Text = "Users";
                TunnerVisible("users");
                this.Refresh();
            }
            else
            {
                CustomMessageForm.CustomMessageBox.Show("Warning", "This account is not valid to proceed!", this);
                return;
            }
        }
        private void AddFrame(UserControl control) {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            AddFrame(cfw);
            this.Text = "Cash for Work";
            TunnerVisible("cfw");
            
            this.Refresh();
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            AddFrame(rep);
            this.Text = "Report";
            TunnerVisible("rep");
            this.Refresh();
            
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Text = "Dash Board";
            AddFrame(cfw);
            TunnerVisible("cfw");
            Loaduserinfo("[Full Name :" + userinfo.first_name.ToUpper() + " " + userinfo.middle_name.ToUpper() + " " + userinfo.last_name.ToUpper() + "]", "[Username :" + userinfo.username + "]");
            this.Refresh();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (CustomMessageForm.CustomMessageBox.Confirm("Logout Confirmation", "Do you want to logout?", this))
            {
                Application.Restart();
            }

        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (CustomMessageForm.CustomMessageBox.Confirm("Exit Confirmation", "Are you sure you want to exit?", this))
            {
                Application.Exit();
            }
           
        }
        private void TunnerVisible(string name) { 
        switch(name){
            case "cfw":
                report_tunnel.Visible = false;
                user_tunnel.Visible = false;
                worker_tunnel.Visible = true;
                break;
            case "rep":
                report_tunnel.Visible = true;
                user_tunnel.Visible = false;
                worker_tunnel.Visible = false;
                break;
            case "users":
                report_tunnel.Visible = false;
                user_tunnel.Visible = true;
                worker_tunnel.Visible = false;
                break;
        }
        
        }
        private void Loaduserinfo(string fullname,string username) {
            lbl_full_name.ForeColor = Color.White;
            lbl_username.ForeColor = Color.White;
            lbl_full_name.Text = fullname;
            lbl_username.Text = username;
        }
    }
}
