using Payroll.Interfaces;

namespace Payroll.Mocks;

public class MockEmployee(string name) : IEmployee
{
    private string _name = name;
    private int _payCheck;
    
    public string GetName() 
    {
        return _name;
    }

    public void CalculatePay()
    {
        _payCheck = 1000;
    }

    public void PostPayment()
    {
        _payCheck = 0;
    }

    public bool PaymentsWereNotPostedCorrectly()
    {
        return _payCheck != 0;
    }
}