using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///企业备案信息_北京
    ///</summary>
    [SugarTable("tb_SYT_BASICINFO_TAXREFUND_BJ")]
    public partial class tb_SYT_BASICINFO_TAXREFUND_BJ
    {
           public tb_SYT_BASICINFO_TAXREFUND_BJ(){


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
           /// Desc:税银通企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:海关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_QYDM {get;set;}

           /// <summary>
           /// Desc:企业标志
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_CPCODE {get;set;}

           /// <summary>
           /// Desc:纳税人识别号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_NSRDJ_NO {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_SHXY_NO {get;set;}

           /// <summary>
           /// Desc:出口企业类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_QYLX {get;set;}

           /// <summary>
           /// Desc:退税备案日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BZ_SQ_DATE {get;set;}

           /// <summary>
           /// Desc:纳税人类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_NSRLB {get;set;}

           /// <summary>
           /// Desc:退税评级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_FLGLCD {get;set;}

           /// <summary>
           /// Desc:退税评级认定日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BZ_FLGLCD_DATE {get;set;}

           /// <summary>
           /// Desc:纳税信用等级
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_NSXYDJ {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_CPNAME {get;set;}

           /// <summary>
           /// Desc:企业英文名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_EG_NAME {get;set;}

           /// <summary>
           /// Desc:企业联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_TEL {get;set;}

           /// <summary>
           /// Desc:传真
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_FAX {get;set;}

           /// <summary>
           /// Desc:邮编
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_POSTCODE {get;set;}

           /// <summary>
           /// Desc:电子信箱
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_EMAIL {get;set;}

           /// <summary>
           /// Desc:注册地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ADDRESS {get;set;}

           /// <summary>
           /// Desc:经营场所
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_JY_ADDRESS {get;set;}

           /// <summary>
           /// Desc:登记注册代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ZCLXCODE {get;set;}

           /// <summary>
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ZCLXNAME {get;set;}

           /// <summary>
           /// Desc:行业小类代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_HYCODE {get;set;}

           /// <summary>
           /// Desc:行业小类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_HYNAME {get;set;}

           /// <summary>
           /// Desc:对外贸易编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BADJ_NO {get;set;}

           /// <summary>
           /// Desc:是否提供应税
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_YSFW {get;set;}

           /// <summary>
           /// Desc:提供零税代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_YSFWCODE {get;set;}

           /// <summary>
           /// Desc:工商登记号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_GSDJZ_NO {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BZ_GSDJZ_RZRQ {get;set;}

           /// <summary>
           /// Desc:登记有效期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? BZ_GSDJZ_YXQ {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ZCZJ {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_QYFR {get;set;}

           /// <summary>
           /// Desc:法人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_FR {get;set;}

           /// <summary>
           /// Desc:法定代表人证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_QYFR_NO {get;set;}

           /// <summary>
           /// Desc:法定代表人联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_QYFR_TEL {get;set;}

           /// <summary>
           /// Desc:退税账户开户行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BKNAME {get;set;}

           /// <summary>
           /// Desc:退税账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ACC_NO {get;set;}

           /// <summary>
           /// Desc:办税人1姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BSY {get;set;}

           /// <summary>
           /// Desc:办税人1证件号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BSY_NO {get;set;}

           /// <summary>
           /// Desc:办税人1id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_BSY {get;set;}

           /// <summary>
           /// Desc:办税人1联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BSY_TEL {get;set;}

           /// <summary>
           /// Desc:办税人2姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BSY2 {get;set;}

           /// <summary>
           /// Desc:办税人2证件号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BSY2_NO {get;set;}

           /// <summary>
           /// Desc:办税人2id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_BSY2 {get;set;}

           /// <summary>
           /// Desc:办税人2联系方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_BSY2_TEL {get;set;}

           /// <summary>
           /// Desc:优惠政策情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_YHZC {get;set;}

           /// <summary>
           /// Desc:外汇管理局
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ZGWGJ {get;set;}

           /// <summary>
           /// Desc:附送资料
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_FSZL {get;set;}

           /// <summary>
           /// Desc:计算方法
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_JS_MODE {get;set;}

           /// <summary>
           /// Desc:凭证申报方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_ZZSBFS {get;set;}

           /// <summary>
           /// Desc:数据电文申报
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_SJDWSB {get;set;}

           /// <summary>
           /// Desc:是否分部核算
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_FBHS {get;set;}

           /// <summary>
           /// Desc:核算部门代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_FBHSCODE {get;set;}

           /// <summary>
           /// Desc:运输方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_YSFS {get;set;}

           /// <summary>
           /// Desc:研发设计服务代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_YFSJFW {get;set;}

           /// <summary>
           /// Desc:税务机关代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BZ_SWCODE {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sxID {get;set;}

    }
}
