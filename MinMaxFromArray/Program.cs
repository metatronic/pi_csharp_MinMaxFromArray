using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-13,10,2,3,0,30,-33,12,1,9,3,0,22};
            int min = 0, max = 0;
            
            MinMaxFromArrayRef(numbers, ref min, ref max);
            Console.WriteLine($"Min : {min}, Max : {max}");

            MinMaxFromArrayOut(numbers, out min, out max);
            Console.WriteLine($"Min : {min}, Max : {max}");
            
            MinMax minmax = MinMaxFromArrayStruct(numbers);
            Console.WriteLine($"Min : {minmax.min}, Max : {minmax.max}");

            var result = MinMaxFromArrayTuple(numbers);
            Console.WriteLine($"Min : {result.Item1}, Max : {result.Item2}");

            (int min_1, int max_1) = MinMaxFromArrayTuple7(numbers);
            Console.WriteLine($"Min : {min_1}, Max : {max_1}");

            Console.ReadLine();
        }

        struct MinMax
        {
            public int min;
            public int max;
        }

        static void MinMaxFromArrayRef(int[] numbers, ref int min, ref int max)
        {
            for(int index = 0; index < numbers.Length; index++)
            {
                if(numbers[index] > max)
                {
                    max = numbers[index];
                }
                if(numbers[index] < min)
                {
                    min = numbers[index];
                }
            }
        }

        static void MinMaxFromArrayOut(int[] numbers, out int min, out int max)
        {
            min = 0;
            max = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > max)
                {
                    max = numbers[index];
                }
                if (numbers[index] < min)
                {
                    min = numbers[index];
                }
            }
        }

        static MinMax MinMaxFromArrayStruct(int[] numbers)
        {
            MinMax minmax = new MinMax();
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > minmax.max)
                {
                    minmax.max = numbers[index];
                }
                if (numbers[index] < minmax.min)
                {
                    minmax.min = numbers[index];
                }
            }
            return minmax;
        }

        static Tuple<int,int> MinMaxFromArrayTuple(int[] numbers)
        {
            int min = 0, max = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > max)
                {
                    max = numbers[index];
                }
                if (numbers[index] < min)
                {
                    min = numbers[index];
                }
            }

            var tuple = new Tuple<int, int>(min, max);
            return tuple;
        }

        static (int min_1, int min_2) MinMaxFromArrayTuple7(int[] numbers)
        {
            int min = 0, max = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > max)
                {
                    max = numbers[index];
                }
                if (numbers[index] < min)
                {
                    min = numbers[index];
                }
            }
            return (min, max);
        }
    }
}
