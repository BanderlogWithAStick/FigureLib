using FiguresLib.Figures;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.Figures
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        public void RadiusTest()
        {
            #region Arrange
            Circle circle = new Circle(new Point(0, 0), new Point(4, 3));
            double expected = 5D;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = circle.Radius;
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется радиус в FiguresLib.Figures.Circle.Radius;");
            #endregion
        }

        [TestMethod]
        public void GetSquareTest1()
        {
            #region Arrange
            Circle circle = new Circle(new Point(0, 0), new Point(2, 0));
            double expected = Math.PI * 4;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = circle.GetSquare();
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Circle.GetSquare();");
            #endregion
        }

        [TestMethod]
        public void GetSquareTest2()
        {
            #region Arrange
            Circle circle = new Circle();
            double expected = Math.PI;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = circle.GetSquare();
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Circle.GetSquare();");
            #endregion
        }
    }
}
