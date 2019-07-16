using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///分销员等级表
    ///</summary>
    public partial class Himall_DistributorGrade
    {
           public Himall_DistributorGrade(){


           }
           /// <summary>
           /// Desc:编号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string GradeName {get;set;}

           /// <summary>
           /// Desc:条件
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Quota {get;set;}

    }
}
