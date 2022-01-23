using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDisconnectedArchitectural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            DataTable dt=new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("Select * From Customer",con);
            adapter.Fill(dt);

            Console.WriteLine(dt.ToString());
            Console.ReadKey();
        
        }
    }
}
