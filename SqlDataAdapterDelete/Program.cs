using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapterDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            SqlCommand command = new SqlCommand("Delete Customer where Id=42", con);

            SqlDataAdapter adapter= new SqlDataAdapter();
            adapter.DeleteCommand = command;

            con.Open();
            adapter.DeleteCommand.ExecuteNonQuery();    
            con.Close();


        }
    }
}
