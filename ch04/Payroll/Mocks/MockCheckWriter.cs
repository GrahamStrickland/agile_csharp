using Payroll.Interfaces;

namespace Payroll.Mocks;

public class MockCheckWriter : ICheckWriter 
{
    private List<string> _checkBuffer = [];
    private static int _checkNum = 1;

    public MockCheckWriter() 
    {
        _checkBuffer = [];
    }

    public void WriteCheck()
    {
        var checkStr = _checkNum.ToString().PadLeft(3);
        _checkBuffer.Append("MockCheck" + checkStr);
        _checkNum++;
    }

    public bool ChecksWereWrittenCorrectly()
    {
        return _checkBuffer.Count > 1 &&
            _checkBuffer.Last() == "MockCheck" + _checkNum.ToString().PadLeft(3);
    }
}