using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Staff
    {
        private int staffid;
        private String staffname;
        private int staffdepid;
        private decimal staffsalary;
        private String staffdepartmentname;

        public int Staffid { get => staffid; set => staffid = value; }
        public string Staffname { get => staffname; set => staffname = value; }
        public int Staffdepid { get => staffdepid; set => staffdepid = value; }
        public decimal Staffsalary { get => staffsalary; set => staffsalary = value; }
        public string Staffdepartmentname { get => staffdepartmentname; set => staffdepartmentname = value; }
    }
}
