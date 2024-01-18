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

					gridviewSupplier.Rows.Add(c.ClassID, c.ClassName, total);
				}
				var docs = DataProvider.SchoolManagement.Documents.AsNoTracking().ToList();
				gridviewArea.Rows.Clear();
				foreach (var doc in docs)
				{
					gridviewArea.Rows.Add(doc.FilePath);
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
				int col = e.ColumnIndex;
				if (col <3)
				{

					if (idx < 0) return;
					else
					{
						var editClass = new AddNewClass(int.Parse(gridviewSupplier.Rows[idx].Cells["ID"].Value.ToString()));
						editClass.ShowDialog();
						LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
					}
				} else if (col ==3)
					return;

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
			LoadData(DataProvider.SchoolManagement.Classes.ToList());
		}

		private void gridviewSupplier_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{

				int idx = e.RowIndex;
				int col = e.ColumnIndex;
				if (col <3)
					return;
				if (col != 5)
				{

					if (idx < 0) return;
					else
					{
						var editClass = new AddNewClass(int.Parse(gridviewSupplier.Rows[idx].Cells["ID"].Value.ToString()));
						editClass.ShowDialog();
						LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
					}
				} else if (col ==5)
				{
					var classed = DataProvider.SchoolManagement.Classes.Find(int.Parse(gridviewSupplier.Rows[idx].Cells["ID"].Value.ToString()));
					if (classed != null)
					{
						DataProvider.SchoolManagement.Classes.Remove(classed);
						int i = DataProvider.SchoolManagement.SaveChanges();
						if (i >= 1)
						{
							MessageBox.Show("Success");
						} else
						{
							MessageBox.Show("Fail");
						}
						LoadData(DataProvider.SchoolManagement.Classes.ToList());
					}

				}


			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}
	}
}
