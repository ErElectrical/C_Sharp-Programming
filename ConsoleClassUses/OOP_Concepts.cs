using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClassUses
{
    internal class OOP_Concepts
    {
        public static void oops_explaination()
        {
            Console.WriteLine("Object-Oriented Programming (OOP) is a programming paradigm that uses \"objects\" to design software. The four main principles of OOP are:" +
                "Encapsulation: " +
                "Bundling the data (attributes) and methods (functions) that operate on the data into a single unit or class." +
                " It restricts direct access to some of the object's components.");

            Console.WriteLine("Abstraction: " +
                "Hiding complex implementation details and showing only the essential features of the object." +
                "Inheritance: " +
                "A mechanism where a new class can inherit properties and methods from an existing class, promoting code reusability." +
                "\r\n\r\nPolymorphism: " +
                "The ability to present the same interface for different underlying forms (data types)." +
                " It allows methods to do different things based on the object it is acting upon.");

            Console.WriteLine("Code snippet to understand oops ");

            Animal myDog = new Dog("Buddy");
            Animal myCat = new Cat("Whiskers");

            // Encapsulation: Accessing the Display method
            myDog.Display();
            myCat.Display();

            // Polymorphism: Calling the Speak method
            myDog.Speak(); // Output: Dog barks
            myCat.Speak(); // Output: Cat meows

            Console.WriteLine("A class is simply a user-defined data type that represents both state and behavior." +
                " The state represents the properties and behavior is the action that objects can perform." +
                " In other words, we can say that a class is the blueprint/plan/template that describes the details of an object." +
                " A class is a blueprint from which the individual objects are created." +
                " In C#, a Class is composed of three things i.e. a name, attributes, and operations." +
                "Class keyword is used for creation of class ");

            Console.WriteLine("Objects:" +
                "\r\nIt is an instance of a class. A class is brought live by creating objects." +
                " An object can be considered as a thing that can perform activities." +
                " The set of activities that the object performs defines the object’s behavior." +
                " All the members of a class can be accessed through the object." +
                " To access the class members, we need to use the dot (.) operator." +
                " The dot operator links the name of an object with the name of a member of a class.");

            Console.WriteLine("TYpes of classses in c#" +
                " Abstract Class" +
                "\nConcrete class" +
                "\r\nSealed Class" +
                "\r\nPartial Class" +
                "\r\nStatic Class ");

            Console.WriteLine("It is a special method present inside a class responsible for initializing the variables of that class." +
                "The name of the constructor method is exactly the same name as the class in which it was present." +
                "Constructor do not have any return value" +
                "It is responsible for mainly two tasks -- 1. intialise varibles of class--2 memory allocation "
                );

            Console.WriteLine("Types of constructor :  Explicit constructor --  created by Devloper , Implicit constructor -- if developer do not create constructor" +
                "Than compiler creates constructoir by itself for class as without constructor a class can not be instances ");

            Console.WriteLine("Can we define a method with the same class name in C#?" +
                "\r\nNo, it is not allowed to define a method with the same class name in C#. It will give you a compile-time error. ");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            Console.WriteLine("Static constructor vs Non-static Constructor");
            Console.WriteLine("If a constructor is explicitly declared by using the static modifier," +
                " we call that constructor a static constructor whereas the rest of the others are called non-static constructors ");

            Console.WriteLine("Static constructor initialise static fields where Non-static constructor ." +
                "and non-static fields/variables are initialized by non-static or instance constructors" +
                "Static constructors are implicitly called whereas non-static constructors are explicitly called." +
                "" +
                "whenever a class instances are created and class contain a static constructor than static constructor first excuted before " +
                "creation of object." +
                "static fields are the first member which is excuted by compiler whenever program staarts" +
                "First, the Main method of the Program class starts its execution as it is the entry point for our application." +
                "\r\nThen the Static Constructor of the ConstructorsDemo class is executed." +
                "\r\nThen the Non-Static Constructor of the ConstructorsDemo class is executed." +
                "\r\nFinally, the Main method completes its execution. " +
                "Static Constructors are executed only once whereas the non-static constructors are executed 0 or n number of times depending on the number of instances" +
                " we created for the class");

            Console.WriteLine("Non-Static Constructors can be parameterized whereas the static constructors cannot have any parameter." +
                " This is because we explicitly call the non-static constructors, so we can have a chance to pass parameters. " +
                "On the other hand, static constructors are implicitly called and it is the first block of code to run under a class, " +
                "and hence we don’t have any chance to pass parameters. " +
                "" +
                "There will be only one static constructor under a class " +
                "where non-static constructor can be overloaded.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }

            Console.WriteLine("Private Constructor ");

            Console.WriteLine("when the constructor is created by using the Private Access Specifier," +
                " then it is called a Private Constructor. " +
                "When a class contains a private constructor and if the class does not have any other Public Constructors, " +
                "then you cannot create an object for the class outside of the class." +
                " But we can create objects for the class within the same class. " +
                "private constructor mainly puts restriction on acees of class data , behviour" +
                "" +
                " The use case of Private Constructor is that if you don’t want your class to be instantiated from outside the class, " +
                "then add a private constructor without any public constructor in your class. ");

            Console.WriteLine("If the Parent class has only a private constructor and does not have any public constructors then Inheritance is not possible with outside classes." +
                " But the if the child class is an Inner class of the Parent class, then inheritance is possible ." +
                "If you want to restrict inheritance then don’t go for the private constructor, " +
                "instead, make the Class Sealed which will restrict the class to be inherited from either outside or inside." +
                "" +
                "Private constructor can be overloaded , can be parameter less or with parameter");

            Console.WriteLine("Main use of private Constructor is Designing singleton design pattern." +
                "In singleton Desgin pattern The Singleton design pattern is a creational pattern that ensures a class" +
                " has only one instance and provides a global point of access to that instance." +
                " This pattern is commonly used in scenarios where a single instance of a class is needed to coordinate actions across the system.");

            






        }
    }

    //Base class
    public class Animal
    {
        ///Encapsulation: private field
        private string name;

        //Constructor
        public Animal(string nm)
        {
            this.name = nm;
        }

        //Method to call Animal name
        public void Display()
        {
            Console.WriteLine($"Animal name is {name}");
        }

        // Virtual method for polymorphism
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }


    //Dervied class using inhertiance
    public class Cat : Animal
    {
        //Constructor
        public Cat(string name) : base(name) { }


        //overriding the methos using polymorphism 
        public override void Speak()
        {
            Console.WriteLine("Cat says meow -- meow ");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }



        // Overriding the Speak method (Polymorphism
        public override void Speak()
        {
            Console.WriteLine("Dog says bow -- bow ");
        }
    }

    public sealed class unherited
    {
        private unherited()
        {
            Console.WriteLine("Parent Class Private Constructor is Called");
        }


        private unherited(string msg)
        {
            Console.WriteLine($"Parent Class Private Constructor is Called  {msg}");
        }
        public unherited(string msg,int n)
        {
            Console.WriteLine($"Parent Class public Constructor is Called {msg} --- {n}");
        }

        //As we need to inherited but class is sealed so its not possible 
        //public class Child1 : unherited
        //{
        //    public Child1()
        //    {
        //        Console.WriteLine("Child1 Class Public Constructor is Called");
        //    }
        //}
    }

    //inheritance not possible outside of class due to sealed modifier

    //public class Child2 : unherited
    //{
    //    public Child2()
    //    {
    //        Console.WriteLine("Child2 Class Public Constructor is Called");
    //    }
    //}


}
