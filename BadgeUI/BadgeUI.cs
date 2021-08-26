using BadgesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeUI
{
    public class BadgeUI
    {
        private BadgeRepo Repo { get; set; } = new BadgeRepo();
        public void Seed()
        {
            List<string> zero = new List<string>();
            zero.Add("front");
            zero.Add("back");
            zero.Add("side");
            zero.Add("otherside");
            Badge badge0 = new Badge(0, zero);
            Repo.AddBadge(badge0);
            List<string> one = new List<string>();
            one.Add("front");
            one.Add("back");
            one.Add("side");
            Badge badge1 = new Badge(1, one);

            Repo.AddBadge(badge1);
        }
        public void Run()
        {
            bool islooping = true;
            while (islooping)
            {
                Console.Clear();
                Console.WriteLine("Hello, what would you like to do mr admin?\n" +
                    "1. List Badges\n" +
                    "2. Add a Badge\n" +
                    "3. Update a Badge\n" +
                    "4. Revoke a Badge's door access\n" +
                    "5. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ListBadges();
                        break;
                    case "2":
                        AddBadge();
                        break;
                    case "3":
                        ListBadges();
                        Console.WriteLine("Which badge do you want to update?");
                        string number = Console.ReadLine();
                        UpdateBadge(int.Parse(number));
                        break;
                    case "4":
                        ListBadges();
                        Console.WriteLine("Which badge do you want to revoke access?");
                        string number2 = Console.ReadLine();
                        Revoke(int.Parse(number2));
                        break;
                    case "5":
                        Console.WriteLine("alright, see you later!");
                        islooping = false;
                        break;
                    default:
                        Console.WriteLine("please enter a number from 1-5");
                        break;
                }
                Console.ReadKey();
            }

        }
        private void ListBadges()
        {
            Console.Clear();
            Dictionary<int, Badge> badgeDict = Repo.GetBadges();
            Console.WriteLine("badge number    |    door access");

            for (int i = 0; i < badgeDict.Count; i++)
            {
                string doors = "";
                foreach (string door in badgeDict[i].DoorAccess)
                {
                    doors += door + " ";
                }
                Console.WriteLine($"{i}     |     {doors}");
            }

        }
        private void AddBadge()
        {
            List<string> doors = new List<string>();
            bool isaddingdoors = true;
            while (isaddingdoors)
            {
                Console.WriteLine("input a door to add access to it");
                doors.Add(Console.ReadLine());
                Console.WriteLine("continue adding doors? y/n");
                string response = Console.ReadLine().ToLower();
                if (response != "y" && !string.IsNullOrEmpty(response) && !string.IsNullOrWhiteSpace(response))
                {
                    isaddingdoors = false;
                }
            }
            int length = Repo.GetBadges().Count;
            Repo.AddBadge(new Badge(length, doors));
        }
        private void UpdateBadge(int number)
        {
            List<string> doors = Repo.GetBadges()[number].DoorAccess;
            bool isaddingdoors = true;
            while (isaddingdoors)
            {
                Console.Clear();
                foreach (string door in doors)
                {
                    Console.WriteLine(door);
                }
                Console.WriteLine("input a door to add/remove access to it");

                string selection = Console.ReadLine();

                bool match = false;
                foreach (string door in doors)
                {
                    if (door == selection)
                    {
                        doors.Remove(door);
                        match = true;
                        break;
                    }
                }
                if (!match)
                {
                    doors.Add(selection);
                }
                Console.WriteLine("continue adding/removing doors? y/n");
                string response = Console.ReadLine().ToLower();
                if (response != "y" && !string.IsNullOrEmpty(response) && !string.IsNullOrWhiteSpace(response))
                {
                    Repo.UpdateDoors(number, doors);
                    isaddingdoors = false;
                }
            }
        }
        private void Revoke(int number)
        {
            Repo.RevokeDoorAccess(number);

        }
    }
}
