using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///虚拟订单信息项表
    ///</summary>
    public partial class Himall_VirtualOrderItem
    {
           public Himall_VirtualOrderItem(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderId {get;set;}

           /// <summary>
           /// Desc:订单项ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long OrderItemId {get;set;}

           /// <summary>
           /// Desc:虚拟商品信息项名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string VirtualProductItemName {get;set;}

           /// <summary>
           /// Desc:信息项填写内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:信息项类型(1=文本格式，2=日期，3=时间，4=身份证，5=数字格式，6=图片)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte VirtualProductItemType {get;set;}

    }
}
