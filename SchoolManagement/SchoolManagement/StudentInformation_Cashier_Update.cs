using Guna.UI2.WinForms;
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
	public partial class StudentInformation_Cashier_Update : Form
	{
		private Student student;
		public StudentInformation_Cashier_Update(int s)
		{
			try
			{
                InitializeComponent();
				this.student = DataProvider.SchoolManagement.Students.Find(s);
				lbEventName.Text = student.FulName;
				lbStudentID.Text = student.StudentID.ToString();
				if (student.Information.Image != null)
				{
					string path = Application.StartupPath;
					path = path.Replace("\\bin\\Debug", "");
                    Console.WriteLine(path + student.Information.Image);
                    picAvatar.Image = new System.Drawing.Bitmap(path + "\\Resources\\"+ student.Information.Image);
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btnTuiitionfee_Click(object sender, EventArgs e)
		{
			UCFeeInfo_Cashier_Update uc = new UCFeeInfo_Cashier_Update(student);
			uc.Dock = DockStyle.Fill;
			this.panelDisplay.Controls.Clear();
			this.panelDisplay.Controls.Add(uc);
		}

	}
}
