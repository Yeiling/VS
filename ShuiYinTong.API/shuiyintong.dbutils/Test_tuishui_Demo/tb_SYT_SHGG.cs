using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace shuiyintong.DBUtils.Test_tuishui_Demo
{
    ///<summary>
    ///失信公告(企业)
    ///</summary>
    [SugarTable("tb_SYT_SHGG")]
    public partial class tb_SYT_SHGG
    {
           public tb_SYT_SHGG(){


           }
           /// <summary>
           /// Desc:主键ID
           /// Default:replace(newid(),'-','')
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:企业名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_entName {get;set;}

           /// <summary>
           /// Desc:税银通企业id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SYT_ENT_ID {get;set;}

           /// <summary>
           /// Desc:被执行人姓名/名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BA_pname {get;set;}

           /// <summary>
           /// Desc:失信公告ID
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_shixinId {get;set;}

           /// <summary>
           /// Desc:立案日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SHIXIN_sortTime {get;set;}

           /// <summary>
           /// Desc:性别
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_sex {get;set;}

           /// <summary>
           /// Desc:被执行人履行情况
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_lxqk {get;set;}

           /// <summary>
           /// Desc:执行依据文号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_yjCode {get;set;}

           /// <summary>
           /// Desc:关联人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_relatedParty {get;set;}

           /// <summary>
           /// Desc:执行法院名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_court {get;set;}

           /// <summary>
           /// Desc:身份证/组织机构代码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_idcardNo {get;set;}

           /// <summary>
           /// Desc:作出执行依据单位
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_yjdw {get;set;}

           /// <summary>
           /// Desc:失信被执行人行为具体情形
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_jtqx {get;set;}

           /// <summary>
           /// Desc:生效法律文书确定的义务
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_yiwu {get;set;}

           /// <summary>
           /// Desc:年龄
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? SHIXIN_age {get;set;}

           /// <summary>
           /// Desc:被告
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_pname {get;set;}

           /// <summary>
           /// Desc:所在省份
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_province {get;set;}

           /// <summary>
           /// Desc:案号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_caseNo {get;set;}

           /// <summary>
           /// Desc:发布日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SHIXIN_postTime {get;set;}

           /// <summary>
           /// Desc:公示信息类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SHIXIN_disabled {get;set;}

           /// <summary>
           /// Desc:数据更新时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? SysUpdateTime {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sxID {get;set;}

    }
}
