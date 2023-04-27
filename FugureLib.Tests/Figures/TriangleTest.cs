using FiguresLib.Figures;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.Figures
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Прямоугольный треугольник
        /// </summary>
        Triangle TriangleRight = new Triangle(
            new Point(0, 0),
            new Point(-4, 0),
            new Point(-4, -3));

        /// <summary>
        /// Равнобедренный непрямоугольный треугольник
        /// </summary>
        Triangle TriangleNotRight = new Triangle(
            new Point(0, 0),
            new Point(-8, 0),
            new Point(-4, 3));

        [TestMethod]
        public void GetSquareTest1()
        {
            bool result = 6D == TriangleRight.GetSquare();
            Assert.IsTrue(result, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Triangle.GetSquare();");
        }

        [TestMethod]
        public void GetSquareTest2()
        {
            bool result = 12D == TriangleNotRight.GetSquare();
            Assert.IsTrue(result, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Triangle.GetSquare();");
        }

        [TestMethod]
        public void IsRightTriangleTest1()
        {
            bool result = TriangleRight.IsRightTriangle;
            Assert.IsTrue(result, $"Ошибочно определяется прямоугольность в FiguresLib.Figures.Triangle.IsRightTriangle;");
        }

        [TestMethod]
        public void IsRightTriangleTest2()
        {
            bool result = TriangleNotRight.IsRightTriangle;
            Assert.IsFalse(result, $"Ошибочно определяется прямоугольность в FiguresLib.Figures.Triangle.IsRightTriangle;");
        }
    }
}
