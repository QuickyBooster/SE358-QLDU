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
    public partial class UCEmployees : UserControl
    {
        private User user;
        public UCEmployees(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadData(DataProvider.SchoolManagement.Users.ToList());
        }

        private void LoadData(List<User> users)
        {
            lbTotaEmployees.Text = users.Count.ToString();
            gridviewSupplier.Rows.Clear();
            foreach (var user in users)
            {
                gridviewSupplier.Rows.Add(user.Username, user.FulName, user.Information.Gender, user.Email, user.Role.RoleName);
            }    
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee();
            addNewEmployee.ShowDialog();
            LoadData(DataProvider.SchoolManagement.Users.ToList());
        }

        private void gridviewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0) return;
            else
            {
                var editUser = new AddNewEmployee(gridviewSupplier.Rows[idx].Cells["Employee_ID"].Value.ToString());
                editUser.ShowDialog();
                LoadData(DataProvider.SchoolManagement.Users.AsNoTracking().ToList());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var list = new List<User>();

            foreach (var p in DataProvider.SchoolManagement.Users)
            {
                if (p.FulName.ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    list.Add(p);
                }    
            }

            LoadData(list);
        }
    }
}
