using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CollocationPoruduct
    {
           public Himall_CollocationPoruduct(){


           }
           /// <summary>
           /// Desc:ID自增
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:商品ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:组合购ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ColloId {get;set;}

           /// <summary>
           /// Desc:是否主商品
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsMain {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DisplaySequence {get;set;}

    }
}
