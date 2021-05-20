using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoParts.DAL.Contexts;
using AutoParts.DAL.Entityes;
using AutoParts.Models;

namespace AutoParts
{
    public partial class MainForm : Form
    {
        //Создаем контекст данных
        AutoPartsContext APC;
        //Создаем делегат для передачи и хранения методов
        delegate void MyMethDel(int id);

        public MainForm()
        {
            InitializeComponent();
            //Инициализируем БД
            APC = new AutoPartsContext();
            //обновляем интерфейс
            RefreshUI();
            cb_country.SelectedIndex = -1;
        }

        /// <summary>
        /// Метод обновления интерфейса и привязки данных
        /// </summary>
        void RefreshUI()
        {
            DGV_country.DataSource = APC.Countries.ToList();
            DGV_Client.DataSource = APC.Clients.ToList();
            DGV_product.DataSource = (from w in APC.Products.ToList()
                                     select new ProductView()
                                     {
                                         Count = w.Count,
                                         Country = w.Country,
                                         CountryID = w.CountryID,
                                         ID = w.ID,
                                         Name = w.Name,
                                         Price = w.Price, 
                                         Year = w.Year
                                     }).ToList();
            cb_country.DataSource = new BindingSource(APC.Countries.ToList(), null);
            cb_country.DisplayMember = "Name";
            cb_country.ValueMember = "ID";
            DGV_order.DataSource = (from a in APC.Orders.ToList()
                                   select new OrderView
                                   {
                                       CheckLists = a.CheckLists,
                                       Client = a.Client,
                                       ClientID = a.ClientID,
                                       Date = a.Date,
                                       ID = a.ID
                                   }).ToList();
        }

        #region Управление клиентами
        /// <summary>
        /// Метод добавления клиента
        /// </summary>
        /// <param name="id">Не обязательный параметр, тут не играет роли</param>
        void AddClent(int id = 0)
        {
            //Создаем форму клиента
            AddClients CF = new AddClients();
            if(CF.ShowDialog() == DialogResult.OK)
            {
                //Добавляем в БД данные из формы
                APC.Clients.Add(new Client() { Name = CF.NameClient, Email = CF.Email, Family = CF.Family, LastName = CF.LastName, Phone = CF.Phone });
                //Сохраняем изменения
                APC.SaveChanges();
                //Обновляем интерфейс
                RefreshUI();
            }
        }

        /// <summary>
        /// Метод редактирования клиента
        /// </summary>
        /// <param name="id">Айди клиента из БД</param>
        void ChangeClent(int id = 0)
        {
            //Находим клиента для редактирования в базе по айди
            var clientFinded = APC.Clients.Where(c => c.ID == id).FirstOrDefault();
            //Создаем форму для редактирования (основой является форма создания клиента)
            AddClients CF = new AddClients();
            //Далее заполняем поля формы данными найденого клиента
            CF.NameClient = clientFinded.Name;
            CF.Family = clientFinded.Family;
            CF.LastName = clientFinded.LastName;
            CF.Phone = clientFinded.Phone;
            CF.Email = clientFinded.Email;
            //Удостоверяемся что пользователь нажал "ОК"
            if (CF.ShowDialog() == DialogResult.OK)
            {
                //Проверяем, что такая запись есть в базе
                if (clientFinded != null)
                {
                    //Заменяем данные клиента новыми данными которые ввел пользователь
                    clientFinded.Name = CF.NameClient;
                    clientFinded.Family = CF.Family;
                    clientFinded.LastName = CF.LastName;
                    clientFinded.Phone = CF.Phone;
                    clientFinded.Email = CF.Email;
                }
                //Сохраняем изменения
                APC.SaveChanges();
                //Обновляем интерфейс
                RefreshUI();
            }
        }

