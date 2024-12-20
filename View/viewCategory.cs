<<<<<<< Updated upstream
﻿using RestaurantManagementSystem.Add;
using System;
using System.Collections;
=======
<<<<<<< HEAD
<<<<<<< HEAD
﻿using RestaurantManagementSystem.Add;
using System;
using System.Collections;
=======
﻿using System;
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======
﻿using System;
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
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
    public partial class viewCategory : sampleView
    {
        public viewCategory()
        {
            InitializeComponent();
        }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> Stashed changes
        //Get Data 
        public void GetData()
        {
            string qry = "SELECT * FROM category where catName like '%" + searchbox.Text + "%' ";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            connectDB.LoadData(qry, bunifuDataGridView1, lb);
<<<<<<< Updated upstream
=======
=======
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
        public override void addBtn_Click_1(object sender, EventArgs e)
        {

        }

        public override void searchbox_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes

        }

        public override void viewLabel_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> Stashed changes

        private void viewCategory_Load(object sender, EventArgs e)
        {
            GetData();
        }
        public override void addBtn_Click_1(object sender, EventArgs e)
        {
            addCategory frm = new addCategory();
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
                    addCategory frm = new addCategory();
                    frm.id = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    frm.bunifuTextBox1.Text = bunifuDataGridView1.CurrentRow.Cells["dgvName"].Value != DBNull.Value
                        ? Convert.ToString(bunifuDataGridView1.CurrentRow.Cells["dgvName"].Value)
                        : string.Empty;
                    frm.ShowDialog();
                    GetData();
                }
                else if (bunifuDataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
                {
                    int id = Convert.ToInt32(bunifuDataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "DELETE FROM category WHERE catID = @id";
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


<<<<<<< Updated upstream
=======
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
    }
}
