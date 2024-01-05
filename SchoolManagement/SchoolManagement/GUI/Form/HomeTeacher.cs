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
	public partial class HomeTeacher : Form
	{
		private User user;
		public HomeTeacher(User user)
		{
			InitializeComponent();
			try
			{
				this.user = user;
				label1.Text = user.FulName;
				if (user.Information.Image != null)
				{
					string path = Application.StartupPath;
					path = path.Replace("\\bin\\Debug", "");
					guna2CirclePictureBox2.Image = new System.Drawing.Bitmap(path + user.Information.Image);
				}
			} catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		public HomeTeacher()
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
			} else
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
			uCHome_Teacher = new UCHome_Teacher();
			uCHome_Teacher.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCHome_Teacher);
		}

		private void Students_Click(object sender, EventArgs e)
		{
			uCStudent_Teacher = new UCStudent_Teacher();
			uCStudent_Teacher.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCStudent_Teacher);
		}

		private void Classes_Click_1(object sender, EventArgs e)
		{
			uCClasses_Teacher = new UCClasses_Teacher();
			uCClasses_Teacher.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCClasses_Teacher);
		}

		private void Settings_Click(object sender, EventArgs e)
		{
			uCSettings_Teacher = new UCSettings_Teacher();
			uCSettings_Teacher.Dock = DockStyle.Fill;
			this.HomePanel.Controls.Clear();
			this.HomePanel.Controls.Add(uCSettings_Teacher);
		}
	}
}
