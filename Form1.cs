using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KtGitHub
{
    public partial class Form1 : Form
    {
        List<Account> listAccount = AccountList.Instance.ListAccount;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (CheckLogin(txtUsername.Text, txtPassword.Text))
            {
                FormMain f = new FormMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Incorrect username or password. Please try again.");
                txtUsername.Focus();
            }

        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as FormMain).isExit = false;
            (sender as FormMain).Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool CheckLogin(string username, string password)
        {
            for (int i = 0; i < listAccount.Count; i++)
            {
                if (username == listAccount[i].Username && password == listAccount[i].Password)
                    return true;
            }

            return false;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}