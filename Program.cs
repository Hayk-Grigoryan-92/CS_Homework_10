using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_Homework_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////      practic loop exercises continue     //////////////////////////

            // 8. Simple Calculator: Write a simple calculator program using a switch statement that performs addition,
            // subtraction, multiplication, and division based on user input.

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //Calculator(num1, num2);

            //----------------------------------------------------------------------------

            // 9. Day of the Week:  Use a switch statement to print the name of the day based on a
            // number(1 for Monday, 2 for Tuesday, etc.).

            // DayOfWeek();

            //--------------------------------------------------------------------

            // 10. Vowel or Consonant:Write a program that checks if a given character is a vowel or consonant using a switch statement.

            // IsVowel();

            //------------------------------------------------------------------------

            // 11. Grade System: Implement a grade system using a switch statement.The program should take a 
            //     percentage and print the corresponding grade(A, B, C, D, F).

            //int percent = int.Parse(Console.ReadLine());
            //GeadeSystem(percent);

            //----------------------------------------------------------------------

            //12 Seasons:  Write a program that takes a month number(1 - 12) and prints the corresponding
            //   season using a switch statement.

            // Seasons();

            //---------------------------------------------------------------------

            //13 Array Elements Input and Output:  Write a program that takes 5 integers
            //   as input, stores them in an array, and then prints the array element

            // ArrayElements();

            //------------------------------------------------------------------------

            //14 Find the Largest Element:  Write a program that finds the largest element in an array.

            //int[] arr = { 1, 5, 10, -7, 16, -5, 18, -2 };
            //int largest1 = LargestElement(arr);
            //Console.WriteLine(largest1);

            //--------------------------------------------------------------------

            //15 Sum and Average of Array Elements:  Write a program that calculates the sum and average of elements in an array.

            //int[] arr = { 1, 5, 10};
            //SumAndAverage(arr);

            //---------------------------------------------------------------------

            //16 Reverse an Array: Write a program that reverses the elements of an array.

            //int[] arr = { 1, 5, 10 };
            //ReverseArr(arr);

            //-----------------------------------------------------------------------

            // 17 Count Even and Odd Elements in Array: Write a program that counts the number of even and odd elements in an array.

            //int[] arr = { 1, 5, 10, -7, 16, -5, 18, -2 };
            //EvenOddCount(arr);

            //-----------------------------------------------------------------------

            //18 Sort Array in Ascending Order:  Write a program that sorts an array of integers in ascending order

            //int[] arr = { 1, 5, 10, 7, 16 };
            //SortAscending(arr);
            //Chem grel, Buble Sort

            //-----------------------------------------------------------------

            //19 Merge Two Arrays:  Write a program that merges two arrays into a third array.

            int[] arr1 = { 1, 5, 10, 7, 16 };
            int[] arr2 = { 4, 42, 19};
            MergeArrays(arr1, arr2);

        }

        // 8. Simple Calculator:
        public static void Calculator(int num1, int num2)
        {
            string action = Console.ReadLine();
            switch (action)
            {
                case "+":
                    Console.WriteLine($"Result : {num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result : {num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result : {num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    Console.WriteLine($"Result : {num1} / {num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("you added unknown action");
                    break;
            }
        }

        // 9. Day of the Week
        public static void DayOfWeek()
        {
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("you added wrong day number");
                    break;
            }
        }

        // 10. Vowel or Consonant:

        public static void IsVowel()
        {
            string letter = Console.ReadLine();
            letter.ToLower();

            switch (letter)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("The letter is vowel");
                    break;
                default:
                    Console.WriteLine("The letter is consonant");
                    break;
            }
        }

        // 11. Grade System

        public static void GeadeSystem(int percent)
        {

            if (percent >= 0 || percent <= 100)
            {
                if (percent >= 80)
                {
                    Console.WriteLine("your grade is: A");
                }
                else if (percent >= 60)
                {
                    Console.WriteLine("your grade is: B");
                }
                else if (percent >= 40)
                {
                    Console.WriteLine("your grade is: C");
                }
                else if (percent >= 20)
                {
                    Console.WriteLine("your grade is: D");
                }
                else if (percent >= 0)
                {
                    Console.WriteLine("your grade is: F");
                }
            }
            else
            {
                Console.WriteLine("Wrong percent");
            }

        }

        //12 Seasons:

        public static void Seasons()
        {
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn");
                    break;
                default:
                    Console.WriteLine("You enter wrong month");
                    break;
            }
        }

        //13 Array Elements

        public static void ArrayElements()
        {
            int i = 0;
            int[] arr = new int[5];
            while (i < 5)  // Corrected to run 5 times (0 to 4)
            {
                int n = int.Parse(Console.ReadLine());
                arr[i] = n;
                i++;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine("El: " + arr[j]);
            }
        }

        //14 Find the Largest Element

        public static int LargestElement(int[] arr)
        {
            int largest = 0;
            for (int i = 0;i<arr.Length; i++)
            {
                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }
            return largest;
        }

        //15 Sum and Average of Array Elements

        public static void SumAndAverage(int[] arr) 
        {
            int sum = 0;
            int average = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                average = sum / (i + 1);
            }
            Console.WriteLine(sum);
            Console.WriteLine(average);
        }

        //16 Reverse an Array:
        public static void ReverseArr(int[] arr)
        {
            int[] arr1 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[arr.Length - 1 - i];
                Console.WriteLine(arr1[i]);
            } 
        }

        // 17 Count Even and Odd Elements in Array

        public static void EvenOddCount(int[] arr)
        {
            int even = 0;
            int odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine(even);
            Console.WriteLine(odd);
        }

        //18 Sort Array in Ascending Order

        public static void SortAscending(int[] arr)
        {
            int[] arr1 = new int[arr.Length];
            int elem = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > elem)
                {
                    elem = arr[i];
                    arr1[i] = elem;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
        }

        // Buble Sort-y chem hishum esi heto kgrem

        //19 Merge Two Arrays
        public static void MergeArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(" " + arr3[i]);
            }

        }



    }
}
