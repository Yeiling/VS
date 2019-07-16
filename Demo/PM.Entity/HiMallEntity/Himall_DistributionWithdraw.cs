using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///分销提现
    ///</summary>
    public partial class Himall_DistributionWithdraw
    {
           public Himall_DistributionWithdraw(){


           }
           /// <summary>
           /// Desc:流水号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:会员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemberId {get;set;}

           /// <summary>
           /// Desc:提现名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WithdrawName {get;set;}

           /// <summary>
           /// Desc:提现账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WithdrawAccount {get;set;}

           /// <summary>
           /// Desc:提现状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int WithdrawStatus {get;set;}

           /// <summary>
           /// Desc:提现金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:申请时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime ApplyTime {get;set;}

           /// <summary>
           /// Desc:处理时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ConfirmTime {get;set;}

           /// <summary>
           /// Desc:付款时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? PayTime {get;set;}

           /// <summary>
           /// Desc:付款流水号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PayNo {get;set;}

           /// <summary>
           /// Desc:操作人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Operator {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:提现方式
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int WithdrawType {get;set;}

           /// <summary>
           /// Desc:手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Poundage {get;set;}

    }
}
