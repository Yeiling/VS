using System;
using System.Collections.Generic;
using WebClient.EntityModel;

namespace ConsoleApp
{
    class Program
    {
        static List<UserInfo> userinfoList = new List<UserInfo>()
        {
            new UserInfo{
                Id=1,
                Name="aa",
                Phone="15612345678"
            },
            new UserInfo{
                Id=2,
                Name="bb",
                Phone="15112345678"
            },
            new UserInfo{
                Id=3,
                Name="cc",
                Phone="15312345678"
            }
        };
        static void Main(string[] args)
        {
            #region 测试使用
            //var r = WACTool.Req<IUserInterface<UserInfo>, Task<IApiResult<List<UserInfo>>>>(api =>
            //{
            //    return api.GetUserAll();
            //});

            //HttpApi.Register<IUserInterface>(); 
            #endregion

            //string id = "1";

            //HttpWebApiClientInterface<IMyWebApi> httpWebApi = new HttpWebApiClientArchieve<IMyWebApi>(new HttpApiClientConfig
            //{
            //    Interval = new TimeSpan(3),
            //    LifeTime=new TimeSpan(5)
            //}); 
            //var result = httpWebApi.Request(h =>
            //{
            //    //return userinfoList;
            //    return h.GetUserAsync(id);
            //});


            #region Polly




            #endregion



            Console.ReadKey();
        }

        public static int a(int a, int b)
        {
            return a / b;
        }
    }
}
