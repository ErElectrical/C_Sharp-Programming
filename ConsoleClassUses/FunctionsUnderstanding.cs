using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleClassUses
{
    public class FunctionsUnderstanding
    {
        public static void Functionknowledge()
        {
            Console.WriteLine("function is a group of related instructions that performs a specific task. " +
                "It can be a small or big task, but the function will perform that task completely. " +
                "Functions take some input as parameters and return the result as a return value.");
            Console.WriteLine("\ntwo types of Functions in C#. They are as follows:\r\n\r\nBuilt-in Functions\r\nUser-Defined Functions");
            Console.WriteLine("\n Method Signature is consisting of two things, i.e., the Method Name and the Parameter List. The return type is not considered to be a part of the method signature e.g --  Add(int x, int y)" +
                "Here int x, int y is formal parameter." +
                "return statement terminates the function and returns responsbility to its caller.");
            Console.WriteLine("There are four types of user-defined functions in C#. They are as follows:" +
                "\r\n\r\\r\n×\r\nFunctions with No Argument and No Return Type.\r\nFunctions with Argument and No Return Type.\r\nFunctions with No Argument and with Return Type.\r\nFunctions with Argument and with Return Type");

            Add(5, 210);
            fun1();
            fun2(122,323);
            fun3();
            Fun4("Mohit", "Tanwar");

            Console.WriteLine("User defined functions are of two types" +
                "\nCall by Value"+
                "\nCall by refernce");
            Console.WriteLine("\n In call by value, a copy of the actual parameter's value is passed to the function. " +
                "Changes made to the parameter inside the function do not affect the original argument.");

            int originalArgument = 10;
            Console.WriteLine($" Original argument value before Call by value {originalArgument} ");
            CallByValue(originalArgument);
            Console.WriteLine($" Original argument value After Call by value {originalArgument} " +
                $"\n Theres no change in argument val.");
            Console.WriteLine("\n In call by reference, a reference (or address) to the actual parameter is passed to the function. This allows the function to modify the original argument." +
                "you can pass parameters by reference using the ref keyword");
            Console.WriteLine("Before CallByReference: " + originalArgument);
            CallByReference(ref originalArgument); // Pass by reference
            Console.WriteLine("\nAfter CallByReference: " + originalArgument);
            Console.WriteLine("\nCalculate the Factorial of a Number using Recursion:");
            Console.WriteLine("\n Function calling itself is called Recursion. Or, in simple words," +
                " we can say that recursion is a process in which a function calls itself repeatedly until some specified condition has been satisfied");

            Console.WriteLine("Lets print Factorial series upto 10");
            int x = 5;
            Console.WriteLine($"The factorial of {x} is {FibonacciRecursion(x)}");


        }

        static void Add(int x, int y)
        {
            int sum = x + y;
            Console.Write($"\n sum of number is {sum}");
        }

        static void fun1()
        {
            Console.WriteLine("Functions with No Argument and No Return Type.");
        }

        static void fun2(int x , int y)
        {
            Console.WriteLine("Functions with Argument and No Return Type.");
            Add(x, y);
        }

        static string fun3()
        {
            Console.WriteLine("Function with no argument but have return type");
            string dev_name = "Mohit Tanwar";
            Console.WriteLine($"Developer Name is {dev_name}");
            return dev_name;
        } 

        static string Fun4(string fsname, string Lsname)
        {
            Console.WriteLine("Function with argument and return type");
            string flname = fsname + Lsname;
            Console.WriteLine($"Devloper Full name is {fsname}   {Lsname}");
            return flname;
        }

        static void CallByValue(int num)
        {
            num = num + 10; // Modify the local copy
            Console.WriteLine("Inside CallByValue: " + num);
        }

        static void CallByReference(ref int num)
        {
            num = num + 10; // Modify the original variable
            Console.WriteLine("Inside CallByReference: " + num);
        }

        static int FibonacciRecursion(int num)
        {
            if (num == 1)
            {
                return (1); /* exiting condition */
            }
            else
            {
                return (num * FibonacciRecursion(num - 1));
            }
        }

    }
}
