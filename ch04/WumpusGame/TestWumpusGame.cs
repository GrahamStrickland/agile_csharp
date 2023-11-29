using NUnit.Framework;

internal class TestWumpusGame
{
    public static void Main(string[] args)
    {
        TestMove();
    } 

    [Test]
    public void TestMove()
    {
        WumpusGame g = new WumpusGame();
        g.Connect(4, 5, "E");
        g.SetPlayerRoom(4);
        g.East();
        Assert.Equals(5, g.GetPlayerRoom());
    }
}
