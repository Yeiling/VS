using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberConsumeStatistic
    {
           public Himall_MemberConsumeStatistic(){


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
           public long UserId {get;set;}

           /// <summary>
           /// Desc:门店Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:净消费金额(退款需要维护)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal NetAmount {get;set;}

           /// <summary>
           /// Desc:消费次数(退款不维护)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderNumber {get;set;}

    }
}
