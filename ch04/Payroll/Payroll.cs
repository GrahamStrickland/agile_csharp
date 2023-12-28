using PayrollExample.Interfaces;
using PayrollExample.Mocks;

namespace PayrollExample;

public class Payroll
{
    public IEmployeeDatabase employeeDatabase;
    public ICheckWriter checkWriter;
    public List<string> _employeeNames;

    public Payroll(IEmployeeDatabase employeeDatabase, ICheckWriter checkWriter)
    {
        this.employeeDatabase = employeeDatabase;
        this.checkWriter = checkWriter;
        _employeeNames = [];

        var employee = new MockEmployee("John Doe");
        _employeeNames.Add(employee.GetName());
        this.employeeDatabase.PutEmployee(employee);
    }

    public void PayEmployees()
    {
        foreach (var employeeName in _employeeNames)
        { 
            var employee = employeeDatabase.GetEmployee(employeeName);
            if (employee != null)
            {
                var pay = employee.CalculatePay();
                employee.PostPayment(pay);
                checkWriter.WriteCheck(pay);
            }
        }
    }

    public static void Main()
    {
        Console.WriteLine("This is just an example project, run the tests!");
    }
}
