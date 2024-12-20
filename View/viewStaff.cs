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
    public partial class viewStaff : sampleView
    {
        public viewStaff()
        {
            InitializeComponent();
        }

        private void viewStaff_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public void GetData()
        {
            string qry = "SELECT * FROM staff where sName like '%" + searchbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvRole);

            connectDB.LoadData(qry, bunifuDataGridView1, lb);

        }

        public override void addBtn_Click_1(object sender, EventArgs e)
        {
            addStaff frm = new addStaff();
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
                    addStaff frm = new addStaff();
                    frm.id = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    frm.nametxtbox.Text = Convert.ToString(bunifuDataGridView1.CurrentRow.Cells["dgvName"].Value);
                    frm.phonetxtbox.Text = Convert.ToString(bunifuDataGridView1.CurrentRow.Cells["dgvPhone"].Value);
                    frm.roleDrop.Text = Convert.ToString(bunifuDataGridView1.CurrentRow.Cells["dgvRole"].Value);

                    frm.ShowDialog();
                    GetData();
                }
                else if (bunifuDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    int id = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "DELETE FROM staff WHERE staffID = @id";
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
