using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_SYT_ZB_BAINFO")]
    public partial class tb_SYT_ZB_BAINFO
    {
           public tb_SYT_ZB_BAINFO(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:税银通企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_entName {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_creditCode {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_esDate {get;set;}

           /// <summary>
           /// Desc:经营状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_entStatus {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_regCap {get;set;}

           /// <summary>
           /// Desc:注册币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_regCapCur {get;set;}

           /// <summary>
           /// Desc:营业期限自
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_openFrom {get;set;}

           /// <summary>
           /// Desc:营业期限至
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_openTo {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_regNo {get;set;}

           /// <summary>
           /// Desc:组织机构代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_orgCode {get;set;}

           /// <summary>
           /// Desc:纳税人识别号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_TAX_taxpayerId {get;set;}

           /// <summary>
           /// Desc:海关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_QYDM {get;set;}

           /// <summary>
           /// Desc:海关经营类别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_CUS_business_category {get;set;}

           /// <summary>
           /// Desc:最近更新日期（海关经营类别）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_CUS_business_category_UpdateTime {get;set;}

           /// <summary>
           /// Desc:出口企业类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_QYLX {get;set;}

           /// <summary>
           /// Desc:员工人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZB_empnum {get;set;}

           /// <summary>
           /// Desc:参保人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? ZB_social_security_num {get;set;}

           /// <summary>
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_entType {get;set;}

           /// <summary>
           /// Desc:行业门类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_industryPhyName {get;set;}

           /// <summary>
           /// Desc:行业大类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_industryMajName {get;set;}

           /// <summary>
           /// Desc:行业中类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_industryMidName {get;set;}

           /// <summary>
           /// Desc:行业小类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_industryName {get;set;}

           /// <summary>
           /// Desc:注册地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_address {get;set;}

           /// <summary>
           /// Desc:经营范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_operateScope {get;set;}

           /// <summary>
           /// Desc:工商登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_regOrg {get;set;}

           /// <summary>
           /// Desc:主管税务所（科）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_ZGSWSKFJ {get;set;}

           /// <summary>
           /// Desc:主管外汇管理局
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_ZGWGJ {get;set;}

           /// <summary>
           /// Desc:注册海关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CUS_customs_reg {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_frName {get;set;}

           /// <summary>
           /// Desc:办税人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_BSY {get;set;}

           /// <summary>
           /// Desc:法定代表人证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_QYFR_NO {get;set;}

           /// <summary>
           /// Desc:办税人证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_BSY_NO {get;set;}

           /// <summary>
           /// Desc:法定代表人联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_QYFR_TEL {get;set;}

           /// <summary>
           /// Desc:办税人联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_BSY_TEL {get;set;}

           /// <summary>
           /// Desc:经营场所
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_SCJYDZ {get;set;}

           /// <summary>
           /// Desc:企业联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_TEL {get;set;}

           /// <summary>
           /// Desc:退税账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_ACC_NO {get;set;}

           /// <summary>
           /// Desc:退税账户开户行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_BKNAME {get;set;}

           /// <summary>
           /// Desc:纳税人状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_GTXX {get;set;}

           /// <summary>
           /// Desc:最近更新日期（纳税人状态）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_GTXX_UpdateTime {get;set;}

           /// <summary>
           /// Desc:纳税信用等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_NS_grade_list_grade {get;set;}

           /// <summary>
           /// Desc:纳税信用评价年份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_NS_grade_list_year {get;set;}

           /// <summary>
           /// Desc:退税评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_FLGLCD {get;set;}

           /// <summary>
           /// Desc:最近更新日期（退税评级）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_FLGLCD_UpdateTime {get;set;}

           /// <summary>
           /// Desc:退税风险名单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_tsfxmd {get;set;}

           /// <summary>
           /// Desc:黑名单认定日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_tsfxmd_UpdateTime {get;set;}

           /// <summary>
           /// Desc:海关信用等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_CUS_credit_levels_credit_level {get;set;}

           /// <summary>
           /// Desc:最近更新日期（海关信用等级）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_CUS_credit_levels_credit_level_UpdateTime {get;set;}

           /// <summary>
           /// Desc:海关注销标志
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_CUS_cancel_flag {get;set;}

           /// <summary>
           /// Desc:最近更新日期（海关注销标志）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_CUS_cancel_flag_UpdateTime {get;set;}

           /// <summary>
           /// Desc:退税备案日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ZB_SQ_DATE {get;set;}

           /// <summary>
           /// Desc:对外贸易备案日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_CUS_reg_date {get;set;}

           /// <summary>
           /// Desc:经营场所
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ZB_JY_ADDRESS {get;set;}

           /// <summary>
           /// Desc:企业进出口业务年限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? ZB_cusyear {get;set;}

           /// <summary>
           /// Desc:企业规模
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ENT_Scale {get;set;}

    }
}
