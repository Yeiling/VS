using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ExpressElement
    {
           public Himall_ExpressElement(){


           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:快递公司ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ExpressId {get;set;}

           /// <summary>
           /// Desc:元素类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ElementType {get;set;}

           /// <summary>
           /// Desc:面单元素X坐标1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LeftTopPointX {get;set;}

           /// <summary>
           /// Desc:面单元素Y坐标1
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LeftTopPointY {get;set;}

           /// <summary>
           /// Desc:面单元素X坐标2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RightBottomPointX {get;set;}

           /// <summary>
           /// Desc:面单元素Y坐标2
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RightBottomPointY {get;set;}

    }
}
