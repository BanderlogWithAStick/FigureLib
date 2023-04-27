using FiguresLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = FiguresLib.LibMath.PointD;

namespace FiguresLib.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Создает единичную окружность
        /// </summary>
        public Circle() {
            FigurePoints = new Point[2];
            FigurePoints[0] = new Point(0, 0);
            FigurePoints[1] = new Point(1, 0);
        }

        /// <summary>
        /// Создает окружность с центром в точке center и радиусом r
        /// </summary>
        /// <param name="center">Центр окружности</param>
        /// <param name="r">Радиус</param>
        public Circle(Point center, double r)
        {
            FigurePoints = new Point[2];
            FigurePoints[0] = center;
            FigurePoints[1] = new Point(center.X + r, center.Y);
        }

        /// <summary>
        /// Создает окружность с центром в точке center и крайней точкой окружности в точке border
        /// </summary>
        /// <param name="center">Центр окружности</param>
        /// <param name="border">Крайняя точка окружности</param>
        public Circle(Point center, Point border)
        {
            FigurePoints = new Point[2];
            FigurePoints[0] = center;
            FigurePoints[1] = border;
        }

        /// <summary>
        /// Количество точек в круге
        /// </summary>
        public double PointCount { get { return double.PositiveInfinity; } }

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get { return Point.P2P(FigurePoints[0], FigurePoints[1]); } }

        /// <summary>
        /// Площадь окружности
        /// </summary>
        /// <returns>Площадь</returns>
        public override double GetSquare()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 6);
        }
    }
}
