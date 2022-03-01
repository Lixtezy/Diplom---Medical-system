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
using System.Configuration;

namespace Medical_system
{
    public partial class AddPatient : Form
    {
                

        public AddPatient()
        {
            InitializeComponent();           
        }

      
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet.ICD10". При необходимости она может быть перемещена или удалена.
            this.iCD10TableAdapter.Fill(this.mISDataSet.ICD10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((d_Name.Text.Equals("")) || (LastName.Text.Equals("")) || (Gender.Text.Equals("")) || (DateOfBirth.Text.Equals("")) || (SNILS.Text.Equals("")) || (PolisNum.Text.Equals("")) || (NamePolis.Text.Equals("")) || (Сountry.Text.Equals("")) || (City.Text.Equals("")) || (Street.Text.Equals("")) || (House.Text.Equals("")) || (Apartment.Text.Equals("")) || (ICD10.Text.Equals("")))
                MessageBox.Show("Введите все обязательные данные в поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else 
            { 
                string connectionString = @"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {                
                    SqlCommand command = new SqlCommand("INSERT INTO Patient (Name, LastName, MiddleName, Gender, DateOfBirth, Phone, PWork, SNILS, MedicalHistory, PolisNum, NamePolis, Сountry, District, City, Street, House, Apartment, MainDisease, ICD10) " +
                    "VALUES (@Name, @LastName, @MiddleName, @Gender, @DateOfBirth, @Phone, @PWork, @SNILS, @MedicalHistory, @PolisNum, @NamePolis, @Сountry, @District, @City, @Street, @House, @Apartment, @MainDisease, @ICD10)", connection);
                    command.Parameters.AddWithValue("@Name", d_Name.Text);
                    command.Parameters.AddWithValue("@LastName", LastName.Text);
                    command.Parameters.AddWithValue("@MiddleName", MidName.Text);
                    command.Parameters.AddWithValue("@Gender", Gender.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.Text);
                    command.Parameters.AddWithValue("@Phone", Phone.Text);
                    command.Parameters.AddWithValue("@PWork", Work.Text);
                    command.Parameters.AddWithValue("@SNILS", SNILS.Text);
                    command.Parameters.AddWithValue("@MedicalHistory", DiseaseHistory.Text);                    
                    command.Parameters.AddWithValue("@PolisNum", PolisNum.Text);
                    command.Parameters.AddWithValue("@NamePolis", NamePolis.Text);
                    command.Parameters.AddWithValue("@Сountry", Сountry.Text);
                    command.Parameters.AddWithValue("@District", District.Text);
                    command.Parameters.AddWithValue("@City", City.Text);
                    command.Parameters.AddWithValue("@Street", Street.Text);
                    command.Parameters.AddWithValue("@House", House.Text);
                    command.Parameters.AddWithValue("@Apartment", Apartment.Text);
                    command.Parameters.AddWithValue("@MainDisease", MainDisease.Text);
                    command.Parameters.AddWithValue("@ICD10", ICD10.Text);
                    command.Connection.Open();                
                    command.ExecuteNonQuery();                    
                }                
                Close();
            }            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SNILS_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MidName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void Work_TextChanged(object sender, EventArgs e)
        {

        }

        private void RecDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DiseaseHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ICD10_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SNILS_KeyPress(object sender, KeyPressEventArgs e)
        {     
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.') //буквы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.') //буквы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void MidName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.') //буквы и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; //отсутствие ввода символов
        }

        private void ICD10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
