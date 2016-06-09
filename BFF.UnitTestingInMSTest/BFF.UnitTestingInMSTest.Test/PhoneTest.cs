using System;
using System.Threading;
using BFF.UnitTestingInMsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test
{
    [TestClass]
    public class PhoneTest
    {
        private Phone TestPhone;

        public PhoneTest()
        {
            TestPhone = new Phone();            
        }

        [TestMethod]
        public void VanityToPhoneNumber_HasValidPhoneWord_ReturnsAllNumbers()
        {
            // arrange
            var expectedNumber = "18002257878";
            var alphanumericPhone = "1-800-CAL-RTPT";

            // act
            var result = TestPhone.VanityToPhoneNumber(alphanumericPhone);

            // assert
            Assert.IsTrue(String.CompareOrdinal(expectedNumber, result) == 0);
        }

        [TestMethod]
        public void VanityToPhoneNumber_HasLongVanity_ReturnsStandardLengthPhoneNumber()
        {
            // arrange
            var expectedNumber = "18002255744";
            var vanityPhone = "1-800-CALLRIGHTPOINT";

            // act
            var result = TestPhone.VanityToPhoneNumber(vanityPhone);

            // assert
            Assert.IsTrue(string.CompareOrdinal(expectedNumber, result) == 0);
        }
    }
}
