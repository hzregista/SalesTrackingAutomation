using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class Department
    {
        private int departmentid;
        private String departmentname;

        public int Departmentid { get => departmentid; set => departmentid = value; }
        public string Departmentname { get => departmentname; set => departmentname = value; }
    }
}
