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

namespace RestaurantManagementSystem.Add
{
    public partial class addStaff : sampleAdd
    {
        public addStaff()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void addStaff_Load(object sender, EventArgs e)
        {

        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";


            try
            {
                if (id == 0)
                {
                    qry = "INSERT INTO staff VALUES (@Name, @phone, @role)";
                }
                else
                {
                    qry = "UPDATE category SET sName = @Name, sPhone = @phone, sRole = @role WHERE staffID = @id";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", nametxtbox.Text);
                ht.Add("@phone", phonetxtbox.Text);
                ht.Add("@role", roleDrop.Text);

                if (connectDB.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Saved Successfully.");
                    id = 0;
                    nametxtbox.Text = "";
                    phonetxtbox.Text = "";
                    roleDrop.SelectedIndex = -1;
                    nametxtbox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public override void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
