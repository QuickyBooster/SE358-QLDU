using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AddNewEmployee : Form
    {
        private string path;
        private string destinationPathOfImage;
        private string selectedPath;
        private User user;
        public AddNewEmployee()
        {
            InitializeComponent();
            btn_Delete.Visible = false;
            btn_Add.Visible = false;
            combobox_usergroup.Items.Clear();
            foreach (var p in DataProvider.SchoolManagement.Roles)
            {
                if (p.RoleName.Equals("Principal")) continue;
                combobox_usergroup.Items.Add(p.RoleName);
            }

            lbEmployeeID.Text = (DataProvider.SchoolManagement.Users.ToList().Count + 1).ToString();
        }

        public AddNewEmployee(string username)
        {
            InitializeComponent();
            this.user = DataProvider.SchoolManagement.Users.Find(username);
            btn_Add.Visible = false;
            combobox_usergroup.Items.Clear();
            foreach (var p in DataProvider.SchoolManagement.Roles)
            {
                if (p.RoleName.Equals("Principal")) continue;
                combobox_usergroup.Items.Add(p.RoleName);
            }

            lbEmployeeID.Text = user.InfoID.ToString();

            guna2Panel1.Visible = false;

            txtAddress.Text = user.Information.Address;
            txtEmail.Text = user.Email;
            txtEmployeeName.Text = user.FulName;
            txtPhone.Text = user.Information.PhoneNumber;

            if (user.Information.Gender == "Male")
            {
                checkbox_male.Checked = true;
            }
            else
            {
                guna2CustomCheckBox1.Checked = true;
            }

            string path = Application.StartupPath;
            path = path.Replace("\\bin\\Debug", "");
            picture_product.Image = new System.Drawing.Bitmap(path + user.Information.Image);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Check data input
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtEmployeeName.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtRetypePass.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkbox_male.Checked == false && guna2CustomCheckBox1.Checked == false)
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (combobox_usergroup.SelectedItem == null)
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtRetypePass.Text.Equals(txtPass.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var us = DataProvider.SchoolManagement.Users.Find(txtUsername.Text);
            if (us != null)
            {
                MessageBox.Show("Username is existed", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add into database
            Information info = new Information();
            info.Image = path;
            info.Address = txtAddress.Text;
            info.PhoneNumber = txtPhone.Text;
            info.Gender = checkbox_male.Checked == true ? "Male" : "Female";
            info.InfoID = DataProvider.SchoolManagement.Information.ToList().Count + 1;

            DataProvider.SchoolManagement.Information.Add(info);

            User user = new User();
            user.Username = txtUsername.Text;
            user.Password = txtPass.Text;
            user.Email = txtEmail.Text;
            user.FulName = txtEmployeeName.Text;
            user.InfoID = info.InfoID;
            user.Information = info;

            var role = (from s in DataProvider.SchoolManagement.Roles.ToList() where s.RoleName.Equals(combobox_usergroup.SelectedItem.ToString()) select s).FirstOrDefault();
            user.Role = role;
            user.RoleID = role.RoleID;

            DataProvider.SchoolManagement.Users.Add(user);

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 1)
            {
                MessageBox.Show("Added successfully", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!File.Exists(destinationPathOfImage))
                {
                    File.Copy(selectedPath, destinationPathOfImage);
                    //picture_product.Image = new System.Drawing.Bitmap(destinationPath);
                    //path = "\\Resources\\" + fileName;
                }
                else
                {
                    MessageBox.Show("Error occur when trying to select image", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Added failed", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void deleteFile(string path)
        {
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Delete(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void CopyFile(string source, string path)
        {
            try
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers();
                File.Copy(source, path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                string resourceFolderPath = Path.Combine(Application.StartupPath, "Resources");
                if (!Directory.Exists(resourceFolderPath))
                    Directory.CreateDirectory(resourceFolderPath);

                string fileName = Path.GetFileName(selectedFilePath);
                fileName = (DataProvider.SchoolManagement.Information.ToList().Count + 1).ToString() + fileName;
                string destinationPath = Path.Combine(resourceFolderPath, fileName);

                destinationPath = destinationPath.Replace("\\bin\\Debug", "");
                destinationPathOfImage = destinationPath;
                selectedPath = selectedFilePath;
                path = "\\Resources\\" + fileName;
                picture_product.Image = new System.Drawing.Bitmap(selectedPath);

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var information = DataProvider.SchoolManagement.Information.Find(user.Information.InfoID);

            DataProvider.SchoolManagement.Information.Remove(information);

            DataProvider.SchoolManagement.Users.Remove(user);

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 1)
            {
                MessageBox.Show("Deleted successfully", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Deleted failed", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtEmployeeName.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkbox_male.Checked == false && guna2CustomCheckBox1.Checked == false)
            {
                MessageBox.Show("Fill all information", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var us = DataProvider.SchoolManagement.Users.Find(user.Username);

            us.Email = txtEmail.Text;
            us.FulName = txtEmployeeName.Text;
            us.Information.PhoneNumber = txtPhone.Text;
            us.Information.Address = txtAddress.Text;
            us.Information.Gender = checkbox_male.Checked == true ? "Male" : "Female";

            if (!String.IsNullOrEmpty(path) && !String.IsNullOrEmpty(destinationPathOfImage))
            {
                string existingPath = Application.StartupPath;
                existingPath = existingPath.Replace("\\bin\\Debug", "");

                deleteFile(existingPath + us.Information.Image);
                CopyFile(selectedPath, destinationPathOfImage);

                us.Information.Image = path;
            }

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Updated successfully", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Updated failed", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
