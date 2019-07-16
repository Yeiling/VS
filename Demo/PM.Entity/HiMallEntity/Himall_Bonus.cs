using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_Bonus
    {
           public Himall_Bonus(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:类型，活动红包，关注送红包
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:样式，模板一（源生风格），模板二
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Style {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:商户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MerchantsName {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:祝福语
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Blessing {get;set;}

           /// <summary>
           /// Desc:总面额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal TotalPrice {get;set;}

           /// <summary>
           /// Desc:开始日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime StartTime {get;set;}

           /// <summary>
           /// Desc:结束日期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime EndTime {get;set;}

           /// <summary>
           /// Desc:二维码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QRPath {get;set;}

           /// <summary>
           /// Desc:是否固定金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int PriceType {get;set;}

           /// <summary>
           /// Desc:固定金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal FixedAmount {get;set;}

           /// <summary>
           /// Desc:随机金额起止范围
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal RandomAmountStart {get;set;}

           /// <summary>
           /// Desc:随机金额起止范围
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal RandomAmountEnd {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ReceiveCount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ImagePath {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Description {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsInvalid {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal ReceivePrice {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ReceiveHref {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsAttention {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsGuideShare {get;set;}

    }
}
