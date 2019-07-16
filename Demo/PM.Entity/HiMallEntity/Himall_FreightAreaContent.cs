using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_FreightAreaContent
    {
           public Himall_FreightAreaContent(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:运费模板ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long FreightTemplateId {get;set;}

           /// <summary>
           /// Desc:地区选择
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AreaContent {get;set;}

           /// <summary>
           /// Desc:首笔单元计量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int FirstUnit {get;set;}

           /// <summary>
           /// Desc:首笔单元费用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float FirstUnitMonry {get;set;}

           /// <summary>
           /// Desc:递增单元计量
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int AccumulationUnit {get;set;}

           /// <summary>
           /// Desc:递增单元费用
           /// Default:
           /// Nullable:False
           /// </summary>           
           public float AccumulationUnitMoney {get;set;}

           /// <summary>
           /// Desc:是否为默认
           /// Default:
           /// Nullable:False
           /// </summary>           
           public byte IsDefault {get;set;}

    }
}
