using RestaurantManagementSystem.Add;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.View
{
    public partial class viewProducts : sampleView
    {
        public viewProducts()
        {
            InitializeComponent();
        }

        private void viewProducts_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qry = "select pId, pName, pPrice, CategoryID, c.catName from products p inner join category c on c.catID = p.CategoryID where pName like '%" + searchbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);

            connectDB.LoadData(qry, bunifuDataGridView1, lb);

        }

        public override void addBtn_Click_1(object sender, EventArgs e)
        {
            addProduct frm = new addProduct();
            frm.ShowDialog();
            GetData();
        }
        public override void searchbox_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bunifuDataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
                {
                    addProduct frm = new addProduct();
                    frm.id = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    frm.cID = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvcatID"].Value);
                    

                    frm.ShowDialog();
                    GetData();
                }
                else if (bunifuDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    int id = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "DELETE FROM products WHERE pID = "+ id +"";
                    Hashtable ht = new Hashtable();
                    ht.Add("@id", id);

                    connectDB.SQL(qry, ht);

                    MessageBox.Show("Deleted Successfully");
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
