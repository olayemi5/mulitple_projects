using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace maybe
{
    class Program
    {
        static string connectionString = @"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=PRO_Db;Integrated Security=True";
        static SqlConnection con = new SqlConnection(connectionString);
        static void Main(string[] args)
        {
            string name;
            int id;
            int Age;
            string Email;
            string Resident;
                 
            
            using (con) 
            {
                try 
                {
                    con.Open();
                    Console.WriteLine("Connection opened!");

                    Console.WriteLine("\n What is your registration id?");

                    id = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n Enter your name");

                    name = Console.ReadLine();

                    Console.WriteLine("\n Enter your Age");

                    Age = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n Enter your Email");

                    Email = Console.ReadLine();

                    Console.WriteLine(" \n Enter your Resident Address");

                    Resident = Console.ReadLine();

                    string query = ("INSERT INTO profile (id,Name,Age,Email,Resident) VALUES("+ id + ",'" +name +"',"+Age+", '"+ Email + "','"+Resident +"')");

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("\n Data stored successfully!");
                }
                catch (SqlException x) 
                {
                    Console.WriteLine(x.Message);
                }
            
            }
        }
    }
}
