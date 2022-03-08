using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Spider";
            int age = 100;
            float hight = 1.9f;
            char gender = 'M';
            string heroPower1, heroPower2, heroPower3;
            heroPower1 = "Can jump";
            heroPower2 = "Knows 20 languages";
            heroPower3 = "Can be invisable";
            double salary = 1000;
            bool isEvil = false;
            int deedTimeInHours1 = 20;
            int deedTimeInHours2 = 40;
            int deedTimeInHours3 = 100;
            int cookieCost = 5;

            Console.WriteLine("**************************************");
            Console.WriteLine($"Hero: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Hight: {hight}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine("**************************************");


            // Cookie calculation

            Console.WriteLine("*************Additional info************************");

            var TimeonDeed = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
            Console.WriteLine($"Spider spends total {TimeonDeed} hours on deeds");

            var monthlySalary= TimeonDeed * cookieCost;
            Console.WriteLine($"Our hero earns {monthlySalary} cookies per month");
            
            var AverageTimeonDeed = TimeonDeed / 3;
            Console.WriteLine($"He spends average {AverageTimeonDeed} hours on deeds");

            var boughtCookies = monthlySalary / cookieCost;
            Console.WriteLine($"Spider can buy {boughtCookies} cookies");
            
            if (!isEvil)
            {
                Console.WriteLine("Spider is not an evil, he protects the city");
            }
            Console.WriteLine("*******************************************************");
            Console.ReadLine();
        }
    }
}