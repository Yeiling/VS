﻿using System;

namespace MyDelegate.model
{
    /// <summary>
    /// 定义价格变动委托
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    /// <returns></returns>
    public delegate string PriceChange(object sender, PriceChagedArgs args);
    /// <summary>
    /// 商店类
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// 商店名称
        /// </summary>
        public string ShopName { get; set; }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        public Shop(string name)
        {
            this.ShopName = name;
        }

        /// <summary>
        /// 定义价格变动事件
        /// </summary>
        public event PriceChange PriceChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public void OnPriceChanged(PriceChagedArgs chagedArgs)
        {
            //如果事件被注册，则发送消息给消费者
            if (PriceChanged != null)
                this.PriceChanged(this, chagedArgs);
        }
        /// <summary>
        /// 更新商品名称，并引发商品价格变动事件
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public void UpdatePrice(string name, decimal price)
        {
            PriceChagedArgs priceChagedArgs = new PriceChagedArgs(name, price);
            this.OnPriceChanged(priceChagedArgs);
        }

    }

    /// <summary>
    /// 商品价格变动参数类
    /// </summary>
    public class PriceChagedArgs : EventArgs
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public PriceChagedArgs(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
