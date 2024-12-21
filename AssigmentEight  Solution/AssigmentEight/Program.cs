using System;

namespace AssigmentEight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Problem01
            //IVehicle car = new Car("Home", "Company");
            //Console.WriteLine(car.StartEngine());
            //Console.WriteLine(car.StopEngine());
            //Console.WriteLine("---------------------");
            //IVehicle bike = new Bike("Home", "School");
            //Console.WriteLine(bike.StartEngine());
            //Console.WriteLine(bike.StopEngine());
            #endregion

            //-------------------------------------------------

            #region Problem02
            //Rectangle rectangle = new Rectangle(10,20);
            //Console.WriteLine(rectangle.Display());
            //Console.WriteLine(rectangle.GetArea());
            //Console.WriteLine("---------------------");
            //Circle circle = new Circle(10);
            //Console.WriteLine(circle.Display());
            //Console.WriteLine(circle.GetArea());
            #endregion

            //-------------------------------------------------

            #region Problem03
            //Product[] product = {
            //     new Product(1,"iphone",500),
            //     new Product(2,"Huawei",100),
            //     new Product(3,"Samsung",400),
            //     new Product(4,"Redmi",200),
            // };
            // Array.Sort(product);
            // Console.WriteLine("Sorted Products by Price is:");
            // foreach (var item in product)
            // {
            //     Console.WriteLine(item);
            // }
            #endregion

            //-------------------------------------------------

            #region Problem04
            //IWalkable walkable1 = new Robot("Street");
            //Console.WriteLine(walkable1.Walk());
            //Console.WriteLine("---------------------");
            //IWalkable walkable2 = new Robot("Home");
            //Console.WriteLine(walkable2.Walk());
            #endregion

            //-------------------------------------------------

            #region Problem05
            //Account account = new Account(1,"Hady",1000);
            //Console.WriteLine(account);
            //Console.WriteLine(account.GetId);
            //Console.WriteLine(account.GetAccountHolder);
            //Console.WriteLine(account.GetBalance);
            #endregion

            //-------------------------------------------------

            #region Problem06
            //ILogger logger = new ConsoleLogger();
            //logger.log();
            #endregion

            //-------------------------------------------------



            #region Problem06
            //Book book1 = new Book("Wild Animals");
            //Console.WriteLine(book1.ToString());
            //Book book2 = new Book("Wild Animals", "Ahmed");
            //Console.WriteLine(book2.ToString());
            #endregion

            //-------------------------------------------------

            #endregion

            //-------------------------------------------------

            #region Part02
            IShapeSeries squareSeries = new SquareSeries();
            Console.WriteLine("Square Series:");
            squareSeries.PrintTenShapes();

            Console.WriteLine("Circle Series:");
            IShapeSeries circleSeries = new CircleSeries();
            circleSeries.PrintTenShapes();
            #endregion

            //-------------------------------------------------


        }
    }
}
