using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoParts
{
    /// <summary>
    /// Форма работы с клиентами
    /// </summary>
    public partial class AddClients : Form
    {
        //Инкапсуляция полей клиента в текстбоксы формы
        /// <summary>
        /// Имя
        /// </summary>
        public string NameClient { get { return tb_name.Text; } set { tb_name.Text = value; } }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Family { get { return tb_family.Text; } set { tb_family.Text = value; } }
        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get { return tb_lastname.Text; } set { tb_lastname.Text = value; } }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get { return tb_phone.Text; } set { tb_phone.Text = value; } }
        /// <summary>
        /// Эмейл
        /// </summary>
        public string Email { get { return tb_email.Text; } set { tb_email.Text = value; } }
        public AddClients()
        {
            InitializeComponent();
        }
    }
}
