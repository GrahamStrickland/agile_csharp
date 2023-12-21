namespace PayrollExample.Interfaces;

public interface ICheckWriter
{
    public void WriteCheck(double value);

    public bool ChecksWereWrittenCorrectly();
}