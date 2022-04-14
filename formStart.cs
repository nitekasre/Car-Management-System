using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6_2
{
    public partial class formStart : Form
    {
        public formStart()
        {
            InitializeComponent();
        }

        private void formMenu_Click(object sender, EventArgs e)
        {
            //creates an instance of the CRUD form to be called for opening nad hides the start form
            formCRUD mainForm = new formCRUD();
            mainForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }
    }
}
