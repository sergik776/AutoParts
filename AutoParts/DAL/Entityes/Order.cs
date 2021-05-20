using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.DAL.Entityes
{
    /// <summary>
    /// Таблица заказов
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный номер заказа
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Номер клиента
        /// </summary>
        public int ClientID { get; set; }
        /// <summary>
        /// Экземпляр клиента
        /// </summary>
        public Client Client { get; set; }
        /// <summary>
        /// Дата заказа
        /// </summary>
        public DateTime Date { get; set; }
        public ICollection<CheckList> CheckLists { get; set; }
        public Order()
        {
            CheckLists = new List<CheckList>();
        }
    }
}
