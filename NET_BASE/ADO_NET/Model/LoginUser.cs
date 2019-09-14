namespace ADO_NET.Model
{
    public static class LoginUser
    {
        private static string _id;
        public static string id
        {
            get { return _id; }
            set { _id = value; }
        }
        private static string _name;
        public static string name
        {
            get { return _name; }
            set { _name = value; }
        }
        private static string _pwd;
        public static string pwd
        {
            get { return _pwd; }
            set { _pwd = value; }
        }
    }
}
