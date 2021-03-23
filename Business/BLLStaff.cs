using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace Business
{
    public class BLLStaff
    {
        public static List<Staff> BLLStaffList()
        {
            return DALStaff.StaffList();
        }

        public static int BLLAddStaff(Staff s)
        {
            if (s.Staffname!= "" && s.Staffsalary>0)
            {
                return DALStaff.AddStaff(s);
            }
            else { return -1; }
        }
    }
}
