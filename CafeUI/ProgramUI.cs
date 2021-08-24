using CafeRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class ProgramUI
    {
        private Menu menu = new Menu();
        public void Seed()
        {
            List<PossibleIngreds> number1Ingreds = new List<PossibleIngreds>();
            number1Ingreds.Add(PossibleIngreds.bun);
            number1Ingreds.Add(PossibleIngreds.beeze);
            number1Ingreds.Add(PossibleIngreds.patty);
            Meal number1 = new Meal(1, "BeezeChurger", "the great beezechurger", number1Ingreds, 3.99d);
            List<PossibleIngreds> number2Ingreds = new List<PossibleIngreds>();
            number2Ingreds.Add(PossibleIngreds.bun);
            number2Ingreds.Add(PossibleIngreds.patty);
            number2Ingreds.Add(PossibleIngreds.footlettuce);
            Meal number15 = new Meal(15, "burger king foot lettuce burger", "the last thing you would want in your burger king burger is somebody’s foot fungus", number2Ingreds, 2.99d);
            menu.Add(number1);
            menu.Add(number15);
        }
        public void Run()
        {
            bool islooping = true;
            while (islooping)
            {
                Console.Clear();
                Console.WriteLine("Hello, what do you want to do?\n" +
                    "1. show all meals\n" +
                    "2. add a meal\n" +
                    "3. remove a meal\n" +
                    "4. exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ShowMeals();
                        break;
                    case "2":

                        break;
                    case "3":
                        ShowMeals();
                        Console.WriteLine("which meal do you want to remove? (put its number)");
                        string number = Console.ReadLine();
                        RemoveMeal(number);
                        break;
                    case "4":
                        Console.WriteLine("alright, see you later!");
                        islooping = false;
                        break;
                    default:
                        Console.WriteLine("please enter a number from 1-4");
                        break;
                }
                Console.ReadKey();
            }
        }
        public void ShowMeals()
        {

            List<Meal> mealmenu = menu.FindAllMeals();
            Console.WriteLine("number    |          name           |               price");
            foreach (Meal meal in mealmenu)
            {
                Console.WriteLine($"{meal.Number}        |        {meal.Name}       |      {meal.Price}");
            }
        }
        public void RemoveMeal(string number)
        {
            int numberint = int.Parse(number);
            if (menu.Remove(numberint))
            {
                Console.WriteLine("successfully removed meal from menu.");
            }
            else
            {
                Console.WriteLine("there was an error removing the meal from the menu.");
            }

        }
        public void AddMeal()
        {
            Console.WriteLine("input the number for the meal");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("input the name of the meal");
            string name = Console.ReadLine();
            Console.WriteLine("input a description of the meal");
            string desc = Console.ReadLine();

        }
    }
}
