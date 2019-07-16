using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Gift
    {
           public Himall_Gift(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string GiftName {get;set;}

           /// <summary>
           /// Desc:需要积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int NeedIntegral {get;set;}

           /// <summary>
           /// Desc:限制兑换数量 0表示不限兑换数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LimtQuantity {get;set;}

           /// <summary>
           /// Desc:库存数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int StockQuantity {get;set;}

           /// <summary>
           /// Desc:兑换结束时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndDate {get;set;}

           /// <summary>
           /// Desc:等级要求 0表示不限定
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int NeedGrade {get;set;}

           /// <summary>
           /// Desc:虚拟销量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int VirtualSales {get;set;}

           /// <summary>
           /// Desc:实际销量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RealSales {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SalesStatus {get;set;}

           /// <summary>
           /// Desc:图片存放地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ImagePath {get;set;}

           /// <summary>
           /// Desc:顺序 默认100 数字越小越靠前
           /// Default:100
           /// Nullable:False
           /// </summary>           
           public int Sequence {get;set;}

           /// <summary>
           /// Desc:礼品价值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal GiftValue {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AddDate {get;set;}

    }
}
