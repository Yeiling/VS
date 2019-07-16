using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///营销活动商品
    ///</summary>
    public partial class Himall_ActiveProduct
    {
           public Himall_ActiveProduct(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:活动编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ActiveId {get;set;}

           /// <summary>
           /// Desc:产品编号 -1表示所有商品
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

    }
}
