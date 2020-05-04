using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading;
using WebApiClient;
using WebApiClient.Attributes;
using WebApiClient.Parameterables;
using WebClient.AchieveFile;
using WebClient.EntityModel;

namespace WebClient.InterfaceFiles
{
    /// <summary>
    /// 测试接口
    /// </summary>
    public interface IMyWebApi : IHttpApi
    {
        [HttpGet("user/{id}")]
        ITask<UserInfo> GetUserAsync(string id);

        //--------------------------Get请求------------------------
        // GET /webapi/user?account=laojiu   ////可以添加参数验证
        [HttpGet("webapi/user")]
        ITask<HttpResponseMessage> GetUserByAccountAsync1([Required, StringLength(10)] string account);

        // GET /webapi/user?account=laojiu
        [HttpGet("webapi/user")]
        ITask<ApiResult<UserInfo>> GetUserByAccountAsync2(string account); //隐式转换为强类型模型

        // GET /webapi/user?account=laojiu
        [HttpGet("webapi/user")]
        [JsonReturn] // 指明使用Json处理返回值为UserInfo类型
        ITask<ApiResult<UserInfo>> GetUserByAccountAsync3(string account); //显式转换为强类型模型

        // GET /webapi/user?account=laojiu
        [HttpGet("webapi/user")]
        ITask<ApiResult<UserInfo>> GetUserByAccountAsync4(string account, CancellationToken token); //请求取消令牌参数CancellationToken

        // GET ///http://www.webapiclient.com/laojiu
        [HttpGet("http://www.webapiclient.com/{account}")]
        ITask<ApiResult<string>> GetUserByAccountAsync5(string account);  //动态PATH

        // GET {URI}
        [HttpGet]
        ITask<ApiResult<string>> GetUserByAccountAsync6([Uri] string url); //动态URI
        // GET {URI}?account=laojiu
        [HttpGet]
        ITask<ApiResult<string>> GetUserByAccountAsync7([Uri] string url, string account); //动态URI


        // GET /webapi/user?account=laojiu&password=123456
        [HttpGet("webapi/user")]
        ITask<ApiResult<UserInfo>> GetUserAsync8([Required]string account, [Required]string password);  //多个query参数平铺
        // GET /webapi/user?Account=laojiu&password=123456
        [HttpGet("webapi/user")]
        ITask<ApiResult<UserInfo>> GetUserAsync9(UserReq user);


        // GET /webapi/user?Account=laojiu&password=123456&role=admin
        [HttpGet("webapi/user")]
        ITask<ApiResult<UserInfo>> GetUserAsync10(UserReq user, string role); //多个query参数平铺+部分合并到模型


        //--------------------------POST/PUT/DELETE请求--------------------------
        //使用Json或Xml提交

        //使用[XmlContent] 或[Parameter(Kind.XmlBody)]修饰强类型模型参数，表示提交xml
        //使用[JsonContent]或[Parameter(Kind.JsonBody)] 修饰强类型模型参数，表示提交json

        // POST webapi/user  
        // Body user的json文本，//UserInfo为必填项
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> AddUserWithJsonAsync11([Required, JsonContent] UserInfo user);

        // PUT webapi/user  
        // Body user的xml文本
        [HttpPut("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithXmlAsync12([XmlContent] UserInfo user);

        //--------------------------使用x-www-form-urlencoded提交--------------------------
        // POST webapi/user  
        // Body Account=laojiu&Password=123456
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithFormAsync13(
            [FormContent] UserInfo user);

        // POST webapi/user  
        // Body Account=laojiu&Password=123456&fieldX=xxx
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithFormAsync14(
            [Required, FormContent] UserInfo user,
            [FormField] string fieldX);

        // POST webapi/user  
        // Body Account=laojiu&Password=123456&fieldX=xxx
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserAsync15(
            [Parameter(Kind.Form)] UserInfo user,
            [Parameter(Kind.Form)] string fieldX);

        //--------------------------使用multipart/form-data提交--------------------------
        // POST webapi/user  
        [WebApiClient.Attributes.HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithMulitpartAsync16(
            [MulitpartContent] UserInfo user);

        // POST webapi/user  
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithMulitpartAsync17(
            [MulitpartContent] UserInfo user,
            [MulitpartText] string nickName,
            MulitpartFile file);

        // POST webapi/user  
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithMulitpartAsync18(
            [Parameter(Kind.FormData)] UserInfo user,
            [Parameter(Kind.FormData)] string nickName,
            MulitpartFile file);


        //--------------------------使用具体的HttpContent类型提交--------------------------
        // POST webapi/user  
        // Body Account=laojiu&Password=123456
        [Microsoft.AspNetCore.Mvc.HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithFormAsync19(
            FormUrlEncodedContent user);

        // POST webapi/user  
        // Body Account=laojiu&Password=123456&age=18
        [HttpPost("webapi/user")]
        ITask<ApiResult<UserInfo>> UpdateUserWithFormAsync20(
            FormUrlEncodedContent user,
            [FormField] int age);



        //---------------------------其他定义---------------------------

        /// <summary>
        /// 不处理返回值结果 
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        // GET /webapi/user?account=laojiu   
        [HttpGet("webapi/user")]
        ITask<HttpResponseMessage> GetUserByAccountAsync21(string account);


        /// <summary>
        /// 文件操作---下载
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        // GET /webapi/user?account=laojiu   
        [HttpGet("webapi/user")]
        ITask<HttpResponseFile> GetUserByAccountAsync22(string account);

    }
}
