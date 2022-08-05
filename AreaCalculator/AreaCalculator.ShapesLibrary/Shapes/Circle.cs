using AreaCalculator.ShapesLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibrary.Shapes
{
    public class Circle : IShape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value > 0 ? value : throw new ArgumentOutOfRangeException(); }
        }

        public Circle(double r)
        {
            Radius = r;
        }

        public double GetArea()
        {
            return AreaCalculationHelper.CalculateCircleArea(Radius);
        }
    }
}
