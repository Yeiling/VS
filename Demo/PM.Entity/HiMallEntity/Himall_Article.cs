using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Article
    {
           public Himall_Article(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:文章分类ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long CategoryId {get;set;}

           /// <summary>
           /// Desc:文章标题
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IconUrl {get;set;}

           /// <summary>
           /// Desc:文档内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AddDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

           /// <summary>
           /// Desc:SEO标题
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta_Title {get;set;}

           /// <summary>
           /// Desc:SEO说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta_Description {get;set;}

           /// <summary>
           /// Desc:SEO关键字
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Meta_Keywords {get;set;}

           /// <summary>
           /// Desc:是否显示
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsRelease {get;set;}

    }
}
