using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("tb_SystemManager_ActionLog")]
    public partial class tb_SystemManager_ActionLog
    {
           public tb_SystemManager_ActionLog(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int ID {get;set;}

           /// <summary>
           /// Desc:更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? UpdateTime {get;set;}

           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string No {get;set;}

           /// <summary>
           /// Desc:变更项目
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bgtype {get;set;}

           /// <summary>
           /// Desc:变更前
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bgold {get;set;}

           /// <summary>
           /// Desc:变更后
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string bgnew {get;set;}

           /// <summary>
           /// Desc:操作人员
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string operatorname {get;set;}

           /// <summary>
           /// Desc:页面来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string viewfrom {get;set;}

           /// <summary>
           /// Desc:相关ID，如产品ID,金融客户ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? RelatedId {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string remark {get;set;}

    }
}
