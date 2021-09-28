/*
 * Project_1: This program will fill an array with random numbers and copy those array elements into another array
 * Name: Spencer Unitt
 * Module: Homework 6, Project 1
 * Problem Statement: Copy the contents of one array to another
 * 
 * Algorithm: 
 *  1. Create two arrays and set the first one to 10 and the second one to the first ones Length
 *  2. Use a for loop to fill the first array with 10 random numbers. 
 *  3. Use a for loop set to loop through the second array. Set the first index of the second array to equal the first index of the first array
 *     This loop should end up copying all the elements in the first array and store them in the second array as well.
 *  4. Display the contents of the first array and second array.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, place;

            // Creates a new object from the Random class called nums
            Random nums = new Random();
            
            // Two new int arrays with the equal size of each other
            int[] first = new int[10];
            int[] second = new int[first.Length];

            // Loads up the first array with random numbers
            for(i = 0; i < first.Length; i++)
            {
                // Numbers will be between the numbers 1 and 100
                place = nums.Next(1, 100);
                // Loads the current random number in the selected index of the first array
                first[i] = place;
            }

            // Loops through the size of the second array (that is set to equal the size of the first array)
            for(i = 0; i < second.Length; i++)
            {
                // Copies each element in the first array and sets the elements in the second array equal to it
                second[i] = first[i];
            }

            // Loops through the first array and prints the contents
            Console.WriteLine("The contents of the first array is: ");
            for (i = 0; i < first.Length; i++)
            {
                Console.Write(first[i] + " ");
            }

            // Loops through the second array and prints the contents
            Console.WriteLine("\n\nThe contents of the second array is: ");
            for (i = 0; i < second.Length; i++)
            {
                Console.Write(second[i] + " ");
            }


            Console.ReadLine();
        }
    }
}
