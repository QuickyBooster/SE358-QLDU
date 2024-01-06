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
    public partial class UCStudentTuitionFees : UserControl
    {
        private Student student;
        public UCStudentTuitionFees(Student student)
        {
            InitializeComponent();

            this.student = student;
            lbStudentName.Text = student.FulName;

            LoadData();
        }

        private void LoadData()
        {
            gridviewClass.Rows.Clear();

            foreach(var p in DataProvider.SchoolManagement.Tuitions)
            {
                if (p.Student.StudentID == student.StudentID)
                {
                    gridviewClass.Rows.Add(p.TuitionOfMonth, p.Fee, p.User.FulName, p.StatusTuition);
                }
            }
        }
    }
}
