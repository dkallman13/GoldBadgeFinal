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
        public List<PossibleIngreds> Ingredients { get; }
        public double Price { get; }

        public Meal(int number, string name, string desc, List<PossibleIngreds> ingredientlist, double price)
        {
            Number = number;
            Name = name;
            Description = desc;
            Ingredients = ingredientlist;
            Price = price;
        }
    }
    public enum PossibleIngreds {lettuce, mayo, pickle, bun, patty, ketchup, mustard, onion, tomato, cheese, beeze, footlettuce}
}
