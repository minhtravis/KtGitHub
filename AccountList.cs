using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtGitHub
{
    public class AccountList
    {
        private static AccountList instance;

        public static AccountList Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountList();
                return instance;
            }
            set => instance = value;
        }

        List<Account> listAccount;

        public List<Account> ListAccount
        {
            get => listAccount;
            set => listAccount = value;
        }


        AccountList()
        {
            listAccount = new List<Account>();
            listAccount.Add(new Account("admin", "admin"));
        }
    }
}
