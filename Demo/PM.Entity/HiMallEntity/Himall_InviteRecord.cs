using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_InviteRecord
    {
           public Himall_InviteRecord(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserName {get;set;}

           /// <summary>
           /// Desc:邀请的用户
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RegName {get;set;}

           /// <summary>
           /// Desc:邀请获得的积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int InviteIntegral {get;set;}

           /// <summary>
           /// Desc:被邀请获得的积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RegIntegral {get;set;}

           /// <summary>
           /// Desc:注册时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime RegTime {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long UserId {get;set;}

           /// <summary>
           /// Desc:被邀请的用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long RegUserId {get;set;}

           /// <summary>
           /// Desc:获得积分时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime RecordTime {get;set;}

    }
}
