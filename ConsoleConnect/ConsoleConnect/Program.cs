using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            string str;
            string name;
            int age;

            try 
            {
                str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='c:\users\user\documents\visual studio 2015\Projects\ConsoleConnect\ConsoleConnect\Datas.mdf';Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                Console.WriteLine("Database Connected : ");
                Console.WriteLine("\n Enter your name");
                name = Console.ReadLine();
                Console.WriteLine("\n Enter your age : ");
                age = int.Parse(Console.ReadLine());
                string query = "INSERT INTO details (user_name,user_age) VALUES('" + name +"' , " + age + " )";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n Data stored into Database");
                string read = "SELECT * FROM details";
                SqlCommand view = new SqlCommand(read, con);
                SqlDataReader dr = view.ExecuteReader();


            }catch(SqlException x) 
            {
                Console.WriteLine(x.Message);
                
            }

        }
    }
}
