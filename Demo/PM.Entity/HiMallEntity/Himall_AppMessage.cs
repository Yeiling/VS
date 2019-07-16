using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///APP消息通知表
    ///</summary>
    public partial class Himall_AppMessage
    {
           public Himall_AppMessage(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Id {get;set;}

           /// <summary>
           /// Desc:商家ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:门店ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ShopBranchId {get;set;}

           /// <summary>
           /// Desc:消息类型，对应枚举(1=订单，2=售后)
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TypeId {get;set;}

           /// <summary>
           /// Desc:数据来源编号，对应订单ID或者售后ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long SourceId {get;set;}

           /// <summary>
           /// Desc:消息内容
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Content {get;set;}

           /// <summary>
           /// Desc:是否已读
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public byte IsRead {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime sendtime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Title {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime OrderPayDate {get;set;}

    }
}
