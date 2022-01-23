using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDataSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            //sqlDataAdapter aynı anda 1'den fazla T-SQL sorgusu yazılabilir. 
            DataSet ds = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Customer;Select * From CustomerInformation;", con);
            adapter.Fill(ds);
          


        }
    }
}
