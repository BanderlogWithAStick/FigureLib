using FiguresLib.LibMath;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.LibMath
{
    [TestClass]
    public class PointDTests
    {
        [TestMethod]
        public void P2PTest()
        {
            #region Arrange
            Point p1 = new Point(2, 7);
            Point p2 = new Point(5, 1);
            double expected = 6.708203D;
            double delta = 0.000001D;
            #endregion

            #region Act
            double actual = Point.P2P(p1, p2);
            #endregion

            #region Assert
            Assert.AreEqual(expected, actual, delta, $"Ошибочно вычисляется расстояние между двумя точками в FiguresLib.LibMath.PointD.P2P(PointD a, PointD b);");
            #endregion
        }
    }
}