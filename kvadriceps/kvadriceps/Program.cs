using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Kalkulačka kvadratických rovnic");
            double a = GetUserInput("Zadejte koeficient a: ");
            double b = GetUserInput("Zadejte koeficient b: ");
            double c = GetUserInput("Zadejte koeficient c: ");

            double D = CalculateDiscriminant(a, b, c);

            DisplaySolution(D, a, b);

            Console.Write("Chcete provést další výpočet? (ano/ne): ");
            string response = Console.ReadLine().ToLower();
            if (response != "ano")
            {
                break;
            }
        }
    }

    static double GetUserInput(string prompt)
    {
        double input;
        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out input));

        return input;
    }

    static double CalculateDiscriminant(double a, double b, double c)
    {
        return b * b - 4 * a * c;
    }

    static void DisplaySolution(double D, double a, double b)
    {
        if (D > 0)
        {
            double root1 = (-b + Math.Sqrt(D)) / (2 * a);
            double root2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Dvě reálné kořeny: {root1} a {root2}");
        }
        else if (D == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Jeden reálný kořen (dvojnásobný): {root}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-D) / (2 * a);
            Console.WriteLine($"Komplexní kořeny: {realPart} + {imaginaryPart}i a {realPart} - {imaginaryPart}i");
        }
    }
}
