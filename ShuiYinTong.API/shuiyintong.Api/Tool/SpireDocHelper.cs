using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using shuiyintong.Common.Extend;
using shuiyintong.DBUtils.IService;
using shuiyintong.Entity.Enums;
using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace shuiyintong.Api.Tool
{
    /// <summary>
    /// 
    /// </summary>
    public class SpireDocHelper
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public SpireDocHelper(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 对象转Html文档
        /// </summary>
        /// <param name="html"></param>
        /// <param name="type"></param>
        /// <param name="memi"></param>
        /// <returns></returns>
        public OpResult<Stream> SwaggerHtmlConvers(string html, string type, out string memi)
        {
            string fileName = Guid.NewGuid().ToString() + type;
            string webRootPath = _hostingEnvironment.WebRootPath;
            string path = webRootPath + @"\Files\TempFiles\";
            var addrUrl = path + $"{fileName}";
            FileStream fileStream = null;
            var provider = new FileExtensionContentTypeProvider();
            memi = provider.Mappings[type];
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                var data = System.Text.Encoding.Default.GetBytes(html);
                //byte[] data = Encoding.Default.getbyte(ByteHelpe.html); 
                var stream = ByteExt.BytesToStream(data);
                //创建Document实例
                Spire.Doc.Document document = new Spire.Doc.Document();
                //加载HTML文档
                //document.LoadFromFile("APIDocument.html", FileFormat.Html, XHTMLValidationType.None);
                document.LoadFromStream(stream, FileFormat.Html, XHTMLValidationType.None);
                //document.LoadText(stream, Encoding.Default);
                //保存为Word
                switch (type)
                {
                    case ".docx":
                        //Word
                        document.SaveToFile(addrUrl, FileFormat.Docx);
                        break;
                    case ".pdf":
                        //PDF
                        document.SaveToFile(addrUrl, FileFormat.PDF);
                        break;
                    case ".html":
                        //Html
                        FileStream fs = new FileStream(addrUrl, FileMode.Append, FileAccess.Write, FileShare.None);//html直接写入不用spire.doc
                        StreamWriter sw = new StreamWriter(fs); // 创建写入流
                        sw.WriteLine(html); // 写入Hello World
                        sw.Close(); //关闭文件
                        fs.Close();
                        break;
                    case ".xml":
                        //PDF
                        document.SaveToFile(addrUrl, FileFormat.WordXml);
                        break;
                    case ".svg":
                        //PDF
                        document.SaveToFile(addrUrl, FileFormat.SVG);
                        break;
                }
                document.Close();
                fileStream = File.Open(addrUrl, FileMode.OpenOrCreate);
                var filedata = ByteExt.StreamToBytes(fileStream);
                var outdata = ByteExt.BytesToStream(filedata);
                return new OpResult<Stream>(OpResultType.Success, "转换成功！", outdata);
            }
            catch (Exception e)
            {
                return new OpResult<Stream>(OpResultType.Error, $"转换失败，{e.Message}", null);
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
                if (File.Exists(addrUrl))
                    File.Delete(addrUrl);//删掉文件
            }
        }
    }

    /// <summary>
    /// 操作结果
    /// </summary>
    /// <typeparam name="TData">操作结果数据</typeparam>
    public class OpResult<TData> : ExecResult<OpResultType, TData>
    {
        /// <summary>
        /// 初始化一个<see cref="OpResult{TData}"/>类型的新实例
        /// </summary>
        public OpResult() { ResultType = OpResultType.NoChanged; }

        /// <summary>
        /// 初始化一个<see cref="OpResult{TData}"/>类型的新实例
        /// </summary>
        public OpResult(OpResultType resultType)
            : this(resultType, null, default(TData))
        { }

        /// <summary>
        /// 初始化一个<see cref="OpResult{TData}"/>类型的新实例
        /// </summary>
        public OpResult(OpResultType resultType, string message)
            : this(resultType, message, default(TData))
        { }

        /// <summary>
        /// 初始化一个<see cref="OpResult{TData}"/>类型的新实例
        /// </summary>
        public OpResult(OpResultType resultType, string message, TData data)
            : base(resultType, message, data)
        { }

        /// <summary>
        /// 是否操作成功
        /// </summary>
        public bool Successed { get { return ResultType == OpResultType.Success; } }

        /// <summary>
        /// 返回消息字段
        /// </summary>
        private string _message;

        /// <summary>
        /// 返回消息属性
        /// </summary>
        public override string Message
        {
            get
            {
                if (string.IsNullOrEmpty(_message))
                {
                    Type type = ResultType.GetType();
                    MemberInfo member = type.GetMember(ResultType.ToString()).FirstOrDefault();
                    return member != null ? member.GetCustomAttribute<DescriptionAttribute>().Description : ResultType.ToString();
                }
                else
                {
                    return _message;
                }
            }
            set { _message = value; }
        }
    }

    /// <summary>
    /// 执行结果
    /// </summary>
    /// <typeparam name="TResultType">执行结果类型的类型</typeparam>
    /// <typeparam name="TData">执行结果数据的类型</typeparam>
    public abstract class ExecResult<TResultType, TData> : IExecResult<TResultType, TData>
    {
        /// <summary>
        /// 结果类型
        /// 0=操作没有引发任何变化，提交取消。
        /// 1=操作成功。
        /// 2=操作引发错误。
        /// 3=指定参数的数据不存在。
        /// 4=输入信息验证失败。
        /// 5=登录失效。
        /// 6=身份认证信息错误。
        /// 7=未登录。
        /// </summary>
        public virtual TResultType ResultType { get; set; }

        /// <summary>
        /// 结果附带数据
        /// </summary>
        public virtual TData Data { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        public virtual string Message { get; set; }

        /// <summary>
        /// 无参构造函数
        /// </summary>
        protected ExecResult()
            : this(default(TResultType))
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_type"></param>
        protected ExecResult(TResultType _type)
            : this(_type, null, default(TData))
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_msg"></param>
        protected ExecResult(TResultType _type, string _msg)
            : this(_type, _msg, default(TData))
        { }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="_type"></param>
        /// <param name="_msg"></param>
        /// <param name="_data"></param>
        protected ExecResult(TResultType _type, string _msg, TData _data)
        {
            ResultType = _type;
            Message = _msg;
            Data = _data;
        }
    }
}
