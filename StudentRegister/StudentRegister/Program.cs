using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            string Name;
            int Age;
            string Email;
            int Reg_no;
            int CuponHex;
            int Course_serial;

           try 
           {
                string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='c:\users\user\documents\visual studio 2015\Projects\StudentRegister\StudentRegister\StudentInfo.mdf';Integrated Security=True";
                con = new SqlConnection(str);
                con.Open();
                Console.WriteLine("Database ready......");
                Console.WriteLine("\n Enter your Name : ");
                Name = Console.ReadLine();
                Console.WriteLine("\n Enter your Age : ");
                Age = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Enter your Email : ");
                Email = Console.ReadLine();
                Console.WriteLine("\n Enter your Reg_no : ");
                Reg_no = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Enter your CuponHex : ");
                CuponHex = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Enter your Course_serial : ");
                Course_serial = int.Parse(Console.ReadLine());

                string input = "INSERT INTO Regform (Name,Age,Email,Reg_no,CuponHex,Course_serial) VALUES ('" + Name + "'," + Age + ", '" + Email + "' ," + Reg_no + ", " + CuponHex + "," + Course_serial + ")";
                SqlCommand cmd = new SqlCommand(input, con);
                cmd.ExecuteNonQuery();
                Console.WriteLine(" \n Data Strored Successfully!");
            }
            catch (SqlException x) 
           {
                Console.WriteLine(x.Message);
           }

        }
    }
}
