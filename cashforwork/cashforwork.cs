using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge.Video.DirectShow;
using MaterialSkin.Controls;

namespace cashforwork
{
    public partial class cashforwork : UserControl
    {

        string action = "";
        string cfwid = "0";
        int nhts = 0;

        int _4ps = 0;
        int gender = 0;
        string _name = "";

        string _Name = "";
        string _f_name = "";
        string _m_name = "";
        string _l_name = "";
        string barangay = "";
        bool cellenter = false;

        Mainform mainform;
        List<string> _param;
        public cashforwork()
        {
            InitializeComponent();
        }

        private void cashforwork_Load(object sender, EventArgs e)
        {
            LoadList(textBox6.Text);
            EnableSave = false;
            EnableObject = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ImageUploader form = new ImageUploader();
            form.ShowDialog();
            this.pictureBox1.Image = form.ImageValue;

            try { form.Camera.Stop(); }
            catch (Exception xx) { }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            action = "add";
            EnableSave = true;
            EnableObject = true;
            pictureBox1.Image = Properties.Resources.Users_Male;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_name.Text.Equals(""))
            {
                Mainform form = (Mainform)this.ParentForm;
                CustomMessageForm.CustomMessageBox.Show("Warning", "Nothing to edit!", form);
                return;
            }
            action = "edit";

