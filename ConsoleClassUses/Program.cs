using ConsoleClassUses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyFirstProject
{
    internal class Program
    {

        static string Developer_name = "Mohit Tanwar";
        string tech = "";

        public Program(string tch)
        {
            this.tech = tch;
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Console classes Uses";
            Console.WriteLine("Devloper name");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter Age:");
            string age = Console.ReadLine();

            Console.WriteLine("\nYour name is: "+name);
            Console.WriteLine("Your name is: " + age);

            ////DataTypes are used for store data
            ////C# has 3 types of datatype - value type,Refernce type,Point type.


            ////Value type -  it directly store the data at memory loc. 
            ///Below are some value datatype.
            
            //Byte data - it stores unsigned  8-bit integer. range - 0 to 255.

            //SByte data - it store signed 8-but integer . rabge - -127 to 128.

            Byte data1 = 66;
            Console.WriteLine($"\nI am unsigned 8 - bit integer -- {data1} ");
            Console.WriteLine($"\nI am unsigned 8 - bit integer. My Lower range is -- {Byte.MinValue} and higer range is {Byte.MaxValue} ");
            Console.WriteLine("\nMy size is 1 Byte or 8-bits");
            SByte data2 = -66;
            Console.WriteLine($"\nI am signed 8 - bit integer. My Lower range is -- {SByte.MinValue} and higer range is {SByte.MaxValue} ");

            // my size is 2 bytes.
            char ch = 'B';
            Console.WriteLine($"\nChar: {ch}");
            Console.WriteLine($"\nEquivalent Number: {(byte)ch}");
            Console.WriteLine($"\nChar Minimum: {(int)char.MinValue} and Maximum: {(int)char.MaxValue}");
            Console.WriteLine($"\nChar Size: {sizeof(char)} Byte");

            //numeric datatype -  it is a signed int . we have three types of int (int16,int32,int64). Its not contain decimal values
            //its also called as short or int16 , int or int32 , Long or int64 its all are same.

             

            Int16 num1 = 123;
            Int32 num2 = 456;
            Int64 num3 = 789;
            Console.WriteLine($"\nInt16 Min Value:{Int16.MinValue} and Max Value:{Int16.MaxValue}");
            Console.WriteLine($"\nInt16 Size:{sizeof(Int16)} Byte");
            Console.WriteLine($"\nInt32 Min Value:{Int32.MinValue} and Max Value:{Int32.MaxValue}");
            Console.WriteLine($"\nInt32 Size:{sizeof(Int32)} Byte");
            Console.WriteLine($"\nInt64 Min Value:{Int64.MinValue} and Max Value:{Int64.MaxValue}");
            Console.WriteLine($"\nInt64 Size:{sizeof(Int64)} Byte");

            //what if we have to only store positive value. C# has this security also through data type.
            //we just have to declare like ushort or uint16,uint or uint32,uLong or uint64

            //UInt16 num1 = 123;
            ushort num4 = 123;

            //UInt32 num2 = 456;
            uint num5 = 456;
            // UInt64 num3 = 789;
            ulong num6 = 789;
            Console.WriteLine($"\nushort Min Value:{ushort.MinValue} and Max Value:{ushort.MaxValue}");
            Console.WriteLine($"\nshort Size:{sizeof(ushort)} Byte");
            Console.WriteLine($"\nuint Min Value:{uint.MinValue} and Max Value:{uint.MaxValue}");
            Console.WriteLine($"\nuint Size:{sizeof(uint)} Byte");
            Console.WriteLine($"\nulong Min Value:{ulong.MinValue} and Max Value:{ulong.MaxValue}");
            Console.WriteLine($"\nulong Size:{sizeof(ulong)} Byte");


            //Numbers with decimal . to handle such type of data C# has 3 flavours  single , double , decimal.
            // for single data type -- suffix should be f ,  similarly for decimal suffix is M.
            //float means single 

            Single a = 1.123f;
            Double b = 1.456;
            Decimal c = 1.789M;

            Console.WriteLine($"\nSingle Size:{sizeof(Single)} Byte");
            Console.WriteLine($"\nSingle Min Value:{Single.MinValue} and Max Value:{Single.MaxValue}");
            Console.WriteLine($"\nDouble Size:{sizeof(Double)} Byte");
            Console.WriteLine($"\nDouble Min Value:{Double.MinValue} and Max Value:{Double.MaxValue}");
            Console.WriteLine($"\nDecimal Size:{sizeof(Decimal)} Byte");
            Console.WriteLine($"\nDecimal Min Value:{Decimal.MinValue} and Max Value:{Decimal.MaxValue}");



            //Data type choosen by developer impacts a lot on system performance so it has to be choosen wisely . An example to demonstarte it
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            for (int i = 0; i <= 10000000; i++)
            {
                short s1 = 100;
                short s2 = 100;
                short s3 = 100;
            }
            stopwatch1.Stop();
            Console.WriteLine($"\nshort took : {stopwatch1.ElapsedMilliseconds} MS");
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            for (int i = 0; i <= 10000000; i++)
            {
                decimal s1 = 100;
                decimal s2 = 100;
                decimal s3 = 100;
            }
            stopwatch2.Stop();
            Console.WriteLine($"\ndecimal took : {stopwatch2.ElapsedMilliseconds} MS");

            //a series of char data type is called as string. It is immutable means once a string is created it can not be replaced or changed.
            //its type is refernce just like a class or object .
            string str = "ABC";
            var howManyBytes = str.Length * sizeof(Char);
            Console.WriteLine($"\nstr Value: {str}");
            Console.WriteLine($"\nstr Size: {howManyBytes}");

            //Refernce type --  basically a refernce data type stores the value of memory location or refernce  of the data.e.g -  classes , objects , string , dynamic ,interfaces

            //pointer data type -  C# is not comfortable with this data type as it contains memory optimisation it self in a better way.
            //To use pointer data type you have to disable safe mode. it comes under project property.

            //it has two main symbol - (&) means address of the varible. and (*) means indirection opreator used to access the value at address.
            //below is code of uses pointer data type.

            unsafe
            {
                // declare a variable
                int number = 10;
                // store variable number address location in pointer variable ptr
                int* ptr = &number;
                Console.WriteLine($"\nValue :{number}");
                Console.WriteLine($"\nAddress :{(int)ptr}");
               
            }


            // -  Type casting -- it is important concept of any programming language .with help of this concept one data type can be changed into its compaitable data type
            // like int to float , but not like string to boolean it will through an error. 
            //  There are two types of casting - implicit conversion and Explicit conversion.
            //implicit conversion -  compiler done it automatically for us without data loss. 
            //Genrally in implicit conversion small size data is converted into large size data.

            int numInt = 1500;
            //Get type of numInt
            Type numIntType = numInt.GetType();
            // Implicit Conversion
            double numDouble = numInt;
            //Get type of numDouble
            Type numDoubleType = numDouble.GetType();
            // Value Before Conversion
            Console.WriteLine($"\nnumInt value: {numInt}");
            Console.WriteLine($"\nnumInt Type: {numIntType}");
            Console.WriteLine($"\nInt Size: {sizeof(int)} Bytes");
            // Value After Conversion
            Console.WriteLine($"\nnumDouble value: {numDouble}");
            Console.WriteLine($"\nnumDouble Type: {numDoubleType}");
            Console.WriteLine($"\ndouble Size: {sizeof(double)} Bytes");

            //Explicit conversion - higer size is converted into smaller size and loss of data may be possible dependes upon the data.

            int IntNum1 = 100;
            byte ByteNum1 = (byte)IntNum1; // Explicit Type Casting
            // Printing the Original Value and Converted Value
            Console.WriteLine($"\nOriginal Value:{IntNum1} and Converted Value:{ByteNum1}");
            int IntNum2 = 500;
            byte ByteNum2 = (byte)IntNum2; // Explicit Type Casting
            // Printing the Original Value and Converted Value
            Console.WriteLine($"\nOriginal Value:{IntNum2} and Converted Value:{ByteNum2}");

            //But as we know whenever we convert datatypes first there compatibility is checked but what if we need to convert string to int . Lets see how we are going to do it.

            string str1 = "100";
            int i1 = Convert.ToInt32(str1); //Converting string to Integer
            double d = 123.45;
            int i2 = Convert.ToInt32(d); //Converting double to Integer
            float f = 45.678F;
            string str2 = Convert.ToString(f); //Converting float to string
            Console.WriteLine($"\nOriginal value str: {str} and Converted Value i1:{i1}");
            Console.WriteLine($"\nOriginal value d: {d} and Converted Value i2:{i2}");
            Console.WriteLine($"\nOriginal value f: {f} and Converted Value str2:{str2}");

            //when we are using the Convert class helper method to convert a value to a particular type,
            //if types are not compatible, then it will not throw you any error at compile time.
            //At run time, it will try to convert the value to that particular type and if the value is compatible then it will convert and if the value is not compatible,
            //then it will throw a runtime error.

            // every data type has method Tryparse so instead of throughing error at run time it will output True and false.

            int xx = 0;
            string str3 = "Hello";
            bool IsConverted2 = int.TryParse(str3, out xx);


            // Chapter -- varible
            // varible is basically name of memory location where data is stored. a developer access the data using that varible name . 

            //Typesofvarible typ = new Typesofvarible(150);
            Typesofvarible.varibledef();

            OpratorUses opreator = new OpratorUses();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            opreator.ArithmeticOpreator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            opreator.RelationalOpreator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            opreator.BitWiseOpreator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            opreator.AssignementOpreator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            opreator.TernaryOpreator();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            ControlFlowStatement.explaincontrolflow();
            StarPattern.DifferentStarPattern();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            FunctionsUnderstanding.Functionknowledge();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            Console.WriteLine($"Value before object createion  {Developer_name}");
            Program prg = new Program("Mern stack");
            Console.WriteLine($"Value afetr object createion  {Developer_name}");
            Console.WriteLine($"Value of technology  {prg.tech}");
            Console.WriteLine("Non-static memebers are comes into existence after creation of object before that it does not exist" +
                "where static members are created when class excuation started or application start" +
                "Scope of static varible is  application. It is available for everyone untill the application close");

            Console.WriteLine("A class which is created by static  modfifer is called as static class." +
                "object can not be created for static class" +
                "A static class can have static members only.");



            Console.ReadKey();
    }
    }
}
