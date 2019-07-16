using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CashDepositDetail
    {
           public Himall_CashDepositDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CashDepositId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AddDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Balance {get;set;}

           /// <summary>
           /// Desc:操作类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:充值类型（银联、支付宝之类的）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? RechargeWay {get;set;}

    }
}
