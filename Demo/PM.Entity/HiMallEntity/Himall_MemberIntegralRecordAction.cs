using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberIntegralRecordAction
    {
           public Himall_MemberIntegralRecordAction(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:积分兑换ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long IntegralRecordId {get;set;}

           /// <summary>
           /// Desc:兑换虚拟物l类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int VirtualItemTypeId {get;set;}

           /// <summary>
           /// Desc:虚拟物ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long VirtualItemId {get;set;}

    }
}
