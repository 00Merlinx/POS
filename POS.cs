using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using Bunifu.UI.WinForms;


namespace RestaurantManagementSystem
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            bunifuDataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
            bunifuPanel1.Controls.Clear(); 

        }

        private void AddCategory()
        {
            string qry = "select * from category";
            SqlCommand cmd = new SqlCommand(qry, connectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Bunifu.UI.WinForms.BunifuButton.BunifuButton b = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                    b.IdleFillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(184, 39);
                    b.OnIdleState.ForeColor = Color.White;
                    b.Text = row["catName"].ToString();
                    b.AllowToggling = true;
                    CategoryPanel.Controls.Add(b);
                }
            }
        }
        private void AddItems(int id, string name, string cat, string price)
        {
            var w = new ucProducts()
            {
                PName = name,
                PPrice = price,
                PCategory = cat,
                id = Convert.ToInt32(id)
            };
            bunifuPanel1.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProducts)ss;
                foreach (DataGridViewRow row in bunifuDataGridView1.Rows)
                {
                    //check if product already added and update price
                    if (Convert.ToInt32(row.Cells["dgvid"].Value) == wdg.id)
                    {
                        row.Cells["dgvQty"].Value = int.Parse(row.Cells["dgvQty"].Value.ToString()) + 1;
                        row.Cells["dgvAmount"].Value = int.Parse(row.Cells["dgvQty"].Value.ToString()) *
                        double.Parse(row.Cells["dgvPrice"].Value.ToString());
                    }
                    //add new product
                    bunifuDataGridView1.Rows.Add(new object[] { 0, wdg.id, wdg.PName, 1, wdg.PPrice });
                }
            };
        }

        //product in database
        private void LoadProducts()
        {
            string qry = "Select * from products inner join category on catID = CategoryID";
            SqlCommand cmd = new SqlCommand(qry, connectDB.conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                AddItems(Convert.ToInt32(item["pID"]), item["pName"].ToString(), item["catName"].ToString(), Convert.ToString(item["pPrice"]));
            }
        }

    }
}
