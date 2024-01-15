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
    public partial class StudentInformation_Cashier_Update : Form
    {
        public StudentInformation_Cashier_Update()
        {
            InitializeComponent();
        }

        private void btnTuiitionfee_Click(object sender, EventArgs e)
        {
            UCFeeInfo_Cashier_Update uc = new UCFeeInfo_Cashier_Update();
            uc.Dock = DockStyle.Fill;
            this.panelDisplay.Controls.Clear();
            this.panelDisplay.Controls.Add(uc);
        }
    }
}
