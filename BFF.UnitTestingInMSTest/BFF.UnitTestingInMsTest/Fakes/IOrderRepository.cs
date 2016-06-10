using System;

namespace BFF.UnitTestingInMsTest.Fakes
{
    public interface IOrderRepository
    {
        Order GetOrder(Guid id);

        void SaveOrder(Order order);
    }
}