            EnableSave = true;
            EnableObject = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Equals(""))
            {
                Mainform form = (Mainform)this.ParentForm;
                CustomMessageForm.CustomMessageBox.Show("Warning", "Nothing to delete!", form);
                return;
            }
            mainform = (Mainform)this.ParentForm;
            if (CustomMessageForm.CustomMessageBox.Confirm("Delete Confirmation", "Do you want to delete  " + _name + "?", mainform))
            {
                Program.da.createCommand("delete from workersinformatiions where id = " + cfwid);
                if (Program.da.executeCommand())
                {

                    CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Deleted", mainform);
                    LoadList(textBox6.Text);
                    EnableSave = false;
                    Clear();
                    EnableObject = false;
                }
            }
            else
            {
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NotvalidtoSave)
            {
                mainform = (Mainform)this.ParentForm;
                CustomMessageForm.CustomMessageBox.Show("Warning", "Fill out all important fields!", mainform);
                return;
            }
            if (int.Parse(GetAge) < 18)
            {
                mainform = (Mainform)this.ParentForm;
                if (CustomMessageForm.CustomMessageBox.WarConfirm("Warning Confirmation", SearhName.ToUpper() + " is Below 18! \n\rDo you want to proceed?", mainform))
                {

                }
                else
                {
                    return;
                }
            }
            switch (action)
            {

                case "add":
                    Program.da.createCommand("sp_insert_workersinformation");
                    Program.da.useStoreProcedure();
                    Program.da.addParameter("@f_name", txt_name.Text);
                    Program.da.addParameter("@m_name", txt_middle_name.Text);
                    Program.da.addParameter("@l_name", txt_last_name.Text);
                    Program.da.addParameter("@barangay", cbo_barangay.Text);
                    Program.da.addParameter("@contact_number", txt_contact_number.Text);
                    Program.da.addParameter("@birthday", dt_birthday.Value);
                    nhts = chk_nhts.Checked ? 1 : 0;
                    Program.da.addParameter("@nhts", nhts);
                    _4ps = this.chk_4ps.Checked ? 1 : 0;
                    Program.da.addParameter("@_4ps", _4ps);

                    Program.da.addParameter("@non_nhts", 0);
                    gender = rdn_male.Checked ? 1 : 0;
                    Program.da.addParameter("@gender", gender);
                    Program.da.addParameter("@date_registeer", DateTime.Now);
                    Program.da.addParameter("@batch", this.num_batch.Value);
                    Program.da.addParameter("@process_by", userinfo.first_name + " " + userinfo.middle_name + " " + userinfo.last_name);
                    if (Program.da.executeCommand())
                    {
                        EnableObject = false;
                        UpdateImage(LatestID, pictureBox1.Image);


                        CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Saved", mainform);
                        ClearSearchName();
                        textBox6.Text = "";
                        cellenter = true;
                        LoadList(textBox6.Text);
                        EnableSave = false;


                    }
                    break;
                case "edit":
                    Mainform form = (Mainform)this.ParentForm;
                    if (CustomMessageForm.CustomMessageBox.Confirm("Update Confirmation", "Do you want to save changes?", form))
                    {
                        Program.da.createCommand("sp_update_workersinformations");
                        Program.da.useStoreProcedure();
                        Program.da.addParameter("@f_name", txt_name.Text);
                        Program.da.addParameter("@m_name", txt_middle_name.Text);
                        Program.da.addParameter("@l_name", txt_last_name.Text);
                        Program.da.addParameter("@barangay", cbo_barangay.Text);
                        Program.da.addParameter("@contact_number", txt_contact_number.Text);
                        Program.da.addParameter("@birthday", dt_birthday.Value.ToString("yyyy-MM-dd"));
                        nhts = chk_nhts.Checked ? 1 : 0;
                        Program.da.addParameter("@nhts", nhts);
                        _4ps = this.chk_4ps.Checked ? 1 : 0;
                        Program.da.addParameter("@_4ps", _4ps);

                        Program.da.addParameter("@non_nhts", 0);
                        gender = rdn_male.Checked ? 1 : 0;
                        Program.da.addParameter("@gender", gender);
                        Program.da.addParameter("@id", cfwid);
                        Program.da.addParameter("@batch", this.num_batch.Value);
                        Program.da.addParameter("@process_by", userinfo.first_name + " " + userinfo.middle_name + " " + userinfo.last_name);
                        if (Program.da.executeCommand())
                        {
                            EnableObject = false;
                            UpdateImage(cfwid, pictureBox1.Image);
                            CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Edited", form);
                            LoadList(textBox6.Text);
                            EnableSave = false;
                        }
                        else
                        {
                            CustomMessageForm.CustomMessageBox.Show("Warning", Program.da.Error, form);

                        }
                    }
                    else
                    {
                        return;
                    }
                    break;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ClearSearchName();
            textBox6.Text = "";

            LoadList(textBox6.Text);

            EnableSave = false;
            EnableObject = false;
            action = "";
        }
        private void LoadList(string value)
        {
            mgrid.DataSource = null;
            string searchparam = "and searchfield like '%" + value + "%'";
            if(value.Equals("")){
            
            }
            if (!param.Equals("")) {
                searchparam = "";
            }

            Program.da.createCommand("select x.* from (select Upper(concat (f_name,' ',m_name,' ',l_name)) name,concat (f_name,m_name,l_name,contact_number,barangay)searchfield ,*,'Alfie Opo' as DevelopBy from workersinformatiions ) x where DevelopBy='Alfie Opo' " + param + " " + searchparam + " ORDER BY id DESC");
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
                materialLabel5.Text = "Number of Person :" + dt.Rows.Count;
            }
            else
            {
                materialLabel5.Text = "Number of Person : 0";
            }
            if (!SearhName.Replace(" ", "").Equals(""))
            {
                view.Visible = true;
            }
            else
            {
                view.Visible = false;
            }
        }







        private void mgrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (cellenter)
            {
                if (SearhName.Replace(" ", "").Equals("")) { Select(e); }

            }
        }
        private void Select(DataGridViewCellEventArgs e)
        {
            try
            {

                cfwid = mgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                _name = mgrid.Rows[e.RowIndex].Cells[1].Value.ToString();


                Program.da.createCommand("select x.* from (select *,CONCAT(f_name,m_name,l_name,barangay) searchfield from workersinformatiions)x where x.id=" + cfwid);
                if (Program.da.fillCommand())
                {
                    DataTable dt = new DataTable();
                    dt = Program.da.getTable();
                    DataRow dr = dt.Rows[0];
                    txt_contact_number.Text = dr["contact_number"].ToString();
                    txt_last_name.Text = dr["l_name"].ToString();
                    txt_middle_name.Text = dr["m_name"].ToString();
                    txt_name.Text = dr["f_name"].ToString();
                    cbo_barangay.Text = dr["barangay"].ToString();
                    dt_birthday.Value = DateTime.Parse(dr["birthday"].ToString());
                    label7.Text = "Date Registered :" + DateTime.Parse(dr["date_registeer"].ToString()).ToLongDateString();

                    txt_age.Text = GetAge;


                    try { pictureBox1.Image = byteArrayToImage((byte[])dr["image"]); }
                    catch (Exception xx) { pictureBox1.Image = Properties.Resources.Users_Male; }
                    try
                    {
                        num_batch.Value = int.Parse(dr["batch"].ToString());
                    }
                    catch (Exception ex)
                    {
                        num_batch.Value = 1;
                    }
                    if (dr["gender"].ToString().Equals("1"))
                    {
                        rdn_male.Checked = true;
                        rdn_female.Checked = false;
                    }
                    else
                    {
                        rdn_female.Checked = true;
                        rdn_male.Checked = false;
                    }

                    if (dr["nhts"].ToString().Equals("1"))
                    {
                        chk_nhts.Checked = true;
                    }
                    else
                    {
                        chk_nhts.Checked = false;
                    }

                    if (dr["_4ps"].ToString().Equals("1"))
                    {
                        chk_4ps.Checked = true;
                    }
                    else
                    {
                        chk_4ps.Checked = false;
                    }


                }
            }
            catch (Exception xx)
            {

            }
        }
        private void Clear()
        {
            txt_name.Clear();
            txt_contact_number.Clear();
            txt_last_name.Clear();
            txt_middle_name.Clear();
            chk_4ps.Checked = false;
            chk_nhts.Checked = false;

            rdn_female.Checked = false;
            rdn_male.Checked = false;
            dt_birthday.Value = DateTime.Now;
            cbo_barangay.SelectedIndex = 14;
            label7.Text = DateTime.Now.ToLongDateString();
            num_batch.Value = 1;
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
          if (Keys.Back == e.KeyCode)
            {
                ClearSearchName();
                action = "";
            }
           
            EnableObject = false;
            cellenter = true;
             
                LoadList(textBox6.Text);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void UpdateImage(string id, Image image)
        {
            Program.da.createCommand("sp_update_image");
            Program.da.useStoreProcedure();
            Program.da.addParameter("@id", id);
            Program.da.addParameter("@image", imageToByteArray(image));
            if (Program.da.executeCommand())
            {

            }
        }

        private string LatestID
        {
            get
            {
                Program.da.createCommand("Select Max(id) from workersinformatiions");
                if (Program.da.fillCommand())
                {
                    DataTable dt = new DataTable();
                    dt = Program.da.getTable();
                    return dt.Rows[0][0].ToString();
                }
                return "0";
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (msgbox.Confirm("Are you sure you want to exit?", "Exit Confirmation"))
            {
                Application.Exit();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chk_nhts_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool EnableSave
        {
            set
            {

                btn_add.Enabled = !value;
                btn_edit.Enabled = !value;
                btn_delete.Enabled = !value;
                pictureBox1.Image = Properties.Resources.Users_Male;
                btn_save.Enabled = value;
                btn_cancel.Enabled = value;
                if (action.Equals("add") || action.Equals("cancel"))
                {
                    Clear();
                }

            }
        }
        private bool EnableObject
        {
            set
            {
                txt_name.Enabled = value;
                txt_contact_number.Enabled = value;
                txt_last_name.Enabled = value;
                txt_middle_name.Enabled = value;
                chk_4ps.Enabled = value;
                chk_nhts.Enabled = value;

                rdn_female.Enabled = value;
                rdn_male.Enabled = value;
                dt_birthday.Enabled = value;
                cbo_barangay.Enabled = value;
                label7.Enabled = value;
                num_batch.Enabled = value;
            }
        }




        private string SearhName
        {
            get
            {

                return _f_name + " " + _m_name + " " + _l_name;
            }

        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {

            _f_name = txt_name.Text;
            textBox6.Text = SearhName;
            LoadList(textBox6.Text);
        }

        private void txt_middle_name_KeyUp(object sender, KeyEventArgs e)
        {
            _m_name = txt_middle_name.Text;
            textBox6.Text = SearhName;
            LoadList(textBox6.Text);
        }

        private void txt_last_name_KeyUp(object sender, KeyEventArgs e)
        {
            _l_name = txt_last_name.Text;
            textBox6.Text = SearhName;
            LoadList(textBox6.Text);
        }

        private void cbo_barangay_DropDownClosed(object sender, EventArgs e)
        {
            barangay = cbo_barangay.Text;

        }


        private void mgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                try
                {
                    infoform form = new infoform(mgrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    form.Show();
                    return;
                }
                catch (Exception xx) { }
            }


            ClearSearchName();
            action = "";
            EnableSave = false;
            EnableObject = false;
            if (action.Equals("add"))
            {
                view.Visible = false;
            }
            Select(e);

        }

        private void mgrid_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mgrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            cellenter = true;

        }

        private void mgrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            cellenter = !SearhName.Replace(" ", "").Equals("");

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            cellenter = false;
        }
        private void ClearSearchName()
        {
            _f_name = "";
            _l_name = "";
            _m_name = "";
        }
        public string GetAge
        {
            get
            {
                try
                {
                    DateTime birthday = dt_birthday.Value;
                    DateTime reference = DateTime.Now;
                    int age = reference.Year - birthday.Year;
                    if (reference < birthday.AddYears(age)) age--;

                    return age.ToString(); ;
                }
                catch (Exception xx)
                {
                    return "0";
                }
            }
        }

        private void dt_birthday_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = GetAge;
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Mainform form = (Mainform)this.ParentForm;
            CustomMessageForm.CustomMessageBox.Show("Message", "Successfully Saved", form);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Mainform form = (Mainform)this.ParentForm;
            CustomMessageForm.CustomMessageBox.Show("Warning", "Warning", form);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Mainform form = (Mainform)this.ParentForm;
            CustomMessageForm.CustomMessageBox.Show("Error", "Error", form);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Mainform form = (Mainform)this.ParentForm;
            CustomMessageForm.CustomMessageBox.Show("Confirmation", "Error", form);
        }
        private bool NotvalidtoSave
        {
            get
            {
                return txt_name.Text.Equals("") || txt_last_name.Text.Equals("");
            }
        }

        private void textBox6_MouseEnter(object sender, EventArgs e)
        {
            textBox6.SelectionStart = 0;
            textBox6.SelectionLength = textBox6.Text.Length;
            EnableSave = false;
            EnableObject = false;
            this.action = "";
        }

        private void erasetextbox(object sender, EventArgs e)
        {

        }

        private string param
        {
            get
            {
                _param = new List<string>();
                if (action.Equals("add"))
                {

                    if (!txt_name.Text.Equals(""))
                    {
                        _param.Add("and " + txt_name.Tag.ToString() + " like '%" + txt_name.Text + "%'");
                    }
                    if (!txt_middle_name.Text.Equals(""))
                    {
                        _param.Add("and " + txt_middle_name.Tag.ToString() + " like '%" + txt_middle_name.Text + "%'");
                    }
                    if (!txt_last_name.Text.Equals(""))
                    {
                        _param.Add("and " + txt_last_name.Tag.ToString() + " like '%" + txt_last_name.Text + "%'");
                    }
                     
                }
                return string.Join(" ", _param);
            }
        }

    }
}
