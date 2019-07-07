using System;
using System.Linq;
using System.Text;

namespace PM.Entity.YiiBaidbEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class payments
    {
           public payments(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int customerNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string checkNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime paymentDate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal amount {get;set;}

    }
}
