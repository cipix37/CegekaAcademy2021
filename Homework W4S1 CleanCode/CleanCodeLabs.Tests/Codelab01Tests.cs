using CleanCodeLabs.Codelab01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab01Tests
    {
        [TestMethod]
        public void TestCarManager()
        {
            var carDatabase = new CarDatabase();
            var carManager = new CarManager(carDatabase);

            Assert.AreEqual("Volkswagen Golf III, Fiat Multipla, Renault Megane", carManager.GetCarsNames());
            Assert.AreEqual("Multipla", carManager.GetBestCar().Model);
            Assert.AreEqual("Renault", carDatabase.GetCarByID("3").Brand);
        }
    }
}