using BFF.UnitTestingInMsTest.Mocks;

namespace BFF.UnitTestingInMSTest.Test.Mocks
{
    public class MockOrderRepository : IOrderRepository
    {
        public Order SavedOrder { get; private set; }

        public void SaveOrder(Order order)
        {
            this.SavedOrder = order;
        }
    }
}