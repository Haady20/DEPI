using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace AssigmentEight
{
    public class SquareSeries : IShapeSeries
    {
        private int currentSideLength = 0;
        public int CurrentShapeArea { get; set; }
        public void GetNextArea()
        {
            currentSideLength++;
            CurrentShapeArea = currentSideLength * currentSideLength; // Area = side^2
        }
        public void PrintTenShapes()
        {
            ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                GetNextArea();
                Console.WriteLine($"Square {i + 1} Area: {CurrentShapeArea}");
            }
        }
        public void ResetSeries()
        {
            currentSideLength = 0;
            CurrentShapeArea = 0;
        }
    }
}   
