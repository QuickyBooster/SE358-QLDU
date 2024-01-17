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
    public partial class UCHome_Cashier : UserControl
    {
		private User user;
		public UCHome_Cashier(User user)
		{
			InitializeComponent();
			this.user = user;
			LoadData();
		}

		public void LoadData()
		{
			lbTotalStudents.Text = DataProvider.SchoolManagement.Students.ToList().Count().ToString();
			lbTotalClasses.Text =  DataProvider.SchoolManagement.Classes.ToList().Count().ToString();
			var listStudent = DataProvider.SchoolManagement.Students.ToList();
			try
			{

				lbTotalStudents.Text = listStudent.Count.ToString();

				gridviewSupplier.Rows.Clear();
				foreach (var p in listStudent)
				{
					var dob = p.Information.DateOfBirth.ToString().Split(' ');
					gridviewSupplier.Rows.Add(p.StudentID, p.FulName, dob[0], p.Class.Grade, p.Class.ClassName);
				}
			} catch (Exception ex) { Console.WriteLine(ex.Message); }
		}



	}
}
