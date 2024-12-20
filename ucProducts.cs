using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
   
    public partial class ucProducts : UserControl
    {
        public ucProducts()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect;
        public int id { get; set; }
        public string PPrice { get; set; }
        public string PCategory { get; set; }

        public string PName
        {
            get { return ProductName.Text; }
            set { ProductName.Text = value; }
        }
    }
}
