using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
	public partial class View_All_Exams : Form
	{
		public View_All_Exams()
		{
			InitializeComponent();
			loadData(DataProvider.SchoolManagement.Exams.ToList());
        }
		private void loadData(List<Exam> list )
		{
			try
			{
				var exams = list;
				lbTotalStudents.Text = exams.Count.ToString();

				gridviewSupplier.Rows.Clear();
				int num = 0;
				foreach (var p in exams)
				{
                    gridviewSupplier.Rows.Add(++num, p.Document.FilePath);
                }
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btnAddExam_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Files|*.docx;*.pdf;*.xlxs|All files|*.*";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string selectedFilePath = openFileDialog.FileName;

				string resourceFolderPath = Path.Combine(Application.StartupPath, "Resources");
				if (!Directory.Exists(resourceFolderPath))
					Directory.CreateDirectory(resourceFolderPath);

				string fileName = Path.GetFileName(selectedFilePath);
				fileName = (DataProvider.SchoolManagement.Information.ToList().Count + 1).ToString() + fileName;
				string destinationPath = Path.Combine(resourceFolderPath, fileName);

				destinationPath = destinationPath.Replace("\\bin\\Debug", "");
			}
		}
		private void txtSearchExam_TextChanged(object sender, EventArgs e)
		{
			try
			{

				var list = new List<Exam>();

				foreach (var p in DataProvider.SchoolManagement.Exams.ToList())
				{
					if (p.Document.FilePath.Contains(txtSearchStudent.Text))
					{
						list.Add(p);
					}
				}

				loadData(list);
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}
	}
}
