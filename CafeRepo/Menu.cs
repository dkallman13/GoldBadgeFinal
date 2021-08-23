using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRepo
{
    public class Menu
    {
        public List<Meal> _menuList { get; }
        //crud
        public bool Add(Meal meal)
        {
            int menulenght = _menuList.Count;
            _menuList.Add(meal);
            if (_menuList.Count > menulenght)
            {
                return true;
            }
            return false;
        }
        public bool Remove(int number)
        {
            int menulenght = _menuList.Count;
            _menuList.Remove(FindMealByNumber(number));
            if (_menuList.Count < menulenght)
            {
                return true;
            }
            return false;
        }
        public Meal FindMealByNumber(int number)
        {
            foreach (Meal meal in _menuList)
            {
                if (meal.Number == number)
                {
                    return meal;
                }
            }
            return null;
        }
        public Meal FindMealByName(string name)
        {
            foreach (Meal meal in _menuList)
            {
                if (meal.Name.Contains(name))
                {
                    return meal;
                }
            }
            return null;
        }
        public List<Meal> FindAllMeals()
        {
            List<Meal> menu = new List<Meal>();
            foreach (Meal meal in _menuList)
            {
                menu.Add(meal);
            }
            return menu;
        }
    }
}
