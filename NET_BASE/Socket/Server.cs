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
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }
        private void Server_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        //1:服务器开始监听
        private void btn_Click(object sender, EventArgs e)
        {
            string ip = tbip.Text.Trim();  //ip地址
            int dk = Convert.ToInt32(tbdk.Text.Trim());  //端口号

            IPAddress ipaddress = IPAddress.Parse(ip);
            IPEndPoint ippoint = new IPEndPoint(ipaddress, dk);

            //创建Socket，监听客户端的连接
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                sk.Bind(ippoint);  //Socket绑定ip地址和端口号，监听此ip和端口号
                sk.Listen(10);   //设置一个时刻的最大监听数量10
                showMsg("开始监听客户端。。。。");

                //接收来自客户端发送的消息---使用线程
                Thread th = new Thread(acceptInfo);
                th.IsBackground = true;
                th.Start(sk);
            }
            catch (Exception ex)
            {
                showMsg(ex.Message);
            }

        }

        //2:发送信息
        private void btnfs_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buff = Encoding.Default.GetBytes(textBox1.Text.ToString());
                foreach (string str in socketarr.Keys)
                {
                    socketarr[str].Send(buff);
                }
            }
            catch (Exception ee)
            {
                showMsg(ee.Message.ToString());
            }
        }

        //-------方法-------
        //-------接收客户端的连接信息-----
        //-------定义一个集合，存放客户端地址和名称-------
        Dictionary<string, Socket> socketarr = new Dictionary<string, Socket>();
        void acceptInfo(object ob)
        {
            Socket st = ob as Socket;   //ob为连接的Socket
            while (true)
            {
                //通信用socket
                try
                {
                    //创建通信用的Socket
                    Socket s = st.Accept();
                    string point = s.RemoteEndPoint.ToString();
                    //IPEndPoint endPoint = (IPEndPoint)client.RemoteEndPoint;
                    string me = Dns.GetHostName();//得到本机名称

                    showMsg(point + " " + me + "连接成功！！！");
                    socketarr.Add(point, s);

                    //接收消息
                    Thread th = new Thread(ReceiveMsg);
                    th.IsBackground = true;
                    th.Start(s);
                }
                catch (Exception e)
                {
                    e.Message.ToString();
                    break;
                }
            }
        }
        //-------监听内容先是到文本框中-------
        void showMsg(string msg)
        {
            tb1.AppendText(msg + "\r\n");
        }
        //客户端金额服务器之间发消息
        void ReceiveMsg(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                //接收客户端发送过来的数据
                try
                {
                    //定义byte数组存放从客户端接收过来的数据
                    byte[] bt = new byte[1024 * 1024 * 1];
                    //将接收过来的数据放到bt中，并返回实际接受数据的长度
                    int len = client.Receive(bt);
                    //将字节转换成字符串
                    if (len > 0)
                    {
                        string words = Encoding.Default.GetString(bt, 0, len);
                        showMsg(client.RemoteEndPoint.ToString() + ":" + words);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    showMsg(ex.Message);
                    break;
                }
            }
        }

    }
}





