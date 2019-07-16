using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberGroup
    {
           public Himall_MemberGroup(){


           }
           /// <summary>
           /// Desc:Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:门店编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:统计类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int StatisticsType {get;set;}

           /// <summary>
           /// Desc:统计数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Total {get;set;}

    }
}
