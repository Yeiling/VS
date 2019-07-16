using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FlashSale
    {
           public Himall_FlashSale(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:待审核,进行中,已结束,审核未通过,管理员取消
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:活动开始日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime BeginDate {get;set;}

           /// <summary>
           /// Desc:活动结束日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndDate {get;set;}

           /// <summary>
           /// Desc:限制每人购买的数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LimitCountOfThePeople {get;set;}

           /// <summary>
           /// Desc:仅仅只计算在限时购里的销售数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SaleCount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CategoryName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ImagePath {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal MinPrice {get;set;}

    }
}
