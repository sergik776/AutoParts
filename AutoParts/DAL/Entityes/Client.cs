using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts.DAL.Entityes
{
    /// <summary>
    /// Модель клиента
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Уникальный номер
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Family { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Эмейл
        /// </summary>
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Family} {Name} {LastName}";
        }
    }
}
