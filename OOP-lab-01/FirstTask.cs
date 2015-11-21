using System;

namespace OOP_lab_01 {
    public static class FirstTask {
        private static double _a, _x, _result;

        public static void Execute() {
            ReadInput();
            CalculateResult();
            PrintSolution();
        }

        private static void ReadInput() {
            Console.WriteLine("------ Start task ------");
            Console.Write("Enter a = ");
            _a = double.Parse(Console.ReadLine());
            Console.Write("Enter x = ");
            _x = double.Parse(Console.ReadLine());
        }

        private static void CalculateResult() {
            _result = Math.Log((_x - 4), 2) + Math.Pow(Math.E, (2 * _a - _x));
        }

        private static void PrintSolution() {
            Console.WriteLine("Result is: {0}", _result);
            Console.WriteLine("------ End task ------ \n");
        }
    }
}