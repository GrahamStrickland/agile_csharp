using PayrollExample.Interfaces;

namespace PayrollExample.Mocks;

public class MockCheckWriter : ICheckWriter 
{
    private List<string> _checkBuffer = [];
    private static int _checkNum = 1;

    public MockCheckWriter() 
    {
        _checkBuffer = [];
    }

    public void WriteCheck(double value)
    {
        var checkStr = _checkNum.ToString().PadLeft(3);
        _checkBuffer.Append("MockCheck" + checkStr + ": $" + value.ToString(
            "C",
            new System.Globalization.CultureInfo("en-US")
        ));
        _checkNum++;
    }

    public bool ChecksWereWrittenCorrectly()
    {
        return _checkBuffer.Count > 1 &&
            _checkBuffer.Last() == "MockCheck" + _checkNum.ToString().PadLeft(3) + ": $1,000.00";
    }
}