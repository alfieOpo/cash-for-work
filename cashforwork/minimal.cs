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
    public partial class minimal : MaterialForm
    {
        public minimal()
        {
            InitializeComponent();
        }

        private void minimal_Load(object sender, EventArgs e)
        {
            Loadlist();
        }
        private void Loadlist()
        {
            main_panel.Controls.Clear();
            Program.da.createCommand("select top 10 x.* from (select Upper(concat (f_name,' ',m_name,' ',l_name)) name ,*,'Alfie Opo' as DevelopBy from workersinformatiions ) x");
            if (Program.da.fillCommand())
            {
                DataTable dt = new DataTable();
                dt = Program.da.getTable();

                foreach (DataRow dr in dt.Rows)
                {
                    minimalAdapter adapter = new minimalAdapter();
                    adapter.Fullname = dr["name"].ToString();
                    adapter.Barangay = dr["barangay"].ToString();
                    adapter.ContactNumber = dr["contact_number"].ToString();
                    adapter.Batch=dr["batch"].ToString();    
                    byte[] byt=(byte[])dr["image"];
                    Image img=byteArrayToImage();
                    adapter.Picture = img;                 
                   // adapter.Picture = Properties.Resources.Users_Male;           
                    adapter.Dock = DockStyle.Top;
                    main_panel.Controls.Add(adapter);
                }
            }
        }
        public Image byteArrayToImage()
        {
            try
            {
                //MemoryStream ms = new MemoryStream(byteArrayIn);
                //Image returnImage = Image.FromStream(ms);
            //    return returnImage;
                return Properties.Resources.Users_Male;
            }
            catch (Exception xx) {
                return Properties.Resources.Users_Male;
            }
        }
    }
}
