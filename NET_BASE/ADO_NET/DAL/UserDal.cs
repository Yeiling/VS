using ADO_NET.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO_NET.DAL
{
    public delegate User delUser(string name, string pwd);//定义一个委托
    public class UserDal
    {
        private static readonly string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConSGJJ"].ToString();
        private static string sql = "select userid,username,password from dbo.[User] where username=@name and password=@pwd";

        //定义方法判断是否成功连接数据库
        public static User DBCon(delUser del, string name, string pwd)
        {
            User u = null;
            SqlConnection conn = new SqlConnection(constr);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                    u = del(name, pwd);
            }
            catch { }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return u;
        }

        //sql获取数据
        public static User GetUser(string name, string pwd)
        {
            User u = null;
            SqlConnection conn = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlParameter[] para = new SqlParameter[] {
                    new SqlParameter("@name",SqlDbType.NVarChar,50){Value=string.IsNullOrEmpty(name)?string.Empty:name},
                    new SqlParameter("@pwd",SqlDbType.NVarChar,100){Value=string.IsNullOrEmpty(pwd)?string.Empty:pwd}
                };
                cmd.Parameters.AddRange(para);

                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    u = new User();
                    u.id = r["userid"].ToString();
                    u.name = r["username"].ToString();
                    u.pwd = r["password"].ToString();
                }
            }
            catch (Exception e)
            { }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            return u;

        }

    }
}
