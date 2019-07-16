using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_HomeFloor
    {
           public Himall_HomeFloor(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:楼层名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string FloorName {get;set;}

           /// <summary>
           /// Desc:楼层小标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SubName {get;set;}

           /// <summary>
           /// Desc:显示顺序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

           /// <summary>
           /// Desc:是否显示的首页
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsShow {get;set;}

           /// <summary>
           /// Desc:楼层所属样式（目前支持2套）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int StyleLevel {get;set;}

           /// <summary>
           /// Desc:楼层的默认tab标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DefaultTabName {get;set;}

           /// <summary>
           /// Desc:商品样式，0：默认，1：一排5个，2：一排4个
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CommodityStyle {get;set;}

           /// <summary>
           /// Desc:显示方式，0=默认，1=平铺展示，2=左右轮播
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DisplayMode {get;set;}

    }
}
