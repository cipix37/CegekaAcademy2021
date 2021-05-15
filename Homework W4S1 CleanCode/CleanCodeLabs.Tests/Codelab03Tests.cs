using System;
using System.IO;
using System.Text;
using CleanCodeLabs.Codelab03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CleanCodeLabs.Tests
{
    [TestClass]
    public class Codelab03Tests
    {
        private string _expectedResult;
        private StringBuilder _fakeOutput;

        [TestInitialize]
        public void Initialize()
        {
            _fakeOutput = new StringBuilder();
            Console.SetOut(new StringWriter(_fakeOutput));

            var sb = new StringBuilder();
            sb.AppendLine("Quack...");
            sb.AppendLine("Quack Quack... (in a robot voice)");
            sb.AppendLine("Swim...");
            _expectedResult = sb.ToString();
        }

        [TestMethod]
        public void TestDuckApplication()
        {
            DuckApplication.Start();
            Assert.AreEqual(_expectedResult, _fakeOutput.ToString());
        }
    }
}