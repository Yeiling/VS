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
    public partial class Form2 : Form
    {
        public static Form2 FormMsg = null;  //定义一个静态字段

        private Form2()   //构造函数私有化(private)
        {
            InitializeComponent();
        }

        //定义一个方法，返回值是Form2类型
        public static Form2 GetForm()
        {
            if (FormMsg == null)
            {
                FormMsg = new Form2();
            }
            return FormMsg;
        }
    }

}
