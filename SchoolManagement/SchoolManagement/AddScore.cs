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
	public partial class AddScore : Form
	{
		private Student student;
		public AddScore(Student s)
		{
			InitializeComponent();
			student = s;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void AddScore_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sE358_SchoolManagementDataSet.Subjects' table. You can move, or remove it, as needed.
			this.subjectsTableAdapter.Fill(this.sE358_SchoolManagementDataSet.Subjects);

		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			//var subject = DataProvider.SchoolManagement.Subjects.Find(comboSemester.Text);

			//Console.WriteLine(subject);
			//if (txtSubName.Text!= null)
			//{
			//	var exam15 = new Exam();
			//	exam15.SubjectID = student.InfoID;
			//	exam15.SubjectID = subject.SubjectID;
			//	exam15.Subject = subject;
			//	exam15.Class = student.Class;
			//	exam15.ClassID = student.ClassID;
			//	exam15.TypeExam = "Exam 15min";
			//	exam15.SubmitTime = DateTime.Now;
			//	DataProvider.SchoolManagement.Exams.Add(exam15);
			//	int i = DataProvider.SchoolManagement.SaveChanges();

			//	if (i > 0)
			//	{
   //                 Console.WriteLine(55);
   //                 Console.WriteLine(exam15.ExamID);
   //                 var exam = DataProvider.SchoolManagement.Exams.Find( exam15.SubmitTime);
			//		var score = new Score();
			//		score.Student = student;
			//		score.StudentID = student.InfoID;
			//		score.ScoreOfExam = int.Parse(txtSubName.Text);
			//		score.ExamID = exam.ExamID;
			//		score.Exam = exam;
			//		DataProvider.SchoolManagement.Scores.Add(score);
			//		int y = DataProvider.SchoolManagement.SaveChanges();
			//		if (y>0)
			//		{
			//			MessageBox.Show("Success");
			//		} else
			//			MessageBox.Show("Add Score failed", "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	} else
			//	{
			//		MessageBox.Show("Add Score failed", "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
			//if (guna2TextBox1.Text!= null)
			//{
			//	var exam45 = new Exam();
			//	exam45.SubjectID = student.InfoID;
			//	exam45.SubjectID = subject.SubjectID;
			//	exam45.Subject = subject;
			//	exam45.Class = student.Class;
			//	exam45.ClassID = student.ClassID;
			//	exam45.TypeExam = "Exam 45min";
			//	exam45.SubmitTime = DateTime.Now;
			//	DataProvider.SchoolManagement.Exams.Add(exam45);
			//	int i = DataProvider.SchoolManagement.SaveChanges();

			//	if (i > 0)
			//	{
			//		var exam = DataProvider.SchoolManagement.Exams.Find(exam45.SubmitTime);
			//		var score = new Score();
			//		score.Student = student;
			//		score.StudentID = student.InfoID;
			//		score.ScoreOfExam = int.Parse(txtSubName.Text);
			//		score.ExamID = exam.ExamID;
			//		score.Exam = exam;
			//		DataProvider.SchoolManagement.Scores.Add(score);
			//		int y = DataProvider.SchoolManagement.SaveChanges();
			//		if (y>0)
			//		{
			//			MessageBox.Show("Success");
			//		} else
			//			MessageBox.Show("Add Score failed", "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	} else
			//	{
			//		MessageBox.Show("Add Score failed", "Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//	}
			//}
		}
	}
}
