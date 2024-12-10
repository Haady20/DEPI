using System;
using System.Drawing;

namespace AssigmentSix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Problem1
            //PointOne p1 = new PointOne();
            //Console.WriteLine(p1.ToString());
            //PointOne p2 = new PointOne(10, 20);
            //Console.WriteLine(p2.ToString());
            #endregion

            //----------------------------------------------------------------

            #region Problem2
            //TypeA typeA = new TypeA(5, 10, 15);
            //Console.WriteLine($"{typeA.DisblayValues()},\n(Can find the value of any variable by a method within the same class with no care about its protection level.)");
            //Console.WriteLine("------------------------");
            ////Console.WriteLine(typeA.F);
            ////Can't directly acess private variable out side the class.
            //Console.WriteLine($"Value for G is {typeA.G}, (Can directly acess internal variable outside the calss.)");
            //Console.WriteLine("------------------------");
            //Console.WriteLine($"Value for H is {typeA.H}, (Can directly acess public any where.)");
            #endregion

            //----------------------------------------------------------------

            #region Problem3
            //EmployeeOne employee = new EmployeeOne(1, "Hady", 1000);
            //Console.WriteLine(employee.GetName());// Hady
            //Console.WriteLine(employee.displayEmpDetails());
            //employee.SetName("Ahmed");
            //Console.WriteLine(employee.GetName());// Ahmed
            #endregion

            //----------------------------------------------------------------

            #region Problem4
            //PointTwo pointTwo1 = new PointTwo(5);
            //Console.WriteLine(pointTwo1.ToString());
            //Console.WriteLine("------------------------");
            //PointTwo pointTwo2 = new PointTwo(5, 10);
            //Console.WriteLine(pointTwo2.ToString());
            #endregion

            //----------------------------------------------------------------

            #region Problem4
            //PointThree pointThree = new PointThree(5,5);
            //Console.WriteLine(pointThree.ToString());
            #endregion

            //----------------------------------------------------------------

            #region Problem5
            //    PointFour pointFour = new PointFour(1,2);
            //    Console.WriteLine($"Value of X is '{pointFour.x}', Value of Y is '{pointFour.y}'");
            //    EmployeeTwo employeeTwo = new EmployeeTwo("Hady");
            //    Console.WriteLine($"Employee Name is {employeeTwo.Name}.");
            //    static void ModifyPointFour(PointFour point)
            //    {
            //        point.x += 10;
            //        point.y += 10;
            //        Console.WriteLine($"From Method: Value of X is '{point.x}', Value of Y is '{point.y}'");
            //    }
            //    ModifyPointFour(pointFour);// don't affect .
            //    static void ModifyEmployeeTwo(EmployeeTwo employee)
            //    {
            //        employee.Name = "Ahmed";
            //        Console.WriteLine($"From Method: Employee = {employee.Name}");
            //    }
            //    ModifyEmployeeTwo(employeeTwo);//affect
            //}
            #endregion

            //----------------------------------------------------------------

            #endregion

        }
    }
}
