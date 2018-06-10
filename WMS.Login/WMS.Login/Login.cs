using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMS.Value;

namespace WMS.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.But_login.Click += new EventHandler(UserLogin);
            this.But_cancel.Click += new EventHandler(UserCancel);
        }

        public void UserLogin(object sender,EventArgs e)
        {
            if(this.U)
            {
                
            }

        }

        public void UserCancel(object sender,EventArgs e)
        {
            this.Close();
        }
    }
}
