using System;

namespace OOP_lab_01 {
    public static class ThirdTask {
        private static double _s, _t, _result;

        public static void Execute() {
            ReadInput();
            CalculateResult();
            PrintSolution();
        }

        private static void ReadInput() {
            Console.WriteLine("------ First task ------");
            Console.Write("Enter s = ");
            _s = double.Parse(Console.ReadLine());
            Console.Write("Enter t = ");
            _t = double.Parse(Console.ReadLine());
        }

        private static void CalculateResult() {
            _result = g(1.2, _s) + g(_t, _s) - g((2 * _s - 1), (_s * _t));
        }

        private static double g(double a, double b) {
            return (Math.Pow(a, 2) + Math.Pow(b, 2)) / (Math.Pow(a, 2) + 2 * a * b + 3 * Math.Pow(b, 2) + 4);
        }

        private static void PrintSolution() {
            Console.WriteLine("Result is: {0}", _result);
            Console.WriteLine("------ End task ------ \n");
        }
    }
}