namespace Payroll.Interfaces;

public interface ICheckWriter
{
    public void WriteCheck();

    public bool ChecksWereWrittenCorrectly();
}