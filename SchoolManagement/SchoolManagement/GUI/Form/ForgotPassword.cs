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
	public partial class ForgotPassword : Form
	{
		public ForgotPassword()
		{
			InitializeComponent();
		}

		private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var login = new Login();
			this.Hide();
			login.Show();
		}

		private void btn_sendcode_Click(object sender, EventArgs e)
		{
			try
			{
				var username = txtUsername.Text.Replace(" ", "");
				if (username!="")
				{
					var user = (from p in DataProvider.SchoolManagement.Users.AsNoTracking().ToList()
								where p.Username.Equals(username)
								select p)
								.FirstOrDefault();
					if (user!=null)
					{
						if (user.Email!=null)
						{
							//send email
							//chuyen qua man hinh email
							var getEmail = new GetEmailCode();
							this.Hide();
							getEmail.Show();
						} else
						{
							MessageBox.Show("This account does not contain email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					}
				} else
				{
					MessageBox.Show("Please fill your username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception ex)
			{
				MessageBox.Show("Data connection error!\nTry again later!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
