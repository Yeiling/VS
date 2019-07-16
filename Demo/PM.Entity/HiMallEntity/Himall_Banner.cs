using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Banner
    {
           public Himall_Banner(){


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
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:导航名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:导航显示位置
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Position {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

           /// <summary>
           /// Desc:跳转URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:显示在哪个终端
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Platform {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UrlType {get;set;}

           /// <summary>
           /// Desc:开启或者关闭
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int STATUS {get;set;}

           /// <summary>
           /// Desc:能否删除
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int EnableDelete {get;set;}

    }
}
