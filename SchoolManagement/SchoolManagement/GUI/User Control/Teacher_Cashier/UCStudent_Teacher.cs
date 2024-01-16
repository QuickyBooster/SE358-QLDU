using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
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
					var dob = p.Information.DateOfBirth.ToString().Split(' ');
					gridviewSupplier.Rows.Add(p.StudentID, p.FulName, dob[0], p.Class.Grade, p.Class.ClassName);
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void gridviewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				int idx = e.RowIndex;
				if (idx < 0) return;
				else
				{
					var editStudent = new StudentInformation_Teacher_Update(
						int.Parse(gridviewSupplier.Rows[idx].Cells["No"].Value.ToString()));
					editStudent.ShowDialog();
					loadData(DataProvider.SchoolManagement.Students.ToList());
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void txtSearchStudent_TextChanged(object sender, EventArgs e)
		{
			try
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
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btnAddStudent_Click_1(object sender, EventArgs e)
		{
			try
			{
				AddNewStudent studentInformation = new AddNewStudent();
				studentInformation.ShowDialog();
				loadData(DataProvider.SchoolManagement.Students.ToList());
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}
	}
}
