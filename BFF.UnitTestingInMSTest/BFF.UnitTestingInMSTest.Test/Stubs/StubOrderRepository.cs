using BFF.UnitTestingInMsTest.Stubs;

namespace BFF.UnitTestingInMSTest.Test.Stubs
{
    public class StubOrderRepository : IOrderRepository
    {
        public Order GetOrderByNumber(string orderNumber)
        {
            var order = new Order
            {
                OrderNumber = orderNumber
            };

            return order;
        }
    }
}