using ClassLibrary1;

public class UnitTest1
{
    [Fact]
    public void AddTest()
    {
        Assert.Equal(5, Class1.Add(2, 3));
    }
}