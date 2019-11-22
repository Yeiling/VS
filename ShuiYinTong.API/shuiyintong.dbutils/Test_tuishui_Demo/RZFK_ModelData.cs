using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("RZFK_ModelData")]
    public partial class RZFK_ModelData
    {
           public RZFK_ModelData(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:基础模型指标表关联ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string TypeID {get;set;}

           /// <summary>
           /// Desc:数据KEY
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DataKey {get;set;}

           /// <summary>
           /// Desc:数据VALUE
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string DataValue {get;set;}

           /// <summary>
           /// Desc:模型类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModelType {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Sort {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public decimal? fenzhi {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string gongshi {get;set;}

           /// <summary>
           /// Desc:创建日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? CreateDate {get;set;}

           /// <summary>
           /// Desc:创建人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string CreateUser {get;set;}

           /// <summary>
           /// Desc:修改日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? ModifyDate {get;set;}

           /// <summary>
           /// Desc:修改人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ModifyUser {get;set;}

    }
}
