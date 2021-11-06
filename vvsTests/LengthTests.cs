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
            var length = new Length(1, MeasureType.C);
            length = length + 4.25;
            Assert.AreEqual("5,25 градус Цельсия", length.Verbose());
        }
        [TestMethod()]
        public void SubNumberTest()
        {
            var length = new Length(3, MeasureType.C);
            length = length - 1.75;
            Assert.AreEqual("1,25 градус Цельсия", length.Verbose());
        }
        [TestMethod()]
        public void MeterToAnyTest()
        {
            Length length;

            length = new Length(1, MeasureType.C);
            Assert.AreEqual("32 градус Фаренгейта", length.To(MeasureType.F).Verbose());

            length = new Length(1, MeasureType.C);
            Assert.AreEqual("491,67 градус Ранкина", length.To(MeasureType.Ra).Verbose());

            length = new Length(1, MeasureType.C);
            Assert.AreEqual("273,15 Кельвинов", length.To(MeasureType.K).Verbose());

            length = new Length(32, MeasureType.F);
            Assert.AreEqual("1 градус Цельсия", length.To(MeasureType.C).Verbose());

            length = new Length(491.67, MeasureType.Ra);
            Assert.AreEqual("1 градус Цельсия", length.To(MeasureType.C).Verbose());

            length = new Length(273.15, MeasureType.K);
            Assert.AreEqual("1 градус Цельсия", length.To(MeasureType.C).Verbose());
        }
        [TestMethod()]
        public void AddSubFCTest()
        {
            var C = new Length(1, MeasureType.C);
            var F = new Length(32, MeasureType.F);

            Assert.AreEqual("2 градус Цельсия", (C + F).Verbose());
            Assert.AreEqual("64 градус Фаренгейта", (F + C).Verbose());

            Assert.AreEqual("0 градус Фаренгейта", (F - C).Verbose());
            Assert.AreEqual("0 градус Цельсия", (C - F).Verbose());
        }
    }
}