using System;

namespace BFF.UnitTestingInMsTest.Stubs
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            this._repository = repository;
        }

        public Order GetOrder(Guid orderId)
        {
            return this._repository.GetOrder(orderId);
        }
    }
}