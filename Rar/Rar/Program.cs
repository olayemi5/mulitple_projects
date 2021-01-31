using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rar
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw;
            string language = string.Empty;
            int count = Enum.GetNames(typeof(Languages)).Length;
            for (int i = 0; i < count; i++)
            {
               language =  Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
               Console.WriteLine(language);
                Directory.CreateDirectory(@"C:\Languages");
                Directory.CreateDirectory(@"C:\Languages\" + language);
                sw = new StreamWriter(@"C:\Languages\" + language + "\\log.txt");
                sw.WriteLine("FIle no " + i + " created on " + DateTime.Now);
                sw.Close();
                
            }  
        }
    }
    enum Languages 
    {
        English,
        Hindi,
        Yoruba,
        French,
        Latin,
        Greek,
        Igbo,
        Hausa,
        Egun,
        Igede,
        Arabic,
        Hebrew,
        Potugeese,
        Indian,
        Togo,
        Kenya
     }
}
