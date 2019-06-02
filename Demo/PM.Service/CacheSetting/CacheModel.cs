using PM.Entity.CacheEntity;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PM.Service.CacheSetting
{
    [Serializable]
    public class CacheModel
    {
        /// <summary>
        /// 部门信息表缓存
        /// </summary>
        public List<DeptModel> DeptModel { get; set; }

        public CacheModel()
        {
            DeptModel = new List<DeptModel>();
        }
        protected CacheModel(SerializationInfo info, StreamingContext context)
            : this()
        {
            try { DeptModel = (List<DeptModel>)info.GetValue("DeptModel", typeof(List<DeptModel>)); }
            catch { }

        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("DeptModel", DeptModel);
        }


    }
}
