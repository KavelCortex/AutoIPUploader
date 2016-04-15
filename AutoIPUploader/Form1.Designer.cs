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
            this.SuspendLayout();
            // 
            // UploadButton
            // 
            this.UploadButton.AutoSize = true;
            this.UploadButton.Location = new System.Drawing.Point(101, 186);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 0;
            this.UploadButton.Text = "立即上传";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // lblUplaodStatus
            // 
            this.lblUplaodStatus.AutoSize = true;
            this.lblUplaodStatus.ForeColor = System.Drawing.Color.Red;
            this.lblUplaodStatus.Location = new System.Drawing.Point(117, 49);
            this.lblUplaodStatus.Name = "lblUplaodStatus";
            this.lblUplaodStatus.Size = new System.Drawing.Size(0, 12);
            this.lblUplaodStatus.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblUplaodStatus);
            this.Controls.Add(this.UploadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.Label lblUplaodStatus;
    }
}

