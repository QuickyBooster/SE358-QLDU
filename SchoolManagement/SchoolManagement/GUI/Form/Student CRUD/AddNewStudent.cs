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
    public partial class AddNewStudent : Form
    {
        private Student student;
        private Information information;

        private string sourPath;
        private string desPath;


        public AddNewStudent()
        {
            InitializeComponent();

            student = new Student();
            information = new Information();
            label2.Text = "";
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            label2.Text = "Personal information";
            ucAddStudentInfo = new UCAddStudentInfo(student, information, this);
            ucAddStudentInfo.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(ucAddStudentInfo);
        }

        public void btnParents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill student information before", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisplayParentInformation()
        {
            label2.Text = "Parents information";
            ucAddParentsInfo = new UCAddParentsInfo(student, information, this);
            ucAddParentsInfo.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(ucAddParentsInfo);
        }

        public void HideThisForm()
        {
            this.Hide();
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

        private void btn_AddAvatar_Click(object sender, EventArgs e)
        {
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

                information.Image = fileName;

                sourPath = selectedFilePath;
                desPath = destinationPath;

            }
        }

        public void SaveImageAfterAddedSuccessfully()
        {
            CopyFile(sourPath, desPath);
        }

        
    }
    

}
