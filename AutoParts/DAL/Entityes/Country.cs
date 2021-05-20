using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.DAL.Entityes
{
    /// <summary>
    /// Таблица стран
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Уникальный номер
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Название страны
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список продуктов из этой страны
        /// </summary>
        public ICollection<Product> Products { get; set; }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Country()
        {
            ///Инициализация списка продуктов из этой страны
            Products = new List<Product>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
