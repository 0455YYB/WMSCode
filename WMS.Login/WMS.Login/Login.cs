using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.Value;
using System.Data.SQLite;

namespace WMS.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.But_login.Click += new EventHandler(UserLogin);
            this.But_cancel.Click += new EventHandler(UserCancel);
            string[] user = new string[2];
            user = OperateData.OperXML.GetUserInfo();
            Tex_name.Text = user[0];
            Tex_password.Text = user[1];
        }

        public void UserLogin(object sender,EventArgs e)
        {
            if(this.Tex_name.Text==null)
            {
                MessageBox.Show("请输入用户名密码");
                return;
            }
            else
            {
                string userName = Tex_name.Text.Trim();
                string password = Tex_password.Text.Trim();
                if(passWord==null)
                {
                    MessageBox.Show("请输入密码");
                }
                else
                {
                    SQLiteDataReader userInfo = OperateData.ExecutSQL.GetUserInfo(userName);
                    if (userInfo.Read() && userInfo["password"] == password)
                    {
                        //主窗体跳转，并且记住密码
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请输入正确密码");
                    }
                }

            }

        }

        public void UserCancel(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
