/*
 * Project_2: This program will use methods to fill, print, and reverse and array
 * Name: Spencer Unitt
 * Module: Homework 6, Project 2
 * Problem Statement: Fill an array then reverse the contents
 * 
 * Algorithm: 
 *  1. Create the first method. This method will return the values from 1-10 in assending order
 *  2. Create a second method that will display the contents of an array passed into it
 *  3. Create a third method that will reverse the order of the array passed into the method.
 *     To do this, create a int named temp and a for loop that loops through the array.Length / 2
 *     Inside the for loop, set the temp variable to equal the current index
 *     The current value to equal arr[arr.Length - i - 1]
 *     And the value at arr[arr.Length - i - 1] to equal the current index
 *  4. In the main method, create an int array = to what the first method returns
 *  5. Call the second method to print the contents of the array created in step 4
 *  6. Finally call the third method and reverse the contents of the array created in step 4
 *  7. Use the second method to display the results of the flipped array to the user
 *     
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loads the array with numbers
            int[] numbers = GenerateNumbers();

            Console.WriteLine("The contents of the array is: ");
            // Displays the current numbers in the array
            PrintNumbers(numbers);

            // Reverses the numbers in the array
            Reverse(numbers);
            Console.WriteLine("\n\nThe contents of the flipped array is: ");
            // Shows the now flipped array
            PrintNumbers(numbers);

            Console.ReadLine();
        }

        // Method that returns an array of numbers
        static int[] GenerateNumbers()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            return values;
        }

        // This method will print out the numbers using a for loop
        static void PrintNumbers(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }

        // This method will reverse the contents of the array
        static void Reverse(int[] nums)
        {
            // Temp variable
            int temp;

            // Sorts through the array
            for(int i = 0; i < nums.Length / 2; i++)
            {
                // The temp equals the current index
                temp = nums[i];
                // The current index will equal the next index
                nums[i] = nums[nums.Length - i - 1];
                // The next index will be flipped with the temp variable
                nums[nums.Length - i - 1] = temp;
                                
            }
        }
    }
}
