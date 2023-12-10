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
        public HomeCashier()
        {
            InitializeComponent();
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
    }
}
