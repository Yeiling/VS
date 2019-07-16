using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Label
    {
           public Himall_Label(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:标签名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string LabelName {get;set;}

    }
}
