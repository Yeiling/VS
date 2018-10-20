using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Socket_APP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //打开服务器
        private void btnServer_Click(object sender, EventArgs e)
        {
            Server s = new Server();
            s.Show();
        }
        //打开客户端
        private void btnClient_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
        }

    }
}
