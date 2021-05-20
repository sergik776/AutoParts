using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoParts.DAL.Entityes;

namespace AutoParts.Models
{
    /// <summary>
    /// Модель просмотра товаров
    /// </summary>
    // наследуем базовый класс
    public class ProductView : Product
    {
        /// <summary>
        /// Год выпуска в формате "только год"
        /// </summary>
        public string sYear { get { return Year.ToString("yyyy"); } }
    }
}
