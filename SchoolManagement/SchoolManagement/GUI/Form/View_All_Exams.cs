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
			loadData();
		}
		private void loadData()
		{
			try
			{
				var exams = DataProvider.SchoolManagement.Exams.ToList();
				lbTotalStudents.Text = DataProvider.SchoolManagement.Students.ToList().Count.ToString();

				gridviewSupplier.Rows.Clear();
				int num = 0;
				foreach (var p in exams)
				{
					gridviewSupplier.Rows.Add(++num, p.Document.FilePath);
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btnAddStudent_Click(object sender, EventArgs e)
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
	}
}
