using Point = FiguresLib.LibMath.PointD;

namespace FiguresLib.LibMath
{
    /// <summary>
    /// Метаметика треугольников
    /// </summary>
    public class TriangleMath
    {
        private TriangleMath() { }

        /// <summary>
        /// Возвращает площадь треугольника
        /// </summary>
        /// <param name="a">Точка A</param>
        /// <param name="b">Точка B</param>
        /// <param name="c">Точка C</param>
        /// <returns>Площадь</returns>
        public static double GetTriangleSquare(Point a, Point b, Point c)
        {
            double al = Point.P2P(a, b);
            double bl = Point.P2P(b, c);
            double cl = Point.P2P(c, a);
            double pp = (al + bl + cl) / 2;
            return Math.Sqrt(pp * (pp - al) * (pp - bl) * (pp - cl));
        }
    }
}
