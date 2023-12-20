using Payroll.Mocks;

using NUnit.Framework;

using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Payroll;

public class PayrollTest
{
    public static void Main(string[] args)
    {
        TestPayroll();
    }

    [Test]
    public static void TestPayroll()
    {
        MockEmployeeDatabase db = new MockEmployeeDatabase();
        MockCheckWriter w = new MockCheckWriter();
        Payroll p = new Payroll(db, w);
        Assert.IsTrue(w.ChecksWereWrittenCorrectly());
        Assert.IsTrue(db.PaymentsWerePostedCorrectly());
    }
}