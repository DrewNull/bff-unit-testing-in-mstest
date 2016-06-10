using System;
using BFF.UnitTestingInMsTest.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test.Fakes
{
    [TestClass]
    public class OrderServiceTestsWithFakes
    {
        private readonly FakeOrderRepository _repository;

        public OrderServiceTestsWithFakes()
        {
            this._repository = new FakeOrderRepository();
        }

        [TestMethod]
        public void FindOrder_AnyOrderNumber_CallsGetOrderByNumber()
        {
            // arrange
            var service = new OrderService(this._repository);
            var orderNumber = "123456789";

            // act
            var order = service.FindOrder(orderNumber);

            // assert
            Assert.AreEqual(order.OrderNumber, orderNumber);
        }

        [TestMethod]
        public void SubmitOrder_AnyOrder_CallsSaveOrder()
        {
            // arrange
            var service = new OrderService(this._repository);
            var order = new Order();
            order.Id = Guid.NewGuid();

            // act
            service.SubmitOrder(order);

            // assert
            Assert.AreEqual(this._repository.SavedOrderId, order.Id);
        }
    }
}