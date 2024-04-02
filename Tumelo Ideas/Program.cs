using System;



namespace Tumelo_Ideas
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //Adding a boolean value to make it always loop and recalculate
            bool check = true;


            while (check != false) {

                //Using this variable to check if they want to calculate or not
                
                Console.Write("Enter CAL to calculate any side ? using theorem of pythagoras :");
                string play = Console.ReadLine().ToUpper();

                if (play == "CAL")
                {
                    Console.WriteLine("Which side you looking for ? enter r or x or y;");
                    char side = char.Parse(Console.ReadLine());

                    // initialising 3 var which are double to store the given sides
                    double a, h, op;
                    
                    // creating an triangle 
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
                }
                else
                {
                    Console.Write("Good Bye Thanks for using the program....");

                    //Stopping the program when use enter nothing or press wrong text
                    check = false;
                    break;
                }
            }
            _ = Console.ReadKey();

        }
    }
}
