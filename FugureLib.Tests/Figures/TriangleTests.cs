using FiguresLib.Figures;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.Figures
{
    [TestClass]
    public class TriangleTests
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
            #region Arrange
            double expected = 6D;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = TriangleRight.GetSquare();
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Triangle.GetSquare();");
            #endregion
        }

        [TestMethod]
        public void GetSquareTest2()
        {
            #region Arrange
            double expected = 12D;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = TriangleNotRight.GetSquare();
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Triangle.GetSquare();");
            #endregion
        }

        [TestMethod]
        public void IsRightTriangleTest1()
        {
            #region Act
            bool actual = TriangleRight.IsRightTriangle;
            #endregion

            #region Assert
            Assert.IsTrue(actual, $"Ошибочно определяется прямоугольность треугольника в FiguresLib.Figures.Triangle.IsRightTriangle;");
            #endregion
        }

        [TestMethod]
        public void IsRightTriangleTest2()
        {
            #region Act
            bool actual = TriangleNotRight.IsRightTriangle;
            #endregion

            #region Assert
            Assert.IsFalse(actual, $"Ошибочно определяется прямоугольность треугольника в FiguresLib.Figures.Triangle.IsRightTriangle;");
            #endregion
        }
    }
}
