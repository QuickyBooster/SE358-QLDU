﻿using SchoolManagement.Data;
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
    public partial class Settings_Principal : UserControl
    {
        private User user;
        public Settings_Principal(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();
        }

        public void LoadData()
        {
            lbAddress.Text = user.Information.Address;
            lbEmail2.Text = user.Email;
            lbGender.Text = user.Information.Gender;
            lbPhone.Text = user.Information.PhoneNumber;
            lbUserName2.Text = user.Username;
            lb_Name.Text = user.FulName;
            lbUserName.Text = user.FulName;
            lbEmail.Text = user.Email;

            if (user.Information.Image == null)
            {

            }
            else
            {
                string path = Application.StartupPath;
                path = path.Replace("\\bin\\Debug", "");
                AvatarPic.Image = new System.Drawing.Bitmap(path + user.Information.Image);
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(user);
            changePassword.ShowDialog();
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee(user.Username, 1); // Pass parameter to invisible delete button
            addNewEmployee.ShowDialog();
            this.user = DataProvider.SchoolManagement.Users.Find(user.Username);
            LoadData();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
