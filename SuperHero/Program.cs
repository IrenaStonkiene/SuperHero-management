using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperHero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroNameList = { "1. Spider","2. Superman","3. Supergirl","4. Batman" };
            int [] superHeroage = { "20", "30", "60", "75" };
            string[] superPower1 = {"Jump", "Run", "Swim", "Fly" };
            string[] superPower2 = {"Be invisable", "Speak 100 languages", "Can read others mind", "Can transform to other person"}
            int[] salaryPerMonth = {"1000", "2000", "3000", "4000"}


            bool isMenuRunning = true;
            do
            {
                string menuItems;

                Console.WriteLine($"Welcome to the superhero application!");
                Console.WriteLine($"Select what to do:");
                Console.WriteLine($"1 - Show a list of superheroes");
                Console.WriteLine($"2 - Show specific hero");
                Console.WriteLine($"3 - Adding a superhero");
                Console.WriteLine($"4 - Deleting a superhero");
                Console.WriteLine($"5 - Exit");

                menuItems = Console.ReadLine();

                switch (menuItems)
                {
                    case "1":
                        Console.WriteLine("============List=of=superheroes============");
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }
                        Console.WriteLine("===========================================");
                        break;
                    case "2":
                        Console.WriteLine($"Please choose a superhero by number");
                        for (int i = 0; i < superHeroNameList.Length; i++)
                        {
                            Console.WriteLine($"{i}. {superHeroNameList[i]}");
                        }
                        int.TryParse(Console.ReadLine(), out int chosenNumber);
                        Console.WriteLine($"You have chosen {superHeroNameList[chosenNumber]}");

                        Console.WriteLine("Choose what type of info to show");
                        Console.WriteLine($"1 - GENERAL INFO");
                        Console.WriteLine($"2 - FINANCIAL INFO");
                        string showMenu = Console.ReadLine();
                        if (showMenu == "1")
                        {
                            Console.WriteLine("*********************GENERAL INFO******************");
                            Console.WriteLine($"Hero: {superHeroNameList[chosenNumber]}");
                            for (int i = 0; i < superHeroNameList.Length; i++)
                            {
                                string str = Console.ReadLine();
                            }
                            Console.WriteLine($"Age: "{superHeroage[chosenNumber]}" year old");
                            Console.WriteLine($"Hero powers: \n {superPower1[chosenNumber]}, \n {superPower2[chosenNumber]}");
                            Console.WriteLine("******************************************** \n \n");

                        }else if(showMenu == "2")
                        {
                            double salary = 1000;
                            int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3;
                            deedTimeInHours1 = 5;
                            deedTimeInHours2 = 10;
                            deedTimeInHours3 = 15;
                            var totalTimeSpent = (deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3);
                            double rewardMoney = totalTimeSpent * 5;
                            salary += rewardMoney;
                            var averageTime = totalTimeSpent / 3;

                            double cookieCost = 1.29;
                            double boughtCookies = Math.Floor(salary / cookieCost);
                            double dailySalary = Math.Round(salary / 30, 2);


                            Console.WriteLine("************FINANCIAL INFO*****************");
                            Console.WriteLine($"SuperHero earns {salaryPerMonth[chosenNumber]} Eur per month");
                            Console.WriteLine($"The hero can buy {boughtCookies}");
                            Console.WriteLine($"Our hero earns daily {dailySalary}");
                            Console.WriteLine($"Our hero spent {totalTimeSpent} hours doing deeds");
                            Console.WriteLine($"Our hero on average spent {averageTime} hours per deed");
                            Console.WriteLine($"For the deeds our hero got as a reward {rewardMoney} EUR");
                        }
                        break;
                    case "3":
                        Console.WriteLine("What is the new superhero name?");
                        string superHeroName = Console.ReadLine();
                        superHeroNameList = superHeroNameList.Append(superHeroName);
                        Console.WriteLine($"SuperHero {superHeroName} Added!");
                        break;
                    case "4":
                        superHeroNameList = superHeroNameList.Remove(3);
                        break;
                    case "5":
                        isMenuRunning = false;
                        Console.WriteLine($"Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please choose from the available menu!");
                        break;
                }
            } while (isMenuRunning);

/*

            string name = "Spider";
            int age = 100;
            float hight = 1.9f;
            char gender = 'M';
            string heroPower1, heroPower2, heroPower3;
            heroPower1 = "Can jump";
            heroPower2 = "Knows 20 languages";
            heroPower3 = "Can be invisable";
            double salary1 = 1000;
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

            Console.WriteLine();
            Console.WriteLine("*************Spider's Powers**********")
            Console.WriteLine($"Spider has such powers: {heroPower1}, {heroPower2}, {heroPower3}");
            Console.WriteLine();

            Console.WriteLine("*************Additional info************************");

            var TimeonDeed = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
            Console.WriteLine($"Spider spends total {TimeonDeed} hours on deeds");

            var monthlySalary1= TimeonDeed * cookieCost;
            Console.WriteLine($"Our hero earns {monthlySalary1} cookies per month");
            
            var AverageTimeonDeed = TimeonDeed / 3;
            Console.WriteLine($"He spends average {AverageTimeonDeed} hours on deeds");

            var boughtCookies = monthlySalary1 / cookieCost;
            Console.WriteLine($"Spider can buy {boughtCookies} cookies");
            
            if (!isEvil)
            {
                Console.WriteLine("Spider is not an evil, he protects the city");
            }
            Console.WriteLine("*******************************************************");
            Console.ReadLine();*/
        }
    }
}



//  BUSINESS REQUIREMENTS
// 1. I would like to see a menu, to select different parts of superhero information card
// 2. A list of superheroes - arrays/ maybe lists
// 3, Add a new superhero
// 4. Showing a specific superhero information
// 5. Delete the superhero from the list