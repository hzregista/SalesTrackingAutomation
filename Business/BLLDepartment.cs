using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
namespace Business
{
    public class BLLDepartment
    {
        public static List<Department> BLLDepartmentList()
        {
            return DALDepartment.DepartmentList();
        }
        public static int BLLAddDep(Department d)
        {
            if(d.Departmentname != null && d.Departmentname != "")
            {
                return DALDepartment.DepAdd(d);
            }
            return -1;
        }
    }
}
