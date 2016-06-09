using System;
using BFF.UnitTestingInMsTest.Mocks;

namespace BFF.UnitTestingInMSTest.Test.Mocks
{
    public class MockOrderRepository : IOrderRepository
    {
        public Guid SavedOrderId { get; private set; }

        public void SaveOrder(Order order)
        {
            this.SavedOrderId = order.Id;
        }
    }
}