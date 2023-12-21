using PayrollExample.Interfaces;

namespace PayrollExample.Mocks;

public class MockEmployee(string name) : IEmployee
{
    private string _name = name;
    private double _payCheck;
    
    public string GetName() 
    {
        return _name;
    }

    public double CalculatePay()
    {
        _payCheck = 1000.00;

        return _payCheck;
    }

    public void PostPayment(double payment)
    {
        _payCheck -= payment;
    }

    public bool PaymentsWereNotPostedCorrectly()
    {
        return _payCheck != 0.0;
    }
}