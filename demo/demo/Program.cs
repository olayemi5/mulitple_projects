using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Watching connect demo ");

            try {
                string connectionstring =
                "sever=localhost;port=3306;uid=stephen;pwd=Olayemi5;database=Student_database;cahrset=utf8;Sslmode=none;";
                MySqlConnection con = new MySqlConnection(connectionstring);

                con.Open();
                Console.WriteLine("Connection is "+ con.State.ToString()+ Environment.NewLine);



                con.Close();
                Console.WriteLine("Connection is " + con.State.ToString() + Environment.NewLine);

            } 
            catch (MySql.Data.MySqlClient.MySqlException ex)
             {
                Console.WriteLine("Error " + ex.Message.ToString());
             }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
