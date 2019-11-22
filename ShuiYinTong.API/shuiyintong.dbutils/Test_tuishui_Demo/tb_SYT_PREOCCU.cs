using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///法定代表人在其他企业任职信息
    ///</summary>
    [SugarTable("tb_SYT_PREOCCU")]
    public partial class tb_SYT_PREOCCU
    {
           public tb_SYT_PREOCCU(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entName {get;set;}

           /// <summary>
           /// Desc:税银通企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_frName {get;set;}

           /// <summary>
           /// Desc:法人任职企业法人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_FR {get;set;}

           /// <summary>
           /// Desc:任职企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_rgentName {get;set;}

           /// <summary>
           /// Desc:法人任职企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID_FR {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_creditCode {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_regNo {get;set;}

           /// <summary>
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_entType {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? FOCCU_regCap {get;set;}

           /// <summary>
           /// Desc:注册币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_regCapCur {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FOCCU_esDate {get;set;}

           /// <summary>
           /// Desc:工商登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_regOrg {get;set;}

           /// <summary>
           /// Desc:经营状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_entStatus {get;set;}

           /// <summary>
           /// Desc:注销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FOCCU_canDate {get;set;}

           /// <summary>
           /// Desc:吊销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? FOCCU_revDate {get;set;}

           /// <summary>
           /// Desc:任职职位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_position {get;set;}

           /// <summary>
           /// Desc:是否为法定代表人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_lerepsign {get;set;}

           /// <summary>
           /// Desc:注册地址行政区编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string FOCCU_regorgcode {get;set;}

           /// <summary>
           /// Desc:任职企业总数量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? FOCCU_ppvamount {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sxID {get;set;}

    }
}
