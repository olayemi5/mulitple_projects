using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace African2020
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add("Sis Kehinde Family");
            array.Add("Olayemi Stephen");
            array.Add("Obada Taiwo");
            array.Add("Olayemi Temitope");
            array.Add("Seun Ajibade");
            array.Add("Biodun Kehinde");
            array.Add("Faith Obada");
            array.Add("kakaki");
            array.Add("Jemmy 22");
            array.Add("Christopher");
            array.Add("Jumoke Ominado");
            array.Add("The Dentons");
            array.Add("Williams");
            array.Add("Adeshina");
            array.Add("Oluwafemi");
            array.Add("Faith Iya Kano");
            array.Add("Aknishenide");
            array.Add("Obada");
            array.Add("Eddy");
            array.Add("Olayemi Thywill");
            array.Add("Abel Family \n");

            Hashtable MemberInfo = new Hashtable();
            MemberInfo.Add("Stephen","08058195689");
            MemberInfo.Add("Obada Faith","07055777219");
            MemberInfo.Add("Olayemi Temitope", "0220061088");
            
            Return:
            Console.WriteLine("AFRICAN NIGHT OF PRAISE 2020 \n");
            Console.WriteLine(DateTime.Today + "\n");
            Console.WriteLine("Click 'Yes' to access names of Vision Patners \n ");
            
            var input = Console.ReadLine();
            if(input == "Yes") 
            {
                Console.WriteLine("Enter Passcode \n");

                int inlet = 0;
                int.TryParse(Console.ReadLine(), out inlet);
                if (inlet == 0)
                    Console.WriteLine("You have entered wrong input");


                else if (inlet == 12345)
                {
                    foreach (var names in array)
                    {

                        Console.WriteLine("\n" + names);
                    
                    foreach (DictionaryEntry item in MemberInfo)
                    {
                        Console.WriteLine(item.Key + ":" + " " + item.Value + "\n");
                    }
                }
                else if (inlet != 12345)
                    Console.WriteLine("Wrong Passcode");
                else
                    Console.WriteLine("Invalid Input");


            }
            else if(input == "yes") 
             {
                Console.WriteLine("Enter passcode \n");
                int inlet = 0;
                int.TryParse(Console.ReadLine(), out inlet);
                if (inlet == 0)
                    Console.WriteLine("You have entered wrong input");


                else if (inlet == 12345)
                {
                    foreach (var names in array)
                    {

                        Console.WriteLine("\n" + names);
                    }
                    foreach (DictionaryEntry item in MemberInfo)
                    {
                        Console.WriteLine(item.Key + ":" + " " + item.Value + "\n");
                    }
                }
                else if (inlet != 12345)
                    Console.WriteLine("Wrong Passcode");
                else
                    Console.WriteLine("Invalid Input");


            }
            else if (input == "YES") 
              {
                Console.WriteLine("Enter Passcode: \n");
                int inlet = 0;
                int.TryParse(Console.ReadLine(), out inlet);
                if (inlet == 0)
                    Console.WriteLine("You have entered wrong input");


                else if (inlet == 12345)
                {
                    foreach (var names in array)
                    {

                        Console.WriteLine("\n" + names);
                    }
                    foreach (DictionaryEntry item in MemberInfo)
                    {
                        Console.WriteLine(item.Key + ":" + " " + item.Value + "\n");
                    }
                }
                else if (inlet != 12345)
                    Console.WriteLine("Wrong Passcode");
                else
                    Console.WriteLine("Invalid Input");


            }
            else if (input == "No") 
              {
                Console.WriteLine("'INPUT No' Thanks!");
                goto Return;
               }

               else if (input == "no") 
               {
                Console.WriteLine("'INPUT no' Thanks!");
            }
                else if (input == "NO") 
                {
                Console.WriteLine("'INPUT NO' Thanks!");
                goto Return;
            }
                 else { 
                Console.WriteLine("Invalid Input");
                goto Return;
            }

        }
       

    }
}
