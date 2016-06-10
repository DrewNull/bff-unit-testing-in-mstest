using System;
using System.Linq;
using System.Threading;
using BFF.UnitTestingInMsTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test
{
    [TestClass]
    public class PhoneTest
    {
        private Phone _testPhone;

        [TestInitialize]
        public void PhoneTestInitialize()
        {
            _testPhone = new Phone();

            // Some more startup stuff ...
        }

        [TestCleanup]
        public void PhoneTestCleanup()
        {
            _testPhone = null;

            // Whatever other cleanup you need
        }

        [TestMethod]
        public void VanityToPhoneNumber_HasValidPhoneWord_ReturnsAllNumbers()
        {
            // arrange
            var expectedNumber = "18002255778";
            var alphanumericPhone = "1-800-CALL-RPT";

            // act
            var result = _testPhone.VanityToPhoneNumber(alphanumericPhone);

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
            var result = _testPhone.VanityToPhoneNumber(vanityPhone);

            // assert
            Assert.IsTrue(string.CompareOrdinal(expectedNumber, result) == 0);
        }

        [TestMethod]
        public void AddPhoneToContact_AddNewPhoneWithNoExistingPhoneNumbers_ReturnsOnlyOnePhoneNumber()
        {
            // arrange
            var phone = "1-800-CALL-RPT";

            // act
            var result = _testPhone.AddPhoneToContact(phone, new Contact());

            // assert
            Assert.AreEqual(1, result.PhoneNumbers.Count);
        }

        [TestMethod]
        public void AddPhoneToContact_AddNewPhoneWithExistingPhoneNumbers_ReturnsPhoneNumbersPlusOne()
        {
            // arrange
            var phone = "1-800-CALL-RPT";
            var contact = new Contact()
            {
                Name = "Jimmy",
                Notes = "App Dev",
                PhoneNumbers =
                {
                    "18002255744"
                }
            };

            // act
            var result = _testPhone.AddPhoneToContact(phone, contact);

            // assert
            Assert.AreEqual(2, result.PhoneNumbers.Count);
        }

        [TestMethod]
        public void AddPhoneToContact_AddIdenticalPhoneWithExistingPhoneNumber_ReturnsNoNoNumbers()
        {
            // arrange
            var phone = "1-800-CALL-RPT";
            var contact = new Contact()
            {
                Name = "Jimmy",
                Notes = "App Dev",
                PhoneNumbers =
                {
                    "18002255744",
                    "18002255778"
                }
            };

            // act
            var result = _testPhone.AddPhoneToContact(phone, contact);

            // assert
            Assert.AreEqual(2, result.PhoneNumbers.Count);
        }
    }
}
