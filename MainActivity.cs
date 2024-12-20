<<<<<<< Updated upstream
﻿using RestaurantManagementSystem.View;
using System;
=======
<<<<<<< HEAD
<<<<<<< HEAD
﻿using RestaurantManagementSystem.View;
using System;
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

namespace RestaurantManagementSystem
{
    public partial class MainActivity : Form
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> Stashed changes
        static MainActivity _obj;
        public static MainActivity Instance
        {
            get { if ( _obj == null )
                { _obj = new MainActivity(); }
                return _obj; }
            
        }

<<<<<<< Updated upstream
=======
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
        public MainActivity()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            AddControls(new MainActivity());
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            AddControls(new viewCategory());
=======
<<<<<<< HEAD
<<<<<<< HEAD
            AddControls(new viewCategory());
=======
            
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======
            
>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            AddControls(new viewProducts());
=======
<<<<<<< HEAD
<<<<<<< HEAD
            AddControls(new viewProducts());
=======

>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======

>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
        }

        private void IngredientsBtn_Click(object sender, EventArgs e)
        {

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            AddControls(new viewStaff());
=======
<<<<<<< HEAD
<<<<<<< HEAD
            AddControls(new viewStaff());
=======

>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======

>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            AddControls(new viewProducts());
=======
<<<<<<< HEAD
<<<<<<< HEAD
            AddControls(new viewProducts());
=======

>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
=======

>>>>>>> 91ac2195517ac37bc37bfb9770171067f3cb0b69
>>>>>>> Stashed changes
        }
    }
}
