using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///开票信息
    ///</summary>
    [SugarTable("tb_KPInfo")]
    public partial class tb_KPInfo
    {
           public tb_KPInfo(){


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
           /// Desc:登录账号cid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? cId {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string companyName {get;set;}

           /// <summary>
           /// Desc:税号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string ShuiHao {get;set;}

           /// <summary>
           /// Desc:单位地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Address {get;set;}

           /// <summary>
           /// Desc:电话号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Phone {get;set;}

           /// <summary>
           /// Desc:开户银行
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string KHBank {get;set;}

           /// <summary>
           /// Desc:银行账号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BankNO {get;set;}

    }
}
