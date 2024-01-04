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
    public partial class HomeCashier : Form
    {
        private User user;
        public HomeCashier()
        {
            InitializeComponent();
        }
		public HomeCashier(User user)
		{
			InitializeComponent();
			this.user = user;
			label1.Text = user.FulName;
			if (user.Information.Image != null)
			{
				string path = Application.StartupPath;
				path = path.Replace("\\bin\\Debug", "");
				guna2CirclePictureBox2.Image = new System.Drawing.Bitmap(path + user.Information.Image);
			}
		}
		bool menuExpand = false;
        private void MouseDetect_Tick(object sender, EventArgs e)
        {
            if (!guna2Transition1.IsCompleted) return;
            if (Sidebar.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                if (!menuExpand)
                {
                    menuExpand = true;
                    Sidebar.Visible = false;
                    Sidebar.Width = 220;
                    guna2Transition1.Show(Sidebar);
                }
            }
            else
            {
                if (menuExpand)
                {
                    menuExpand = false;
                    Sidebar.Visible = false;
                    Sidebar.Width = 77;
                    guna2Transition1.Show(Sidebar);
                }
            }
        }

		private void Home_Click(object sender, EventArgs e)
		{
			uCHome_Cashier = new UCHome_Cashier();
			uCHome_Cashier.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCHome_Cashier);
		}

		private void Tuition_Click(object sender, EventArgs e)
		{
			uCTuition_Cashier = new UCTuition_Cashier();
			uCTuition_Cashier.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCTuition_Cashier);
		}

		private void Expenses_Click(object sender, EventArgs e)
		{
			uCExpenses_Cashier = new UCExpenses_Cashier();
			uCExpenses_Cashier.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCExpenses_Cashier);
		}

		private void Settings_Click(object sender, EventArgs e)
		{
			uCSettings_Cashier = new UCSettings_Cashier();
			uCSettings_Cashier.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCSettings_Cashier);
		}
	}
}
