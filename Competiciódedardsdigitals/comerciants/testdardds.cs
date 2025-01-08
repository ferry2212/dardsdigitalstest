using Xunit;

public class ProgramTests
{
    [Fact]
    public void CalculaPunts_ReturnsCorrectPoints()
    {
        Assert.Equal(50, Program.CalculaPunts(0, 0));  // Coordenades al centre
        Assert.Equal(25, Program.CalculaPunts(1, 0));  // Distància 1
        Assert.Equal(25, Program.CalculaPunts(0, -1)); // Distància 1
        Assert.Equal(12, Program.CalculaPunts(2, 0));  // Distància 2
        Assert.Equal(6, Program.CalculaPunts(3, 3));   // Distància 6
    }

    [Fact]
    public void Main_DeclaresAWinner()
    {
        var mockRandom = new MockRandom(new[] { 0, 0, 0, 0, 0, 0 }); // Mock amb resultats controlats
        Program.random = mockRandom;

        using (var consoleOutput = new ConsoleOutput())
        {
            Program.Main();
            var output = consoleOutput.GetOutput();

            Assert.Contains("Ha guanyat el jugador", output);
        }
    }

    [Fact]
    public void Main_GameEndsWhenObjectiveReached()
    {
        var mockRandom = new MockRandom(new[] { 10, 10, 10, 10, 10, 10 }); // Mock amb punts alts
        Program.random = mockRandom;

        using (var consoleOutput = new ConsoleOutput())
        {
            Program.Main();
            var output = consoleOutput.GetOutput();

            Assert.Contains("Ha guanyat el jugador", output);
            Assert.DoesNotContain("Jugador 1 tira", output.Split("Ha guanyat")[1]);
        }
    }
}