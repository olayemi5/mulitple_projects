using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.IO;

namespace LangFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Lang)).Length;
            for (int i = 0; i < count; i++)
            {

                language = Enum.GetValues(typeof(Lang)).GetValue(i).ToString();
                Console.WriteLine(language);
                Directory.CreateDirectory(@"C:\Enum");
                Directory.CreateDirectory(@"C:\Enum\" + language );
                sw = new StreamWriter("C:\\Enum\\" + language +  " \\log.txt");
                sw.WriteLine("File no " + i + " Created on " + DateTime.Now);
                sw.Close();
            }
        }
    }
    enum Lang 
    {
        English,    
        Yoruba,
        Igbo,
        Hausa,
        Egun,
        Togo,
        Ghana,
        Hebrew,
        Tivi,
        German,
        Arabic,
        Chineese
     }
}
