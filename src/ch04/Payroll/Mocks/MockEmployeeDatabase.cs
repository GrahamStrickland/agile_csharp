using PayrollExample.Interfaces;

namespace PayrollExample.Mocks;

public class MockEmployeeDatabase : IEmployeeDatabase
{
    private List<IEmployee> _employees;

    public MockEmployeeDatabase()
    {
        _employees = [];
    }

    public IEmployee? GetEmployee(string employeeName)
    {
        return _employees.Find(employee => employee.GetName() == employeeName); 
    }

    public void PutEmployee(IEmployee employee)
    {
        _employees = [.. _employees, employee];
    }

    public bool PaymentsWerePostedCorrectly() {
        return !_employees.Any(employee => employee.PaymentsWereNotPostedCorrectly()); 
    }
}