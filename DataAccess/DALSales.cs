using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class DALSales
    {
        public static List<Sales> SalesList()
        {
            List<Sales> values = new List<Sales>();
            SqlCommand cmd = new SqlCommand("SELLING", Connection.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Sales sal = new Sales();
                sal.Salesid = Convert.ToInt32(sdr["salesid"].ToString());
                sal.Productname = sdr["productname"].ToString();
                sal.Staffname = sdr["staffname"].ToString();
                sal.Customername = sdr["customername"].ToString();
                values.Add(sal);
            }
            sdr.Close();
            return values;
        }
    }
}
