namespace Payroll;

public interface ICheckWriter
{
    public void WriteCheck();

    public bool ChecksWereWrittenCorrectly();
}