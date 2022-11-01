using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace reserv
{
    public partial class Form1 : Form
    {
        string username;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text;
            string pwd = pwdField.Text;
            string query = "SELECT username from login where username=@username and password=@password";
            Database.con.Open();
            SqlCommand cmd = new SqlCommand(query, Database.con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", pwd);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
              
                new Form2(username).Show();

            }
            else
            {
                MessageBox.Show("Login ou mot de passe incorrect");

            }


            Database.con.Close();
            reader.Close();
        }
    }
}