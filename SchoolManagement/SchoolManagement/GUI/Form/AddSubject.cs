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
    public partial class AddSubject : Form
    {
        private Subject subject;
        public AddSubject()
        {
            InitializeComponent();

            btn_Delete.Visible = false;
            btn_Update.Visible = false;

            cbb_Teacher.Items.Clear();

            foreach (var p in DataProvider.SchoolManagement.Users.ToList())
            {
                if (p.Role.RoleID == 2)
                {
                    cbb_Teacher.Items.Add(p.FulName);
                }    
            }

            lbSubjectID.Text = (DataProvider.SchoolManagement.Subjects.ToList().Count + 1).ToString();
        }

        public AddSubject(int subjectID)
        {
            InitializeComponent();

            btn_Add.Visible = false;

            cbb_Teacher.Items.Clear();

            foreach (var p in DataProvider.SchoolManagement.Users.ToList())
            {
                if (p.Role.RoleID == 2)
                {
                    cbb_Teacher.Items.Add(p.FulName);
                }
            }

            lbSubjectID.Text = (DataProvider.SchoolManagement.Subjects.ToList().Count + 1).ToString();
            this.subject = DataProvider.SchoolManagement.Subjects.Find(subjectID);

            txtSubName.Text = subject.SubjectName;
            lbSubjectID.Text = subject.SubjectID.ToString();
            cbb_Teacher.SelectedItem = subject.User.FulName;
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSubName.Text))
            {
                MessageBox.Show("Fill all information", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (cbb_Teacher.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            var subject = new Subject();
            subject.SubjectID = DataProvider.SchoolManagement.Subjects.ToList().Count + 1;
            subject.SubjectName = txtSubName.Text;

            var teacher = (from s in DataProvider.SchoolManagement.Users.ToList() where s.FulName.Equals(cbb_Teacher.SelectedItem.ToString()) select s).FirstOrDefault();

            subject.User = teacher;
            subject.Leader = teacher.Username;

            DataProvider.SchoolManagement.Subjects.Add(subject);
            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Added successfully", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Added failed", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var existingSubject = DataProvider.SchoolManagement.Subjects.Find(subject.SubjectID);

            DataProvider.SchoolManagement.Subjects.Remove(existingSubject);
            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Deleted successfully", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Deleted failed", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSubName.Text))
            {
                MessageBox.Show("Fill all information", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbb_Teacher.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingSubject = DataProvider.SchoolManagement.Subjects.Find(subject.SubjectID);

            existingSubject.SubjectName = txtSubName.Text;

            var teacher = (from s in DataProvider.SchoolManagement.Users.ToList() where s.FulName.Equals(cbb_Teacher.SelectedItem.ToString()) select s).FirstOrDefault();

            existingSubject.Leader = teacher.Username;
            existingSubject.User = teacher;

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Updated successfully", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }    
            else
            {
                MessageBox.Show("Updated failed", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
