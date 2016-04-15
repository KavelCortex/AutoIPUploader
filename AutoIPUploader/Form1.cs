using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoIPUploader
{
    public delegate void ThreadStart();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            var t = new Thread(AutoUpload);
            t.Start();
        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (Upload.UploadIP())
                lblUplaodStatus.Text = "Upload #" + Upload.UploadCount + " :成功";
        }
        private void AutoUpload()
        {
            while (true)
            {
                Upload.UploadIP();
                lblUplaodStatus.Text = "Upload #" + Upload.UploadCount + " :成功";
                Thread.Sleep(600*1000);
            }
        }
    }
}
