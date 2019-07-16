using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WXCardCodeLog
    {
           public Himall_WXCardCodeLog(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:卡券记录号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CardLogId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CardId {get;set;}

           /// <summary>
           /// Desc:标识
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Code {get;set;}

           /// <summary>
           /// Desc:投放时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime SendTime {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CodeStatus {get;set;}

           /// <summary>
           /// Desc:操作时间 失效、核销、删除时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UsedTime {get;set;}

           /// <summary>
           /// Desc:红包类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CouponType {get;set;}

           /// <summary>
           /// Desc:红包记录编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponCodeId {get;set;}

           /// <summary>
           /// Desc:对应OpenId
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OpenId {get;set;}

    }
}
