using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassUses
{
    public class ExceptionHandling
    {

        public static void CheckExceptionHandling()
        {

            Console.WriteLine("Try block : " +
                " whenever some logic / code may through exception it should be put inside the try block" +
                "If Some where error occured CLR creted a object of exception and though it ." +
                "" +
                "The catch block : " +
                "is used to catch the exception that is thrown from its corresponding try block. It has the logic to take necessary actions on that caught exception" +
                "" +
                "The keyword finally establishes" +
                " a block that definitely executes the statements placed in it irrespective of whether any exception has occurred or not." +
                "" +
                " ");

            Console.WriteLine("Multiple Catch block are possible here" +
                "Different catch block can target different exceptions." +
                "" +
                "Final block needs to be excuted no matter some error occur or not " +
                "Generally IN final block resource releases codes is written" +
                "");

            Console.WriteLine(" Some exceptions are according to application requirement" +
                "In such secenerio we need to create a custom exception that can guide " +
                "user in this situations." +
                "" +
                "Innerexception is a property of Exception class" +
                "It will give us the very first error that caused the series of exceptions . " +
                "");
            int number1, number2, result;
            Console.WriteLine("Enter First number");
            number1 = (int)Console.Read();
            number2 = (int)Console.Read();
            try
            {
                result = number1 / number2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine($"{ex.Message}");
                
            }
            catch (FormatException FE)
            {
                Console.WriteLine(FE.ToString());
                Console.WriteLine($"{FE.Message}");

            }

            //this single catch  exception can handle all of the exception.
            //It is always recommended to write thic catch block at the end of each catch block

            catch(DivideBYODD ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic Catch Block...");
            }

        }
        
        
    }

    public class DivideBYODD : Exception
    {


        public override string Message
        {
            get
            {
                return "Divisor Cannot be Odd Number";
            }
        }

        //Overriding the HelpLink Property
        public override string HelpLink
        {
            get
            {
                return "Get More Information from here: https://dotnettutorials.net/lesson/create-custom-exception-csharp/";
            }
        }
    }
}
