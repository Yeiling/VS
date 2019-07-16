using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_WXCardLog
    {
           public Himall_WXCardLog(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:卡券编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CardId {get;set;}

           /// <summary>
           /// Desc:标题 英文27  汉字 9个
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CardTitle {get;set;}

           /// <summary>
           /// Desc:副标题 英文54  汉字18个
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CardSubTitle {get;set;}

           /// <summary>
           /// Desc:卡券颜色 HasTable
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CardColor {get;set;}

           /// <summary>
           /// Desc:审核状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int AuditStatus {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppId {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppSecret {get;set;}

           /// <summary>
           /// Desc:红包类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int CouponType {get;set;}

           /// <summary>
           /// Desc:红包编号 涉及多表，不做外键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CouponId {get;set;}

    }
}
