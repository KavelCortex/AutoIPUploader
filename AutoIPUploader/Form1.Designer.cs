namespace AutoIPUploader
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.UploadButton = new System.Windows.Forms.Button();
            this.lblUplaodStatus = new System.Windows.Forms.Label();
            this.btnLoop = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UploadStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.AutoSize = true;
            this.UploadButton.Location = new System.Drawing.Point(327, 402);
            this.UploadButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(150, 46);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "立即上传";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // lblUplaodStatus
            // 
            this.lblUplaodStatus.AutoSize = true;
            this.lblUplaodStatus.ForeColor = System.Drawing.Color.Red;
            this.lblUplaodStatus.Location = new System.Drawing.Point(234, 98);
            this.lblUplaodStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUplaodStatus.Name = "lblUplaodStatus";
            this.lblUplaodStatus.Size = new System.Drawing.Size(0, 24);
            this.lblUplaodStatus.TabIndex = 1;
            // 
            // btnLoop
            // 
            this.btnLoop.AutoSize = true;
            this.btnLoop.Location = new System.Drawing.Point(84, 402);
            this.btnLoop.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(164, 46);
            this.btnLoop.TabIndex = 2;
            this.btnLoop.Text = "开始持续上传";
            this.btnLoop.UseVisualStyleBackColor = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UploadStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(568, 38);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UploadStatus
            // 
            this.UploadStatus.Name = "UploadStatus";
            this.UploadStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLoop);
            this.Controls.Add(this.lblUplaodStatus);
            this.Controls.Add(this.UploadButton);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label lblUplaodStatus;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UploadStatus;
    }
}

