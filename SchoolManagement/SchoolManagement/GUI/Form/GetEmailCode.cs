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
	public partial class GetEmailCode : Form
	{
		private int code;
		private User user;
		public GetEmailCode()
		{
			InitializeComponent();
		}
		public GetEmailCode(User user, int code)
		{
			InitializeComponent();
			this.code = code;
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtEmailCode.Text.Equals(code.ToString()))
				{
					var changePass = new ChangePassword(user);
					changePass.Show();
					this.Hide();
				} else
				{
					MessageBox.Show("Wrong Code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
