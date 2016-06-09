using System;
using BFF.UnitTestingInMsTest.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test.Stubs
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void GetOrder_AnyOrder_GetsFromRepository()
        {
            // arrange
            var stubRepository = new StubOrderRepository();
            var service = new OrderService(stubRepository);
            var orderId = Guid.NewGuid();

            // act
            var order = service.GetOrder(orderId);

            // assert
            Assert.AreEqual(order.Id, orderId);
        }
    }
}