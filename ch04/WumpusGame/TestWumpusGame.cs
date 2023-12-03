using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

internal class TestWumpusGame
{
    public static void Main(string[] args)
    {
        TestMove();
    } 

    [Test]
    public static void TestMove()
    {
        WumpusGame g = new WumpusGame();
        g.Connect(4, 5, "E");
        g.SetPlayerRoom(4);
        g.East();
        Assert.AreEqual(5, g.GetPlayerRoom());
    }
}
