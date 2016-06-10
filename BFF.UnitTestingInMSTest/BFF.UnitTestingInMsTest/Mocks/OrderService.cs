namespace BFF.UnitTestingInMsTest.Mocks
{
    public class OrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IOrderValidator _validator;

        public OrderService(IOrderRepository repository, IOrderValidator validator)
        {
            this._repository = repository;
            this._validator = validator;
        }

        public void SubmitOrder(Order order)
        {
            bool isValid = this._validator.IsValid(order);

            if (isValid)
            {
                this._repository.SaveOrder(order);
            }
        }
    }
}