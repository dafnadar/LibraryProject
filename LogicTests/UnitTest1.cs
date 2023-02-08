using BookLib;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace LogicTests
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Stopwatch stopwatch = new Stopwatch();
        private readonly ItemCollection logic = ItemCollection.Instance;

        [TestMethod] // what gets into report
        public void GetItemsTest() => Assert.IsTrue(logic.GetItems().Count() > 0);

        [TestMethod]
        public void GetItemsByTitle() => Assert.IsNotNull(logic.GetItemsByTitle(logic.GetItems(), "vvv"));        


        [TestMethod]
        public void PerformenceTest()
        {            
            stopwatch.Start();
            logic.GetItems();
            Assert.IsTrue(stopwatch.ElapsedMilliseconds < 100);
        }
    }
}
