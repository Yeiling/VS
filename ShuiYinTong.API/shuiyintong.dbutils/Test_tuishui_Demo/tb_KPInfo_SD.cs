using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///开票信息表
    ///</summary>
    [SugarTable("tb_KPInfo_SD")]
    public partial class tb_KPInfo_SD
    {
           public tb_KPInfo_SD(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:登录用户ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int uId {get;set;}

           /// <summary>
           /// Desc:购方名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerName {get;set;}

           /// <summary>
           /// Desc:购房税号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerTaxNo {get;set;}

           /// <summary>
           /// Desc:开户行
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BankName {get;set;}

           /// <summary>
           /// Desc:账号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AccountNo {get;set;}

           /// <summary>
           /// Desc:购方电子邮箱
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerEmail {get;set;}

           /// <summary>
           /// Desc:购方电话
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerTel {get;set;}

           /// <summary>
           /// Desc:购方联系人
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerContact {get;set;}

           /// <summary>
           /// Desc:购方联系人电话
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerContactTel {get;set;}

           /// <summary>
           /// Desc:购方地址
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string BuyerAddr {get;set;}

           /// <summary>
           /// Desc:用款ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? yongkuanId {get;set;}

           /// <summary>
           /// Desc:发票类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string kpType {get;set;}

           /// <summary>
           /// Desc:含税金额
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AmoutTax {get;set;}

           /// <summary>
           /// Desc:商品名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string kppro {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

           /// <summary>
           /// Desc:开票申请日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? kpcreatedate {get;set;}

           /// <summary>
           /// Desc:最新更新日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? updatetime {get;set;}

           /// <summary>
           /// Desc:发票备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string fpremark {get;set;}

    }
}
