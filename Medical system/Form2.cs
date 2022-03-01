using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_system
{
    public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 taskWindow = new Form1();
            SqlConnection conn = new SqlConnection(@"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI");
            SqlCommand command = new SqlCommand("SELECT Login, Password, LaNaMi, DocSpec FROM [User] WHERE Login = @Login AND Password = @Password", conn);
            conn.Open();
            command.Parameters.AddWithValue("@Login", Login.Text);
            command.Parameters.AddWithValue("@Password", Password.Text);            
            SqlDataReader reader = command.ExecuteReader();
            
            if (reader.HasRows == true)
            {
                while (reader.Read())
                {
                    taskWindow.avtor_fio.Text = reader.GetValue(2).ToString();
                    taskWindow.label131.Text = reader.GetValue(3).ToString();
                }
                                
                conn.Close();              
                taskWindow.Show();
                Hide();                             
            }            
            else
            {
                MessageBox.Show("Неправильный логин или пароль.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
