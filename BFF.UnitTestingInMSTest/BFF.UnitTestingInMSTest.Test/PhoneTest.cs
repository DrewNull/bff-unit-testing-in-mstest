using System;
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
        public void AlphanumericToPhoneNumber_HasValidPhoneWord_ReturnsAllNumbers()
        {
            // arrange
            var expectedNumber = "18002257878";
            var alphanumericPhone = "1-800-CAL-RTPT";

            // act
            var result = TestPhone.AlphanumericToPhoneNumber(alphanumericPhone);

            // assert
            Assert.IsTrue(String.CompareOrdinal(expectedNumber, result) == 0);
        }
    }
}
