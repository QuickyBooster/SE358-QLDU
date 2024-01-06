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
    public partial class StudentInformation : Form
    {
        private Student student;
        private string sourPath;
        private string desPath;
        public StudentInformation(int studentID)
        {
            InitializeComponent();

            this.student = DataProvider.SchoolManagement.Students.Find(studentID);

            lbEventName.Text = student.FulName;
            lbStudentID.Text = student.StudentID.ToString();

            string path = Application.StartupPath.Replace("\\bin\\Debug", "") + "\\Resources\\" + student.Information.Image;
            picAvatar.Image = new System.Drawing.Bitmap(path);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCAddStudentInfo uc = new UCAddStudentInfo(student);
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCAddParentsInfo uc = new UCAddParentsInfo(student);
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            uCStudentScoreInfo = new UCStudentScoreInfo(student);
            uCStudentScoreInfo.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uCStudentScoreInfo);
        }

        private void btnTuiitionfee_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCStudentTuitionFees uc = new UCStudentTuitionFees(student);
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
