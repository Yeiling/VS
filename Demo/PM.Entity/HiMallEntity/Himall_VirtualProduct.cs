using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///虚拟商品表
    ///</summary>
    public partial class Himall_VirtualProduct
    {
           public Himall_VirtualProduct(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:商品有效期类型(0=长期有效，1=自定义日期)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool ValidityType {get;set;}

           /// <summary>
           /// Desc:自定义开始时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? StartDate {get;set;}

           /// <summary>
           /// Desc:自定义结束时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? EndDate {get;set;}

           /// <summary>
           /// Desc:核销码生效类型（1=立即生效，2=付款完成X小时后生效，3=次日生效）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte EffectiveType {get;set;}

           /// <summary>
           /// Desc:付款完成X小时后生效
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Hour {get;set;}

           /// <summary>
           /// Desc:1=支持有效期内退款，2=支持随时退款，3=不支持退款
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte SupportRefundType {get;set;}

           /// <summary>
           /// Desc:使用须知
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UseNotice {get;set;}

    }
}
