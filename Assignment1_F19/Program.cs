using System;
using System.Collections;

namespace Assignment1_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1: ");
            int a = 1, b = 23;
            printSelfDividingNumbers(a, b);
            Console.WriteLine("\n");

            Console.WriteLine("Question 2: ");
            int n2 = 4;
            printSeries(n2);
            Console.WriteLine("\n");

            Console.WriteLine("Question 3: ");
            int n3 = 5;
            printTriangle(n3);
            Console.WriteLine("\n");

            Console.WriteLine("Question 4: ");
            int[] J = new int[] { 1, 3 };
            int[] S = new int[] { 1, 3, 3, 2, 2, 2, 2, 2 };
            int r4 = numJewelsInStones(J, S);
            Console.WriteLine(r4);
            Console.WriteLine("\n");


            Console.WriteLine("Question 5: ");
            int[] arr1 = new int[] { 1, 2, 5, 6, 7, 8, 9 };
            displayArray(arr1);



            /* solvePuzzle();*/
        }

        public static void printSelfDividingNumbers(int x, int y)
        {
            try
            {
                bool isSelfDividing(int i) //Create the method and argument for self dividing numbers loop
                {
                    var number = i;
                    while (number > 1) //Number must be great than 1 to compute
                    {
                        var reminder = number % 10;
                        if (reminder == 0 || i % reminder != 0) //Create argument for is remainder is or is 0
                        {
                            return false;

                        }
                        number = number / 10;//Allows for number to continuously loop, will stop at 1 if not inserted
                    }
                    return true;

                }

                for (int i = x; i <= y; i++)//Count the numbers up to the inputted int value loop
                {

                    if (isSelfDividing(i) == true)
                    {
                        Console.Write(i + ", "); // Displays all inputs within i that meet self dividing number criteria
                    }


                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSelfDividingNumbers()");
            }
        }
        public static void printSeries(int n2)
        {
            try
            {
                // Write your code here

                for (int i = 1; i <= n2; i++)//Counting up from integer
                {
                    for (int j = 1; j <= i; j++)//Logic for repeating number ongiong from 1
                    {
                        Console.Write(i + ", ");
                    }

                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printSeries()");
            }
        }

        public static void printTriangle(int n3)
        {
            try
            {
                int j;
                for (int i = n3; i > 0; i--)//Loop 1 will collect the number of lines to repeat 
                {
                    for (j = n3 - i; j > 0; j--)//Logic for the amount of lines to input based off previous int 
                    {
                        Console.Write(" ");
                    }
                    for (j = (2 * i) - 1; j > 0; j--)//Need logix for the number of stars to be outputted per line
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }
        }

        public static int numJewelsInStones(int[] J, int[] S)
        {
            try
            {
                // Write your code here
               
                int r4 = 0;//set int to 0

                //Using foreach loops for array traversals
                foreach (int stone in S) //Call for each int that is within the array of S
                {
                    foreach (int jewel in J) //Call for each int that is within the second array J
                    {
                        if (jewel == stone)//Set them to equal 
                            r4++;
                    }
                }

                return r4;//Returns the value count
            }

            catch
            {
                Console.WriteLine("Exception occured while computing numJewelsInStones()");
            }

            return 0;//Allow for final path to return 0 value
        }

        public static void displayArray(int[] a)
        {
            try
            {
                // Write your code here
                //Pick smaller array, need to define all of the possible arrays within the array
                //Start from largest to smallest, then do 2,3,4,5, and 1,2,3,4 smaller 
                //Then 3,4,5/2,3,4/1,2,3
                int arrayA = 0;

                for (int i = 0; i < a.Length; i++)//Logic for counting array up 
                {
                    {
                        arrayA += 1;
                    }

                    Console.Write(arrayA + ", ");    



                }
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getLargestCommonSubArray()");
            }
        }
    }
}
/*public static void SolvePuzzle()
{
    try
    {
        // Write your code here
    }//Each letter can be 0-9 as the range, 
     //Use dictionarys in C#, GOOGLE
     //Going to have a loop within a loop, for the first part (UBER + COOL)
     //Cryptarithmetic
    catch
    {
        Console.WriteLine("Exception occured while computing solvePuzzle()");
    }
}
*/
      



