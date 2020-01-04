using System;
using System.Collections.Generic;
using System.Text;

namespace 尚硅谷数据结构和算法.LinkLists
{
    /// <summary>
    /// 哈希表（哈希链表），也叫散列表
    /// </summary>
    public class HashLinkList<T>
    {
        /// <summary>
        /// 数量
        /// </summary>
        private int Count;
        /// <summary>
        /// 单链表
        /// </summary>
        private SingleLinkList<T>[] singleLinkList;
        private HashLinkList() : this(20)
        { }
        public HashLinkList(int length)
        {
            singleLinkList = new SingleLinkList<T>[length];
            for (int i = 0; i < singleLinkList.Length; i++)
                singleLinkList[i] = new SingleLinkList<T>();
        }

        /// <summary>
        /// 获取HashCode编码
        /// </summary>
        /// <param name="model"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public int HasdCode(T model, Func<T, int> func) => func(model);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public bool Add(T model, Func<T, int> func)
        {
            int code = HasdCode(model, func);
            singleLinkList[code].Add(model);
            Count++;
            return true;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public bool Del(T model, Func<T, int> func)
        {
            int code = HasdCode(model, func);
            //单链表删除元素

            Count--;
            return true;
        }


    }


}
