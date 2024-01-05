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
		public GetEmailCode()
		{
			InitializeComponent();
		}
		public GetEmailCode(int code)
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

				}
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
