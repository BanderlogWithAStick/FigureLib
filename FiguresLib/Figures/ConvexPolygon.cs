using FiguresLib.Interfaces;
using FiguresLib.LibMath;
using Point = FiguresLib.LibMath.PointD;

namespace FiguresLib.Figures
{
    /// <summary>
    /// Выпуклый многоугольник
    /// </summary>
    public class ConvexPolygon : Figure, ISquarable
    {
        /// <summary>
        /// Создает выпуклый многоугольник из последовательности точек
        /// </summary>
        /// <param name="points">Точки</param>
        /// <exception cref="ArgumentNullException">Нулевое значение массива точек</exception>
        /// <exception cref="ArgumentException">Некорректный аргумент</exception>
        public ConvexPolygon(IEnumerable<Point> points)
        {
            #region ArgumentExceptions
            if (points == null) throw new ArgumentNullException(nameof(points));
            if (points.Count() < 3) throw new ArgumentException("Фигура должна содержать 3 и более точек");
            #endregion

            FigurePoints = new Point[points.Count()];
            for (int i = 0; i < points.Count(); i++) FigurePoints[i] = points.ElementAt(i);
        }

        /// <summary>
        /// Возвращает площадь многоугольника
        /// </summary>
        /// <returns>Площадь</returns>
        public override double GetSquare()
        {
            double sqsum = 0;
            for (int i = 0; i < FigurePoints.Length - 2; i++) sqsum += TriangleMath.GetTriangleSquare(FigurePoints[0], FigurePoints[i+1], FigurePoints[i+2]);
            return sqsum;
        }
    }
}
