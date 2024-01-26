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
    public partial class LoginWindow : Form
    {
        public static event EventHandler OnLogin;
        private User _user;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Login(object sender, EventArgs e)
        {
            _user = new();
            _user.UserName = userName_tbx.Text;
            _user.Password = password_tbx.Text;
            if (!string.IsNullOrEmpty(_user.UserName) && !string.IsNullOrEmpty(_user.Password))
            {
                _user.Permission = Permisson.Normal;
                _user.PermissionDescription = "普通用户";
                CloseWindow();
            }
            if (_user.UserName == "ad")
            {
                _user.Permission = Permisson.Admin;
                _user.PermissionDescription = "管理员";
                CloseWindow();
            }
            if (_user.UserName == "Eng")
            {
                _user.Permission = Permisson.Engineer;
                _user.PermissionDescription = "工程师";
                CloseWindow();
            }
            
        }
        private void CloseWindow()
        {
            OnLogin?.Invoke(_user, EventArgs.Empty);
            this.Close();
        }
    }
}
