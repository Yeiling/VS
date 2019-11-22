using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_enter_basicinfo")]
    public partial class tb_enter_basicinfo
    {
           public tb_enter_basicinfo(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:法人个人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRSYT_PER_Id {get;set;}

           /// <summary>
           /// Desc:法人婚姻状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FRMarriage {get;set;}

           /// <summary>
           /// Desc:法人教育程度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FREdu {get;set;}

           /// <summary>
           /// Desc:实际控制人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControlName {get;set;}

           /// <summary>
           /// Desc:实际控制人税银通个人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControlSYT_PER_Id {get;set;}

           /// <summary>
           /// Desc:实际控制人身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControlidNO {get;set;}

           /// <summary>
           /// Desc:实际控制人联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControlTele {get;set;}

           /// <summary>
           /// Desc:实际控制人婚姻状况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControlMarriage {get;set;}

           /// <summary>
           /// Desc:实际控制人教育程度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ControlEdu {get;set;}

           /// <summary>
           /// Desc:实际控制人从业经验
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ControlWorkingExp {get;set;}

           /// <summary>
           /// Desc:临时保存falg  临时0  正式1
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? TempStatus {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updateTime {get;set;}

           /// <summary>
           /// Desc:授信订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderId {get;set;}

    }
}
