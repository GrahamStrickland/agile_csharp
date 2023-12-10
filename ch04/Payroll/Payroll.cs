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

    public void PayEmployees()
    {
        IEmployee employee = employeeDatabase.GetEmployee();
        checkWriter.WriteCheck();
        employeeDatabase.PutEmployee(employee);
    }
}
