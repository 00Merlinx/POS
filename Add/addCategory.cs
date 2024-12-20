using System;
<<<<<<< HEAD
using System.Collections;
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
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
    public partial class addCategory : sampleAdd
    {
        public addCategory()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public int id = 0;

        public override void saveBtn_Click(object sender, EventArgs e)
        {
            string qry = "";
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", bunifuTextBox1.Text);

            try
            {
                if (id == 0)
                {
                    qry = "INSERT INTO category VALUES (@Name)";
                }
                else
                {
                    qry = "UPDATE category SET catName = @Name WHERE catID = @id";
                }

                if (connectDB.SQL(qry, ht) > 0)
                {
                    MessageBox.Show("Saved Successfully.");
                    id = 0;
                    bunifuTextBox1.Text = "";
                    bunifuTextBox1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public override void sampleAdd_Load(object sender, EventArgs e)
=======
        public virtual void saveBtn_Click(object sender, EventArgs e)
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
        {

        }

<<<<<<< HEAD
        public override void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void addCategory_Load(object sender, EventArgs e)
        {

        }
=======
        public virtual void sampleAdd_Load(object sender, EventArgs e)
        {

        }

        public virtual void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
    }
}
