using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MobileHomeTopic
    {
           public Himall_MobileHomeTopic(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:终端
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Platform {get;set;}

           /// <summary>
           /// Desc:专题ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long TopicId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Sequence {get;set;}

    }
}
