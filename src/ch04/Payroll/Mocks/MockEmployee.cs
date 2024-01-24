using PayrollExample.Interfaces;

namespace PayrollExample.Mocks;

public class MockEmployee(string name) : IEmployee
{
    private string _name = name;
    private double _payDue = 0.0;
    
    public string GetName() 
    {
        return _name;
    }

    public double CalculatePay()
    {
        _payDue = 1000.00;

        return _payDue;
    }

    public void PostPayment(double payment)
    {
        _payDue -= payment;
    }

    public bool PaymentsWereNotPostedCorrectly()
    {
        return _payDue != 0.0;
    }
}