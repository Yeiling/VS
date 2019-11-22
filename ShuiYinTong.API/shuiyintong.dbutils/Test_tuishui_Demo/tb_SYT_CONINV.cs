using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业对外投资信息
    ///</summary>
    [SugarTable("tb_SYT_CONINV")]
    public partial class tb_SYT_CONINV
    {
           public tb_SYT_CONINV(){


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
           /// Desc:被投资企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_entName {get;set;}

           /// <summary>
           /// Desc:对外投资企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID_CINV {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_creditCode {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_regNo {get;set;}

           /// <summary>
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_entType {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_frName {get;set;}

           /// <summary>
           /// Desc:对外投资企业法人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_CINV_FR {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CINV_regCap {get;set;}

           /// <summary>
           /// Desc:注册币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_regCapCur {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CINV_esDate {get;set;}

           /// <summary>
           /// Desc:工商登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_regOrg {get;set;}

           /// <summary>
           /// Desc:经营状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_entStatus {get;set;}

           /// <summary>
           /// Desc:注销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CINV_canDate {get;set;}

           /// <summary>
           /// Desc:吊销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CINV_revDate {get;set;}

           /// <summary>
           /// Desc:认缴出资额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CINV_subConam {get;set;}

           /// <summary>
           /// Desc:认缴出资币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_subCurrency {get;set;}

           /// <summary>
           /// Desc:出资比例
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? CINV_fundedRatio {get;set;}

           /// <summary>
           /// Desc:出资方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_conform {get;set;}

           /// <summary>
           /// Desc:注册地址行政区编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_regorgcode {get;set;}

           /// <summary>
           /// Desc:投资企业总数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? CINV_binvvamount {get;set;}

           /// <summary>
           /// Desc:投资企业曾用名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_his_name {get;set;}

           /// <summary>
           /// Desc:注册地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_addresses {get;set;}

           /// <summary>
           /// Desc:投资企业主要人员职位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_employees_job_title {get;set;}

           /// <summary>
           /// Desc:投资企业主要人员姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CINV_employees_name {get;set;}

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
