using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoParts.DAL.Entityes;

namespace AutoParts.Models
{
    /// <summary>
    /// Модель просмотра заказов
    /// </summary>
    // наследуем базовый класс
    public class OrderView : Order
    {
        /// <summary>
        /// Номер телефона клиента
        /// </summary>
        public string Phone { get { return base.Client.Phone; } }
        /// <summary>
        /// Эмейл клинета
        /// </summary>
        public string Email { get { return base.Client.Email; } }
    }
}
