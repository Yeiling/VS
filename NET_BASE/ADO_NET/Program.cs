using ADO_NET.BLL;
using ADO_NET.Model;
using System;
using System.Collections.Generic;

namespace ADO_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名:");
            string name = Console.ReadLine().Trim();
            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine("请输入密码:");
                string pwd = Console.ReadLine().Trim();

                if (!string.IsNullOrEmpty(pwd))
                {
                    GetUser g = new GetUser();
                    List<User> us = g.UserArry(name, pwd);
                    if (us.Count > 0)
                    {
                        for (int i = 0; i < us.Count; i++)
                        {
                            Console.WriteLine("编号是:{0}", us[i].id);
                            Console.WriteLine("用户名是:{0}", us[i].name);
                            Console.WriteLine("密码是:{0}", us[i].pwd);
                        }
                    }
                    else
                    {
                        Console.WriteLine("登录失败,没有这个人.....");
                    }
                }

            }


            Console.ReadKey();
        }


    }



}
