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
    public partial class UCAddParentsInfo : UserControl
    {
        private Student student;
        private Information information;
        private AddNewStudent addNewStudent;

        public UCAddParentsInfo(Student student, Information information, AddNewStudent addNewStudent)
        {
            InitializeComponent();

            btn_Update.Visible = false;

            this.student = student;
            this.information = information;
            this.addNewStudent = addNewStudent;
        }

        public UCAddParentsInfo(Student student)
        {
            InitializeComponent();

            btn_Add.Visible = false;

            this.student = student;

            LoadData();
            
        }

        public void LoadData()
        {
            txtFatherCarreer.Text = student.Information.FatherOccupation;
            txtFatherName.Text = student.Information.FatherName;
            txtFatherPhone.Text = student.Information.FatherPhoneNumber;

            txtMother.Text = student.Information.MotherName;
            txtMotherCarreer.Text = student.Information.MotherOccupation;
            txtMotherPhone.Text = student.Information.MotherPhoneNumber;
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
            if (String.IsNullOrEmpty(txtFatherCarreer.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtFatherName.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtFatherPhone.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAllDigits(txtFatherPhone.Text) || txtFatherPhone.Text.Length <= 9)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMother.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMotherCarreer.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMotherPhone.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAllDigits(txtMotherPhone.Text) || txtMotherPhone.Text.Length <= 9)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(information.Image))
            {
                MessageBox.Show("Please choose image for student", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }    

            information.FatherName = txtFatherName.Text;
            information.FatherOccupation = txtFatherCarreer.Text;
            information.FatherPhoneNumber = txtFatherPhone.Text;

            information.MotherOccupation = txtMotherCarreer.Text;
            information.MotherPhoneNumber = txtMotherPhone.Text;
            information.MotherName = txtMother.Text;

            student.Information = information;
            student.InfoID = information.InfoID;

            DataProvider.SchoolManagement.Information.Add(information);
            DataProvider.SchoolManagement.Students.Add(student);

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 1)
            {
                MessageBox.Show("Added successfully", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addNewStudent.SaveImageAfterAddedSuccessfully();
                addNewStudent.HideThisForm();
            }    
            else
            {
                MessageBox.Show("Added failed", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFatherCarreer.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtFatherName.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtFatherPhone.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAllDigits(txtFatherPhone.Text) || txtFatherPhone.Text.Length <= 9)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMother.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMotherCarreer.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtMotherPhone.Text))
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsAllDigits(txtMotherPhone.Text) || txtMotherPhone.Text.Length <= 9)
            {
                MessageBox.Show("Fill all information", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingStudent = DataProvider.SchoolManagement.Students.Find(student.StudentID);

            existingStudent.Information.FatherName = txtFatherName.Text;
            existingStudent.Information.FatherOccupation = txtFatherCarreer.Text;
            existingStudent.Information.FatherPhoneNumber = txtFatherPhone.Text;

            existingStudent.Information.MotherOccupation = txtMotherCarreer.Text;
            existingStudent.Information.MotherPhoneNumber = txtMotherPhone.Text;
            existingStudent.Information.MotherName = txtMother.Text;

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Updated successfully", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Updated failed", "Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
