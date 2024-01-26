using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AOPDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoginWindow.OnLogin += LoginWindow_OnLogin;
        }

        private void LogIn(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        [Check(Permisson.Engineer)]
        private void Func_Click(object sender, EventArgs e)
        {
            MessageBox.Show("打开功能中...");
        }

        private void LoginWindow_OnLogin(object sender, EventArgs e)
        {
            Global.CurrentUser = sender as User;
            permisson_tsLab.Text = Global.CurrentUser.PermissionDescription;
            userName_tsLab.Text = Global.CurrentUser.UserName;
        }
    }
}
