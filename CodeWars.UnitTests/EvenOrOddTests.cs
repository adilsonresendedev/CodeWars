using CodeWars.Business;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
    public class EvenOrOddTests
    {
        private EvenOrOddBusiness _evenOrOddBusiness;
        [SetUp]
        public void Setup()
        {
            _evenOrOddBusiness = new EvenOrOddBusiness();
        }

        [Test]
        public void MyTest()
        {
            Assert.That(_evenOrOddBusiness.EvenOrOdd(2), Is.EqualTo("Even"));
            Assert.That(_evenOrOddBusiness.EvenOrOdd(1), Is.EqualTo("Odd"));
            Assert.That(_evenOrOddBusiness.EvenOrOdd(0), Is.EqualTo("Even"));
            Assert.That(_evenOrOddBusiness.EvenOrOdd(7), Is.EqualTo("Odd"));
            Assert.That(_evenOrOddBusiness.EvenOrOdd(-1), Is.EqualTo("Odd"));
        }
    }
}
