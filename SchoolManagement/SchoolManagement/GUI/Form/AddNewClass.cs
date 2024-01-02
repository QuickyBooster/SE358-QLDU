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
    public partial class AddNewClass : Form
    {
        private Class cl;
        public AddNewClass()
        {
            InitializeComponent();

            btnDelete.Visible = false;
            btnUpdate.Visible = false;

            combobox_Organiser.Items.Clear();
            foreach (var p in DataProvider.SchoolManagement.Users)
            {
                if (p.Role.RoleID == 2)
                {
                    combobox_Organiser.Items.Add(p.FulName);
                }    
            }
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("10");
            guna2ComboBox1.Items.Add("11");
            guna2ComboBox1.Items.Add("12");

            guna2ComboBox2.Items.Clear();
            guna2ComboBox2.Items.Add("In Progress");
            guna2ComboBox2.Items.Add("Ended");

            lbClassID.Text = (DataProvider.SchoolManagement.Classes.AsNoTracking().ToList().Count + 1).ToString();

        }

        public AddNewClass(int classID)
        {
            InitializeComponent();

            btnCreate.Visible = false;

            cl = (from s in DataProvider.SchoolManagement.Classes.AsNoTracking().ToList() where s.ClassID.Equals(classID) select s).FirstOrDefault();

            combobox_Organiser.Items.Clear();
            foreach (var p in DataProvider.SchoolManagement.Users)
            {
                if (p.Role.RoleID == 2)
                {
                    combobox_Organiser.Items.Add(p.FulName);
                }
            }
            guna2ComboBox1.Items.Clear();
            guna2ComboBox1.Items.Add("10");
            guna2ComboBox1.Items.Add("11");
            guna2ComboBox1.Items.Add("12");

            guna2ComboBox2.Items.Clear();
            guna2ComboBox2.Items.Add("In Progress");
            guna2ComboBox2.Items.Add("Ended");

            lbClassID.Text = cl.ClassID.ToString();
            txtClassName.Text = cl.ClassName.ToString();
            guna2ComboBox1.SelectedItem = cl.Grade.ToString();
            guna2ComboBox2.SelectedItem = cl.StatusClass.ToString();
            combobox_Organiser.SelectedItem = cl.User.FulName.ToString();
            

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtClassName.Text))
            {
                MessageBox.Show("Fill all information", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (combobox_Organiser.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (guna2ComboBox1.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (guna2ComboBox2.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var cl = new Class();
                cl.ClassName = txtClassName.Text;
                cl.ClassID = DataProvider.SchoolManagement.Classes.AsNoTracking().ToList().Count + 1;
                cl.Grade = guna2ComboBox1.SelectedItem.ToString();
                cl.SchoolYear = DateTime.Now.Year;
                cl.StatusClass = guna2ComboBox2.SelectedItem.ToString();
                cl.Exams = new List<Exam>();
                cl.Students = new List<Student>();

                var teacher = (from s in DataProvider.SchoolManagement.Users where s.Role.RoleID == 2 && s.FulName.Equals(combobox_Organiser.SelectedItem.ToString()) select s).FirstOrDefault();
                cl.TeacherID = teacher.Username;
                cl.User = teacher;

                DataProvider.SchoolManagement.Classes.Add(cl);
                int i = DataProvider.SchoolManagement.SaveChanges();
                if (i > 0)
                {
                    MessageBox.Show("Added successfully", "Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Added failed", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var classes = DataProvider.SchoolManagement.Classes.Find(cl.ClassID);

                if (txtClassName.Text != classes.ClassName && !String.IsNullOrEmpty(txtClassName.Text)) 
                    classes.ClassName = txtClassName.Text;
                if (!guna2ComboBox2.SelectedItem.ToString().Equals(classes.StatusClass)) 
                    classes.StatusClass = guna2ComboBox2.SelectedItem.ToString();
                if (!guna2ComboBox1.SelectedItem.ToString().Equals(classes.Grade))
                    classes.Grade = guna2ComboBox1.SelectedItem.ToString();

                var teacher = (from s in DataProvider.SchoolManagement.Users where s.Role.RoleID == 2 && s.FulName.Equals(combobox_Organiser.SelectedItem.ToString()) select s).FirstOrDefault();
                classes.TeacherID = teacher.Username;
                classes.User = teacher;

                int i = DataProvider.SchoolManagement.SaveChanges();
                if (i > 0)
                {
                    MessageBox.Show("Updated successfully", "Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deleted failed", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                var classes = DataProvider.SchoolManagement.Classes.Find(cl.ClassID);
                DataProvider.SchoolManagement.Classes.Remove(classes);
                int i = DataProvider.SchoolManagement.SaveChanges();
                if (i > 0)
                {
                    MessageBox.Show("Deleted successfully", "Class", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Deleted failed", "Class", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }
    }
}
