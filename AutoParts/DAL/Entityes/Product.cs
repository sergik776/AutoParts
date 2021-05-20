using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.DAL.Entityes
{
    /// <summary>
    /// Таблица товаров
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Уникальный номер
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Номер страны производителя
        /// </summary>
        public int CountryID { get; set; }
        /// <summary>
        /// Вложенный экземпляр строны производителя
        /// </summary>
        public Country Country { get; set; }
        /// <summary>
        /// Название товара
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Стоимость товара
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Кол-ао товара на складе
        /// </summary>
        public int Count { get; set; }
        public DateTime Year { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
