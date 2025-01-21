using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassUses
{
    public class Typesofvarible
    {
        // static varible 
        static int x = 100;

        int y = 200;  //instance varible 
        readonly string Developer_name;
        public Typesofvarible(int a ) {

            //Generally it is not recommended to intialise static varible through constructor of class .


            x = a;
            y = a;


        }

        public Typesofvarible(string a)
        {

            //Generally it is not recommended to intialise static varible through constructor of class .


            Developer_name = a; 


        }

        public  static void varibledef()
        {
            Console.WriteLine("\n Static varible -- This varible contains  'static' keyword. this varible belongs to class rather than any instance. " +
                "Static variables are often used to store data that is common to all instances or to maintain state information that should be shared across all instances. " +
                " life span of static varible start just starting of program and ends with life span of program");
            Console.WriteLine("an instance variable (also known as a member variable or field) is a variable that is associated with a specific instance of a class." +
                " Each object (or instance) of the class has its own copy of the instance variable, which allows each object to maintain its own state.");

            Typesofvarible obj1 = new Typesofvarible(200);
            Console.WriteLine($"\nInstance varible value for obj1 {obj1.y}");
            Console.WriteLine($"\nStatic varible value {Typesofvarible.x}");
            Typesofvarible obj2 = new Typesofvarible(400);
            Console.WriteLine($"\nInstance varible value for obj2 {obj2.y}");
            Console.WriteLine($"\nStatic varible value {Typesofvarible.x}");

            Console.WriteLine($"\nGenerally static varible are not bound with instance but as here we are initialising static varible through constructor due to which we can " +
                $" change static varible value");


            //Constant type pf varible
            const float pi = 3.14f;
            Console.WriteLine($"\n Value of declared constant {pi} if we declare a variable by using the 'const' keyword, then it is a constant variable and the value of the constant variable can’t be modified once after its declaration." +
                " So, it is mandatory to initialize the constant variable at the time of its declaration only. otherwise compiler throws error  . ");
            Console.WriteLine($"\n The only difference between a static and constant variable is that the static variables can be modified using constructor " +
                $"whereas the constant variables in C# can’t be modified once it is declared. ");

            //readonly varible . 
            //When we declare a variable by using the readonly keyword, then it is known as a read-only variable
            //and these variables can’t be modified like constants but after initialization.
            //That means it is not mandatory to initialize a read-only variable at the time of its declaration,
            //they can also be initialized under the constructor.
            //That means we can modify the read-only variable value only within a constructor.

            //The behavior of read-only variables will be similar to the behavior of non -static variables in C#,
            //
            //i.e. initialized only after creating the instance of the class and once for each instance of the class is created.
            //That means we can consider it as a non-static variable and to access readonly variables we need an instance.

            Console.WriteLine("//When we declare a variable by using the readonly keyword, then it is known as a read-only variable\r\n           " +
                " //and these variables can’t be modified like constants but after initialization.\r\n            " +
                "//That means it is not mandatory to initialize a read-only variable at the time of its declaration,\r\n          " +
                "  //they can also be initialized under the constructor.\r\n         " +
                "   //That means we can modify the read-only variable value only within a constructor.\r\n\r\n      " +
                "      //The behavior of read-only variables will be similar to the behavior of non -static variables in C#,\r\n       " +
                "     //\r\n            //i.e. initialized only after creating the instance of the class and once for each instance of the class is created.\r\n   " +
                "         //That means we can consider it as a non-static variable and to access readonly variables we need an instance.");

            Console.WriteLine($"\nThe only difference between a non-static and readonly variable is that after initialization, " +
                $"you can modify the non-static variable value but you cannot modify the readonly variable value.");

            Typesofvarible obj3 = new Typesofvarible("Mohit Tanwar");
            Console.WriteLine($"\nDeveloper name through Readonly varible {obj3.Developer_name}");

            Console.WriteLine($"\n This means you can only initialize a readonly variable at the time of its declaration or through a constructor. " +
                $"difference between a constant and readonly variable in C# is that a constant is a fixed value for the whole class whereas readonly is a fixed value " +
                $"specific to an instance of a class and for each instance.");
        }

    }
}
