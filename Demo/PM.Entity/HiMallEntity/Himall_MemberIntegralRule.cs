using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberIntegralRule
    {
           public Himall_MemberIntegralRule(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:积分规则类型ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TypeId {get;set;}

           /// <summary>
           /// Desc:规则对应的积分数量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Integral {get;set;}

    }
}
