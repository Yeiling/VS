using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Attribute
    {
           public Himall_Attribute(){


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
           public long TypeId {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

           /// <summary>
           /// Desc:是否为必选
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsMust {get;set;}

           /// <summary>
           /// Desc:是否可多选
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsMulti {get;set;}

    }
}
