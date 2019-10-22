using Newtonsoft.Json;

namespace shuiyintong.Common.Extend
{
    /// <summary>
    /// Json序列化扩展
    /// </summary>
    public static class JsonExt
    {
        /// <summary>
        /// Json序列化对象
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="obj">对象</param>
        /// <param name="f">格式</param>
        /// <returns></returns>
        public static string ToJson<T>(this T obj, _Formatting f = _Formatting.Indented)
        {
            var ff = Formatting.Indented;
            if (f == _Formatting.None)
                ff = Formatting.None;

            string json = JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                Formatting = ff
            });
            return json;
        }

        /// <summary>
        /// Json反序列话
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">Json字符串</param>
        /// <returns></returns>
        public static T ToObject<T>(this string json)
        {
            if (json == null)
                return default(T);
            return JsonConvert.DeserializeObject<T>(json);
        }

        //
        // 摘要:
        //     Specifies formatting options for the Newtonsoft.Json.JsonTextWriter.
        public enum _Formatting
        {
            //
            // 摘要:
            //     No special formatting is applied. This is the default.
            None = 0,
            //
            // 摘要:
            //     Causes child objects to be indented according to the Newtonsoft.Json.JsonTextWriter.Indentation
            //     and Newtonsoft.Json.JsonTextWriter.IndentChar settings.
            Indented = 1
        }

    }
}
