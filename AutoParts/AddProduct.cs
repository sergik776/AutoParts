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
    public partial class AddProduct : Form
    {
        public int CountryID { get { return (int)cb_country.SelectedValue; } set { cb_country.SelectedValue = value; } }
        public string ProdName { get { return tb_name.Text; } set { tb_name.Text = value; } }
        public int Year { get { return Convert.ToInt32(tb_year.Text); } set { tb_year.Text = value.ToString(); } }
        public double Price { get { return (double)num_price.Value; } set { num_price.Value = (decimal)value; } }
        public int Count { get { return (int)num_count.Value; } set { num_count.Value = (int)value; } }

        public AddProduct()
        {
            InitializeComponent();
            num_price.Maximum = 1000000;
            num_count.Maximum = 1000000;
        }

        int Country()
        {
            return 0;
        }
    }
}
