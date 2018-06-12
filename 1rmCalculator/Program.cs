using System;

namespace _1rmCalculator
{
    class OneRepMaxCalculator
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Изчисляване на тежестта за едно повторение в серия по формула Brzycki от Matt Brzycki.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Въведете работни кг. - ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Въведете колко повторения правите с тези кг. - ");
            int reps = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Вашите максимални кг. за едно повторение са -");
            var formulaResult = weight / (1.0278 - 0.0278 * reps);
            Console.WriteLine($"{Math.Round(formulaResult)} кг.");

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
