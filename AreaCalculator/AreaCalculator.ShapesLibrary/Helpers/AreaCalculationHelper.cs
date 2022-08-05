namespace AreaCalculator.ShapesLibrary.Helpers
{
    /// <summary>
    /// Набор статических методов для вычисления площадей фигур.
    /// </summary>
    public static class AreaCalculationHelper
    {
        /// <summary>
        /// Вычислить площадь круга.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI* Math.Pow(radius, 2);
        }

        /// <summary>
        /// Вычислить площадь прямоугольного треугольника.
        /// </summary>
        /// <param name="firstLeg">Первый катет.</param>
        /// <param name="secondLeg">Второй катет.</param>
        /// <returns>Площадь прямоугольного треугольника.</returns>
        public static double CalculateAreaForRightTriangle(double firstLeg, double secondLeg)
        {
            return (firstLeg * secondLeg) / 2;
        }

        /// <summary>
        /// Вычислить площадь треугольника по формуле Герона.
        /// </summary>
        /// <param name="firstSide">Первая сторона.</param>
        /// <param name="secondSide">Вторая сторона.</param>
        /// <param name="thirdSide">Третья сторона.</param>
        /// <returns>Площадь треугольника.</returns>
        public static double CalculateTriangleAreaUsingHeronsFormula(double firstSide, double secondSide, double thirdSide)
        {
            var semiperimeter = CalculateSemiperimeter(firstSide, secondSide, thirdSide);

            return Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));
        }

        private static double CalculateSemiperimeter(double firstSide, double secondSide, double thirdSide)
        {
            return (firstSide + secondSide + thirdSide) / 2;
        }
    }
}