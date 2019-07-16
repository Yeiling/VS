using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_DistributionRanking
    {
           public Himall_DistributionRanking(){


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
           public long BatchId {get;set;}

           /// <summary>
           /// Desc:销售员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemberId {get;set;}

           /// <summary>
           /// Desc:成交数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Quantity {get;set;}

           /// <summary>
           /// Desc:成交金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:已结算金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Settlement {get;set;}

           /// <summary>
           /// Desc:未结算金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal NoSettlement {get;set;}

    }
}
