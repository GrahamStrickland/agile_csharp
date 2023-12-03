namespace Payroll.Mocks;

public class MockCheckWriter : ICheckWriter 
{
    public void WriteCheck()
    {
        throw new NotImplementedException();
    }

    public bool ChecksWereWrittenCorrectly()
    {
        throw new NotImplementedException();
    }
}