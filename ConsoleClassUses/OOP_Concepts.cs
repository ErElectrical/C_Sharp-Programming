using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }

            Console.WriteLine("The Destructor is also a special type of method present in a class, just like a constructor," +
                " having the same name as the class name but prefixed with ~ tilde. " +
                "The Constructor in C# is Explicitly called when the object of the class is created. On the other hand," +
                " the Destructor in C# is Implicitly Called when the object of the class is destroyed." +
                "" +
                "A Destructor is called automatically by the garbage collector when object has no use or program excution is done" +
                "Developer can force garbage collector to call destructor by using GC.Collect() Method ");


            DestructorDemo obj1 = new DestructorDemo();
            DestructorDemo obj2 = new DestructorDemo();
            obj1 = null;

            //This statement force the garbage collector to destoyed all unused objects.
            GC.Collect();
            Console.WriteLine("There's only one Destructor for a class ." +
                "Destructors cannot be called Explicitly. They are invoked automatically by the garbage collector." +
                " At most what we can do is, we can request the Garbage collector to execute the Destructor by calling the GC.Collect() method");

            Console.WriteLine("" +
                "If our application is using an expensive external resource, " +
                "then it is recommended to provide an explicit way to release the resources before the garbage collector frees the object." +
                " To release the resource, it is recommended to implement a Dispose method of the IDisposable interface " +
                "that performs the necessary clean-up for the object." +
                " So, basically, we need our class to inherit from the IDisposable interface and provide the implementation for the Dispose methods" +
                "");

            UmmanagedResource resource = null;
            try
            {
                resource = new UmmanagedResource();
                Console.WriteLine("Using Resources");
            }
            finally
            {
                if (resource != null)
                {
                    Console.WriteLine("Calling Dispose Method to Destroy Resources");
                    resource.Dispose();
                }
            }

            //Trying to Call the Dispose Method again
            Console.WriteLine();
            Console.WriteLine("Trying to Call the Dispose Method Again To Destroy Resources");
            resource.Dispose();

            Console.WriteLine("" +
                "Garbage Collector is nothing but a feature provided by CLR" +
                " that helps us clean or destroy unused managed objects. " +
                "Cleaning or destroying those unused managed objects basically reclaims the memory." +
                "Garbage collector basically clean up memory claims by unused managed object" +
                "It doesnot count for umanged objects");

            Console.WriteLine("Managed Code" +
                "\r\nManaged code is code that is executed by the Common Language Runtime (CLR) in the .NET framework." +
                " The CLR provides various services, including garbage collection, type safety, exception handling, and security." +
                "Most C# code you write, including classes, methods, and properties, is managed code" +
                "");


            Console.WriteLine("" +
                "Unmanaged code" +
                " is code that is executed directly by the operating system outside the control of the CLR. " +
                "This includes code written in languages like C and C++ that do not run under the CLR." +
                " ");


            Console.WriteLine(" Access Specifiers are used to define the scope of the type (Class, Interface, Structs, Delegate, Enum, etc.) " +
                "as well as the scope of their members (Variables, Properties, Constructors, and Methods). " +
                "Scope means accessibility or visibility that is who can access them and who cannot access them are defined by the Access Specifiers.");

            Console.WriteLine("C# supports 6 types of access specifiers. " +
                "They are as follows" +
                "\r\n\r\nPrivate" +
                "\r\nPublic" +
                "\r\nProtected" +
                "\r\nInternal" +
                "\r\nProtected Internal" +
                "\r\nPrivate Protected (C# Version 7.2 onwards)" +
                "" +
                "");

            Console.WriteLine("" +
                "Assemblies" +
                "\r\nDefinition: " +
                "An assembly is a compiled code library used for deployment, versioning, and security in .NET applications. It can be an executable (.exe) or a library (.dll)." +
                "\r\n\r\nComponents:" +
                "\r\n\r\n" +
                "Manifest: Contains metadata about the assembly (name, version, culture)." +
                "\r\nType Metadata: Information about the types (classes, interfaces) defined in the assembly." +
                "\r\nIntermediate Language (IL) Code:" +
                " The compiled code executed by the .NET runtime." +
                "\r\nResources: " +
                "Additional files (images, strings) used by the assembly." +
                "\r\nTypes:" +
                "\r\n\r\nExecutable Assemblies: Applications that can be run directly.\r\nLibrary Assemblies: Reusable libraries for other applications." +
                "\r\nVersioning: Assemblies support versioning, allowing multiple versions to coexist." +
                "\r\n\r\nStrong-Named Assemblies: Assemblies with a unique identity (name, version, public key) for security and versioning." +
                "\r\n\r\n" +
                "Global Assembly Cache (GAC): A machine-wide cache for shared assemblies that are strong-named." +
                "\r\n\r\nLoading: " +
                "Assemblies can be loaded statically (at compile time) or dynamically (at runtime using methods like Assembly.Load).");

            Console.WriteLine("Types of Aceess Speicier " +
                "" +
                "" +
                "Public Aceess specifiers :" +
                " Members declared as public are accessible from any other code in the same assembly or another assembly that references it." +
                "\r\nUsage: Use public when you want to expose a member to all other classes and assemblies." +
                "" +
                "" +
                "Private: " +
                "Members declared as private are accessible only within the body of the class or struct in which they are declared. " +
                "They are not accessible from outside the class." +
                "\r\nUsage:" +
                " Use private to encapsulate data and restrict access to it, ensuring that it can only be modified by the class itself." +
                "" +
                "" +
                "Protected:" +
                " Members declared as protected are accessible within their own class and by inherited class. They are not accessible from outside the class hierarchy." +
                "\r\nUsage: Use protected when you want to allow access to a member for classes that inherit from the base class but not for other classes." +
                "" +
                "Internal:" +
                " Members declared as internal are accessible only within the same assembly (project). " +
                "They are not accessible from another assembly." +
                "\r\nUsage: " +
                "Use internal when you want to expose members to other classes in the same assembly but keep them hidden from other assemblies." +
                "" +
                "" +
                " Protected Internal\r\n: " +
                "Members declared as protected internal are accessible from the current assembly and from derived classes in other assemblies. " +
                "This is a combination of protected and internal." +
                "\r\nUsage: " +
                "Use protected internal when you want to allow access to a member from both derived classes and classes within the same assembly." +
                "" +
                "Private Protected: Accessible within the same class and derived classes, but only in the same assembly.");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            Console.WriteLine("Encapsulation Hides the internal state and functionality of an object and only allows access through a public set of functions." +
                " Let us simplify the above definition as follows:" +
                "\r\n\r\nThe process of binding or grouping the State (i.e., Data Members) and Behaviour (i.e., Member Functions) together into a single unit (i.e., class, interface, struct, etc.) is called Encapsulation " +
                ". The Encapsulation Principle ensures that the state and behavior of a unit (i.e., class, interface, struct, etc.) cannot be accessed directly from other units (i.e., class, interface, struct, etc.)." +
                "Through encapsulation we can validate inputs before passing it to varible as state can not be changed directly");

            Console.WriteLine("" +
                "Abstraction is one of the fundamental principles of Object-Oriented Programming (OOP) ." +
                " It allows you to hide the complex implementation details of a system and expose only the necessary parts to the user." +
                " This helps in reducing complexity and increasing efficiency by allowing the user to interact with the system at a higher level" +
                " without needing to understand the underlying details." +
                "" +
                "" +
                "we can implement abstraction in two ways" +
                "1.using Interface." +
                "2.using Abstarct classes and abstarct Method.");


            //abstraction achieved by Interface
            IBank sbi = BankFactory.Getbank("SBI");
            IBank Axiss = BankFactory.Getbank("Axis");
            sbi.BankTransfer();
            sbi.CheckBalanace();
            sbi.MiniStatement();
            sbi.ValidateCard();
            sbi.WithdrawMoney();
            Axiss.BankTransfer();
            Axiss.CheckBalanace();
            Axiss.MiniStatement();
            Axiss.ValidateCard();
            Axiss.WithdrawMoney();


            //abstraction achieevd by Abstract class and Methods

            Ibank Canara = new Canara();
            Ibank ISBT = new ISBI();
            Canara.BankTransfer();
            Canara.CheckBalanace();
            Canara.MiniStatement();
            Canara.ValidateCard();
            Canara.WithdrawMoney();
            ISBT.BankTransfer();
            ISBT.CheckBalanace();
            ISBT.MiniStatement();
            ISBT.ValidateCard();
            ISBT.WithdrawMoney();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }

            Console.WriteLine($"Inheritance in C# is a mechanism of consuming the members that are defined in one class from another class." +
                $"It enhance code reusibility");

            B obj54 = new B(10);
            B obj55 = new B(20);
            B obj35 = new B(30);

            Console.WriteLine($"Single Inheritance (Single, Multilevel, and Hierarchical)" +
                $"\r\nMultiple Inheritance (Multiple and Hybrid)");

            Console.WriteLine("Handling the complexity caused due to multiple inheritances is very complex." +
                " Hence it was not supported in dot net with class and it can be done with interfaces." +
                "e.g : public class OPPO : Phone,Android ");

            Console.WriteLine("\n The IS-A relationship is used to describe inheritance. " +
                "It indicates that one class is a specialized version of another class. " +
                "In other words, a derived class (child class) is a type of the base class (parent class).");

            Console.WriteLine(" The HAS-A relationship describes composition or aggregation.\n" +
                " It indicates that one class contains or is composed of one or more instances of another class. " +
                "This relationship is used to model how objects are composed of other objects.");


            //Cons

            Console.WriteLine(" Abstract Class:" +
                "An abstract class in C# is a class that cannot be instantiated directly." +
                " It is designed to be a base class from which other classes can derive." +
                " It can contain both abstract methods (without implementation) and concrete methods (with implementation)." +
                "Purpose: The purpose of an abstract class is to provide a common interface and shared functionality for derived classes.");

            Console.WriteLine("Abstract Method:" +
                " An abstract method is a method that is declared without an implementation in an abstract class. It must be implemented in any non-abstract derived class." +
                "Purpose: Abstract methods define a contract that derived classes must fulfill by providing their own implementations.");


            phone nookia = new Nokia();
            nookia.CompanyName();


            Console.WriteLine("Important Notes on abstract class and abstract Method");

            Console.WriteLine("When to use the Abstract Method" +
                "\r\nAbstract methods are usually declared where two or more subclasses are expected to fulfill a similar role in a different manner." +
                " You can also do the same thing using an interface also." +
                " But if we are using an abstract class means we can provide some common functionality that is going to be the same for all the child classes " +
                "and this is not possible using the interface.");

            Console.WriteLine("abstract class object is created when a subclass instastinted." +
                "This is because abstract class contains concerte and static Methods that needs to be exist in memory" +
                "we can call static methods of abtsrct class just through class name and abstract method will be called by " +
                "subclass (derived class) object");

            Console.WriteLine("Can we Declare an Abstract Method as Static" +
                "NO, we can not do it it will give a compile time error" +
                "Because abstract method defination needs to be provided in derived class and if it is static than it may be called before its defination provided which cretes a choas" +
                "" +
                "" +
                "Can we Declare an Abstract Method as Sealed" +
                "No we can not do it because abstract methods meants to be inherited and override " +
                "and if it is sealed than it can not be inheited or overridden" +
                "" +
                "" +
                "Can we Declare an Abstract Method as Private" +
                "No , Because if it is private than it can not be accessible outside of boxees" +
                "" +
                "Difference Between Abstract Methods and Method Overriding " +
                "Both are nearly same the only difference is if method in base class is virtual than it is optional for dericed class" +
                "to re-implmentiotion of virtual method" +
                "But if it is abstract than it is mandatory for the derived class to provide proper behaviour to the method.");

            shape rect = new Rectangle(10.23, 31.23);
            Console.WriteLine(rect.GetArea());
            shape cir = new circle(563.45);
            cir.GetArea();

            Console.WriteLine(" Interface is a fundamental concept defining a contract or a set of rules a class must adhere to." +
                " It specifies a list of methods, properties, events, or indexers a class implementing the interface must provide. " +
                "Interfaces allow you to define a common set of functionality that multiple classes can share, promoting code reusability and ensuring a consistent structure " +
                "for related classes." +
                "Interface helps in achieve abstraction and multiple inheritance." +
                "Interface can not be insiteted . " +
                "Key Characteristics of Interfaces" +
                "\r\n" +
                "No Implementation:" +
                " Interfaces cannot contain any implementation. They only define the signatures of methods, properties, events, or indexers." +
                "\r\n\r\n" +
                "Multiple Inheritance:" +
                " A class or struct can implement multiple interfaces, allowing for a form of multiple inheritance." +
                "\r\n\r\n" +
                "Public Members:" +
                " All members of an interface are implicitly public, and you cannot specify any access modifiers." +
                "\r\n\r\n" +
                "Cannot Contain Fields:" +
                " Interfaces cannot contain fields or constructors." +
                "\r\n\r\n" +
                "Can Contain Properties: " +
                "Interfaces can define properties, but they cannot provide any implementation for them.");


            Console.WriteLine("" +
                "The Interface in C# is a fully un-implemented class used for declaring a set of methods of an object." +
                "So, we can define an interface as a pure abstract class which allows us to define only abstract methods." +
                " The abstract method means a method without a body or implementation." +
                "" +
                "\r\n\r\n" +
                "\r\n\r\n" +
                "It is used to achieve multiple inheritances which can’t be achieved by class. " +
                "It is used to achieve full abstraction because it cannot have a method body.\r\n\r\n" +
                "" +
                "A class can be inherited either from another class or from an interface also." +
                " So, inheritance can be divided into two categories" +
                "\r\n\r\n" +
                "Implementation Inheritance -- If a class is inherited from a class.Child class can use the Methods of and fields of parent class ." +
                "\r\nInterface Inheritance -- If a class inherited a interface . As we know child class had to provide defination for its Method." +
                "Interface provide abstraction and multiple inheritance ." +
                "" +
                "Methods of interface are public default and we can not change its visibility" +
                "" +
                "interface con inherit another interface but it can not be a child of an abstract class." +
                "" +
                "" +
                "Interface can not be declared as sealed because an interface meants to be inherited where " +
                "sealed keyword makes it impotent." +
                "" +
                "Class can inherit multiple interfaces but it can have only  a single subclass ." +
                "" +
                "Difference between Interface and Class ." +
                "" +
                "interface can not be instantiate ." +
                "interface contains only abstract and public method name with their return type." +
                "interface is not extended by class,it is implemented by the class." +
                "" +
                "Similarity between Interface and abstract class." +
                "both can not be instantiated  means we can not create object for them." +
                "whoever inhrit this it becomes a contract for child to provide defination to interace all methods" +
                "Both intercae and abstract can not be sealed." +
                "" +
                " Difference Between Interface and Abstract Class" +
                "" +
                "The interface is a fully un-implemented class used for declaring a set of methods of an object. " +
                "The abstract class is a partially implemented class. It implements some of the methods of an object. " +
                "These implemented methods are common for all next-level subclasses." +
                " The remaining operations are implemented by the next-level subclasses according to their requirement." +
                "\r\n\r\n" +
                "The interface allows us to develop multiple inheritances." +
                " So, we must start object design with interface whereas abstract class does not support multiple inheritances " +
                "so it always comes next to interface in the object creation process." +
                "" +
                "Abstract Class:" +
                "\r\n" +
                "It is a partially implemented class. It allows us to define both concrete and abstract methods." +
                "\r\n" +
                "It should be declared as abstract by using the abstract keyword, abstract methods should also contain the abstract keyword." +
                "\r\nIts member’s default accessibility modifier is private and can be changed to any of the other accessibility modifiers." +
                "\r\nIt is possible to declare data fields in an abstract class." +
                "\r\nAn abstract class can contain a non-abstract function." +
                "\r\nAn abstract class can inherit from another abstract class or from an interface." +
                "\r\nAn abstract class cannot be used to implement multiple inheritances." +
                "\r\nAbstract class members can have Access Specifiers." +
                "" +
                "Interface:" +
                "\r\n" +
                "It is a fully un-implemented class. It allows us to define only abstract methods." +
                "\r\n" +
                "It should be created by using the keyword interface. By default, all the members are abstract only. Explicitly using abstract keyword is not allowed." +
                "\r\n" +
                "Its member’s default accessibility modifier is public and cannot be changed." +
                "\r\n" +
                "It is not possible to declare any data fields in an interface." +
                "\r\n" +
                "An interface cannot contain non-abstract functions." +
                "\r\n" +
                "An interface can inherit from only other interfaces but cannot inherits from the abstract class." +
                "\r\n" +
                "An interface can be used to implement multiple inheritances." +
                "\r\n" +
                "Interface members cannot have Access Specifiers." +
                "" +
                "Let's See a real time example of interface through a bank application." +
                "" +
                "When do you choose interface over an abstract class or vice versa ?  \n" +
                "If we want some implementation that will be the same for all the derived classes," +
                " then it is better to go for an abstract class instead of an interface. " +
                "" +
                "With the interface, we can move our implementation to any class that implements the interface." +
                " With the abstract class, we can share the implementation for all the derived classes in one central place," +
                " and thus avoid code duplication in the derived classes." +
                "\r\n" +
                "" +
                "Can an interface inherit from another interface ?" +
                "Yes it is possible for a interface to inheirt other interface in this case it becomes contract for derived class to provide implemntation of both " +
                "interfaces methods." +
                "" +
                "" +
                "interfcaes can not be instantited means object creation can not be done for interface." +
                "\n If a class derived a interfaces " +
                "\n 1. provide implementation of all of the methods" +
                "\n 2. if some methods not needed for implementation than use abstract keyword and leave implemetation of it" +
                "" +
                "\n If a interface inherit another interface and both interfacses has same method name and signature" +
                "\n than derived class has to implement both methods explicitly." +
                "" +
                "\n Let's take a real time example of multiple inheritance." +
                "" +
                "\nA scenario involving a FlyingCar that can both drive and fly." +
                "" +
                " We will define two interfaces, IDriveable and IFlyable, and then implement these interfaces in a FlyingCar class.");

            IBankIndia saving = new HdfcSavingaccount(10000);
            saving.CheckBalance();
            saving.DepositAmount(2700);
            saving.WithdrawAmount(5000);

            IBankIndia current = new HdfcCurrentaccount(8000);
            current.CheckBalance();
            current.DepositAmount(2700);
            current.WithdrawAmount(5000);


            FlyingCar myFlyingCar = new FlyingCar();

            myFlyingCar.stop();
            myFlyingCar.run();
            myFlyingCar.TakeOff();
            myFlyingCar.Fly();


            Console.WriteLine("Polymorphism means takes more than one form." +
                "In programming its means a function changes its behaviour based on types of input" +
                "As a developer we seen them in BSL classes also." +
                "" +
                "\n" +
                "Types of polymorphism" +
                "1. static polymorphism, compile - time polymorphism , Early binding .e.g - Method overloading , Method hiding , Opreator overloading" +
                "2. Dynamic polymorphism , run - time polymorphism , Late binding e.g : Method overriding " +
                "" +
                "Static polymorphism -- Behaviour of Method is decided at compile time." +
                "Method overloading is an example of it" +
                "As linking between function call and function defination happens at compile time so it is calles as early binding." +
                "" +
                "" +
                "Dynamic polymorphism :" +
                "\n In late binding behaviour of Method is decided at run time " +
                "\n when its object is called . As linking between method call and method defination occurs at run time " +
                "\n therefore it is called as late binding .");

            staticpolymorphism pm = new staticpolymorphism();
            pm.Add(10, 15);
            pm.Add(10.5f, 20.5f);
            pm.Add("Mohit", "Tanwar");

            MethodOverriding mo = new class2();
            mo.method(); // which method needs to be called is decided at run time.

            MethodOverloading obj = new MethodOverloading();
            obj.Method(); //Invoke the 1st Method
            obj.Method(10); //Invoke the 2nd Method
            obj.Method("Hello"); //Invoke the 3rd Method
            obj.Method(10, "Hello"); //Invoke the 4th Method
            obj.Method("Hello", 10); //Invoke the 5th Method

            Console.WriteLine("" +
                "Encapsulation is one of the fundamental principles of Object-Oriented Programming (OOP)." +
                " In C#, as with other OOP languages, encapsulation refers to bundling related data and behaviors into a single unit (typically a class) and restricting access" +
                " to some of the object’s components. It helps protect the data’s integrity and expose only what’s necessary to the outside world." +
                "");

            // Starts with a balance of 500
            EncapsulationRealLifeExample myAccount = new EncapsulationRealLifeExample(500);

            // Balance becomes 700
            myAccount.Deposit(200);
            Console.WriteLine($" Your Balance is :---- {myAccount.Balance}"); // Outputs: 700

            // Balance becomes 600
            myAccount.Withdraw(100);
            Console.WriteLine($" Your Balance is :---- {myAccount.Balance}"); // Outputs: 600

            // myAccount.balance = -1000;  // This would be an error, as the balance field is private and inaccessible directly.

            CoffeeMachine myMachine = new CoffeeMachine(1000, 100);  // Initialize with 1000 ml of water and 100 grams of beans
            myMachine.MakeEspresso();  // Outputs: Heating water... Grinding coffee beans... Making Espresso...
            Console.WriteLine($"Beans left: {myMachine.BeansLeft()} grams");  // 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }

            Console.WriteLine("" +
                "Abstraction is a foundational concept in object-oriented programming (OOP) . " +
                " abstraction refers to hiding the complex implementation details and showing only the essential features of an object." +
                " Here’s a more detailed explanation:" +
                "\r\n\r\nHiding Complexity:" +
                " Just like a car dashboard doesn’t show all the intricate details of how the engine works" +
                " but provides you with a few essential controls (like the steering wheel, accelerator, brakes, etc.), " +
                "abstraction in programming is about hiding the intricate details of how something works and providing only the essential operations to work with it." +
                "\r\nFacilitating Extensibility: " +
                "Because abstraction allows you to hide implementation details behind a consistent interface," +
                " you can later change the underlying implementation without affecting the code that uses this abstraction." +
                "\r\nUsing Classes and Interfaces: " +
                " abstraction can be achieved using classes and interfaces. " +
                "While you can’t create an instance of an abstract class, you can use its shape (properties and methods) in child classes." +
                " Interfaces go a step further by only defining the shape without any implementation, enforcing concrete classes to provide the specifics.");

            static void SendAlert(IMessagingService service, string recipient, string message)
            {
                service.SendMessage(recipient, message);
            }

            //Using the Abstraction
            Vehicle myCar = new Car();
            Vehicle myTrain = new ElectricTrain();

            myCar.Stop();
            myCar.Start();
            myTrain.Stop();
            myTrain.Start();

            Console.WriteLine("" +
                "" +
                "Imagine a system that has to communicate with multiple messaging platforms: " +
                "Email, SMS, and Push Notification. Without abstraction, you might end up with methods like SendEmail(), SendSms(), SendPushNotification(), etc." +
                " scattered throughout your application. " +
                "If a new messaging method is added, you must add another method and call it differently." +
                "" +
                "");

            IMessagingService emailService = new EmailService();
            IMessagingService smsService = new SmsService();
            IMessagingService pushService = new PushNotificationService();
            SendAlert(emailService, "example@example.com", "Hello via Email!");
            SendAlert(smsService, "1234567890", "Hello via SMS!");
            SendAlert(pushService, "User123", "Hello via Push Notification!");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }

            IMediaPlayer vd = new VideoPlayer();
            IMediaPlayer sd = new AudioPlayer();
            vd.Play("Heropanti.mkv");
            sd.Play("song.mp4");

            MallCounter cc = new creditcardPayment();
            MallCounter pp = new PaypalPayment();
            MallCounter Bp = new BitCoinPayment();
            cc.Welcome();
            cc.PaymentSuccessfull();
            pp.Welcome();
            pp.PaymentSuccessfull();
            Bp.Welcome();
            pp.PaymentSuccessfull();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }


            Console.WriteLine("" +
                "inheritance is another core principle of object-oriented programming." +
                " It allows a class to inherit properties and methods from another, promoting code reuse and establishing a natural hierarchy between classes.;" +
                "" +
                "Base Class (Parent Class):" +
                " The class whose members are inherited by another class. It’s also known as the superclass or parent class." +
                "\r\nDerived Class (Child Class):" +
                " The class that inherits members from the base class. It can also introduce additional members or override inherited ones." +
                " It’s also known as the subclass or child class." +
                "\r\nInheritance Chain: " +
                "Classes can inherit from a class that inherits from another class, leading to an inheritance “chain” or “hierarchy.”" +
                "\r\nAccess Modifiers: " +
                "Only members with public, protected, or internal access modifiers in the base class are accessible from the derived class. " +
                "Private members of the base class are not accessible in the derived class." +
                "\r\nMethod Overriding: " +
                "If the base class defines a method as virtual, the derived class can override this method using the override keyword." +
                " This allows the derived class to provide a specific implementation for that method." +
                "\r\n" +
                "The base Keyword: " +
                "Inside a derived class, you can use the base keyword to access members of the base class." +
                "\r\n" +
                "Sealed Classes:" +
                "if you want to prevent a class from being inherited, you can mark it with the sealed keyword.");

            CarII myCarII = new CarII { Doors = 4 };
            myCarII.Start();
            myCarII.Accelerate();
            myCarII.OpenSunroof();
            myCarII.Stop();
            Console.WriteLine();
            Motorcycle myBike = new Motorcycle { HasSideCar = false };
            myBike.Start();
            myBike.Accelerate();
            myBike.UseKickstand();
            myBike.Stop();

            Console.WriteLine("Polymorphism is a fundamental principle in object-oriented programming (OOP) that allows objects of different classes to be treated as objects of a common superclass." +
                "polymorphism helps in invoke nodes of derived classes through base class referrence." +
                "Compile-Time Polymorphism (Static Polymorphism):" +
                "\r\n" +
                "Achieved by method overloading or operator overloading." +
                "\r\n" +
                "The method call is resolved at compile-time." +
                "\r\nRun-Time Polymorphism (Dynamic Polymorphism):" +
                "\r\n" +
                "Achieved by method overriding." +
                "\r\n" +
                "The method call is resolved at runtime based on the actual object type." +
                "\r\n" +
                "In C#, this is implemented using the virtual keyword in the base class method and the override keyword in the derived class method.");

            shapeII pg = new pentagaon();
            shapeII Sg = new Hexagaon();
            pg.MakeSound();
            Sg.MakeSound();


        }
    }


    public class MethodOverloading
    {
        public void Method()
        {
            Console.WriteLine("1st Method");
        }
        public void Method(int i)
        {
            Console.WriteLine("2nd Method");
        }
        public void Method(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void Method(int i, string s)
        {
            Console.WriteLine("4th Method");
        }
        public void Method(string s, int i)
        {
            Console.WriteLine("5th Method");
        }
    }

    public class MethodOverriding
    {
        public virtual void method()
        {
            Console.WriteLine("Call from Parent class.");
        }
    }

    public class class2 : MethodOverriding
    {
        public override void method()
        {
            Console.WriteLine("Call from child class.");
        }
    }
    public class staticpolymorphism
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(float x, float y)
        {
            Console.WriteLine(x + y);
        }
        public void Add(string s1, string s2)
        {
            Console.WriteLine(s1 + " " + s2);
        }
    }
    public interface IDriveable
    {
        void stop();
        void run();
    }

    public interface IFlyable
    {
        void TakeOff();
        void Fly();
    }

    public class FlyingCar : IFlyable, IDriveable
    {
        public void stop()
        {
            Console.WriteLine("Car is starting.");
        }

        public void run()
        {
            Console.WriteLine("Car is stopping.");
        }

        public void TakeOff()
        {
            Console.WriteLine("Airplane is taking off.");
        }

        public void Fly()
        {
            Console.WriteLine("Airplane is landing.");
        }

    }

    public interface IBankIndia
    {
        void DepositAmount(double amount);
        void WithdrawAmount(double amount);
        void CheckBalance();
    }

    public class HdfcSavingaccount : IBankIndia
    {
        private double balance = 0;
        private double perdaywithdrwalLimit = 10000;
        private double todaywithdrawal = 0;

        public HdfcSavingaccount(double bal)
        {
            this.balance = bal;

        }

        public void DepositAmount(double amount)
        {
            balance = balance + amount;
            Console.Write($"Balance ammount is {balance}");
        }

        public void WithdrawAmount(double amount)
        {
            if (amount >= balance)
            {
                Console.WriteLine("Sorry insufficient balance");
            }
            else if (amount >= perdaywithdrwalLimit)
            {
                Console.WriteLine("Sorry Limit exceeded");
            }
            else
            {
                balance = balance - todaywithdrawal;
                Console.WriteLine($"Amount withdrawal successfully. " +
                    $" Balnce remain {balance}");
            }
        }

        public void CheckBalance()
        {
            Console.Write($"Balance ammount is {balance}");
        }
    }

    public class HdfcCurrentaccount : IBankIndia
    {
        private double balance = 0;

        private double todaywithdrawal = 0;

        public HdfcCurrentaccount(double bal)
        {
            this.balance = bal;

        }

        public void DepositAmount(double amount)
        {
            balance = balance + amount;
            Console.Write($"Balance ammount is {balance}");
        }

        public void WithdrawAmount(double amount)
        {
            if (amount >= balance)
            {
                Console.WriteLine("Sorry insufficient balance");
            }

            else
            {
                balance = balance - todaywithdrawal;
                Console.WriteLine($"Amount withdrawal successfully. " +
                    $" Balnce remain {balance}");
            }
        }

        public void CheckBalance()
        {
            Console.Write($"Balance ammount is {balance}");
        }
    }

    //Abstarct class is a class that can not be instited directly
    //it acts as a blueprint for dervied class contains abstract method and concerte method.
    //Purpose of abstract class is to create a common interface and shared functionality between derived classes .


    //it is neccessary for interface name to start with I
    public interface IBikeWarehouse
    {
        void CompanyName();
        void ModelYear();


    }


    public class Apache : IBikeWarehouse
    {
        public void CompanyName()
        {
            Console.WriteLine("Apache rtr 180");
        }

        public void ModelYear()
        {
            Console.WriteLine("Apache rtr 180 -- 2014");
        }
    }

    public class Hero : IBikeWarehouse
    {
        public void CompanyName()
        {
            Console.WriteLine("Hero pulsar 150");
        }

        public void ModelYear()
        {
            Console.WriteLine("Hero pulsar 180 -- 2015");
        }
    }


    public abstract class shape
    {
        public double height;
        public double width;
        public double Radius;
        public const float PI = 3.14f;
        public abstract double GetArea();
    }

    internal class Rectangle : shape
    {
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double GetArea()
        {
            return height * width;
        }
    }

    public class circle : shape
    {
        public circle(double radius)
        {
            this.Radius = radius;
        }
        public override double GetArea()
        {
            return PI * Radius;
        }
    }
    public abstract class phone
    {
        public static void smartphone()
        {
            Console.WriteLine("I am a smartphone");
        }

        public abstract void CompanyName();
    }

    public class Nokia : phone
    {
        public override void CompanyName()
        {
            Console.WriteLine("I am Noika");
            phone.smartphone();
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
        public unherited(string msg, int n)
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

    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor Object Created");
        }
        ~DestructorDemo()
        {
            string type = GetType().Name;
            Console.WriteLine($"Object {type} is Destroyed");
        }
    }


    public class UmmanagedResource : IDisposable
    {
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    //Write Code Here to Destroy the Managed Resources
                    Console.WriteLine("Managed Resources Destroyed by Dispose Method");
                }

                //Write Code Here to Destroy the Umanaged Resources
                Console.WriteLine("Unmanaged Resources Destroyed by Dispose Method");
                disposedValue = true;
            }
            else
            {
                Console.WriteLine("Resources are Already Destroyed by Dispose Method");
            }
        }

        ~UmmanagedResource()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Destructor to Destroy the Resources");
            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            //Write Code here to Destroy the Object
            Console.WriteLine("Request Comes to Dispose Method to Destroy the Resources");
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }


    //Members declared as public are accessible from any other code in the same assembly or another assembly that references it.
    public class MyClass
    {
        public int MyProperty { get; set; }
    }

    public class MyClass1
    {
        private int myField;

        private void MyMethod()
        {
            // This method can only be called within MyClass
        }
    }


    public class BaseClass
    {
        protected int myProtectedField;
    }

    public class DerivedClass : BaseClass
    {
        public void AccessProtectedField()
        {
            myProtectedField = 10; // Accessible here
        }
    }

    internal class MyInternalClass
    {
        internal void MyInternalMethod()
        {
            // This method can be accessed only within the same assembly
        }
    }


    //Protected Internal: Accessible within the same assembly and derived classes.
    public class MyClass2
    {
        protected internal int myProtectedInternalField;
    }

    public class DerivedClass1 : MyClass2
    {
        public void AccessField()
        {
            myProtectedInternalField = 10; // Accessible here
        }
    }

    public class AnotherClass
    {
        public void AccessField(MyClass2 obj)
        {
            obj.myProtectedInternalField = 20; // Accessible here if in the same assembly
        }
    }

    public class Bank
    {
        private double _Amount;
        private long AccountNo = 1222123190;
        private string Name = "Mohit Tanwar";

        public double Amount
        {
            get
            {
                return _Amount;
            }
            set
            {
                // Validate the value before storing it in the _Amount variable
                if (value < 0)
                {

                    Console.WriteLine($"Balance can not be negative");
                    //throw new Exception("Please Pass a Positive Value");
                }
                else
                {
                    Console.WriteLine($"Account Number is : {AccountNo}");
                    _Amount = value;
                }
            }
        }
    }


    //Here we are trying to achieve abstraction using interface.
    //Interface contains only methods defination it is responsbility of the derived classses
    //to provide proper logic to it.
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }

    public class SBI : IBank
    {
        public void ValidateCard()
        {
            Console.WriteLine("Crad validation done by SBI");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Money withdrwal done by SBI");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("Balance check done by SBI");
        }

        public void BankTransfer()
        {
            Console.WriteLine("Bank Transfer request  done by SBI");
        }

        public void MiniStatement()
        {
            Console.WriteLine("MiniStatement  request  done by SBI");
        }
    }

    public class Axis : IBank
    {
        public void ValidateCard()
        {
            Console.WriteLine("Crad validation done by Axis");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Money withdrwal done by Axis");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("Balance check done by Axis");
        }

        public void BankTransfer()
        {
            Console.WriteLine("Bank Transfer request  done by Axis");
        }

        public void MiniStatement()
        {
            Console.WriteLine("MiniStatement  request  done by Axis");
        }
    }

    public class BankFactory
    {
        public static IBank Getbank(string type)
        {
            IBank ob = null;
            if (type == "SBI")
            {
                ob = new SBI();
            }
            else
            {
                ob = new Axis();
            }
            return ob;
        }
    }

    internal abstract class Ibank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }

    internal class Canara : Ibank
    {
        public override void ValidateCard()
        {
            Console.WriteLine("Crad validation done by Canara");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("Money withdrwal done by Canara");
        }

        public override void CheckBalanace()
        {
            Console.WriteLine("Balance check done by Canara");
        }

        public override void BankTransfer()
        {
            Console.WriteLine("Bank Transfer request  done by Canara");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("MiniStatement  request  done by Canara");
        }
    }

    internal class ISBI : Ibank
    {
        public override void ValidateCard()
        {
            Console.WriteLine("Crad validation done by ISBI");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("Money withdrwal done by ISBI");
        }

        public override void CheckBalanace()
        {
            Console.WriteLine("Balance check done by ISBI");
        }

        public override void BankTransfer()
        {
            Console.WriteLine("Bank Transfer request  done by ISBI");
        }

        public override void MiniStatement()
        {
            Console.WriteLine("MiniStatement  request  done by ISBI");
        }
    }


    class A
    {
        public A(int number)
        {
            Console.WriteLine($"Class A Constructor is Called : {number}");
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    class B : A
    {
        public B(int num) : base(num)
        {
            Console.WriteLine("Class B Constructor is Called");
        }
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

    }


    internal class EncapsulationRealLifeExample
    {
        // This private field is encapsulated and can't be directly accessed from outside the class.
        private decimal balance;

        public decimal Balance
        {
            // Only provides a way to read the balance but not modify it directly.
            get { return balance; }
        }

        public EncapsulationRealLifeExample(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }

            balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be positive.");
            }

            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount should be positive.");
            }

            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            balance -= amount;
        }

    }

    public class CoffeeMachine
    {
        private int waterAmount; // in milliliters
        private int beansAmount; // in grams
        private bool isHeated;
        public CoffeeMachine(int water, int beans)
        {
            waterAmount = water;
            beansAmount = beans;
            isHeated = false;
        }
        private void HeatWater()
        {
            if (!isHeated)
            {
                Console.WriteLine("Heating water...");
                isHeated = true;
            }
        }

        private void GrindBeans(int amount)
        {
            if (beansAmount < amount)
            {
                throw new InvalidOperationException("Not enough coffee beans!");
            }
            Console.WriteLine("Grinding coffee beans...");
            beansAmount -= amount;
        }
        // This is the method exposed to the user.
        public void MakeEspresso()
        {
            HeatWater();
            GrindBeans(20); // let's say we need 20 grams of beans for an espresso
            Console.WriteLine("Making Espresso...");
        }
        // Another method exposed to the user.
        public void MakeLatte()
        {
            HeatWater();
            GrindBeans(25); // we need 25 grams of beans for a latte
            Console.WriteLine("Making Latte...");
        }
        public int BeansLeft()
        {
            return beansAmount;
        }

        public int WaterLeft()
        {
            return waterAmount;
        }
    }

    public abstract class Vehicle
    {
        // These are abstract methods; the derived classes will provide the implementation.
        public abstract void Start();
        public abstract void Stop();
    }
    //Concrete Implementations
    public class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a key turn.");
        }
        public override void Stop()
        {
            Console.WriteLine("Car is stopping using its brakes.");
        }
    }
    public class ElectricTrain : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Electric train is starting by powering up.");
        }
        public override void Stop()
        {
            Console.WriteLine("Electric train is stopping by cutting off the power.");
        }
    }

    public interface IMessagingService
    {
        void SendMessage(string recipient, string message);
    }

    public class EmailService : IMessagingService
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending Email to {recipient}: {message}");
            // Here, you'd have the actual logic to send an email.
        }
    }
    public class SmsService : IMessagingService
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {message}");
            // Here, you'd have the actual logic to send an SMS.
        }
    }
    public class PushNotificationService : IMessagingService
    {
        public void SendMessage(string recipient, string message)
        {
            Console.WriteLine($"Sending Push Notification to {recipient}: {message}");
            // Here, you'd have the actual logic to send a push notification.
        }
    }

    public interface IMediaPlayer
    {
        void Play(string filePath);
    }

    public class AudioPlayer : IMediaPlayer
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing song from  {filePath}");
        }
    }

    public class VideoPlayer : IMediaPlayer
    {
        public void Play(string filePath)
        {
            Console.WriteLine($"Playing video from  {filePath}");
        }
    }

    //Let’s imagine a scenario where you’re developing a system for an online store that supports multiple payment methods like Credit Cards, PayPal, and Bitcoin.
    //Without abstraction, you’d potentially have disparate methods like ProcessCreditCardPayment(), ProcessPayPalPayment(), etc.
    //This would make the system rigid and difficult to extend if you were to introduce new payment methods.

    public abstract class MallCounter
    {
        internal void Welcome()
        {
            Console.WriteLine("Welcome To Elante Mall");
        }

        internal abstract bool PaymentSuccessfull();
    }

    internal class creditcardPayment : MallCounter
    {
        internal override bool PaymentSuccessfull()
        {

            Console.WriteLine("Credit card payment choosen by user" +
                "Need pincode of crdit card");
            return true;
        }
    }

    internal class PaypalPayment : MallCounter
    {
        internal override bool PaymentSuccessfull()
        {

            Console.WriteLine("Paypal account payment choosen by user" +
                "Need Dmeat id of Paypal ");
            return true;
        }
    }

    internal class BitCoinPayment : MallCounter
    {
        internal override bool PaymentSuccessfull()
        {

            Console.WriteLine("BitCoin account payment choosen by user" +
                "Need Seeler Bitcon credentials  id of Bitcoin  ");
            return true;
        }
    }

    //Different types of vehicles,
    //such as a basic vehicle, a car, and a motorcycle.
    //All vehicles can be started and stopped and have a speed.
    //However, cars and motorcycles have specific properties and behaviors.

    //Base Class (Parent Class) - Vehicle
    public class VehicleII
    {
        public int Speed { get; protected set; }
        public void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle stopped.");
        }
        public virtual void Accelerate()
        {
            Speed += 5;
            Console.WriteLine($"Vehicle accelerates. Current speed: {Speed} km/h.");
        }
    }
    //Derived Class (Child Class) - Car
    public class CarII : VehicleII
    {
        public int Doors { get; set; }
        public override void Accelerate()
        {
            Speed += 10;
            Console.WriteLine($"Car accelerates. Current speed: {Speed} km/h.");
        }
        public void OpenSunroof()
        {
            Console.WriteLine("Sunroof opened.");
        }
    }
    //Derived Class (Child Class) - Motorcycle
    public class Motorcycle : VehicleII
    {
        public bool HasSideCar { get; set; }
        public override void Accelerate()
        {
            Speed += 7;
            Console.WriteLine($"Motorcycle accelerates. Current speed: {Speed} km/h.");
        }
        public void UseKickstand()
        {
            Console.WriteLine("Kickstand placed.");
        }
    }

    //Let’s understand polymorphism using another real-world example: a graphics program that can draw different shapes. Each shape can be drawn on a canvas,
    //but the way each shape is drawn might differ.

    public abstract class shapeII
    {
        public abstract void MakeSound();
    }

    public class pentagaon : shapeII
    {
        public override void MakeSound()
        {
            Console.Write("Penta penta - gaon");
        }
    }

    public class Hexagaon : shapeII
    {
        public override void MakeSound()
        {
            Console.Write("Hexa Hexa - gaon");
        }
    }
}



