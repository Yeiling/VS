using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_AccountMeta
    {
           public Himall_AccountMeta(){


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
           public long AccountId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MetaKey {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string MetaValue {get;set;}

           /// <summary>
           /// Desc:营销服务开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ServiceStartTime {get;set;}

           /// <summary>
           /// Desc:营销服务结束时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ServiceEndTime {get;set;}

    }
}
