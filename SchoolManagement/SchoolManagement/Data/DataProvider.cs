using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data
{
    public class DataProvider
    {
        private static SE358_SchoolManagementEntities schoolManagement;

        public static SE358_SchoolManagementEntities SchoolManagement
        {
            get 
            { 
                if (schoolManagement == null)
                {
                    schoolManagement = new SE358_SchoolManagementEntities();
                }

                return schoolManagement; 
            }
            set { schoolManagement = value; }
        }

       

    }
}
