using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Tests
{
 [TestFixture]
    public class SimpleCalculatorTests
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var result = sut.Add(1, 3);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();
            var result = sut.Multiply(2, 3);
            Assert.That(result,Is.EqualTo(6));

        }

    }
}
