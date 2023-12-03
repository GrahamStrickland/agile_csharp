using Payroll.Interfaces;

namespace Payroll.Mocks;

public class MockEmployeeDatabase : IEmployeeDatabase
{
    public IEmployee GetEmployee()
    {
        throw new NotImplementedException();
    }

    public void putEmployee(IEmployee employee)
    {
        throw new NotImplementedException();
    }

    public bool PaymentsWerePostedCorrectly() {
        throw new NotImplementedException();
    }
}