using System;



namespace Tumelo_Ideas
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Which side you looking for ? enter r or x or y;");
            char side = char.Parse(Console.ReadLine());

            double a, h, op;
            Console.WriteLine("'|\\\'");
            Console.WriteLine("'|\\\\\'");
            Console.WriteLine("'|\\\\\\'");

            double answer = 0;
            _ = Math.Pow(answer, 2);

            // r^2 = x^2 + y^2
            // r HYpotenus is x adjecent plus opposite which is y

            Console.WriteLine("Enter given side Adjacent side : ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter given side Hypoternus : ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Opposite Side");
            op = double.Parse(Console.ReadLine());

            if (side == 'r')
            {
                answer = Math.Pow(a, 2) + Math.Pow(op, 2);
                double hypotonus = Math.Sqrt(answer);
                Console.WriteLine($"The answer for side {side} and the answer is {hypotonus}");
            }
            else if (side == 'x')
            {
                answer = Math.Pow(h, 2) - Math.Pow(op, 2);
                double adjacent = Math.Sqrt(answer);
                Console.WriteLine($"The answer for side {side} and the answer is {adjacent}");
            }
            else if (side == 'y')
            {
                answer = Math.Pow(h, 2) - Math.Pow(a, 2);
                double opposite = Math.Sqrt(answer);
                Console.WriteLine($"The answer for side {side} and the answer is {opposite}");
            }
            _ = Console.ReadKey();

        }
    }
}
