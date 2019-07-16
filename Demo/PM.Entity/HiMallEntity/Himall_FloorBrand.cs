using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FloorBrand
    {
           public Himall_FloorBrand(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:楼层ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FloorId {get;set;}

           /// <summary>
           /// Desc:品牌ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BrandId {get;set;}

    }
}
