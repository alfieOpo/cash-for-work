using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashforwork
{
    public partial class cashUsers : UserControl
    {
        string action = "";
        string userid = "0";
        string userfullname = "";
        bool PasswordMatch = false;
        Mainform mainform;
        public cashUsers()
        {
            InitializeComponent();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            action = "add";
            EnableSave = true;
            txt_password.Hint = "Password";
            lbl_error.Visible = false;
            EnableObject = true;
            passwordvisible = true;
            chk_admin.Checked = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            action = "edit";
            EnableSave = true;
            lbl_error.Visible = false;
            EnableObject = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            mainform = (Mainform)this.ParentForm;

            if (CustomMessageForm.CustomMessageBox.Confirm("Delete Confirmation", "Are you sure you want to delete " + userfullname, mainform))
            {
                Program.da.createCommand("delete from users where id=" + userid);
                if (Program.da.executeCommand())
                {
                    CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Deleted", mainform);
                    action = "";
                    EnableSave = false;
                    LoadList(txt_search.Text);
                    EnableObject = false;
                }
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            mainform = (Mainform)this.ParentForm;
            if (txt_name.Text.Equals("") || txt_last_name.Text.Equals("") || txt_username.Text.Equals(""))
            {
                CustomMessageForm.CustomMessageBox.Show("Warning", "Fill out all important fields", mainform);
                
                return;
            }
            int isadmin = 0;
            switch (action)
            {
                case "add":

                    if (!PasswordMatch)
                    {
                        
                     
                        CustomMessageForm.CustomMessageBox.Show("Warning",  "Password didn't match", mainform);                        
                        return;
                    }
                    Program.da.createCommand("sp_insert_users");
                    Program.da.useStoreProcedure();
                    Program.da.addParameter("@f_name", txt_name.Text);
                    Program.da.addParameter("@m_name", txt_middle_name.Text);
                    Program.da.addParameter("@l_name", txt_last_name.Text);
                    Program.da.addParameter("@username", txt_username.Text);
                    Program.da.addParameter("@password", txt_password.Text);                    
                      isadmin = chk_admin.Checked ? 1 : 0;
                    Program.da.addParameter("@isadmin", isadmin);
                    if (Program.da.executeCommand())
                    {

                        action = "";
                        EnableSave = false;
                        LoadList(txt_search.Text);
                        EnableObject = false;
                        passwordvisible = false;
                        CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Saved", mainform); 
                       
                    }
                    break;
                case "edit":

                    if (CustomMessageForm.CustomMessageBox.Confirm( "Update Confirmations","Do you want to save changes.?",mainform))
                    {
                        Program.da.createCommand("sp_update_users");
                        Program.da.useStoreProcedure();
                        Program.da.addParameter("@id", userid);
                        Program.da.addParameter("@f_name", txt_name.Text);
                        Program.da.addParameter("@m_name", txt_middle_name.Text);
                        Program.da.addParameter("@l_name", txt_last_name.Text);
                        Program.da.addParameter("@username", txt_username.Text);
                        Program.da.addParameter("@password", txt_password.Text);
                        isadmin = chk_admin.Checked ? 1 : 0;
                        Program.da.addParameter("@isadmin", isadmin);
                        if (Program.da.executeCommand())
                        {

                            action = "";
                            EnableSave = false;
                            EnableObject = false;
                            LoadList(txt_search.Text);
                            passwordvisible = false;
                            CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Edited", mainform);                      
                        }
                    }

                    break;
            }
            action = "";
            EnableSave = false;


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            action = "add";
            EnableSave = false;
            passwordvisible = false;

        }
        private bool EnableSave
        {
            set
            {

                btn_add.Enabled = !value;
                btn_edit.Enabled = !value;
                btn_delete.Enabled = !value;
                linkLabel1.Enabled = !value;
                btn_save.Enabled = value;
                btn_cancel.Enabled = value;
                if (action.Equals("add"))
                {

                    txt_last_name.Clear();
                    txt_middle_name.Clear();
                    txt_name.Clear();
                    txt_password.Clear();
                    txt_username.Clear();
                    txt_confirm_password.Clear();
                    label7.Text = DateTime.Now.ToLongDateString();
                }
               
            }
        }
        private bool EnableObject {
            set {

                txt_name.Enabled = value;
                txt_last_name.Enabled = value;
                txt_middle_name.Enabled = value;
                txt_name.Enabled = value;
                txt_password.Enabled = value;
                txt_username.Enabled = value;
                txt_confirm_password.Enabled = value;
                linkLabel1.Enabled = value;
            }
        }
        private void LoadList(string value)
        {
            mgrid.DataSource = null;
            string param = " where x.name like '%" + value + "%'";
            if (value.Equals(""))
            {
                param = "";
            }
            Program.da.createCommand("select x.* from (select id,upper(concat(f_name,' ',m_name,' ',l_name)) name from users)x " + param+" ORDER BY id DESC");
            if (Program.da.fillCommand())
            {
                DataTable dt = new DataTable();
                dt = Program.da.getTable();
                mgrid.AutoGenerateColumns = false;
                mgrid.AllowUserToAddRows = false;
                mgrid.DataSource = dt;
                for (int i = 0; i < mgrid.Rows.Count; i++)
                {
                    if ((i % 2) == 0)
                    {
                        mgrid.Rows[i].DefaultCellStyle.BackColor = Color.AliceBlue;
                    }
                }
            }
        }
        private void Select(DataGridViewCellEventArgs e)
        {
            try
            {
                EnableSave = false;
                passwordvisible = false;
                userid = mgrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
                userfullname = mgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Program.da.createCommand("select * from users where id =" + userid);
                if (Program.da.fillCommand())
                {
                    DataTable dt = new DataTable();
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    txt_confirm_password.Text = "";
                    txt_last_name.Text = dr["l_name"].ToString();
                    txt_middle_name.Text = dr["m_name"].ToString();
                    txt_name.Text = dr["f_name"].ToString();
                    txt_password.Text = dr["password"].ToString();
                    txt_username.Text = dr["username"].ToString();
                    chk_admin.Checked = dr["isadmin"].ToString().Equals("1");
                    label7.Text = "Date Registered : " + DateTime.Parse(dr["date_registered"].ToString()).ToLongDateString();
                }
            }
            catch (Exception a) { }
        }


        private void mgrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            Select(e); lbl_error.Visible = false; EnableObject = false;
        }

        private void mgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Select(e); lbl_error.Visible = false; EnableObject = false;
        }

        private void txt_confirm_password_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             
        }

        private void txt_confirm_password_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_confirm_password_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_confirm_password_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txt_password.Text.Equals(""))
            {
                txt_confirm_password.Text = "";
                lbl_error.Visible = false;
            }
            else
            {
                if (txt_password.Text.Length <= txt_confirm_password.Text.Length)
                {
                    if (txt_confirm_password.Text.Equals(txt_password.Text))
                    {
                        lbl_error.ForeColor = Color.Green;
                        lbl_error.Visible = true;
                        lbl_error.Text = "password match";
                        PasswordMatch = true;
                    }
                    else
                    {
                        lbl_error.ForeColor = Color.Red;
                        lbl_error.Visible = true;
                        lbl_error.Text = "password didn't match";
                        PasswordMatch = false;
                    }
                }
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            LoadList(txt_search.Text);
        }

        private void cashUsers_Load(object sender, EventArgs e)
        {
            LoadList(txt_search.Text);
            EnableSave = false;
            lbl_error.Visible = false;
            lbl_error.Visible = false;
            EnableObject = false;
        }
        private bool passwordvisible {
            set {
                txt_password.Visible = value;
                txt_confirm_password.Visible = value;
                linkLabel1.Visible = !value;
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            passwordvalidator password=new passwordvalidator(txt_password.Text);
            password.ShowDialog();
           if(password.Valid){
               passwordvisible = true;
               txt_password.Clear();
               txt_password.Hint = "Enter New Password";
           }
           
        }

        private void txt_password_Click(object sender, EventArgs e)
        {

        }
    }
}
