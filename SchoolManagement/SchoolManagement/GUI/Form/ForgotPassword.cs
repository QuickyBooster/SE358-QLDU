using SchoolManagement.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net;
using System.Net.Mail;

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
							var rd = new Random();
							int code = rd.Next(1000, 9999);
							if (SendEmail(user.Email, code))
							//if (SendEmail(user.Email, code))
							{

								MessageBox.Show("Succesfull!\nEmail sent", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
								//chuyen qua man hinh email
								var getEmail = new GetEmailCode(user,code);
								getEmail.Show();
								this.Hide();
							} else
							{
								MessageBox.Show("Error!\nEmail cannot send", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						} else
						{
							MessageBox.Show("This account does not contain email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

					} else
						MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				} else
				{
					MessageBox.Show("Please fill your username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			} catch (Exception ex)
			{
				MessageBox.Show("Data connection error!\nTry again later!", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// need email account
		/// </summary>
		/// <param name="email"></param>
		/// <param name="code"></param>
		/// <returns></returns>
		public bool SendEmail(string email, int code)
		{
			try
			{
				Console.WriteLine("0-----------------");
				var smtpClient = new System.Net.Mail.SmtpClient("smtp.???-vi du nhu gmail.com")
				{
					Port = 587,
					Credentials = new NetworkCredential("username", "password"),
					EnableSsl = true,
				};

				var message = new MailMessage
				{
					From = new MailAddress("user name"),
					Subject = "[Recover acccount-G5]",
					Body = $"This is your code, please enter it in the box: {code}",
					IsBodyHtml = false,
				};

				message.To.Add(email);

				smtpClient.Send(message);
				return true;
			} catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}
	}
}
