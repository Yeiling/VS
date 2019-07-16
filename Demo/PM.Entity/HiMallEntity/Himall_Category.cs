using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Category
    {
           public Himall_Category(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:分类名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:分类图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Icon {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

           /// <summary>
           /// Desc:是否支持虚拟商品(0=否，1=是)
           /// Default:b'0'
           /// Nullable:False
           /// </summary>           
           public bool SupportVirtualProduct {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ParentCategoryId {get;set;}

           /// <summary>
           /// Desc:分类的深度
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Depth {get;set;}

           /// <summary>
           /// Desc:分类的路径（以|分离）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Path {get;set;}

           /// <summary>
           /// Desc:未使用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RewriteName {get;set;}

           /// <summary>
           /// Desc:是否有子分类
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte HasChildren {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long TypeId {get;set;}

           /// <summary>
           /// Desc:分佣比例
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal CommisRate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta_Title {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta_Description {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta_Keywords {get;set;}

           /// <summary>
           /// Desc:是否已删除
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsDeleted {get;set;}

           /// <summary>
           /// Desc:是否显示
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte IsShow {get;set;}

    }
}
