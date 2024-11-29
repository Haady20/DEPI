using System;
using System.Text;

namespace AssigmentThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01

            #region Problem 1
            //Console.WriteLine("Enter an input...");
            //string number = Console.ReadLine();

            //try {
            //    int parsedNumber = int.Parse(number);
            //    Console.WriteLine(number);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input Formate Error!");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Over Flow Error!");
            //}

            ////-----------------

            //try
            //{
            //    int convertedNumber = Convert.ToInt32(number);
            //    Console.WriteLine(convertedNumber);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Input Formate Error!");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Over Flow Error!");
            //}
            #endregion

            //--------------------------------------------------------

            #region Problem 2
            //Console.WriteLine("Enter a number ...");
            //string number =Console.ReadLine();

            //if (int.TryParse(number, out int checkedNumber)) { 
            //    Console.WriteLine("Vaild Number "+checkedNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input!");
            //}
            #endregion

            //--------------------------------------------------------

            #region Problem 3
            //object obj;

            //obj = "Ahmed";
            //Console.WriteLine($"Value is {obj} , {obj.GetHashCode()}");
            //obj = 11;
            //Console.WriteLine($"Value is {obj} , {obj.GetHashCode()}");
            //obj = 2.5;
            //Console.WriteLine($"Value is {obj} , {obj.GetHashCode()}");
            #endregion


            //--------------------------------------------------------

            #region Problem 4

            //int[] arrOne = new int[] {10};
            //Console.WriteLine(arrOne[0]);//10

            //int[] arrTwo = arrOne;
            //arrTwo[0] = 20;
            //Console.WriteLine(arrTwo[0]);//20
            #endregion

            //--------------------------------------------------------



            #region Problem 5
            //string stOne = "Hi";
            //Console.WriteLine($"{stOne} , {stOne.GetHashCode()}");

            //string stTwo = "Willy";
            //Console.WriteLine($"{stTwo} , {stTwo.GetHashCode()}");

            //string fullSt = stOne +" "+ stTwo;
            //Console.WriteLine($"{fullSt} , {fullSt.GetHashCode()}");
            #endregion

            //--------------------------------------------------------

            #region Problem 6
            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine($"Value:{sb} , {sb.GetHashCode()} .");

            //sb.Append(",I am 19.");
            //Console.WriteLine($"Value:{sb} , {sb.GetHashCode()} .");
            #endregion

            //--------------------------------------------------------
            #region Problem 7
            //Console.WriteLine("Enter First Number...");
            //int numOne=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Secound Number...");
            //int numTwo = Convert.ToInt32(Console.ReadLine());

            //int sum = numOne+numTwo;

            //Console.WriteLine("Summition is:- " +numOne +" + " +numTwo +" = "+sum);

            //Console.WriteLine("Composite Formatting: Sum is {0} + {1} = {2}", numOne, numTwo, sum);

            //Console.WriteLine($"Summition is:- {numOne} + {numTwo} = {sum}");
            #endregion

            //--------------------------------------------------------

            #region Problem 8
            //StringBuilder sb = new StringBuilder("Hello World");
            //Console.WriteLine(sb);

            //sb.Append(" ,Hello C#!");
            //Console.WriteLine(sb);

            //sb.Replace("C#","Community");
            //    Console.WriteLine(sb);

            //sb.Insert(0, "- ");
            //Console.WriteLine(sb);

            //sb.Remove(0,2);
            //Console.WriteLine(sb);
            #endregion

            //--------------------------------------------------------

            #endregion
        }
    }
}
