using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///用款报关单明细
    ///</summary>
    [SugarTable("tb_YongkuanBGDDet")]
    public partial class tb_YongkuanBGDDet
    {
           public tb_YongkuanBGDDet(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderId {get;set;}

           /// <summary>
           /// Desc:用款ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? YongkuanId {get;set;}

           /// <summary>
           /// Desc:订单编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNo {get;set;}

           /// <summary>
           /// Desc:用款编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YongkuanNo {get;set;}

           /// <summary>
           /// Desc:报关单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BgdNoMX {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string status {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:离境日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LJ_DATE {get;set;}

           /// <summary>
           /// Desc:人民币出口额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RMB_AMT {get;set;}

           /// <summary>
           /// Desc:美元出口额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string USD_AMT {get;set;}

           /// <summary>
           /// Desc:用款报关单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? YongkuanBDGId {get;set;}

           /// <summary>
           /// Desc:商品
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HGCMName {get;set;}

    }
}
