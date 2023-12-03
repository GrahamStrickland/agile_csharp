namespace Payroll.Interfaces;

public interface IEmployeeDatabase
{
    public IEmployee GetEmployee();
    public void PutEmployee(IEmployee employee);
    public bool PaymentsWerePostedCorrectly();
}