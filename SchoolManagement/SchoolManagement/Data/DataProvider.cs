using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class DataProvider
    {
        private static SchoolManagement schoolManagement;

        public static SchoolManagement SchoolManagement
        {
            get 
            { 
                if (schoolManagement == null)
                {
                    schoolManagement = new SchoolManagement();
                }

                return schoolManagement; 
            }
            set { schoolManagement = value; }
        }

    }
}
