using System;
using System.IO;
using System.Text;
using CleanCodeLabs.Codelab04;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab04Tests
    {
        private string _expectedResult;

        private StringBuilder _fakeOutput;

        [TestInitialize]
        public void Initialize()
        {
            _fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(_fakeOutput));

            var sb = new StringBuilder();
            sb.AppendLine("Doing some hard work, but I do get tired");
            sb.AppendLine("Working like a true working horse");
            sb.AppendLine("DOING SO MUCH WORK, BEEP");
            sb.AppendLine("Eating my 'bokes'");
            sb.AppendLine("Eating some jummy hay!");
            sb.AppendLine("RECHARGING BATTERIES, BEEP");
            _expectedResult = sb.ToString();
        }

        [TestMethod]
        public void TestFactory()
        {
            FactoryApp.Run();
            var output = _fakeOutput.ToString();
            Assert.AreEqual(_expectedResult, output);
        }
    }
}