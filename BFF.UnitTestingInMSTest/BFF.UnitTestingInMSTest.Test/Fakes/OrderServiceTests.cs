using System;
using BFF.UnitTestingInMsTest.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test.Fakes
{
    [TestClass]
    public class OrderServiceTests
    {
        private readonly FakeOrderRepository _repository;

        public OrderServiceTests()
        {
            this._repository = new FakeOrderRepository();
        }

        [TestMethod]
        public void GetOrder_AnyOrder_GetFromRepository()
        {
            // arrange
            var service = new OrderService(this._repository);
            var orderId = Guid.NewGuid();

            // act
            var order = service.GetOrder(orderId);

            // assert
            Assert.AreEqual(order.Id, orderId);
        }

        [TestMethod]
        public void SaveOrder_AnyOrder_SavesToRepository()
        {
            // arrange
            var service = new OrderService(this._repository);
            var order = new Order();
            order.Id = Guid.NewGuid();

            // act
            service.SaveOrder(order);

            // assert
            Assert.AreEqual(this._repository.SavedOrderId, order.Id);
        }
    }
}