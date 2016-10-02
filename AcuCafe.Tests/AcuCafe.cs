using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcuCafe.Tests
{
    [TestClass]
    public class AcuCafe
    {

        [TestMethod]
        public void EspressoPriceCheck()
        {
            Espresso espresso = new Espresso();
            double drinkCost = espresso.Cost();
            Assert.IsTrue(drinkCost == 1.8);
        }

        [TestMethod]
        public void EspressoWithSugarPriceCheck()
        {
            Espresso espresso = new Espresso();
            double drinkCost = espresso.Cost();
            Sugar sugar = new Sugar(espresso);
            drinkCost += sugar.Cost();
            Assert.IsTrue(drinkCost == 2.3);
        }

        [TestMethod]
        public void HotTeaWithMilkAndSugarDescriptionCheck()
        {
            string description = "";
            HotTea tea = new HotTea();
            description = tea.Description;
            Assert.IsTrue(description == "Hot Tea");
            Milk milk = new Milk(tea);
            description += milk.Description;
            Assert.IsTrue(description == "Hot Tea + Milk");
            Sugar sugar = new Sugar(tea);
            description += sugar.Description;
            Assert.IsTrue(description == "Hot Tea + Milk + Sugar");
        }

        [TestMethod]
        public void PreventMilkWithIcedTea()
        {
            IcedTea icedTea = new IcedTea();
            Milk milk = new Milk(icedTea);
            Assert.IsTrue(milk.Exception != null);
            if (milk.Exception != null)
            {
                Assert.IsTrue(milk.Exception.Message == "Cannot add milk to iced tea!");
            }
        }


    }
}
