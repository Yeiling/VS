using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberLabel
    {
           public Himall_MemberLabel(){


           }
           /// <summary>
           /// Desc:Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:会员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemId {get;set;}

           /// <summary>
           /// Desc:标签Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long LabelId {get;set;}

    }
}
