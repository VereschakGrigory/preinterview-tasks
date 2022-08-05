using AreaCalculator.ShapesLibrary.Shapes;

namespace AreaCalculator.ShapesLibrary
{
    /// <summary>
    /// Поскольку точно неизвестно, что должна предоставлять библиотека конечному
    /// пользователю - набор классов фигур, поддерживающих вычисление площади,
    /// или интерфейс сервиса для вычисления площади заданной фигуры,
    /// помимо набора классов фигур сделан интерфейс с методом-оберткой.
    /// </summary>
    public interface IAreaCalculationService
    {
        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        /// <param name="shape">Фигура.</param>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateShapesArea(IShape shape);
    }
}