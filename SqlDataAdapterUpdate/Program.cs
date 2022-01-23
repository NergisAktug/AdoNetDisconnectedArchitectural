using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapterUpdate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            SqlCommand command=new SqlCommand("Update Customer set Name='Gamze' where Id=15",con);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand=command;

            con.Open();
            adapter.UpdateCommand.ExecuteNonQuery();
            con.Close();




        }
    }
}
