using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
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


            Console.WriteLine("Strings are immutable in nature. Its mean once a string is created and we try to override it " +
                "than the value is stored to other memorry location and its address is stored in varible." +
                "Let's see through an example weather string is immutable or not");

            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);

            Console.WriteLine("\n Strings are immutable but sometimes we do not want this immutable behaviour " +
                "IN this case Stringbuilder class plays a vital role");
            Console.WriteLine($"\nThe StringBuilder class in C# is used to create and manipulate strings in a more efficient way," +
                $" especially when you need to perform multiple modifications to a string." +
                $" Unlike regular strings, which are immutable, StringBuilder allows you to modify the contents without creating new instances each time.");

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello Developer");
            sb.Append(" ,  ");
            sb.Append("How's your day");

            string st = sb.ToString();
            Console.WriteLine($"\n {st}");

            Console.WriteLine("The static keyword in C# is a powerful feature that allows you to define members that belong to the class itself rather than to instances of the class." +
                " It is commonly used for:" +
                "\r\n\r\nShared data across instances (static fields)." +
                "\r\nUtility methods that do not require an instance (static methods)." +
                "\r\nInitialization of static data (static constructors)." +
                "\r\nGrouping related functionality in a single class (static classes).");

            Console.WriteLine("A static variable gets initialized only once during the life cycle of a class whereas" +
                " a non-static variable gets initialized either 0 or n number of times, depending on the number of objects created for that class.");

            Console.WriteLine("Constats are immutable values that are known at the time of compliation and their value donot change at run time." +
                "Read-only varibles are also immutable but their value is known at runtime and its do not change at run time it remains same." +
                "Constatnts are just static members only difference is that static can be changes but a constant can not be altered after its declration.");

            Console.WriteLine("Readonly varibles are non-static ." +
                "The variable which is created by using the readonly keyword is known as a read-only variable in C#. The read-only variable’s value cannot be modified once after its initialization." +
                "It is not mandatory or required to initialize the read-only variable at the time of its declaration like a constant. " +
                "You can initialize the read-only variables under a constructor but the most important point is that once after initialization," +
                " you cannot modify the value of the readonly variable outside the constructor." +
                "Behaviour of Read only members is same as non-static memebres."
                );

            Console.WriteLine("properties are a way to encapsulate data within a class. " +
                "They provide a flexible mechanism to read, write, or compute the values of private fields. " +
                "Properties can have different access modifiers for their getters and setters, allowing for controlled access to the underlying data.");

            Console.WriteLine("Here we are discussing a important ques difference between .ToString() and convert.tostring() method." +
                "ToString when you want to get the string representation of a specific object, " +
                "especially if you have overridden it for custom behavior." +
                " Use Convert.ToString when you need a more general-purpose conversion that handles null values gracefully and can work with various types.");

            Console.WriteLine("Checked Keyword in C# is used to explicitly enable overflow checking for integral-type arithmetic operations and conversions." +
                " The Unchecked Keyword in C# is used to suppress overflow-checking for integral-type arithmetic operations and conversions." +
                "\r\n\r\nHere, overflow checking means when the value of any integral type exceeds its range, " +
                "it does not raise any exception, instead it will give us unexpected or garbage result");


            Console.WriteLine($"Let's see max range of int {int.Max}");
            int a = 2147483647;
            int b = 2147483647;

            //int c = checked(a + b);
            //Console.WriteLine(c);

            Console.WriteLine("Memory allocation is done in two ways ." +
                "Stack Memory:" +
                "\r\n\r\nStorage: The stack is used for storing value types (e.g., int, char, struct) and reference types' references (pointers)" +
                ".\r\nAllocation/Deallocation: " +
                "Memory allocation and deallocation are fast and follow a Last In, First Out (LIFO) order." +
                " When a method is called, its local variables are pushed onto the stack, and when the method exits, the memory is automatically reclaimed." +
                "\r\nLifetime: The lifetime of stack-allocated variables is limited to the scope of the method in which they are defined. " +
                "Once the method exits, the memory is freed." +
                "\r\nSize Limitations: The stack has a limited size, which can lead to a StackOverflowException if too much memory is used " +
                "(e.g., in deep recursion)." +
                "\r\nHeap Memory:" +
                "\r\n\r\nStorage: The heap is used for storing reference types (e.g., objects, arrays) and is managed by the garbage collector." +
                "\r\nAllocation/Deallocation: Memory allocation on the heap is generally slower than on the stack," +
                " and deallocation is handled by the garbage collector, which runs periodically to reclaim memory that is no longer in use." +
                "\r\nLifetime:" +
                " Objects allocated on the heap can persist beyond the scope of the method that created them, allowing for more flexible memory management." +
                "\r\nSize Limitations: The heap is typically larger than the stack, allowing for the allocation of larger objects and more complex data structures.");

            Console.WriteLine("Boxing: " +
                "Boxing is the process of converting a value type (like int, double, struct) to a reference type (object). When a value type is boxed," +
                " a new object is allocated to the heap, and the value is copied into it.\r\n\r\nUnboxing:" +
                " Unboxing is the reverse process of boxing, where a value is extracted from an object. " +
                "It involves explicitly converting a reference type (object) into a value type. " +
                "This operation also involves a copy operation, where the value is copied from the heap into the stack.");

            Console.WriteLine("Initialsing varible");
            int x = 10;

            Console.WriteLine("Boxing");
            object y = x; //Boxing
            Console.WriteLine("UnBoxing");
            int z = (int)y; //Unboxing

            Console.WriteLine("If we use Boxing than performance is dregrade" +
                "A program to demontrate it ");

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start(); 

            for(int i = 0; i < 1000000; i++)
            {
                int j = 100;
                object obj = j;
            }
            stopwatch1.Stop();
            Console.WriteLine($"Boxing took: {stopwatch1.ElapsedMilliseconds} MS");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for(int i = 0;i < 1000000; i++)
            {
                object obj = 200;
                int j = Convert.ToInt32(obj);
            }
            Console.WriteLine($"Boxing took: {stopwatch2.ElapsedMilliseconds} MS");

        }

    }
}
