using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace ClassLibrary
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Role")]
    public partial class Role
    {
           public Role(){


           }
           /// <summary>
           /// Desc:角色id（99：超级管理员，98：管理员，97：运营，96：媒介，95：商务，1：代理，0：站长）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int RoleId {get;set;}

           /// <summary>
           /// Desc:角色名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string RoleName {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short Status {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

    }
}
