using System;
using System.Security.Cryptography;
using System.Transactions;
public enum Days
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

namespace Assigment_Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Problem 1
            //int[] arr1 = new int[5];

            //for (int i = 0; i < arr1.Length; i++) {
            //    arr1[i] = i + 1;
            //    Console.WriteLine($"Arary One Value is {arr1[i]} in index {i}.");
            //}

            //Console.WriteLine("-------------------------------");

            //int[] arr2 = new int[] { 6, 7, 8, 9, 10 };
            //for (int i = 0; i < arr2.Length; i++) {
            //    Console.WriteLine($"Arary Two Value is {arr2[i]} in index {i}.");

            //}

            //Console.WriteLine("-------------------------------");

            //int[] arr3 = { 11, 12, 13, 14, 15 };
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"Arary Three Value is {arr3[i]} in index {i}.");
            //}

            //Console.WriteLine("-------------------------------");

            //try{
            //    Console.WriteLine(arr1[10]);
            //}
            //catch (IndexOutOfRangeException exp){
            //    Console.WriteLine("Caught an exception:" +exp.Message +".");
            //}

            #endregion

            //-----------------------------------------------------------------------

            #region Problem 2
            //int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] arr2 = arr1;

            //arr1[0] = 10;
            //Console.WriteLine($"Arary One Value is {arr1[0]} in index 0.");//10
            //Console.WriteLine($"Arary Two Value is {arr2[0]} in index 0.");//10

            //Console.WriteLine("-------------------------------");

            //int[] arr3 = (int[]) arr1.Clone();
            //arr1[0] = 20;
            //Console.WriteLine($"Arary One Value is {arr1[0]} in index 0.");//20
            //Console.WriteLine($"Arary Two Value is {arr3[0]} in index 0.");//10

            //Console.WriteLine("-------------------------------");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 3
            //int[,] arr = new int[3, 3];

            //for (int i = 0; i < 3; i++) {
            //    Console.WriteLine($"Enter Student {i + 1} Grades..");
            //    for (int j = 0; j < 3; j++) {
            //        Console.WriteLine($"Student {i + 1}, Subject {j + 1} Grade:");
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //Console.WriteLine("----------------------");
            //}

            //for (int i = 0; i < 3; i++){
            //    Console.WriteLine($"Grades For Student {i + 1} is:");
            //    for (int j = 0; j < 3; j++) {
            //        Console.WriteLine($"Subject {j + 1} Grade is : {arr[i, j]}.");
            //    }
            //Console.WriteLine("----------------------");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 4
            //int[] arr1 = { 20, 5, 18, 1, 7 };
            //Console.WriteLine($"Array One Before Sorting: {string.Join(",", arr1)}.");
            //Array.Sort(arr1);
            //Console.WriteLine($"Array One After Sorting: {string.Join(",", arr1)}.");
            //Console.WriteLine("----------------------");
            //Console.WriteLine($"Array One Before Reversing: {string.Join(",", arr1)}.");
            //Array.Reverse(arr1);
            //Console.WriteLine($"Array One After Reversing: {string.Join(",", arr1)}.");
            //Console.WriteLine("----------------------");
            //Console.WriteLine($"Index of Number 18 is: {Array.IndexOf(arr1, 18)}.");
            //Console.WriteLine("----------------------");
            //Console.WriteLine($"Array One Before Clearing: {string.Join(",", arr1)}");
            //Array.Clear(arr1,0,5);
            //Console.WriteLine($"Array One After Clearing: {string.Join(",", arr1)}.");
            //Console.WriteLine("----------------------");
            //int[] arr2 = new int[arr1.Length];
            //Array.Copy(arr1, arr2, arr1.Length);
            //Console.WriteLine($"Array Two After Copying Array One: {string.Join(",", arr2)}.");
            //Console.WriteLine("----------------------");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 5
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for (int i = 0; i < arr.Length; i++) { 
            //    Console.WriteLine("Array Elments is:"+arr[i]);
            //}
            //Console.WriteLine("----------------------");
            //foreach (int i in arr) {
            //    Console.WriteLine("Array Elments is:" + i);
            //}
            //Console.WriteLine("----------------------");
            //int j = 0;
            //while ( j < arr.Length)
            //{
            //    Console.WriteLine("Array Elments is:" + arr[j]);
            //    j++;
            //}
            //Console.WriteLine("----------------------");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 6
            //int number;
            //bool valid;
            //do
            //{
            //    Console.WriteLine("Enter a positive ood number...");
            //    string input=Console.ReadLine();
            //    valid = int.TryParse(input, out number);
            //    if (number > 0 && number % 2 != 0 && valid)
            //    {
            //        Console.WriteLine($"You entered a valid number: {number}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input!");
            //        valid = false;
            //    }
            //}
            //while (!valid);
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 7
            //int[,] arr =
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    {7, 8, 8 }
            //};
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for(int j=0; j < arr.GetLength(1); j++) 
            //    {
            //        Console.Write(arr[i, j] + "\t ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 8
            //Console.WriteLine("Enter a Month Number..");
            //int month=Convert.ToInt32(Console.ReadLine());
            //if (month < 0 || month > 12) Console.WriteLine("Invalid Input!");
            //else if (month == 1) Console.WriteLine("The Month is January.");
            //else if (month == 2) Console.WriteLine("The Month is February.");
            //else if (month == 3) Console.WriteLine("The Month is March.");
            //else if (month == 4) Console.WriteLine("The Month is April.");
            //else if (month == 5) Console.WriteLine("The Month is May.");
            //else if (month == 6) Console.WriteLine("The Month is June.");
            //else if (month == 7) Console.WriteLine("The Month is July.");
            //else if (month == 8) Console.WriteLine("The Month is August.");
            //else if (month == 9) Console.WriteLine("The Month is September.");
            //else if (month == 10) Console.WriteLine("The Month is October.");
            //else if (month == 11) Console.WriteLine("The Month is November.");
            //else if (month == 12) Console.WriteLine("The Month is December.");
            //-----------------------------------------------------------------------
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("The Month is January.");
            //        break;
            //    case 2:
            //        Console.WriteLine("The Month is February.");
            //        break;
            //    case 3:
            //        Console.WriteLine("The Month is March.");
            //        break;
            //    case 4:
            //        Console.WriteLine("The Month is April.");
            //        break;
            //    case 5:
            //        Console.WriteLine("The Month is May.");
            //        break;
            //    case 6:
            //        Console.WriteLine("The Month is June.");
            //        break;
            //    case 7:
            //        Console.WriteLine("The Month is July.");
            //        break;
            //    case 8:
            //        Console.WriteLine("The Month is September.");
            //        break;
            //    case 9:
            //        Console.WriteLine("The Month is October.");
            //        break;
            //    case 10:
            //        Console.WriteLine("The Month is April.");
            //        break;
            //    case 11:
            //        Console.WriteLine("The Month is November.");
            //        break;
            //    case 12:
            //        Console.WriteLine("The Month is December.");
            //        break;
            //    default: 
            //        Console.WriteLine("Invalid Input!");
            //        break;
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 9
            //int[] arr = { 5, 19, 11, 8, 6, 45, 77, 1 };
            //Array.Sort(arr);
            //Console.WriteLine($"Sorted Array: {string.Join(",", arr)}.");
            //Console.WriteLine($"Index of 8 is {Array.IndexOf(arr,8)}");
            //Console.WriteLine($"Last Index of 8 is {Array.LastIndexOf(arr, 8)}");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 10
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int forSum = 0;
            //int forEachsum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    forSum += arr[i];
            //}
            //Console.WriteLine("forSum Summation is: " + forSum);

            //foreach (int i in arr) {
            //    forEachsum += i;
            //}
            //Console.WriteLine("forEach Summation is: "+forEachsum);
            #endregion
            //-----------------------------------------------------------------------

            #endregion

            //-----------------------------------------------------------------------

            #region Part02
            #region Problem 1
            Console.WriteLine("Enter a Number...");
            String input = Console.ReadLine();
            if(int.TryParse(input,out int dayNumber) && dayNumber >= 1 && dayNumber <= 7) {
                Days day = (Days)dayNumber;
                Console.WriteLine($"The day is: {day}.");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            #endregion


            #endregion
            
            //-----------------------------------------------------------------------

        }
    }
}
