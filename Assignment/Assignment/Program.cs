using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! How are you doing ");
            DESCryptoServiceProvider key = new DESCryptoServiceProvider();
            Console.WriteLine("Enter your message ");
            string plainText = Console.ReadLine();
            string cipherText = "";
            Console.WriteLine("\n Cipher Text:" + Encrypt(plainText, key));
            Console.WriteLine("\n Plain Text:" + Decrypt(cipherText, key));

        }
        public static string Encrypt(string plainText, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.WriteLine(plainText);
            sw.Flush();
            cs.FlushFinalBlock();
            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));

        }

       

    }
}