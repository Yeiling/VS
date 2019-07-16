using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberSignIn
    {
           public Himall_MemberSignIn(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:最近签到时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime LastSignTime {get;set;}

           /// <summary>
           /// Desc:持续签到天数 每周期后清零
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DurationDay {get;set;}

           /// <summary>
           /// Desc:持续签到天数总数 非连续周期清零
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DurationDaySum {get;set;}

           /// <summary>
           /// Desc:签到总天数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long SignDaySum {get;set;}

    }
}
