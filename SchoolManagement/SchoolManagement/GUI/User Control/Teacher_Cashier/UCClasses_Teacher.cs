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
	public partial class UCClasses_Teacher : UserControl
	{
		private User user;
		public UCClasses_Teacher(User user)
		{
			InitializeComponent();
			this.user = user;
			LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
		}

		private void LoadData(List<Class> classes)
		{
			try
			{

				lbTotaClasses.Text = classes.ToList().Count.ToString();

				gridviewSupplier.Rows.Clear();
				foreach (Class c in classes)
				{
					int total = 0;
					foreach (var p in DataProvider.SchoolManagement.Students)
					{
						if (p.Class.ClassID == c.ClassID)
						{
							total++;
						}
					}

					gridviewSupplier.Rows.Add(c.ClassName, total);
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btnAddClass_Click(object sender, EventArgs e)
		{
			try
			{
				AddNewClass addNewClass = new AddNewClass();
				addNewClass.ShowDialog();
				LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
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
					var editClass = new AddNewClass(int.Parse(gridviewSupplier.Rows[idx].Cells["ClassId"].Value.ToString()));
					editClass.ShowDialog();
					LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void txtSearchClass_TextChanged(object sender, EventArgs e)
		{
			try
			{

				var list = new List<Class>();
				foreach (var p in DataProvider.SchoolManagement.Classes.ToList())
				{
					if (p.ClassName.ToLower().Contains(txtSearchClass.Text.ToLower()))
					{
						list.Add(p);
					}
				}
				LoadData(list);
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void viewAllButton_Click(object sender, EventArgs e)
		{
			Form viewAllExams = new View_All_Exams();
			viewAllExams.Show();
		}
	}
}
