using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("testdardds")] // Permet l'accés a membres interns des del projecte de proves

class Program
{
    internal static Random random = new Random();

    internal static int CalculaPunts(int x, int y)
    {
        int dist = Math.Abs(x) + Math.Abs(y);
        int punts = 50;

        while (dist > 0)
        {
            punts /= 2;
            dist--;
        }

        return punts;
    }

    internal static void Main()
    {
        int puntsJugador1 = 0;
        int puntsJugador2 = 0;
        int objectiu = 50;

        while (puntsJugador1 < objectiu && puntsJugador2 < objectiu)
        {
            int x1 = random.Next(-10, 11);
            int y1 = random.Next(-10, 11);
            int punts1 = CalculaPunts(x1, y1);
            puntsJugador1 += punts1;
            Console.WriteLine($"Jugador 1 tira a ({x1},{y1}) - {punts1} punts (Total: {puntsJugador1})");

            int x2 = random.Next(-10, 11);
            int y2 = random.Next(-10, 11);
            int punts2 = CalculaPunts(x2, y2);
            puntsJugador2 += punts2;
            Console.WriteLine($"Jugador 2 tira a ({x2},{y2}) - {punts2} punts (Total: {puntsJugador2})");

            if (puntsJugador1 >= objectiu && puntsJugador2 >= objectiu)
            {
                if (puntsJugador1 > puntsJugador2)
                {
                    Console.WriteLine($"Ha guanyat el jugador 1 {puntsJugador1} a {puntsJugador2}");
                    break;
                }
                else if (puntsJugador2 > puntsJugador1)
                {
                    Console.WriteLine($"Ha guanyat el jugador 2 {puntsJugador2} a {puntsJugador1}");
                    break;
                }
            }
            else if (puntsJugador1 >= objectiu)
            {
                Console.WriteLine($"Ha guanyat el jugador 1 {puntsJugador1} a {puntsJugador2}");
                break;
            }
            else if (puntsJugador2 >= objectiu)
            {
                Console.WriteLine($"Ha guanyat el jugador 2 {puntsJugador2} a {puntsJugador1}");
                break;
            }
        }
    }
}
