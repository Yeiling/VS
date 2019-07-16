using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Menu
    {
           public Himall_Menu(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:上级ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ParentId {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:标题
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:链接地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:深度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short Depth {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short Sequence {get;set;}

           /// <summary>
           /// Desc:全路径
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FullIdPath {get;set;}

           /// <summary>
           /// Desc:终端
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Platform {get;set;}

           /// <summary>
           /// Desc:url类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int UrlType {get;set;}

    }
}
