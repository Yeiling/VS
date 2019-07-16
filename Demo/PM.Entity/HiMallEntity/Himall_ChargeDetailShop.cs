using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_ChargeDetailShop
    {
           public Himall_ChargeDetailShop(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:店铺ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

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

    }
}
