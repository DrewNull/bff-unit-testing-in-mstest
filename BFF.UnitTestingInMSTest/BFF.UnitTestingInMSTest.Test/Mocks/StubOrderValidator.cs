using BFF.UnitTestingInMsTest.Mocks;

namespace BFF.UnitTestingInMSTest.Test.Mocks
{
    public class StubOrderValidator : IOrderValidator
    {
        private readonly bool _isOrIsNotValid ;

        public StubOrderValidator(bool isOrIsNotValid)
        {
            this._isOrIsNotValid = isOrIsNotValid;
        }

        public bool IsValid(Order order)
        {
            return this._isOrIsNotValid;
        }
    }
}