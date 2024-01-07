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
    public partial class StudentInformation_Teacher : Form
    {
        private Student student;
        public StudentInformation_Teacher()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCAddStudentInfo uc = new UCAddStudentInfo(student);
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }
    }
}
