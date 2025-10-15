using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call the Task1Addnumbers method
            Task1Addnumbers();

            //Call the Task2findlargestnumber method
            Task2findlargestnumber();

            //call the Task3calculateaverageofseveralnumbers method
            Task3calculateaverageofseveralnumbers();
        }

        //Method to ask user for 2 whole numbers and print their sum
        static int Task1Addnumbers()
        {
            // Declare 3 open integer variables
            int num1, num2, sum;

            //Ask for the first number
            Console.Write("Please enter a whole number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            //Ask for the second number
            Console.Write("Please enter a 2nd whole number that you wish to add to the first: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Calculate the sum of the 2 numbers and print it to the console
            sum = num1 + num2;
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is: " + sum);

            //Return the sum to the calling method
            return sum;
        }

        //Method to ask user for 3 whole numbers and print the largest
        static int Task2findlargestnumber()
        {
            // Declare 4 open integer variables
            int num1, num2, num3, largest;
         
            //A0sk for the first number
            Console.Write("Please enter a whole number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            
            //Ask for the second number
            Console.Write("Please enter a 2nd whole number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            //Ask for the third number
            Console.Write("Please enter a 3rd whole number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            
            //Determine which of the 3 numbers is the largest and print it to the console
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
                Console.WriteLine("The largest of the 3 numbers is: " + largest);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
                Console.WriteLine("The largest of the 3 numbers is: " + largest);
            }
            else
            {
                largest = num3;
                Console.WriteLine("The largest of the 3 numbers is: " + largest);
            }
            //Return the largest number to the calling method
            return largest;
        }

        //Method to ask user for how many numbers they wish to enter, then ask for that many whole numbers and print their average
        static double Task3calculateaverageofseveralnumbers()
        {
            // Declare open integer and double variables
            int count, i;
            double num, sum = 0, average;
         
            //Ask how many numbers the user wishes to enter
            Console.Write("How many whole numbers do you wish to enter? ");
            count = Convert.ToInt32(Console.ReadLine());
            
            //Use a for loop to ask for the specified number of whole numbers, adding each to a running total
            for (i = 1; i <= count; i++)
            {
                Console.Write("Please enter whole number " + i + ": ");
                num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            
            //Calculate the average of the entered numbers and print it to the console
            average = sum / count;
            Console.WriteLine("The average of the " + count + " numbers you entered is: " + average);
            
            //Return the average to the calling method
            return average;
        }
    }

}
