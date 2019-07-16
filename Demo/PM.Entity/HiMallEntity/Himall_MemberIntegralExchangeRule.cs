using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberIntegralExchangeRule
    {
           public Himall_MemberIntegralExchangeRule(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:一块钱对应多少积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int IntegralPerMoney {get;set;}

           /// <summary>
           /// Desc:一个积分对应多少钱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int MoneyPerIntegral {get;set;}

    }
}
