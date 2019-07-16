using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_HandSlideAd
    {
           public Himall_HandSlideAd(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:图片URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ImageUrl {get;set;}

           /// <summary>
           /// Desc:图片跳转URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

    }
}
