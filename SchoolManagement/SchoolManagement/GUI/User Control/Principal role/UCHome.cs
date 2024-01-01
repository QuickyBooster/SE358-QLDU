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
    public partial class UCHome : UserControl
    {
        private User user;
        public UCHome(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadData();
        }

        public void LoadData()
        {
            int total = 0;
            flowLayoutPanel2.Controls.Clear();
            DataProvider.SchoolManagement.Users.ToList().ForEach(p =>
            {
                if (p.Role.RoleID == 3)
                {
                    total++;
                    var ucMiniEvent = new UCMiniEvent(p);
                    flowLayoutPanel2.Controls.Add(ucMiniEvent);
                }    
            });
            lbTotalEmployees.Text = total.ToString();

            total = 0;
            flowLayoutPanel1.Controls.Clear();
            DataProvider.SchoolManagement.Users.ToList().ForEach(p =>
            {
                if (p.Role.RoleID == 2)
                {
                    total++;
                    var ucMiniEvent = new UCMiniEvent(p);
                    flowLayoutPanel1.Controls.Add(ucMiniEvent);
                }
            });
            lbTotalTeachers.Text = total.ToString();

            total = 0;
            DataProvider.SchoolManagement.Students.ToList().ForEach(p =>
            {
                total++;
            });
            lbTotalStudents.Text = total.ToString();

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
