using GreetingRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GreetingUI
{
    public class GreetingUX
    {
        private GreetingRepoSitory Repo = new GreetingRepoSitory();
        public void Seed()
        {
            Repo.Add("dank", "the meme man", CustomerType.Past);
            Thread.Sleep(5);
            Repo.Add("Chad", "Hammers-Clock", CustomerType.Potential);
            Thread.Sleep(5);
            Repo.Add("Veronica", "Hammers-Clock", CustomerType.Current);
        }
        public void Run()
        {
            bool islooping = true;
            while (islooping)
            {
                Console.Clear();
                Console.WriteLine("Hello, what do you want to do?\n" +
                    "1. Show and send the messages\n" +
                    "2. Add user to database\n" +
                    "3. Update a User\n" +
                    "4. Remove a user\n" +
                    "5. exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SendMessages();
                        break;
                    case "2":
                        Add();
                        break;
                    case "3":
                        Update();
                        break;
                    case "4":
                        Delete();
                        break;
                    case "5":
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
        private void SendMessages()
        {
            Console.WriteLine("(id)Firstname     |     Lastname      |      Email");
            foreach (Customer person in Repo.CustomersDirectory)
            {
                if (person.Type == CustomerType.Current)
                {
                    Console.WriteLine($"({person.ID}){person.FirstName}          {person.LastName}          Thank you for your work with us. We appreciate your loyalty. Here's a coupon.");
                }
                else if (person.Type == CustomerType.Past)
                {
                    Console.WriteLine($"({person.ID}){person.FirstName}          {person.LastName}          It's been a long time since we've heard from you, we want you back.");
                }
                else
                {
                    Console.WriteLine($"({person.ID}){person.FirstName}          {person.LastName}          We currently have the lowest rates on Helicopter Insurance!");
                }
            }
        }
        private void Add()
        {
            Console.Clear();
            Console.WriteLine("Please enter the first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("please enter the last name.");
            string lastname = Console.ReadLine();
            Console.WriteLine("which type of user are they?\n" +
                "1. Current\n" +
                "2. Past\n" +
                "3. Potential");
            int usertypeindex = int.Parse(Console.ReadLine()) - 1;
            CustomerType usertype = (CustomerType)usertypeindex;

            Repo.Add(firstname, lastname, usertype);
        }
        private void Update()
        {
            SendMessages();
            Console.WriteLine("input the id of the user you wish to update");
            int id = int.Parse(Console.ReadLine());
            if (Repo.GetCustomerByID(id) != null)
            {
                Console.WriteLine($"{Repo.GetCustomerByID(id).FirstName} {Repo.GetCustomerByID(id).LastName} {Repo.GetCustomerByID(id).Type}");
                Console.WriteLine("update their name? (y/n)");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    Console.WriteLine("Please enter the first name");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("please enter the last name.");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("which type of user are they?\n" +
                        "1. Current\n" +
                        "2. Past\n" +
                        "3. Potential");
                    int usertypeindex = int.Parse(Console.ReadLine()) - 1;
                    CustomerType usertype = (CustomerType)usertypeindex;
                    Repo.Update(id, firstname, lastname, usertype);
                    Console.WriteLine("success");
                }
                else if (response == "n")
                {
                    Console.WriteLine("which type of user are they?\n" +
                       "1. Current\n" +
                       "2. Past\n" +
                       "3. Potential");
                    int usertypeindex = int.Parse(Console.ReadLine()) - 1;
                    CustomerType usertype = (CustomerType)usertypeindex;
                    Repo.Update(id, usertype);
                }
            }
            else
            {
                Console.WriteLine("please input one of the ids next time");
            }
        }
        public void Delete()
        {
            SendMessages();
            Console.WriteLine("input the id of the user you wish to update");
            int id = int.Parse(Console.ReadLine());
            if (Repo.GetCustomerByID(id) != null)
            {
                Repo.Delete(id);
                Console.WriteLine("successfully deleted the user");
            }
            else
            {
                Console.WriteLine("please input one of the ids next time");
            }
        }
    }
}
