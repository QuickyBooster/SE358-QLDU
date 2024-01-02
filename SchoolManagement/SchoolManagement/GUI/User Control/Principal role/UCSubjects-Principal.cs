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
    public partial class UCSubjects_Principal : UserControl
    {
        private User user;
        public UCSubjects_Principal(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadData(DataProvider.SchoolManagement.Subjects.ToList());
        }

        private void LoadData(List<Subject> subjects)
        {
            lbTotaSubjects.Text = subjects.Count.ToString();
            gridviewSubject.Rows.Clear();
            foreach(var p in subjects)
            {
                gridviewSubject.Rows.Add(p.SubjectID, p.SubjectName, p.User.FulName);
            }    
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubject addSubject = new AddSubject();
            addSubject.ShowDialog();
            LoadData(DataProvider.SchoolManagement.Subjects.ToList());
        }

        private void gridviewSubject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            else
            {
                var editSubject = new AddSubject(int.Parse(gridviewSubject.Rows[idx].Cells["Subject_ID"].Value.ToString()));
                editSubject.ShowDialog();
                LoadData(DataProvider.SchoolManagement.Subjects.ToList());
            }
        }

        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            var list = new List<Subject>();

            foreach(var p in DataProvider.SchoolManagement.Subjects.ToList())
            {
               if (p.SubjectName.ToLower().Contains(txtSearchSubject.Text.ToLower()))
                {
                    list.Add(p);
                }    
            }

            LoadData(list);
        }
    }
}
