namespace Payroll.Interfaces;

public interface IEmployee
{
    public string GetName();

    public void CalculatePay();

    public void PostPayment();

    public bool PaymentsWereNotPostedCorrectly();
}