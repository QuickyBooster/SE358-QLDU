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
using System.Xml.Linq;

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


					var scores = DataProvider.SchoolManagement.Scores.ToList();
					var exams = DataProvider.SchoolManagement.Exams.ToList();
					var examList = exams.FindAll(a => a.SubjectID == subject.SubjectID);
					var exam15 = examList.FindAll(a => a.TypeExam.Equals("Exam 15min"));
					var exam45 = examList.FindAll(a => a.TypeExam.Equals("Exam 45min"));
					var efinal = examList.FindAll(a => a.TypeExam.Equals("Exam Semester"));
					string p15 = "", p45 = "", pfinal = "";

					if (exam15.Count > 0)
					{
						p15 = scores.FindAll(a => a.ExamID == exam15.Last().ExamID).Last().ScoreOfExam.ToString();
						SumPoint += double.Parse(p15);
						Console.WriteLine(SumPoint);
						amountOfExams +=1;
					}

					if (exam45.Count > 0)
					{
						p45 = scores.FindAll(a => a.ExamID == exam45.Last().ExamID).Last().ScoreOfExam.ToString();
						SumPoint+= (double.Parse(p45)*2);
						Console.WriteLine(SumPoint);
						amountOfExams +=2;
					}

					if (efinal.Count > 0)
					{
						pfinal = scores.FindAll(a => a.ExamID == efinal.Last().ExamID).Last().ScoreOfExam.ToString();
						SumPoint+=(double.Parse(pfinal)*3);
						Console.WriteLine(SumPoint);
						amountOfExams +=3;
					}

					if (SumPoint != 0)
					{
						AVGPoint = SumPoint / amountOfExams;
						//lbAVGPoint.Text = AVGPoint.ToString();
					}

					gridviewClass.Rows.Add(subject.SubjectName, p15, p45, pfinal, Math.Round(AVGPoint, 2));
				} else // All
				{
					double AVGPoint = 0.0;
					int amountOfSubject = 0;

					foreach (var sub in DataProvider.SchoolManagement.Subjects)
					{
						double SumPoint = 0.0;
						double AVGPointOfSubject = 0.0;
						int amountOfExams = 0;

						var scores = DataProvider.SchoolManagement.Scores.ToList();
						var exams = DataProvider.SchoolManagement.Exams.ToList();
						var examList = exams.FindAll(a => a.SubjectID == sub.SubjectID);
						var exam15 = examList.FindAll(a => a.TypeExam.Equals("Exam 15min"));
						var exam45 = examList.FindAll(a => a.TypeExam.Equals("Exam 45min"));
						var efinal = examList.FindAll(a => a.TypeExam.Equals("Exam Semester"));
						string p15 = "", p45 = "", pfinal = "";

						if (exam15.Count > 0)
						{
							p15 = scores.FindAll(a => a.ExamID == exam15.Last().ExamID).Last().ScoreOfExam.ToString();
							SumPoint += double.Parse(p15);
							Console.WriteLine(SumPoint);
							amountOfExams +=1;
						}

						if (exam45.Count > 0)
						{
							p45 = scores.FindAll(a => a.ExamID == exam45.Last().ExamID).Last().ScoreOfExam.ToString();
							SumPoint+= (double.Parse(p45)*2);
							Console.WriteLine(SumPoint);
							amountOfExams +=2;
						}

						if (efinal.Count > 0)
						{
							pfinal = scores.FindAll(a => a.ExamID == efinal.Last().ExamID).Last().ScoreOfExam.ToString();
							SumPoint+=(double.Parse(pfinal)*3);
							Console.WriteLine(SumPoint);
							amountOfExams +=3;
						}

						if (SumPoint != 0)
						{
							AVGPointOfSubject = SumPoint / amountOfExams;
							//lbAVGPoint.Text = AVGPoint.ToString();
						}

						gridviewClass.Rows.Add(sub.SubjectName, p15, p45, pfinal, Math.Round(AVGPointOfSubject, 2));

						if (SumPoint != 0)
						{
							AVGPoint += AVGPointOfSubject;
							amountOfSubject++;
						}
					}

					if (AVGPoint != 0)
					{
						AVGPoint = (AVGPoint * 1.00) / amountOfSubject;
						lbAVGPoint.Text = Math.Round(AVGPoint, 2).ToString();
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
