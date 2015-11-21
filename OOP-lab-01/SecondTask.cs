using System;
using System.Collections.Generic;

namespace OOP_lab_01 {
    public static class SecondTask {
        private static double _n;
        private static List<double> _mersenNumbers = new List<double>();

        public static void Execute() {
            ReadInput();
            CalculateResult();
            PrintSolution();
        }

        private static void ReadInput() {
            Console.WriteLine("------ First Task ------");
            Console.Write("Enter n = ");
            _n = double.Parse(Console.ReadLine());
        }

        private static void CalculateResult() {
            for (var number = 1; ; number++) {
                if (IsNumberPrime(number)) {
                    var mersenNumber = Math.Pow(2, number) - 1;
                    if (mersenNumber < _n) {
                        _mersenNumbers.Add(mersenNumber);
                    } else {
                        break;
                    }
                }
            }
        }

        private static bool IsNumberPrime(int number) {
            var boundary = Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (var i = 2; i <= boundary; ++i) {
                if (number % i == 0) return false;
            }

            return true;
        }

        private static void PrintSolution() {
            Console.WriteLine("Result: {0}", string.Join(", ", _mersenNumbers));
            Console.WriteLine("------ End task ------ \n");
        }
    }
}