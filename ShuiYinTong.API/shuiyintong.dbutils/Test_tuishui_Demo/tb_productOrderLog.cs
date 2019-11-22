using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///订单日志
    ///</summary>
    [SugarTable("tb_productOrderLog")]
    public partial class tb_productOrderLog
    {
           public tb_productOrderLog(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userName {get;set;}

           /// <summary>
           /// Desc:日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? dates {get;set;}

           /// <summary>
           /// Desc:操作
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string action {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:标签
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string title {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string orderId {get;set;}

           /// <summary>
           /// Desc:用户类型（AB角色）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userType {get;set;}

           /// <summary>
           /// Desc:用款ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string yongkuanId {get;set;}

           /// <summary>
           /// Desc:预警ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string warningId {get;set;}

           /// <summary>
           /// Desc:开票ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string kpId {get;set;}

           /// <summary>
           /// Desc:支用ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string zyId {get;set;}

    }
}
