using FiguresLib.Figures;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.Figures
{
    [TestClass]
    public class ConvexPolygonTest
    {
        [TestMethod]
        public void GetSquareTest1()
        {
            ConvexPolygon polygon = new ConvexPolygon( new Point[] {
                new Point(-4,3),
                new Point(3,-3),
                new Point(7,0),
                new Point(3,3)
            });
            bool result = 33D == polygon.GetSquare();
            Assert.IsTrue(result, $"Ошибочно вычисляется площадь в FiguresLib.Figures.ConvexPolygon.GetSquare();");
        }

        [TestMethod]
        public void GetSquareTest2()
        {
            ConvexPolygon polygon = new ConvexPolygon(new Point[] {
                new Point(-4,3),
                new Point(3,-3),
                new Point(7,0),
                new Point(7,6),
                new Point(0,6)
            });
            bool result = 66D == polygon.GetSquare();
            Assert.IsTrue(result, $"Ошибочно вычисляется площадь в FiguresLib.Figures.ConvexPolygon.GetSquare();");
        }
    }
}
