using BFF.UnitTestingInMsTest.Stubs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFF.UnitTestingInMSTest.Test.Stubs
{
    [TestClass]
    public class OrderServiceTests
    {
        [TestMethod]
        public void FindOrder_AnyOrderNumber_CallsGetOrderByNumber()
        {
            // arrange
            var stubRepository = new StubOrderRepository();
            var service = new OrderService(stubRepository);
            var orderNumber = "123456789";

            // act
            var order = service.FindOrder(orderNumber);

            // assert
            Assert.AreEqual(order.OrderNumber, orderNumber);
        }
    }
}