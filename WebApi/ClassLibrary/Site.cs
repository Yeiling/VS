using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace ClassLibrary
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("Site")]
    public partial class Site
    {
           public Site(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int Id {get;set;}

           /// <summary>
           /// Desc:站点名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Name {get;set;}

           /// <summary>
           /// Desc:站点网址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Url {get;set;}

           /// <summary>
           /// Desc:站点备案
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BeiAn {get;set;}

           /// <summary>
           /// Desc:所属用户
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int UserId {get;set;}

           /// <summary>
           /// Desc:状态
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public short Status {get;set;}

           /// <summary>
           /// Desc:平台类型（0：pc，1：wap，2：app）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short SiteType {get;set;}

           /// <summary>
           /// Desc:app名称
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppName {get;set;}

           /// <summary>
           /// Desc:app包名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppPackage {get;set;}

           /// <summary>
           /// Desc:app版本
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppVersion {get;set;}

           /// <summary>
           /// Desc:app应用商店地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppUrl {get;set;}

           /// <summary>
           /// Desc:智合平台生成的appid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppId {get;set;}

           /// <summary>
           /// Desc:设备类型（0：其他，1：Android，2：IOS）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public short AppOSType {get;set;}

           /// <summary>
           /// Desc:app描述
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string AppDescription {get;set;}

           /// <summary>
           /// Desc:支持一键下载
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppDown {get;set;}

           /// <summary>
           /// Desc:支持gif
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppDongTu {get;set;}

           /// <summary>
           /// Desc:支持DeepLink
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppLink {get;set;}

           /// <summary>
           /// Desc:支持Html
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppHtml {get;set;}

           /// <summary>
           /// Desc:支持GPS
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppGPS {get;set;}

           /// <summary>
           /// Desc:app请求超时时间 毫秒
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int TimeOut {get;set;}

           /// <summary>
           /// Desc:支持宏替换
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppSupMacro {get;set;}

           /// <summary>
           /// Desc:支持Js
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppJs {get;set;}

           /// <summary>
           /// Desc:支持视频
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppVideo {get;set;}

           /// <summary>
           /// Desc:添加时间
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime PostDate {get;set;}

           /// <summary>
           /// Desc:所属公司
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Company {get;set;}

           /// <summary>
           /// Desc:提供签名包验证
           /// Default:
           /// Nullable:False
           /// </summary>           
           public bool IsAppSignature {get;set;}

    }
}
