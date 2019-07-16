using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FloorTabl
    {
           public Himall_FloorTabl(){


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
           /// Desc:楼层名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

    }
}
