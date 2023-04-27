using FiguresLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = FiguresLib.LibMath.PointD;

namespace FiguresLib.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : ConvexPolygon
    {
        /// <summary>
        /// Создает треугольник по трем точкам
        /// </summary>
        /// <param name="A">Точка A</param>
        /// <param name="B">Точка B</param>
        /// <param name="C">Точка C</param>
        public Triangle(Point A, Point B, Point C) : base(new Point[] { new Point(A), new Point(B), new Point(C) }) { }
        public bool IsRightTriangle
        {
            get
            {
                double al = Point.P2P(FigurePoints[0], FigurePoints[1]);
                double bl = Point.P2P(FigurePoints[1], FigurePoints[2]);
                double cl = Point.P2P(FigurePoints[2], FigurePoints[0]);
                return
                    Math.Pow(al, 2) + Math.Pow(bl, 2) == Math.Pow(cl, 2) ||
                    Math.Pow(bl, 2) + Math.Pow(cl, 2) == Math.Pow(al, 2) ||
                    Math.Pow(cl, 2) + Math.Pow(al, 2) == Math.Pow(bl, 2)
                    ;
            }
        }
    }
}
