using System;

namespace 数据结构和算法.Model
{
    /// <summary>
    /// 模拟单链表
    /// </summary>
    public class SingleArryList
    {
        /// <summary>
        /// 头结点，不存储数据，为了编写方便
        /// </summary>
        private Node Header;
        /// <summary>
        /// 节点总数
        /// </summary>
        private int _counts { get; set; }
        #region 接口方法实现
        public int Count
        {
            get
            {
                return _counts; //数组元素个数
            }
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="t">新元素</param>
        public void Add(object t)
        {
            Add(Count, t);
        }
        /// <summary>
        /// 制定位置添加元素
        /// </summary>
        /// <param name="index">要添加的索引位置</param>
        /// <param name="t">新元素</param>
        public void Add(int index, object obj)
        {
            //使用头结点
            Node temp = Header;

            //创建新节点
            Node newNode = new Node(obj);

            //找到要添加的索引index位置节点的前一个节点
            for (int i = 0; i < index; i++)
            {

            }

        }
        /// <summary>
        /// 是否含有元素
        /// </summary>
        /// <param name="t">元素</param>
        /// <returns>是否包含</returns>
        public bool Contains(object t)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 依据索引查找元素
        /// </summary>
        /// <param name="index">索引位置</param>
        /// <returns>目标元素</returns>
        public object Get(int index)
        {
            return null;
        }
        /// <summary>
        /// 元素的位置
        /// </summary>
        /// <param name="t">元素</param>
        /// <returns>索引位置</returns>
        public int Indexof(object t)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 数组是否为空
        /// </summary>
        /// <returns>是否为空</returns>
        public bool IsEmpty()
        {
            return Count > 0;
        }
        /// <summary>
        /// 移除一个元素
        /// </summary>
        /// <param name="t">移除目标元素</param>
        public void Remove(object t)
        {

        }
        /// <summary>
        /// 移除一个元素(依据索引)
        /// </summary>
        /// <param name="index">索引位置</param>
        public void Remove(int index)
        {

        }
        /// <summary>
        /// 替换元素
        /// </summary>
        /// <param name="index">索引位置</param>
        /// <param name="newModel">新元素</param>
        /// <returns>返回新元素</returns>
        public object Replace(int index, object newModel)
        {

            return null;
        }
        #endregion
    }
}
