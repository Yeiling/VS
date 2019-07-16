using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberIntegral
    {
           public Himall_MemberIntegral(){


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
           public long MemberId {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:用户历史积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int HistoryIntegrals {get;set;}

           /// <summary>
           /// Desc:用户可用积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AvailableIntegrals {get;set;}

    }
}
