using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FloorTopic
    {
           public Himall_FloorTopic(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:楼层ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FloorId {get;set;}

           /// <summary>
           /// Desc:专题类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TopicType {get;set;}

           /// <summary>
           /// Desc:专题封面图片
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TopicImage {get;set;}

           /// <summary>
           /// Desc:专题名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string TopicName {get;set;}

           /// <summary>
           /// Desc:专题跳转URL
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Url {get;set;}

    }
}
