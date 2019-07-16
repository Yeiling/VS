using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_HomeCategory
    {
           public Himall_HomeCategory(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:分类所属行数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RowId {get;set;}

           /// <summary>
           /// Desc:分类ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CategoryId {get;set;}

           /// <summary>
           /// Desc:分类深度(最深3）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Depth {get;set;}

    }
}
