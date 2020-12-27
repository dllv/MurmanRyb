using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MurmanRyb
{
    class DBConnection
    {
        static string connectionString = @"Database = murmanryb_db; Data Source = localhost;
                                                UserID = root; Password = password";
        static MySqlConnection msConnect;
        static MySqlCommand msCommand;
        static public MySqlDataAdapter msDataAdapter;
        static public DataTable dtUsers = new DataTable();
        static public DataTable dtCustomers = new DataTable();

        public static string User;
        public static string Role;

        static public bool Connect()
        {
            try
            {
                msConnect = new MySqlConnection(connectionString); msConnect.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = msConnect;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
                return false;
            }
        }

        static public void Close()
        {
            msConnect.Close();
        }

        static public void Authorization(string login, string password)
        {
            try
            {
                string sql = "SELECT Role FROM Users WHERE Login = '" + login
                    + "' AND Password = '" + password + "' ;";

                msCommand = new MySqlCommand(sql, msConnect);
                Object result = msCommand.ExecuteScalar();
                if (result != null)
                {
                    Role = result.ToString();
                    User = login;
                }
                else
                {
                    Role = null;
                }
            }
            catch (Exception ex)
            {
                Role = User = null;
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "Ошибка!");
            }
        }

        static public void GetUserList(string selectedRole = null)
        {
            if (selectedRole == null)
                msCommand.CommandText = "SELECT * FROM Users";

            else msCommand.CommandText = "SELECT * FROM Users WHERE Users.Role='" +
                    selectedRole + "'";
                
            dtUsers.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtUsers);
        }

        static public void GetCustomerList()
        {
            msCommand.CommandText = "SELECT * FROM Customers";
            dtCustomers.Clear();
            msDataAdapter.SelectCommand = msCommand;
            msDataAdapter.Fill(dtCustomers);
        }

        static public bool AddUser(string login, string password, string role)
        {
            msCommand.CommandText = "INSERT INTO users VALUES('" + login + "','" + password + "','" + role + "');";
            if (msCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }

        static public void AddCustomer(string user, string name, string telephone, string adress, string email = null)
        {
            msCommand.CommandText = "INSERT INTO customers VALUES('"
                + user + "','" + name + "','" + telephone + "','"
                + email + "','" + adress + "');";
            msCommand.ExecuteNonQuery();
        }
    }
}