namespace Socket_WFM
{
    partial class MainFrm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JTStart = new System.Windows.Forms.Button();
            this.textIP = new System.Windows.Forms.TextBox();
            this.textDK = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口:";
            // 
            // JTStart
            // 
            this.JTStart.Location = new System.Drawing.Point(417, 21);
            this.JTStart.Name = "JTStart";
            this.JTStart.Size = new System.Drawing.Size(75, 23);
            this.JTStart.TabIndex = 2;
            this.JTStart.Text = "开启监听";
            this.JTStart.UseVisualStyleBackColor = true;
            this.JTStart.Click += new System.EventHandler(this.JTStart_Click);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(70, 22);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(153, 21);
            this.textIP.TabIndex = 3;
            this.textIP.Text = "127.0.0.1";
            // 
            // textDK
            // 
            this.textDK.Location = new System.Drawing.Point(304, 22);
            this.textDK.Name = "textDK";
            this.textDK.Size = new System.Drawing.Size(84, 21);
            this.textDK.TabIndex = 4;
            this.textDK.Text = "8090";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 66);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(480, 225);
            this.txtMsg.TabIndex = 5;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(13, 316);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(362, 21);
            this.txtSend.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(381, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(111, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "向客户端发送消息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 349);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.textDK);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.JTStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainFrm";
            this.Text = "MainFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button JTStart;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.TextBox textDK;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
    }
}

