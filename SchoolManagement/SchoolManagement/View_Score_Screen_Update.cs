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
    public partial class View_Score_Screen_Update : Form
    {
        public View_Score_Screen_Update()
        {
            InitializeComponent();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.ShowDialog();
            // Load lại data
        }
    }
}
