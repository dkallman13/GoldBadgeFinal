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
        public void Seed()
        {
            List<string> number1Ingreds = new List<string>();
            number1Ingreds.Add("bun");
            number1Ingreds.Add("patty");
            number1Ingreds.Add("beeze");
            Meal number1 = new Meal(1, "BeezeChurger", "the great beezechurger", number1Ingreds, 3.99d);
            List<string> number2Ingreds = new List<string>();
            number2Ingreds.Add("bun");
            number2Ingreds.Add("patty");
            number2Ingreds.Add("foot lettuce");
            Meal number15 = new Meal(15, "burger king foot lettuce burger", "the last thing you would want in your burger king burger is somebody’s foot fungus", number2Ingreds, 2.99d);
        }
        public void Run()
        {

        }
    }
}
