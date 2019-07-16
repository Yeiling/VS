using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OrderComment
    {
           public Himall_OrderComment(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:店铺名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:评价日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CommentDate {get;set;}

           /// <summary>
           /// Desc:包装评分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PackMark {get;set;}

           /// <summary>
           /// Desc:物流评分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DeliveryMark {get;set;}

           /// <summary>
           /// Desc:服务评分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ServiceMark {get;set;}

    }
}
