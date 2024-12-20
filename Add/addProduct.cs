using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem.Add
{
    public partial class addProduct : sampleAdd
    {
        public addProduct()
        {
            InitializeComponent();
        }

        public int id = 0;
        public int cID = 0;

        private void addProduct_Load(object sender, EventArgs e)
        {
            // ComboBox Fill
            string qry = "SELECT catID AS id, catName AS name FROM category";
            connectDB.CBFill(qry, roleDrop);

            if (cID > 0)
            {
                roleDrop.SelectedValue = cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";

            try
            {
                if (id == 0)
                {
                    qry = "INSERT INTO products (pName, pPrice, CategoryID) VALUES (@Name, @price, @cat)";
                }
                else
                {
                    qry = "UPDATE products SET pName = @Name, pPrice = @price, CategoryID = @cat WHERE pID = @id";
                }

                Hashtable ht = new Hashtable
                {
                    { "@id", id },
                    { "@Name", nametxtbox.Text },
                    { "@price", pricetxtbox.Text },
                    { "@cat", Convert.ToInt32(roleDrop.SelectedValue) }
                };

                if (connectDB.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Saved Successfully.");
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = "SELECT * FROM products WHERE pID = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(qry, connectDB.conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            nametxtbox.Text = dt.Rows[0]["pName"].ToString();
                            pricetxtbox.Text = dt.Rows[0]["pPrice"].ToString();
                            roleDrop.SelectedValue = dt.Rows[0]["CategoryID"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product data: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            id = 0;
            cID = 0;
            nametxtbox.Text = "";
            pricetxtbox.Text = "";
            roleDrop.SelectedIndex = -1;
            nametxtbox.Focus();
        }

        public override void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
