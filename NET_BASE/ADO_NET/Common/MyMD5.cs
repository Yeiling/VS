using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace ADO_NET.Common
{
    public static class MyMD5
    {
        //MD5加密方法
        public static string GetMD5(string str)
        {
            StringBuilder sb = new StringBuilder();
            if (!String.IsNullOrEmpty(str))
            {
                byte[] bt = Encoding.Default.GetBytes(str);
                using (MD5 m = MD5.Create())
                {
                    byte[] md5bt = m.ComputeHash(bt);

                    for (int i = 0; i < md5bt.Length; i++)
                    {
                        sb.Append(md5bt[i].ToString("x"));
                    }
                }

            }
            return sb.ToString();
        }


    }
}
