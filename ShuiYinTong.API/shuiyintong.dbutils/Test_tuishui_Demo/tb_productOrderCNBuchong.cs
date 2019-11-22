using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///订单表-中行补充信息
    ///</summary>
    [SugarTable("tb_productOrderCNBuchong")]
    public partial class tb_productOrderCNBuchong
    {
           public tb_productOrderCNBuchong(){


           }
           /// <summary>
           /// Desc:
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
           public string orderId {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? uId {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Realname {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Sex {get;set;}

           /// <summary>
           /// Desc:省
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Pro {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Tel {get;set;}

           /// <summary>
           /// Desc:证件类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IDType {get;set;}

           /// <summary>
           /// Desc:证件号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string IDNo {get;set;}

           /// <summary>
           /// Desc:2017增值税对应销售收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SaleTaxAmount2017 {get;set;}

           /// <summary>
           /// Desc:2017增值税税额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxAmount2017 {get;set;}

           /// <summary>
           /// Desc:2018增值税对应销售收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SaleTaxAmount2018 {get;set;}

           /// <summary>
           /// Desc:2018增值税税额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxAmount2018 {get;set;}

           /// <summary>
           /// Desc:2019增值税对应销售收入
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SaleTaxAmount2019 {get;set;}

           /// <summary>
           /// Desc:2019增值税税额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TaxAmount2019 {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createtime {get;set;}

    }
}
