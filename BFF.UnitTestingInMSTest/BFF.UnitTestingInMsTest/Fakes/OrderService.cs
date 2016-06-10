namespace BFF.UnitTestingInMsTest.Fakes
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

        public void SubmitOrder(Order order)
        {
            // do some other stuff

            this._repository.SaveOrder(order);
        }
    }
}