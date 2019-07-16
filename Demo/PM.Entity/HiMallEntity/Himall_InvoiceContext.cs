using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_InvoiceContext
    {
           public Himall_InvoiceContext(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:发票名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

    }
}
