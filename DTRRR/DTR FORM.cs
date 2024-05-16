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
    public partial class DTR_FORM : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3307;User Id=root;password='Heisenberg251251'");
        MySqlConnection connection;
        MySqlCommand command;
        
        

        public DTR_FORM()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
               
                string connectionString = "server=localhost;port=3307;database=phpmyadmin;user=root;password=Heisenberg251251;"; ;
                connection = new MySqlConnection(connectionString);
                command = connection.CreateCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database connection: " + ex.Message);
            }
        }

        private void SaveTimeToMySQL(string time, string columnName)
        {
            
            string connectionString = "server=localhost;user=root;password=Heisenberg251251;database=phpmyadmin";
            string query = $"UPDATE phpmyadmin SET {columnName}='{time}' WHERE id={dataGridView1.CurrentCell.RowIndex + 1}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        public DTR_FORM(string employeeName, string employeeRole, string management, string employeeID)
        {
            InitializeComponent();

            EmployeeLabel.Text = employeeName;
            label12.Text = employeeRole;
            label13.Text = management;
            label14.Text = employeeID;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DTR_FORM_Load(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToShortDateString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeInButton_Click(object sender, EventArgs e)
        {
            
            DateTime timeIn = DateTime.Now;

          
            string formattedTimeIn = timeIn.ToString("yyyy-MM-dd HH:mm:ss");

            
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TIMEIN"].Value = formattedTimeIn;

            SaveTimeToMySQL(formattedTimeIn, "TimeIn");

        }

        private void TimeOutButton_Click(object sender, EventArgs e)
        {
            
            DateTime timeOut = DateTime.Now;

            
            string formattedTimeOut = timeOut.ToString("yyyy-MM-dd HH:mm:ss");

            
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["TIMEOUT"].Value = formattedTimeOut;

            SaveTimeToMySQL(formattedTimeOut, "TimeOut");

        }

        private void EmployeeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    
    }
}

