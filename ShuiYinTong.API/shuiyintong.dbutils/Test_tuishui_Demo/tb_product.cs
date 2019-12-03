using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///产品表
    ///</summary>
    [SugarTable("tb_product")]
    public partial class tb_product
    {
           public tb_product(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:机构编号
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? bId {get;set;}

           /// <summary>
           /// Desc:机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankName {get;set;}

           /// <summary>
           /// Desc:产品名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productName {get;set;}

           /// <summary>
           /// Desc:产品类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string pruductType {get;set;}

           /// <summary>
           /// Desc:授信额度
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? maxMoney {get;set;}

           /// <summary>
           /// Desc:介绍定义
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contents {get;set;}

           /// <summary>
           /// Desc:简要特征
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productAdd {get;set;}

           /// <summary>
           /// Desc:申请条件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productClaim {get;set;}

           /// <summary>
           /// Desc:资料清单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productMater {get;set;}

           /// <summary>
           /// Desc:产品优势
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productTrait {get;set;}

           /// <summary>
           /// Desc:流程文件
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productFlow {get;set;}

           /// <summary>
           /// Desc:展示期限
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? dateline {get;set;}

           /// <summary>
           /// Desc:年利率
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? curYearReate {get;set;}

           /// <summary>
           /// Desc:发布日期
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? pubDate {get;set;}

           /// <summary>
           /// Desc:结束日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? endDate {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:是否推荐
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string recommendFlag {get;set;}

           /// <summary>
           /// Desc:借款期限
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string MoneyTime {get;set;}

           /// <summary>
           /// Desc:还款方式
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ReturnWay {get;set;}

           /// <summary>
           /// Desc:是否通过担保公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DBGSFlag {get;set;}

           /// <summary>
           /// Desc:产品图片
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string img {get;set;}

           /// <summary>
           /// Desc:最低利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string maxRate {get;set;}

           /// <summary>
           /// Desc:排序
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? orderno {get;set;}

           /// <summary>
           /// Desc:服务费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? serviceRate {get;set;}

           /// <summary>
           /// Desc:担保公司ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string guaranteeId {get;set;}

           /// <summary>
           /// Desc:产品编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ProductNo {get;set;}

           /// <summary>
           /// Desc:版本号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string version {get;set;}

           /// <summary>
           /// Desc:展示利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string showRate {get;set;}

           /// <summary>
           /// Desc:适用地区
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string productArea {get;set;}

           /// <summary>
           /// Desc:展示额度
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? showMoney {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updateDate {get;set;}

           /// <summary>
           /// Desc:融资利率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankRate {get;set;}

    }
}
