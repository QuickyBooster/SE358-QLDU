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
    public partial class StudentInformation_Teacher_Update : Form
    {
        private Student student;
        public StudentInformation_Teacher_Update()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCPersonalInfo_Teacher_Update uc = new UCPersonalInfo_Teacher_Update();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCParentsInfo_Teacher_Update uc = new UCParentsInfo_Teacher_Update();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }
        private void btnScores_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCScoreInfo_Teacher_Update uc = new UCScoreInfo_Teacher_Update();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }

        private void btnTuiitionfee_Click(object sender, EventArgs e)
        {
            student = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            UCFeeInfo_Teacher_Update uc = new UCFeeInfo_Teacher_Update();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }
        private void btn_ChangeAvatar_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

    }
}
