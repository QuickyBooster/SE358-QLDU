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
    public partial class UCAddStudentInfo : UserControl
    {
        private Student student;
        private Information information;
        private AddNewStudent addNewStudent;

        public UCAddStudentInfo(Student student, Information information, AddNewStudent addNewStudent)
        {
            InitializeComponent();
            txtEmail.Visible = false;
            label7.Visible = false;

            lbStudentID.Text = (DataProvider.SchoolManagement.Students.ToList().Count + 1).ToString();

            comboGrade.Items.Add("10");
            comboGrade.Items.Add("11");
            comboGrade.Items.Add("12");

            this.student = student;
            this.information = information;
            this.addNewStudent = addNewStudent;

            btn_Update.Visible = false;
        }

        public UCAddStudentInfo(Student student)
        {
            InitializeComponent();

            lbStudentID.Text = student.StudentID.ToString();
            txtEmail.Visible = false;
            label7.Visible = false;

            comboGrade.Items.Add("10");
            comboGrade.Items.Add("11");
            comboGrade.Items.Add("12");

            this.student = student;

            LoadData();

            btn_Add.Visible = false;
        }

        public void LoadData()
        {
            lbStudentID.Text = student.StudentID.ToString();
            txtAddress.Text = student.Information.Address;
            txtPhone.Text = student.Information.PhoneNumber;
            txtStudentName.Text = student.FulName;
            dtpBirthDate.Value = (DateTime)student.Information.DateOfBirth;
            comboGrade.SelectedItem = student.Class.Grade;
            comboClass.SelectedItem = student.Class.ClassName;
            if (student.Information.Gender.Equals("Male"))
            {
                checkbox_male.Checked = true;
            }    
            else
            {
                cbFemale.Checked = true;
            }    
        }

        public bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (String.IsNullOrEmpty(txtEmail.Text))
            //{
            //    MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (!txtEmail.Text.EndsWith("@gmail.com")) 
            //{
            //    MessageBox.Show("Email is not valid", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAllDigits(txtPhone.Text) || txtPhone.Text.Length <= 9)
            {
                MessageBox.Show("Phone number is not valid", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    
            if (String.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpBirthDate.Value == null || dtpBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth is not valid", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbFemale.Checked == false && checkbox_male.Checked == false)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboGrade.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboClass.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cl = (from s in DataProvider.SchoolManagement.Classes.ToList() where s.ClassName.Equals(comboClass.SelectedItem.ToString()) select s).FirstOrDefault();
            student.StudentID = DataProvider.SchoolManagement.Students.ToList().Count + 1;
            student.FulName = txtStudentName.Text;
            student.Class = cl;
            student.ClassID = cl.ClassID;

            information.InfoID = DataProvider.SchoolManagement.Information.ToList().Count + 1;
            information.Address = txtAddress.Text;
            information.DateOfBirth = dtpBirthDate.Value;
            information.Gender = checkbox_male.Checked == true ? "Male" : "Female";
            information.PhoneNumber = txtPhone.Text;

            addNewStudent.DisplayParentInformation();
        }

        private void comboGrade_SelectedValueChanged(object sender, EventArgs e)
        {
            comboClass.Items.Clear();

            foreach(var p in DataProvider.SchoolManagement.Classes.ToList())
            {
                if (p.Grade.Equals(comboGrade.SelectedItem.ToString()))
                {
                    comboClass.Items.Add(p.ClassName);
                }    
            }    
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (String.IsNullOrEmpty(txtEmail.Text))
            //{
            //    MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (!txtEmail.Text.EndsWith("@gmail.com")) 
            //{
            //    MessageBox.Show("Email is not valid", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAllDigits(txtPhone.Text) || txtPhone.Text.Length <= 9)
            {
                MessageBox.Show("Phone number is not valid", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dtpBirthDate.Value == null || dtpBirthDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth is not valid", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbFemale.Checked == false && checkbox_male.Checked == false)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboGrade.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboClass.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingStudent = DataProvider.SchoolManagement.Students.Find(student.StudentID);
            var cl = (from s in DataProvider.SchoolManagement.Classes.ToList() where s.ClassName.Equals(comboClass.SelectedItem.ToString()) select s).FirstOrDefault();

            existingStudent.FulName = txtStudentName.Text;
            existingStudent.Class = cl;
            existingStudent.ClassID = cl.ClassID;

            existingStudent.Information.Address = txtAddress.Text;
            existingStudent.Information.DateOfBirth = dtpBirthDate.Value;
            existingStudent.Information.Gender = checkbox_male.Checked == true ? "Male" : "Female";
            existingStudent.Information.PhoneNumber = txtPhone.Text;

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Updated personal information successfully", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else
            {
                MessageBox.Show("Updated personal information failed", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
