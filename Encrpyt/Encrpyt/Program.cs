using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace CryptographyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DESCryptoServiceProvider key = new DESCryptoServiceProvider();

            Return:
            Console.WriteLine("Hello inmate what would you like to do (Encryption, Decryption or Exit)");
            string plainText = Console.ReadLine();
           
            if (plainText == "Encryption")
            {
                Console.WriteLine("Enter message to be encripted!");
                Console.ReadLine();
                Console.WriteLine("\n Cipher Text:" + Encrypt(plainText, key));
                goto Return;
            }
            else if (plainText == "Decryption")
            {
                string cipherText = Encrypt(plainText, key);
                Console.WriteLine("Enter file to be decrypted!");
                Console.ReadLine();
                Console.WriteLine(" \n Plain Text:" + Decrypt(cipherText, key));
                goto Return;
            }
            else if (plainText == "Exit")
                Console.WriteLine("Goodbye nigga! Thanks for your patronage!");

            else
                Console.WriteLine("Invalid Input Case-Sensitive required!");
            //switch (input) 
            //{
            //    case "Encryption":Console.WriteLine("\n Cipher Text:" + Encrypt(plainText, key));break;
            //     case "Decryption": Console.WriteLine("\n Plain Text:" + Decrypt(cipherText, key)); break;
            // }

        }
        public static string Encrypt(string plainText, SymmetricAlgorithm key) 
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(),CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.WriteLine(plainText);
            sw.Flush();
            cs.FlushFinalBlock();
            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));
            
        }
        public static string Decrypt(string cipherText, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText));
            CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
    }
}
