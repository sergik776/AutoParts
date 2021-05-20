using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoParts.DAL.Entityes;

namespace AutoParts.DAL.Contexts
{
    /// <summary>
    /// Контекст данных
    /// </summary>
    //Наследуемся от энтити фреймворка
    public class AutoPartsContext : DbContext
    {
        /// <summary>
        /// ПОдключаем инициализатор базы данных
        /// </summary>
        static AutoPartsContext()
        {
            Database.SetInitializer(new DBInitializer());
        }
        //Создаем конмтруктор, передаем базвому конструктору название строки подключения
        public AutoPartsContext() : base("DefaultConnection") { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CheckList> CheckLists { get; set; }
    }
}
