using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
	public partial class UCTuition_Cashier : UserControl
	{
		public UCTuition_Cashier()
		{
			InitializeComponent();
			loadData(DataProvider.SchoolManagement.Students.ToList());
		}
		private void loadData(List<Student> list)
		{
			try
			{
				var studentList = list;
				lbTotalStudents.Text = studentList.Count.ToString();

				gridviewSupplier.Rows.Clear();
                foreach (var p in studentList)
				{
					var dob = p.Information.DateOfBirth.ToString().Split(' ');
					gridviewSupplier.Rows.Add(p.StudentID, p.FulName, dob[0], p.Class.Grade, p.Class.ClassName, p.Class.TeacherID, /*p.Tuitions.Last().ToString()*/"status?");
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
		private void gridviewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{

				int idx = e.RowIndex;
				if (idx < 0) return;
				else
				{
                    Console.WriteLine(66);
					var id = int.Parse(gridviewSupplier.Rows[idx].Cells["ID"].Value.ToString());
                    Console.WriteLine(id);
                    var editStudent = new StudentInformation_Cashier_Update(id);
                    Console.WriteLine(70);
                    editStudent.ShowDialog();
                    Console.WriteLine( 72);
                    //loadData(DataProvider.SchoolManagement.Students.ToList());
                }
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}
	}
}
