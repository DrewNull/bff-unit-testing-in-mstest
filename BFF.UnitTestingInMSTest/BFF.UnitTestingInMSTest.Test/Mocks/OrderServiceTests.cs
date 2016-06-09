using System;
using BFF.UnitTestingInMsTest.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test.Mocks
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void SaveOrder_AnyOrder_SavesToRepository()
        {
            // arrange
            var mockRepository = new MockOrderRepository();
            var service = new OrderService(mockRepository); 
            var order = new Order();
            order.Id = Guid.NewGuid();

            // act
            service.SaveOrder(order);

            // assert
            Assert.AreEqual(mockRepository.SavedOrderId, order.Id);
        }
    }
}