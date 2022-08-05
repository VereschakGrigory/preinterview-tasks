using AreaCalculator.ShapesLibrary.Helpers;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibraryTests
{
    public class AreaCalculationHelperTests
    {
        [Theory]
        [InlineData(1, 3.141592653589793)]
        [InlineData(5, 78.53981633974483)]
        [InlineData(15, 706.8583470577034)]
        public void Calculate_circle_area(double radius, double expected)
        {
            var actual = AreaCalculationHelper.CalculateCircleArea(radius);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 4, 6)]
        [InlineData(6, 8, 24)]
        [InlineData(12, 16, 96)]
        public void Calculate_right_triangle_area(double firstLeg, double secondLeg, double expected)
        {
            var actual = AreaCalculationHelper.CalculateAreaForRightTriangle(firstLeg, secondLeg);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, 5, 6, 7.483314773547883)]
        [InlineData(6, 6, 8, 17.88854381999832)]
        [InlineData(3, 4, 5, 6)]
        public void Calculate_triangle_area_using_herons_formula(double firstSide, double secondSide, double thirdSide, double expected)
        {
            var actual = AreaCalculationHelper.CalculateTriangleAreaUsingHeronsFormula(firstSide, secondSide, thirdSide);

            actual.Should().Be(expected);
        }
    }
}
