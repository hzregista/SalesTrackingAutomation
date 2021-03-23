using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DataAccess
{
    public class Connection
    {
        public static SqlConnection conn = new SqlConnection("Data Source=xxx;Initial Catalog=SalesTracking;Integrated Security=True"); //Instead of typing the name of my local machine, I typed "xxx". 

    }
}