        /// <summary>
        /// Метод удаления клиента
        /// </summary>
        /// <param name="id">Айди клиента из БД</param>
        void DeleteClent(int id = 0)
        {
            //Находим клиента для редактирования в базе по айди
            var clientFinded = APC.Clients.Where(c => c.ID == id).FirstOrDefault();
            //Проверяем, что такая запись есть в базе
            if (clientFinded != null)
            {
                //Проверяем не привязаны ли записи к удаляемому объекту
                if (APC.Orders.Where(c => c.ClientID == id).Count() <= 0)
                {
                    //Удаляем запись из БД
                    APC.Clients.Remove(clientFinded);
                    //Сохраняем данные
                    APC.SaveChanges();
                    //Обновляем интерфейс
                    RefreshUI();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити клієнта. \nНа нього оформлені замовлення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
#endregion
        #region Управление странами
        /// <summary>
        /// Метод добавления страны
        /// </summary>
        /// <param name="id">Не обязательынй параметр, в даном случае не играет роли</param>
        void AddCountry(int id = 0)
        {
            //Создаем форму добавления страны
            FormAddCountry ACF = new FormAddCountry();
            //Удостоверяемся что пользователь нажал "ОК"
            if (ACF.ShowDialog() == DialogResult.OK)
            {
                //Добавляем в БД данные из формы
                APC.Countries.Add(new Country() { Name = ACF.CountryName });
                //Сохраняем изменения
                APC.SaveChanges();
                //Обновляем интерфейс
                RefreshUI();
            }
        }

        /// <summary>
        /// Метод редактирования страны
        /// </summary>
        /// <param name="id">Номер редактируемой страны из базы</param>
        void ChangeCountry(int id)
        {
            //Находим страну для редактирования в базе по айди
            var countryFinded = APC.Countries.Where(c => c.ID == id).FirstOrDefault();
            //Создаем форму для редактирования (основой является форма создания страны)
            FormAddCountry ACF = new FormAddCountry();
            //Изменяем поле название формы с "Добавить страну" на "Изменить страну"
            ACF.Text = "Редактирвоать страну";
            //Заполняем поле "название страны" названием той страны которую хотим редактировать
            ACF.CountryName = countryFinded.Name;
            //Удостоверяемся что пользователь нажал "ОК"
            if (ACF.ShowDialog() == DialogResult.OK)
            {
                //Проверяем, что такая запись есть в базе
                if(countryFinded!=null)
                {
                    //Изменяем название редактируемой страны на ту которую ввел пользователь
                    countryFinded.Name = ACF.CountryName;
                    //Сохраняем данные
                    APC.SaveChanges();
                }
                //Обновляем интерфейс
                RefreshUI();
            }
        }

        /// <summary>
        /// Метод удаления страны
        /// </summary>
        /// <param name="id">Номер страны из базы для удаления</param>
        void DeleteCountry(int id)
        {
            //Находим страну для удаления в базе по айди
            var countryFinded = APC.Countries.Where(c => c.ID == id).FirstOrDefault();
            //Проверяем, что такая запись есть в базе
            if (countryFinded != null)
            {
                //Проверяем не привязаны ли записи к удаляемому объекту
                if(APC.Products.Where(c=>c.CountryID == id).Count() <= 0)
                { 
                //Удаляем запись из БД
                APC.Countries.Remove(countryFinded);
                //Сохраняем изменения
                APC.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити країну. \nНа складі є замовлення з нею", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            //Обнавляем интерфейс
            RefreshUI();
        }
        #endregion
        #region Управление Продуктами
        void AddProduct(int id = 0)
        {
            AddProduct AP = new AddProduct();
            AP.cb_country.DataSource = new BindingSource(APC.Countries.ToList(), null);
            AP.cb_country.DisplayMember = "Name";
            AP.cb_country.ValueMember = "ID";
            AP.cb_country.SelectedIndex = -1;
            if (AP.ShowDialog() == DialogResult.OK)
            {
                APC.Products.Add(new Product() { CountryID = AP.CountryID, Count = AP.Count, Name = AP.ProdName, Price = AP.Price, Year = new DateTime(AP.Year, 1,1) });
                APC.SaveChanges();
                RefreshUI();
            }
        }

        void ChangeProduct(int id = 0)
        {
            Product changeProduct = APC.Products.Where(c => c.ID == id).FirstOrDefault();
            AddProduct AP = new AddProduct();
            AP.cb_country.DataSource = new BindingSource(APC.Countries.ToList(), null);
            AP.cb_country.DisplayMember = "Name";
            AP.cb_country.ValueMember = "ID";
            AP.cb_country.SelectedValue = changeProduct.CountryID;
            AP.Price = changeProduct.Price;
            AP.Count = changeProduct.Count;
            AP.ProdName = changeProduct.Name;
            AP.Year = changeProduct.Year.Year;
            if (AP.ShowDialog() == DialogResult.OK)
            {
                changeProduct.Count = AP.Count;
                changeProduct.CountryID = (int)AP.cb_country.SelectedValue;
                changeProduct.Price = AP.Price;
                changeProduct.Name = AP.ProdName;
                changeProduct.Year = new DateTime(AP.Year, 1, 1);
                APC.SaveChanges();
                RefreshUI();
            }
        }
        void deleteProduct(int id = 0)
        {
            Product deleteProduct = APC.Products.Where(c => c.ID == id).FirstOrDefault();
            if (deleteProduct != null)
            {
                //Проверяем не привязаны ли записи к удаляемому объекту
                if (APC.CheckLists.Where(c => c.ProductID == id).Count() <= 0)
                {
                    APC.Products.Remove(deleteProduct);
                    APC.SaveChanges();
                    RefreshUI();
                }
                else
                {
                    MessageBox.Show("Неможливо видалити продукт, \nтак як він фігурує у заказах", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        /// <summary>
        /// Метод вызывающий другие методы в зависимости от открытой вкладки
        /// </summary>
        /// <param name="client">Метод который вызывается если октрыта вкладка клиенты</param>
        /// <param name="prod">Метод который вызывается если октрыта вкладка товары</param>
        /// <param name="order">Метод который вызывается если октрыта вкладка заказы</param>
        /// <param name="country">Метод который вызывается если октрыта вкладка страны</param>
        void ChoiseTabControl(MyMethDel client, MyMethDel prod, MyMethDel order, MyMethDel country)
        {
            //узнаем название открытой страницы
            switch (tabControl1.SelectedTab.Name)
            {
                //В зависимости от страницы вызываем метод который соответствует этой странице
                case "TP_Clients":
                    client?.Invoke(Convert.ToInt32(DGV_Client.CurrentRow?.Cells["cl_id"].Value));
                    break;
                case "TP_Auto":
                    prod?.Invoke(Convert.ToInt32(DGV_product.CurrentRow?.Cells["pr_ID"].Value));
                    break;
                case "TP_Order":
                    order?.Invoke(0);
                    break;
                case "TP_Country":
                    country?.Invoke(Convert.ToInt32(DGV_country.CurrentRow?.Cells["ID"].Value));
                    break;
            }
        }

        //Событие нажатие кнопки "добавить"
        private void button1_Click(object sender, EventArgs e)
        {
            //Определяем вкладку и передаем методы для вызова
            ChoiseTabControl(AddClent, AddProduct, null, AddCountry);
        }
        //Событие нажатие кнопки "изменить"
        private void button2_Click(object sender, EventArgs e)
        {
            //Определяем вкладку и передаем методы для вызова
            ChoiseTabControl(ChangeClent, ChangeProduct, null, ChangeCountry);
        }

        //Событие нажатие кнопки "удалить"
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Определяем вкладку и передаем методы для вызова
            ChoiseTabControl(DeleteClent, deleteProduct, null, DeleteCountry);
        }

        //Кнопка поиска клиента по фамилии
        private void btn_cl_find_Click(object sender, EventArgs e)
        {
            //Запрос поиска
            DGV_Client.DataSource = APC.Clients.ToList().Where(c=>c.Family.Contains(tb_cl_fam_find.Text)).ToList();
        }

        //Поиск клиента при нажатии энтр в текстовом поле
        private void tb_cl_fam_find_KeyDown(object sender, KeyEventArgs e)
        {
            //проверяем что нажата энтр
            if(e.KeyCode == Keys.Enter)
            {
                //вызываем нажатие кнопки поиск
                btn_cl_find_Click(this, new EventArgs());
            }
        }

        //Кнопка сброса поиска клиента
        private void btn_cancel_filter_Click(object sender, EventArgs e)
        {
            tb_cl_fam_find.Text = string.Empty;
            RefreshUI();
        }

        //Кнопка сброса поиска продуктов
        private void btn_cancel_find_product_Click(object sender, EventArgs e)
        {
            RefreshUI();
            cb_country.SelectedIndex = -1;
        }

        //Поиск продуктов при нажатии энтр
        private void cb_country_KeyDown(object sender, KeyEventArgs e)
        {
            //проверяем что нажата энтр
            if (e.KeyCode == Keys.Enter)
            {
                //вызываем нажатие кнопки поиск
                button1_Click_1(this, new EventArgs());
            }
        }
            
        //кнопка поиска продуктов по стране
        private void button1_Click_1(object sender, EventArgs e)
        {
            //запрос поиска
            //DGV_product.DataSource = APC.Products.ToList().Where(c => c.CountryID == (int)cb_country.SelectedValue).ToList();
            DGV_product.DataSource = (from w in APC.Products.ToList()
                                      where w.CountryID == (int)cb_country.SelectedValue
                                      select new ProductView()
                                      {
                                          Count = w.Count,
                                          Country = w.Country,
                                          CountryID = w.CountryID,
                                          ID = w.ID,
                                          Name = w.Name,
                                          Price = w.Price,
                                          Year = w.Year
                                      }).ToList();
        }

        /// <summary>
        /// Событие выбора заказа в таблице заказов
        /// Заполняет список товаров в заказе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_order_SelectionChanged(object sender, EventArgs e)
        {
            //Получаем айди выбраного заказа
            int id = Convert.ToInt32(DGV_order.CurrentRow?.Cells["or_ID"].Value);
            //Заполняем таблицу товарами из выбранного заказа
            DGV_checkList.DataSource = (from q in APC.CheckLists.ToList()
                                        where q.OrderID == id
                                        select new CheckListView()
                                        {
                                            Count = q.Count,
                                            OrderID = q.OrderID,
                                            ID = q.ID,
                                            Order = q.Order,
                                            Product = q.Product,
                                            ProductID = q.ProductID
                                        }).ToList();
        }

        /// <summary>
        /// Событие кнопки поиска заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            //В этом блоке используются LINQ выражения и модели для отоброжения полных данных

            //Переменная для хранения айди заказа для поиска
            int id = 0;
            //Искать по айди если айди ввели в поле и поиск по дате не активен
            if (int.TryParse(tb_orderID.Text, out id) && cb1.Checked == false)
            {
                DGV_order.DataSource = (from a in APC.Orders.ToList()
                                        where a.ID.ToString().StartsWith(id.ToString())
                                        select new OrderView
                                        {
                                            CheckLists = a.CheckLists,
                                            Client = a.Client,
                                            ClientID = a.ClientID,
                                            Date = a.Date,
                                            ID = a.ID
                                        }).ToList();
            }
            //Сбросить поиск если поле айди пустое и поиск по дате не активен
            else if (int.TryParse(tb_orderID.Text, out id) == false && cb1.Checked == false)
            {
                RefreshUI();
            }
            //Искать по дате если полей айди пустое а поле даты активное
            else if (int.TryParse(tb_orderID.Text, out id) == false && cb1.Checked == true)
            {
                DGV_order.DataSource = (from a in APC.Orders.ToList()
                                        where a.Date.Date == dateTimePicker1.Value.Date
                                        select new OrderView
                                        {
                                            CheckLists = a.CheckLists,
                                            Client = a.Client,
                                            ClientID = a.ClientID,
                                            Date = a.Date,
                                            ID = a.ID
                                        }).ToList();
            }
            //искть и по дате и по айди, если оба поле активны и заполнены
            else if (int.TryParse(tb_orderID.Text, out id) == true && cb1.Checked == true)
            {
                DGV_order.DataSource = (from a in APC.Orders.ToList()
                                        where a.Date.Date == dateTimePicker1.Value.Date
                                        where a.ID.ToString().StartsWith(id.ToString())
                                        select new OrderView
                                        {
                                            CheckLists = a.CheckLists,
                                            Client = a.Client,
                                            ClientID = a.ClientID,
                                            Date = a.Date,
                                            ID = a.ID
                                        }).ToList();
            }
        }

        /// <summary>
        /// Событие кнопки сбоса поиска заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            tb_orderID.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now.Date;
            cb1.Checked = false;
            RefreshUI();
        }

        /// <summary>
        /// чек бокс использования фильра по дате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = cb1.Checked;
        }

        /// <summary>
        /// рлимк по нажатию "энтр" в поле айди заказа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_orderID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click_1(sender, new EventArgs());
            }
        }

        /// <summary>
        /// Поиск по нажатию "энтр" в поле поиск по дате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click_1(sender, new EventArgs());
            }
        }
    }
}
