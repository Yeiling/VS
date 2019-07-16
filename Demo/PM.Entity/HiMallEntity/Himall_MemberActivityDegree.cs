using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberActivityDegree
    {
           public Himall_MemberActivityDegree(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:会员编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:是否为一个月活跃用户
           /// Default:b'0'
           /// Nullable:False
           /// </summary>           
           public bool OneMonth {get;set;}

           /// <summary>
           /// Desc:是否为三个月活跃用户
           /// Default:b'0'
           /// Nullable:False
           /// </summary>           
           public bool ThreeMonth {get;set;}

           /// <summary>
           /// Desc:是否为六个月活跃用户
           /// Default:b'0'
           /// Nullable:False
           /// </summary>           
           public bool SixMonth {get;set;}

           /// <summary>
           /// Desc:一个月活跃会员有效时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OneMonthEffectiveTime {get;set;}

           /// <summary>
           /// Desc:三个月活跃会员有效时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ThreeMonthEffectiveTime {get;set;}

           /// <summary>
           /// Desc:六个月活跃会员有效时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SixMonthEffectiveTime {get;set;}

    }
}
