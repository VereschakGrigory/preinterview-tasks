using AreaCalculator.ShapesLibrary.Shapes;
using FluentAssertions;

namespace AreaCalculator.ShapesLibraryTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 3.141592653589793)]
        [InlineData(5, 78.53981633974483)]
        [InlineData(15, 706.8583470577034)]
        public void Area_calculation_is_successful(double radius, double expected)
        {
            var sut = new Circle(radius);

            var actual = sut.GetArea();

            actual.Should().Be(expected);
        }

        [Fact]
        public void Circle_creation_with_negative_radius_fails()
        {
            Action act = () => new Circle(-5);
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Circle_creation_with_zero_radius_fails()
        {
            Action act = () => new Circle(0);
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Circle_creation_with_positive_radius_is_successful()
        {
            Action act = () => new Circle(5);
            act.Should().NotThrow();
        }
    }
}