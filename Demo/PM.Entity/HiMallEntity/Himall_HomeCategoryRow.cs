using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_HomeCategoryRow
    {
           public Himall_HomeCategoryRow(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:行ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RowId {get;set;}

           /// <summary>
           /// Desc:所属行推荐图片1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Image1 {get;set;}

           /// <summary>
           /// Desc:所属行推荐图片1的URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url1 {get;set;}

           /// <summary>
           /// Desc:所属行推荐图片2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Image2 {get;set;}

           /// <summary>
           /// Desc:所属行推荐图片2的URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url2 {get;set;}

    }
}
