using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsGenius
{
    public partial class frmInteraction : Form
    {
        public frmInteraction()
        {
            InitializeComponent();
        }

        private void frmInteraction_Load(object sender, EventArgs e)
        {
            lblWellDone.Text = user2.username; //load page displays user logged in username
        }
        //to go back to menu so user can have more than one shot
        private void lblGoBack_Click(object sender, EventArgs e)
        {
            this.Hide(); //hides this form
            frmMenu menu = new frmMenu(); //creates a new instance of menu
            menu.Show(); //displays menu
        }
    }
}
