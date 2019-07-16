using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///分销用户表
    ///</summary>
    public partial class Himall_Distributor
    {
           public Himall_Distributor(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemberId {get;set;}

           /// <summary>
           /// Desc:上级编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long SuperiorId {get;set;}

           /// <summary>
           /// Desc:所属等级
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long GradeId {get;set;}

           /// <summary>
           /// Desc:分销订单数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderCount {get;set;}

           /// <summary>
           /// Desc:小店名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShopName {get;set;}

           /// <summary>
           /// Desc:小店图标
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ShopLogo {get;set;}

           /// <summary>
           /// Desc:是否展示小店logo
           /// Default:b'1'
           /// Nullable:False
           /// </summary>           
           public bool IsShowShopLogo {get;set;}

           /// <summary>
           /// Desc:审核状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int DistributionStatus {get;set;}

           /// <summary>
           /// Desc:申请时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ApplyTime {get;set;}

           /// <summary>
           /// Desc:通过时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PassTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:直接下级数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SubNumber {get;set;}

           /// <summary>
           /// Desc:余额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Balance {get;set;}

           /// <summary>
           /// Desc:总结算收入
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SettlementAmount {get;set;}

           /// <summary>
           /// Desc:冻结金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal FreezeAmount {get;set;}

           /// <summary>
           /// Desc:已提现
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal WithdrawalsAmount {get;set;}

           /// <summary>
           /// Desc:分销成交商品数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ProductCount {get;set;}

           /// <summary>
           /// Desc:分销成交金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SaleAmount {get;set;}

           /// <summary>
           /// Desc:下级分销成交商品数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int SubProductCount {get;set;}

           /// <summary>
           /// Desc:下级分销成交金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal SubSaleAmount {get;set;}

    }
}
