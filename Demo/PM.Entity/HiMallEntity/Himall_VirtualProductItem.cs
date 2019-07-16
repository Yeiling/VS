using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///虚拟商品信息项表
    ///</summary>
    public partial class Himall_VirtualProductItem
    {
           public Himall_VirtualProductItem(){


           }
           /// <summary>
           /// Desc:编号
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
           /// Desc:信息项标题名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:信息项类型(1=文本格式，2=日期，3=时间，4=身份证，5=数字格式，6=图片)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte Type {get;set;}

           /// <summary>
           /// Desc:是否必填(0=否，1=是)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool Required {get;set;}

    }
}
