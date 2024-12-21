using System;
using static AssigmentNine.Employee;

namespace AssigmentNine
{
    internal class Program
    {
        public static void Swap(ref Rectangle rect1, ref Rectangle rect2)
        {
            Rectangle temp = rect1;
            rect1 = rect2;
            rect2 = temp;
        }
        public static T[] ReverseArray<T>(T[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null.");
            }

            T[] reversedArray = new T[array.Length];
            int j = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversedArray[j++] = array[i];
            }
            return reversedArray;
        }
        public class CustomObject
        {
            public string Name { get; set; }

            public CustomObject(string name)
            {
                Name = name;
            }

            public override string ToString()
            {
                return Name;
            }
        }
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array), "Array cannot be null");
            }

            if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
            {
                throw new ArgumentOutOfRangeException("Indices are out of range");
            }
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public static T Maximum<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty", nameof(array));
            }
            T maxElement = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(maxElement) > 0)
                {
                    maxElement = item;
                }
            }
            return maxElement;
        }

        static void Main(string[] args)
        {

            #region Part01
            #region Problem01

            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //    Console.WriteLine($"{day}: {(int)day}.");

            #endregion

            // --------------------------------------------------

            #region Problem02

            //foreach ( Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade}: {(short)grade}.");                
            //}

            #endregion

            // --------------------------------------------------

            #region Problem03

            //Person person = new Person("Hady",19,"DEPI");
            //Console.WriteLine(person);

            #endregion

            // --------------------------------------------------

            #region Problem04

            //Child child = new Child(10000);
            //Console.WriteLine(child.DisplaySalary());

            #endregion

            // --------------------------------------------------

            #region Problem05

            //double result = Utility.CalculatePerimeter(10, 20);
            //Console.WriteLine($"The perimeter of a rectangle is: {result}.");

            #endregion

            // --------------------------------------------------

            #region Problem06

            //ComplexNumber num1 = new ComplexNumber(3, 2); 
            //ComplexNumber num2 = new ComplexNumber(1, 7); 
            //ComplexNumber result = num1 * num2;
            //Console.WriteLine($"Result of multiplying {num1} and {num2} is: {result}");

            #endregion

            // --------------------------------------------------

            #region Problem07

            //Console.WriteLine("Size of default int enum: " + sizeof(Gender) + " byte.");
            //Gender gender = Gender.Male;
            //Console.WriteLine("Memory usage of Gender enum: " + sizeof(Gender) + " byte.");
            //Console.WriteLine("Gender value: " + gender);

            #endregion

            // --------------------------------------------------

            #region Problem08
            //double celsius = 25.0;
            //double fahrenheit = 77.0;
            //double convertedFahrenheit = Utility.CelsiusToFahrenheit(celsius);
            //Console.WriteLine($"{celsius} C is equal to {convertedFahrenheit} F".);
            //double convertedCelsius = Utility.FahrenheitToCelsius(fahrenheit);
            //Console.WriteLine($"{fahrenheit} F is equal to {convertedCelsius} C.");
            #endregion

            // --------------------------------------------------

            #region Problem08

            //string[] str = { "A", "B", "C", "D", "F", "E", "Z", "a", "b" };
            //foreach (var input in str)
            //{
            //    if (Enum.TryParse<Grades>(input, true, out Grades grade))
            //    {
            //        Console.WriteLine($"Successfully parsed '{input}' to Grade: {grade}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Failed to parse '{input}' into a valid Grade.");
            //    }
            //}

            #endregion

            // --------------------------------------------------

            #region Problem09 GPT

            //Employee[] employees = new Employee[]
            //{
            //new Employee(1, "Ahmed"),
            //new Employee(2, "Sayed"),
            //new Employee(3, "Hady")
            //};
            //Employee searchEmployee = new Employee(3, "Hady");
            //int index = Helper2<Employee>.SearchArray(employees, searchEmployee);
            //if (index != -1)
            //{
            //    Console.WriteLine($"Employee found at index: {index}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}

            #endregion

            // --------------------------------------------------

            #region Problem10

            //int int1 = 10;
            //int int2 = 20;
            //Console.WriteLine($"Max of {int1} and {int2} is: {Helper.Max(int1, int2)}");
            //Console.WriteLine("-----------------------------------");
            //double double1 = 15.5;
            //double double2 = 10.2;
            //Console.WriteLine($"Max of {double1} and {double2} is: {Helper.Max(double1, double2)}");
            //Console.WriteLine("-----------------------------------");
            //string str1 = "Apple";
            //string str2 = "Banana";
            //Console.WriteLine($"Max of '{str1}' and '{str2}' is: '{Helper.Max(str1, str2)}'");
            //Console.WriteLine("-----------------------------------");

            #endregion

            // --------------------------------------------------

            #region Problem11

            //int[] intArray = { 1, 2, 3, 4, 2, 5, 2 };
            //Console.WriteLine("Original integer array is: " + string.Join(", ", intArray));
            //Helper2<int>.ReplaceArray(intArray, 2, 99);
            //Console.WriteLine("Modified integer array is : " + string.Join(", ", intArray));
            //Console.WriteLine("--------------------------------");
            //string[] strArray = { "apple", "banana", "apple", "lemon" };
            //Console.WriteLine("Original string array is : " + string.Join(", ", strArray));
            //Helper2<string>.ReplaceArray(strArray, "apple", "orange");
            //Console.WriteLine("Modified string array is : " + string.Join(", ", strArray));
            #endregion

            // --------------------------------------------------

            #region Problem12
            //Rectangle rectangle1 = new Rectangle(10, 5);
            //Rectangle rectangle2 = new Rectangle(7, 3);
            //Console.WriteLine("Before Swap:");
            //Console.WriteLine($"Rectangle 1: {rectangle1}.");
            //Console.WriteLine($"Rectangle 2: {rectangle2}.");
            //Swap(ref rectangle1, ref rectangle2);
            //Console.WriteLine("After Swap:");
            //Console.WriteLine($"Rectangle 1: {rectangle1}.");
            //Console.WriteLine($"Rectangle 2: {rectangle2}.");

            #endregion

            // --------------------------------------------------

            #region Problem13

            //Department sales = new Department("Sales");
            //Department hr = new Department("Human Resources");
            //Department it = new Department("IT");
            //Employee[] employees = new Employee[]
            //{
            //new Employee("Ahmed", sales),
            //new Employee("Sayed", hr),
            //new Employee("Ali", it),
            //new Employee("Mahmoud", sales),
            //new Employee("Mohamed", hr)
            //};
            //string searchDepartment = "Sales";
            //Employee[] foundEmployees = SearchArray(employees, searchDepartment);
            //Console.WriteLine($"Employees in the {searchDepartment} department:");
            //foreach (var employee in foundEmployees)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            // --------------------------------------------------


            #region Problem14 GPT

            //Circle circle1 = new Circle(5.0, "Red");
            //Circle circle2 = new Circle(5.0, "Red");
            //Circle circle3 = new Circle(4.0, "Blue");
            //Console.WriteLine("Comparing Circle structs:");
            //Console.WriteLine($"circle1 == circle2: {circle1 == circle2}"); 
            //Console.WriteLine($"circle1.Equals(circle2): {circle1.Equals(circle2)}");
            //Console.WriteLine($"circle1 == circle3: {circle1 == circle3}"); 
            //Console.WriteLine($"circle1.Equals(circle3): {circle1.Equals(circle3)}"); 
            //CircleClass circleClass1 = new CircleClass(5.0, "Red");
            //CircleClass circleClass2 = new CircleClass(5.0, "Red");
            //CircleClass circleClass3 = new CircleClass(4.0, "Blue");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Comparing CircleClass instances:");
            //Console.WriteLine($"circleClass1 == circleClass2: {circleClass1 == circleClass2}");
            //Console.WriteLine($"circleClass1.Equals(circleClass2): {circleClass1.Equals(circleClass2)}"); 
            //Console.WriteLine($"circleClass1 == circleClass3: {circleClass1 == circleClass3}"); 
            //Console.WriteLine($"circleClass1.Equals(circleClass3): {circleClass1.Equals(circleClass3)}"); 



            #endregion

            // --------------------------------------------------

            #endregion
            
            // --------------------------------------------------

            #region Part02
            #region Problem01

            //int[] intArray = { 1, 2, 3, 4, 5 };
            //int[] reversedIntArray = ReverseArray(intArray);
            //Console.WriteLine("Reversed Integer Array: " + string.Join(", ", reversedIntArray));
            //string[] stringArray = { "Apple", "Banana", "Cherry" };
            //string[] reversedStringArray = ReverseArray(stringArray);
            //Console.WriteLine("Reversed String Array: " + string.Join(", ", reversedStringArray));
            //var customArray = new CustomObject[]
            //{
            //new CustomObject("Object1"),
            //new CustomObject("Object2"),
            //new CustomObject("Object3")
            //};
            //var reversedCustomArray = ReverseArray(customArray);
            //Console.WriteLine("Reversed Custom Object Array: " + string.Join(", ", Array.ConvertAll(reversedCustomArray, obj => obj.ToString())));

            #endregion

            // --------------------------------------------------

            #region Problem02 GPT

            //GenericStack<int> intStack = new GenericStack<int>();
            //intStack.Push(1);
            //intStack.Push(2);
            //Console.WriteLine("Top element: " + intStack.Peek()); 
            //Console.WriteLine("Popped element: " + intStack.Pop()); 
            //Console.WriteLine("Stack empty? " + intStack.IsEmpty()); 

            #endregion

            // --------------------------------------------------

            #region Problem03

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Before swap: " + string.Join(", ", numbers));
            //Swap(numbers, 1, 3);
            //Console.WriteLine("After swap: " + string.Join(", ", numbers));
            //string[] words = { "apple", "banana", "orange" };
            //Console.WriteLine("Before swap: " + string.Join(", ", words));
            //Swap(words, 0, 2);
            //Console.WriteLine("After swap: " + string.Join(", ", words)); 

            #endregion

            // --------------------------------------------------

            #region Problem04 GPT
            //int[] numbers = { 1, 5, 3, 9, 2 };
            //Console.WriteLine("Maximum element in numbers: " + Maximum(numbers));
            //double[] doubles = { 1.1, 5.5, 3.3, 9.9, 2.2 };
            //Console.WriteLine("Maximum element in doubles: " + Maximum(doubles)); 
            //string[] words = { "apple", "banana", "cherry" };
            //Console.WriteLine("Maximum element in words: " + Maximum(words));
            #endregion 

            // --------------------------------------------------

            #endregion

        }
    }
}