using System;
using System.Linq;
using System.Text;

namespace PM.Entity.HiMallEntity
{
    ///<summary>
    ///
    ///</summary>
    public partial class Himall_CustomerService
    {
           public Himall_CustomerService(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long Id {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ShopId {get;set;}

           /// <summary>
           /// Desc:工具类型（QQ、旺旺）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Tool {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Type {get;set;}

           /// <summary>
           /// Desc:客服名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:通信账号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AccountCode {get;set;}

           /// <summary>
           /// Desc:终端类型
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int TerminalType {get;set;}

           /// <summary>
           /// Desc:客服状态
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int ServerStatus {get;set;}

    }
}
