using Microsoft.VisualStudio.TestTools.UnitTesting;
using vvs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vvs.Tests
{
    [TestClass()]
    public class LengthTests
    {
       

        [TestMethod()]
        public void VerboseTest()
        {
            var length = new Length(38, MeasureType.C);
            Assert.AreEqual("38 градус Цельсия", length.Verbose());

            length = new Length(38, MeasureType.F);
            Assert.AreEqual("38 градус Фаренгейта", length.Verbose());

            length = new Length(38, MeasureType.Ra);
            Assert.AreEqual("38 градус Ранкина", length.Verbose());

            length = new Length(38, MeasureType.K);
            Assert.AreEqual("38 Кельвинов", length.Verbose());
        }
        [TestMethod()]
        public void AddNumberTest()
        {
            var length = new Length(1, MeasureType.m);
            length = length + 4.25;
            Assert.AreEqual("5.25 м.", length.Verbose());
        }
    }
}