using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapterInsert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            string sql = "insert into Customer VALUES(15,'Burak','Cakır')";
            SqlDataAdapter adapter = new SqlDataAdapter();  //sqlDataAdapter aynı anda 1'den fazla T-SQL sorgusu yazılabilir. 
            adapter.InsertCommand =new SqlCommand(sql, con);
            con.Open();

            adapter.InsertCommand.ExecuteNonQuery();




        }
    }
}
