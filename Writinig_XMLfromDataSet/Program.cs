using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writinig_XMLfromDataSet
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
            ds.Tables[0].TableName = "MyTable";
            Console.WriteLine($"Database Name:{ds.DataSetName} Table Name:{ds.Tables[0].TableName}");
            Console.WriteLine($"Total Of Table in Database:{ds.Tables.Count}");

            for (int i = 0; i < ds.Tables.Count; i++)
            {
                Console.WriteLine($"Table Name:{ds.Tables[i].TableName}");
            }
            //Xml'e data yazmak için
            ds.WriteXml(@"C:\Users\nergis\source\repos\AdoNetDisconnectedArchitectural\Writinig_XMLfromDataSet\XML\MyData.xml");
            

           /*********************************************************************/


            //Xml'den veri okumak için yukarıdaki Sql sorgularına gerek yoktur.Db'olarak Xml'in okudu dosya kullanılır.

           /* DataSet ds = new DataSet("My Database");
            ds.ReadXml(@"C:\Users\nergis\source\repos\AdoNetDisconnectedArchitectural\Writinig_XMLfromDataSet\XML\MyData.xml");
            ds.Tables[0].TableName = "MyTable";
            Console.WriteLine($"Database Name:{ds.DataSetName} Table Name:{ds.Tables[0].TableName}");
            Console.WriteLine($"Total Of Table in Database:{ds.Tables.Count}");

            for (int i = 0; i < ds.Tables.Count; i++)
            {
                Console.WriteLine($"Table Name:{ds.Tables[i].TableName}");
            }*/



            Console.ReadKey();

        }
    }
}
