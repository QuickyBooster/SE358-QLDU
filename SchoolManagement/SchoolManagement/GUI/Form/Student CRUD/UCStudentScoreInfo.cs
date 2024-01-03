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
    public partial class UCStudentScoreInfo : UserControl
    {
        private Student student;
        public UCStudentScoreInfo(Student student)
        {
            InitializeComponent();
            this.student = student;

            lbStudentName.Text = student.FulName + " points by subject";

            foreach(var p in DataProvider.SchoolManagement.Subjects.ToList())
            {
                comboSemester.Items.Add(p.SubjectName);
            }

            lbAVGPoint.Text = "";
            btnSearch.Visible = false;
            btnEdit.Visible = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void comboSemester_SelectedValueChanged(object sender, EventArgs e)
        {
            double SumPoint = 0.0;
            double AVGPoint = 0.0;
            int amountOfExams = 0;

            gridviewClass.Rows.Clear();

            var subject = (from s in DataProvider.SchoolManagement.Subjects.ToList() where s.SubjectName.Equals(comboSemester.SelectedItem.ToString()) select s).FirstOrDefault();

            foreach(var s in DataProvider.SchoolManagement.Scores.ToList())
            {
                if (s.Exam.Subject.SubjectID == subject.SubjectID && s.Student.StudentID == student.StudentID)
                {
                    string type = s.Exam.TypeExam;

                    if (type.Contains("15"))
                    {
                        type = 15 + " mins";
                        amountOfExams++;
                        SumPoint = (SumPoint * 1.00) + (double)s.ScoreOfExam;
                    }
                    else if (type.Contains("45"))
                    {
                        type = 45 + "mins";
                        amountOfExams++;
                        amountOfExams++;
                        SumPoint = (SumPoint * 1.00) + (double)s.ScoreOfExam + (double)s.ScoreOfExam;
                    }
                    else
                    {
                        type = "Final semester";
                        amountOfExams++;
                        amountOfExams++;
                        amountOfExams++;
                        SumPoint = (SumPoint * 1.00) + (double)s.ScoreOfExam + (double)s.ScoreOfExam + (double)s.ScoreOfExam;
                    }

                    gridviewClass.Rows.Add(s.Exam.ExamID, subject.SubjectName, type, s.ScoreOfExam);

                }
            }

            if (SumPoint != 0)
            {
                AVGPoint = SumPoint / amountOfExams;
                lbAVGPoint.Text = AVGPoint.ToString();
            }
        }
    }
}
