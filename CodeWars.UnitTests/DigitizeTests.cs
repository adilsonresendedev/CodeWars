using CodeWars.Business;
using NUnit.Framework;

namespace CodeWars.UnitTests
{
    public class DigitizeTests
    {
        DigitizeBusiness DigitizeBusiness = new DigitizeBusiness();

        [Test]
        public void MyTest()
        {
            Assert.That(DigitizeBusiness.Digitize(35231), Is.EqualTo(new long[] { 1, 3, 2, 5, 3 }));
            Assert.That(DigitizeBusiness.Digitize(0), Is.EqualTo(new long[] { 0 }));
        }
    }
}
