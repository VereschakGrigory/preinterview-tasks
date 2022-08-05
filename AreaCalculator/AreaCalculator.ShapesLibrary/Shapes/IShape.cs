using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.ShapesLibrary.Shapes
{
    public interface IShape
    {
        /// <summary>
        /// Получить площадь фигуры.
        /// </summary>
        /// <returns></returns>
        public double GetArea();
    }
}
