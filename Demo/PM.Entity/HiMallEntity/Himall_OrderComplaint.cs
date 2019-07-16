using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_OrderComplaint
    {
           public Himall_OrderComplaint(){


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
           /// Desc:审核状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

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
           /// Desc:店铺联系方式
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShopPhone {get;set;}

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
           /// Desc:用户联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UserPhone {get;set;}

           /// <summary>
           /// Desc:投诉日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ComplaintDate {get;set;}

           /// <summary>
           /// Desc:投诉原因
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ComplaintReason {get;set;}

           /// <summary>
           /// Desc:商家反馈信息
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SellerReply {get;set;}

           /// <summary>
           /// Desc:投诉备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PlatRemark {get;set;}

    }
}
