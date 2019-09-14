using System;

namespace CSharp_BASE.Class
{
    public class ItcastClass
    {
        //给字段_names定义一个长度属性
        public int _count
        {
            get { return _names.Length; }  //（只读）
        }
        //字段
        private string[] _names = { "张三", "李四", "王五", "赵柳" };
        //属性
        public string names
        {
            get;
            set;
        }
        //索引器
        public string this[int index]
        {
            get
            {
                if (index < 0 || index > _count)
                    throw new Exception("索引值超出数组的范围");
                
                return _names[index];
            }
            set
            {
                _names[index] = value;
            }
        }
    }
}
