namespace PayrollTests
{
    [TestClass]
    public class PayrollTests
    {
        [TestMethod]
        public void TestPayroll()
        {
            MockEmployeeDatabase db = new MockEmployeeDatabase();
            MockCheckWriter w = new MockCheckWriter();
            Payroll p = new Payroll(db, w);
            p.PayEmployees();
            Assert.IsTrue(w.ChecksWereWrittenCorrectly());
            Assert.IsTrue(db.PaymentsWerePostedCorrectly());
        }
    }
}