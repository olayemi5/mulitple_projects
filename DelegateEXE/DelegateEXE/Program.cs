using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEXE
{

    public delegate void DisplayPlayerName(Dictionary<int,string> PlayerInfo);
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> listOfplayers = new Dictionary<int, string>();
            listOfplayers.Add(7, "Messi");
            listOfplayers.Add(10, "Ronaldo");
            listOfplayers.Add(6, "Gerrude");
            listOfplayers.Add(4, "Block");

            DisplayPlayerName Info = new DisplayPlayerName(DisplatInfo);
            Info(listOfplayers);
           
        }

        public static void  DisplatInfo(Dictionary<int,string>PlayerInfo)
        {
            foreach (var player in PlayerInfo)
            {
                Console.WriteLine("Player No is: {0}  and player name is: {1}  ",player.Key, player.Value);
            } 
        }
    }
}
