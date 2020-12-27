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
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            DBConnection.GetUserList();
            dataGridView1.DataSource = DBConnection.dtUsers;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = null;
            switch (comboBox1.SelectedIndex)
            {
                case 1:
                    selectedRole = "Администратор";
                    break;
                case 2:
                    selectedRole = "Пользователь";
                    break;
            }
            DBConnection.GetUserList(selectedRole);
        }
    }
}
