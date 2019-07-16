using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Agreement
    {
           public Himall_Agreement(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:协议类型 枚举 AgreementType：0买家注册协议，1卖家入驻协议
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AgreementType {get;set;}

           /// <summary>
           /// Desc:协议内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AgreementContent {get;set;}

           /// <summary>
           /// Desc:最后修改日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime LastUpdateTime {get;set;}

    }
}
