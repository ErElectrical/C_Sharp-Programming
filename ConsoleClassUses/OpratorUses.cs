using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleClassUses
{
    public class OpratorUses
    {
        //Operators  are used to manipulate the variables and values in a program.
        //Types of opreator . total 7 
        //Arithmetic opreator
        //Relational Operators
        //Logical Operators
        //Bitwise Operators
        //Assignment Operators
        //Unary Operators or
        //Ternary Operator or Conditional Operator1. Arithmetic Operators
        //        These operators perform basic mathematical operations.
        //        Addition(+): Adds two operands.
        //        Subtraction(-): Subtracts the second operand from the first.
        //        Multiplication(*): Multiplies two operands.
        //        Division(/): Divides the first operand by the second.
        //        Modulus(%): Returns the remainder of a division operation.


        //2. Relational Operators
        //These operators compare two values and return a boolean result.

        //Equal to(==): Checks if two operands are equal.
        //Not equal to (!=): Checks if two operands are not equal.
        //Greater than(>): Checks if the left operand is greater than the right.
        //Less than (<): Checks if the left operand is less than the right.
        //Greater than or equal to (>=): Checks if the left operand is greater than or equal to the right.
        //Less than or equal to(<=) : Checks if the left operand is less than or equal to the right.

        //3. Logical Operators
        //These operators are used to perform logical operations.

        //Logical AND (&&): Returns true if both operands are true.
        //Logical OR(||): Returns true if at least one operand is true.
        //Logical NOT(!): Reverses the logical state of its operand.


        //4. Bitwise Operators
        //These operators perform operations on binary representations of integers.

        //Bitwise AND(&): Performs a bitwise AND operation.
        //Bitwise OR(|): Performs a bitwise OR operation.
        //Bitwise XOR(^): Performs a bitwise exclusive OR operation.
        //Bitwise NOT (~): Inverts the bits of its operand.
        //Left Shift (<<): Shifts bits to the left, filling with zeros.
        //Right Shift(>>): Shifts bits to the right.
        //5. Assignment Operators

        //These operators assign values to variables.

        //Assignment(=): Assigns the right operand's value to the left operand.
        //Add and assign(+=) : Adds the right operand to the left operand and assigns the result.
        //Subtract and assign (-=): Subtracts the right operand from the left operand and assigns the result.
        //Multiply and assign (*=): Multiplies the left operand by the right operand and assigns the result.
        //Divide and assign (/=): Divides the left operand by the right operand and assigns the result.
        //Modulus and assign (%=): Takes the modulus of the left operand by the right operand and assigns the result.

        //6. Unary Operators
        //These operators operate on a single operand.

        //Increment(++): Increases the value of the operand by 1.
        //Decrement(--) : Decreases the value of the operand by 1.
        //Unary plus(+): Indicates a positive value(usually optional).
        //Unary minus(-): Negates the value of the operand.
        //7. Ternary Operator
        //This is a shorthand for an if-else statement.

        //Conditional (?:): Evaluates a boolean expression and returns one of two values based on the result.
        //        csharp

        //Verify
        //        Open In Editor
        //Run
        //        Copy code
        //int result = (condition) ? valueIfTrue : valueIfFalse;
        //8. Null Coalescing Operator
        //This operator is used to provide a default value when dealing with nullable types.

        //Null coalescing (??): Returns the left-hand operand if it is not null; otherwise, it returns the right operand.
        //csharp

        //Verify

        //Open In Editor
        //Run
        //Copy code
        //var value = nullableValue ?? defaultValue;
        //9. Type Comparison Operator
        //This operator checks the type of an object.

        //is: Checks if an object is of a specific type.
        //as: Attempts to cast an object to a specific type and returns null if the cast fails.
        //10. Member Access Operators
        //These operators are used to access members of types.

        //Dot (.): Accesses members of a type(properties, methods, etc.).
        //Index([]) : Accesses elements in an array or collection.

        

        public void ArithmeticOpreator()
        {
            Console.WriteLine($" \n In this chapter we are going to read about Opreator uses . with help of opreator we use data genrated through out the program"); 
            Console.WriteLine($"\nArithmetic opreator ");
            Console.WriteLine($"\n" +
                $"Addition (+): Adds two operands." +
                $"\r\nSubtraction (-): Subtracts the second operand from the first" +
                $".\r\nMultiplication (*): Multiplies two operands." +
                $"\r\nDivision (/): Divides the first operand by the second." +
                $"\r\nModulus (%): Returns the remainder of a division operation. ");
            int a = 10;
            int b = 3;

            int sum = a + b;          // Addition
            int difference = a - b;   // Subtraction
            int product = a * b;      // Multiplication
            int quotient = a / b;     // Division
            int remainder = a % b;    // Modulus

            Console.WriteLine($"\nOpreands is : {a} and {b}");

            Console.WriteLine($"\nSum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");

        }

        public void RelationalOpreator()
        {
            Console.WriteLine($"\nRelational opreator - it returns boolean ");
            Console.WriteLine($" \nEqual to (==): Checks if two operands are equal.\r\nNot equal to (!=): Checks if two operands are not equal.\r\nGreater than (>): Checks if the left operand is greater than the right.\r\nLess than (<): Checks if the left operand is less than the right.\r\nGreater than or equal to (>=): Checks if the left operand is greater than or equal to the right.\r\nLess than or equal to (<=): Checks if the left operand is less than or equal to the right. ");
            int x = 5;
            int y = 10;

            bool isEqual = (x == y);           // Equal to
            bool isNotEqual = (x != y);        // Not equal to
            bool isGreater = (x > y);          // Greater than
            bool isLess = (x < y);             // Less than
            bool isGreaterOrEqual = (x >= y);  // Greater than or equal to
            bool isLessOrEqual = (x <= y);     // Less than or equal to

            Console.WriteLine($"Equal: {isEqual}, Not Equal: {isNotEqual}, Greater: {isGreater}, Less: {isLess}, GreaterOrEqual: {isGreaterOrEqual}, LessOrEqual: {isLessOrEqual}");
        }

        public void LogicalOpreator()
        {
            Console.WriteLine("\n Logical opreator it returns boolean");
            Console.WriteLine("\nThese operators are used to perform logical operations.\r\n\r\nLogical AND (&&): Returns true if both operands are true.\r\nLogical OR (||): Returns true if at least one operand is true.\r\nLogical NOT (!): Reverses the logical state of its operand.");
            bool condition1 = true;
            bool condition2 = false;

            bool andResult = condition1 && condition2; // Logical AND
            bool orResult = condition1 || condition2;  // Logical OR
            bool notResult = !condition1;                // Logical NOT

            Console.WriteLine($"AND: {andResult}, OR: {orResult}, NOT: {notResult}");
        }

        public void BitWiseOpreator()
        {
            Console.WriteLine("\nBitwise operators  are used to perform operations on the individual bits of integer types. " +
                "Understanding these operators can be very useful in various programming scenarios, including low-level programming, graphics, cryptography, and performance optimization. ");
            Console.WriteLine("\n Let's understand different bitwise opreator ");
            Console.WriteLine($"\n Bitwise AND (&)\r\nOperation:" +
                $" Compares each bit of two integers and returns a new integer where each bit is set to 1 if both corresponding bits are 1; otherwise, it is set to 0." +
                $"\r\nExample:\r\np = 5 (binary 0101)\r\nq = 3 (binary 0011)\r\np & q results in 0001 (which is 1 in decimal)." +
                $"\r\nUses:\r\nMasking: You can use the AND operator to isolate specific bits in a number." +
                $" For example, if you want to check if a certain bit is set (1) or not (0), " +
                $"you can use a mask.\r\nPermissions: In systems where permissions are represented as bits, " +
                $"you can use AND to check if a specific permission is granted.\r\n2. " +
                $"Bitwise OR (|)\r\nOperation: " +
                $"Compares each bit of two integers and returns a new integer where each bit is set to 1 if at least one of the corresponding bits is 1." +
                $"\r\nExample:\r\np | q results in 0111 (which is 7 in decimal).\r\nUses:\r\nSetting Bits: You can use the OR operator to set specific bits to 1." +
                $" For example, if you want to enable a feature represented by a specific bit, you can OR it with the current value." +
                $"\r\nCombining Flags: When using bit flags, OR can combine multiple flags into a single integer.\r\n3." +
                $" Bitwise XOR (^)\r\nOperation: Compares each bit of two integers and returns a new integer where each bit is set to 1 if the corresponding bits are different " +
                $"(one is 1 and the other is 0).\r\nExample:\r\np ^ q results in 0110 (which is 6 in decimal).\r\nUses:\r\nToggling Bits:" +
                $" XOR can be used to toggle specific bits. If you XOR a bit with 1, it flips the bit (0 becomes 1 and 1 becomes 0)." +
                $"\r\nChecksums and Error Detection: XOR is often used in algorithms for checksums and error detection because it has properties that can help identify changes in data." +
                $"\r\n4." +
                $" Bitwise NOT (~)\r\nOperation:" +
                $" Inverts all the bits of the integer, changing 1s to 0s and 0s to 1s.\r\nExample:\r\n~p results in ...11111010 (in a 32-bit signed integer," +
                $" this is -6 in decimal due to two's complement representation)." +
                $"\r\nUses:\r\nInversion:" +
                $" You can use NOT to invert bits," +
                $" which can be useful in certain algorithms or when working with binary data." +
                $"\r\nCreating Masks: " +
                $"NOT can be used to create masks that select all bits except for the ones you want to keep.\r\n5." +
                $" Left Shift (<<)\r\nOperation: " +
                $"Shifts all bits of the integer to the left by a specified number of positions, filling the rightmost bits with zeros." +
                $"\r\nExample:\r\np << 1 results in 1010 (which is 10 in decimal).\r\nUses:\r\nMultiplication by Powers of Two: " +
                $"Shifting left by n positions is equivalent to multiplying the number by 2^n. For example, x << 1 is x * 2.\r\nBit Manipulation:" +
                $" Useful in algorithms that require bit manipulation, such as graphics programming or low-level data processing.\r\n6. Right Shift (>>)" +
                $"\r\nOperation: Shifts all bits of the integer to the right by a specified number of positions. The behavior depends on whether the number is signed or unsigned." +
                $"\r\nExample:\r\np >> 1 results in 0010 (which is 2 in decimal).\r\nUses:\r\nDivision by Powers of Two: " +
                $"Shifting right by n positions is equivalent to dividing the number by 2^n. " +
                $"For example, x >> 1 is x / 2.\r\nExtracting Bits: Right shift can be used to extract specific bits from a number," +
                $" which is useful in various algorithms.");

            int p = 5;  // 0101 in binary
            int q = 3;  // 0011 in binary

            int bitwiseAnd = p & q;  // Bitwise AND
            int bitwiseOr = p | q;   // Bitwise OR
            int bitwiseXor = p ^ q;  // Bitwise XOR
            int bitwiseNot = ~p;     // Bitwise NOT
            int leftShift = p << 1;  // Left Shift
            int rightShift = p >> 1; // Right Shift

            Console.WriteLine($"AND: {bitwiseAnd}, OR: {bitwiseOr}, XOR: {bitwiseXor}, NOT: {bitwiseNot}, Left Shift: {leftShift}, Right Shift: {rightShift}");


        }

        public void AssignementOpreator()
        {
            Console.WriteLine("\n Uses of Assignemtn opreatot ");
            int z = 10; // Simple assignment
            z += 5;     // Equivalent to z = z + 5
            z -= 3;     // Equivalent to z = z - 3
            z *= 2;     // Equivalent to z = z * 2
            z /= 4;     // Equivalent to z = z / 4
            z %= 3;     // Equivalent to z = z % 3

            Console.WriteLine($"\nFinal value of z: {z}");
        }

        public void TernaryOpreator()
        {
            int age = 16;
            Console.WriteLine("\n Uses of Ternary opreator ");
            string eligibility = (age >= 18) ? "Eligible to vote" : "Not eligible to vote";

            Console.WriteLine(eligibility);

            Console.WriteLine(" Syntax for it -- string eligibility = (age >= 18) ? \"Eligible to vote\" : \"Not eligible to vote\";\r\n");

        }

    }
}
