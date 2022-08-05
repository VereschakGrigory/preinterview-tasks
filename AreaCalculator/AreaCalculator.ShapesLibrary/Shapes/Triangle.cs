using AreaCalculator.ShapesLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibrary.Shapes
{
    public class Triangle : IShape
    {
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        public double FirstSide {
            get { return _firstSide; }
            set { _firstSide = value > 0 ? value : throw new ArgumentOutOfRangeException(); }
        }

        public double SecondSide
        {
            get { return _secondSide; }
            set { _secondSide = value > 0 ? value : throw new ArgumentOutOfRangeException(); }
        }

        public double ThirdSide
        {
            get { return _thirdSide; }
            set { _thirdSide = value > 0 ? value : throw new ArgumentOutOfRangeException(); }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!CanTriangleExist(firstSide, secondSide, thirdSide))
            {
                throw new ArgumentOutOfRangeException();
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double GetArea()
        {
            // Неизвестно, в каком порядке передаются стороны треугольника в конструктор класса.
            // Для проверки треугольника, является ли он прямоугольным, необходимо упорядочить по длине стороны.
            var (minSide, midSide, maxSide) = GetSidesOrderedByLength();

            if (IsTriangleRight(minSide, midSide, maxSide))
            {
                return AreaCalculationHelper.CalculateAreaForRightTriangle(minSide, midSide);
            }

            return AreaCalculationHelper.CalculateTriangleAreaUsingHeronsFormula(FirstSide, SecondSide, ThirdSide);
        }

        /// <summary>
        /// Определение, является ли треугольник с указанными по возрастанию длины сторонами прямоугольным, по обратной теореме Пифагора.
        /// </summary>
        /// <param name="firstSide">Первая сторона.</param>
        /// <param name="secondSide">Вторая сторона.</param>
        /// <param name="thirdSide">Третья сторона.</param>
        /// <returns>True, если треугольник - прямоугольный, иначе - False.</returns>
        public static bool IsTriangleRight(double firstSide, double secondSide, double thirdSide)
        {
            return Math.Pow(thirdSide, 2) == (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));
        }

        private (double minSide, double midSide, double maxSide) GetSidesOrderedByLength()
        {
            double[] sides = { FirstSide, SecondSide, ThirdSide };
            Array.Sort(sides);

            return (minSide: sides[0], midSide: sides[1], maxSide: sides[2]);
        }

        private static bool CanTriangleExist(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide > thirdSide && secondSide + thirdSide > firstSide && thirdSide + firstSide > secondSide;
        }
    }
}
