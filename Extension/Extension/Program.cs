using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Extension
{
    public delegate string DisplayInt(int number);
    class Program
    {
        static void Main(string[] args)
        {

            DisplayInt wave = new DisplayInt(DisplayInfoMessage);
            wave(7);
            DisplayInfoMessage(7);

        }

        public static void DisplayInfoMessage()
        {
            Console.WriteLine("Infomaton about Player");
        }

        public static void DisplayInfoMessage(string Playername)
        {
            Console.WriteLine("Infomaton about Player : {0}", Playername);
        }

        public static void DisplayInfoMessage(string Playername, int goal)
        {
            Console.WriteLine("Infomaton about Player : Player's name is {0} and as scored {1} goals ", Playername, goal);
        }

        public static string DisplayInfoMessage(int number) 
        {
            string Playername = string.Empty;
            switch (number) 
            {
                case 4: Playername = "Gerrud"; break;
                case 10: Playername = "Messi"; break;
                case 7: Playername = "Ronaldo"; break;
                default: break;
            }
            return Playername;
         }

    }
   
 }

    

