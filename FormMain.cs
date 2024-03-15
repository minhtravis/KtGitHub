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
    public partial class FormMain : Form
    {
        public bool isExit = true;

        public FormMain()
        {
            InitializeComponent();
        }

        public event EventHandler Logout;


        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Do you want to exit the program?", "", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }
    }
}
