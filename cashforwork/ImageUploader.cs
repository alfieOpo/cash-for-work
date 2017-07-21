using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using AForge.Video.DirectShow;
using AForge.Video;
using MaterialSkin.Controls;

namespace cashforwork
{
    public partial class ImageUploader : MaterialForm
    {
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;
        OpenFileDialog ofd = new OpenFileDialog();
        private bool valid = false;
        private Image _image;
        public ImageUploader()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cam.IsRunning)
                {
                    _image = pictureBox3.Image;
                    cam.Stop();
                    
                    _image = pictureBox3.Image;
                    this.Close();
                }
            }
            catch (Exception xx) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Person Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox2.Image = new Bitmap(dlg.FileName);
                    _image = pictureBox2.Image;
                }
            }
        }
        public Image ImageValue {
            get { return _image; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImageUploader_Load(object sender, EventArgs e)
        {
            try
            {
                webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo VideopCaptureDevice in webcam)
                {
                    cbo_webcam.Items.Add(VideopCaptureDevice.Name);
                }
                cbo_webcam.SelectedIndex = 0;
            }
            catch (Exception xx) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cam = new VideoCaptureDevice(webcam[cbo_webcam.SelectedIndex].MonikerString);
                cam.NewFrame += new NewFrameEventHandler(cam_NewFrame);
                cam.Start();
            }
            catch (Exception xx) { }
        }
        private void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox3.Image = bit;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try { cam.Stop(); }
            catch (Exception xx) { }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public   VideoCaptureDevice Camera {
            get { 
            return cam;
            }
        }

    }
}
