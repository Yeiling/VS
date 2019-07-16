using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WXshop
    {
           public Himall_WXshop(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:公众号的APPID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AppId {get;set;}

           /// <summary>
           /// Desc:公众号的AppSecret
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AppSecret {get;set;}

           /// <summary>
           /// Desc:公众号的Token
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Token {get;set;}

           /// <summary>
           /// Desc:跳转的URL
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FollowUrl {get;set;}

    }
}
