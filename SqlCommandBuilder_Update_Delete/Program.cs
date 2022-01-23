using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandBuilder_Update_Delete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SqlCommandBuilder , con.Open() yada con.Close() yapmadan islemlerin yapılmasını saglar
            SqlConnection con = new SqlConnection(@"Data Source=NIRVANA\SQLEXPRESS;Initial Catalog=SQLFULL;Persist Security Info=True;User ID=udemy;Password=1");
            SqlDataAdapter adapter = new SqlDataAdapter("Select*from Customer", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet("My Database");
            adapter.Fill(ds);//Tablo dolduruluyor.
         
            Console.WriteLine($"Database Name:{ds.DataSetName} Table Name:{ds.Tables[0].TableName}");
            Console.WriteLine($"Total Of Table in Database:{ds.Tables.Count}");

            for (int i = 0; i < ds.Tables.Count; i++)
            {
                Console.WriteLine($"Table Name:{ds.Tables[i].TableName}");
            }
            ds.Tables[0].Rows.Add(64,"Osman","Gullu");
            ds.Tables[0].Rows.Add(65, "Osmann", "Gulluu");
            adapter.Update(ds);
            Console.ReadKey();

        }
    }
}
