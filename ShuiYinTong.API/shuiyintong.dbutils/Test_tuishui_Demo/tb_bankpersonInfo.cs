using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///机构信息表
    ///</summary>
    [SugarTable("tb_bankpersonInfo")]
    public partial class tb_bankpersonInfo
    {
           public tb_bankpersonInfo(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:用户类型
           /// Default:2
           /// Nullable:True
           /// </summary>           
           public int? usertype {get;set;}

           /// <summary>
           /// Desc:电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string phone {get;set;}

           /// <summary>
           /// Desc:用户ID
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? userId {get;set;}

           /// <summary>
           /// Desc:用户名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string userName {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string pwd {get;set;}

           /// <summary>
           /// Desc:省
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string province {get;set;}

           /// <summary>
           /// Desc:市
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public string city {get;set;}

           /// <summary>
           /// Desc:县
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? xian {get;set;}

           /// <summary>
           /// Desc:机构类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jigoutype {get;set;}

           /// <summary>
           /// Desc:机构名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jigouname {get;set;}

           /// <summary>
           /// Desc:机构地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jigouaddress {get;set;}

           /// <summary>
           /// Desc:机构电话
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jigouphone {get;set;}

           /// <summary>
           /// Desc:真实姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string truename {get;set;}

           /// <summary>
           /// Desc:部门
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string departmentposition {get;set;}

           /// <summary>
           /// Desc:qq
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string QQ {get;set;}

           /// <summary>
           /// Desc:上传 不用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? isupload {get;set;}

           /// <summary>
           /// Desc:不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string infourl {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? int2 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nvarchar1 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nvarchar2 {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string nvarchar3 {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:DateTime.Now
           /// Nullable:True
           /// </summary>           
           public DateTime? creattime {get;set;}

           /// <summary>
           /// Desc:审核时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? shenhetime {get;set;}

           /// <summary>
           /// Desc:备用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? datetime1 {get;set;}

           /// <summary>
           /// Desc:企业图
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string companyimage {get;set;}

           /// <summary>
           /// Desc:网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string website {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string contents {get;set;}

           /// <summary>
           /// Desc:店名 不用
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string dianname {get;set;}

           /// <summary>
           /// Desc:联系人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string linkname {get;set;}

           /// <summary>
           /// Desc:银行名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankname {get;set;}

           /// <summary>
           /// Desc:银行ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankid {get;set;}

           /// <summary>
           /// Desc:银行行号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bankcode {get;set;}

           /// <summary>
           /// Desc:月度管理费率
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? yuedfee {get;set;}

           /// <summary>
           /// Desc:逾期违约金费率
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? yuqifee {get;set;}

           /// <summary>
           /// Desc:剩余月度管理费率
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public decimal? shengyuydfee {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? status {get;set;}

           /// <summary>
           /// Desc:是否银行
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? isbank {get;set;}

           /// <summary>
           /// Desc:是否企业
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public int? iscompany {get;set;}

           /// <summary>
           /// Desc:机构简称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jigoujiancheng {get;set;}

           /// <summary>
           /// Desc:英文简称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ENjigoujiancheng {get;set;}

           /// <summary>
           /// Desc:机构编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string jigouNO {get;set;}

    }
}
