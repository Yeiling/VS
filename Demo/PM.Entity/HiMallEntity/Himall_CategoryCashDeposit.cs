using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CategoryCashDeposit
    {
           public Himall_CategoryCashDeposit(){


           }
           /// <summary>
           /// Desc:主键Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:分类Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CategoryId {get;set;}

           /// <summary>
           /// Desc:需要缴纳保证金
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal NeedPayCashDeposit {get;set;}

           /// <summary>
           /// Desc:允许七天无理由退货
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte EnableNoReasonReturn {get;set;}

    }
}
