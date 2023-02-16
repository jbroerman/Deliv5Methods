/*Jacob Broerman
 2/16/23
 Description: Console app that uses 2 methods to randomly populate an array with user input and take a summation of that array.

using System;

namespace Deliv5Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int myArray = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter an integer number that's between 5 and 15: ");
                    myArray = int.Parse(Console.ReadLine());
                    if ((myArray >- 5) && (myArray <= 15))

                    {
                        break;
                    }
                }
                catch
                {
                   
                }

                Console.WriteLine("Invalid input, try again.");
            }

            int[] Samplearray = PopulateArray(myArray);
            Console.WriteLine("The elements of the array are: " + string.Join(" ", Samplearray));

            int sum = SumArrayElements(Samplearray);
            Console.WriteLine("The sum is: " + sum);
        }

        static int[] PopulateArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(10, 51);
            }

            return array;
        }

        static int SumArrayElements(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                sum += element;
            }

            return sum;
        }
    }
}
