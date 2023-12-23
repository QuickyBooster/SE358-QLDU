using SchoolManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MessageBox.Show(DataProvider.SchoolManagement.Users.AsNoTracking().ToList().Count.ToString());
            //DataProvider.SchoolManagement.Users.AsNoTracking().ToList().ForEach(user => { })

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePrincipal());
            //MessageBox.Show(DataProvider.SchoolManagement.Users);

        }
    }
}
