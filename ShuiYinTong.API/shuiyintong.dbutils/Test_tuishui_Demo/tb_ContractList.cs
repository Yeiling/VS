using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///合同表
    ///</summary>
    [SugarTable("tb_ContractList")]
    public partial class tb_ContractList
    {
           public tb_ContractList(){


           }
           /// <summary>
           /// Desc:键值
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:订单ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? OrderId {get;set;}

           /// <summary>
           /// Desc:订单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string OrderNO {get;set;}

           /// <summary>
           /// Desc:合同号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HTNO {get;set;}

           /// <summary>
           /// Desc:合同名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HTName {get;set;}

           /// <summary>
           /// Desc:合同状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string HTstatus {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateTime {get;set;}

           /// <summary>
           /// Desc:签署时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SignTime {get;set;}

           /// <summary>
           /// Desc:链接
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string LinkPath {get;set;}

           /// <summary>
           /// Desc:类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Type {get;set;}

           /// <summary>
           /// Desc:类型2 
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Text2 {get;set;}

           /// <summary>
           /// Desc:用款Id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? YongkuanId {get;set;}

           /// <summary>
           /// Desc:用款编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string YongkuanNo {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DB_NO {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Text3 {get;set;}

    }
}
