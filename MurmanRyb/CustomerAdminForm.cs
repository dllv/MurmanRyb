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
    public partial class CustomerAdminForm : Form
    {
        public CustomerAdminForm()
        {
            InitializeComponent();
        }

        private void CustomerAdminForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetCustomerList();
            dataGridView1.DataSource = DBConnection.dtCustomers;
        }
    }
}
