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
    public partial class ProductToOrder : Form
    {
        public int Count { get { return (int)numericUpDown1.Value; } set { numericUpDown1.Value = (int)value; } }

        public ProductToOrder()
        {
            InitializeComponent();
        }
    }
}
