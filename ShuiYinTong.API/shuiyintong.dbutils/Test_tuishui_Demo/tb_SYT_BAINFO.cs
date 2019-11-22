using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_SYT_BAINFO")]
    public partial class tb_SYT_BAINFO
    {
           public tb_SYT_BAINFO(){


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
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_creditCode {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_regNo {get;set;}

           /// <summary>
           /// Desc:组织机构代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_orgCode {get;set;}

           /// <summary>
           /// Desc:登记注册类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entType {get;set;}

           /// <summary>
           /// Desc:法定代表人姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_frName {get;set;}

           /// <summary>
           /// Desc:法人id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_PER_ID_FR {get;set;}

           /// <summary>
           /// Desc:注册资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BA_regCap {get;set;}

           /// <summary>
           /// Desc:注册币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_regCapCur {get;set;}

           /// <summary>
           /// Desc:实收资本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BA_recCap {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_esDate {get;set;}

           /// <summary>
           /// Desc:营业期限自
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_openFrom {get;set;}

           /// <summary>
           /// Desc:营业期限至
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_openTo {get;set;}

           /// <summary>
           /// Desc:工商登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_regOrg {get;set;}

           /// <summary>
           /// Desc:核准日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_apprDate {get;set;}

           /// <summary>
           /// Desc:经营状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entStatus {get;set;}

           /// <summary>
           /// Desc:注销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_canDate {get;set;}

           /// <summary>
           /// Desc:吊销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_revDate {get;set;}

           /// <summary>
           /// Desc:注册地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_address {get;set;}

           /// <summary>
           /// Desc:所在省份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_province {get;set;}

           /// <summary>
           /// Desc:所在城市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_city {get;set;}

           /// <summary>
           /// Desc:所在区县
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_county {get;set;}

           /// <summary>
           /// Desc:注册地址行政区编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_areaCode {get;set;}

           /// <summary>
           /// Desc:经营范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_operateScope {get;set;}

           /// <summary>
           /// Desc:最近年报报送年度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_ancheYear {get;set;}

           /// <summary>
           /// Desc:最近年报公示日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? BA_ancheDate {get;set;}

           /// <summary>
           /// Desc:行业门类代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_industryPhyCode {get;set;}

           /// <summary>
           /// Desc:行业门类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_industryPhyName {get;set;}

           /// <summary>
           /// Desc:行业小类代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_industryCode {get;set;}

           /// <summary>
           /// Desc:行业小类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_industryName {get;set;}

           /// <summary>
           /// Desc:许可经营项目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_abuItem {get;set;}

           /// <summary>
           /// Desc:一般经营项目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_cbuItem {get;set;}

           /// <summary>
           /// Desc:经营（业务）范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_operateScope2 {get;set;}

           /// <summary>
           /// Desc:经营(业务)范围及方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_operateScopeAndForm {get;set;}

           /// <summary>
           /// Desc:原注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_oriRegNo {get;set;}

           /// <summary>
           /// Desc:员工人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? BA_empnum {get;set;}

           /// <summary>
           /// Desc:企业英文名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entnameeng {get;set;}

           /// <summary>
           /// Desc:是否上市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_IPO {get;set;}

           /// <summary>
           /// Desc:上市类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_IPOTYPE {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

    }
}
