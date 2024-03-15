using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtGitHub
{
    public class Account
    {
        private string userName;

        public string Username
        {
            get => userName;
            set => userName = value;
        }

        private string passWord;

        public string Password
        {
            get => passWord;
            set => passWord = value;
        }

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
