using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WXAccToken
    {
           public Himall_WXAccToken(){


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
           /// Nullable:True
           /// </summary>           
           public string AppId {get;set;}

           /// <summary>
           /// Desc:微信访问令牌
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AccessToken {get;set;}

           /// <summary>
           /// Desc:微信令牌过期日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime TokenOutTime {get;set;}

    }
}
