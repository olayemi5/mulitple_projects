using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace UserValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"C:\UserDetails");
            string file = @"C:\UserDetails\userDetails.txt";
            
            Console.WriteLine("Welcome to Innotelligence Application portal");
            Console.WriteLine();
            Console.WriteLine("Do you want to Register (Yes/No)");

            Console.WriteLine();

            string input = Console.ReadLine();
            if (input == "Yes")
            {
            Return:
                Console.WriteLine("Enter your Username");
                string inputUser = Console.ReadLine();
                if (inputUser == string.Empty)
                {

                    Console.WriteLine("All feilds required!");
                    goto Return;
                }
                else
                {
                    Console.WriteLine("Enter Password");

                }
                string inputPassword = Console.ReadLine();
                if (inputPassword == string.Empty)
                {
                    Console.WriteLine("All feilds required!");

                    goto Return;
                }
                else
                    Console.WriteLine("Your username '{0}' and passsword '{1}' as been stored to your log file", inputUser, inputPassword);
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine("Username: " + inputUser);
                sw.WriteLine("Password: " + inputPassword);
                sw.Close();
            }
            else { 
            Console.WriteLine("Do have a Nice day!");return;

                Console.WriteLine();
        }
                Back:
                Console.WriteLine("Do you wish to continue to Login form? (Yes/No)");
                string loginInput =     Console.ReadLine();
            if (loginInput == string.Empty)
            {
                Console.WriteLine("All feilds are required!");
                goto Back;
            }
            else if (loginInput == "No")
            {
                Console.WriteLine("Do have a Nice day! Thanks for Registering");
            }
            else 
            {
                Console.WriteLine("Welcome");
                
            }

        }
    }
}
