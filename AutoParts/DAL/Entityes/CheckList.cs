using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.DAL.Entityes
{
    /// <summary>
    /// Таблица чека заказа
    /// </summary>
    public class CheckList
    {
        /// <summary>
        /// Уникальный номер
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Номер зхаказа к которому пренадлежит позиция
        /// </summary>
        public int OrderID { get; set; }
        /// <summary>
        /// Экземпляр заказа
        /// </summary>
        public Order Order { get; set; }
        /// <summary>
        /// Номер продукта со склада
        /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// Экземпляр продукта
        /// </summary>
        public Product Product { get; set; }
        /// <summary>
        /// Кол-во продукта
        /// </summary>
        public int Count { get; set; }
    }
}
