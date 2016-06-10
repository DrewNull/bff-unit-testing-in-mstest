using System;
using BFF.UnitTestingInMsTest.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test.Mocks
{
    [TestClass]
    public class OrderServiceTestsWithMocks
    {
        [TestMethod]
        public void SubmitOrder_ValidOrder_CallsSaveOrder()
        {
            // arrange
            var mockRepository = new MockOrderRepository();
            var stubValidator = new StubOrderValidator(true);
            var service = new OrderService(mockRepository, stubValidator);
            var order = new Order
            {
                Id = Guid.NewGuid()
            };

            // act
            service.SubmitOrder(order);

            // assert
            Assert.IsNotNull(mockRepository.SavedOrder);
            Assert.AreEqual(mockRepository.SavedOrder.Id, order.Id);
        }

        [TestMethod]
        public void SubmitOrder_InvalidOrder_DoesNotCallSaveOrder()
        {
            // arrange
            var mockRepository = new MockOrderRepository();
            var stubValidator = new StubOrderValidator(false);
            var service = new OrderService(mockRepository, stubValidator);
            var order = new Order
            {
                Id = Guid.NewGuid()
            };

            // act
            service.SubmitOrder(order);

            // assert
            Assert.IsNull(mockRepository.SavedOrder);
        }
    }
}