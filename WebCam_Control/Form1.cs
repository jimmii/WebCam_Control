using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCam_Control
{
    public partial class WebCam_Control : Form
    {
        public WebCam_Control()
        {
            InitializeComponent();
        }

        private FilterInfoCollection AvailableVideoDevices;
        private VideoCaptureDevice VideoSource;

        private void WebCam_Control_Load(object sender, EventArgs e)
        {
            AvailableVideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo Device in AvailableVideoDevices)
            {
                SelectCamera_comboBox.Items.Add(Device.Name);
            }
            SelectCamera_comboBox.SelectedItem = 0;

            VideoSource = new VideoCaptureDevice();
        }

        private void Start_Btn_Click(object sender, EventArgs e)
        {
            if (SelectCamera_comboBox.SelectedIndex >= 0)
            {             
                    VideoSource = new VideoCaptureDevice(AvailableVideoDevices[SelectCamera_comboBox.SelectedIndex].MonikerString);
                    VideoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
                    VideoSource.Start();
                
            }           
            else
                MessageBox.Show("You must select camera!", "Info", MessageBoxButtons.OK);
        }

            private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
            {
            Display_pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
            }

        private void WebCam_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((VideoSource.IsRunning == true) && (VideoSource!=null))
                VideoSource.Stop();
        }

        private void Stop_Btn_Click(object sender, EventArgs e)
        {
            if (VideoSource.IsRunning == true)
                {
                    VideoSource.Stop();
                    VideoSource = null;
                }   
        }
    }
}
