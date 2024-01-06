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
	public partial class UCStudent_Teacher : UserControl
	{
		public UCStudent_Teacher()
		{
			InitializeComponent();

			loadData(DataProvider.SchoolManagement.Students.ToList());
		}

		private void loadData(List<Student> students)
		{
			try
			{

				lbTotalStudents.Text = students.Count.ToString();

				gridviewSupplier.Rows.Clear();

				foreach (var p in students)
				{
					var part = p.Information.DateOfBirth.ToString().Split(' ');
					gridviewSupplier.Rows.Add(p.StudentID, p.FulName, p.Information.Gender, part[0], p.Class.ClassName, p.Class.User.FulName);
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}



		private void gridviewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			int idx = e.RowIndex;
			if (idx < 0) return;
			else
			{
				var editStudent = new StudentInformation(int.Parse(gridviewSupplier.Rows[idx].Cells["Student_ID"].Value.ToString()));
				editStudent.ShowDialog();
				loadData(DataProvider.SchoolManagement.Students.ToList());
			}
		}

		private void txtSearchStudent_TextChanged(object sender, EventArgs e)
		{
			var list = new List<Student>();

			foreach (var p in DataProvider.SchoolManagement.Students.ToList())
			{
				if (p.FulName.Contains(txtSearchStudent.Text))
				{
					list.Add(p);
				}
			}

			loadData(list);
		}

		private void btnAddStudent_Click_1(object sender, EventArgs e)
		{
			AddNewStudent studentInformation = new AddNewStudent();
			studentInformation.ShowDialog();
			loadData(DataProvider.SchoolManagement.Students.ToList());
		}
	}
}
