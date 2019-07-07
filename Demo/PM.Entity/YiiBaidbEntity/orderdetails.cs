using System;
using System.Linq;
using System.Text;

namespace PM.Entity.YiiBaidbEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class orderdetails
    {
           public orderdetails(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int orderNumber {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string productCode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int quantityOrdered {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal priceEach {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short orderLineNumber {get;set;}

    }
}
