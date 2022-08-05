using AreaCalculator.ShapesLibrary.Shapes;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibraryTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 5, 6, 7.483314773547883)]
        [InlineData(6, 6, 8, 17.88854381999832)]
        [InlineData(3, 4, 5, 6)]
        public void Area_calculation_is_successful(double firstSide, double secondSide, double thirdSide, double expected)
        {
            var sut = new Triangle(firstSide, secondSide, thirdSide);

            var actual = sut.GetArea();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData(3, -5, 5)]
        [InlineData(-2, 4, 5)]
        [InlineData(3, 4, -1)]
        public void Triangle_creation_throws_exception_when_side_is_negative(double firstSide, double secondSide, double thirdSide)
        {
            Action act = () => new Triangle(firstSide, secondSide, thirdSide);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(3, 0, 5)]
        [InlineData(0, 4, 5)]
        [InlineData(3, 4, 0)]
        public void Triangle_creation_throws_exception_when_side_is_zero(double firstSide, double secondSide, double thirdSide)
        {
            Action act = () => new Triangle(firstSide, secondSide, thirdSide);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(10, 1, 5)]
        public void Triangle_creation_throws_exception_when_triangle_cant_exist_with_passed_positive_sides(double firstSide, double secondSide, double thirdSide)
        {
            Action act = () => new Triangle(firstSide, secondSide, thirdSide);

            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Triangle_creation_with_equal_sides_is_successful()
        {
            Action act = () => new Triangle(5, 5, 5);

            act.Should().NotThrow();
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6, 8, 10)]
        public void Triangle_is_right_triangle(double firstSide, double secondSide, double thirdSide)
        {
            var actual = Triangle.IsTriangleRight(firstSide, secondSide, thirdSide);

            actual.Should().BeTrue();
        }

        [Theory]
        [InlineData(5, 5, 5)]
        [InlineData(6, 8, 9)]
        [InlineData(3, 5, 6)]
        public void Triangle_is_not_right_triangle(double firstSide, double secondSide, double thirdSide)
        {
            var actual = Triangle.IsTriangleRight(firstSide, secondSide, thirdSide);

            actual.Should().BeFalse();
        }

        [Fact]
        public void False_check_for_right_triangle_with_unordered_sides()
        {
            var actual = Triangle.IsTriangleRight(3, 5, 4);

            actual.Should().BeFalse();
        }
    }
}
