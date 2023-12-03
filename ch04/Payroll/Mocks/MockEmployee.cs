namespace Payroll.Mocks;

public class MockEmployee : IEmployee
{
    public void CalculatePay()
    {
        throw new NotImplementedException();
    }

    public void PostPayment()
    {
        throw new NotImplementedException();
    }

    public bool PaymentsWereNotPostedCorrectly() {
        throw new NotImplementedException();
    }   
}