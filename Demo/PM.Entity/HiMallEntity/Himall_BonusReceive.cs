using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_BonusReceive
    {
           public Himall_BonusReceive(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:红包Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BonusId {get;set;}

           /// <summary>
           /// Desc:领取人微信Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OpenId {get;set;}

           /// <summary>
           /// Desc:领取日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ReceiveTime {get;set;}

           /// <summary>
           /// Desc:领取金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Price {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsShare {get;set;}

           /// <summary>
           /// Desc:红包金额是否已经转入了预存款
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsTransformedDeposit {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public long? UserId {get;set;}

    }
}
