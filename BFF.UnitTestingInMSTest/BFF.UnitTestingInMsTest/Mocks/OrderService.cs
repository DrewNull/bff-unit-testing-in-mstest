namespace BFF.UnitTestingInMsTest.Mocks
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            this._repository = repository;
        }

        public void SaveOrder(Order order)
        {
            this._repository.SaveOrder(order);
        }
    }
}