using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ArticleCategory
    {
           public Himall_ArticleCategory(){


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
           public long ParentCategoryId {get;set;}

           /// <summary>
           /// Desc:文章类型名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:显示顺序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

           /// <summary>
           /// Desc:是否为默认
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsDefault {get;set;}

    }
}
