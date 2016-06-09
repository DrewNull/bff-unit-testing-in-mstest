using System;

namespace BFF.UnitTestingInMsTest.Stubs
{
    public interface IOrderRepository
    {
        Order GetOrder(Guid id);
    }
}