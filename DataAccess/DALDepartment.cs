using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
namespace DataAccess
{
    public class DALDepartment
    {
        public static List<Department> DepartmentList()
        {
            List<Department> values = new List<Department>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM tbdepartment",Connection.conn);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Department dp = new Department();
                dp.Departmentid = Convert.ToInt32(sdr["departmentid"].ToString());
                dp.Departmentname = sdr["departmentname"].ToString();
                values.Add(dp);    
            }
            sdr.Close();
            return values;
        }

        public static int DepAdd(Department d)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbdepartment (departmentname) Values (@d)",Connection.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@d",d.Departmentname);
            return cmd.ExecuteNonQuery();
        }

    }
}
