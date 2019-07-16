using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_IntegralMallAd
    {
           public Himall_IntegralMallAd(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:活动类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ActivityType {get;set;}

           /// <summary>
           /// Desc:活动编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ActivityId {get;set;}

           /// <summary>
           /// Desc:显示图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Cover {get;set;}

           /// <summary>
           /// Desc:显示状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ShowStatus {get;set;}

           /// <summary>
           /// Desc:显示平台
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int ShowPlatform {get;set;}

    }
}
