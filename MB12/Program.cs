using MB12;

public class Program
{

    public static void Main()
    {
        //Fibonacci
        int n = 40;
        for (int i = 0; i <= n; i++)
        {
            int fibonacciNumber = Fibonacci.FibonacciIterativ(i);
            Console.WriteLine("Fibonacci({0}) = {1}", i, fibonacciNumber);
        }
        Console.ReadLine();


        //Türe von Hanoi
        int numDiscs = 4; // Anzahl der Scheiben
        string source = "A"; // Quellstapel
        string auxiliary = "B"; // Hilfsstapel
        string destination = "C"; // Zielstapel

        Console.WriteLine("Ausgangsstellung:");
        Console.WriteLine("Quellstapel ({0}): {1}", source, new string('■', numDiscs));
        Console.WriteLine("Hilfsstapel ({0}): {1}", auxiliary, new string('■', numDiscs));
        Console.WriteLine("Zielstapel ({0}): {1}", destination, new string('■', numDiscs));
        Console.WriteLine();

        Hanoi.Bewege(numDiscs, source, auxiliary, destination);

        Console.WriteLine("Endstellung:");
        Console.WriteLine("Quellstapel ({0}): {1}", source, new string('■', numDiscs));
        Console.WriteLine("Hilfsstapel ({0}): {1}", auxiliary, new string('■', numDiscs));
        Console.WriteLine("Zielstapel ({0}): {1}", destination, new string('■', numDiscs));

        Console.ReadLine();

    }

}