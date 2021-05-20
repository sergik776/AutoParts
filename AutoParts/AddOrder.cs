using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoParts.DAL.Entityes;

namespace AutoParts
{
    public partial class AddOrder : Form
    {
        public BindingList<CheckList> CheckLists;
        public List<Product> Products;

        public AddOrder(List<Product> _Products)
        {
            InitializeComponent();
            CheckLists = new BindingList<CheckList>();
            DGV_checklist.DataSource = CheckLists;
            Products = _Products;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}
