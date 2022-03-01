using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;
using Panel = System.Windows.Forms.Panel;
using Word = Microsoft.Office.Interop.Word;


namespace Medical_system
{
    public partial class Form1 : Form
    {
        private readonly string TemplateFileName = @"C:\Users\pro50\source\repos\Medical system\Templates\Шаблон приема ревматолога.doc";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet.ICD10". При необходимости она может быть перемещена или удалена.
            this.iCD10TableAdapter.Fill(this.mISDataSet.ICD10);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet4.ObshiyAnalizyKrovi". При необходимости она может быть перемещена или удалена.
            //this.obshiyAnalizyKroviTableAdapter.Fill(this.mISDataSet4.ObshiyAnalizyKrovi);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mISDataSet4.AnalizeType". При необходимости она может быть перемещена или удалена.
            this.analizeTypeTableAdapter.Fill(this.mISDataSet4.AnalizeType);
            GetData();
            prim_bolvsys.SelectedIndex = 0; //выбор индекса в комбобоксе по умолчанию
            //эпизод по дате            
            epizod.Text = DateTime.Now.ToShortDateString();


        }
        public class BorderedPanel : Panel
        {
            [DefaultValue(typeof(Color), "Black")]
            public Color BorderColor { get; set; }

            [DefaultValue(1)]
            public int BorderWidth { get; set; }

            public BorderedPanel()
            {
                BorderColor = Color.Black;
                BorderWidth = 1;
            }

            protected override void OnPaintBackground(PaintEventArgs e)
            {
                base.OnPaintBackground(e);

                var d = BorderWidth / 2;
                using (var pen = new Pen(BorderColor, BorderWidth))
                    e.Graphics.DrawRectangle(pen, d, d, Width - 2 * d - 1, Height - 2 * d - 1);
            }
        }
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            //прием пациента
            var LastName = prim_LastName.Text;
            var Name = prim_Name.Text;
            var MidName = prim_MidName.Text;
            var DateOfBirth = prim_DateOfBirth.Text;
            var id = prim_id.Text;
            var Сountry = prim_Сountry.Text;
            var District = prim_District.Text;
            var City = prim_City.Text;
            var Street = prim_Street.Text;
            var House = prim_House.Text;
            var Apartment = prim_Apartment.Text;
            var Work = prim_Work.Text;
            //жалобы
            var jalob = prim_jalob.Text; //есть ограничение на количество текста!!! надо снять как-то; возможно сначало подгружать в бд а потом из бд выводить в шаблон?
            var bolvsys = prim_bolvsys.Text;
            var oteksys = prim_oteksys.Text;
            var utrskov = prim_utrskov.Text;
            var povtemp = prim_povtemp.Text;
            var slab = prim_slab.Text;
            var izmmastel = prim_izmmastel.Text;
            var visnasliz = prim_visnasliz.Text;
            var syhkojslis = prim_syhkojslis.Text;
            var chyvstrykholod = prim_chyvstrykholod.Text;
            var zatrpriglot = prim_zatrpriglot.Text;
            //ревматологический статус
            var telosloj = prim_telosloj.Text;
            var ves = prim_ves.Text;
            var rost = prim_rost.Text;
            var indmasstela = prim_indmasstela.Text;
            var spovtela = prim_spovtela.Text;
            var porokoltkan = prim_porokoltkan.Text;
            var tynsyndr = prim_tynsyndr.Text;
            var vnesysproj = prim_vnesysproj.Text;
            var izmslisobol = prim_izmslisobol.Text;
            var gepatomealg = prim_gepatomealg.Text;
            var ytrenskov = prim_ytrenskov.Text;
            var chps = prim_chps.Text;
            var chbs = prim_chbs.Text;
            var deform = prim_deform.Text;
            var vash = prim_vash.Text;
            //анамнез жизни
            var revmzabrod = prim_revmzabrod.Text;
            var psorrods = prim_psorrods.Text;
            var onkpotrods = prim_onkpotrods.Text;
            var drygzabrods = prim_drygzabrods.Text;
            var workstat = prim_workstat.Text;
            var inval = prim_inval.Text;
            var invgr = prim_invgr.Text;
            var dinaminv = prim_dinaminv.Text;
            var pereosvinv = prim_pereosvinv.Text;
            var listnetryd = prim_listnetryd.Text;
            var bolnichdney = prim_bolnichdney.Text;
            var alerganamn = prim_alerganamn.Text;
            var grip = prim_grip.Text;
            var pnevmokok = prim_pnevmokok.Text;
            var korona = prim_korona.Text;
            var tyber = prim_tyber.Text;
            var venzab = prim_venzab.Text;
            var gepatit = prim_gepatit.Text;
            var malaria = prim_malaria.Text;
            var kleshi = prim_kleshi.Text;
            var vredprivich = prim_vredprivich.Text;
            var profvred = prim_profvred.Text;
            var bityslov = prim_bityslov.Text;
            var pitanie = prim_pitanie.Text;
            var dvigact = prim_dvigact.Text;
            //анамнез заболевания
            var anamnzabol = prim_anamnzabol.Text; //есть ограничение на количество текста!!! надо снять как-то;
            //общий осмотр
            var obhsost = prim_obhsost.Text;
            var temptela = prim_temptela.Text;
            var soznan = prim_soznan.Text;
            var kontact = prim_kontact.Text;
            var emoclab = prim_emoclab.Text;
            var prostrivrema = prim_prostrivrema.Text;
            var teloslojprav = prim_teloslojprav.Text;
            var kojpokr = prim_kojpokr.Text;
            var kojokrask = prim_kojokrask.Text;
            var tyrgor = prim_tyrgor.Text;
            var vlagtyrgor = prim_vlagtyrgor.Text;
            var vidslisobol = prim_vidslisobol.Text;
            var okrasvidslisobol = prim_okrasvidslisobol.Text;
            var kostmishrazv = prim_kostmishrazv.Text;
            var dvijvsyst = prim_dvijvsyst.Text;
            var zev = prim_zev.Text;
            var okraszev = prim_okraszev.Text;
            var mindal = prim_mindal.Text;
            var pereferlimf = prim_pereferlimf.Text;
            var oteki = prim_oteki.Text;
            var mestoteki = prim_mestoteki.Text;
            var molochjel = prim_molochjel.Text;
            var palpatormolochjel = prim_palpatormolochjel.Text;
            var shitovjel = prim_shitovjel.Text;
            var razmshitovjel = prim_razmshitovjel.Text;
            var chss = prim_chss.Text;
            var artdavl = prim_artdavl.Text;
            var patologpyls = prim_patologpyls.Text;
            var pulsbedr = prim_pulsbedr.Text;
            var shymbrahart = prim_shymbrahart.Text;
            var tonserdc = prim_tonserdc.Text;
            var shymserdc = prim_shymserdc.Text;
            var chislodih = prim_chislodih.Text;
            var grydform = prim_grydform.Text;
            var actdihmishc = prim_actdihmishc.Text;
            var distchrip = prim_distchrip.Text;
            var perkytor = prim_perkytor.Text;
            var dyhan = prim_dyhan.Text;
            var shymdyhan = prim_shymdyhan.Text;
            var jziknal = prim_jziknal.Text;
            var jivotpripalpac = prim_jivotpripalpac.Text;
            var glybpalpackish = prim_glybpalpackish.Text;
            var slepkish = prim_slepkish.Text;
            var poperobodkish = prim_poperobodkish.Text;
            var pechen = prim_pechen.Text;
            var krayreberdyg = prim_krayreberdyg.Text;
            var plotnkrayreberdyg = prim_plotnkrayreberdyg.Text;
            var poverhpecheni = prim_poverhpecheni.Text;
            var selezenk = prim_selezenk.Text;
            var simptpokolach = prim_simptpokolach.Text;
            var fiziologotprav = prim_fiziologotprav.Text;
            //представления о больном
            var predstavobolnom = prim_predstavobolnom.Text; //есть ограничение на количество текста!!! надо снять как-то; ConvertToInt32(ProductID.Text) возможно поможет?
            //план ведения
            var planobsledov = prim_planobsledov.Text; //есть ограничение на количество текста!!! надо снять как-то;
            var planlecheni = prim_planlecheni.Text; //есть ограничение на количество текста!!! надо снять как-то;

