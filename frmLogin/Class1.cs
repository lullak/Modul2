﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLogin
{
    public class Credentials
    {
        private string _username;
        private string _password;

        public Credentials()
        {
            _username = "user";
            _password = "password";
        }

        public Credentials(string username, string password)
        {
            _username = username;
            _password = password;
        }   

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
