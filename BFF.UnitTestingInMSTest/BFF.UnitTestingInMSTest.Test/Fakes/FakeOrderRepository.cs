using System;
using BFF.UnitTestingInMsTest.Fakes;

namespace BFF.UnitTestingInMSTest.Test.Fakes
{
    public class FakeOrderRepository : IOrderRepository
    {
        public Guid SavedOrderId { get; private set; }

        public Order GetOrder(Guid id)
        {
            var order = new Order
            {
                Id = id
            };

            return order;
        }

        public void SaveOrder(Order order)
        {
            this.SavedOrderId = order.Id;
        }
    }
}