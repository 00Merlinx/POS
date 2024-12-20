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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            {
                Registration reg = new Registration();
                reg.Show();
                this.Hide();
            }
        }
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> Stashed changes

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            {
                POS reg = new POS();
                reg.Show();
                this.Hide();
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
