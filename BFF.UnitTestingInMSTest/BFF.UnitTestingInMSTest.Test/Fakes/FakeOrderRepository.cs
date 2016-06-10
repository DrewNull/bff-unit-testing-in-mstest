using System;
using BFF.UnitTestingInMsTest.Fakes;

namespace BFF.UnitTestingInMSTest.Test.Fakes
{
    public class FakeOrderRepository : IOrderRepository
    {
        public Guid SavedOrderId { get; private set; }

        public Order GetOrderByNumber(string orderNumber)
        {
            var order = new Order
            {
                OrderNumber = orderNumber
            };

            return order;
        }

        public void SaveOrder(Order order)
        {
            this.SavedOrderId = order.Id;
        }
    }
}