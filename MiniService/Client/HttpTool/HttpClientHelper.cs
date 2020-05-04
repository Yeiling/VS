using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Client.HttpTool
{
    /// <summary>
    /// HttpClient请求公共类
    /// </summary>
    public class HttpClientHelper
    {
        /// <summary>
        /// POST请求获取结果
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="data">参数</param>
        /// <param name="header">请求头</param>
        /// <param name="timeout">超时时间</param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static string POSTRequest(string url, string data, Dictionary<string, string> header = null, Action<HttpStatusCode, string> dataAction = null, int timeout = 30000, string contentType = "application/json")
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new Exception("请求url为空");
            if (data == null)
                data = "";
            if (!(WebRequest.Create(url) is HttpWebRequest request))
                return null;

            request.Timeout = timeout;
            request.Method = "POST";
            byte[] bdata = Encoding.UTF8.GetBytes(data);
            request.ContentType = contentType;
            request.MediaType = contentType;
            request.ContentLength = bdata.Length;
            if (header.IsNotNullOrEmpty())
            {
                foreach (var h in header)
                    request.Headers.Add(h.Key, h.Value);
            }
            using (Stream streamOut = request.GetRequestStream())
            {
                streamOut.Write(bdata, 0, bdata.Length);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream streamIn = response.GetResponseStream())
                    {
                        if (streamIn == null)
                            return null;

                        string result;
                        using (StreamReader reader = new StreamReader(streamIn))
                        {
                            result = reader.ReadToEnd();
                        }
                        if (!string.IsNullOrWhiteSpace(result))
                            dataAction?.Invoke(response.StatusCode, result);

                        return result;
                    }
                }
            }
        }

        /// <summary>
        /// Get请求
        /// </summary>
        /// <param name="url">URL地址</param>
        /// <param name="dataAction">请求结果处理</param>
        /// <param name="timeout">超时时间</param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public static string GetRequest(string url, Action<HttpStatusCode, string> dataAction = null, int timeout = 30000, string contentType = "application/json")
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new Exception("请求url为空");
            if (!(WebRequest.Create(url) is HttpWebRequest request))
                return null;

            request.Timeout = timeout;
            request.Method = "GET";
            request.ContentType = contentType;
            request.MediaType = contentType;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream streamIn = response.GetResponseStream())
                {
                    if (streamIn == null)
                        return null;

                    string result;
                    using (StreamReader reader = new StreamReader(streamIn))
                    {
                        result = reader.ReadToEnd();
                    }
                    if (!string.IsNullOrWhiteSpace(result))
                        dataAction?.Invoke(response.StatusCode, result);

                    return result;
                }
            }

        }
    }
}
