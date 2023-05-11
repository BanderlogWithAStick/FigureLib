using FiguresLib.Figures;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.Figures
{
    [TestClass]
    public class ConvexPolygonTests
    {
        [TestMethod]
        public void GetSquareTest1()
        {
            #region Arrange
            ConvexPolygon polygon = new ConvexPolygon(new Point[] {
                new Point(-4,3),
                new Point(3,-3),
                new Point(7,0),
                new Point(3,3)
            });
            double expected = 33D;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = polygon.GetSquare();
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется площадь в FiguresLib.Figures.ConvexPolygon.GetSquare();");
            #endregion
        }

        [TestMethod]
        public void GetSquareTest2()
        {
            #region Arrange
            ConvexPolygon polygon = new ConvexPolygon(new Point[] {
                new Point(-4,3),
                new Point(3,-3),
                new Point(7,0),
                new Point(7,6),
                new Point(0,6)
            });
            double expected = 66D;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = polygon.GetSquare();
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется площадь в FiguresLib.Figures.ConvexPolygon.GetSquare();");
            #endregion
        }
    }
}
