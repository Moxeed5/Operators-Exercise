﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z;

            Console.WriteLine("x+=y");
            Console.WriteLine(x += y);

            Console.WriteLine(x -= y);

            Console.WriteLine(x *= y);
            Console.WriteLine(x %= y);

            Console.WriteLine("z= x + y");

            //part 2, 


            int a = 17;
            int b = 4;

            int quotient = a / b;

            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }

            Console.WriteLine("Please enter the radius: ");
            var r = double.Parse(Console.ReadLine());

            // the argument does not need to be the same as the answer
            var answer = Calculations.AreaofCircle(r);
            Console.WriteLine(answer);
        }
    }
}
