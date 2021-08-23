using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo
{
    public class Meal
    {
        public int Number { get; }
        public string Name { get; }
        public string Description { get; }
        public List<string> Ingredients { get; }
        public double Price { get; }

        public Meal(int number, string name, string desc, List<string> ingredientlist, double price)
        {
            Number = number;
            Name = name;
            Description = desc;
            Ingredients = ingredientlist;
            Price = price;
        }
    }
}
