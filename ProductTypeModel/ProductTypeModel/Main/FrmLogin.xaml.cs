using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BLL;
using Models;

namespace UI
{
    /// <summary>
    /// FrmLogin.xaml 的交互逻辑
    /// </summary>
    public partial class FrmLogin : Window
    {
        UserSevice UserSer = new UserSevice();
        public FrmLogin()
        {
            InitializeComponent();
            TBUserId.Focus();
        }



        private void TBUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TBPassword.Focus();
            }
        }

        private void TBPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BTLogin_Click(null, null);
            }
        }

        private void BTCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BTLogin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBUserId.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空", "错误提示");
                TBUserId.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TBPassword.Password))
            {
                MessageBox.Show("密码不能为空", "错误提示");
                TBPassword.Focus();
                return;
            }
            if (TBUserId.Text.Trim().Length != 6)
            {
                MessageBox.Show("用户名必须为6位有效数字");
                TBUserId.Clear();
                TBUserId.Focus();
                return;
            }
            if (UserSer.IsExist(TBUserId.Text.Trim(), TBPassword.Password))
            {
                FrmMain frmMain = new FrmMain();
                frmMain.UserModel = UserSer.GetModel(TBUserId.Text.Trim());
                frmMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "错误提示");
                TBUserId.Clear();
                TBPassword.Clear();
                TBUserId.Focus();
                return;
            }
        }
    }
}
