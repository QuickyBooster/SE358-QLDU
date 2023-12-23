using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Login : Form
    {
		public Login()
		{
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
            var user = (from p in Data.DataProvider.SchoolManagement.Users.AsNoTracking().ToList() where p.Username.Equals(txtUsername.Text) && p.Password.Equals(txtPass.Text) select p).FirstOrDefault();

            if (user != null && user.RoleID == 1)
            {
                var homePrincipal = new HomePrincipal(user);
                this.Hide();
				homePrincipal.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}
	}
}
