namespace BFF.UnitTestingInMsTest.Mocks
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            this._repository = repository;
        }

        public void SubmitOrder(Order order)
        {
            // do some other stuff

            this._repository.SaveOrder(order);
        }
    }
}