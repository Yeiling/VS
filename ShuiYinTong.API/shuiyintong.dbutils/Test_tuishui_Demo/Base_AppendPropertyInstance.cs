using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///资料属性实例
    ///</summary>
    [SugarTable("Base_AppendPropertyInstance")]
    public partial class Base_AppendPropertyInstance
    {
           public Base_AppendPropertyInstance(){


           }
           /// <summary>
           /// Desc:属性实例主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string PropertyInstance_ID {get;set;}

           /// <summary>
           /// Desc:附加属性主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Property_Control_ID {get;set;}

           /// <summary>
           /// Desc:对象属性值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PropertyInstance_Value {get;set;}

           /// <summary>
           /// Desc:对象业务属性主键
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string PropertyInstance_Key {get;set;}

    }
}
