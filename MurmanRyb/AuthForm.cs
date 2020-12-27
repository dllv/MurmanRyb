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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            if (!DBConnection.Connect()) Close();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            DBConnection.Authorization(loginTextBox.Text, passwordTextBox.Text);

            switch (DBConnection.Role)
            {
                case null:
                    MessageBox.Show("Неверные данные!");
                    break;
                case "Пользователь":
                    Hide();
                    new CustomerForm() { ReturnForm = this }.Show();
                    break;
                case "Администратор":
                    Hide();
                    new AdminForm() { ReturnForm = this }.Show();
                    break;
            }
        }
    }
}
