using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoParts.DAL.Contexts;
using AutoParts.DAL.Entityes;

namespace AutoParts.DAL
{
    /// <summary>
    /// Инициализатор базы данных
    /// </summary>
    public class DBInitializer : DropCreateDatabaseAlways<AutoPartsContext>
    {
        /// <summary>
        /// Метод инициализации
        /// </summary>
        /// <param name="db"></param>
        protected override void Seed(AutoPartsContext db)
        {
            //Начальыне данные
            Country c1 = new Country() { Name = "Украина" };
            Country c2 = new Country() { Name = "Россия" };
            Country c3 = new Country() { Name = "Германия" };

            Client cl1 = new Client() { Name = "Сергей", Family = "Новицкий", LastName = "Ильич", Email = "novickii.sergei.nure@gmail.com", Phone = "0679379992" };

            Product p1 = new Product() { Name = "Поршень", CountryID = 3, Price = 1500, Count = 4, Year = new DateTime(2005, 1, 1) };
            Product p2 = new Product() { Name = "Колесо", CountryID = 2, Price = 750, Count = 21, Year = new DateTime(2017, 1, 1) };

            Order o1 = new Order() { ClientID = 1, Date = DateTime.Now };
            Order o2 = new Order() { ClientID = 1, Date = DateTime.Now };
            CheckList ch1 = new CheckList() { OrderID = 1, ProductID = 2, Count = 3 };
            CheckList ch2 = new CheckList() { OrderID = 2, ProductID = 1, Count = 21 };
            CheckList ch3 = new CheckList() { OrderID = 2, ProductID = 2, Count = 9 };

            //Добавляем в БД
            db.Countries.Add(c1);
            db.Countries.Add(c2);
            db.Countries.Add(c3);
            db.Clients.Add(cl1);
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Orders.Add(o1);
            db.Orders.Add(o2);
            db.SaveChanges();
            db.CheckLists.Add(ch1);
            db.CheckLists.Add(ch2);
            db.CheckLists.Add(ch3);
            //Сохраняем
            db.SaveChanges();
        }
    }
}
