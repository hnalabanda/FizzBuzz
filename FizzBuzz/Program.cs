using System;
using System.ComponentModel.Design;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (IsMultipleOf3(i))
                {
                    Console.WriteLine("Fizz");
                }
                else if (IsMultipleOf5(i))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        static Boolean IsMultipleOf3(int i)
        {
            if (i%3>=1)
            {
                return true;
                
            }
            else
            {
                return false;
            }
           
        }
        static Boolean IsMultipleOf5(int i)
        {
            if (i%5>=1)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}