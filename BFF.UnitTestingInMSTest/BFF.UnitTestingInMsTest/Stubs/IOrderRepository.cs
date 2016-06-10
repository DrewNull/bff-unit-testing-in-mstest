namespace BFF.UnitTestingInMsTest.Stubs
{
    public interface IOrderRepository
    {
        Order GetOrderByNumber(string orderNumber);
    }
}