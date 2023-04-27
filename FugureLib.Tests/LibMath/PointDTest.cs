using FiguresLib.LibMath;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.LibMath
{
    [TestClass]
    public class PointDTest
    {
        [TestMethod]
        public void P2PTest()
        {
            Point p1 = new Point(3, 4);
            bool result = PointD.P2P(new Point(0, 0), p1) == 5D;
            Assert.IsTrue(result, $"Ошибочно вычисляется расстояние между двумя точками в FiguresLib.LibMath.PointD.P2P;");
        }
    }
}