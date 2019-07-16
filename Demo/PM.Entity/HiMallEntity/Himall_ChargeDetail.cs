using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ChargeDetail
    {
           public Himall_ChargeDetail(){


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
           /// Desc:充值时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ChargeTime {get;set;}

           /// <summary>
           /// Desc:充值金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal ChargeAmount {get;set;}

           /// <summary>
           /// Desc:充值方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ChargeWay {get;set;}

           /// <summary>
           /// Desc:充值状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ChargeStatus {get;set;}

           /// <summary>
           /// Desc:提交充值时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:赠送
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PresentAmount {get;set;}

    }
}
