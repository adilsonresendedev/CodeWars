using CodeWars.Business;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.UnitTests
{
    public class SmallestBusinessTests
    {
        private SmallestBusiness _smallestBusiness;
        [SetUp]
        public void Setup()
        {
            _smallestBusiness = new SmallestBusiness();
        }

        [Test]
        [TestCase(new int[] { 78, 56, 232, 12, 11, 43 }, ExpectedResult = 11)]
        [TestCase(new int[] { 78, 56, -2, 12, 8, -33 }, ExpectedResult = -33)]
        public int FixedTest(int[] args)
        {
            return _smallestBusiness.FindSmallestInt(args);
        }
    }
}
