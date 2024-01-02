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
    public partial class UCClasses_Principal : UserControl
    {
        private User user;
        public UCClasses_Principal(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
        }

        private void LoadData(List<Class> classes)
        {
            lbTotaClasses.Text = classes.ToList().Count.ToString();

            gridviewClass.Rows.Clear();
            foreach (Class c in classes)
            {
                int total = 0;
                foreach (var p in DataProvider.SchoolManagement.Students)
                {
                    if (p.Class.ClassID == c.ClassID)
                    {
                        total++;
                    }    
                }
                gridviewClass.Rows.Add(c.ClassID, c.Grade, c.ClassName, total, c.User.FulName);
            }    
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            AddNewClass addNewClass = new AddNewClass();
            addNewClass.ShowDialog();
            LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
        }

        private void gridviewClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            else
            {
                var editClass = new AddNewClass(int.Parse(gridviewClass.Rows[idx].Cells["ClassId"].Value.ToString()));
                editClass.ShowDialog();
                LoadData(DataProvider.SchoolManagement.Classes.AsNoTracking().ToList());
            }
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            var list = new List<Class>();
            foreach (var p in DataProvider.SchoolManagement.Classes.ToList())
            {
                if (p.ClassName.ToLower().Contains(txtSearchClass.Text.ToLower()))
                {
                    list.Add(p);
                }
            }
            LoadData(list);
        }
    }
}
