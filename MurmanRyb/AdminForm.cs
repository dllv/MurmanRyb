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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public Form ReturnForm;

        private void exitButton_Click(object sender, EventArgs e)
        {
            DBConnection.Role = null;
            ReturnForm.Show();
            this.Close();
        }

        private void userListButton_Click(object sender, EventArgs e)
        {
            UserListForm userListForm = new UserListForm();
            userListForm.Show();
        }

        private void customerListButton_Click(object sender, EventArgs e)
        {
            CustomerAdminForm customerAdminForm = new CustomerAdminForm();
            customerAdminForm.Show();
        }
    }
}