            //создается оболочка ворда
            var wordApp = new Word.Application();
            wordApp.Visible = false; //для того, чтобы не видеть как заполняется шаблон

            try
            {
                //передача в документ
                var wordDocument = wordApp.Documents.Open(TemplateFileName);

                //прием пациента
                ReplaceWordStub("{prim_LastName}", LastName, wordDocument);
                ReplaceWordStub("{prim_Name}", Name, wordDocument);
                ReplaceWordStub("{prim_MidName}", MidName, wordDocument);
                ReplaceWordStub("{prim_DateOfBirth}", DateOfBirth, wordDocument);
                ReplaceWordStub("{prim_id}", id, wordDocument);
                ReplaceWordStub("{prim_Сountry}", Сountry, wordDocument);
                ReplaceWordStub("{prim_District}", District, wordDocument);
                ReplaceWordStub("{prim_City}", City, wordDocument);
                ReplaceWordStub("{prim_Street}", Street, wordDocument);
                ReplaceWordStub("{prim_House}", House, wordDocument);
                ReplaceWordStub("{prim_Apartment}", Apartment, wordDocument);
                ReplaceWordStub("{prim_Work}", Work, wordDocument);
                //жалобы
                ReplaceWordStub("{prim_jalob}", jalob, wordDocument);
                ReplaceWordStub("{prim_bolvsys}", bolvsys, wordDocument);
                ReplaceWordStub("{prim_oteksys}", oteksys, wordDocument);
                ReplaceWordStub("{prim_utrskov}", utrskov, wordDocument);
                ReplaceWordStub("{prim_povtemp}", povtemp, wordDocument);
                ReplaceWordStub("{prim_slab}", slab, wordDocument);
                ReplaceWordStub("{prim_izmmastel}", izmmastel, wordDocument);
                ReplaceWordStub("{prim_visnasliz}", visnasliz, wordDocument);
                ReplaceWordStub("{prim_syhkojslis}", syhkojslis, wordDocument);
                ReplaceWordStub("{prim_chyvstrykholod}", chyvstrykholod, wordDocument);
                ReplaceWordStub("{prim_zatrpriglot}", zatrpriglot, wordDocument);
                //ревматологический статус
                ReplaceWordStub("{prim_telosloj}", telosloj, wordDocument);
                ReplaceWordStub("{prim_ves}", ves, wordDocument);
                ReplaceWordStub("{prim_rost}", rost, wordDocument);
                ReplaceWordStub("{prim_indmasstela}", indmasstela, wordDocument);
                ReplaceWordStub("{prim_spovtela}", spovtela, wordDocument);
                ReplaceWordStub("{prim_porokoltkan}", porokoltkan, wordDocument);
                ReplaceWordStub("{prim_tynsyndr}", tynsyndr, wordDocument);
                ReplaceWordStub("{prim_vnesysproj}", vnesysproj, wordDocument);
                ReplaceWordStub("{prim_izmslisobol}", izmslisobol, wordDocument);
                ReplaceWordStub("{prim_gepatomealg}", gepatomealg, wordDocument);
                ReplaceWordStub("{prim_ytrenskov}", ytrenskov, wordDocument);
                ReplaceWordStub("{prim_chps}", chps, wordDocument);
                ReplaceWordStub("{prim_chbs}", chbs, wordDocument);
                ReplaceWordStub("{prim_deform}", deform, wordDocument);
                ReplaceWordStub("{prim_vash}", vash, wordDocument);
                //анамнез жизни
                ReplaceWordStub("{prim_revmzabrod}", revmzabrod, wordDocument);
                ReplaceWordStub("{prim_psorrods}", psorrods, wordDocument);
                ReplaceWordStub("{prim_onkpotrods}", onkpotrods, wordDocument);
                ReplaceWordStub("{prim_drygzabrods}", drygzabrods, wordDocument);
                ReplaceWordStub("{prim_workstat}", workstat, wordDocument);
                ReplaceWordStub("{prim_inval}", inval, wordDocument);
                ReplaceWordStub("{prim_invgr}", invgr, wordDocument);
                ReplaceWordStub("{prim_dinaminv}", dinaminv, wordDocument);
                ReplaceWordStub("{prim_pereosvinv}", pereosvinv, wordDocument);
                ReplaceWordStub("{prim_listnetryd}", listnetryd, wordDocument);
                ReplaceWordStub("{prim_bolnichdney}", bolnichdney, wordDocument);
                ReplaceWordStub("{prim_alerganamn}", alerganamn, wordDocument);
                ReplaceWordStub("{prim_grip}", grip, wordDocument);
                ReplaceWordStub("{prim_pnevmokok}", pnevmokok, wordDocument);
                ReplaceWordStub("{prim_korona}", korona, wordDocument);
                ReplaceWordStub("{prim_tyber}", tyber, wordDocument);
                ReplaceWordStub("{prim_venzab}", venzab, wordDocument);
                ReplaceWordStub("{prim_gepatit}", gepatit, wordDocument);
                ReplaceWordStub("{prim_malaria}", malaria, wordDocument);
                ReplaceWordStub("{prim_kleshi}", kleshi, wordDocument);
                ReplaceWordStub("{prim_vredprivich}", vredprivich, wordDocument);
                ReplaceWordStub("{prim_profvred}", profvred, wordDocument);
                ReplaceWordStub("{prim_bityslov}", bityslov, wordDocument);
                ReplaceWordStub("{prim_pitanie}", pitanie, wordDocument);
                ReplaceWordStub("{prim_dvigact}", dvigact, wordDocument);
                //анамнез заболевания
                ReplaceWordStub("{prim_anamnzabol}", anamnzabol, wordDocument);
                //общий осмотр
                ReplaceWordStub("{prim_obhsost}", obhsost, wordDocument);
                ReplaceWordStub("{prim_temptela}", temptela, wordDocument);
                ReplaceWordStub("{prim_soznan}", soznan, wordDocument);
                ReplaceWordStub("{prim_kontact}", kontact, wordDocument);
                ReplaceWordStub("{prim_emoclab}", emoclab, wordDocument);
                ReplaceWordStub("{prim_prostrivrema}", prostrivrema, wordDocument);
                ReplaceWordStub("{prim_teloslojprav}", teloslojprav, wordDocument);
                ReplaceWordStub("{prim_kojpokr}", kojpokr, wordDocument);
                ReplaceWordStub("{prim_kojokrask}", kojokrask, wordDocument);
                ReplaceWordStub("{prim_tyrgor}", tyrgor, wordDocument);
                ReplaceWordStub("{prim_vlagtyrgor}", vlagtyrgor, wordDocument);
                ReplaceWordStub("{prim_vidslisobol}", vidslisobol, wordDocument);
                ReplaceWordStub("{prim_okrasvidslisobol}", okrasvidslisobol, wordDocument);
                ReplaceWordStub("{prim_kostmishrazv}", kostmishrazv, wordDocument);
                ReplaceWordStub("{prim_dvijvsyst}", dvijvsyst, wordDocument);
                ReplaceWordStub("{prim_zev}", zev, wordDocument);
                ReplaceWordStub("{prim_okraszev}", okraszev, wordDocument);
                ReplaceWordStub("{prim_mindal}", mindal, wordDocument);
                ReplaceWordStub("{prim_pereferlimf}", pereferlimf, wordDocument);
                ReplaceWordStub("{prim_oteki}", oteki, wordDocument);
                ReplaceWordStub("{prim_mestoteki}", mestoteki, wordDocument);
                ReplaceWordStub("{prim_molochjel}", molochjel, wordDocument);
                ReplaceWordStub("{prim_palpatormolochjel}", palpatormolochjel, wordDocument);
                ReplaceWordStub("{prim_shitovjel}", shitovjel, wordDocument);
                ReplaceWordStub("{prim_razmshitovjel}", razmshitovjel, wordDocument);
                ReplaceWordStub("{prim_chss}", chss, wordDocument);
                ReplaceWordStub("{prim_artdavl}", artdavl, wordDocument);
                ReplaceWordStub("{prim_patologpyls}", patologpyls, wordDocument);
                ReplaceWordStub("{prim_pulsbedr}", pulsbedr, wordDocument);
                ReplaceWordStub("{prim_shymbrahart}", shymbrahart, wordDocument);
                ReplaceWordStub("{prim_tonserdc}", tonserdc, wordDocument);
                ReplaceWordStub("{prim_shymserdc}", shymserdc, wordDocument);
                ReplaceWordStub("{prim_chislodih}", chislodih, wordDocument);
                ReplaceWordStub("{prim_grydform}", grydform, wordDocument);
                ReplaceWordStub("{prim_actdihmishc}", actdihmishc, wordDocument);
                ReplaceWordStub("{prim_distchrip}", distchrip, wordDocument);
                ReplaceWordStub("{prim_perkytor}", perkytor, wordDocument);
                ReplaceWordStub("{prim_dyhan}", dyhan, wordDocument);
                ReplaceWordStub("{prim_shymdyhan}", shymdyhan, wordDocument);
                ReplaceWordStub("{prim_jziknal}", jziknal, wordDocument);
                ReplaceWordStub("{prim_jivotpripalpac}", jivotpripalpac, wordDocument);
                ReplaceWordStub("{prim_glybpalpackish}", glybpalpackish, wordDocument);
                ReplaceWordStub("{prim_slepkish}", slepkish, wordDocument);
                ReplaceWordStub("{prim_poperobodkish}", poperobodkish, wordDocument);
                ReplaceWordStub("{prim_pechen}", pechen, wordDocument);
                ReplaceWordStub("{prim_krayreberdyg}", krayreberdyg, wordDocument);
                ReplaceWordStub("{prim_plotnkrayreberdyg}", plotnkrayreberdyg, wordDocument);
                ReplaceWordStub("{prim_poverhpecheni}", poverhpecheni, wordDocument);
                ReplaceWordStub("{prim_selezenk}", selezenk, wordDocument);
                ReplaceWordStub("{prim_simptpokolach}", simptpokolach, wordDocument);
                ReplaceWordStub("{prim_fiziologotprav}", fiziologotprav, wordDocument);
                //представления о больном
                ReplaceWordStub("{prim_predstavobolnom}", predstavobolnom, wordDocument);
                //план ведения
                ReplaceWordStub("{prim_planobsledov}", planobsledov, wordDocument);
                ReplaceWordStub("{prim_planlecheni}", planlecheni, wordDocument);


                wordDocument.SaveAs(@"D:\Учеба программист\Инженер-программист\Дипломная работа\Прием.doc");

                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }


        }
        //метод заполнениря меток в шаблоне
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting(); //очистить формат
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPatient taskWindow = new AddPatient();
            taskWindow.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void проверкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 taskWindow = new Form2();
            taskWindow.Show();
        }

        private void PatientShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Formup();
        }
        private void списокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void GetData()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(@"SELECT CONCAT_WS (' ', LastName, Name, MiddleName) as ФИО, DateOfBirth as 'Дата Рождения', Name, LastName, MiddleName, Gender, DateOfBirth, Phone, PWork, SNILS, PolisNum, NamePolis, Сountry, District, City, Street, House, Apartment, MainDisease, ICD10, id FROM Patient", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Rows[0].Selected = false;   //отключает выделение первой строки
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 110;
            dataGridView1.Columns[2].Visible = false; //откючает видимость колонки датагрид
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
        }
        private void тестОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
        private void DiseaseHistory_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void добавитьАнализыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void общийАнализКровиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 taskWindow = new Form5();
            taskWindow.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int currRowIndex = dataGridView1.CurrentCell.RowIndex;
            //при повторном нажатии сохранял изменения в базе данных
            if ((k_Name.Text.Equals("")) || (LastName.Text.Equals("")) || (Gender.Text.Equals("")) || (DateOfBirth.Text.Equals("")) || (SNILS.Text.Equals("")) || (PolisNum.Text.Equals("")) || (NamePolis.Text.Equals("")) || (Сountry.Text.Equals("")) || (City.Text.Equals("")) || (Street.Text.Equals("")) || (House.Text.Equals("")) || (Apartment.Text.Equals("")) || (ICD10.Text.Equals("")))
                System.Windows.Forms.MessageBox.Show("Введите все обязательные данные в поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                k_Name.ReadOnly = !k_Name.ReadOnly;
                LastName.ReadOnly = !LastName.ReadOnly;
                MidName.ReadOnly = !MidName.ReadOnly;
                Gender1.Visible = !Gender1.Visible;
                Gender.Visible = !Gender.Visible;
                DateOfBirth.ReadOnly = !DateOfBirth.ReadOnly;
                Phone.ReadOnly = !Phone.ReadOnly;
                Work.ReadOnly = !Work.ReadOnly;
                SNILS.ReadOnly = !SNILS.ReadOnly;
                PolisNum.ReadOnly = !PolisNum.ReadOnly;
                NamePolis.ReadOnly = !NamePolis.ReadOnly;
                Country1.Visible = !Country1.Visible;
                Сountry.Visible = !Сountry.Visible;
                District.ReadOnly = !District.ReadOnly;
                City.ReadOnly = !City.ReadOnly;
                Street.ReadOnly = !Street.ReadOnly;
                House.ReadOnly = !House.ReadOnly;
                Apartment.ReadOnly = !Apartment.ReadOnly;
                MainDisease.ReadOnly = !MainDisease.ReadOnly;
                ICD10_1.Visible = !ICD10_1.Visible;
                ICD10.Visible = !ICD10.Visible;
                button2.Visible = !button2.Visible;
                if (button1.Text == "Сохранить изменения") button1.Text = "Редактировать";
                else button1.Text = "Сохранить изменения";

                string connectionString = @"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand update = new SqlCommand(@"UPDATE Patient SET Name=@Name, LastName=@LastName, MiddleName=@MidName, Gender=@Gender, DateOfBirth=@DateOfBirth, Phone=@Phone, PWork=@Work, SNILS=@SNILS, PolisNum=@PolisNum, NamePolis=@NamePolis, Сountry=@Сountry, District=@District, City=@City, Street=@Street, House=@House, Apartment=@Apartment, MainDisease=@MainDisease, ICD10=@ICD10 WHERE (id=@id)", connection);
                    update.Parameters.AddWithValue("@Name", k_Name.Text);
                    update.Parameters.AddWithValue("@LastName", LastName.Text);
                    update.Parameters.AddWithValue("@MidName", MidName.Text);
                    update.Parameters.AddWithValue("@Gender", Gender.Text);
                    update.Parameters.AddWithValue("@DateOfBirth", DateOfBirth.Text);
                    update.Parameters.AddWithValue("@Phone", Phone.Text);
                    update.Parameters.AddWithValue("@Work", Work.Text);
                    update.Parameters.AddWithValue("@SNILS", SNILS.Text);
                    update.Parameters.AddWithValue("@PolisNum", PolisNum.Text);
                    update.Parameters.AddWithValue("@NamePolis", NamePolis.Text);
                    update.Parameters.AddWithValue("@Сountry", Сountry.Text);
                    update.Parameters.AddWithValue("@District", District.Text);
                    update.Parameters.AddWithValue("@City", City.Text);
                    update.Parameters.AddWithValue("@Street", Street.Text);
                    update.Parameters.AddWithValue("@House", House.Text);
                    update.Parameters.AddWithValue("@Apartment", Apartment.Text);
                    update.Parameters.AddWithValue("@MainDisease", MainDisease.Text);
                    update.Parameters.AddWithValue("@ICD10", ICD10.Text);
                    update.Parameters.AddWithValue("@id", id.Text);
                    connection.Open();
                    update.ExecuteNonQuery();
                    connection.Close();
                }                
                dataGridView1.CurrentCell = dataGridView1[0, currRowIndex];
            }
            GetData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            k_Name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            LastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            MidName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Gender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Gender1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            DateOfBirth.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Phone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Work.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            SNILS.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            PolisNum.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            NamePolis.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            Сountry.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            Country1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            District.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            City.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            Street.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            House.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            Apartment.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            MainDisease.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            ICD10.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            ICD10_1.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            button1.Text = "Редактировать";
            k_Name.ReadOnly = !k_Name.ReadOnly;
            LastName.ReadOnly = !LastName.ReadOnly;
            MidName.ReadOnly = !MidName.ReadOnly;
            Gender1.Visible = !Gender1.Visible;
            Gender.Visible = !Gender.Visible;
            DateOfBirth.ReadOnly = !DateOfBirth.ReadOnly;
            Phone.ReadOnly = !Phone.ReadOnly;
            Work.ReadOnly = !Work.ReadOnly;
            SNILS.ReadOnly = !SNILS.ReadOnly;
            PolisNum.ReadOnly = !PolisNum.ReadOnly;
            NamePolis.ReadOnly = !NamePolis.ReadOnly;
            Country1.Visible = !Country1.Visible;
            Сountry.Visible = !Сountry.Visible;
            District.ReadOnly = !District.ReadOnly;
            City.ReadOnly = !City.ReadOnly;
            Street.ReadOnly = !Street.ReadOnly;
            House.ReadOnly = !House.ReadOnly;
            Apartment.ReadOnly = !Apartment.ReadOnly;
            MainDisease.ReadOnly = !MainDisease.ReadOnly;
            ICD10_1.Visible = !ICD10_1.Visible;
            ICD10.Visible = !ICD10.Visible;
            button2.Visible = !button2.Visible;                
            
            
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Сountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ICD10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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
        private void SNILS_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        } 
        private void comboBox56_SelectedIndexChanged(object sender, EventArgs e)
        {
            //исправить!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if (prim_oteki.GetItemText(prim_oteki.SelectedItem) == "не определяются")
            {
                label108.Visible = false;
                prim_mestoteki.Visible = false;
            }
            else
            {
                label108.Visible = true;
                prim_mestoteki.Visible = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }

        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(prim_ves.Text) || String.IsNullOrEmpty(prim_rost.Text))
            {

            }
            else
            {
                Double a, b, c, f;
                a = Double.Parse(prim_ves.Text);
                b = Double.Parse(prim_rost.Text);
                c = (a / ((b / 100) * (b / 100)));
                f = 3600;
                //формула Мостеллера для площади поверхности тела               
                Double q = Math.Sqrt(a * b / f);
                c = Math.Round(c, 2);
                q = Math.Round(q, 2);
                prim_indmasstela.Text = c.ToString();
                prim_spovtela.Text = q.ToString();
            }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(prim_ves.Text) || String.IsNullOrEmpty(prim_rost.Text))
            {

            }
            else
            {
                Double a, b, c, f;
                a = Double.Parse(prim_ves.Text);
                b = Double.Parse(prim_rost.Text);
                c = (a / ((b / 100) * (b / 100)));
                f = 3600;
                //формула Мостеллера для площади поверхности тела               
                Double q = Math.Sqrt(a * b / f);
                c = Math.Round(c, 2);
                q = Math.Round(q, 2);
                prim_indmasstela.Text = c.ToString();
                prim_spovtela.Text = q.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((k_Name.Text.Equals("")) || (LastName.Text.Equals("")) || (Gender.Text.Equals("")) || (DateOfBirth.Text.Equals("")) || (SNILS.Text.Equals("")) || (PolisNum.Text.Equals("")) || (NamePolis.Text.Equals("")) || (Сountry.Text.Equals("")) || (City.Text.Equals("")) || (Street.Text.Equals("")) || (House.Text.Equals("")) || (Apartment.Text.Equals("")) || (ICD10.Text.Equals("")))
                MessageBox.Show("Введите все обязательные данные в поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                string connectionString = @"server = DESKTOP-24JBSIO\SQLEXPRESS; database = MIS; Integrated Security=SSPI";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("INSERT INTO Priem (SNILS, epizod, prim_jalob, prim_bolvsys, prim_oteksys, prim_utrskov, prim_povtemp, prim_slab, prim_izmmastel, prim_visnasliz, prim_syhkojslis, prim_chyvstrykholod, prim_zatrpriglot, prim_telosloj, prim_ves, prim_rost, prim_indmasstela, prim_spovtela, prim_porokoltkan, prim_tynsyndr, prim_vnesysproj, prim_izmslisobol, prim_gepatomealg, " +
                    "prim_ytrenskov, prim_chps, prim_chbs, prim_deform, prim_vash, prim_revmzabrod, prim_psorrods, prim_onkpotrods, prim_drygzabrods, prim_workstat, prim_inval, prim_invgr, prim_dinaminv, prim_pereosvinv, prim_listnetryd, prim_bolnichdney, prim_alerganamn, prim_grip, prim_pnevmokok, prim_korona, prim_tyber, prim_venzab, prim_gepatit, prim_malaria, prim_kleshi, prim_vredprivich, prim_profvred, " +
                    "prim_bityslov, prim_pitanie, prim_dvigact, prim_anamnzabol, prim_obhsost, prim_temptela, prim_soznan, prim_kontact, prim_emoclab, prim_prostrivrema, prim_teloslojprav, prim_kojpokr, prim_kojokrask, prim_tyrgor, prim_vlagtyrgor, prim_vidslisobol, prim_okrasvidslisobol, prim_kostmishrazv, prim_dvijvsyst, prim_zev, prim_okraszev, prim_mindal, prim_pereferlimf, prim_oteki, prim_mestoteki, " +
                    "prim_molochjel, prim_palpatormolochjel, prim_shitovjel, prim_razmshitovjel, prim_chss, prim_artdavl, prim_patologpyls, prim_pulsbedr, prim_shymbrahart, prim_tonserdc, prim_shymserdc, prim_chislodih, prim_grydform, prim_actdihmishc, prim_distchrip, prim_perkytor, prim_dyhan, prim_shymdyhan, prim_jziknal, prim_jivotpripalpac, prim_glybpalpackish, prim_slepkish, prim_poperobodkish, prim_pechen, " +
                    "prim_krayreberdyg, prim_plotnkrayreberdyg, prim_poverhpecheni, prim_selezenk, prim_simptpokolach, prim_fiziologotprav, prim_predstavobolnom, prim_planobsledov, prim_planlecheni)" +
                    "VALUES (@SNILS, @epizod, @jalob, @bolvsys, @oteksys, @utrskov, @povtemp, @slab, @izmmastel, @visnasliz, @syhkojslis, @chyvstrykholod, @zatrpriglot, @telosloj, @ves, @rost, @indmasstela, @spovtela, @porokoltkan, @tynsyndr, @vnesysproj, @izmslisobol, @gepatomealg, @ytrenskov, @chps, @chbs, @deform, @vash, @revmzabrod, @psorrods, @onkpotrods, @drygzabrods, @workstat, @inval, @invgr, @dinaminv, " +
                    "@pereosvinv, @listnetryd, @bolnichdney, @alerganamn, @grip, @pnevmokok, @korona, @tyber, @venzab, @gepatit, @malaria, @kleshi, @vredprivich, @profvred, " +
                    "@bityslov, @pitanie, @dvigact, @anamnzabol, @obhsost, @temptela, @soznan, @kontact, @emoclab, @prostrivrema, @teloslojprav, @kojpokr, @kojokrask, @tyrgor, @vlagtyrgor, @vidslisobol, @okrasvidslisobol, @kostmishrazv, @dvijvsyst, @zev, @okraszev, @mindal, @pereferlimf, @oteki, @mestoteki, " +
                    "@molochjel, @palpatormolochjel, @shitovjel, @razmshitovjel, @chss, @artdavl, @patologpyls, @pulsbedr, @shymbrahart, @tonserdc, @shymserdc, @chislodih, @grydform, @actdihmishc, @distchrip, @perkytor, @dyhan, @shymdyhan, @jziknal, @jivotpripalpac, @glybpalpackish, @slepkish, @poperobodkish, @pechen, " +
                    "@krayreberdyg, @plotnkrayreberdyg, @poverhpecheni, @selezenk, @simptpokolach, @fiziologotprav, @predstavobolnom, @planobsledov, @planlecheni)", connection);

                    command.Parameters.AddWithValue("@epizod", epizod.Text);
                    command.Parameters.AddWithValue("@SNILS", SNILS.Text);
                    //жалобы
                    command.Parameters.AddWithValue("@jalob", prim_jalob.Text);
                    command.Parameters.AddWithValue("@bolvsys", prim_bolvsys.Text);
                    command.Parameters.AddWithValue("@oteksys", prim_oteksys.Text);
                    command.Parameters.AddWithValue("@utrskov", prim_utrskov.Text);
                    command.Parameters.AddWithValue("@povtemp", prim_povtemp.Text);
                    command.Parameters.AddWithValue("@slab", prim_slab.Text);
                    command.Parameters.AddWithValue("@izmmastel", prim_izmmastel.Text);
                    command.Parameters.AddWithValue("@visnasliz", prim_visnasliz.Text);
                    command.Parameters.AddWithValue("@syhkojslis", prim_syhkojslis.Text);
                    command.Parameters.AddWithValue("@chyvstrykholod", prim_chyvstrykholod.Text);
                    command.Parameters.AddWithValue("@zatrpriglot", prim_zatrpriglot.Text);
                    //ревматологический статус
                    command.Parameters.AddWithValue("@telosloj", prim_telosloj.Text);
                    command.Parameters.AddWithValue("@ves", prim_ves.Text); //!!!!!!!!!!!!!!!!!!!!!
                    command.Parameters.AddWithValue("@rost", prim_rost.Text); //!!!!!!!!!!!!!!!!!!!!!
                    command.Parameters.AddWithValue("@indmasstela", prim_indmasstela.Text); //!!!!!!!!!!!!!!!!!!!!!
                    command.Parameters.AddWithValue("@spovtela", prim_spovtela.Text); //!!!!!!!!!!!!!!!!!!!!!
                    command.Parameters.AddWithValue("@porokoltkan", prim_porokoltkan.Text);
                    command.Parameters.AddWithValue("@tynsyndr", prim_tynsyndr.Text);
                    command.Parameters.AddWithValue("@vnesysproj", prim_vnesysproj.Text);
                    command.Parameters.AddWithValue("@izmslisobol", prim_izmslisobol.Text);
                    command.Parameters.AddWithValue("@gepatomealg", prim_gepatomealg.Text);
                    command.Parameters.AddWithValue("@ytrenskov", prim_ytrenskov.Text);
                    command.Parameters.AddWithValue("@chps", prim_chps.Text);
                    command.Parameters.AddWithValue("@chbs", prim_chbs.Text);
                    command.Parameters.AddWithValue("@deform", prim_deform.Text);
                    command.Parameters.AddWithValue("@vash", prim_vash.Text);
                    //анамнез жизни
                    command.Parameters.AddWithValue("@revmzabrod", prim_revmzabrod.Text);
                    command.Parameters.AddWithValue("@psorrods", prim_psorrods.Text);
                    command.Parameters.AddWithValue("@onkpotrods", prim_onkpotrods.Text);
                    command.Parameters.AddWithValue("@drygzabrods", prim_drygzabrods.Text);
                    command.Parameters.AddWithValue("@workstat", prim_workstat.Text);
                    command.Parameters.AddWithValue("@inval", prim_inval.Text);
                    command.Parameters.AddWithValue("@invgr", prim_invgr.Text);
                    command.Parameters.AddWithValue("@dinaminv", prim_dinaminv.Text);
                    command.Parameters.AddWithValue("@pereosvinv", prim_pereosvinv.Text);
                    command.Parameters.AddWithValue("@listnetryd", prim_listnetryd.Text);
                    command.Parameters.AddWithValue("@bolnichdney", prim_bolnichdney.Text);
                    command.Parameters.AddWithValue("@alerganamn", prim_alerganamn.Text);
                    command.Parameters.AddWithValue("@grip", prim_grip.Text);
                    command.Parameters.AddWithValue("@pnevmokok", prim_pnevmokok.Text);
                    command.Parameters.AddWithValue("@korona", prim_korona.Text);
                    command.Parameters.AddWithValue("@tyber", prim_tyber.Text);
                    command.Parameters.AddWithValue("@venzab", prim_venzab.Text);
                    command.Parameters.AddWithValue("@gepatit", prim_gepatit.Text);
                    command.Parameters.AddWithValue("@malaria", prim_malaria.Text);
                    command.Parameters.AddWithValue("@kleshi", prim_kleshi.Text);
                    command.Parameters.AddWithValue("@vredprivich", prim_vredprivich.Text);
                    command.Parameters.AddWithValue("@profvred", prim_profvred.Text);
                    command.Parameters.AddWithValue("@bityslov", prim_bityslov.Text);
                    command.Parameters.AddWithValue("@pitanie", prim_pitanie.Text);
                    command.Parameters.AddWithValue("@dvigact", prim_dvigact.Text);
                    //анамнез заболевания
                    command.Parameters.AddWithValue("@anamnzabol", prim_anamnzabol.Text);
                    //общий осмотр
                    command.Parameters.AddWithValue("@obhsost", prim_obhsost.Text);
                    command.Parameters.AddWithValue("@temptela", prim_temptela.Text); //!!!!!!!!!!!!!!!!!!!!!
                    command.Parameters.AddWithValue("@soznan", prim_soznan.Text);
                    command.Parameters.AddWithValue("@kontact", prim_kontact.Text);
                    command.Parameters.AddWithValue("@emoclab", prim_emoclab.Text);
                    command.Parameters.AddWithValue("@prostrivrema", prim_prostrivrema.Text);
                    command.Parameters.AddWithValue("@teloslojprav", prim_teloslojprav.Text);
                    command.Parameters.AddWithValue("@kojpokr", prim_kojpokr.Text);
                    command.Parameters.AddWithValue("@kojokrask", prim_kojokrask.Text);
                    command.Parameters.AddWithValue("@tyrgor", prim_tyrgor.Text);
                    command.Parameters.AddWithValue("@vlagtyrgor", prim_vlagtyrgor.Text);
                    command.Parameters.AddWithValue("@vidslisobol", prim_vidslisobol.Text);
                    command.Parameters.AddWithValue("@okrasvidslisobol", prim_okrasvidslisobol.Text);
                    command.Parameters.AddWithValue("@kostmishrazv", prim_kostmishrazv.Text);
                    command.Parameters.AddWithValue("@dvijvsyst", prim_dvijvsyst.Text);
                    command.Parameters.AddWithValue("@zev", prim_zev.Text);
                    command.Parameters.AddWithValue("@okraszev", prim_okraszev.Text);
                    command.Parameters.AddWithValue("@mindal", prim_mindal.Text);
                    command.Parameters.AddWithValue("@pereferlimf", prim_pereferlimf.Text);
                    command.Parameters.AddWithValue("@oteki", prim_oteki.Text);
                    command.Parameters.AddWithValue("@mestoteki", prim_mestoteki.Text);
                    command.Parameters.AddWithValue("@molochjel", prim_molochjel.Text);
                    command.Parameters.AddWithValue("@palpatormolochjel", prim_palpatormolochjel.Text);
                    command.Parameters.AddWithValue("@shitovjel", prim_shitovjel.Text);
                    command.Parameters.AddWithValue("@razmshitovjel", prim_razmshitovjel.Text);
                    command.Parameters.AddWithValue("@chss", prim_chss.Text);
                    command.Parameters.AddWithValue("@artdavl", prim_artdavl.Text);
                    command.Parameters.AddWithValue("@patologpyls", prim_patologpyls.Text);
                    command.Parameters.AddWithValue("@pulsbedr", prim_pulsbedr.Text);
                    command.Parameters.AddWithValue("@shymbrahart", prim_shymbrahart.Text);
                    command.Parameters.AddWithValue("@tonserdc", prim_tonserdc.Text);
                    command.Parameters.AddWithValue("@shymserdc", prim_shymserdc.Text);
                    command.Parameters.AddWithValue("@chislodih", prim_chislodih.Text);
                    command.Parameters.AddWithValue("@grydform", prim_grydform.Text);
                    command.Parameters.AddWithValue("@actdihmishc", prim_actdihmishc.Text);
                    command.Parameters.AddWithValue("@distchrip", prim_distchrip.Text);
                    command.Parameters.AddWithValue("@perkytor", prim_perkytor.Text);
                    command.Parameters.AddWithValue("@dyhan", prim_dyhan.Text);
                    command.Parameters.AddWithValue("@shymdyhan", prim_shymdyhan.Text);
                    command.Parameters.AddWithValue("@jziknal", prim_jziknal.Text);
                    command.Parameters.AddWithValue("@jivotpripalpac", prim_jivotpripalpac.Text);
                    command.Parameters.AddWithValue("@glybpalpackish", prim_glybpalpackish.Text);
                    command.Parameters.AddWithValue("@slepkish", prim_slepkish.Text);
                    command.Parameters.AddWithValue("@poperobodkish", prim_poperobodkish.Text);
                    command.Parameters.AddWithValue("@pechen", prim_pechen.Text);
                    command.Parameters.AddWithValue("@krayreberdyg", prim_krayreberdyg.Text);
                    command.Parameters.AddWithValue("@plotnkrayreberdyg", prim_plotnkrayreberdyg.Text);
                    command.Parameters.AddWithValue("@poverhpecheni", prim_poverhpecheni.Text);
                    command.Parameters.AddWithValue("@selezenk", prim_selezenk.Text);
                    command.Parameters.AddWithValue("@simptpokolach", prim_simptpokolach.Text);
                    command.Parameters.AddWithValue("@fiziologotprav", prim_fiziologotprav.Text);
                    //представления о больном
                    command.Parameters.AddWithValue("@predstavobolnom", prim_predstavobolnom.Text);
                    //план ведения
                    command.Parameters.AddWithValue("@planobsledov", prim_planobsledov.Text);
                    command.Parameters.AddWithValue("@planlecheni", prim_planlecheni.Text);

                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    button3.Enabled = false;
                    button4.Visible = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        public void Formup()
        {
            //вывод данных в подготовленную форму
            k_Name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prim_Name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            LastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            prim_LastName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            MidName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            prim_MidName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Gender.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Gender1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            DateOfBirth.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            prim_DateOfBirth.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            Phone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            Work.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            prim_Work.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            SNILS.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            PolisNum.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            NamePolis.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

            Сountry.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            Country1.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            prim_Сountry.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

            District.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            prim_District.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();

            City.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            prim_City.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();

            Street.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            prim_Street.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

            House.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            prim_House.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();

            Apartment.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            prim_Apartment.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();

            MainDisease.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();

            ICD10.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            ICD10_1.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();

            id.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            prim_id.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();


        }
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            Formup();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }
    }
}
   
