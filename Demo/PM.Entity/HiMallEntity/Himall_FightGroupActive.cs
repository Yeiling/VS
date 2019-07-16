using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///拼团活动
    ///</summary>
    public partial class Himall_FightGroupActive
    {
           public Himall_FightGroupActive(){


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
           /// Desc:商品编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:商品名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProductName {get;set;}

           /// <summary>
           /// Desc:图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IconUrl {get;set;}

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
           /// Desc:参团人数限制
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LimitedNumber {get;set;}

           /// <summary>
           /// Desc:成团时限
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal LimitedHour {get;set;}

           /// <summary>
           /// Desc:数量限制
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LimitQuantity {get;set;}

           /// <summary>
           /// Desc:成团数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int GroupCount {get;set;}

           /// <summary>
           /// Desc:成功成团数量
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OkGroupCount {get;set;}

           /// <summary>
           /// Desc:活动添加时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AddTime {get;set;}

           /// <summary>
           /// Desc:平台操作状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ManageAuditStatus {get;set;}

           /// <summary>
           /// Desc:平台操作说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ManageRemark {get;set;}

           /// <summary>
           /// Desc:平台操作时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ManageDate {get;set;}

           /// <summary>
           /// Desc:平台操作人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? ManagerId {get;set;}

           /// <summary>
           /// Desc:活动当前状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ActiveTimeStatus {get;set;}

    }
}
