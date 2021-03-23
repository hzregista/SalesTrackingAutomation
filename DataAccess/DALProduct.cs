using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class DALProduct
    {
        public static List<Product> ProductList()
        {
            List<Product> values = new List<Product>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbproduct", Connection.conn);
            if (cmd.Connection.State != ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Product prd = new Product();
                prd.Productid = Convert.ToInt32(sdr["productid"].ToString());
                prd.Productname = sdr["productname"].ToString();
                prd.Productprice = Convert.ToDecimal(sdr["productprice"].ToString());
                prd.Productcount = Convert.ToInt32(sdr["productcount"].ToString());
                values.Add(prd);
            }
            sdr.Close();
            return values;
        }
        
        public static int AddProd(Product p)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbproduct (productname,productprice,productcount) values (@p1,@p2,@p3)",Connection.conn);
            if (cmd.Connection.State !=ConnectionState.Open)
            {
                cmd.Connection.Open();
            }
            cmd.Parameters.AddWithValue("@p1",p.Productname);
            cmd.Parameters.AddWithValue("@p2", p.Productprice);
            cmd.Parameters.AddWithValue("@p3", p.Productcount);
            return cmd.ExecuteNonQuery();
        }
    }

}
