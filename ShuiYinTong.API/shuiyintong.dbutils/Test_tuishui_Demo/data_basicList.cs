using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///有数_企业照面信息
    ///</summary>
    [SugarTable("data_basicList")]
    public partial class data_basicList
    {
           public data_basicList(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string entName {get;set;}

           /// <summary>
           /// Desc:有数企业ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string entId {get;set;}

           /// <summary>
           /// Desc:统一社会信用代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string creditCode {get;set;}

           /// <summary>
           /// Desc:注册号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string regNo {get;set;}

           /// <summary>
           /// Desc:组织机构代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string orgCode {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string entType {get;set;}

           /// <summary>
           /// Desc:法定代表人/负责人/执行事务合伙人/投资人/经营者
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string frName {get;set;}

           /// <summary>
           /// Desc:有数关联人ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string frPersonId {get;set;}

           /// <summary>
           /// Desc:注册资本（万元）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string regCap {get;set;}

           /// <summary>
           /// Desc:注册币种
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string regCapCur {get;set;}

           /// <summary>
           /// Desc:实收资本（万元）
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string recCap {get;set;}

           /// <summary>
           /// Desc:成立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string esDate {get;set;}

           /// <summary>
           /// Desc:营业期限自
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string openFrom {get;set;}

           /// <summary>
           /// Desc:营业期限至
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string openTo {get;set;}

           /// <summary>
           /// Desc:登记机关
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string regOrg {get;set;}

           /// <summary>
           /// Desc:核准时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string apprDate {get;set;}

           /// <summary>
           /// Desc:登记状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string entStatus {get;set;}

           /// <summary>
           /// Desc:注销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string canDate {get;set;}

           /// <summary>
           /// Desc:吊销日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string revDate {get;set;}

           /// <summary>
           /// Desc:住所
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string address {get;set;}

           /// <summary>
           /// Desc:省
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string province {get;set;}

           /// <summary>
           /// Desc:地级市
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string city {get;set;}

           /// <summary>
           /// Desc:区/县
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string county {get;set;}

           /// <summary>
           /// Desc:住所所在行政区划代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string areaCode {get;set;}

           /// <summary>
           /// Desc:经营范围
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string operateScope {get;set;}

           /// <summary>
           /// Desc:最近年报报送年度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ancheYear {get;set;}

           /// <summary>
           /// Desc:最近年报公示日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ancheDate {get;set;}

           /// <summary>
           /// Desc:行业门类代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string industryPhyCode {get;set;}

           /// <summary>
           /// Desc:行业门类名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string industryPhyName {get;set;}

           /// <summary>
           /// Desc:国民经济行业代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string industryCode {get;set;}

           /// <summary>
           /// Desc:国民经济行业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string industryName {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ID {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYTentName {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? LastMergeTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

    }
}
