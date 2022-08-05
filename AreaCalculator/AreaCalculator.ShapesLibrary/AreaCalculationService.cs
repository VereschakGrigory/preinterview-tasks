using AreaCalculator.ShapesLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibrary
{
    public class AreaCalculationService : IAreaCalculationService
    {
        public double CalculateShapesArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
