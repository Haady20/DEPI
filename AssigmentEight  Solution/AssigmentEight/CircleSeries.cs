using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace AssigmentEight
{
    public class CircleSeries : IShapeSeries
    {
        private int currentRadius = 0;

        public int CurrentShapeArea { get; set; }

        public void GetNextArea()
        {
            currentRadius++;
            CurrentShapeArea = (int)(Math.PI * currentRadius * currentRadius); // Area = π * r^2
        }
        public void PrintTenShapes()
        {
            ResetSeries();
            for (int i = 0; i < 10; i++)
            {
                GetNextArea();
                Console.WriteLine($"Circle {i + 1} Area: {CurrentShapeArea}");
            }
        }
        public void ResetSeries()
        {
            currentRadius = 0;
            CurrentShapeArea = 0;
        }

    }
}
