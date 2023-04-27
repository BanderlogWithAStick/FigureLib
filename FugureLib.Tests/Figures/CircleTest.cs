using FiguresLib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = FiguresLib.LibMath.PointD;

namespace FugureLib.Tests.Figures
{
    [TestClass]
    public class CircleTest
    {

        [TestMethod]
        public void RadiusTest()
        {
            Circle circle = new Circle(new Point(0, 0), new Point(4, 3));
            bool result = circle.Radius == 5;
            Assert.IsTrue(result, $"Ошибочно вычисляется радиус в FiguresLib.Figures.Circle.Radius;");
        }

        [TestMethod]
        public void GetSquareTest1()
        {
            Circle circle = new Circle(new Point(0,0), new Point(2,0));
            bool result = circle.GetSquare() == Math.Round(Math.PI * 4, 6);
            Assert.IsTrue(result, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Circle.GetSquare();");
        }

        [TestMethod]
        public void GetSquareTest2()
        {
            Circle circle = new Circle();
            bool result = circle.GetSquare() == Math.Round(Math.PI, 6);
            Assert.IsTrue(result, $"Ошибочно вычисляется площадь в FiguresLib.Figures.Circle.GetSquare();");
        }
    }
}
