using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_InviteRule
    {
           public Himall_InviteRule(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:邀请能获得的积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int InviteIntegral {get;set;}

           /// <summary>
           /// Desc:被邀请能获得的积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RegIntegral {get;set;}

           /// <summary>
           /// Desc:分享标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShareTitle {get;set;}

           /// <summary>
           /// Desc:分享详细
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShareDesc {get;set;}

           /// <summary>
           /// Desc:分享图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShareIcon {get;set;}

           /// <summary>
           /// Desc:分享规则
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShareRule {get;set;}

    }
}
