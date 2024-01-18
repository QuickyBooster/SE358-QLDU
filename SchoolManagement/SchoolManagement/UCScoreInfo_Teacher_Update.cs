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
    public partial class UCScoreInfo_Teacher_Update : UserControl
    {
		private Student student;
		public UCScoreInfo_Teacher_Update(Student student)
		{
			InitializeComponent();
			this.student = student;

			lbStudentName.Text = student.FulName;

			comboSemester.Items.Add("All");
			foreach (var p in DataProvider.SchoolManagement.Subjects.ToList())
			{
				comboSemester.Items.Add(p.SubjectName);
			}

			lbAVGPoint.Text = "";
			btnSearch.Visible = false;
			btnEdit.Visible = true;

		}

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}

		private void comboSemester_SelectedValueChanged(object sender, EventArgs e)
		{
			try
			{
				gridviewClass.Rows.Clear();

				if (!comboSemester.SelectedItem.ToString().Equals("All"))
				{
					double SumPoint = 0.0;
					double AVGPoint = 0.0;
					int amountOfExams = 0;

					var subject = (from s in DataProvider.SchoolManagement.Subjects.ToList() where s.SubjectName.Equals(comboSemester.SelectedItem.ToString()) select s).FirstOrDefault();

					foreach (var s in DataProvider.SchoolManagement.Scores.ToList())
					{
						if (s.Exam.Subject.SubjectID == subject.SubjectID && s.Student.StudentID == student.StudentID)
						{
							string type = s.Exam.TypeExam;

							if (type.Contains("15"))
							{
								type = 15 + " mins";
								amountOfExams++;
								SumPoint = (SumPoint * 1.00) + (double)s.ScoreOfExam;
							} else if (type.Contains("45"))
							{
								type = 45 + "mins";
								amountOfExams++;
								amountOfExams++;
								SumPoint = (SumPoint * 1.00) + (double)s.ScoreOfExam + (double)s.ScoreOfExam;
							} else
							{
								type = "Final semester";
								amountOfExams++;
								amountOfExams++;
								amountOfExams++;
								SumPoint = (SumPoint * 1.00) + (double)s.ScoreOfExam + (double)s.ScoreOfExam + (double)s.ScoreOfExam;
							}

							gridviewClass.Rows.Add(subject.SubjectName, type, s.ScoreOfExam);

						}
					}

					if (SumPoint != 0)
					{
						AVGPoint = SumPoint / amountOfExams;
						lbAVGPoint.Text = AVGPoint.ToString();
					}
				} else // All
				{
					double AVGPoint = 0.0;
					int amountOfSubject = 0;

					foreach (var sub in DataProvider.SchoolManagement.Subjects)
					{
						double SumPoint = 0.0;
						double AVGPointOfSubject = 0.0;
						int amountOfExams = 0;

						foreach (var p in DataProvider.SchoolManagement.Scores)
						{
							if (p.Exam.Subject.SubjectID == sub.SubjectID && p.Student.StudentID == student.StudentID)
							{
								if (p.Exam.TypeExam.Contains("15"))
								{
									amountOfExams++;
									SumPoint = (SumPoint * 1.00) + (double)p.ScoreOfExam;
								} else if (p.Exam.TypeExam.Contains("45"))
								{
									amountOfExams += 2;
									SumPoint = (SumPoint * 1.00) + (double)p.ScoreOfExam + (double)p.ScoreOfExam;
								} else
								{
									amountOfExams += 3;
									SumPoint = (SumPoint * 1.00) + (double)p.ScoreOfExam + (double)p.ScoreOfExam + (double)p.ScoreOfExam;
								}
							}
						}

						if (SumPoint != 0)
						{
							AVGPointOfSubject = SumPoint / amountOfExams;
							AVGPoint = (AVGPoint * 1.00) + AVGPointOfSubject;
							amountOfSubject++;
							gridviewClass.Rows.Add(sub.SubjectName, "Average point", AVGPointOfSubject);
						}
					}

					if (AVGPoint != 0)
					{
						AVGPoint = (AVGPoint * 1.00) / amountOfSubject;
						lbAVGPoint.Text = AVGPoint.ToString();
					}
				}
			} catch (Exception ex)
			{
				MessageBox.Show("Maybe teacher is entering points for this student, please go back later");
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			var addScore = new AddScore(student);
			addScore.ShowDialog();
		}
	}
}
