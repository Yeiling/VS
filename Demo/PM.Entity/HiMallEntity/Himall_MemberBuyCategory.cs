using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberBuyCategory
    {
           public Himall_MemberBuyCategory(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:会员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:类别ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CategoryId {get;set;}

           /// <summary>
           /// Desc:购买次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrdersCount {get;set;}

    }
}
