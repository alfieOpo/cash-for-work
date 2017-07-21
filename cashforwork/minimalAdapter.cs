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

namespace cashforwork
{
    public partial class minimalAdapter : UserControl
    {
        public string Batch {
            set {
                lbl_batch.Text = value;
            }
        }
        public string Fullname {
            set {
                lbl_full_name.Text = value.ToUpper();   
            }
        }
        public string Barangay
        {
            set
            {
                lbl_barangay.Text = value.ToUpper();
            }
        }
        public string ContactNumber
        {
            set
            {
                lbl_contacnumber.Text = value.ToUpper();
            }
        }
        public Image Picture
        {
            set
            {
                try
                {
                    pictureBox1.Image = value;
                }
                catch (Exception xx) {
                    pictureBox1.Image = Properties.Resources.Users_Male;
                }
            }
        }
        public minimalAdapter()
        {
            InitializeComponent();
        }

        
    }
}
