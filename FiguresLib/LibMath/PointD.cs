namespace FiguresLib.LibMath
{
    /// <summary>
    /// Точка с double координатами
    /// </summary>
    public struct PointD
    {
        /// <summary>
        /// Создает точку с указанными координатами
        /// </summary>
        /// <param name="x">Значение абсциссы</param>
        /// <param name="y">Значение ординаты</param>
        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Создает точку копию
        /// </summary>
        /// <param name="source">Источник копии</param>
        public PointD(PointD source)
        {
            this = source;
        }

        /// <summary>
        /// Значение по оси абсцисс
        /// </summary>
        public double X { get; }
        /// <summary>
        /// Значение по оси ординат
        /// </summary>
        public double Y { get; }
        
        public override string ToString() => $"({X}|{Y})";

        /// <summary>
        /// Вычисляет расстояние между двумя PointD
        /// </summary>
        /// <param name="a">Точка A</param>
        /// <param name="b">Точка B</param>
        /// <returns>Расстояние</returns>
        public static double P2P(PointD a, PointD b) { return Math.Abs(Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2))); }
    }
}
