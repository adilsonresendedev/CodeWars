using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Business;

namespace CodeWars.UnitTests
{
    public class StringBusinessTests
    {
        private StringBusiness _stringBusiness;

        [SetUp]
        public void Setup()
        {
            _stringBusiness = new StringBusiness();
        }

        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", _stringBusiness.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", _stringBusiness.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", _stringBusiness.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", _stringBusiness.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", _stringBusiness.Remove_char("ok"));
        }
    }
}
