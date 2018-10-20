using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADO_NET.Model
{
    public class User
    {
        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _pwd;
        public string pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
        private string _role;
        public string role
        {
            get { return _role; }
            set { _role = value; }
        }

    }
}
