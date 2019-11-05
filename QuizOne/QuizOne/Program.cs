using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1)
            GenerateParamide(5);
            
            //(2)
            Console.WriteLine(IntSum(1123));

            //(3)
            Console.WriteLine(FactN(3));


            Console.ReadKey();


        }
        //Write a C# method to take N and generate paramide with N
        static void GenerateParamide(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = i; j < num; j++)
                {
                    Console.Write( "*" );
                }
                Console.WriteLine();
            }
        }

        //Write a  C# method to create a function to calcualte the sum of the individual digits of a given number.
        static int IntSum(int num)
        {
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
        //Write a  C# program to calculate n!
        static int FactN(int num)
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }

    }
}
