namespace BFF.UnitTestingInMsTest.Stubs
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository repository)
        {
            this._repository = repository;
        }

        public Order FindOrder(string orderNumber)
        {
            // do some other stuff

            return this._repository.GetOrderByNumber(orderNumber);
        }
    }
}