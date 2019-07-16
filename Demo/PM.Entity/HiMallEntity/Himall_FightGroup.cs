using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///拼团组团详情
    ///</summary>
    public partial class Himall_FightGroup
    {
           public Himall_FightGroup(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:团长用户编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long HeadUserId {get;set;}

           /// <summary>
           /// Desc:对应活动
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ActiveId {get;set;}

           /// <summary>
           /// Desc:参团人数限制
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LimitedNumber {get;set;}

           /// <summary>
           /// Desc:时间限制
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal LimitedHour {get;set;}

           /// <summary>
           /// Desc:已参团人数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int JoinedNumber {get;set;}

           /// <summary>
           /// Desc:是否异常
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsException {get;set;}

           /// <summary>
           /// Desc:数据状态 初始中  成团中  成功   失败
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int GroupStatus {get;set;}

           /// <summary>
           /// Desc:开团时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime AddGroupTime {get;set;}

           /// <summary>
           /// Desc:结束时间 成功或失败的时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? OverTime {get;set;}

           /// <summary>
           /// Desc:商品编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ProductId {get;set;}

           /// <summary>
           /// Desc:店铺编号
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

    }
}
