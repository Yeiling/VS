using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_AttributeValue
    {
           public Himall_AttributeValue(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:属性ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long AttributeId {get;set;}

           /// <summary>
           /// Desc:属性值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Value {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long DisplaySequence {get;set;}

    }
}
