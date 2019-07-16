using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Coupon
    {
           public Himall_Coupon(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:店铺名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:价格
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Price {get;set;}

           /// <summary>
           /// Desc:最大可领取张数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PerMax {get;set;}

           /// <summary>
           /// Desc:订单金额（满足多少钱才能使用）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal OrderAmount {get;set;}

           /// <summary>
           /// Desc:发行张数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Num {get;set;}

           /// <summary>
           /// Desc:开始时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime StartTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndTime {get;set;}

           /// <summary>
           /// Desc:优惠券名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CouponName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:领取方式 0 店铺首页 1 积分兑换 2 主动发放
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ReceiveType {get;set;}

           /// <summary>
           /// Desc:所需积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int NeedIntegral {get;set;}

           /// <summary>
           /// Desc:兑换截止时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndIntegralExchange {get;set;}

           /// <summary>
           /// Desc:积分商城封面
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IntegralCover {get;set;}

           /// <summary>
           /// Desc:是否同步到微信
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsSyncWeiXin {get;set;}

           /// <summary>
           /// Desc:微信状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WXAuditStatus {get;set;}

           /// <summary>
           /// Desc:微信卡券记录号 与微信卡券记录关联
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? CardLogId {get;set;}

           /// <summary>
           /// Desc:使用范围：0=全场通用，1=部分商品可用
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UseArea {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

    }
}
