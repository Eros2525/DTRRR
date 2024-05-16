using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;


namespace DTRRR
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3307;User Id=root;password='Heisenberg251251'");
        int i;
        public Form1()
        {
            InitializeComponent();

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ("server=localhost;user=root;database=payrollrate1;port=3307;password='Heisenberg251251'");
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT EmployeeName, EmployeeRole, Management, EmployeeID FROM phpmyadmin.payrollrate WHERE EmployeeName = @employeeName AND password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeename", UserBox.Text);
                    command.Parameters.AddWithValue("@Password", PassWordBox.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string employeeName = reader["EmployeeName"].ToString();
                            string employeeRole = reader["EmployeeRole"].ToString();
                            string management = reader["Management"].ToString();
                            string employeeID = reader["EmployeeID"].ToString();


                            DTR_FORM dtrForm = new DTR_FORM(employeeName, employeeRole, management, employeeID);
                            dtrForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private static void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private static void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private static void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

