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
    public partial class UCStudents : UserControl
    {
        public UCStudents()
        {
            InitializeComponent();

            loadData();
        }

        private void loadData()
        {
            int total = 0;
            DataProvider.SchoolManagement.Students.ToList().ForEach(p => total++);
            lbTotalStudents.Text = total.ToString();

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            UCAddStudentInfo studentInformation = new UCAddStudentInfo();
            studentInformation.Show();
        }
    }
}
