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
    public partial class HomePrincipal : Form
    {
        private User user;
        public HomePrincipal(User user)
		{
            InitializeComponent();
            this.user = user;
        }

        public HomePrincipal()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        //private void Btn_hide_Click(object sender, EventArgs e)
        //{
        //    pictureBox2.Visible = false;
        //    pictureBox1.Visible = false;
        //    Sidebar.Visible = false;
        //    Btn_hide.Visible = false;
        //    Btn_show.Visible = true;
        //    Sidebar.Width = 80;
        //    guna2Transition1.ShowSync(Sidebar);
        //    //HomePanel.Width = 920;
        //    //guna2Transition1.ShowSync(HomePanel);
        //}

        //private void Btn_show_Click(object sender, EventArgs e)
        //{
        //    pictureBox2.Visible = true;
        //    pictureBox1.Visible = true;
        //    Btn_show.Visible = false;
        //    Btn_hide.Visible = true;
        //    Sidebar.Visible = false;
        //    Sidebar.Width = 220;
        //    guna2Transition1.ShowSync(Sidebar);
        //    //HomePanel.Width = 790;
        //    //guna2Transition1.ShowSync(HomePanel);

        //}


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
            ucHome = new UCHome(user);
            ucHome.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucHome);
        }

        private void Students_Click(object sender, EventArgs e)
        {
            ucStudents= new UCStudents();
            ucStudents.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucStudents);
        }

        private void HomePrincipal_Load(object sender, EventArgs e)
        {
            ucHome = new UCHome(user);
            ucHome.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(ucHome);
        }

        private void Classes_Click(object sender, EventArgs e)
        {
            UCClasses_Principal uc = new UCClasses_Principal(user);
            uc.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(uc);
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            UCEmployees uc = new UCEmployees(user);
            uc.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(uc);
        }

        private void Subjects_Click(object sender, EventArgs e)
        {
            UCSubjects_Principal uc = new UCSubjects_Principal(user);
            uc.Dock = DockStyle.Fill;
            this.TabUC.Controls.Clear();
            this.TabUC.Controls.Add(uc);
        }
    }
}
