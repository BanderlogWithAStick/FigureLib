using FiguresLib.Interfaces;
using Point = FiguresLib.LibMath.PointD;

namespace FiguresLib.Figures
{
    /// <summary>
    /// Фигура
    /// </summary>
    public abstract class Figure : ISquarable
    {
        /// <summary>
        /// Описывающие фигуру точки
        /// </summary>
        public Point[] FigurePoints { get; set; }

        public abstract double GetSquare();

        /// <summary>
        /// Количество точек в фигуре
        /// </summary>
        public double PointsCount { get {  return FigurePoints.Length; } }
    }
}
