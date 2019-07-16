using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ApplyWithDraw
    {
           public Himall_ApplyWithDraw(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:会员ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MemId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NickName {get;set;}

           /// <summary>
           /// Desc:OpenId
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OpenId {get;set;}

           /// <summary>
           /// Desc:申请状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ApplyStatus {get;set;}

           /// <summary>
           /// Desc:提现金额
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal ApplyAmount {get;set;}

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
           public string OpUser {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:提现方式
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int ApplyType {get;set;}

           /// <summary>
           /// Desc:手续费
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal Poundage {get;set;}

    }
}
