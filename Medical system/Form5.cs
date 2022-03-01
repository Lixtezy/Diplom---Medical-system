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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet5.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter2.Fill(this.mISDataSet5.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet4.Patient". При необходимости она может быть перемещена или удалена.
            //this.patientTableAdapter1.Fill(this.mISDataSet4.Patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet2.Patient". При необходимости она может быть перемещена или удалена.
            //this.patientTableAdapter.Fill(this.mISDataSet2.Patient);

        }

        private void Сancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((PatSel.Text.Equals("")) || (DateOfAnalysis.Text.Equals("")))
                MessageBox.Show("Введите все обязательные данные в поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                string connectionString = @"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO ObshiyAnalizyKrovi (SNILS, HGB, RBC, MCV, MCH, MCHC, HCT, RDW_CV, RDW_SD, PLT, MPV, P_LCR, PDW, PCT, WBC) " +
                    "VALUES (@SNILS, @HGB, @RBC, @MCV, @MCH, @MCHC, @HCT, @RDW_CV, @RDW_SD, @PLT, @MPV, @P_LCR, @PDW, @PCT, @WBC)", connection);
                    command.Parameters.AddWithValue("@SNILS", PatSel.Text);
                    command.Parameters.AddWithValue("@HGB", HGB.Text);
                    command.Parameters.AddWithValue("@RBC", RBC.Text);
                    command.Parameters.AddWithValue("@MCV", MCV.Text);
                    command.Parameters.AddWithValue("@MCH", MCH.Text);
                    command.Parameters.AddWithValue("@MCHC", MCHC.Text);
                    command.Parameters.AddWithValue("@HCT", HCT.Text);
                    command.Parameters.AddWithValue("@RDW_CV", RDW_CV.Text);
                    command.Parameters.AddWithValue("@RDW_SD", RDW_SD.Text);
                    command.Parameters.AddWithValue("@PLT", PLT.Text);
                    command.Parameters.AddWithValue("@MPV", MPV.Text);
                    command.Parameters.AddWithValue("@P_LCR", P_LCR.Text);
                    command.Parameters.AddWithValue("@PDW", PDW.Text);
                    command.Parameters.AddWithValue("@PCT", PCT.Text);
                    command.Parameters.AddWithValue("@WBC", WBC.Text);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand("INSERT INTO AnalizeType (SNILS, AnalysisType, DateOfAnalysis) " +
                //    "VALUES (@SNILS, @AnalysisType, @DateOfAnalysis)", connection);
                //    command.Parameters.AddWithValue("@SNILS", PatSel.Text);
                //    command.Parameters.AddWithValue("@AnalysisType", AnalysisType.Text);
                //    command.Parameters.AddWithValue("@DateOfAnalysis", DateOfAnalysis.Text);
                //    command.Connection.Open();
                //    command.ExecuteNonQuery();
                //}
                Close();
            }            
        }

        public void Patient_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI";
            SqlDataAdapter adapter = new SqlDataAdapter();            
            adapter.SelectCommand = new SqlCommand(@"SELECT CONCAT_WS (' ', LastName, Name, MiddleName, DateOfBirth) as ФИО, SNILS FROM Patient", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);            
            PatSel.DataSource = table;
            PatSel.DisplayMember = "ФИО";
            conn.Open();

        }

        private void SNILS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientTableAdapter2.FillBy(this.mISDataSet5.Patient);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
