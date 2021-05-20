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
    /// Форма работы с странами
    /// </summary>
    public partial class FormAddCountry : Form
    {
        /// <summary>
        /// Название страны инкапсулируется в текстбокс
        /// </summary>
        public string CountryName { get { return tb_country.Text; }  set { tb_country.Text = value; } }
        public FormAddCountry()
        {
            InitializeComponent();
        }
    }
}
