using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandBuilderr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlCommandBuilder , con.Open() yada con.Close() yapmadan islemlerin yapılmasını saglar
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            SqlDataAdapter adapter = new SqlDataAdapter("Select*from Customer", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds=new DataSet();
            adapter.Fill(ds);



        }
    }
}
