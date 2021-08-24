using CafeRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CafeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<PossibleIngreds> number1Ingreds = new List<PossibleIngreds>();
            number1Ingreds.Add(PossibleIngreds.bun);
            number1Ingreds.Add(PossibleIngreds.beeze);
            number1Ingreds.Add(PossibleIngreds.patty);
            Meal number1 = new Meal(1, "BeezeChurger", "the great beezechurger", number1Ingreds, 3.99d);
            Menu menu = new Menu();

            List<PossibleIngreds> number15Ingreds = new List<PossibleIngreds>();
            number15Ingreds.Add(PossibleIngreds.bun);
            number15Ingreds.Add(PossibleIngreds.patty);
            number15Ingreds.Add(PossibleIngreds.footlettuce);
            Meal number15 = new Meal(15, "burger king foot lettuce burger", "the last thing you would want in your burger king burger is somebody’s foot fungus", number15Ingreds, 2.99d);

            //test that it is added and that the findmealbynumber actually finds the right meal
            menu.Add(number15);
            menu.Add(number1);
            Assert.AreEqual(number1.Name, menu.FindMealByNumber(1).Name);
            Assert.AreEqual(number1.Description, menu.FindMealByNumber(1).Description);
            Assert.AreEqual(number1.Price, menu.FindMealByNumber(1).Price);
            Assert.AreEqual(number1.Ingredients, menu.FindMealByNumber(1).Ingredients);

            //test the other half of methods, the findmealbyname and remove function
            Assert.AreEqual(number15.Name, menu.FindMealByName("burger king foot lettuce burger").Name);
            Assert.AreEqual(number15.Description, menu.FindMealByName("burger king foot lettuce burger").Description);
            Assert.AreEqual(number15.Price, menu.FindMealByName("burger king foot lettuce burger").Price);
            Assert.AreEqual(number15.Ingredients, menu.FindMealByName("burger king foot lettuce burger").Ingredients);

            menu.Remove(15);
            Assert.IsNull(menu.FindMealByNumber(15));
            //not exactly sure how to test the last function since it returns a private variable in the menu class. but i can verify manually that it works

        }
    }
}
