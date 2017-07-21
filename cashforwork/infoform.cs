using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashforwork
{
    public partial class infoform : MaterialForm
    {
        string id = "";
        public infoform(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void infoform_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadData() {
            Program.da.createCommand("sp_select_indiinfo");
            Program.da.useStoreProcedure();
            Program.da.addParameter("@id",this.id); 
            if(Program.da.fillCommand()){
                DataTable dt = new DataTable();
                dt = Program.da.getTable();
                DataRow dr = dt.Rows[0];
                txt_contact_number.Text = dr["contact_number"].ToString();
                txt_last_name.Text = dr["l_name"].ToString();
                txt_middle_name.Text = dr["m_name"].ToString();
                txt_first_name.Text = dr["f_name"].ToString();
                txt_barangay.Text = dr["barangay"].ToString();
                txt_birthday.Text = DateTime.Parse(dr["birthday"].ToString()).ToLongDateString();
                lbl_dateregister.Text = "Date Registered :" + DateTime.Parse(dr["date_registeer"].ToString()).ToLongDateString();
                txt_batch.Text = dr["batch"].ToString();
                txt_gender.Text=dr["gender"].ToString();
                pictureBox1.Image = byteArrayToImage((byte[])dr["image"]);
                txt_age.Text = GetAge;
            }
        }
        public  string GetAge
        {
            get
            {
                try
                {
                    DateTime birthday = DateTime.Parse(txt_birthday.Text);
                    DateTime reference = DateTime.Now;
                    int age = reference.Year - birthday.Year;
                    if (reference < birthday.AddYears(age)) age--;

                    return age.ToString(); ;
                }
                catch (Exception xx) {
                    return "0";
                }
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}
