using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;
using System.Data;
namespace DataAccess
{
    public class DALCustomer
    {
        public static List<Customer> CustomerList()
        {
            List<Customer> values = new List<Customer>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbcustomer",Connection.conn);
            if (cmd.Connection.State!=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Customer cst = new Customer();
                cst.Customerid = Convert.ToInt32(sdr["customerid"].ToString());
                cst.Customername = sdr["customername"].ToString();
                values.Add(cst);
            }
            sdr.Close();
            return values;
        }

        public static int CustAdd(Customer c)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbcustomer (customername) values (@c)", Connection.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@c", c.Customername);
            return cmd.ExecuteNonQuery();
        }

        public static bool CustomerDelete(int cd)
        {
            SqlCommand cmd = new SqlCommand("Delete From tbcustomer WHERE customerid=@cid",Connection.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("cid",cd);
            return cmd.ExecuteNonQuery() > 0;
        }

        public static List<Customer> GetCustomer(int id)
        {
            List<Customer> values = new List<Customer>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbcustomer WHERE customerid=@cid", Connection.conn);
            cmd.Parameters.AddWithValue("cid", id);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Customer cst = new Customer();
                cst.Customername = sdr["customername"].ToString();
                values.Add(cst);
            }
            sdr.Close();
            return values;
        }
        public static bool CustomerUpdate(Customer cu)
        {
            SqlCommand cmd = new SqlCommand("Update tbcustomer Set customername = @cname Where customerid=@cid",Connection.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@cid",cu.Customerid);
            cmd.Parameters.AddWithValue("@cname",cu.Customername);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
