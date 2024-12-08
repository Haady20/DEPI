using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;

namespace AssigmentFive
{
    internal class Program
    {
        public static void SumAndMultiply(int num1, int num2, out int sum, out int product) {
            sum = num1 + num2;
            product = num1 * num2;
        }
        public static void printing(string messg, int value = 5) {
            for (int i = 0; i < value; i++) {
                Console.WriteLine(messg);
            }
        }
        public static int SumArray(params int[] input) {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region Part01
            #region Problem 1
            //try
            //{
            //Console.WriteLine("Enter First Number...");
            //int inputOne=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Secound Number...");
            //int inputTwo = Convert.ToInt32(Console.ReadLine());
            //    int result = inputOne / inputTwo;
            //    Console.WriteLine($"The result of dividing is {result}.");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    Console.WriteLine("Operation Completed!");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 2
            //int x, y;
            //while (true)
            //{
            //    Console.WriteLine("Enter First Positive Number ...");
            //    if (int.TryParse(Console.ReadLine(), out x) && x > 0){
            //        Console.WriteLine("valid Number!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Number!");
            //    }
            //}
            //while (true)
            //{
            //    Console.WriteLine("Enter Secound Positive Number ...");

            //    if (int.TryParse(Console.ReadLine(), out y) && y > 1) {
            //        Console.WriteLine("valid Number!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Number!");

            //    }
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 3
            //int? x = null;
            //int y = x ?? 0;
            //Console.WriteLine($"Value of nullabelInt is {x}.");
            //Console.WriteLine($"Value after assigning null-coalescing operator is {y}.");
            //if (x.HasValue)
            //{
            //    Console.WriteLine($"nullableInt has a value {x.Value}.");
            //}
            //else
            //{
            //    Console.WriteLine($"nullableInt don't have a value!");
            //}
            //x = 5;
            //if (x.HasValue)
            //{
            //    Console.WriteLine($"nullableInt has a value {x.Value}.");
            //}
            //else
            //{
            //    Console.WriteLine($"nullableInt don't have a value!");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 4
            //int[] arr = new int[5];
            //try{
            //    Console.WriteLine($"Value of index 6 is: {string.Join("", arr[6])}");
            //}
            //catch (IndexOutOfRangeException ex){
            //    Console.WriteLine(ex.Message ); 
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 5
            //int[,] arr = new int[3, 3];
            //for (int i = 0; i < arr.GetLength(0); i++){
            //    for (int j = 0; j < arr.GetLength(1); j++){
            //        Console.WriteLine($"Enter a value for index [{i},{j}]");
            //        if (!int.TryParse(Console.ReadLine(),out arr[i,j])){
            //            Console.WriteLine("Invalid Input");
            //            j--;
            //        }
            //    }
            //}

            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < arr.GetLength(0); i++){
            //    for (int j = 0; j < arr.GetLength(1); j++){
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < arr.GetLength(0); i++){
            //    int rowSum = 0;
            //    for (int j = 0; j < arr.GetLength(1); j++){
            //        rowSum+= arr[i, j];
            //    }
            //    Console.WriteLine($"The Summition of Row {i + 1} is {rowSum}.");
            //}

            //Console.WriteLine("-------------------------------");


            //for (int i = 0; i < arr.GetLength(1); i++)
            //{
            //    int columSum = 0;
            //    for (int j = 0; j < arr.GetLength(0); j++)
            //    {
            //        columSum += arr[j, i];
            //    }
            //    Console.WriteLine($"The Summition of Column {i + 1} is {columSum}.");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 6
            //int[][] arr = new int[3][];
            //arr[0] = new int[2];
            //arr[1] = new int[4];
            //arr[2] = new int[6];

            //for (int i = 0; i < arr.Length; i++){
            //    for (int j = 0; j < arr[i].Length; j++){
            //        Console.WriteLine($"Enter a value for index [{i},{j}]");
            //        if (!int.TryParse(Console.ReadLine(), out arr[i][j])){
            //            Console.WriteLine("Invalid Input!");
            //            j--;
            //        }
            //    }
            //}

            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Row {i+1} Values are: ");
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + " ");
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 7
            //#nullable enable
            //string? x = null;
            //Console.WriteLine("Enter a string value...");
            //string input = Console.ReadLine() ?? string.Empty;
            //if (!string.IsNullOrWhiteSpace(input)){
            //    x = input;
            //    Console.WriteLine("Invalid Input!");
            //}
            //else if (x == null){

            //    Console.WriteLine("The string is null.");
            //}
            //else{
            //    Console.WriteLine($"You Enterd '{x}' as an input.");
            //    Console.WriteLine("The string is not null.");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 8
            //int value = 10;
            //object boxValue = value;
            //try
            //{
            //    int unBoxing = (int)boxValue; // Unboxing
            //    Console.WriteLine("Valid Unboxing!");
            //    Console.WriteLine($"Unboxed value is {unBoxing} and its type is {unBoxing.GetType()}.");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Invalid unboxing: {ex}");
            //}
            //try
            //{
            //    string invalidUnboxing = (string)boxValue; 
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Invalid unboxing: {ex}");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 9
            //int x;
            //int y;
            //int i;
            //int j;
            //Console.WriteLine("Enter First Number");
            //if(!int.TryParse(Console.ReadLine(), out x)){
            //    Console.WriteLine("Invalid Input");
            //}
            //Console.WriteLine("Enter Secound Number");
            //if (!int.TryParse(Console.ReadLine(), out y))
            //{
            //    Console.WriteLine("Invalid Input");
            //}
            //SumAndMultiply(x, y, out i, out j);
            //Console.WriteLine("------------------------");
            //Console.WriteLine($"Summition is {i}, Production is {j} .");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 10
            //printing("Hady",10);
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 11
            //int?[] arr = new int?[5];
            //arr[0] = 2;
            //for (int i = 0; i < arr.Length; i++){
            //    Console.WriteLine(arr[i]?.ToString()?? "Null");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 12

