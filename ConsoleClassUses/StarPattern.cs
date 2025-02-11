using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleClassUses
{
    public  class StarPattern
    {
        public static void DifferentStarPattern()
        {
            for(int i = 0;i < 10; i++)
            {
                Console.WriteLine("-----");
            }
            Console.WriteLine("\nWelcome to Learning of Diffferent Star Patternss");
            Console.WriteLine("\nWrite a program to print a right-angled triangle star pattern of height 10");
            Console.WriteLine("First pattern output should be like below");
            Console.WriteLine("*\r\n**\r\n***\r\n****\r\n*****");
            int numberofline = 10;

            Console.WriteLine();
            Console.WriteLine("Output 1. ");
            for(int i = 1; i <= numberofline; i++) // Outer loop for each line
            {
                for(int j = 1; j <= i; j++) // Inner loop for printing asterisks
                {
                    Console.Write(" *");
                }
                Console.WriteLine(); // next line after printing *
            }

            Console.WriteLine($"Write a program to print an inverted right-angled triangle star pattern of height 10 like below .\r\n*****\r\n****\r\n***\r\n**\r\n*");

            Console.WriteLine();
            Console.WriteLine("Output 2. ");
            for (int i = numberofline; i >= 1; i--) // outer loop for controlling each line down to 1
            {
                for (int j = 1; j <= i; j++) // inner loop for printing * 
                {
                    Console.Write(" *");
                }
                Console.WriteLine(); // jump to next line 
            }

            Console.WriteLine("Write a program to print a pyramid star pattern of height 10 like below.\r\n    *\r\n   ***\r\n  *****\r\n *******");

            Console.WriteLine();
            Console.WriteLine("Output 3. ");


            //Outer Loop (for(int i = 0; i < numberofline; i++)):
            //This loop iterates from 0 to numberofline -1.The variable i represents the current row of the pyramid.
            for (int i = 0; i< numberofline; i++)
            {
                //First Inner Loop(for (int j = 0; j < numberofline - i - 1; j++)):
                //This loop prints spaces before the asterisks on each line. The number of spaces decreases as i increases.
                //Specifically, it prints numberofline - i - 1 spaces.This means:
                //For the first row(i = 0), it prints numberofline - 1 spaces.
                //For the second row(i = 1), it prints numberofline - 2 spaces.
                //And so on, until the last row, which has no leading spaces.


                for (int j = 0; j < numberofline - i - 1; j++)
                {
                    Console.Write(" ");
                }

                //Second Inner Loop (for (int j = 0; j < 2 * i + 1; j++)):

                //This loop prints the asterisks(*) for the current row.The number of asterisks increases as i increases.
                //The formula 2 * i + 1 calculates the number of asterisks to print:
                //For i = 0, it prints 1 asterisk.
               // For i = 1, it prints 3 asterisks.
                //For i = 2, it prints 5 asterisks.
                //And so on, creating the pyramid shape.

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); // it will jump to next line after printing the space and asterick.

                

            }

            Console.WriteLine("Inverted star pattern pyramid. It should look like below pattern ");
            Console.WriteLine("*******\r\n *****\r\n  ***\r\n   *");
            Console.WriteLine($"\n output 4.");
            for (int i = numberofline; i > 0; i--)
            {
                for (int j = 0; j < numberofline - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nDiamond star pattern pyramid. It should look like below pattern ");
            Console.WriteLine("   *\r\n  ***\r\n *****\r\n*******\r\n *****\r\n  ***\r\n   *");
            Console.WriteLine("Output 4.");

            for(int i = 0; i < numberofline; i++)  //this is responsible for upper part 
            {
                for(int j = 0; j < numberofline - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < (2*i-1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = numberofline; i > 0; i--) //this is responsible for lower part
            {
                for (int j = 0; j < numberofline - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nHollow square star pattern pyramid. It should look like below pattern ");
            Console.WriteLine("   *******\r\n*     *\r\n*     *\r\n*******");
            Console.WriteLine("Output 5.");

            for(int i = 0; i<numberofline; i++) // this loop control line no.
            {
                for(int j =0; j < numberofline; j++) // this loop control col no.
                {
                    if (i == 0 || i == numberofline - 1 || j == 0 || j == numberofline - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nHollow  star pattern pyramid. It should look like below pattern ");
            Console.WriteLine("*\r\n  * *\r\n *   *\r\n*******");
            Console.WriteLine("Output 6.\n");

            for(int i = 0; i < numberofline; i++) //iterates through each row of the pyramid.
            {
                for(int j = 0; j < numberofline - i - 1; j++) //prints the leading spaces for each row. The number of spaces decreases as the row number increases.
                {
                    Console.Write(" ");
                }
                for(int j  = 0; j < (2 * i + 1); j++) //handles the printing of stars and spaces:
                {

                    //It prints a star at the beginning (j == 0) and at the end of the row (j == (2 * i)).
                    //For all other positions in the row(when i is not the last row), it prints a space.
                    //If it's the last row (i == rows - 1), it prints stars for the entire row.

                    if ( j == 0 || j == (2*i) || i == numberofline - 1)  
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }

            Console.WriteLine("Write a program to print a pyramid of numbers where each row contains numbers from 1 to the row number.");
            Console.WriteLine("1 \r\n   1 2 \r\n  1 2 3 \r\n 1 2 3 4 \r\n1 2 3 4 5 ");
            Console.WriteLine("Output 6.\n");
            for(int i = 0; i <= numberofline; i++)
            {
                // Print leading spaces for alignment
                for (int j = 0; j < numberofline - i; j++)
                {
                    Console.Write(" ");
                }

                // Print numbers from 1 to i
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                // Move to the next line after each row
                Console.WriteLine();
            }

            Console.WriteLine("\nWrite a program to print a Hollow Inverted Pyramid of numbers where each row contains numbers from 1 to the row number.");
            Console.WriteLine("*********\r\n *     *\r\n  *   *\r\n   * *\r\n    *");
            Console.WriteLine("Output 7.\n");

            int n = 5;
            for (int i = n; i >= 1; i--)// This loop controls the current row of Pyramid
            {
                for (int j = n; j > i; j--) // This loop 
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    if (k == 1 || k == (2 * i - 1) || i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n write a program to print a Right-Angled Triangle (Numbered) ");
            Console.WriteLine("1\r\n22\r\n333\r\n4444\r\n55555");
            Console.WriteLine("\nOutput 8 .");

            for(int i = 0; i < numberofline; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("  " + i);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n write a program to print a  inverted Right-Angled Triangle (Numbered) ");
            Console.WriteLine("55555\r\n4444\r\n333\r\n22\r\n1");
            Console.WriteLine("\nOutput 8 .");

            for(int i =  numberofline; i >= 1 ; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("  " + i);
                }

                Console.WriteLine();

            }

        }
    }
}
