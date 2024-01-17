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
	public partial class StudentInformation_Teacher_Update : Form
	{
		private Student student;
		public StudentInformation_Teacher_Update(int s)
		{
			try
			{
				InitializeComponent();
				this.student = DataProvider.SchoolManagement.Students.Find(s);
				lbEventName.Text = student.FulName;
				lbStudentID.Text = student.StudentID.ToString();
				if (student.Information.Image != null)
				{
					string path = Application.StartupPath;
					path = path.Replace("\\bin\\Debug", "");
					picAvatar.Image = new System.Drawing.Bitmap(path + student.Information.Image);
				}
			} catch (Exception e) { Console.WriteLine(e.Message); }
		}

		private void btnPersonal_Click(object sender, EventArgs e)
		{
			student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			UCPersonalInfo_Teacher_Update uc = new UCPersonalInfo_Teacher_Update(student);
			uc.Dock = DockStyle.Fill;
			this.panelDisplay.Controls.Clear();
			this.panelDisplay.Controls.Add(uc);
			//student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			//UCAddStudentInfo uc = new UCAddStudentInfo(student);
			//uc.Dock = DockStyle.Fill;
			//this.panelDisplay.Controls.Clear();
			//this.panelDisplay.Controls.Add(uc);
		}
		

		// waiting for Linh to fix
		private void btnParents_Click(object sender, EventArgs e)
		{
			//student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			//UCParentsInfo_Teacher_Update uc = new UCParentsInfo_Teacher_Update();
			//uc.Dock = DockStyle.Fill;
			//this.panelDisplay.Controls.Clear();
			//this.panelDisplay.Controls.Add(uc);
			student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			UCAddParentsInfo uc = new UCAddParentsInfo(student);
			uc.Dock = DockStyle.Fill;
			this.panelDisplay.Controls.Clear();
			this.panelDisplay.Controls.Add(uc);
		}

		private void btnScores_Click(object sender, EventArgs e)
		{
			student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			UCScoreInfo_Teacher_Update uc = new UCScoreInfo_Teacher_Update(student);
			uc.Dock = DockStyle.Fill;
			this.panelDisplay.Controls.Clear();
			this.panelDisplay.Controls.Add(uc);
			//var uCStudentScoreInfo = new UCStudentScoreInfo(student);
			//uCStudentScoreInfo.Dock = DockStyle.Fill;
			//this.panelDisplay.Controls.Clear();
			//this.panelDisplay.Controls.Add(uCStudentScoreInfo);
		}

		private void btnTuiitionfee_Click(object sender, EventArgs e)
		{
			//student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			//UCFeeInfo_Teacher_Update uc = new UCFeeInfo_Teacher_Update();
			//uc.Dock = DockStyle.Fill;
			//this.panelDisplay.Controls.Clear();
			//this.panelDisplay.Controls.Add(uc);
			student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
			UCStudentTuitionFees uc = new UCStudentTuitionFees(student);
			uc.Dock = DockStyle.Fill;
			this.panelDisplay.Controls.Clear();
			this.panelDisplay.Controls.Add(uc);
		}
		private void btn_ChangeAvatar_Click(object sender, EventArgs e)
		{
			student = DataProvider.SchoolManagement.Students.Find(student.StudentID);

			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All files|*.*";

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
				picAvatar.Image = new System.Drawing.Bitmap(selectedFilePath);

				string path = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\" + student.Information.Image;

				deleteFile(path);

				CopyFile(selectedFilePath, destinationPath);

				student.Information.Image = fileName;

				int i = DataProvider.SchoolManagement.SaveChanges();

			}
		}
		private static void CopyFile(string source, string path)
		{
			try
			{
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
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
				File.Delete(path);
			} catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
		private void btnDel_Click(object sender, EventArgs e)
		{
			var existingStudent = DataProvider.SchoolManagement.Students.Find(student.StudentID);

			string path = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\" + existingStudent.Information.Image;

			DataProvider.SchoolManagement.Information.Remove(existingStudent.Information);

			DataProvider.SchoolManagement.Students.Remove(existingStudent);

			int i = DataProvider.SchoolManagement.SaveChanges();

			if (i > 1)
			{
				MessageBox.Show("Deleted successfully", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
				deleteFile(path);
				this.Hide();
			} else
			{
				MessageBox.Show("Deleted failed", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

	}
}
