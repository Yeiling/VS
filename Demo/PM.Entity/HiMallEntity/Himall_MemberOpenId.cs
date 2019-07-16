using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberOpenId
    {
           public Himall_MemberOpenId(){


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
           /// Desc:微信OpenID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OpenId {get;set;}

           /// <summary>
           /// Desc:开发平台Openid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UnionOpenId {get;set;}

           /// <summary>
           /// Desc:开发平台Unionid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string UnionId {get;set;}

           /// <summary>
           /// Desc:插件名称（Himall.Plugin.OAuth.WeiXin）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ServiceProvider {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AppIdType {get;set;}

    }
}
