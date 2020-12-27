using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurmanRyb
{
    public partial class CustomerForm : Form
    {
        public Form ReturnForm;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DBConnection.Role = null;
            ReturnForm.Show();
            this.Close();
        }
    }
}
