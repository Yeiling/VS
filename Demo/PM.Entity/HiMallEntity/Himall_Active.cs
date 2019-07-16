using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///营销活动表
    ///</summary>
    public partial class Himall_Active
    {
           public Himall_Active(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:店铺编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:活动名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ActiveName {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime StartTime {get;set;}

           /// <summary>
           /// Desc:结束时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndTime {get;set;}

           /// <summary>
           /// Desc:是否全部商品
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte IsAllProduct {get;set;}

           /// <summary>
           /// Desc:是否全部门店
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public byte IsAllStore {get;set;}

           /// <summary>
           /// Desc:活动类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ActiveType {get;set;}

           /// <summary>
           /// Desc:活动状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActiveStatus {get;set;}

    }
}
