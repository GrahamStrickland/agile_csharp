namespace PayrollExample.Interfaces;

public interface IEmployeeDatabase
{
    public IEmployee? GetEmployee(string employeeName);

    public void PutEmployee(IEmployee employee);

    public bool PaymentsWerePostedCorrectly();
}