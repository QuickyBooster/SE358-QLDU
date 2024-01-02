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
    public partial class ChangePassword : Form
    {
        private User user;
        public ChangePassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_SaveChange_Click(object sender, EventArgs e)
        {
            var existingUser = DataProvider.SchoolManagement.Users.Find(user.Username);

            if (String.IsNullOrEmpty(guna2TextBox1.Text))
            {
                MessageBox.Show("Fill all information", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Fill all information", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtRetypePass.Text))
            {
                MessageBox.Show("Fill all information", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!existingUser.Password.Equals(guna2TextBox1.Text))
            {
                MessageBox.Show("Password are not correct", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtPass.Text.Equals(txtRetypePass.Text))
            {
                MessageBox.Show("Password are not same with retype password", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPass.Text.Length <= 8)
            {
                MessageBox.Show("Your password must be at least 8 characters", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            existingUser.Password = txtPass.Text;

            int i = DataProvider.SchoolManagement.SaveChanges();

            if (i > 0)
            {
                MessageBox.Show("Changed password successfully", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Changed password failed", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
