using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib.Interfaces
{
    /// <summary>
    /// С вычисляемой площадью
    /// </summary>
    public interface ISquarable
    {
        /// <summary>
        /// Вычисляет площадь
        /// </summary>
        /// <returns>Площадь</returns>
        public double GetSquare();
    }
}
