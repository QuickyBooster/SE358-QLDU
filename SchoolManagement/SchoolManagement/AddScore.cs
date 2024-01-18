using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
			LoadData();
		}

		private void LoadData()
		{
			comboSemester.Items.Clear();

			foreach (var p in DataProvider.SchoolManagement.Subjects.ToList())
			{
				comboSemester.Items.Add(p.SubjectName);
			}
		}


		private void AddScore_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'sE358_SchoolManagementDataSet.Subjects' table. You can move, or remove it, as needed.
			this.subjectsTableAdapter.Fill(this.sE358_SchoolManagementDataSet.Subjects);

		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			var subjects = DataProvider.SchoolManagement.Subjects.ToList();
			var subject = subjects.Find(a => a.SubjectName == comboSemester.Text);
			try
			{

				Console.WriteLine(subject);
				if (txtSubName.Text!= "")
				{
					var exam15 = new Exam();
					exam15.SubjectID = student.InfoID;
					exam15.SubjectID = subject.SubjectID;
					exam15.Subject = subject;
					exam15.Class = student.Class;
					exam15.ClassID = student.ClassID;
					exam15.TypeExam = "Exam 15min";
					exam15.SubmitTime = DateTime.Now;
					DataProvider.SchoolManagement.Exams.Add(exam15);
					int i = DataProvider.SchoolManagement.SaveChanges();

					if (i > 0)
					{
						var score = new Score();
						score.Student = student;
						score.StudentID = student.InfoID;
						score.ScoreOfExam = int.Parse(txtSubName.Text);
						score.ExamID = exam15.ExamID;
						score.Exam = exam15;
						DataProvider.SchoolManagement.Scores.Add(score);
						int y = DataProvider.SchoolManagement.SaveChanges();
						if (y>0)
						{
							Console.WriteLine("Added 15");

						}
					}
				}
				if (guna2TextBox1.Text!= "")
				{
					var exam45 = new Exam();
					exam45.SubjectID = student.InfoID;
					exam45.SubjectID = subject.SubjectID;
					exam45.Subject = subject;
					exam45.Class = student.Class;
					exam45.ClassID = student.ClassID;
					exam45.TypeExam = "Exam 45min";
					exam45.SubmitTime = DateTime.Now;
					DataProvider.SchoolManagement.Exams.Add(exam45);
					int i = DataProvider.SchoolManagement.SaveChanges();

					if (i > 0)
					{
						var score = new Score();
						score.Student = student;
						score.StudentID = student.InfoID;
						score.ScoreOfExam = int.Parse(guna2TextBox1.Text);
						score.ExamID = exam45.ExamID;
						score.Exam = exam45;
						DataProvider.SchoolManagement.Scores.Add(score);
						int y = DataProvider.SchoolManagement.SaveChanges();
						if (y>0)
						{
							Console.WriteLine("Added 45");
						}
					}
				}
				if (guna2TextBox2.Text!= "")
				{
					var final = new Exam();
					final.SubjectID = student.InfoID;
					final.SubjectID = subject.SubjectID;
					final.Subject = subject;
					final.Class = student.Class;
					final.ClassID = student.ClassID;
					final.TypeExam = "Exam Semester";
					final.SubmitTime = DateTime.Now;
					DataProvider.SchoolManagement.Exams.Add(final);
					int i = DataProvider.SchoolManagement.SaveChanges();

					if (i > 0)
					{
						var score = new Score();
						score.Student = student;
						score.StudentID = student.InfoID;
						score.ScoreOfExam = int.Parse(guna2TextBox2.Text);
						score.ExamID = final.ExamID;
						score.Exam = final;
						DataProvider.SchoolManagement.Scores.Add(score);
						int y = DataProvider.SchoolManagement.SaveChanges();
						if (y>0)
						{
							Console.WriteLine("Added Final");
						}
					}
					MessageBox.Show("Done!\nPlease check again");
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{

		}

		private void comboSemester_TextChanged(object sender, EventArgs e)
		{
			try
			{

				txtSubName.Text = "";
				guna2TextBox1.Text = "";
				guna2TextBox2.Text = "";
				var subjects = DataProvider.SchoolManagement.Subjects.ToList();
				var subject = subjects.Find(a => a.SubjectName == comboSemester.Text);
				var exams = DataProvider.SchoolManagement.Exams.ToList();
				var examList = exams.FindAll(a => a.SubjectID == subject.SubjectID);
				Console.WriteLine(161);
				if (examList.Count!=0)
				{

					var exam15 = examList.FindAll(a => a.TypeExam.Equals("Exam 15min"));
					if (exam15.Count!=0)
						txtSubName.Text = DataProvider.SchoolManagement.Scores.ToList().FindAll(a => a.ExamID == exam15.Last().ExamID).Last().ScoreOfExam.ToString();


					var exam45 = examList.FindAll(a => a.TypeExam.Equals("Exam 45min"));
					if (exam45.Count!=0)
						guna2TextBox1.Text = DataProvider.SchoolManagement.Scores.ToList().FindAll(a => a.ExamID == exam45.Last().ExamID).Last().ScoreOfExam.ToString();


					var final = examList.FindAll(a => a.TypeExam.Equals("Exam Semester"));
					if (final.Count!=0)
						guna2TextBox2.Text = DataProvider.SchoolManagement.Scores.ToList().FindAll(a => a.ExamID == final.Last().ExamID).Last().ScoreOfExam.ToString();
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
