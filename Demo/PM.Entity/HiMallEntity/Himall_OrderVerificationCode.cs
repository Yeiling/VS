using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///订单核销码表
    ///</summary>
    public partial class Himall_OrderVerificationCode
    {
           public Himall_OrderVerificationCode(){


           }
           /// <summary>
           /// Desc:编号
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
           /// Desc:订单项ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderItemId {get;set;}

           /// <summary>
           /// Desc:核销码状态(1=待核销，2=已核销，3=退款中，4=退款完成，5=已过期)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte Status {get;set;}

           /// <summary>
           /// Desc:核销码(12位随机数)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string VerificationCode {get;set;}

           /// <summary>
           /// Desc:核销时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? VerificationTime {get;set;}

           /// <summary>
           /// Desc:核销人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string VerificationUser {get;set;}

    }
}
