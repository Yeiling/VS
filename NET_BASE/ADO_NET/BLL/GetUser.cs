using ADO_NET.Common;
using ADO_NET.DAL;
using ADO_NET.Model;
using System.Collections.Generic;

namespace ADO_NET.BLL
{
    public class GetUser
    {
        //获取用户名和密码(MD5加密)
        public List<User> UserArry(string name, string pwd)
        {
            List<User> Users = null;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(pwd))
            {
                pwd = MyMD5.GetMD5(pwd).Trim();

                User u = UserDal.DBCon(UserDal.GetUser, name, pwd);
                if (u != null)
                {
                    Users = new List<User>();
                    Users.Add(u);
                }
            }
            return Users;
        }
    }
}
