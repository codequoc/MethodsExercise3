using System;
using System.Collections.Generic;
using System.Transactions;

namespace MethodsExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //printNumbers();
            //printByThree();
            //equivalent(5, 10);
            //Console.WriteLine(EvenOrOdd(5));
            //checkPositive();
            //voteAge(18);
            //Console.WriteLine(range(1));
            multiplicationTable();
        }

        public static void printNumbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void printByThree()
        {
            int num = 3;
            while (num <= 999)
            {
                Console.WriteLine(num);
                num += 3;
            }
        }

        public static string equivalent(int firstNum, int secondNum)
        {
            if (firstNum == secondNum)
            {
                return "Equal";
            } else {
                return "Not eqaul";
            }
        }

        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "even";
            } else {
                return "odd";
            }
        }

        public static void checkPositive()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                Console.WriteLine("Positive");
            } else
            {
                Console.WriteLine("Negetive");
            }
           
        }
        public static void voteAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("Can vote");
            } else
            {
                Console.WriteLine("Can not vote");
            }
        }

        public static string range(int num)
        {
            if (num >= -10 && num <= 10) {
                return "within range";
            } else
            {
                return "out of range";
            }
        }

        public static void multiplicationTable()
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.Write("|" + i + "\t");
                for (int j = 1; j <= 12; j++)
                {
                    if (i > 0)
                    {
                        int multiply = i * j;
                        Console.Write("|" + multiply + "\t");
                    } else
                    {
                        Console.Write("|" + j + "\t");
                    }
                }
                Console.WriteLine("|");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            }
        }
    }
}
