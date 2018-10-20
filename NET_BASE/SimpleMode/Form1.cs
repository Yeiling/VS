using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleMode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //点击按钮创建新窗体
        private void Btn_Click(object sender, EventArgs e)
        {
            //窗体单例模式步骤
            //1：将Form2的构造函数私有化
            //2:提供一个静态方法，返回一个Form2对象
            //3：创建一个单例
            Form2 f2 = Form2.GetForm();
            f2.Show();

        }
    }
}