            //Console.WriteLine("Enter a Number...");
            //int input = Convert.ToInt32(Console.ReadLine());
            //switch (input)
            //{
            //    case 1:
            //        Console.WriteLine("The Day is Monday.");
            //        break;
            //    case 2:
            //        Console.WriteLine("The Day is Tuesday.");
            //        break;
            //    case 3:
            //        Console.WriteLine("The Day is Wednesday.");
            //        break;
            //    case 4:
            //        Console.WriteLine("The Day is Thursday.");
            //        break;
            //    case 5:
            //        Console.WriteLine("The Day is Friday.");
            //        break;
            //    case 6:
            //        Console.WriteLine("The Day is Saturday.");
            //        break;
            //    case 7:
            //        Console.WriteLine("The Day is Sunday.");
            //        break;
            //    default: Console.WriteLine("Invalid Number");
            //        break; 
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 13
            //int sumOne = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine(sumOne);
            //int[] arr = {6, 7, 8, 9, 10};
            //int sumTwo=SumArray(arr);
            //Console.WriteLine(sumTwo);
            #endregion

            //-----------------------------------------------------------------------

            #endregion

            //-----------------------------------------------------------------------

            #region Part02
            #region Problem 1
            //Console.WriteLine("Enter The Range Number...");
            //int range=Convert.ToInt32(Console.ReadLine());
            //if (range<0){
            //    Console.WriteLine("Invalid Range!");
            //}
            //else
            //{
            //Console.WriteLine("----------------------");
            //Console.WriteLine($"Numbers from 1 to {range} is:");
            //    for (int i = 1; i <= range; i++){
            //        Console.Write(i+" ");
            //    }
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 2
            //Console.WriteLine("Enter a Number...");
            //int number=Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("----------------------");
            //Console.WriteLine($"Multiplication for {number} up to 12 times is :-");
            //for (int i = 1; i <= 12; i++){
            //    int product = 0;
            //    product = number * i;
            //    Console.Write(product + "\t");
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 3
            //Console.WriteLine("Enter a Number...");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Even numbers from {number} to 2 is :-");
            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 4
            //Console.WriteLine("Enter First number ...");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Secound number...");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //double reesult = Math.Pow(numberOne,numberTwo);
            //Console.WriteLine($"{numberOne} raised to the power of {numberTwo} is: {reesult}.");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 5
            //Console.WriteLine("Enter a text...");
            //string input=Console.ReadLine();
            //char[] arr = input.ToCharArray();
            //Array.Reverse(arr);
            //string reversedInput = new string(arr);
            //Console.Write(reversedInput);
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 6
            //Console.WriteLine("Enter a Number...");
            //string input = Console.ReadLine();
            //Char[] arr = input.ToCharArray();
            //Array.Reverse(arr);
            //string reversedInput = new string(arr);
            //Console.WriteLine(reversedInput);
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 7
            //int[] arr =
            //{
            //    1,7,0,0,0,5,
            //    6,7,5,0,7,5,
            //    37,0,0,0,
            //    0,5,6,7,5,
            //    0,7,5,37,0,
            //    0,0,0,5,6,7,5,
            //    0,7,5,3
            //};
            //Console.WriteLine(string.Join(",", arr));
            //Console.WriteLine("------------------------------------------------------------");
            #endregion

            //-----------------------------------------------------------------------

            #region Problem 8
            //Console.WriteLine("Enter Array Elements...");
            //string input = Console.ReadLine();
            //int[] arr = input.Split(",").Select(int.Parse).ToArray();
            //Console.WriteLine(string.Join(",", arr));
            //var indices = new System.Collections.Generic.List<int>();//Chatgpt
            //for (int i = 0; i < arr.Length; i++){
            //    if (arr[i] == 7){
            //        indices.Add(i);
            //    }
            //}
            //if (indices.Count < 2){
            //    Console.WriteLine("There are less than two occurrences of 7 in the array.");
            //}
            //int maxDistance = 0;
            //for (int i = 1; i < indices.Count; i++){
            //    int distance = indices[i] - indices[i - 1];
            //    if (distance > maxDistance){
            //        maxDistance = distance;
            //    }
            //}
            //Console.WriteLine($"The longest distance between 7 is: {maxDistance}.");
            #endregion
            
            //-----------------------------------------------------------------------

            #region Problem 9
            //Console.WriteLine("Enter a sentence...");
            //string input = Console.ReadLine();
            //string[] arr = input.Split(" ");
            //Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ",arr));
            #endregion

            //-----------------------------------------------------------------------

            #endregion
        }
    }
}
