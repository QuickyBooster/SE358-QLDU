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
			loadData(DataProvider.SchoolManagement.Documents.ToList());
		}
		private void loadData(List<Document> list)
		{
			try
			{
				var document = list;
				lbTotalStudents.Text = document.Count.ToString();

				gridviewSupplier.Rows.Clear();
				int num = 0;
				foreach (var p in document)
				{
					gridviewSupplier.Rows.Add(++num, p.FilePath);
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
				fileName = (DataProvider.SchoolManagement.Documents.ToList().Count + 1).ToString() + fileName;
				string destinationPath = Path.Combine(resourceFolderPath, fileName);

				destinationPath = destinationPath.Replace("\\bin\\Debug", "");

				CopyFile(selectedFilePath, destinationPath);
				var document = new Document();
				document.UploadDate = DateTime.Now;
				document.FilePath = fileName;
				DataProvider.SchoolManagement.Documents.Add(document);
				int i = DataProvider.SchoolManagement.SaveChanges();

				if (i >= 1)
				{
					MessageBox.Show("Success");
				} else
				{
					MessageBox.Show("Already Exists!\nPlease change file's name!");
				}
					loadData(DataProvider.SchoolManagement.Documents.ToList());
			}
		}
		private static void CopyFile(string source, string path)
		{
			try
			{
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				source = source.Replace("\\bin\\Debug", "");
				path = path.Replace("\\bin\\Debug", "");
				File.Copy(source, path);
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		private static void deleteFile(string path)
		{
			try
			{
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				path = path.Replace("\\bin\\Debug", "");
				File.Delete(path);
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		private void txtSearchExam_TextChanged(object sender, EventArgs e)
		{
			try
			{

				var list = new List<Document>();

				foreach (var p in DataProvider.SchoolManagement.Documents.ToList())
				{
					if (p.FilePath.Contains(txtSearchStudent.Text))
					{
						list.Add(p);
					}
				}

				loadData(list);
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void gridviewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (DataProvider.SchoolManagement.Documents.ToList().Count ==0)
					return;
				if (e.ColumnIndex == 2||e.ColumnIndex==3)
				{
					int idx = e.RowIndex;
					var doc = gridviewSupplier.Rows[idx].Cells["File_name"].Value.ToString();
					if (e.ColumnIndex == 2)
					{
						SaveFileDialog saveFileDialog = new SaveFileDialog();
						saveFileDialog.Filter = "Files|*.docx;*.pdf;*.xlsx|All files|*.*";

						// Show the dialog and wait for the user's response
						DialogResult result = saveFileDialog.ShowDialog();

						// If the user clicked the "Save" button
						if (result == DialogResult.OK)
						{
							// Get the chosen file path
							string destinationFilePath = saveFileDialog.FileName;

							MessageBox.Show("File saved and copied successfully!");
							CopyFile(Application.StartupPath+"\\Resources\\"+doc, destinationFilePath);
						}
					} else
					{
						var document = DataProvider.SchoolManagement.Documents.Find(doc);
						if(document != null)
						{
							DataProvider.SchoolManagement.Documents.Remove(document);
                            Console.WriteLine(162);
							deleteFile(Application.StartupPath+"\\Resources\\"+doc);
							int i = DataProvider.SchoolManagement.SaveChanges();
                            if (i >= 1)
							{
								MessageBox.Show("Success");
							} else
							{
								MessageBox.Show("Fail");
							}
							loadData(DataProvider.SchoolManagement.Documents.ToList());
						}
					}
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}
	}
}
