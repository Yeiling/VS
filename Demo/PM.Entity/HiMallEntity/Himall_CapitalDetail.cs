using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CapitalDetail
    {
           public Himall_CapitalDetail(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:资产主表ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long CapitalID {get;set;}

           /// <summary>
           /// Desc:资产类型
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int SourceType {get;set;}

           /// <summary>
           /// Desc:金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal Amount {get;set;}

           /// <summary>
           /// Desc:来源数据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string SourceData {get;set;}

           /// <summary>
           /// Desc:交易时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime CreateTime {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Remark {get;set;}

           /// <summary>
           /// Desc:赠送
           /// Default:0.00
           /// Nullable:False
           /// </summary>           
           public decimal PresentAmount {get;set;}

    }
}
