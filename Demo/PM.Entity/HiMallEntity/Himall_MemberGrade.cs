using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_MemberGrade
    {
           public Himall_MemberGrade(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:会员等级名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string GradeName {get;set;}

           /// <summary>
           /// Desc:该等级所需积分
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Integral {get;set;}

           /// <summary>
           /// Desc:描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:
           /// Default:10.00
           /// Nullable:False
           /// </summary>           
           public decimal Discount {get;set;}

    }
}
