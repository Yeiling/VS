using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FavoriteShop
    {
           public Himall_FavoriteShop(){


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
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:分类标签
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tags {get;set;}

           /// <summary>
           /// Desc:收藏日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime Date {get;set;}

    }
}
