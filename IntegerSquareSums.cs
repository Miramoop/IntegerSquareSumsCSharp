// CSCI 436 - Assignment #9 - Exception Handling
// Miranda Morris
// 2/18/2024

//Write a Java, C++, C#, VB, or Java program that inputs a variable-length list of positive, 
//non-zero integer values in the range of 1 to 100 from the keyboard. The program then 
//calculates the square of each number and maintains the sum of all the squares of each number 
//in the list. The program then outputs the sum of all the squares.  

//This program must use exception handling to ensure that the input values are within the allowable 
//range and are legal integers. The program must not terminate abnormally (e.g., crash) due to 
//an error. If an overflow error is encountered, the error must be handled. When handling an 
//exception, an error message must be displayed and the program gracefully terminated. Discuss 
//which language you used and why.  

using System;
using System.Linq.Expressions;

namespace ExceptionHandlingExample
{
    class ExceptionHandlingExample
    {
        static void Main(string[] args)
        {
            try
            {
                    Console.WriteLine("What size list would you like to make?"); //ask user what size list to make
                    int size = Convert.ToInt32(Console.ReadLine());
                    int[] numarray = new int[size];

                    //User inputs the elements contained in the list
                    Console.WriteLine("\nPlease enter elements of list");

                    //Making the User Input into array then converting to list
                    for (int i = 0; i < numarray.Length; i++)
                    {
                        numarray[i] = Convert.ToInt32(Console.ReadLine());
                        List<int> numarrayList = numarray.ToList();
                    }

                    //Creating the Squared Array
                    for (int i = 0; i < numarray.Length; i++)
                    {
                        numarray[i] = (int)Math.Pow(numarray[i], 2);
                        List<int> numarrayList = numarray.ToList();
                    }

                    //Printing out the sum of the squared array's elements to the user
                    for (int i = 0; i < numarray.Length - 1; i++)
                    {
                        List<int> numarrayList = numarray.ToList();
                        int sum = numarrayList.Sum();
                        Console.WriteLine("\nThe Sum of the Squared Elements is {0}", sum);
                    }

            }

            catch (FormatException e)
            {
                Console.WriteLine("Format Exception: Please only enter numbers 1 through 100");
            }

            catch(OverflowException e)
            {
                Console.WriteLine("Overflow Exception: Do not enter operators");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong with the program! Please try again!");
            }

            finally
            {
                Console.WriteLine("Thanks for using my program!");
            }

            Console.ReadLine();
       
        }
    }
}
