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
		public UCFeeInfo_Cashier_Update(int s)
		{
			try
			{

				InitializeComponent();
				this.student = DataProvider.SchoolManagement.Students.Find(s);
				lbStudentName.Text = student.FulName;

				loadData(DataProvider.SchoolManagement.Tuitions.ToList());
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void loadData(List<Tuition> tuitions)
		{
			try
			{
				gridviewClass.Rows.Clear();
				int num = 0;
				foreach (var p in tuitions)
				{
					gridviewClass.Rows.Add(++num, p.TuitionOfMonth.ToString(), p.Fee.Value.ToString(), p.CashierID.ToString(), p.StatusTuition.ToString());
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			loadData(DataProvider.SchoolManagement.Tuitions.ToList());
		}
	}
}
