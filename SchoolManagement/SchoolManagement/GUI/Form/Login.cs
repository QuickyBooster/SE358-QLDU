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
			try
			{
				var username = txtUsername.Text.Replace(" ", "");
				if (username!="" &&   txtPass.Text!="")
				{

					//var users = DataProvider.SchoolManagement.Users.ToList().FirstOrDefault();
					var user = (from p in DataProvider.SchoolManagement.Users.AsNoTracking().ToList()
								where p.Username.Equals(username) && p.Password.Equals(txtPass.Text)
								select p)
								.FirstOrDefault();
					Console.WriteLine(user);
					Console.WriteLine("=========================================");

					if (user!=null)
					{
						switch (user.RoleID)
						{
							case 1:
								var homePrincipal = new HomePrincipal(user);
								this.Hide();
								homePrincipal.Show();
								break;

							case 2:
								var homeTeacher = new HomeTeacher(user);
								this.Hide();
								homeTeacher.Show();
								break;

							case 3:
								var homeCashier = new HomeCashier(user);
								this.Hide();
								homeCashier.Show();
								break;

						}
					} else
					{
						MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				} else
				{
					MessageBox.Show("Please enter both username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception ex)
			{
				MessageBox.Show("Data connection error!\nTry again later!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex.ToString());
			}
		}
		private void txtUsername_TextChanged(object sender, EventArgs e)
		{

		}

		private void txtPass_TextChanged(object sender, EventArgs e)
		{

		}

		private void checkbox_male_Click(object sender, EventArgs e)
		{
			if (checkbox_male.Checked)
				txtPass.PasswordChar='\0';
			else
				txtPass.PasswordChar='*';

		}

		private void link_forgot_pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var forgetPassword = new ForgotPassword();
			this.Hide();
			forgetPassword.Show();
		}
	}
}
