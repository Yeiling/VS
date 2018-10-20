using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Socket_WFM
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        public delegate void GetTxtMsg(string str);  //定义一个委托
        List<Socket> Sarry = new List<Socket>();   //客户端连接对象集合


        //开始监听
        private void JTStart_Click(object sender, EventArgs e)
        {
            txtMsg.Text = "正在执行Socket,如下:";
            //1:创建Socket连接监听对象sk(AddressFamily.InterNetwork:设置网络寻址协议;SocketType.Stream:数据传输方式;ProtocolType.Tcp:设置传输协议)
            Socket sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2:给监听绑定一个端口号  
            IPAddress ip = IPAddress.Parse(textIP.Text);  //获取ip地址
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(textDK.Text));  //绑定ip和端口号
            sk.Bind(point);
            //3:开始监听
            sk.Listen(10);
            txtMsg.Text += ShowMsg("正在监听...");
            //4:开始接收客户端的连接
            txtMsg.Text += ShowMsg("正在等待客户端连接...\r\n");

            ThreadPool.QueueUserWorkItem(this.StartAccept, sk);

            #region 此处代码封装在一个方法中,在线程中执行
            ////---------------Accept()方法执行会一直等待客户端连接,会阻塞主线程----------
            //Socket proSocket = sk.Accept();  //返回一个代理通信的socket对象

            //txtMsg.Text += ShowMsg("正在等待客户端连接...");
            //txtMsg.Text += string.Format("客户端{0}连接上了\r\n", proSocket.RemoteEndPoint.ToString());

            ////5:与客户端发送消息
            //string str = DateTime.Now.ToString();
            //byte[] bt = Encoding.Default.GetBytes(str);
            //proSocket.Send(bt, 0, bt.Length, SocketFlags.None);

            //txtMsg.Text = ShowMsg(str);

            ////6:通信的Socket停止连接(停止客户端与服务器的连接)
            //proSocket.Shutdown(SocketShutdown.Both);
            //proSocket.Close();

            ////7:监听的Socket关闭掉连接(延迟5秒)
            //sk.Close();
            #endregion
        }
        //向客户端发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMsgToClient(Sarry);
        }
        //服务器接收客户端连接方法
        public void StartAccept(object obj)
        {
            //---------------Accept()方法执行会一直等待客户端连接,会阻塞主线程----------
            Socket sk = obj as Socket;
            while (true)
            {
                Socket proSocket = sk.Accept();  //返回一个代理通信的socket对象
                txtMsg.Text += string.Format("客户端连接上了,时间:" + DateTime.Now.ToString() + "\r\n", proSocket.RemoteEndPoint.ToString());

                //把连接过来的客户端对象放到集合中
                Sarry.Add(proSocket);

                //5:向客户端发送消息  telnet 127.0.0.1 8090
                #region
                //string str = DateTime.Now.ToString();
                //byte[] bt = Encoding.Default.GetBytes(str);
                //proSocket.Send(bt, 0, bt.Length, SocketFlags.None);
                //txtMsg.Text += ShowMsg(str) + "\r\n";   //把发送的消息显示在界面上
                #endregion

                //5.1接收客户端的消息,也使用通信对象proSocket
                #region
                //byte[] bts = new byte[1024 * 1024];  //设置接收到的缓冲区大小
                //int realength = proSocket.Receive(bts, 0, bts.Length, SocketFlags.None);
                //string receiveStr = Encoding.Default.GetString(bts, 0, realength);
                //txtMsg.Text += receiveStr + "\r\n";
                #endregion

                //放入线程池里执行接收消息
                ThreadPool.QueueUserWorkItem(ReceiveMsgFromClient, proSocket);

                //6:通信的Socket停止连接(停止客户端与服务器的连接)
                //proSocket.Shutdown(SocketShutdown.Both);
                //proSocket.Close();

                //7:监听的Socket关闭掉连接(延迟5秒)
                //sk.Close();
            }
        }

        //(1):向客户端发送消息方法
        public void SendMsgToClient(List<Socket> Sarry)
        {
            if (Sarry.Count > 0)
            {
                foreach (Socket s in Sarry)
                {
                    string str = txtSend.Text + "\r\n";
                    byte[] bt = Encoding.Default.GetBytes(str);
                    s.Send(bt);
                }
            }
        }
        //(2):接收客户端发送的消息
        public void ReceiveMsgFromClient(object obj)
        {
            Socket proSocket = obj as Socket;

            byte[] bts = new byte[1024 * 1024];  //设置接收到的缓冲区大小
            while (true)
            {
                int realength = proSocket.Receive(bts, 0, bts.Length, SocketFlags.None);
                if (realength == 0)
                {
                    txtMsg.Text += "\r\n对方退出了";
                    proSocket.Shutdown(SocketShutdown.Receive);  //关闭接收
                    proSocket.Close();
                    Sarry.Remove(proSocket);  //将通信Socket对象proSocket从集合中移除
                    return;
                }
                string receiveStr = Encoding.Default.GetString(bts, 0, realength);
                txtMsg.Text += "客户端" + proSocket.RemoteEndPoint.ToString() + "向你发送" + receiveStr + "\r\n";
            }
        }




        //文本框显示消息
        public static string ShowMsg(string msg)
        {
            return "\r\n" + msg;
        }


    }
}
