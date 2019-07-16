using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Capital
    {
           public Himall_Capital(){


           }
           /// <summary>
           /// Desc:
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
           /// Desc:可用余额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Balance {get;set;}

           /// <summary>
           /// Desc:冻结资金
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal FreezeAmount {get;set;}

           /// <summary>
           /// Desc:累计充值总金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal ChargeAmount {get;set;}

           /// <summary>
           /// Desc:累积充值赠送
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PresentAmount {get;set;}

    }
}
