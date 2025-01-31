using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace AssigmentOne
{
    internal class Program
    {
        public static T GetDefault<T>()
        {
            return default(T);
        }
        public static List<TResult> FunctionToList<T, TResult>(List<T> inputList, Func<T, TResult> func)
        {
            List<TResult> resultList = new List<TResult>();
            foreach (var item in inputList)
            {
                resultList.Add(func(item));
            }
            return resultList;
        }
        public static void ActionToList(List<string> inputList, Action<string> action)
        {
            foreach (var item in inputList)
            {
                action(item);
            }
        }
        public static List<int> FilterList(List<int> inputList, Predicate<int> predicate)
        {
            List<int> filteredList = new List<int>();
            foreach (var item in inputList)
            {
                if (predicate(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
        public static List<string> FilterStrings(List<string> inputList, Func<string, bool> condition)
        {
            List<string> filteredList = new List<string>();
            foreach (var item in inputList)
            {
                if (condition(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
        public static int PerformOperation(int a, int b, Func<int, int, int> operation)
        {
            return operation(a, b);
        }
        public static List<string> FilterStringss(List<string> inputList, Func<string, bool> condition)
        {
            List<string> filteredList = new List<string>();
            foreach (var item in inputList)
            {
                if (condition(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }
        public static double PerformOperation(double a, double b, Func<double, double, double> operation)
        {
            return operation(a, b);
        }
        static void Main(string[] args)
        {
            #region Part01
            #region Problem 01
            //Employee[] employees = new Employee[]{
            //    new Employee("Ali",500),
            //    new Employee("Ahmed",200),
            //    new Employee("Sayed",300),
            //    new Employee("Mahmoud",100),
            //    new Employee("Mohey",400)
            //};
            //SortingAlgorithm<Employee> soort = new SortingAlgorithm<Employee>();
            //soort.Sort(employees, (x, y) => x.EmpSalary.CompareTo(y.EmpSalary));
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.EmpName}: {employee.EmpSalary}.");
            //}
            #endregion
            #region Problem 02
            //int[] Number = new int[] { 5, 10, 12, 4, 20, 1, 9 };
            //SortingTwo<int> Soort = new SortingTwo<int>();
            //Soort.Sort(Number,(x,y)=>x.CompareTo(y));
            //foreach (var num in Number)
            //{
            //   Console.WriteLine($"{num}.");
            //}
            #endregion
            #region Problem 03
            //string[] Names = new string[] {
            //new string("yara"),
            //new string("Sayed"),
            //new string("Mahmoud"),
            //new string("Hassan"),
            //new string("Amy"),
            //};
            //SortingThree<string> Soort = new SortingThree<string>();
            //Soort.Sort(Names,(x,y)=> x.Length.CompareTo(y.Length));
            //foreach (string name in Names) {
            //    Console.WriteLine($"{name}.");
            //}
            #endregion
            #region Problem 04
            //Employee[] employees = new Employee[] {
            //new Employee("Ali",900),
            //new Manager("Mahmoud",800),
            //new Employee("Sayed",1000),
            //new Manager("hassan",500),
            //new Manager("Asaad",700),
            //new Employee("Hassan",600)
            //};
            //SortingFour<Employee> Soort = new SortingFour<Employee>();
            //Soort.Sort(employees,(x,y)=>x.EmpSalary.CompareTo(y.EmpSalary));
            //foreach (Employee employee in employees) { 
            //Console.WriteLine($"{employee.EmpName},{employee.EmpSalary}.");
            //}
            #endregion
            #region Problem 05
            //Employee[] employees = new Employee[]
            //       {
            //new Employee("Aliaa", 500),
            //new Employee("Emed", 200),
            //new Employee("Mai", 300),
            //new Employee("Mahmoud", 700),
            //new Employee("Mohey", 400)
            //       };
            //SortingFive<Employee> soorter = new SortingFive<Employee>();
            //Func<Employee, Employee, bool> nameLengthComparison = (x, y) => x.EmpName.Length < y.EmpName.Length;
            //soorter.Sort(employees, nameLengthComparison);
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.EmpName}: {employee.EmpSalary}");
            //}
            #endregion
            #region Problem 06
            //int[] numbers = { 6, 5, 4, 3, 2, 1, };
            //Array.Sort(numbers, delegate (int x,int y)
            //{
            //    return x.CompareTo(y);
            //});
            //Console.WriteLine("Sorted using anonymous function:");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine($"{number}.");
            //}
            //Array.Sort(numbers,(x,y)=>x.CompareTo(y));
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine($"Sorted using lambda expression:");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine($"{number}.");
            //}
            #endregion
            #region Problem 07
            //int[] numbers =new int[] { 6, 4, 2, 1, 3, 9 };
            //SortingAlgorithm<int> num = new SortingAlgorithm<int>();
            //Console.WriteLine("Original Array:");
            //Console.WriteLine(string.Join(", ", numbers));
            //num.Swap(numbers, 0, 5);
            //Console.WriteLine("Swapping First and Last Elements:");
            //Console.WriteLine(string.Join(", ", numbers));
            //num.Sort(numbers,(x,y)=>x.CompareTo(y));
            //Console.WriteLine("Sorting A  rray:");
            //Console.WriteLine(string.Join(", ",numbers));
            #endregion
            #region Problem 08
            #endregion
            #region Problem 09
            //int defaultInt = GetDefault<int>();
            //Console.WriteLine(defaultInt);
            //double defaultdouble = GetDefault<double>();
            //Console.WriteLine(defaultdouble);
            //decimal defaultdecimal = GetDefault<decimal>();
            //Console.WriteLine(defaultdecimal);
            //string defaultstring = GetDefault<string>();
            //Console.WriteLine(defaultstring);
            //Employee defaultEmployee = GetDefault<Employee>();
            //Console.WriteLine($"Default value for Employee: {defaultEmployee == null}");//If Null Returns True.
            #endregion
            #region Problem 10
            //Employee[] employees = new Employee[]
            //{
            //new Employee("Ali", 500),
            //new Employee("Ahmed", 200),
            //new Employee("Sayed", 300),
            //new Employee("Mahmoud", 700),
            //new Employee("Mohey", 400)
            //};
            //SortingAlgoritem2<Employee> sorter = new SortingAlgoritem2<Employee>();
            //sorter.Sort(employees);
            #endregion
            #region Problem 11
            #endregion
            #region Problem 12 //GPT
            //List<string> strings = new List<string>
            //{
            //"hello",
            //"world",
            //"delegate",
            //"example"
            //};
            //StringTransform toUpperCase = s => s.ToUpper();
            //var upperCaseList = StringTransformer.TransformList(strings, toUpperCase);
            //Console.WriteLine("Uppercase Transformation:");
            //upperCaseList.ForEach(Console.WriteLine);
            //StringTransform reverseString = s => new string(s.ToCharArray().Reverse().ToArray());
            //var reversedList = StringTransformer.TransformList(strings, reverseString);
            //Console.WriteLine("\nReversed Transformation:");
            //reversedList.ForEach(Console.WriteLine);
            #endregion
            #region Problem 13
            //IntOperation addition =(a,b)=> a + b;
            //IntOperation subtraction = (a, b) => a - b;
            //IntOperation multiplcation= (a, b) => a * b;
            //IntOperation devision = (a, b) => b != 0 ? a / b : throw new DivideByZeroException("Cannot divide by zero.");
            //int num1 = 10;
            //int num2= 5;
            //Console.WriteLine($"Addition Result:{Oprerations.PerformOperation(num1, num2, addition)}.");
            //Console.WriteLine($"Subtraction Result:{Oprerations.PerformOperation(num1, num2, subtraction)}.");
            //Console.WriteLine($"Multiplcation Result:{Oprerations.PerformOperation(num1, num2, multiplcation)}.");
            //Console.WriteLine($"Devision Result:{Oprerations.PerformOperation(num1, num2, devision)}.");
            #endregion
            #region Problem 14
            //List<int> inputNumber = new List<int> { 1,2,3,4,5,6};
            //Transformer<int,string> intToString = number => number.ToString();
            //List<string> stringList = Transformer.TransformList(inputNumber, intToString);
            #endregion
            #region Problem 15
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Func<int, int> square = x => x * x;
            //List<int> squaredNumbers = FunctionToList(numbers, square);
            //Console.WriteLine("Squared Numbers: " + string.Join(",", squaredNumbers));
            #endregion
            #region Problem 16
            //List<string> messages = new List<string> { "Ahmed", "Sayed", "Hassan", "Fahd", "Amir" };
            //Action<string> printMessage = message => Console.WriteLine($"{message}.");
            //ActionToList(messages, printMessage);
            #endregion
            #region Problem 17
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Predicate<int> isEven = number => number % 2 == 0;
            //List<int> evenNumbers = FilterList(numbers, isEven);
            //Console.WriteLine("Even Numbers: " + string.Join(",", evenNumbers));
            #endregion
            #region Problem 18
            //List<string> words = new List<string> { "Ahmed", "Hassan", "Sayed", "Amir", "Mammoud", "Abdallah"};
            //List<string> startsWithA = FilterStrings(words, word => word.StartsWith("A"));
            //Console.WriteLine("Words that start with 'A': " + string.Join(", ", startsWithA));
            //List<string> longerThanFive = FilterStrings(words, word => word.Length > 5);
            //Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", longerThanFive));
            #endregion
            #region Problem 19
            //int addResult = PerformOperation(10, 5, (x, y) => x + y);
            //Console.WriteLine("Addition: 10 + 5 = " + addResult);
            //int subtractResult = PerformOperation(10, 5, (x, y) => x - y);
            //Console.WriteLine("Subtraction: 10 - 5 = " + subtractResult);
            //int multiplyResult = PerformOperation(10, 5, (x, y) => x * y);
            //Console.WriteLine("Multiplication: 10 * 5 = " + multiplyResult);
            #endregion
            #region Problem 20 //GPT
            //List<string> words = new List<string> { "Ahmed", "Hessan", "Sayed", "Amir", "Mammoud", "Abdallah" };
            //List<string> longerThanThree = FilterStringss(words, word => word.Length > 3);
            //Console.WriteLine("Words with length greater than 3: " + string.Join(", ", longerThanThree));
            //List<string> containsE = FilterStrings(words, word => word.Contains("e"));
            //Console.WriteLine("Words that contain 'e': " + string.Join(", ", containsE));
            #endregion
            #region Problem 21
            //double divideResult = PerformOperation(10.0, 2.0, (x, y) => x / y);
            //Console.WriteLine("Division: 10.0 / 2.0 = " + divideResult);
            //double exponentResult = PerformOperation(2.0, 3.0, (x, y) => Math.Pow(x, y));
            //Console.WriteLine("Exponentiation: 2.0 ^ 3.0 = " + exponentResult);
            #endregion
            #endregion
        }
}
}
