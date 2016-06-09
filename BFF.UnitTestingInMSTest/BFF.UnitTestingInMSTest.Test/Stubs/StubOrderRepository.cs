using System;
using BFF.UnitTestingInMsTest.Stubs;

namespace BFF.UnitTestingInMSTest.Test.Stubs
{
    public class StubOrderRepository : IOrderRepository
    {
        public Order GetOrder(Guid id)
        {
            var order = new Order
            {
                Id = id
            };

            return order;
        }
    }
}