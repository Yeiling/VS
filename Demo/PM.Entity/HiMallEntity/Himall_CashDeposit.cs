using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CashDeposit
    {
           public Himall_CashDeposit(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:Shop表外键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:可用金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal CurrentBalance {get;set;}

           /// <summary>
           /// Desc:已缴纳金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal TotalBalance {get;set;}

           /// <summary>
           /// Desc:最后一次缴纳时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime Date {get;set;}

           /// <summary>
           /// Desc:是否显示标志，只有保证金欠费该字段才有用，默认显示
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte EnableLabels {get;set;}

    }
}
