using System;

namespace WebSys_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] values = { 1, 2, 3, 5, 6, 7, 8, 9 };
            Console.WriteLine("Max Value is: {0}", GetMaxValue(values));
            Console.WriteLine("Min Value is: {0}", GetMinValue(values));
            Console.WriteLine("Avg Value is: {0}", GetAverageValueFromArray(values));
            Console.WriteLine("Avg Value is: {0}", GetModalValue(values));
        }

        private static int GetMaxValue(int[] valuesToCalculate) {
            var maxValue = 0;
            foreach(var currentValue in valuesToCalculate) {
                maxValue = currentValue > maxValue ? currentValue : maxValue;
            }

            return maxValue;
        }

        private static int GetMinValue(int[] valuesToCalc)
        {
            var minValue = 1;

            foreach (var currentValue in valuesToCalc)
            {
                minValue = currentValue < minValue ? currentValue : minValue;
            }
            return minValue;
        }

        private static int GetAverageValueFromArray(int[] valuesToCalculate)
        {
            var totalSumOfValues = 0;

            foreach (var currentValue in valuesToCalculate) {
                totalSumOfValues += currentValue;
            }

            var averageValue = totalSumOfValues / valuesToCalculate.Length;
            return averageValue;
        }

        private static decimal GetModalValue(int[] valuesToCalculate)
        {
            var arrayLength = valuesToCalculate.Length;

            var result = ((decimal)valuesToCalculate[arrayLength / 2] + (decimal)valuesToCalculate[(arrayLength / 2) + 1]) / 2;

            return result;
        }
    }
}
