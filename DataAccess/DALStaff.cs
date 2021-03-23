using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;
using DataAccess;


namespace DataAccess
{
    public class DALStaff
    {
        public static List<Staff> StaffList()
        {
            List<Staff> values = new List<Staff>();
            SqlCommand cmd = new SqlCommand("DEPARTMENTS",Connection.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Staff stf = new Staff();
                stf.Staffid = Convert.ToInt32(sdr["staffid"].ToString());
                stf.Staffname = sdr["staffname"].ToString();
                stf.Staffdepid = Convert.ToInt32(sdr["staffdepid"].ToString());
                stf.Staffsalary = Convert.ToDecimal(sdr["staffsalary"].ToString());
                stf.Staffdepartmentname = sdr["departmentname"].ToString();
                values.Add(stf);
            }
            sdr.Close();
            return values;
        }

        public static int AddStaff(Staff s)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbstaff (staffname,staffdepid,staffsalary) values (@s1,@s2,@s3)",Connection.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@s1",s.Staffname);
            cmd.Parameters.AddWithValue("@s2", s.Staffdepid);
            cmd.Parameters.AddWithValue("@s3", s.Staffsalary);
            return cmd.ExecuteNonQuery();
        }
    }
}
