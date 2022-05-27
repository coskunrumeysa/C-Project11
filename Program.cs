//Beni Yaratan Elbet Yolumu Gösterir .Şuara -78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country;
            string town;
            string name;
            string surname;
            double weight;
            weight = 58.90;

            Console.WriteLine("Please enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your surname :");
            surname = Console.ReadLine();
            Console.WriteLine("Your weight" + " " + weight);
            Console.WriteLine("Please enter your country:");
            country = Console.ReadLine();
            Console.WriteLine("Please enter your town :");
            town = Console.ReadLine();
            Console.WriteLine("Your Name:" +" "+name);
            Console.WriteLine("Your surname:" + " " + surname);
            Console.WriteLine("Your Country:" + " " + country);
            Console.WriteLine("Your Town:" + " " + town);
            Console.Read();


        }
    }
}
