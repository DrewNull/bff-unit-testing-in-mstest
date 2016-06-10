using System;

namespace BFF.UnitTestingInMsTest.Fakes
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

        public void SaveOrder(Order order)
        {
            this._repository.SaveOrder(order);
        }
    }
}