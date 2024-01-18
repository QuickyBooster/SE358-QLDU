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
	public partial class UCFeeInfo_Cashier_Update : UserControl
	{
		private Student student;
		public UCFeeInfo_Cashier_Update(Student student)
		{
			InitializeComponent();

			this.student = student;
			lbStudentName.Text = student.FulName;

			LoadData();
		}

		private void LoadData()
		{
			gridviewClass.Rows.Clear();

			foreach (var p in DataProvider.SchoolManagement.Tuitions)
			{
				if (p.Student.StudentID == student.StudentID)
				{
					gridviewClass.Rows.Add(p.TuitionOfMonth, p.Fee, p.User.FulName, p.StatusTuition);
				}
			}
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadData();	
		}
	}
}
