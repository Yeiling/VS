using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace shuiyintong.Common.BankConfig
{
    /// <summary>
    /// 缓存Cache使用
    /// </summary>
    [Serializable]
    public class SettingsModel
    {
        public List<BankConfig> BankConfig { get; set; }

        public SettingsModel()
        {
            BankConfig = new List<BankConfig>();

        }
        protected SettingsModel(SerializationInfo info, StreamingContext context)
            : this()
        {
            try { BankConfig = (List<BankConfig>)info.GetValue("BankConfig", typeof(List<BankConfig>)); }
            catch { }

        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("BankConfig", BankConfig);
        }
    }
}
