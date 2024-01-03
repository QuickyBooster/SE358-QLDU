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
    public partial class StudentInformation : Form
    {
        public StudentInformation()
        {
            InitializeComponent();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnParents_Click(object sender, EventArgs e)
        {
            ucParentsInfo = new UCParentsInfo();
            ucParentsInfo.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(ucParentsInfo);
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            uCStudentScoreInfo = new UCStudentScoreInfo();
            uCStudentScoreInfo.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uCStudentScoreInfo);
        }
    }
}
