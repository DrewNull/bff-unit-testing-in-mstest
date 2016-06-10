namespace BFF.UnitTestingInMsTest.Fakes
{
    public interface IOrderRepository
    {
        Order GetOrderByNumber(string orderNumber);

        void SaveOrder(Order order);
    }
}