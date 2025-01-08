using System;
using Xunit;

public class DardsDigitalsTests
{
    [Fact]
    public void CalculaPunts_DistanciaZero_Returns50()
    {
        // Arrange
        int x = 0;
        int y = 0;

        // Act
        int result = Program.CalculaPunts(x, y);

        // Assert
        Assert.Equal(50, result);
    }

    [Fact]
    public void CalculaPunts_DistanciaUn_Returns25()
    {
        // Arrange
        int x = 1;
        int y = 0;

        // Act
        int result = Program.CalculaPunts(x, y);

        // Assert
        Assert.Equal(25, result);
    }

    [Fact]
    public void CalculaPunts_DistanciaGran_ReturnsZero()
    {
        // Arrange
        int x = 20;
        int y = 20;

        // Act
        int result = Program.CalculaPunts(x, y);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void CalculaPunts_ValoresNegatius_CorrectCalculation()
    {
        // Arrange
        int x = -5;
        int y = -5;

        // Act
        int result = Program.CalculaPunts(x, y);

        // Assert
        Assert.Equal(0, result); // Distància 10 dona 0 punts
    }

    [Fact]
    public void JugarPartida_Jugador1Guanya()
    {
        // Arrange
        int puntsJugador1 = 50;
        int puntsJugador2 = 40;

        // Act
        string guanyador = DeterminarGuanyador(puntsJugador1, puntsJugador2);

        // Assert
        Assert.Equal("Jugador 1", guanyador);
    }

    [Fact]
    public void JugarPartida_Jugador2Guanya()
    {
        // Arrange
        int puntsJugador1 = 40;
        int puntsJugador2 = 50;

        // Act
        string guanyador = DeterminarGuanyador(puntsJugador1, puntsJugador2);

        // Assert
        Assert.Equal("Jugador 2", guanyador);
    }

    [Fact]
    public void JugarPartida_Empat()
    {
        // Arrange
        int puntsJugador1 = 50;
        int puntsJugador2 = 50;

        // Act
        string guanyador = DeterminarGuanyador(puntsJugador1, puntsJugador2);

        // Assert
        Assert.Equal("Empat", guanyador);
    }

    // Mètode auxiliar per determinar el guanyador
    private static string DeterminarGuanyador(int puntsJugador1, int puntsJugador2)
    {
        if (puntsJugador1 > puntsJugador2)
        {
            return "Jugador 1";
        }
        else if (puntsJugador2 > puntsJugador1)
        {
            return "Jugador 2";
        }
        else
        {
            return "Empat";
        }
    }
}
