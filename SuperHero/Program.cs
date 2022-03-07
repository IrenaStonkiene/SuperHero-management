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
            char gender = "M";
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
            Console.WriteLine($"hight: {hight}");
            Console.WriteLine($"gender: {gender}");
            Console.WriteLine("**************************************");


            // Cookie calculation

            Console.WriteLine("*************Additional info************************");

            var TimeonDeed = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
            Console.WriteLine($"Spider spends total hours on deeds: {TimeonDeed}");

            var monthlySalary= TimeonDeed * cookieCost;
            Console.WriteLine($"Spider earns Cookies: {monthlySalary}");
            
            var AverageTimeonDeed = TimeonDeed / 3;
            Console.WriteLine($"Spider spends avergae time on deed is: {AverageTimeonDeed}");

            var boughtCookies = monthlySalary / cookieCost;
            Console.WriteLine($"Spider can buy {boughtCookies}");
            
            if (!isEvil)
            {Console.WriteLine("Spider protects the city")};
            Console.WriteLine("*******************************************************");
