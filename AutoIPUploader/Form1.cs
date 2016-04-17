using System;
using System.Windows.Forms;

namespace AutoIPUploader
{
    public delegate void ThreadStart();
    public partial class Form1 : Form
    {
        public const int UPDATE_INTERVAL = 60 * 1000;
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (Upload.UploadIP())
                lblUplaodStatus.Text = "Upload #" + Upload.UploadCount + " :成功";
        }

        protected System.Timers.Timer UploadTimer;
        protected bool isLoopRunning = false;
        protected int UploadRunningTime;
        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (!isLoopRunning)
                StartLoop();
            else
                StopLoop();
        }

        private void StartLoop()
        {
            btnLoop.Text = "停止持续上传";
            UploadStatus.Text = "正在初始化上传...";
            UploadRunningTime = 0;
            UploadTimer = new System.Timers.Timer();
            UploadTimer.Interval = UPDATE_INTERVAL;
            UploadTimer.Elapsed += UploadTimer_Tick;
            UploadTimer.Start();
            isLoopRunning = true;
        }
        private void StopLoop()
        {
            UploadTimer.Dispose();
            btnLoop.Text = "开始持续上传";
            isLoopRunning = false;
        }


        private void UploadTimer_Tick(object sender, EventArgs e)
        {
            UploadStatus.Text = GetDate(++UploadRunningTime);
            if (Upload.UploadIP())
                lblUplaodStatus.Text = "Upload #" + Upload.UploadCount + " :成功";
            else
                lblUplaodStatus.Text = "Upload #" + Upload.UploadCount + " :失败";
        }
        public static string GetDate(int value)
        {
            int hour = 0;
            int minute = 0;
            int second = value;
            //second = Convert.ToInt32(value / 1000);
            if (second >= 60)
            {
                minute = second / 60;
                second %= 60;
            }
            if (minute >= 60)
            {
                hour = minute / 60;
                minute %= 60;
            }
            return (hour.ToString() + ":" + minute.ToString() + ":"+ second.ToString());
        }
    }
}
