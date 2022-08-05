using AreaCalculator.ShapesLibrary;
using AreaCalculator.ShapesLibrary.Shapes;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibraryTests
{
    public class AreaCalculationServiceTests
    {
        [Theory]
        [InlineData(1, 3.141592653589793)]
        [InlineData(5, 78.53981633974483)]
        [InlineData(15, 706.8583470577034)]
        public void Area_calculation_for_circle_is_successful(double radius, double expected)
        {
            var sut = new AreaCalculationService();
            IShape figure = new Circle(radius);

            var actual = sut.CalculateShapesArea(figure);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void Area_calculation_for_circle_with_invalid_radius_throws_exception(double radius)
        {
            var sut = new AreaCalculationService();

            Action act = () => sut.CalculateShapesArea(new Circle(radius));

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(3, 5, 6, 7.483314773547883)]
        [InlineData(6, 6, 8, 17.88854381999832)]
        [InlineData(3, 4, 5, 6)]
        public void Area_calculation_for_triangle_is_successful(double firstSide, double secondSide, double thirdSide, double expected)
        {
            var sut = new AreaCalculationService();
            IShape figure = new Triangle(firstSide, secondSide, thirdSide);

            var actual = sut.CalculateShapesArea(figure);

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, -5, 5)]
        [InlineData(1, 1, 2)]
        [InlineData(3, 4, 0)]
        public void Area_calculation_for_triangle_with_invalid_sides_throws_exception(double firstSide, double secondSide, double thirdSide)
        {
            var sut = new AreaCalculationService();

            Action act = () => sut.CalculateShapesArea(new Triangle(firstSide, secondSide, thirdSide));

            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
