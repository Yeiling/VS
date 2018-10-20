using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XML
{
    public class Vnd
    {
        private string _vndid;

        public string Vndid
        {
            get { return _vndid; }
            set { _vndid = value; }
        }
        private string _vndname;

        public string Vndname
        {
            get { return _vndname; }
            set { _vndname = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _contacts;

        public string Contacts
        {
            get { return _contacts; }
            set { _contacts = value; }
        }
        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
