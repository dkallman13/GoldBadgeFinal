using BadgesClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BadgeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BadgeRepo Repo = new BadgeRepo();
            List<string> zero = new List<string>();
            zero.Add("front");
            zero.Add("back");
            zero.Add("side");
            zero.Add("otherside");
            Badge badge0 = new Badge(0, zero);
            Assert.IsTrue(Repo.AddBadge(badge0));

            List<string> zero_1 = zero;
            zero_1.Remove("side");
            Repo.UpdateDoors(0, zero_1);
            CollectionAssert.AreEquivalent(zero_1, Repo.GetBadges()[0].DoorAccess);
            Repo.RevokeDoorAccess(0);
            CollectionAssert.AreEquivalent(new List<string>(), Repo.GetBadges()[0].DoorAccess);

        }
    }
}
