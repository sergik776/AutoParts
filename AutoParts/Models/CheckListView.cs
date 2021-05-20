using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoParts.DAL.Entityes;

namespace AutoParts.Models
{
    /// <summary>
    /// Модель просмотра списка товаров в заказе
    /// </summary>
    // наследуем базовый класс
    public class CheckListView : CheckList
    {
        /// <summary>
        /// Страна произваодитель
        /// </summary>
        public string Country { get { return base.Product.Country.Name; } }
        /// <summary>
        /// Год выпуска
        /// </summary>
        public string ProductYear { get { return base.Product.Year.ToString("yyyy"); } }
    }
}
