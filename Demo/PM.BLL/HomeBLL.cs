using Newtonsoft.Json;
using PM.Entity;
using PM.Entity.AppSettings;
using PM.Factory;
using PM.Service;
using PM.Service.CacheSetting;
using PM.Service.IService;
using PM.Service.Service;
using System.Reflection;

namespace PM.BLL
{
    public class HomeBLL
    {
        /// <summary>
        /// 业务逻辑
        /// </summary>
        public static object Index()
        {
            //string pm = Config.DBConfig.PM;
            //string edm = Config.DBConfig.EDM;
            //string url = Config.DBConfig.URL.DefaultURL;
            //string rooturl = Config.Setting.RootUrl;

            //SaveCache.CacheAll();
            //var temp = LoadCache.Cache.neo_t_departmentModel.FindAll(ntm =>
            //{
            //    return ntm.name.Contains("部门");
            //});

            //SqlSugarDBContext.GetDbContext(Config.DBConfig.Test).SqlSugarClientAct(sc =>
            //{
            //    sc.DbFirst.CreateClassFile(@"D:\GitFiles\Demo\PM.Entity\TestEntity", "PM.Entity.TestEntity");
            //});

            //var DbContext1 = SqlSugarDBContext.GetDbContext(Config.DBConfig.PM);
            //单个实体对象常规操作---不支持SQL语句
            //var lst = DbContext1.SimpleClientFun(sc =>
            //{
            //    return sc.GetList<neo_t_department>(s => s.active == 1 && s.name.Contains("部"));
            //});

            //var DbContext2 = SqlSugarDBContext.GetDbContext();
            ////其他操作支持SQL语句
            //var lsts = DbContext2.SqlSugarClientFun(ssc =>
            //{
            //    return ssc.SqlQueryable<neo_t_message>(@"select id,title,content,type,related_type,related_obj,is_related,recall,deleted,create_time,last_modify_time,organization_id,sender_id from neo_t_message").ToArray();

            //    //统计数量
            //    //return ssc.Ado.GetInt(@"SELECT COUNT(1) from auth_group");
            //});
            //return JsonConvert.SerializeObject(lst);


            //ITestable test = Assembly.Load("PM.Entity").CreateInstance("PM.Entity.ModelTest") as ModelTest;
            //int max = test.max(20, 50);


            //var deptmodel = ServerFac.GetObject(Config.DBConfig.ServerModel.DeptService) as IDeptService;
            //var deptList = deptmodel.QueryList();
            //string Jsonstr1 = JsonConvert.SerializeObject(deptList);
            //var empmodel = ServerFac.GetObject(Config.DBConfig.ServerModel.EmpService) as IEmpService;
            //int total = 0;
            //var empList = empmodel.QueryPage(ep => ep.ename.Contains("o"), ref total, 1, 30);
            //string Jsonstr2 = JsonConvert.SerializeObject(empList);

            var OrderDetailService = ServerFac.GetObject(Config.DBConfig.ServerModel.OrderDetailService) as IOrderDetailService;
            var orders = OrderDetailService.QueryList();




            return orders;
        }


    }
}