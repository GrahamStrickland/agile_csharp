using Payroll.Interfaces;

namespace Payroll;

public class Payroll
{
    public IEmployeeDatabase employeeDatabase;
    public ICheckWriter checkWriter;

    public Payroll(IEmployeeDatabase employeeDatabase, ICheckWriter checkWriter)
    {
        this.employeeDatabase = employeeDatabase;
        this.checkWriter = checkWriter;
    }

    public void PayEmployees(string employeeName)
    {
        IEmployee? employee = employeeDatabase.GetEmployee(employeeName);

        if (employee == null)
        {
            throw new Exception("No such employee");
        }

        checkWriter.WriteCheck();
        employeeDatabase.PutEmployee(employee);
    }
}
