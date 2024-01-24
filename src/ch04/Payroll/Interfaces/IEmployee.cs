namespace PayrollExample.Interfaces;

public interface IEmployee
{
    public string GetName();

    public double CalculatePay();

    public void PostPayment(double payment);

    public bool PaymentsWereNotPostedCorrectly();
}