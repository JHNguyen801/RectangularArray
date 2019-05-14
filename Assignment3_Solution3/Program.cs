// This program uses a rectangular 3 x 2 array holding values, initializing the array 
// then computing and display the sum, product, and sum of the product array elements
using System;

namespace Assignment3_Solution3
{
    class Program
    {
        // This method is to display the value of the array, compute the sum, 
        // product and sum of the product of the columns for each row.
        static void Main(string[] args)
        {
            // Declare variable for sum, product and the sum of product 
            // to compute elements in the array
            int sum = 0;
            int product;
            int sumproduct = 0;

            // Intialize the values of rectangular arrays
            int[,] intArray = new int[,] { { 5, 1 }, { 3, -1 }, { -4, -3 } };

            // Display the mesaage and the elements in the rectangular arrays
            Console.WriteLine("The array contains:");
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            // loop for sum and compute the sum of the array elements 
            foreach (int i in intArray)
            {
                sum = sum + i;
            }
            // Print out the summ of all elements in the array
            Console.WriteLine("\nThe sum of array elements is " + sum + "\n");

            //loop for product of the element in the array
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                // Initialize product value
                product = 1;
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    product *= intArray[i, j]; 
                }

                // To show the product line 0 to 2
                Console.WriteLine("The product of line {0} is {1}", i, product);
                // Compute the sum of the product of the array
                sumproduct = sumproduct + product;
            }

            // Display the sum of products value of the array
            Console.WriteLine("\nSum of the Products is " + sumproduct);
            return;
        }
    }
}
