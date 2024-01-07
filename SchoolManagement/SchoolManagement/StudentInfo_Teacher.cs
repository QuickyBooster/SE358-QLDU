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

    public partial class StudentInfo_Teacher : Form
    {
        private Student student;
        public StudentInfo_Teacher()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            UCPersonalInfo_Teacher uc = new UCPersonalInfo_Teacher();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            UCParentsInfo_Teacher uc = new UCParentsInfo_Teacher();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            UCScoreInfo_Teacher uc = new UCScoreInfo_Teacher();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnTuiitionfee_Click(object sender, EventArgs e)
        {
            UCFeeInfo_Teacher uc = new UCFeeInfo_Teacher();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private static void deleteFile(string path)
        {
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CopyFile(string source, string path)
        {
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Copy(source, path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
            }
            else
            {
                MessageBox.Show("Deleted failed", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
