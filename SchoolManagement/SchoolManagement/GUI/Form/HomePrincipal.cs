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
        public HomePrincipal()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_hide_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            Sidebar.Visible = false;
            Btn_hide.Visible = false;
            Btn_show.Visible = true;
            Sidebar.Width = 80;
            guna2Transition1.ShowSync(Sidebar);
            //HomePanel.Width = 920;
            //guna2Transition1.ShowSync(HomePanel);
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = true;
            Btn_show.Visible = false;
            Btn_hide.Visible = true;
            Sidebar.Visible = false;
            Sidebar.Width = 220;
            guna2Transition1.ShowSync(Sidebar);
            //HomePanel.Width = 790;
            //guna2Transition1.ShowSync(HomePanel);

        }


    }
}
