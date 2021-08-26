using GreetingRepo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace GreetingTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GreetingRepoSitory Repo = new GreetingRepoSitory();
            Repo.Add("dank", "the meme man", CustomerType.Past);
            Repo.Add("Chad", "Hammers-Clock", CustomerType.Potential);
            Repo.Add("Veronica", "Hammers-Clock", CustomerType.Current);

            Assert.AreEqual(Repo.GetCustomerByID(1).FirstName, "Chad");
            Repo.Delete(2);
            Assert.IsNull(Repo.GetCustomerByID(2));
            Repo.Update(1, CustomerType.Current);
            Repo.Update(0, "dan", "kallman", CustomerType.Past);
            Assert.AreEqual("kallman", Repo.GetCustomerByID(0).LastName);
            Assert.AreEqual(CustomerType.Current, Repo.GetCustomerByID(1).Type);
        }
    }
}
