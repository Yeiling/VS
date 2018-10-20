using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Socket_APP
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        //创建一个公共的Socket
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //1:连接服务器
        private void button1_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text.Trim();
            int dk = Convert.ToInt32(textBox2.Text.Trim());

            IPAddress ipaddress = IPAddress.Parse(ip);
            IPEndPoint point = new IPEndPoint(ipaddress, dk);

            try
            {
                client.Connect(point);
                GetMsg("连接的服务器是：" + point.Address.ToString());

                //连接成功后，接收服务器发送的信息
                Thread th = new Thread(ReceiveMsg);
                th.IsBackground = true;
                th.Start(client);
            }
            catch (Exception ex)
            {
                GetMsg(ex.Message);
            }

        }

        //2:向服务器发送信息
        private void button2_Click(object sender, EventArgs e)
        {
            if (client != null)
            {
                try
                {
                    byte[] buffers = Encoding.Default.GetBytes(textBox4.Text.ToString());
                    client.Send(buffers);
                }
                catch (Exception ee)
                {
                    GetMsg(ee.Message.ToString());
                }
            }
        }


        //--------方法-------

        //收到信息添加在文本框
        void GetMsg(string msg)
        {
            textBox3.AppendText(msg + "\r\n");
        }

        //发送消息
        void ReceiveMsg(object ob)
        {
            Socket sk = ob as Socket;
            while (true)
            {
                //接收客户端发送过来的数据
                try
                {
                    //定义byte数组存放从客户端接收过来的数据
                    byte[] bt = new byte[1024 * 1024];
                    //将接收过来的数据放到bt中，并返回实际接受数据的长度
                    int len = sk.Receive(bt);
                    //将字节转换成字符串
                    if (len > 0)
                    {
                        string words = Encoding.Default.GetString(bt, 0, len);
                        GetMsg(sk.RemoteEndPoint.ToString() + ":" + words);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    GetMsg(ex.Message);
                    break;
                }
            }
        }



    }
}
