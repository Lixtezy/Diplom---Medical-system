
namespace Medical_system
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАнализыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийАнализКровиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet2 = new Medical_system.MISDataSet2();
            this.mISDataSet = new Medical_system.MISDataSet();
            this.mISDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet4 = new Medical_system.MISDataSet4();
            this.iCD10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analizeTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.analizeTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obshiyAnalizyKroviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Medical_system.MISDataSet2TableAdapters.PatientTableAdapter();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.analizeTypeTableAdapter = new Medical_system.MISDataSet4TableAdapters.AnalizeTypeTableAdapter();
            this.obshiyAnalizyKroviTableAdapter = new Medical_system.MISDataSet4TableAdapters.ObshiyAnalizyKroviTableAdapter();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.hospitalizationTableAdapter = new Medical_system.MISDataSet4TableAdapters.HospitalizationTableAdapter();
            this.patientTableAdapter1 = new Medical_system.MISDataSet4TableAdapters.PatientTableAdapter();
            this.patientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iCD10TableAdapter = new Medical_system.MISDataSetTableAdapters.ICD10TableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.AnalysisType = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.DateOfAnalysis = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.epizod = new System.Windows.Forms.MaskedTextBox();
            this.label114 = new System.Windows.Forms.Label();
            this.prim_jalob = new System.Windows.Forms.RichTextBox();
            this.prim_DateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label165 = new System.Windows.Forms.Label();
            this.prim_id = new System.Windows.Forms.TextBox();
            this.label164 = new System.Windows.Forms.Label();
            this.prim_Name = new System.Windows.Forms.TextBox();
            this.label163 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.prim_Сountry = new System.Windows.Forms.TextBox();
            this.label156 = new System.Windows.Forms.Label();
            this.prim_LastName = new System.Windows.Forms.TextBox();
            this.label157 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.prim_MidName = new System.Windows.Forms.TextBox();
            this.label159 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.prim_House = new System.Windows.Forms.TextBox();
            this.label153 = new System.Windows.Forms.Label();
            this.prim_Apartment = new System.Windows.Forms.TextBox();
            this.prim_Work = new System.Windows.Forms.TextBox();
            this.prim_Street = new System.Windows.Forms.TextBox();
            this.label152 = new System.Windows.Forms.Label();
            this.prim_City = new System.Windows.Forms.TextBox();
            this.prim_District = new System.Windows.Forms.TextBox();
            this.label151 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.prim_planlecheni = new System.Windows.Forms.RichTextBox();
            this.prim_planobsledov = new System.Windows.Forms.RichTextBox();
            this.label149 = new System.Windows.Forms.Label();
            this.prim_predstavobolnom = new System.Windows.Forms.RichTextBox();
            this.label148 = new System.Windows.Forms.Label();
            this.prim_fiziologotprav = new System.Windows.Forms.ComboBox();
            this.label147 = new System.Windows.Forms.Label();
            this.prim_simptpokolach = new System.Windows.Forms.ComboBox();
            this.label146 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.prim_selezenk = new System.Windows.Forms.ComboBox();
            this.label144 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.prim_plotnkrayreberdyg = new System.Windows.Forms.TextBox();
            this.prim_poverhpecheni = new System.Windows.Forms.ComboBox();
            this.label142 = new System.Windows.Forms.Label();
            this.prim_krayreberdyg = new System.Windows.Forms.ComboBox();
            this.label141 = new System.Windows.Forms.Label();
            this.prim_pechen = new System.Windows.Forms.ComboBox();
            this.label140 = new System.Windows.Forms.Label();
            this.prim_poperobodkish = new System.Windows.Forms.ComboBox();
            this.label139 = new System.Windows.Forms.Label();
            this.prim_slepkish = new System.Windows.Forms.ComboBox();
            this.label138 = new System.Windows.Forms.Label();
            this.prim_glybpalpackish = new System.Windows.Forms.ComboBox();
            this.label137 = new System.Windows.Forms.Label();
            this.prim_jivotpripalpac = new System.Windows.Forms.ComboBox();
            this.label136 = new System.Windows.Forms.Label();
            this.prim_jziknal = new System.Windows.Forms.ComboBox();
            this.label135 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.prim_shymdyhan = new System.Windows.Forms.ComboBox();
            this.label133 = new System.Windows.Forms.Label();
            this.prim_dyhan = new System.Windows.Forms.ComboBox();
            this.label132 = new System.Windows.Forms.Label();
            this.prim_perkytor = new System.Windows.Forms.ComboBox();
            this.label130 = new System.Windows.Forms.Label();
            this.prim_distchrip = new System.Windows.Forms.ComboBox();
            this.label129 = new System.Windows.Forms.Label();
            this.prim_actdihmishc = new System.Windows.Forms.ComboBox();
            this.label128 = new System.Windows.Forms.Label();
            this.prim_grydform = new System.Windows.Forms.ComboBox();
            this.label127 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.prim_chislodih = new System.Windows.Forms.TextBox();
            this.label125 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.prim_shymserdc = new System.Windows.Forms.ComboBox();
            this.label123 = new System.Windows.Forms.Label();
            this.prim_tonserdc = new System.Windows.Forms.ComboBox();
            this.label122 = new System.Windows.Forms.Label();
            this.prim_shymbrahart = new System.Windows.Forms.ComboBox();
            this.label121 = new System.Windows.Forms.Label();
            this.prim_pulsbedr = new System.Windows.Forms.ComboBox();
            this.label120 = new System.Windows.Forms.Label();
            this.prim_patologpyls = new System.Windows.Forms.ComboBox();
            this.label119 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.prim_artdavl = new System.Windows.Forms.TextBox();
            this.label118 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.prim_chss = new System.Windows.Forms.TextBox();
            this.label115 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.prim_razmshitovjel = new System.Windows.Forms.ComboBox();
            this.prim_shitovjel = new System.Windows.Forms.ComboBox();
            this.label112 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.prim_palpatormolochjel = new System.Windows.Forms.ComboBox();
            this.label110 = new System.Windows.Forms.Label();
            this.prim_molochjel = new System.Windows.Forms.ComboBox();
            this.label109 = new System.Windows.Forms.Label();
            this.prim_mestoteki = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.prim_oteki = new System.Windows.Forms.ComboBox();
            this.label107 = new System.Windows.Forms.Label();
            this.prim_pereferlimf = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.prim_mindal = new System.Windows.Forms.ComboBox();
            this.prim_okraszev = new System.Windows.Forms.ComboBox();
            this.label104 = new System.Windows.Forms.Label();
            this.prim_zev = new System.Windows.Forms.ComboBox();
            this.label105 = new System.Windows.Forms.Label();
            this.prim_dvijvsyst = new System.Windows.Forms.ComboBox();
            this.label103 = new System.Windows.Forms.Label();
            this.prim_kostmishrazv = new System.Windows.Forms.ComboBox();
            this.label102 = new System.Windows.Forms.Label();
            this.prim_okrasvidslisobol = new System.Windows.Forms.ComboBox();
            this.label100 = new System.Windows.Forms.Label();
            this.prim_vidslisobol = new System.Windows.Forms.ComboBox();
            this.label101 = new System.Windows.Forms.Label();
            this.prim_vlagtyrgor = new System.Windows.Forms.ComboBox();
            this.label98 = new System.Windows.Forms.Label();
            this.prim_tyrgor = new System.Windows.Forms.ComboBox();
            this.label99 = new System.Windows.Forms.Label();
            this.prim_kojokrask = new System.Windows.Forms.ComboBox();
            this.label97 = new System.Windows.Forms.Label();
            this.prim_kojpokr = new System.Windows.Forms.ComboBox();
            this.label96 = new System.Windows.Forms.Label();
            this.prim_teloslojprav = new System.Windows.Forms.ComboBox();
            this.label95 = new System.Windows.Forms.Label();
            this.prim_prostrivrema = new System.Windows.Forms.ComboBox();
            this.label94 = new System.Windows.Forms.Label();
            this.prim_emoclab = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.prim_kontact = new System.Windows.Forms.ComboBox();
            this.label92 = new System.Windows.Forms.Label();
            this.prim_temptela = new System.Windows.Forms.TextBox();
            this.prim_soznan = new System.Windows.Forms.ComboBox();
            this.label91 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.prim_obhsost = new System.Windows.Forms.ComboBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.prim_anamnzabol = new System.Windows.Forms.RichTextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.prim_dvigact = new System.Windows.Forms.ComboBox();
            this.label86 = new System.Windows.Forms.Label();
            this.prim_pitanie = new System.Windows.Forms.ComboBox();
            this.label85 = new System.Windows.Forms.Label();
            this.prim_bityslov = new System.Windows.Forms.ComboBox();
            this.label84 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.prim_profvred = new System.Windows.Forms.ComboBox();
            this.label82 = new System.Windows.Forms.Label();
            this.prim_vredprivich = new System.Windows.Forms.ComboBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.prim_kleshi = new System.Windows.Forms.ComboBox();
            this.label79 = new System.Windows.Forms.Label();
            this.prim_malaria = new System.Windows.Forms.ComboBox();
            this.label78 = new System.Windows.Forms.Label();
            this.prim_gepatit = new System.Windows.Forms.ComboBox();
            this.label77 = new System.Windows.Forms.Label();
            this.prim_venzab = new System.Windows.Forms.ComboBox();
            this.label75 = new System.Windows.Forms.Label();
            this.prim_tyber = new System.Windows.Forms.ComboBox();
            this.label76 = new System.Windows.Forms.Label();
            this.prim_korona = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.prim_pnevmokok = new System.Windows.Forms.ComboBox();
            this.label73 = new System.Windows.Forms.Label();
            this.prim_grip = new System.Windows.Forms.ComboBox();
            this.label72 = new System.Windows.Forms.Label();
            this.prim_alerganamn = new System.Windows.Forms.ComboBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.prim_bolnichdney = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.prim_listnetryd = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.prim_pereosvinv = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.prim_dinaminv = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.prim_inval = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.prim_workstat = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.prim_drygzabrods = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.prim_onkpotrods = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.prim_psorrods = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.prim_revmzabrod = new System.Windows.Forms.ComboBox();
            this.label57 = new System.Windows.Forms.Label();
            this.prim_invgr = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.prim_vash = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.prim_deform = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.prim_chbs = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.prim_chps = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.prim_ytrenskov = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.prim_gepatomealg = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.prim_izmslisobol = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.prim_vnesysproj = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.prim_tynsyndr = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.prim_porokoltkan = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.prim_spovtela = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.prim_indmasstela = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.prim_rost = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.prim_ves = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.prim_telosloj = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.prim_zatrpriglot = new System.Windows.Forms.ComboBox();
            this.prim_chyvstrykholod = new System.Windows.Forms.ComboBox();
            this.prim_syhkojslis = new System.Windows.Forms.ComboBox();
            this.prim_visnasliz = new System.Windows.Forms.ComboBox();
            this.prim_izmmastel = new System.Windows.Forms.ComboBox();
            this.prim_slab = new System.Windows.Forms.ComboBox();
            this.prim_povtemp = new System.Windows.Forms.ComboBox();
            this.prim_utrskov = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.prim_oteksys = new System.Windows.Forms.ComboBox();
            this.prim_bolvsys = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label166 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.ICD10_1 = new System.Windows.Forms.TextBox();
            this.ICD10 = new System.Windows.Forms.ComboBox();
            this.Gender1 = new System.Windows.Forms.TextBox();
            this.PolisNum = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Country1 = new System.Windows.Forms.TextBox();
            this.Сountry = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.House = new System.Windows.Forms.TextBox();
            this.Apartment = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.District = new System.Windows.Forms.TextBox();
            this.SNILS = new System.Windows.Forms.MaskedTextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.DateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MainDisease = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.NamePolis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Work = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.MidName = new System.Windows.Forms.TextBox();
            this.k_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.avtor_fio = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCD10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analizeTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analizeTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obshiyAnalizyKroviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.анализыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить пациента";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // анализыToolStripMenuItem
            // 
            this.анализыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАнализыToolStripMenuItem});
            this.анализыToolStripMenuItem.Name = "анализыToolStripMenuItem";
            this.анализыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.анализыToolStripMenuItem.Text = "Анализы";
            // 
            // добавитьАнализыToolStripMenuItem
            // 
            this.добавитьАнализыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общийАнализКровиToolStripMenuItem});
            this.добавитьАнализыToolStripMenuItem.Name = "добавитьАнализыToolStripMenuItem";
            this.добавитьАнализыToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьАнализыToolStripMenuItem.Text = "Добавить анализы";
            this.добавитьАнализыToolStripMenuItem.Click += new System.EventHandler(this.добавитьАнализыToolStripMenuItem_Click);
            // 
            // общийАнализКровиToolStripMenuItem
            // 
            this.общийАнализКровиToolStripMenuItem.Name = "общийАнализКровиToolStripMenuItem";
            this.общийАнализКровиToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.общийАнализКровиToolStripMenuItem.Text = "Общий анализ крови";
            this.общийАнализКровиToolStripMenuItem.Click += new System.EventHandler(this.общийАнализКровиToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Обновить список пациентов";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTipText = "Экспорт данных в MsWord";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(314, 936);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CurrentCellChanged += new System.EventHandler(this.dataGridView1_CurrentCellChanged);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.mISDataSet2;
            // 
            // mISDataSet2
            // 
            this.mISDataSet2.DataSetName = "MISDataSet2";
            this.mISDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mISDataSet
            // 
            this.mISDataSet.DataSetName = "MISDataSet";
            this.mISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mISDataSetBindingSource
            // 
            this.mISDataSetBindingSource.DataSource = this.mISDataSet;
            this.mISDataSetBindingSource.Position = 0;
            // 
            // patientBindingSource4
            // 
            this.patientBindingSource4.DataMember = "Patient";
            this.patientBindingSource4.DataSource = this.mISDataSet4;
            // 
            // mISDataSet4
            // 
            this.mISDataSet4.DataSetName = "MISDataSet4";
            this.mISDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCD10BindingSource
            // 
            this.iCD10BindingSource.DataMember = "ICD10";
            this.iCD10BindingSource.DataSource = this.mISDataSetBindingSource;
            // 
            // analizeTypeBindingSource1
            // 
            this.analizeTypeBindingSource1.DataMember = "AnalizeType";
            this.analizeTypeBindingSource1.DataSource = this.mISDataSet4;
            // 
            // analizeTypeBindingSource
            // 
            this.analizeTypeBindingSource.DataMember = "AnalizeType";
            this.analizeTypeBindingSource.DataSource = this.mISDataSet4;
            // 
            // patientBindingSource5
            // 
            this.patientBindingSource5.DataMember = "Patient";
            this.patientBindingSource5.DataSource = this.mISDataSet4;
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.mISDataSet4;
            // 
            // hospitalizationBindingSource
            // 
            this.hospitalizationBindingSource.DataMember = "Hospitalization";
            this.hospitalizationBindingSource.DataSource = this.mISDataSet4;
            // 
            // obshiyAnalizyKroviBindingSource
            // 
            this.obshiyAnalizyKroviBindingSource.DataMember = "ObshiyAnalizyKrovi";
            this.obshiyAnalizyKroviBindingSource.DataSource = this.mISDataSet4;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            // 
            // analizeTypeTableAdapter
            // 
            this.analizeTypeTableAdapter.ClearBeforeFill = true;
            // 
            // obshiyAnalizyKroviTableAdapter
            // 
            this.obshiyAnalizyKroviTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalizationTableAdapter
            // 
            this.hospitalizationTableAdapter.ClearBeforeFill = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // patientBindingSource3
            // 
            this.patientBindingSource3.DataMember = "Patient";
            this.patientBindingSource3.DataSource = this.mISDataSet4;
            // 
            // iCD10TableAdapter
            // 
            this.iCD10TableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.AnalysisType);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.DateOfAnalysis);
            this.tabPage3.Controls.Add(this.splitter1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(948, 903);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Анализы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(9, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 20);
            this.label21.TabIndex = 32;
            this.label21.Text = "Выберете анализ";
            // 
            // AnalysisType
            // 
            this.AnalysisType.DataSource = this.analizeTypeBindingSource1;
            this.AnalysisType.DisplayMember = "AnalysisType";
            this.AnalysisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AnalysisType.Location = new System.Drawing.Point(13, 36);
            this.AnalysisType.Name = "AnalysisType";
            this.AnalysisType.Size = new System.Drawing.Size(164, 24);
            this.AnalysisType.TabIndex = 31;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(9, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(125, 20);
            this.label20.TabIndex = 29;
            this.label20.Text = "Выберете дату";
            // 
            // DateOfAnalysis
            // 
            this.DateOfAnalysis.DataSource = this.analizeTypeBindingSource;
            this.DateOfAnalysis.DisplayMember = "DateOfAnalysis";
            this.DateOfAnalysis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DateOfAnalysis.Location = new System.Drawing.Point(13, 86);
            this.DateOfAnalysis.Name = "DateOfAnalysis";
            this.DateOfAnalysis.Size = new System.Drawing.Size(164, 24);
            this.DateOfAnalysis.TabIndex = 28;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 899);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.epizod);
            this.tabPage2.Controls.Add(this.label114);
            this.tabPage2.Controls.Add(this.prim_jalob);
            this.tabPage2.Controls.Add(this.prim_DateOfBirth);
            this.tabPage2.Controls.Add(this.label165);
            this.tabPage2.Controls.Add(this.prim_id);
            this.tabPage2.Controls.Add(this.label164);
            this.tabPage2.Controls.Add(this.prim_Name);
            this.tabPage2.Controls.Add(this.label163);
            this.tabPage2.Controls.Add(this.label162);
            this.tabPage2.Controls.Add(this.prim_Сountry);
            this.tabPage2.Controls.Add(this.label156);
            this.tabPage2.Controls.Add(this.prim_LastName);
            this.tabPage2.Controls.Add(this.label157);
            this.tabPage2.Controls.Add(this.label155);
            this.tabPage2.Controls.Add(this.label158);
            this.tabPage2.Controls.Add(this.prim_MidName);
            this.tabPage2.Controls.Add(this.label159);
            this.tabPage2.Controls.Add(this.label160);
            this.tabPage2.Controls.Add(this.label154);
            this.tabPage2.Controls.Add(this.label161);
            this.tabPage2.Controls.Add(this.prim_House);
            this.tabPage2.Controls.Add(this.label153);
            this.tabPage2.Controls.Add(this.prim_Apartment);
            this.tabPage2.Controls.Add(this.prim_Work);
            this.tabPage2.Controls.Add(this.prim_Street);
            this.tabPage2.Controls.Add(this.label152);
            this.tabPage2.Controls.Add(this.prim_City);
            this.tabPage2.Controls.Add(this.prim_District);
            this.tabPage2.Controls.Add(this.label151);
            this.tabPage2.Controls.Add(this.label150);
            this.tabPage2.Controls.Add(this.prim_planlecheni);
            this.tabPage2.Controls.Add(this.prim_planobsledov);
            this.tabPage2.Controls.Add(this.label149);
            this.tabPage2.Controls.Add(this.prim_predstavobolnom);
            this.tabPage2.Controls.Add(this.label148);
            this.tabPage2.Controls.Add(this.prim_fiziologotprav);
            this.tabPage2.Controls.Add(this.label147);
            this.tabPage2.Controls.Add(this.prim_simptpokolach);
            this.tabPage2.Controls.Add(this.label146);
            this.tabPage2.Controls.Add(this.label145);
            this.tabPage2.Controls.Add(this.prim_selezenk);
            this.tabPage2.Controls.Add(this.label144);
            this.tabPage2.Controls.Add(this.label143);
            this.tabPage2.Controls.Add(this.prim_plotnkrayreberdyg);
            this.tabPage2.Controls.Add(this.prim_poverhpecheni);
            this.tabPage2.Controls.Add(this.label142);
            this.tabPage2.Controls.Add(this.prim_krayreberdyg);
            this.tabPage2.Controls.Add(this.label141);
            this.tabPage2.Controls.Add(this.prim_pechen);
            this.tabPage2.Controls.Add(this.label140);
            this.tabPage2.Controls.Add(this.prim_poperobodkish);
            this.tabPage2.Controls.Add(this.label139);
            this.tabPage2.Controls.Add(this.prim_slepkish);
            this.tabPage2.Controls.Add(this.label138);
            this.tabPage2.Controls.Add(this.prim_glybpalpackish);
            this.tabPage2.Controls.Add(this.label137);
            this.tabPage2.Controls.Add(this.prim_jivotpripalpac);
            this.tabPage2.Controls.Add(this.label136);
            this.tabPage2.Controls.Add(this.prim_jziknal);
            this.tabPage2.Controls.Add(this.label135);
            this.tabPage2.Controls.Add(this.label134);
            this.tabPage2.Controls.Add(this.prim_shymdyhan);
            this.tabPage2.Controls.Add(this.label133);
            this.tabPage2.Controls.Add(this.prim_dyhan);
            this.tabPage2.Controls.Add(this.label132);
            this.tabPage2.Controls.Add(this.prim_perkytor);
            this.tabPage2.Controls.Add(this.label130);
            this.tabPage2.Controls.Add(this.prim_distchrip);
            this.tabPage2.Controls.Add(this.label129);
            this.tabPage2.Controls.Add(this.prim_actdihmishc);
            this.tabPage2.Controls.Add(this.label128);
            this.tabPage2.Controls.Add(this.prim_grydform);
            this.tabPage2.Controls.Add(this.label127);
            this.tabPage2.Controls.Add(this.label126);
            this.tabPage2.Controls.Add(this.prim_chislodih);
            this.tabPage2.Controls.Add(this.label125);
            this.tabPage2.Controls.Add(this.label124);
            this.tabPage2.Controls.Add(this.prim_shymserdc);
            this.tabPage2.Controls.Add(this.label123);
            this.tabPage2.Controls.Add(this.prim_tonserdc);
            this.tabPage2.Controls.Add(this.label122);
            this.tabPage2.Controls.Add(this.prim_shymbrahart);
            this.tabPage2.Controls.Add(this.label121);
            this.tabPage2.Controls.Add(this.prim_pulsbedr);
            this.tabPage2.Controls.Add(this.label120);
            this.tabPage2.Controls.Add(this.prim_patologpyls);
            this.tabPage2.Controls.Add(this.label119);
            this.tabPage2.Controls.Add(this.label117);
            this.tabPage2.Controls.Add(this.prim_artdavl);
            this.tabPage2.Controls.Add(this.label118);
            this.tabPage2.Controls.Add(this.label116);
            this.tabPage2.Controls.Add(this.prim_chss);
            this.tabPage2.Controls.Add(this.label115);
            this.tabPage2.Controls.Add(this.label113);
            this.tabPage2.Controls.Add(this.prim_razmshitovjel);
            this.tabPage2.Controls.Add(this.prim_shitovjel);
            this.tabPage2.Controls.Add(this.label112);
            this.tabPage2.Controls.Add(this.label111);
            this.tabPage2.Controls.Add(this.prim_palpatormolochjel);
            this.tabPage2.Controls.Add(this.label110);
            this.tabPage2.Controls.Add(this.prim_molochjel);
            this.tabPage2.Controls.Add(this.label109);
            this.tabPage2.Controls.Add(this.prim_mestoteki);
            this.tabPage2.Controls.Add(this.label108);
            this.tabPage2.Controls.Add(this.prim_oteki);
            this.tabPage2.Controls.Add(this.label107);
            this.tabPage2.Controls.Add(this.prim_pereferlimf);
            this.tabPage2.Controls.Add(this.label106);
            this.tabPage2.Controls.Add(this.prim_mindal);
            this.tabPage2.Controls.Add(this.prim_okraszev);
            this.tabPage2.Controls.Add(this.label104);
            this.tabPage2.Controls.Add(this.prim_zev);
            this.tabPage2.Controls.Add(this.label105);
            this.tabPage2.Controls.Add(this.prim_dvijvsyst);
            this.tabPage2.Controls.Add(this.label103);
            this.tabPage2.Controls.Add(this.prim_kostmishrazv);
            this.tabPage2.Controls.Add(this.label102);
            this.tabPage2.Controls.Add(this.prim_okrasvidslisobol);
            this.tabPage2.Controls.Add(this.label100);
            this.tabPage2.Controls.Add(this.prim_vidslisobol);
            this.tabPage2.Controls.Add(this.label101);
            this.tabPage2.Controls.Add(this.prim_vlagtyrgor);
            this.tabPage2.Controls.Add(this.label98);
            this.tabPage2.Controls.Add(this.prim_tyrgor);
            this.tabPage2.Controls.Add(this.label99);
            this.tabPage2.Controls.Add(this.prim_kojokrask);
            this.tabPage2.Controls.Add(this.label97);
            this.tabPage2.Controls.Add(this.prim_kojpokr);
            this.tabPage2.Controls.Add(this.label96);
            this.tabPage2.Controls.Add(this.prim_teloslojprav);
            this.tabPage2.Controls.Add(this.label95);
            this.tabPage2.Controls.Add(this.prim_prostrivrema);
            this.tabPage2.Controls.Add(this.label94);
            this.tabPage2.Controls.Add(this.prim_emoclab);
            this.tabPage2.Controls.Add(this.label93);
            this.tabPage2.Controls.Add(this.prim_kontact);
            this.tabPage2.Controls.Add(this.label92);
            this.tabPage2.Controls.Add(this.prim_temptela);
            this.tabPage2.Controls.Add(this.prim_soznan);
            this.tabPage2.Controls.Add(this.label91);
            this.tabPage2.Controls.Add(this.label90);
            this.tabPage2.Controls.Add(this.prim_obhsost);
            this.tabPage2.Controls.Add(this.label89);
            this.tabPage2.Controls.Add(this.label88);
            this.tabPage2.Controls.Add(this.prim_anamnzabol);
            this.tabPage2.Controls.Add(this.label87);
            this.tabPage2.Controls.Add(this.prim_dvigact);
            this.tabPage2.Controls.Add(this.label86);
            this.tabPage2.Controls.Add(this.prim_pitanie);
            this.tabPage2.Controls.Add(this.label85);
            this.tabPage2.Controls.Add(this.prim_bityslov);
            this.tabPage2.Controls.Add(this.label84);
            this.tabPage2.Controls.Add(this.label83);
            this.tabPage2.Controls.Add(this.prim_profvred);
            this.tabPage2.Controls.Add(this.label82);
            this.tabPage2.Controls.Add(this.prim_vredprivich);
            this.tabPage2.Controls.Add(this.label81);
            this.tabPage2.Controls.Add(this.label80);
            this.tabPage2.Controls.Add(this.prim_kleshi);
            this.tabPage2.Controls.Add(this.label79);
            this.tabPage2.Controls.Add(this.prim_malaria);
            this.tabPage2.Controls.Add(this.label78);
            this.tabPage2.Controls.Add(this.prim_gepatit);
            this.tabPage2.Controls.Add(this.label77);
            this.tabPage2.Controls.Add(this.prim_venzab);
            this.tabPage2.Controls.Add(this.label75);
            this.tabPage2.Controls.Add(this.prim_tyber);
            this.tabPage2.Controls.Add(this.label76);
            this.tabPage2.Controls.Add(this.prim_korona);
            this.tabPage2.Controls.Add(this.label74);
            this.tabPage2.Controls.Add(this.prim_pnevmokok);
            this.tabPage2.Controls.Add(this.label73);
            this.tabPage2.Controls.Add(this.prim_grip);
            this.tabPage2.Controls.Add(this.label72);
            this.tabPage2.Controls.Add(this.prim_alerganamn);
            this.tabPage2.Controls.Add(this.label71);
            this.tabPage2.Controls.Add(this.label70);
            this.tabPage2.Controls.Add(this.prim_bolnichdney);
            this.tabPage2.Controls.Add(this.label69);
            this.tabPage2.Controls.Add(this.prim_listnetryd);
            this.tabPage2.Controls.Add(this.label68);
            this.tabPage2.Controls.Add(this.prim_pereosvinv);
            this.tabPage2.Controls.Add(this.label67);
            this.tabPage2.Controls.Add(this.prim_dinaminv);
            this.tabPage2.Controls.Add(this.label66);
            this.tabPage2.Controls.Add(this.prim_inval);
            this.tabPage2.Controls.Add(this.label65);
            this.tabPage2.Controls.Add(this.prim_workstat);
            this.tabPage2.Controls.Add(this.label63);
            this.tabPage2.Controls.Add(this.label64);
            this.tabPage2.Controls.Add(this.prim_drygzabrods);
            this.tabPage2.Controls.Add(this.label62);
            this.tabPage2.Controls.Add(this.prim_onkpotrods);
            this.tabPage2.Controls.Add(this.label61);
            this.tabPage2.Controls.Add(this.prim_psorrods);
            this.tabPage2.Controls.Add(this.label59);
            this.tabPage2.Controls.Add(this.prim_revmzabrod);
            this.tabPage2.Controls.Add(this.label57);
            this.tabPage2.Controls.Add(this.prim_invgr);
            this.tabPage2.Controls.Add(this.label60);
            this.tabPage2.Controls.Add(this.label58);
            this.tabPage2.Controls.Add(this.label56);
            this.tabPage2.Controls.Add(this.label54);
            this.tabPage2.Controls.Add(this.prim_vash);
            this.tabPage2.Controls.Add(this.label55);
            this.tabPage2.Controls.Add(this.prim_deform);
            this.tabPage2.Controls.Add(this.label53);
            this.tabPage2.Controls.Add(this.prim_chbs);
            this.tabPage2.Controls.Add(this.label52);
            this.tabPage2.Controls.Add(this.prim_chps);
            this.tabPage2.Controls.Add(this.label51);
            this.tabPage2.Controls.Add(this.label49);
            this.tabPage2.Controls.Add(this.prim_ytrenskov);
            this.tabPage2.Controls.Add(this.label50);
            this.tabPage2.Controls.Add(this.prim_gepatomealg);
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.prim_izmslisobol);
            this.tabPage2.Controls.Add(this.label47);
            this.tabPage2.Controls.Add(this.prim_vnesysproj);
            this.tabPage2.Controls.Add(this.label46);
            this.tabPage2.Controls.Add(this.prim_tynsyndr);
            this.tabPage2.Controls.Add(this.label45);
            this.tabPage2.Controls.Add(this.prim_porokoltkan);
            this.tabPage2.Controls.Add(this.label44);
            this.tabPage2.Controls.Add(this.prim_spovtela);
            this.tabPage2.Controls.Add(this.label43);
            this.tabPage2.Controls.Add(this.label41);
            this.tabPage2.Controls.Add(this.prim_indmasstela);
            this.tabPage2.Controls.Add(this.label42);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.prim_rost);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.prim_ves);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.prim_telosloj);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.prim_zatrpriglot);
            this.tabPage2.Controls.Add(this.prim_chyvstrykholod);
            this.tabPage2.Controls.Add(this.prim_syhkojslis);
            this.tabPage2.Controls.Add(this.prim_visnasliz);
            this.tabPage2.Controls.Add(this.prim_izmmastel);
            this.tabPage2.Controls.Add(this.prim_slab);
            this.tabPage2.Controls.Add(this.prim_povtemp);
            this.tabPage2.Controls.Add(this.prim_utrskov);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.prim_oteksys);
            this.tabPage2.Controls.Add(this.prim_bolvsys);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(948, 903);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Прием";
            // 
            // epizod
            // 
            this.epizod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.epizod.Location = new System.Drawing.Point(164, 159);
            this.epizod.Mask = "00/00/0000";
            this.epizod.Name = "epizod";
            this.epizod.Size = new System.Drawing.Size(100, 26);
            this.epizod.TabIndex = 276;
            this.epizod.ValidatingType = typeof(System.DateTime);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.BackColor = System.Drawing.Color.Transparent;
            this.label114.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label114.Location = new System.Drawing.Point(75, 162);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(63, 19);
            this.label114.TabIndex = 277;
            this.label114.Text = "Эпизод:";
            // 
            // prim_jalob
            // 
            this.prim_jalob.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_jalob.Location = new System.Drawing.Point(78, 633);
            this.prim_jalob.Name = "prim_jalob";
            this.prim_jalob.Size = new System.Drawing.Size(670, 148);
            this.prim_jalob.TabIndex = 274;
            this.prim_jalob.Text = "";
            // 
            // prim_DateOfBirth
            // 
            this.prim_DateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_DateOfBirth.Location = new System.Drawing.Point(195, 319);
            this.prim_DateOfBirth.Mask = "00/00/0000";
            this.prim_DateOfBirth.Name = "prim_DateOfBirth";
            this.prim_DateOfBirth.Size = new System.Drawing.Size(112, 26);
            this.prim_DateOfBirth.TabIndex = 272;
            this.prim_DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label165
            // 
            this.label165.AutoSize = true;
            this.label165.BackColor = System.Drawing.Color.Transparent;
            this.label165.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label165.Location = new System.Drawing.Point(349, 1226);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(35, 19);
            this.label165.TabIndex = 271;
            this.label165.Text = "м^2";
            // 
            // prim_id
            // 
            this.prim_id.BackColor = System.Drawing.Color.White;
            this.prim_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_id.Location = new System.Drawing.Point(164, 191);
            this.prim_id.Name = "prim_id";
            this.prim_id.ReadOnly = true;
            this.prim_id.Size = new System.Drawing.Size(124, 26);
            this.prim_id.TabIndex = 270;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.BackColor = System.Drawing.Color.Transparent;
            this.label164.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label164.Location = new System.Drawing.Point(74, 195);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(54, 19);
            this.label164.TabIndex = 269;
            this.label164.Text = "№ И/б:";
            // 
            // prim_Name
            // 
            this.prim_Name.BackColor = System.Drawing.Color.White;
            this.prim_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_Name.Location = new System.Drawing.Point(164, 223);
            this.prim_Name.Name = "prim_Name";
            this.prim_Name.ReadOnly = true;
            this.prim_Name.Size = new System.Drawing.Size(273, 26);
            this.prim_Name.TabIndex = 268;
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.BackColor = System.Drawing.Color.Transparent;
            this.label163.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label163.Location = new System.Drawing.Point(74, 226);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(40, 19);
            this.label163.TabIndex = 267;
            this.label163.Text = "Имя:";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.BackColor = System.Drawing.Color.Transparent;
            this.label162.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label162.Location = new System.Drawing.Point(75, 349);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(150, 19);
            this.label162.TabIndex = 266;
            this.label162.Text = "Адрес регистрации:";
            // 
            // prim_Сountry
            // 
            this.prim_Сountry.BackColor = System.Drawing.Color.White;
            this.prim_Сountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_Сountry.Location = new System.Drawing.Point(164, 370);
            this.prim_Сountry.Name = "prim_Сountry";
            this.prim_Сountry.ReadOnly = true;
            this.prim_Сountry.Size = new System.Drawing.Size(273, 26);
            this.prim_Сountry.TabIndex = 19;
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.BackColor = System.Drawing.Color.Transparent;
            this.label156.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label156.Location = new System.Drawing.Point(281, 501);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(74, 19);
            this.label156.TabIndex = 30;
            this.label156.Text = "Квартира";
            // 
            // prim_LastName
            // 
            this.prim_LastName.BackColor = System.Drawing.Color.White;
            this.prim_LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_LastName.Location = new System.Drawing.Point(164, 255);
            this.prim_LastName.Name = "prim_LastName";
            this.prim_LastName.ReadOnly = true;
            this.prim_LastName.Size = new System.Drawing.Size(273, 26);
            this.prim_LastName.TabIndex = 265;
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.BackColor = System.Drawing.Color.Transparent;
            this.label157.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label157.Location = new System.Drawing.Point(75, 501);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(38, 19);
            this.label157.TabIndex = 29;
            this.label157.Text = "Дом";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.BackColor = System.Drawing.Color.Transparent;
            this.label155.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label155.Location = new System.Drawing.Point(74, 259);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(75, 19);
            this.label155.TabIndex = 264;
            this.label155.Text = "Фамилия:";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.BackColor = System.Drawing.Color.Transparent;
            this.label158.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label158.Location = new System.Drawing.Point(75, 469);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(51, 19);
            this.label158.TabIndex = 28;
            this.label158.Text = "Улица";
            // 
            // prim_MidName
            // 
            this.prim_MidName.BackColor = System.Drawing.Color.White;
            this.prim_MidName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_MidName.Location = new System.Drawing.Point(164, 287);
            this.prim_MidName.Name = "prim_MidName";
            this.prim_MidName.ReadOnly = true;
            this.prim_MidName.Size = new System.Drawing.Size(274, 26);
            this.prim_MidName.TabIndex = 263;
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.BackColor = System.Drawing.Color.Transparent;
            this.label159.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label159.Location = new System.Drawing.Point(74, 437);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(49, 19);
            this.label159.TabIndex = 26;
            this.label159.Text = "Город";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.BackColor = System.Drawing.Color.Transparent;
            this.label160.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label160.Location = new System.Drawing.Point(74, 405);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(51, 19);
            this.label160.TabIndex = 25;
            this.label160.Text = "Район";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.BackColor = System.Drawing.Color.Transparent;
            this.label154.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label154.Location = new System.Drawing.Point(74, 290);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(76, 19);
            this.label154.TabIndex = 262;
            this.label154.Text = "Отчество:";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.BackColor = System.Drawing.Color.Transparent;
            this.label161.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label161.Location = new System.Drawing.Point(74, 373);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(58, 19);
            this.label161.TabIndex = 24;
            this.label161.Text = "Страна";
            // 
            // prim_House
            // 
            this.prim_House.BackColor = System.Drawing.Color.White;
            this.prim_House.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_House.Location = new System.Drawing.Point(165, 498);
            this.prim_House.Name = "prim_House";
            this.prim_House.ReadOnly = true;
            this.prim_House.Size = new System.Drawing.Size(102, 26);
            this.prim_House.TabIndex = 14;
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.BackColor = System.Drawing.Color.Transparent;
            this.label153.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label153.Location = new System.Drawing.Point(74, 323);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(115, 19);
            this.label153.TabIndex = 260;
            this.label153.Text = "Дата рождения:";
            // 
            // prim_Apartment
            // 
            this.prim_Apartment.BackColor = System.Drawing.Color.White;
            this.prim_Apartment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_Apartment.Location = new System.Drawing.Point(361, 498);
            this.prim_Apartment.Name = "prim_Apartment";
            this.prim_Apartment.ReadOnly = true;
            this.prim_Apartment.Size = new System.Drawing.Size(77, 26);
            this.prim_Apartment.TabIndex = 13;
            // 
            // prim_Work
            // 
            this.prim_Work.BackColor = System.Drawing.Color.White;
            this.prim_Work.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_Work.Location = new System.Drawing.Point(189, 531);
            this.prim_Work.Name = "prim_Work";
            this.prim_Work.ReadOnly = true;
            this.prim_Work.Size = new System.Drawing.Size(559, 26);
            this.prim_Work.TabIndex = 259;
            // 
            // prim_Street
            // 
            this.prim_Street.BackColor = System.Drawing.Color.White;
            this.prim_Street.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_Street.Location = new System.Drawing.Point(164, 467);
            this.prim_Street.Name = "prim_Street";
            this.prim_Street.ReadOnly = true;
            this.prim_Street.Size = new System.Drawing.Size(273, 26);
            this.prim_Street.TabIndex = 9;
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.BackColor = System.Drawing.Color.Transparent;
            this.label152.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label152.Location = new System.Drawing.Point(75, 533);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(108, 19);
            this.label152.TabIndex = 258;
            this.label152.Text = "Место работы:";
            // 
            // prim_City
            // 
            this.prim_City.BackColor = System.Drawing.Color.White;
            this.prim_City.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_City.Location = new System.Drawing.Point(164, 434);
            this.prim_City.Name = "prim_City";
            this.prim_City.ReadOnly = true;
            this.prim_City.Size = new System.Drawing.Size(273, 26);
            this.prim_City.TabIndex = 11;
            // 
            // prim_District
            // 
            this.prim_District.BackColor = System.Drawing.Color.White;
            this.prim_District.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_District.Location = new System.Drawing.Point(165, 403);
            this.prim_District.Name = "prim_District";
            this.prim_District.ReadOnly = true;
            this.prim_District.Size = new System.Drawing.Size(273, 26);
            this.prim_District.TabIndex = 10;
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.BackColor = System.Drawing.Color.Transparent;
            this.label151.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label151.Location = new System.Drawing.Point(87, 4407);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(117, 19);
            this.label151.TabIndex = 256;
            this.label151.Text = "План лечения:";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.BackColor = System.Drawing.Color.Transparent;
            this.label150.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label150.Location = new System.Drawing.Point(87, 4219);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(156, 19);
            this.label150.TabIndex = 255;
            this.label150.Text = "План обследования:";
            // 
            // prim_planlecheni
            // 
            this.prim_planlecheni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_planlecheni.Location = new System.Drawing.Point(78, 4429);
            this.prim_planlecheni.Name = "prim_planlecheni";
            this.prim_planlecheni.Size = new System.Drawing.Size(670, 148);
            this.prim_planlecheni.TabIndex = 254;
            this.prim_planlecheni.Text = "";
            // 
            // prim_planobsledov
            // 
            this.prim_planobsledov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_planobsledov.Location = new System.Drawing.Point(78, 4241);
            this.prim_planobsledov.Name = "prim_planobsledov";
            this.prim_planobsledov.Size = new System.Drawing.Size(670, 148);
            this.prim_planobsledov.TabIndex = 253;
            this.prim_planobsledov.Text = "";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.BackColor = System.Drawing.Color.Transparent;
            this.label149.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label149.Location = new System.Drawing.Point(335, 4176);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(171, 23);
            this.label149.TabIndex = 252;
            this.label149.Text = "ПЛАН ВЕДЕНИЯ";
            // 
            // prim_predstavobolnom
            // 
            this.prim_predstavobolnom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_predstavobolnom.Location = new System.Drawing.Point(78, 4008);
            this.prim_predstavobolnom.Name = "prim_predstavobolnom";
            this.prim_predstavobolnom.Size = new System.Drawing.Size(670, 148);
            this.prim_predstavobolnom.TabIndex = 251;
            this.prim_predstavobolnom.Text = "";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.BackColor = System.Drawing.Color.Transparent;
            this.label148.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label148.Location = new System.Drawing.Point(259, 3972);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(318, 23);
            this.label148.TabIndex = 250;
            this.label148.Text = "ПРЕДСТАВЛЕНИЕ О БОЛЬНОМ";
            // 
            // prim_fiziologotprav
            // 
            this.prim_fiziologotprav.DisplayMember = "нет";
            this.prim_fiziologotprav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_fiziologotprav.FormattingEnabled = true;
            this.prim_fiziologotprav.Items.AddRange(new object[] {
            "в норме",
            "затруднены"});
            this.prim_fiziologotprav.Location = new System.Drawing.Point(304, 3929);
            this.prim_fiziologotprav.MaxDropDownItems = 2;
            this.prim_fiziologotprav.Name = "prim_fiziologotprav";
            this.prim_fiziologotprav.Size = new System.Drawing.Size(135, 27);
            this.prim_fiziologotprav.TabIndex = 249;
            this.prim_fiziologotprav.TabStop = false;
            this.prim_fiziologotprav.Text = "в норме";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.BackColor = System.Drawing.Color.Transparent;
            this.label147.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label147.Location = new System.Drawing.Point(74, 3932);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(224, 19);
            this.label147.TabIndex = 248;
            this.label147.Text = "Физиологические отправления:";
            // 
            // prim_simptpokolach
            // 
            this.prim_simptpokolach.DisplayMember = "нет";
            this.prim_simptpokolach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_simptpokolach.FormattingEnabled = true;
            this.prim_simptpokolach.Items.AddRange(new object[] {
            "отрицательный",
            "положительный"});
            this.prim_simptpokolach.Location = new System.Drawing.Point(352, 3896);
            this.prim_simptpokolach.MaxDropDownItems = 2;
            this.prim_simptpokolach.Name = "prim_simptpokolach";
            this.prim_simptpokolach.Size = new System.Drawing.Size(137, 27);
            this.prim_simptpokolach.TabIndex = 247;
            this.prim_simptpokolach.TabStop = false;
            this.prim_simptpokolach.Text = "отрицательный";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.BackColor = System.Drawing.Color.Transparent;
            this.label146.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label146.Location = new System.Drawing.Point(74, 3900);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(272, 19);
            this.label146.TabIndex = 246;
            this.label146.Text = "Симптом поколачивания по пояснице:";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.BackColor = System.Drawing.Color.Transparent;
            this.label145.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label145.Location = new System.Drawing.Point(74, 3866);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(195, 19);
            this.label145.TabIndex = 244;
            this.label145.Text = "Органы мочеиспускания:";
            // 
            // prim_selezenk
            // 
            this.prim_selezenk.DisplayMember = "нет";
            this.prim_selezenk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_selezenk.FormattingEnabled = true;
            this.prim_selezenk.Items.AddRange(new object[] {
            "не пальпируется",
            "пальпируется"});
            this.prim_selezenk.Location = new System.Drawing.Point(161, 3830);
            this.prim_selezenk.MaxDropDownItems = 2;
            this.prim_selezenk.Name = "prim_selezenk";
            this.prim_selezenk.Size = new System.Drawing.Size(155, 27);
            this.prim_selezenk.TabIndex = 243;
            this.prim_selezenk.TabStop = false;
            this.prim_selezenk.Text = "не пальпируется";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.BackColor = System.Drawing.Color.Transparent;
            this.label144.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label144.Location = new System.Drawing.Point(74, 3834);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(81, 19);
            this.label144.TabIndex = 242;
            this.label144.Text = "Селезенка:";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.BackColor = System.Drawing.Color.Transparent;
            this.label143.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label143.Location = new System.Drawing.Point(648, 3768);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(85, 19);
            this.label143.TabIndex = 241;
            this.label143.Text = "плотности.";
            // 
            // prim_plotnkrayreberdyg
            // 
            this.prim_plotnkrayreberdyg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_plotnkrayreberdyg.Location = new System.Drawing.Point(579, 3764);
            this.prim_plotnkrayreberdyg.Name = "prim_plotnkrayreberdyg";
            this.prim_plotnkrayreberdyg.Size = new System.Drawing.Size(63, 26);
            this.prim_plotnkrayreberdyg.TabIndex = 240;
            // 
            // prim_poverhpecheni
            // 
            this.prim_poverhpecheni.DisplayMember = "нет";
            this.prim_poverhpecheni.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_poverhpecheni.FormattingEnabled = true;
            this.prim_poverhpecheni.Items.AddRange(new object[] {
            "гладкая"});
            this.prim_poverhpecheni.Location = new System.Drawing.Point(232, 3797);
            this.prim_poverhpecheni.MaxDropDownItems = 2;
            this.prim_poverhpecheni.Name = "prim_poverhpecheni";
            this.prim_poverhpecheni.Size = new System.Drawing.Size(102, 27);
            this.prim_poverhpecheni.TabIndex = 239;
            this.prim_poverhpecheni.TabStop = false;
            this.prim_poverhpecheni.Text = "гладкая";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.BackColor = System.Drawing.Color.Transparent;
            this.label142.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label142.Location = new System.Drawing.Point(74, 3800);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(152, 19);
            this.label142.TabIndex = 238;
            this.label142.Text = "Поверхность печени:";
            // 
            // prim_krayreberdyg
            // 
            this.prim_krayreberdyg.DisplayMember = "нет";
            this.prim_krayreberdyg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_krayreberdyg.FormattingEnabled = true;
            this.prim_krayreberdyg.Items.AddRange(new object[] {
            "под краем реберной дуги"});
            this.prim_krayreberdyg.Location = new System.Drawing.Point(360, 3764);
            this.prim_krayreberdyg.MaxDropDownItems = 2;
            this.prim_krayreberdyg.Name = "prim_krayreberdyg";
            this.prim_krayreberdyg.Size = new System.Drawing.Size(209, 27);
            this.prim_krayreberdyg.TabIndex = 237;
            this.prim_krayreberdyg.TabStop = false;
            this.prim_krayreberdyg.Text = "под краем реберной дуги";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.BackColor = System.Drawing.Color.Transparent;
            this.label141.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label141.Location = new System.Drawing.Point(259, 3768);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(100, 19);
            this.label141.TabIndex = 236;
            this.label141.Text = "Край печени:";
            // 
            // prim_pechen
            // 
            this.prim_pechen.DisplayMember = "нет";
            this.prim_pechen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_pechen.FormattingEnabled = true;
            this.prim_pechen.Items.AddRange(new object[] {
            "не увеличена",
            "увеличена"});
            this.prim_pechen.Location = new System.Drawing.Point(141, 3764);
            this.prim_pechen.MaxDropDownItems = 2;
            this.prim_pechen.Name = "prim_pechen";
            this.prim_pechen.Size = new System.Drawing.Size(113, 27);
            this.prim_pechen.TabIndex = 235;
            this.prim_pechen.TabStop = false;
            this.prim_pechen.Text = "не увеличена";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.BackColor = System.Drawing.Color.Transparent;
            this.label140.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label140.Location = new System.Drawing.Point(74, 3768);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(61, 19);
            this.label140.TabIndex = 234;
            this.label140.Text = "Печень:";
            // 
            // prim_poperobodkish
            // 
            this.prim_poperobodkish.DisplayMember = "нет";
            this.prim_poperobodkish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_poperobodkish.FormattingEnabled = true;
            this.prim_poperobodkish.Items.AddRange(new object[] {
            "без особенностей"});
            this.prim_poperobodkish.Location = new System.Drawing.Point(548, 3731);
            this.prim_poperobodkish.MaxDropDownItems = 2;
            this.prim_poperobodkish.Name = "prim_poperobodkish";
            this.prim_poperobodkish.Size = new System.Drawing.Size(148, 27);
            this.prim_poperobodkish.TabIndex = 233;
            this.prim_poperobodkish.TabStop = false;
            this.prim_poperobodkish.Text = "без особенностей";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.BackColor = System.Drawing.Color.Transparent;
            this.label139.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label139.Location = new System.Drawing.Point(335, 3734);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(209, 19);
            this.label139.TabIndex = 232;
            this.label139.Text = "Поперечно-ободочная кишка:";
            // 
            // prim_slepkish
            // 
            this.prim_slepkish.DisplayMember = "нет";
            this.prim_slepkish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_slepkish.FormattingEnabled = true;
            this.prim_slepkish.Items.AddRange(new object[] {
            "без особенностей"});
            this.prim_slepkish.Location = new System.Drawing.Point(186, 3731);
            this.prim_slepkish.MaxDropDownItems = 2;
            this.prim_slepkish.Name = "prim_slepkish";
            this.prim_slepkish.Size = new System.Drawing.Size(148, 27);
            this.prim_slepkish.TabIndex = 231;
            this.prim_slepkish.TabStop = false;
            this.prim_slepkish.Text = "без особенностей";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.BackColor = System.Drawing.Color.Transparent;
            this.label138.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label138.Location = new System.Drawing.Point(74, 3734);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(106, 19);
            this.label138.TabIndex = 230;
            this.label138.Text = "Слепая кишка:";
            // 
            // prim_glybpalpackish
            // 
            this.prim_glybpalpackish.DisplayMember = "нет";
            this.prim_glybpalpackish.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_glybpalpackish.FormattingEnabled = true;
            this.prim_glybpalpackish.Items.AddRange(new object[] {
            "без особенностей"});
            this.prim_glybpalpackish.Location = new System.Drawing.Point(360, 3698);
            this.prim_glybpalpackish.MaxDropDownItems = 2;
            this.prim_glybpalpackish.Name = "prim_glybpalpackish";
            this.prim_glybpalpackish.Size = new System.Drawing.Size(148, 27);
            this.prim_glybpalpackish.TabIndex = 229;
            this.prim_glybpalpackish.TabStop = false;
            this.prim_glybpalpackish.Text = "без особенностей";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.BackColor = System.Drawing.Color.Transparent;
            this.label137.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label137.Location = new System.Drawing.Point(74, 3701);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(285, 19);
            this.label137.TabIndex = 228;
            this.label137.Text = "Глубокая пальпация сигмовидная кишка:";
            // 
            // prim_jivotpripalpac
            // 
            this.prim_jivotpripalpac.DisplayMember = "нет";
            this.prim_jivotpripalpac.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_jivotpripalpac.FormattingEnabled = true;
            this.prim_jivotpripalpac.Items.AddRange(new object[] {
            "безболезненный",
            "болезненный"});
            this.prim_jivotpripalpac.Location = new System.Drawing.Point(354, 3666);
            this.prim_jivotpripalpac.MaxDropDownItems = 2;
            this.prim_jivotpripalpac.Name = "prim_jivotpripalpac";
            this.prim_jivotpripalpac.Size = new System.Drawing.Size(135, 27);
            this.prim_jivotpripalpac.TabIndex = 227;
            this.prim_jivotpripalpac.TabStop = false;
            this.prim_jivotpripalpac.Text = "безболезненный";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.BackColor = System.Drawing.Color.Transparent;
            this.label136.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label136.Location = new System.Drawing.Point(74, 3668);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(274, 19);
            this.label136.TabIndex = 226;
            this.label136.Text = "Живот при поверхностной пальпации:";
            // 
            // prim_jziknal
            // 
            this.prim_jziknal.DisplayMember = "нет";
            this.prim_jziknal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_jziknal.FormattingEnabled = true;
            this.prim_jziknal.Items.AddRange(new object[] {
            "не обложен",
            "обложен"});
            this.prim_jziknal.Location = new System.Drawing.Point(187, 3632);
            this.prim_jziknal.MaxDropDownItems = 2;
            this.prim_jziknal.Name = "prim_jziknal";
            this.prim_jziknal.Size = new System.Drawing.Size(101, 27);
            this.prim_jziknal.TabIndex = 225;
            this.prim_jziknal.TabStop = false;
            this.prim_jziknal.Text = "не обложен";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.BackColor = System.Drawing.Color.Transparent;
            this.label135.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label135.Location = new System.Drawing.Point(74, 3635);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(107, 19);
            this.label135.TabIndex = 224;
            this.label135.Text = "Язык налетом:";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.BackColor = System.Drawing.Color.Transparent;
            this.label134.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label134.Location = new System.Drawing.Point(74, 3603);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(214, 19);
            this.label134.TabIndex = 222;
            this.label134.Text = "Пищеварительная система: ";
            // 
            // prim_shymdyhan
            // 
            this.prim_shymdyhan.DisplayMember = "нет";
            this.prim_shymdyhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_shymdyhan.FormattingEnabled = true;
            this.prim_shymdyhan.Items.AddRange(new object[] {
            "не выстушиваются",
            "выстушиваются"});
            this.prim_shymdyhan.Location = new System.Drawing.Point(227, 3567);
            this.prim_shymdyhan.MaxDropDownItems = 2;
            this.prim_shymdyhan.Name = "prim_shymdyhan";
            this.prim_shymdyhan.Size = new System.Drawing.Size(160, 27);
            this.prim_shymdyhan.TabIndex = 221;
            this.prim_shymdyhan.TabStop = false;
            this.prim_shymdyhan.Text = "не выстушиваются";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.BackColor = System.Drawing.Color.Transparent;
            this.label133.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label133.Location = new System.Drawing.Point(74, 3570);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(147, 19);
            this.label133.TabIndex = 220;
            this.label133.Text = "Дыхательные шумы:";
            // 
            // prim_dyhan
            // 
            this.prim_dyhan.DisplayMember = "нет";
            this.prim_dyhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_dyhan.FormattingEnabled = true;
            this.prim_dyhan.Items.AddRange(new object[] {
            "везикулярное",
            "жесткое"});
            this.prim_dyhan.Location = new System.Drawing.Point(430, 3535);
            this.prim_dyhan.MaxDropDownItems = 2;
            this.prim_dyhan.Name = "prim_dyhan";
            this.prim_dyhan.Size = new System.Drawing.Size(115, 27);
            this.prim_dyhan.TabIndex = 219;
            this.prim_dyhan.TabStop = false;
            this.prim_dyhan.Text = "везикулярное";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.BackColor = System.Drawing.Color.Transparent;
            this.label132.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label132.Location = new System.Drawing.Point(354, 3537);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(70, 19);
            this.label132.TabIndex = 218;
            this.label132.Text = "дыхание:";
            // 
            // prim_perkytor
            // 
            this.prim_perkytor.DisplayMember = "нет";
            this.prim_perkytor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_perkytor.FormattingEnabled = true;
            this.prim_perkytor.Items.AddRange(new object[] {
            "ясный легочный звук"});
            this.prim_perkytor.Location = new System.Drawing.Point(172, 3535);
            this.prim_perkytor.MaxDropDownItems = 2;
            this.prim_perkytor.Name = "prim_perkytor";
            this.prim_perkytor.Size = new System.Drawing.Size(176, 27);
            this.prim_perkytor.TabIndex = 217;
            this.prim_perkytor.TabStop = false;
            this.prim_perkytor.Text = "ясный легочный звук";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.BackColor = System.Drawing.Color.Transparent;
            this.label130.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label130.Location = new System.Drawing.Point(74, 3537);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(92, 19);
            this.label130.TabIndex = 216;
            this.label130.Text = "Перкуторно:";
            // 
            // prim_distchrip
            // 
            this.prim_distchrip.DisplayMember = "нет";
            this.prim_distchrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_distchrip.FormattingEnabled = true;
            this.prim_distchrip.Items.AddRange(new object[] {
            "не слышны",
            "слышны"});
            this.prim_distchrip.Location = new System.Drawing.Point(252, 3501);
            this.prim_distchrip.MaxDropDownItems = 2;
            this.prim_distchrip.Name = "prim_distchrip";
            this.prim_distchrip.Size = new System.Drawing.Size(107, 27);
            this.prim_distchrip.TabIndex = 215;
            this.prim_distchrip.TabStop = false;
            this.prim_distchrip.Text = "не слышны";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.BackColor = System.Drawing.Color.Transparent;
            this.label129.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label129.Location = new System.Drawing.Point(74, 3504);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(172, 19);
            this.label129.TabIndex = 214;
            this.label129.Text = "Дистанционные хрипы:";
            // 
            // prim_actdihmishc
            // 
            this.prim_actdihmishc.DisplayMember = "нет";
            this.prim_actdihmishc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_actdihmishc.FormattingEnabled = true;
            this.prim_actdihmishc.Items.AddRange(new object[] {
            "не участвуют",
            "участвуют"});
            this.prim_actdihmishc.Location = new System.Drawing.Point(371, 3469);
            this.prim_actdihmishc.MaxDropDownItems = 2;
            this.prim_actdihmishc.Name = "prim_actdihmishc";
            this.prim_actdihmishc.Size = new System.Drawing.Size(118, 27);
            this.prim_actdihmishc.TabIndex = 213;
            this.prim_actdihmishc.TabStop = false;
            this.prim_actdihmishc.Text = "не участвуют";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.BackColor = System.Drawing.Color.Transparent;
            this.label128.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label128.Location = new System.Drawing.Point(575, 3439);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(59, 19);
            this.label128.TabIndex = 212;
            this.label128.Text = "формы.";
            // 
            // prim_grydform
            // 
            this.prim_grydform.DisplayMember = "нет";
            this.prim_grydform.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_grydform.FormattingEnabled = true;
            this.prim_grydform.Items.AddRange(new object[] {
            "правильной",
            "не правильной"});
            this.prim_grydform.Location = new System.Drawing.Point(441, 3436);
            this.prim_grydform.MaxDropDownItems = 2;
            this.prim_grydform.Name = "prim_grydform";
            this.prim_grydform.Size = new System.Drawing.Size(128, 27);
            this.prim_grydform.TabIndex = 211;
            this.prim_grydform.TabStop = false;
            this.prim_grydform.Text = "правильной";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.BackColor = System.Drawing.Color.Transparent;
            this.label127.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label127.Location = new System.Drawing.Point(327, 3439);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(112, 19);
            this.label127.TabIndex = 210;
            this.label127.Text = "Грудная клетка:";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.BackColor = System.Drawing.Color.Transparent;
            this.label126.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label126.Location = new System.Drawing.Point(74, 3471);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(295, 19);
            this.label126.TabIndex = 208;
            this.label126.Text = "В акте дыхания вспомогательные мышцы:";
            // 
            // prim_chislodih
            // 
            this.prim_chislodih.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_chislodih.Location = new System.Drawing.Point(258, 3436);
            this.prim_chislodih.Name = "prim_chislodih";
            this.prim_chislodih.Size = new System.Drawing.Size(63, 26);
            this.prim_chislodih.TabIndex = 207;
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.BackColor = System.Drawing.Color.Transparent;
            this.label125.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label125.Location = new System.Drawing.Point(74, 3439);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(178, 19);
            this.label125.TabIndex = 206;
            this.label125.Text = "Число дыханий в 1 мин.:";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.BackColor = System.Drawing.Color.Transparent;
            this.label124.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label124.Location = new System.Drawing.Point(74, 3407);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(139, 19);
            this.label124.TabIndex = 204;
            this.label124.Text = "Органы дыхания:";
            // 
            // prim_shymserdc
            // 
            this.prim_shymserdc.DisplayMember = "нет";
            this.prim_shymserdc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_shymserdc.FormattingEnabled = true;
            this.prim_shymserdc.Items.AddRange(new object[] {
            "не определяется",
            "определяется"});
            this.prim_shymserdc.Location = new System.Drawing.Point(174, 3371);
            this.prim_shymserdc.MaxDropDownItems = 2;
            this.prim_shymserdc.Name = "prim_shymserdc";
            this.prim_shymserdc.Size = new System.Drawing.Size(143, 27);
            this.prim_shymserdc.TabIndex = 203;
            this.prim_shymserdc.TabStop = false;
            this.prim_shymserdc.Text = "не определяется";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.BackColor = System.Drawing.Color.Transparent;
            this.label123.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label123.Location = new System.Drawing.Point(74, 3374);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(94, 19);
            this.label123.TabIndex = 202;
            this.label123.Text = "Шум сердца:";
            // 
            // prim_tonserdc
            // 
            this.prim_tonserdc.DisplayMember = "нет";
            this.prim_tonserdc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_tonserdc.FormattingEnabled = true;
            this.prim_tonserdc.Items.AddRange(new object[] {
            "не приглушены",
            "приглушены"});
            this.prim_tonserdc.Location = new System.Drawing.Point(178, 3339);
            this.prim_tonserdc.MaxDropDownItems = 2;
            this.prim_tonserdc.Name = "prim_tonserdc";
            this.prim_tonserdc.Size = new System.Drawing.Size(143, 27);
            this.prim_tonserdc.TabIndex = 201;
            this.prim_tonserdc.TabStop = false;
            this.prim_tonserdc.Text = "не приглушены";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.BackColor = System.Drawing.Color.Transparent;
            this.label122.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label122.Location = new System.Drawing.Point(74, 3341);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(98, 19);
            this.label122.TabIndex = 200;
            this.label122.Text = "Тоны сердца:";
            // 
            // prim_shymbrahart
            // 
            this.prim_shymbrahart.DisplayMember = "нет";
            this.prim_shymbrahart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_shymbrahart.FormattingEnabled = true;
            this.prim_shymbrahart.Items.AddRange(new object[] {
            "не выслушивается",
            "выслушивается"});
            this.prim_shymbrahart.Location = new System.Drawing.Point(413, 3305);
            this.prim_shymbrahart.MaxDropDownItems = 2;
            this.prim_shymbrahart.Name = "prim_shymbrahart";
            this.prim_shymbrahart.Size = new System.Drawing.Size(156, 27);
            this.prim_shymbrahart.TabIndex = 199;
            this.prim_shymbrahart.TabStop = false;
            this.prim_shymbrahart.Text = "не выслушивается";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.BackColor = System.Drawing.Color.Transparent;
            this.label121.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label121.Location = new System.Drawing.Point(74, 3308);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(333, 19);
            this.label121.TabIndex = 198;
            this.label121.Text = "Шум над проекцией брахиоцефальных артерий:";
            // 
            // prim_pulsbedr
            // 
            this.prim_pulsbedr.DisplayMember = "нет";
            this.prim_pulsbedr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_pulsbedr.FormattingEnabled = true;
            this.prim_pulsbedr.Items.AddRange(new object[] {
            "отчетливые",
            "не отчетливые"});
            this.prim_pulsbedr.Location = new System.Drawing.Point(299, 3272);
            this.prim_pulsbedr.MaxDropDownItems = 2;
            this.prim_pulsbedr.Name = "prim_pulsbedr";
            this.prim_pulsbedr.Size = new System.Drawing.Size(143, 27);
            this.prim_pulsbedr.TabIndex = 197;
            this.prim_pulsbedr.TabStop = false;
            this.prim_pulsbedr.Text = "отчетливые";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.BackColor = System.Drawing.Color.Transparent;
            this.label120.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label120.Location = new System.Drawing.Point(74, 3276);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(219, 19);
            this.label120.TabIndex = 196;
            this.label120.Text = "Пульсации бедренных сосудов:";
            // 
            // prim_patologpyls
            // 
            this.prim_patologpyls.DisplayMember = "нет";
            this.prim_patologpyls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_patologpyls.FormattingEnabled = true;
            this.prim_patologpyls.Items.AddRange(new object[] {
            "не определяются",
            "определеяются"});
            this.prim_patologpyls.Location = new System.Drawing.Point(365, 3239);
            this.prim_patologpyls.MaxDropDownItems = 2;
            this.prim_patologpyls.Name = "prim_patologpyls";
            this.prim_patologpyls.Size = new System.Drawing.Size(143, 27);
            this.prim_patologpyls.TabIndex = 195;
            this.prim_patologpyls.TabStop = false;
            this.prim_patologpyls.Text = "не определяются";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.BackColor = System.Drawing.Color.Transparent;
            this.label119.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label119.Location = new System.Drawing.Point(74, 3242);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(285, 19);
            this.label119.TabIndex = 194;
            this.label119.Text = "При осмотре патологические пульсации:";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.BackColor = System.Drawing.Color.Transparent;
            this.label117.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label117.Location = new System.Drawing.Point(497, 3211);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(72, 19);
            this.label117.TabIndex = 193;
            this.label117.Text = "мм рт. ст.";
            this.label117.Visible = false;
            // 
            // prim_artdavl
            // 
            this.prim_artdavl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_artdavl.Location = new System.Drawing.Point(431, 3207);
            this.prim_artdavl.Name = "prim_artdavl";
            this.prim_artdavl.Size = new System.Drawing.Size(64, 26);
            this.prim_artdavl.TabIndex = 192;
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.BackColor = System.Drawing.Color.Transparent;
            this.label118.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label118.Location = new System.Drawing.Point(256, 3211);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(175, 19);
            this.label118.TabIndex = 191;
            this.label118.Text = "Артериальное давление:";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.BackColor = System.Drawing.Color.Transparent;
            this.label116.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label116.Location = new System.Drawing.Point(188, 3211);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(75, 19);
            this.label116.TabIndex = 190;
            this.label116.Text = "уд. в мин.";
            this.label116.Visible = false;
            // 
            // prim_chss
            // 
            this.prim_chss.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_chss.Location = new System.Drawing.Point(122, 3207);
            this.prim_chss.Name = "prim_chss";
            this.prim_chss.Size = new System.Drawing.Size(64, 26);
            this.prim_chss.TabIndex = 189;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.BackColor = System.Drawing.Color.Transparent;
            this.label115.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label115.Location = new System.Drawing.Point(74, 3211);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(44, 19);
            this.label115.TabIndex = 188;
            this.label115.Text = "ЧСС:";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.BackColor = System.Drawing.Color.Transparent;
            this.label113.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label113.Location = new System.Drawing.Point(74, 3146);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(228, 19);
            this.label113.TabIndex = 184;
            this.label113.Text = "Сердечно-сосудистая система:";
            // 
            // prim_razmshitovjel
            // 
            this.prim_razmshitovjel.DisplayMember = "нет";
            this.prim_razmshitovjel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_razmshitovjel.FormattingEnabled = true;
            this.prim_razmshitovjel.Items.AddRange(new object[] {
            "не увеличена",
            "увеличена"});
            this.prim_razmshitovjel.Location = new System.Drawing.Point(393, 3110);
            this.prim_razmshitovjel.MaxDropDownItems = 2;
            this.prim_razmshitovjel.Name = "prim_razmshitovjel";
            this.prim_razmshitovjel.Size = new System.Drawing.Size(115, 27);
            this.prim_razmshitovjel.TabIndex = 183;
            this.prim_razmshitovjel.TabStop = false;
            this.prim_razmshitovjel.Text = "не увеличена";
            // 
            // prim_shitovjel
            // 
            this.prim_shitovjel.DisplayMember = "нет";
            this.prim_shitovjel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_shitovjel.FormattingEnabled = true;
            this.prim_shitovjel.Items.AddRange(new object[] {
            "не пальпируется",
            "пальпируется"});
            this.prim_shitovjel.Location = new System.Drawing.Point(244, 3110);
            this.prim_shitovjel.MaxDropDownItems = 2;
            this.prim_shitovjel.Name = "prim_shitovjel";
            this.prim_shitovjel.Size = new System.Drawing.Size(143, 27);
            this.prim_shitovjel.TabIndex = 182;
            this.prim_shitovjel.TabStop = false;
            this.prim_shitovjel.Text = "не пальпируется";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.BackColor = System.Drawing.Color.Transparent;
            this.label112.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label112.Location = new System.Drawing.Point(74, 3113);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(164, 19);
            this.label112.TabIndex = 181;
            this.label112.Text = "Щитовидная железа:";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.BackColor = System.Drawing.Color.Transparent;
            this.label111.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label111.Location = new System.Drawing.Point(222, 3081);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(78, 19);
            this.label111.TabIndex = 180;
            this.label111.Text = "визуально";
            this.label111.Visible = false;
            // 
            // prim_palpatormolochjel
            // 
            this.prim_palpatormolochjel.DisplayMember = "нет";
            this.prim_palpatormolochjel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_palpatormolochjel.FormattingEnabled = true;
            this.prim_palpatormolochjel.Items.AddRange(new object[] {
            "без уплотнений",
            "с уплотнениями "});
            this.prim_palpatormolochjel.Location = new System.Drawing.Point(560, 3077);
            this.prim_palpatormolochjel.MaxDropDownItems = 2;
            this.prim_palpatormolochjel.Name = "prim_palpatormolochjel";
            this.prim_palpatormolochjel.Size = new System.Drawing.Size(136, 27);
            this.prim_palpatormolochjel.TabIndex = 179;
            this.prim_palpatormolochjel.TabStop = false;
            this.prim_palpatormolochjel.Text = "без уплотнений";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.BackColor = System.Drawing.Color.Transparent;
            this.label110.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label110.Location = new System.Drawing.Point(455, 3081);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(99, 19);
            this.label110.TabIndex = 178;
            this.label110.Text = "пальпаторно:";
            // 
            // prim_molochjel
            // 
            this.prim_molochjel.DisplayMember = "нет";
            this.prim_molochjel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_molochjel.FormattingEnabled = true;
            this.prim_molochjel.Items.AddRange(new object[] {
            "не изменены",
            "изменены"});
            this.prim_molochjel.Location = new System.Drawing.Point(306, 3077);
            this.prim_molochjel.MaxDropDownItems = 2;
            this.prim_molochjel.Name = "prim_molochjel";
            this.prim_molochjel.Size = new System.Drawing.Size(143, 27);
            this.prim_molochjel.TabIndex = 177;
            this.prim_molochjel.TabStop = false;
            this.prim_molochjel.Text = "не изменены";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.BackColor = System.Drawing.Color.Transparent;
            this.label109.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label109.Location = new System.Drawing.Point(74, 3081);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(154, 19);
            this.label109.TabIndex = 176;
            this.label109.Text = "Молочные железы:";
            // 
            // prim_mestoteki
            // 
            this.prim_mestoteki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_mestoteki.Location = new System.Drawing.Point(312, 3044);
            this.prim_mestoteki.Name = "prim_mestoteki";
            this.prim_mestoteki.Size = new System.Drawing.Size(436, 26);
            this.prim_mestoteki.TabIndex = 175;
            this.prim_mestoteki.Visible = false;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.BackColor = System.Drawing.Color.Transparent;
            this.label108.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label108.Location = new System.Drawing.Point(289, 3047);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(17, 19);
            this.label108.TabIndex = 172;
            this.label108.Text = "в";
            this.label108.Visible = false;
            // 
            // prim_oteki
            // 
            this.prim_oteki.DisplayMember = "нет";
            this.prim_oteki.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_oteki.FormattingEnabled = true;
            this.prim_oteki.Items.AddRange(new object[] {
            "не определяются",
            "определяются"});
            this.prim_oteki.Location = new System.Drawing.Point(140, 3044);
            this.prim_oteki.MaxDropDownItems = 2;
            this.prim_oteki.Name = "prim_oteki";
            this.prim_oteki.Size = new System.Drawing.Size(143, 27);
            this.prim_oteki.TabIndex = 171;
            this.prim_oteki.TabStop = false;
            this.prim_oteki.Text = "не определяются";
            this.prim_oteki.SelectedIndexChanged += new System.EventHandler(this.comboBox56_SelectedIndexChanged);
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.BackColor = System.Drawing.Color.Transparent;
            this.label107.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label107.Location = new System.Drawing.Point(74, 3047);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(60, 19);
            this.label107.TabIndex = 170;
            this.label107.Text = "Отеки:";
            // 
            // prim_pereferlimf
            // 
            this.prim_pereferlimf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_pereferlimf.Location = new System.Drawing.Point(306, 3012);
            this.prim_pereferlimf.Name = "prim_pereferlimf";
            this.prim_pereferlimf.Size = new System.Drawing.Size(442, 26);
            this.prim_pereferlimf.TabIndex = 169;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.BackColor = System.Drawing.Color.Transparent;
            this.label106.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label106.Location = new System.Drawing.Point(74, 3016);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(226, 19);
            this.label106.TabIndex = 168;
            this.label106.Text = "Периферические лимфоузлы:";
            // 
            // prim_mindal
            // 
            this.prim_mindal.DisplayMember = "нет";
            this.prim_mindal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_mindal.FormattingEnabled = true;
            this.prim_mindal.Items.AddRange(new object[] {
            "не увеличены",
            "увеличены"});
            this.prim_mindal.Location = new System.Drawing.Point(401, 2979);
            this.prim_mindal.MaxDropDownItems = 2;
            this.prim_mindal.Name = "prim_mindal";
            this.prim_mindal.Size = new System.Drawing.Size(124, 27);
            this.prim_mindal.TabIndex = 167;
            this.prim_mindal.TabStop = false;
            this.prim_mindal.Text = "не увеличены";
            // 
            // prim_okraszev
            // 
            this.prim_okraszev.DisplayMember = "нет";
            this.prim_okraszev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_okraszev.FormattingEnabled = true;
            this.prim_okraszev.Location = new System.Drawing.Point(178, 2979);
            this.prim_okraszev.MaxDropDownItems = 2;
            this.prim_okraszev.Name = "prim_okraszev";
            this.prim_okraszev.Size = new System.Drawing.Size(61, 27);
            this.prim_okraszev.TabIndex = 166;
            this.prim_okraszev.TabStop = false;
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.BackColor = System.Drawing.Color.Transparent;
            this.label104.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label104.Location = new System.Drawing.Point(245, 2982);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(150, 19);
            this.label104.TabIndex = 165;
            this.label104.Text = "окраски, миндалины";
            // 
            // prim_zev
            // 
            this.prim_zev.DisplayMember = "нет";
            this.prim_zev.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_zev.FormattingEnabled = true;
            this.prim_zev.Location = new System.Drawing.Point(111, 2979);
            this.prim_zev.MaxDropDownItems = 2;
            this.prim_zev.Name = "prim_zev";
            this.prim_zev.Size = new System.Drawing.Size(61, 27);
            this.prim_zev.TabIndex = 164;
            this.prim_zev.TabStop = false;
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.BackColor = System.Drawing.Color.Transparent;
            this.label105.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label105.Location = new System.Drawing.Point(74, 2982);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(35, 19);
            this.label105.TabIndex = 163;
            this.label105.Text = "Зев:";
            // 
            // prim_dvijvsyst
            // 
            this.prim_dvijvsyst.DisplayMember = "нет";
            this.prim_dvijvsyst.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_dvijvsyst.FormattingEnabled = true;
            this.prim_dvijvsyst.Location = new System.Drawing.Point(236, 2946);
            this.prim_dvijvsyst.MaxDropDownItems = 2;
            this.prim_dvijvsyst.Name = "prim_dvijvsyst";
            this.prim_dvijvsyst.Size = new System.Drawing.Size(61, 27);
            this.prim_dvijvsyst.TabIndex = 162;
            this.prim_dvijvsyst.TabStop = false;
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.Color.Transparent;
            this.label103.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label103.Location = new System.Drawing.Point(74, 2950);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(156, 19);
            this.label103.TabIndex = 161;
            this.label103.Text = "Движения в суставах:";
            // 
            // prim_kostmishrazv
            // 
            this.prim_kostmishrazv.DisplayMember = "нет";
            this.prim_kostmishrazv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_kostmishrazv.FormattingEnabled = true;
            this.prim_kostmishrazv.Location = new System.Drawing.Point(327, 2913);
            this.prim_kostmishrazv.MaxDropDownItems = 2;
            this.prim_kostmishrazv.Name = "prim_kostmishrazv";
            this.prim_kostmishrazv.Size = new System.Drawing.Size(61, 27);
            this.prim_kostmishrazv.TabIndex = 160;
            this.prim_kostmishrazv.TabStop = false;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.Color.Transparent;
            this.label102.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label102.Location = new System.Drawing.Point(74, 2916);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(251, 19);
            this.label102.TabIndex = 159;
            this.label102.Text = "Костно-мышечная система развита:";
            // 
            // prim_okrasvidslisobol
            // 
            this.prim_okrasvidslisobol.DisplayMember = "нет";
            this.prim_okrasvidslisobol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_okrasvidslisobol.FormattingEnabled = true;
            this.prim_okrasvidslisobol.Location = new System.Drawing.Point(360, 2880);
            this.prim_okrasvidslisobol.MaxDropDownItems = 2;
            this.prim_okrasvidslisobol.Name = "prim_okrasvidslisobol";
            this.prim_okrasvidslisobol.Size = new System.Drawing.Size(61, 27);
            this.prim_okrasvidslisobol.TabIndex = 158;
            this.prim_okrasvidslisobol.TabStop = false;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.BackColor = System.Drawing.Color.Transparent;
            this.label100.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label100.Location = new System.Drawing.Point(427, 2884);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(62, 19);
            this.label100.TabIndex = 157;
            this.label100.Text = "окраски";
            // 
            // prim_vidslisobol
            // 
            this.prim_vidslisobol.DisplayMember = "нет";
            this.prim_vidslisobol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_vidslisobol.FormattingEnabled = true;
            this.prim_vidslisobol.Location = new System.Drawing.Point(293, 2880);
            this.prim_vidslisobol.MaxDropDownItems = 2;
            this.prim_vidslisobol.Name = "prim_vidslisobol";
            this.prim_vidslisobol.Size = new System.Drawing.Size(61, 27);
            this.prim_vidslisobol.TabIndex = 156;
            this.prim_vidslisobol.TabStop = false;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.Color.Transparent;
            this.label101.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label101.Location = new System.Drawing.Point(74, 2884);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(219, 19);
            this.label101.TabIndex = 155;
            this.label101.Text = "Видимые слизистые оболочки:";
            // 
            // prim_vlagtyrgor
            // 
            this.prim_vlagtyrgor.DisplayMember = "нет";
            this.prim_vlagtyrgor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_vlagtyrgor.FormattingEnabled = true;
            this.prim_vlagtyrgor.Location = new System.Drawing.Point(198, 2847);
            this.prim_vlagtyrgor.MaxDropDownItems = 2;
            this.prim_vlagtyrgor.Name = "prim_vlagtyrgor";
            this.prim_vlagtyrgor.Size = new System.Drawing.Size(61, 27);
            this.prim_vlagtyrgor.TabIndex = 154;
            this.prim_vlagtyrgor.TabStop = false;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.BackColor = System.Drawing.Color.Transparent;
            this.label98.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label98.Location = new System.Drawing.Point(265, 2850);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(83, 19);
            this.label98.TabIndex = 153;
            this.label98.Text = "влажности";
            // 
            // prim_tyrgor
            // 
            this.prim_tyrgor.DisplayMember = "нет";
            this.prim_tyrgor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_tyrgor.FormattingEnabled = true;
            this.prim_tyrgor.Location = new System.Drawing.Point(131, 2847);
            this.prim_tyrgor.MaxDropDownItems = 2;
            this.prim_tyrgor.Name = "prim_tyrgor";
            this.prim_tyrgor.Size = new System.Drawing.Size(61, 27);
            this.prim_tyrgor.TabIndex = 152;
            this.prim_tyrgor.TabStop = false;
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.Color.Transparent;
            this.label99.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label99.Location = new System.Drawing.Point(74, 2850);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(57, 19);
            this.label99.TabIndex = 151;
            this.label99.Text = "Тургор:";
            // 
            // prim_kojokrask
            // 
            this.prim_kojokrask.DisplayMember = "нет";
            this.prim_kojokrask.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_kojokrask.FormattingEnabled = true;
            this.prim_kojokrask.Items.AddRange(new object[] {
            "физиологической",
            "не физиологической"});
            this.prim_kojokrask.Location = new System.Drawing.Point(289, 2814);
            this.prim_kojokrask.MaxDropDownItems = 2;
            this.prim_kojokrask.Name = "prim_kojokrask";
            this.prim_kojokrask.Size = new System.Drawing.Size(142, 27);
            this.prim_kojokrask.TabIndex = 150;
            this.prim_kojokrask.TabStop = false;
            this.prim_kojokrask.Text = "физиологической";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.BackColor = System.Drawing.Color.Transparent;
            this.label97.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label97.Location = new System.Drawing.Point(437, 2817);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(62, 19);
            this.label97.TabIndex = 149;
            this.label97.Text = "окраски";
            // 
            // prim_kojpokr
            // 
            this.prim_kojpokr.DisplayMember = "нет";
            this.prim_kojpokr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_kojpokr.FormattingEnabled = true;
            this.prim_kojpokr.Items.AddRange(new object[] {
            "чистые",
            "изменены"});
            this.prim_kojpokr.Location = new System.Drawing.Point(206, 2814);
            this.prim_kojpokr.MaxDropDownItems = 2;
            this.prim_kojpokr.Name = "prim_kojpokr";
            this.prim_kojpokr.Size = new System.Drawing.Size(77, 27);
            this.prim_kojpokr.TabIndex = 148;
            this.prim_kojpokr.TabStop = false;
            this.prim_kojpokr.Text = "чистые";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.BackColor = System.Drawing.Color.Transparent;
            this.label96.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label96.Location = new System.Drawing.Point(74, 2817);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(131, 19);
            this.label96.TabIndex = 147;
            this.label96.Text = "Кожные покровы:";
            // 
            // prim_teloslojprav
            // 
            this.prim_teloslojprav.DisplayMember = "нет";
            this.prim_teloslojprav.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_teloslojprav.FormattingEnabled = true;
            this.prim_teloslojprav.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_teloslojprav.Location = new System.Drawing.Point(273, 2782);
            this.prim_teloslojprav.MaxDropDownItems = 2;
            this.prim_teloslojprav.Name = "prim_teloslojprav";
            this.prim_teloslojprav.Size = new System.Drawing.Size(61, 27);
            this.prim_teloslojprav.TabIndex = 145;
            this.prim_teloslojprav.TabStop = false;
            this.prim_teloslojprav.Text = "да";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.BackColor = System.Drawing.Color.Transparent;
            this.label95.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label95.Location = new System.Drawing.Point(74, 2784);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(193, 19);
            this.label95.TabIndex = 144;
            this.label95.Text = "Телосложение правильное:";
            // 
            // prim_prostrivrema
            // 
            this.prim_prostrivrema.DisplayMember = "нет";
            this.prim_prostrivrema.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_prostrivrema.FormattingEnabled = true;
            this.prim_prostrivrema.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_prostrivrema.Location = new System.Drawing.Point(395, 2748);
            this.prim_prostrivrema.MaxDropDownItems = 2;
            this.prim_prostrivrema.Name = "prim_prostrivrema";
            this.prim_prostrivrema.Size = new System.Drawing.Size(61, 27);
            this.prim_prostrivrema.TabIndex = 143;
            this.prim_prostrivrema.TabStop = false;
            this.prim_prostrivrema.Text = "да";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.BackColor = System.Drawing.Color.Transparent;
            this.label94.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label94.Location = new System.Drawing.Point(74, 2751);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(315, 19);
            this.label94.TabIndex = 142;
            this.label94.Text = "В пространстве и времени ориентирован (а):";
            // 
            // prim_emoclab
            // 
            this.prim_emoclab.DisplayMember = "нет";
            this.prim_emoclab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_emoclab.FormattingEnabled = true;
            this.prim_emoclab.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_emoclab.Location = new System.Drawing.Point(362, 2716);
            this.prim_emoclab.MaxDropDownItems = 2;
            this.prim_emoclab.Name = "prim_emoclab";
            this.prim_emoclab.Size = new System.Drawing.Size(61, 27);
            this.prim_emoclab.TabIndex = 141;
            this.prim_emoclab.TabStop = false;
            this.prim_emoclab.Text = "нет";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.Transparent;
            this.label93.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label93.Location = new System.Drawing.Point(74, 2718);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(282, 19);
            this.label93.TabIndex = 140;
            this.label93.Text = "Эмоциональная лабильность выражена:";
            // 
            // prim_kontact
            // 
            this.prim_kontact.DisplayMember = "нет";
            this.prim_kontact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_kontact.FormattingEnabled = true;
            this.prim_kontact.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_kontact.Location = new System.Drawing.Point(256, 2682);
            this.prim_kontact.MaxDropDownItems = 2;
            this.prim_kontact.Name = "prim_kontact";
            this.prim_kontact.Size = new System.Drawing.Size(61, 27);
            this.prim_kontact.TabIndex = 139;
            this.prim_kontact.TabStop = false;
            this.prim_kontact.Text = "да";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.Color.Transparent;
            this.label92.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label92.Location = new System.Drawing.Point(74, 2685);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(179, 19);
            this.label92.TabIndex = 138;
            this.label92.Text = "В контакт вступает легко:";
            // 
            // prim_temptela
            // 
            this.prim_temptela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_temptela.Location = new System.Drawing.Point(210, 2616);
            this.prim_temptela.Name = "prim_temptela";
            this.prim_temptela.Size = new System.Drawing.Size(67, 26);
            this.prim_temptela.TabIndex = 137;
            // 
            // prim_soznan
            // 
            this.prim_soznan.DisplayMember = "нет";
            this.prim_soznan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_soznan.FormattingEnabled = true;
            this.prim_soznan.Items.AddRange(new object[] {
            "ясное",
            "неясное",
            "ступор",
            "отупление",
            "кома",
            "бред",
            "галлюцинации"});
            this.prim_soznan.Location = new System.Drawing.Point(210, 2650);
            this.prim_soznan.MaxDropDownItems = 2;
            this.prim_soznan.Name = "prim_soznan";
            this.prim_soznan.Size = new System.Drawing.Size(135, 27);
            this.prim_soznan.TabIndex = 136;
            this.prim_soznan.TabStop = false;
            this.prim_soznan.Text = "ясное";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.Color.Transparent;
            this.label91.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label91.Location = new System.Drawing.Point(74, 2652);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(78, 19);
            this.label91.TabIndex = 135;
            this.label91.Text = "Сознание:";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.Color.Transparent;
            this.label90.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label90.Location = new System.Drawing.Point(74, 2619);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(130, 19);
            this.label90.TabIndex = 133;
            this.label90.Text = "Температура тела:";
            // 
            // prim_obhsost
            // 
            this.prim_obhsost.DisplayMember = "нет";
            this.prim_obhsost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_obhsost.FormattingEnabled = true;
            this.prim_obhsost.Items.AddRange(new object[] {
            "удовлетворительное",
            "средней тяжести",
            "тяжелое"});
            this.prim_obhsost.Location = new System.Drawing.Point(210, 2583);
            this.prim_obhsost.MaxDropDownItems = 2;
            this.prim_obhsost.Name = "prim_obhsost";
            this.prim_obhsost.Size = new System.Drawing.Size(178, 27);
            this.prim_obhsost.TabIndex = 132;
            this.prim_obhsost.TabStop = false;
            this.prim_obhsost.Text = "удовлетворительное";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.Color.Transparent;
            this.label89.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label89.Location = new System.Drawing.Point(74, 2587);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(130, 19);
            this.label89.TabIndex = 131;
            this.label89.Text = "Общее состояние:";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label88.Location = new System.Drawing.Point(324, 2557);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(184, 23);
            this.label88.TabIndex = 130;
            this.label88.Text = "ОБЩИЙ ОСМОТР";
            // 
            // prim_anamnzabol
            // 
            this.prim_anamnzabol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_anamnzabol.Location = new System.Drawing.Point(78, 2392);
            this.prim_anamnzabol.Name = "prim_anamnzabol";
            this.prim_anamnzabol.Size = new System.Drawing.Size(670, 148);
            this.prim_anamnzabol.TabIndex = 129;
            this.prim_anamnzabol.Text = "";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.Color.Transparent;
            this.label87.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label87.Location = new System.Drawing.Point(297, 2357);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(266, 23);
            this.label87.TabIndex = 128;
            this.label87.Text = "АНАМНЕЗ ЗАБОЛЕВАНИЯ";
            // 
            // prim_dvigact
            // 
            this.prim_dvigact.DisplayMember = "нет";
            this.prim_dvigact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_dvigact.FormattingEnabled = true;
            this.prim_dvigact.Items.AddRange(new object[] {
            "достаточная",
            "недостаточная"});
            this.prim_dvigact.Location = new System.Drawing.Point(265, 2305);
            this.prim_dvigact.MaxDropDownItems = 2;
            this.prim_dvigact.Name = "prim_dvigact";
            this.prim_dvigact.Size = new System.Drawing.Size(144, 27);
            this.prim_dvigact.TabIndex = 127;
            this.prim_dvigact.TabStop = false;
            this.prim_dvigact.Text = "достаточная";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.Transparent;
            this.label86.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label86.Location = new System.Drawing.Point(74, 2308);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(185, 19);
            this.label86.TabIndex = 126;
            this.label86.Text = "Двигательная активность:";
            // 
            // prim_pitanie
            // 
            this.prim_pitanie.DisplayMember = "нет";
            this.prim_pitanie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_pitanie.FormattingEnabled = true;
            this.prim_pitanie.Items.AddRange(new object[] {
            "достаточное",
            "недостаточное",
            "повышенное"});
            this.prim_pitanie.Location = new System.Drawing.Point(151, 2273);
            this.prim_pitanie.MaxDropDownItems = 2;
            this.prim_pitanie.Name = "prim_pitanie";
            this.prim_pitanie.Size = new System.Drawing.Size(144, 27);
            this.prim_pitanie.TabIndex = 125;
            this.prim_pitanie.TabStop = false;
            this.prim_pitanie.Text = "достаточное";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.Color.Transparent;
            this.label85.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label85.Location = new System.Drawing.Point(74, 2275);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(71, 19);
            this.label85.TabIndex = 124;
            this.label85.Text = "Питание:";
            // 
            // prim_bityslov
            // 
            this.prim_bityslov.DisplayMember = "нет";
            this.prim_bityslov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_bityslov.FormattingEnabled = true;
            this.prim_bityslov.Items.AddRange(new object[] {
            "удовлетворительные",
            "неудовлетворительные"});
            this.prim_bityslov.Location = new System.Drawing.Point(211, 2239);
            this.prim_bityslov.MaxDropDownItems = 2;
            this.prim_bityslov.Name = "prim_bityslov";
            this.prim_bityslov.Size = new System.Drawing.Size(210, 27);
            this.prim_bityslov.TabIndex = 123;
            this.prim_bityslov.TabStop = false;
            this.prim_bityslov.Text = "удовлетворительные";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.Color.Transparent;
            this.label84.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label84.Location = new System.Drawing.Point(74, 2242);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(131, 19);
            this.label84.TabIndex = 122;
            this.label84.Text = "Бытовые условия:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label83.Location = new System.Drawing.Point(74, 2210);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(105, 19);
            this.label83.TabIndex = 120;
            this.label83.Text = "Образ жизни:";
            // 
            // prim_profvred
            // 
            this.prim_profvred.DisplayMember = "нет";
            this.prim_profvred.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_profvred.FormattingEnabled = true;
            this.prim_profvred.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_profvred.Location = new System.Drawing.Point(315, 2173);
            this.prim_profvred.MaxDropDownItems = 2;
            this.prim_profvred.Name = "prim_profvred";
            this.prim_profvred.Size = new System.Drawing.Size(61, 27);
            this.prim_profvred.TabIndex = 119;
            this.prim_profvred.TabStop = false;
            this.prim_profvred.Text = "нет";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.BackColor = System.Drawing.Color.Transparent;
            this.label82.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label82.Location = new System.Drawing.Point(74, 2176);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(235, 19);
            this.label82.TabIndex = 118;
            this.label82.Text = "Профессиональные вредности:";
            // 
            // prim_vredprivich
            // 
            this.prim_vredprivich.DisplayMember = "нет";
            this.prim_vredprivich.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_vredprivich.FormattingEnabled = true;
            this.prim_vredprivich.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_vredprivich.Location = new System.Drawing.Point(238, 2140);
            this.prim_vredprivich.MaxDropDownItems = 2;
            this.prim_vredprivich.Name = "prim_vredprivich";
            this.prim_vredprivich.Size = new System.Drawing.Size(61, 27);
            this.prim_vredprivich.TabIndex = 117;
            this.prim_vredprivich.TabStop = false;
            this.prim_vredprivich.Text = "нет";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label81.Location = new System.Drawing.Point(74, 2144);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(158, 19);
            this.label81.TabIndex = 116;
            this.label81.Text = "Вредные привычки:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.BackColor = System.Drawing.Color.Transparent;
            this.label80.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label80.Location = new System.Drawing.Point(355, 2110);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(104, 19);
            this.label80.TabIndex = 115;
            this.label80.Text = "укусы клещей:";
            // 
            // prim_kleshi
            // 
            this.prim_kleshi.DisplayMember = "нет";
            this.prim_kleshi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_kleshi.FormattingEnabled = true;
            this.prim_kleshi.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_kleshi.Location = new System.Drawing.Point(468, 2107);
            this.prim_kleshi.MaxDropDownItems = 2;
            this.prim_kleshi.Name = "prim_kleshi";
            this.prim_kleshi.Size = new System.Drawing.Size(61, 27);
            this.prim_kleshi.TabIndex = 114;
            this.prim_kleshi.TabStop = false;
            this.prim_kleshi.Text = "нет";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label79.Location = new System.Drawing.Point(210, 2110);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(68, 19);
            this.label79.TabIndex = 113;
            this.label79.Text = "малярия:";
            // 
            // prim_malaria
            // 
            this.prim_malaria.DisplayMember = "нет";
            this.prim_malaria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_malaria.FormattingEnabled = true;
            this.prim_malaria.Items.AddRange(new object[] {
            "нет",
            "есть"});
            this.prim_malaria.Location = new System.Drawing.Point(284, 2107);
            this.prim_malaria.MaxDropDownItems = 2;
            this.prim_malaria.Name = "prim_malaria";
            this.prim_malaria.Size = new System.Drawing.Size(61, 27);
            this.prim_malaria.TabIndex = 112;
            this.prim_malaria.TabStop = false;
            this.prim_malaria.Text = "нет";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label78.Location = new System.Drawing.Point(74, 2110);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(64, 19);
            this.label78.TabIndex = 111;
            this.label78.Text = "гепатит:";
            // 
            // prim_gepatit
            // 
            this.prim_gepatit.DisplayMember = "нет";
            this.prim_gepatit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_gepatit.FormattingEnabled = true;
            this.prim_gepatit.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_gepatit.Location = new System.Drawing.Point(141, 2107);
            this.prim_gepatit.MaxDropDownItems = 2;
            this.prim_gepatit.Name = "prim_gepatit";
            this.prim_gepatit.Size = new System.Drawing.Size(61, 27);
            this.prim_gepatit.TabIndex = 110;
            this.prim_gepatit.TabStop = false;
            this.prim_gepatit.Text = "нет";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label77.Location = new System.Drawing.Point(430, 2078);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(195, 19);
            this.label77.TabIndex = 109;
            this.label77.Text = "венирические заболевания:";
            // 
            // prim_venzab
            // 
            this.prim_venzab.DisplayMember = "нет";
            this.prim_venzab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_venzab.FormattingEnabled = true;
            this.prim_venzab.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_venzab.Location = new System.Drawing.Point(631, 2074);
            this.prim_venzab.MaxDropDownItems = 2;
            this.prim_venzab.Name = "prim_venzab";
            this.prim_venzab.Size = new System.Drawing.Size(61, 27);
            this.prim_venzab.TabIndex = 108;
            this.prim_venzab.TabStop = false;
            this.prim_venzab.Text = "нет";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.BackColor = System.Drawing.Color.Transparent;
            this.label75.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label75.Location = new System.Drawing.Point(280, 2078);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(83, 19);
            this.label75.TabIndex = 107;
            this.label75.Text = "туберкулез:";
            // 
            // prim_tyber
            // 
            this.prim_tyber.DisplayMember = "нет";
            this.prim_tyber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_tyber.FormattingEnabled = true;
            this.prim_tyber.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_tyber.Location = new System.Drawing.Point(366, 2074);
            this.prim_tyber.MaxDropDownItems = 2;
            this.prim_tyber.Name = "prim_tyber";
            this.prim_tyber.Size = new System.Drawing.Size(61, 27);
            this.prim_tyber.TabIndex = 106;
            this.prim_tyber.TabStop = false;
            this.prim_tyber.Text = "нет";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.BackColor = System.Drawing.Color.Transparent;
            this.label76.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label76.Location = new System.Drawing.Point(74, 2078);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(205, 19);
            this.label76.TabIndex = 105;
            this.label76.Text = "Инфекционные заболевания:";
            // 
            // prim_korona
            // 
            this.prim_korona.DisplayMember = "нет";
            this.prim_korona.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_korona.FormattingEnabled = true;
            this.prim_korona.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_korona.Location = new System.Drawing.Point(687, 2041);
            this.prim_korona.MaxDropDownItems = 2;
            this.prim_korona.Name = "prim_korona";
            this.prim_korona.Size = new System.Drawing.Size(61, 27);
            this.prim_korona.TabIndex = 102;
            this.prim_korona.TabStop = false;
            this.prim_korona.Text = "нет";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BackColor = System.Drawing.Color.Transparent;
            this.label74.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label74.Location = new System.Drawing.Point(587, 2044);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(97, 19);
            this.label74.TabIndex = 101;
            this.label74.Text = "коронавирус:";
            // 
            // prim_pnevmokok
            // 
            this.prim_pnevmokok.DisplayMember = "нет";
            this.prim_pnevmokok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_pnevmokok.FormattingEnabled = true;
            this.prim_pnevmokok.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_pnevmokok.Location = new System.Drawing.Point(521, 2041);
            this.prim_pnevmokok.MaxDropDownItems = 2;
            this.prim_pnevmokok.Name = "prim_pnevmokok";
            this.prim_pnevmokok.Size = new System.Drawing.Size(61, 27);
            this.prim_pnevmokok.TabIndex = 100;
            this.prim_pnevmokok.TabStop = false;
            this.prim_pnevmokok.Text = "нет";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label73.Location = new System.Drawing.Point(427, 2044);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(91, 19);
            this.label73.TabIndex = 99;
            this.label73.Text = "пневмококк:";
            // 
            // prim_grip
            // 
            this.prim_grip.DisplayMember = "нет";
            this.prim_grip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_grip.FormattingEnabled = true;
            this.prim_grip.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_grip.Location = new System.Drawing.Point(360, 2041);
            this.prim_grip.MaxDropDownItems = 2;
            this.prim_grip.Name = "prim_grip";
            this.prim_grip.Size = new System.Drawing.Size(61, 27);
            this.prim_grip.TabIndex = 98;
            this.prim_grip.TabStop = false;
            this.prim_grip.Text = "нет";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BackColor = System.Drawing.Color.Transparent;
            this.label72.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label72.Location = new System.Drawing.Point(304, 2044);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(53, 19);
            this.label72.TabIndex = 97;
            this.label72.Text = "грипп:";
            // 
            // prim_alerganamn
            // 
            this.prim_alerganamn.DisplayMember = "нет";
            this.prim_alerganamn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_alerganamn.FormattingEnabled = true;
            this.prim_alerganamn.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_alerganamn.Location = new System.Drawing.Point(301, 2009);
            this.prim_alerganamn.MaxDropDownItems = 2;
            this.prim_alerganamn.Name = "prim_alerganamn";
            this.prim_alerganamn.Size = new System.Drawing.Size(61, 27);
            this.prim_alerganamn.TabIndex = 96;
            this.prim_alerganamn.TabStop = false;
            this.prim_alerganamn.Text = "нет";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BackColor = System.Drawing.Color.Transparent;
            this.label71.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label71.Location = new System.Drawing.Point(74, 2044);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(234, 19);
            this.label71.TabIndex = 94;
            this.label71.Text = "Эпидемиологический анамнез:";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.Transparent;
            this.label70.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label70.Location = new System.Drawing.Point(74, 2013);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(221, 19);
            this.label70.TabIndex = 92;
            this.label70.Text = "Аллергологический анамнез:";
            // 
            // prim_bolnichdney
            // 
            this.prim_bolnichdney.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_bolnichdney.Location = new System.Drawing.Point(360, 1977);
            this.prim_bolnichdney.Name = "prim_bolnichdney";
            this.prim_bolnichdney.Size = new System.Drawing.Size(67, 26);
            this.prim_bolnichdney.TabIndex = 91;
            this.prim_bolnichdney.Text = "0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.Color.Transparent;
            this.label69.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label69.Location = new System.Drawing.Point(74, 1980);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(280, 19);
            this.label69.TabIndex = 90;
            this.label69.Text = "В текущем году больничный лист (дни):";
            // 
            // prim_listnetryd
            // 
            this.prim_listnetryd.DisplayMember = "нет";
            this.prim_listnetryd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_listnetryd.FormattingEnabled = true;
            this.prim_listnetryd.Items.AddRange(new object[] {
            "не нужен",
            "нужен"});
            this.prim_listnetryd.Location = new System.Drawing.Point(270, 1944);
            this.prim_listnetryd.MaxDropDownItems = 2;
            this.prim_listnetryd.Name = "prim_listnetryd";
            this.prim_listnetryd.Size = new System.Drawing.Size(98, 27);
            this.prim_listnetryd.TabIndex = 89;
            this.prim_listnetryd.TabStop = false;
            this.prim_listnetryd.Text = "не нужен";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.Color.Transparent;
            this.label68.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label68.Location = new System.Drawing.Point(74, 1948);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(190, 19);
            this.label68.TabIndex = 88;
            this.label68.Text = "Лист нетрудоспособности:";
            // 
            // prim_pereosvinv
            // 
            this.prim_pereosvinv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_pereosvinv.Location = new System.Drawing.Point(271, 1912);
            this.prim_pereosvinv.Name = "prim_pereosvinv";
            this.prim_pereosvinv.Size = new System.Drawing.Size(67, 26);
            this.prim_pereosvinv.TabIndex = 87;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Transparent;
            this.label67.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label67.Location = new System.Drawing.Point(74, 1915);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(191, 19);
            this.label67.TabIndex = 86;
            this.label67.Text = "Переосвидетельствование:";
            // 
            // prim_dinaminv
            // 
            this.prim_dinaminv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_dinaminv.Location = new System.Drawing.Point(327, 1880);
            this.prim_dinaminv.Name = "prim_dinaminv";
            this.prim_dinaminv.Size = new System.Drawing.Size(67, 26);
            this.prim_dinaminv.TabIndex = 85;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.Color.Transparent;
            this.label66.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label66.Location = new System.Drawing.Point(219, 1850);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(60, 19);
            this.label66.TabIndex = 84;
            this.label66.Text = "Группа:";
            // 
            // prim_inval
            // 
            this.prim_inval.DisplayMember = "нет";
            this.prim_inval.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_inval.FormattingEnabled = true;
            this.prim_inval.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_inval.Location = new System.Drawing.Point(152, 1847);
            this.prim_inval.MaxDropDownItems = 2;
            this.prim_inval.Name = "prim_inval";
            this.prim_inval.Size = new System.Drawing.Size(61, 27);
            this.prim_inval.TabIndex = 83;
            this.prim_inval.TabStop = false;
            this.prim_inval.Text = "нет";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.Color.Transparent;
            this.label65.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label65.Location = new System.Drawing.Point(74, 1850);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(72, 19);
            this.label65.TabIndex = 82;
            this.label65.Text = "Инвалид:";
            // 
            // prim_workstat
            // 
            this.prim_workstat.DisplayMember = "нет";
            this.prim_workstat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_workstat.FormattingEnabled = true;
            this.prim_workstat.Items.AddRange(new object[] {
            "работает",
            "не работает",
            "состоит на бирже труда",
            "пенсионер"});
            this.prim_workstat.Location = new System.Drawing.Point(138, 1814);
            this.prim_workstat.MaxDropDownItems = 2;
            this.prim_workstat.Name = "prim_workstat";
            this.prim_workstat.Size = new System.Drawing.Size(206, 27);
            this.prim_workstat.TabIndex = 81;
            this.prim_workstat.TabStop = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Transparent;
            this.label63.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label63.Location = new System.Drawing.Point(74, 1818);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(58, 19);
            this.label63.TabIndex = 80;
            this.label63.Text = "Статус:";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.Color.Transparent;
            this.label64.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label64.Location = new System.Drawing.Point(74, 1785);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(153, 19);
            this.label64.TabIndex = 79;
            this.label64.Text = "Страховой анамнез:";
            // 
            // prim_drygzabrods
            // 
            this.prim_drygzabrods.DisplayMember = "нет";
            this.prim_drygzabrods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_drygzabrods.FormattingEnabled = true;
            this.prim_drygzabrods.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_drygzabrods.Location = new System.Drawing.Point(407, 1751);
            this.prim_drygzabrods.MaxDropDownItems = 2;
            this.prim_drygzabrods.Name = "prim_drygzabrods";
            this.prim_drygzabrods.Size = new System.Drawing.Size(61, 27);
            this.prim_drygzabrods.TabIndex = 78;
            this.prim_drygzabrods.TabStop = false;
            this.prim_drygzabrods.Text = "нет";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.Transparent;
            this.label62.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label62.Location = new System.Drawing.Point(74, 1755);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(327, 19);
            this.label62.TabIndex = 77;
            this.label62.Text = "Другие заболевания у кровных родственников:";
            // 
            // prim_onkpotrods
            // 
            this.prim_onkpotrods.DisplayMember = "нет";
            this.prim_onkpotrods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_onkpotrods.FormattingEnabled = true;
            this.prim_onkpotrods.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_onkpotrods.Location = new System.Drawing.Point(374, 1718);
            this.prim_onkpotrods.MaxDropDownItems = 2;
            this.prim_onkpotrods.Name = "prim_onkpotrods";
            this.prim_onkpotrods.Size = new System.Drawing.Size(61, 27);
            this.prim_onkpotrods.TabIndex = 76;
            this.prim_onkpotrods.TabStop = false;
            this.prim_onkpotrods.Text = "нет";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label61.Location = new System.Drawing.Point(74, 1721);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(294, 19);
            this.label61.TabIndex = 75;
            this.label61.Text = "Онкопаталогия у кровных родственников:";
            // 
            // prim_psorrods
            // 
            this.prim_psorrods.DisplayMember = "нет";
            this.prim_psorrods.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_psorrods.FormattingEnabled = true;
            this.prim_psorrods.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_psorrods.Location = new System.Drawing.Point(327, 1685);
            this.prim_psorrods.MaxDropDownItems = 2;
            this.prim_psorrods.Name = "prim_psorrods";
            this.prim_psorrods.Size = new System.Drawing.Size(61, 27);
            this.prim_psorrods.TabIndex = 74;
            this.prim_psorrods.TabStop = false;
            this.prim_psorrods.Text = "нет";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label59.Location = new System.Drawing.Point(74, 1689);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(247, 19);
            this.label59.TabIndex = 73;
            this.label59.Text = "Псориаз у кровных родственников:";
            // 
            // prim_revmzabrod
            // 
            this.prim_revmzabrod.DisplayMember = "нет";
            this.prim_revmzabrod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_revmzabrod.FormattingEnabled = true;
            this.prim_revmzabrod.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_revmzabrod.Location = new System.Drawing.Point(432, 1652);
            this.prim_revmzabrod.MaxDropDownItems = 2;
            this.prim_revmzabrod.Name = "prim_revmzabrod";
            this.prim_revmzabrod.Size = new System.Drawing.Size(61, 27);
            this.prim_revmzabrod.TabIndex = 72;
            this.prim_revmzabrod.TabStop = false;
            this.prim_revmzabrod.Text = "нет";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label57.Location = new System.Drawing.Point(74, 1655);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(352, 19);
            this.label57.TabIndex = 71;
            this.label57.Text = "Ревматические болезни у кровных родственников:";
            // 
            // prim_invgr
            // 
            this.prim_invgr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_invgr.Location = new System.Drawing.Point(285, 1847);
            this.prim_invgr.Name = "prim_invgr";
            this.prim_invgr.Size = new System.Drawing.Size(67, 26);
            this.prim_invgr.TabIndex = 70;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label60.Location = new System.Drawing.Point(74, 1884);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(247, 19);
            this.label60.TabIndex = 69;
            this.label60.Text = "Динамика инвалидности по годам:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label58.Location = new System.Drawing.Point(74, 1624);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(147, 19);
            this.label58.TabIndex = 66;
            this.label58.Text = "Наследственность:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label56.Location = new System.Drawing.Point(317, 1585);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(190, 23);
            this.label56.TabIndex = 65;
            this.label56.Text = "АНАМНЕЗ ЖИЗНИ";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label54.Location = new System.Drawing.Point(200, 1551);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(29, 19);
            this.label54.TabIndex = 64;
            this.label54.Text = "мм";
            // 
            // prim_vash
            // 
            this.prim_vash.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_vash.Location = new System.Drawing.Point(127, 1548);
            this.prim_vash.Name = "prim_vash";
            this.prim_vash.Size = new System.Drawing.Size(67, 26);
            this.prim_vash.TabIndex = 63;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label55.Location = new System.Drawing.Point(74, 1551);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(47, 19);
            this.label55.TabIndex = 62;
            this.label55.Text = "ВАШ:";
            // 
            // prim_deform
            // 
            this.prim_deform.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.prim_deform.DisplayMember = "нет";
            this.prim_deform.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_deform.FormattingEnabled = true;
            this.prim_deform.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_deform.Location = new System.Drawing.Point(179, 1516);
            this.prim_deform.MaxDropDownItems = 2;
            this.prim_deform.Name = "prim_deform";
            this.prim_deform.Size = new System.Drawing.Size(61, 27);
            this.prim_deform.TabIndex = 61;
            this.prim_deform.TabStop = false;
            this.prim_deform.Text = "нет";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label53.Location = new System.Drawing.Point(74, 1520);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(99, 19);
            this.label53.TabIndex = 60;
            this.label53.Text = "Деформации:";
            // 
            // prim_chbs
            // 
            this.prim_chbs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_chbs.Location = new System.Drawing.Point(290, 1484);
            this.prim_chbs.Name = "prim_chbs";
            this.prim_chbs.Size = new System.Drawing.Size(67, 26);
            this.prim_chbs.TabIndex = 59;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label52.Location = new System.Drawing.Point(74, 1487);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(210, 19);
            this.label52.TabIndex = 58;
            this.label52.Text = "Число болезненных суставов:";
            // 
            // prim_chps
            // 
            this.prim_chps.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_chps.Location = new System.Drawing.Point(277, 1452);
            this.prim_chps.Name = "prim_chps";
            this.prim_chps.Size = new System.Drawing.Size(67, 26);
            this.prim_chps.TabIndex = 57;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label51.Location = new System.Drawing.Point(74, 1456);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(197, 19);
            this.label51.TabIndex = 56;
            this.label51.Text = "Число припухших суставов:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label49.Location = new System.Drawing.Point(317, 1423);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(41, 19);
            this.label49.TabIndex = 55;
            this.label49.Text = "мин.";
            // 
            // prim_ytrenskov
            // 
            this.prim_ytrenskov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_ytrenskov.Location = new System.Drawing.Point(244, 1420);
            this.prim_ytrenskov.Name = "prim_ytrenskov";
            this.prim_ytrenskov.Size = new System.Drawing.Size(67, 26);
            this.prim_ytrenskov.TabIndex = 54;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label50.Location = new System.Drawing.Point(74, 1423);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(164, 19);
            this.label50.TabIndex = 53;
            this.label50.Text = "Утренняя скованность:";
            // 
            // prim_gepatomealg
            // 
            this.prim_gepatomealg.DisplayMember = "нет";
            this.prim_gepatomealg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_gepatomealg.FormattingEnabled = true;
            this.prim_gepatomealg.Items.AddRange(new object[] {
            "нет",
            "есть"});
            this.prim_gepatomealg.Location = new System.Drawing.Point(192, 1387);
            this.prim_gepatomealg.MaxDropDownItems = 2;
            this.prim_gepatomealg.Name = "prim_gepatomealg";
            this.prim_gepatomealg.Size = new System.Drawing.Size(61, 27);
            this.prim_gepatomealg.TabIndex = 52;
            this.prim_gepatomealg.TabStop = false;
            this.prim_gepatomealg.Text = "нет";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label48.Location = new System.Drawing.Point(74, 1391);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(112, 19);
            this.label48.TabIndex = 51;
            this.label48.Text = "Гепатомегалия:";
            // 
            // prim_izmslisobol
            // 
            this.prim_izmslisobol.DisplayMember = "нет";
            this.prim_izmslisobol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_izmslisobol.FormattingEnabled = true;
            this.prim_izmslisobol.Items.AddRange(new object[] {
            "нет",
            "есть"});
            this.prim_izmslisobol.Location = new System.Drawing.Point(308, 1354);
            this.prim_izmslisobol.MaxDropDownItems = 2;
            this.prim_izmslisobol.Name = "prim_izmslisobol";
            this.prim_izmslisobol.Size = new System.Drawing.Size(61, 27);
            this.prim_izmslisobol.TabIndex = 50;
            this.prim_izmslisobol.TabStop = false;
            this.prim_izmslisobol.Text = "нет";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label47.Location = new System.Drawing.Point(74, 1357);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(228, 19);
            this.label47.TabIndex = 49;
            this.label47.Text = "Изменения слизистых оболочек:";
            // 
            // prim_vnesysproj
            // 
            this.prim_vnesysproj.DisplayMember = "нет";
            this.prim_vnesysproj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_vnesysproj.FormattingEnabled = true;
            this.prim_vnesysproj.Items.AddRange(new object[] {
            "нет",
            "есть"});
            this.prim_vnesysproj.Location = new System.Drawing.Point(360, 1321);
            this.prim_vnesysproj.MaxDropDownItems = 2;
            this.prim_vnesysproj.Name = "prim_vnesysproj";
            this.prim_vnesysproj.Size = new System.Drawing.Size(61, 27);
            this.prim_vnesysproj.TabIndex = 48;
            this.prim_vnesysproj.TabStop = false;
            this.prim_vnesysproj.Text = "нет";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label46.Location = new System.Drawing.Point(74, 1325);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(280, 19);
            this.label46.TabIndex = 47;
            this.label46.Text = "Внесуставные (системные) проявления:";
            // 
            // prim_tynsyndr
            // 
            this.prim_tynsyndr.DisplayMember = "нет";
            this.prim_tynsyndr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_tynsyndr.FormattingEnabled = true;
            this.prim_tynsyndr.Items.AddRange(new object[] {
            "нет",
            "есть"});
            this.prim_tynsyndr.Location = new System.Drawing.Point(248, 1288);
            this.prim_tynsyndr.MaxDropDownItems = 2;
            this.prim_tynsyndr.Name = "prim_tynsyndr";
            this.prim_tynsyndr.Size = new System.Drawing.Size(61, 27);
            this.prim_tynsyndr.TabIndex = 46;
            this.prim_tynsyndr.TabStop = false;
            this.prim_tynsyndr.Text = "нет";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label45.Location = new System.Drawing.Point(74, 1291);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(168, 19);
            this.label45.TabIndex = 45;
            this.label45.Text = "Туннельные синдромы:";
            // 
            // prim_porokoltkan
            // 
            this.prim_porokoltkan.DisplayMember = "нет";
            this.prim_porokoltkan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_porokoltkan.FormattingEnabled = true;
            this.prim_porokoltkan.Items.AddRange(new object[] {
            "нет",
            "есть"});
            this.prim_porokoltkan.Location = new System.Drawing.Point(571, 1255);
            this.prim_porokoltkan.MaxDropDownItems = 2;
            this.prim_porokoltkan.Name = "prim_porokoltkan";
            this.prim_porokoltkan.Size = new System.Drawing.Size(61, 27);
            this.prim_porokoltkan.TabIndex = 44;
            this.prim_porokoltkan.TabStop = false;
            this.prim_porokoltkan.Text = "нет";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label44.Location = new System.Drawing.Point(74, 1259);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(491, 19);
            this.label44.TabIndex = 43;
            this.label44.Text = "Поражения околосуставных мягких тканей, внесуставные проявления: ";
            // 
            // prim_spovtela
            // 
            this.prim_spovtela.BackColor = System.Drawing.Color.White;
            this.prim_spovtela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_spovtela.Location = new System.Drawing.Point(276, 1223);
            this.prim_spovtela.Name = "prim_spovtela";
            this.prim_spovtela.ReadOnly = true;
            this.prim_spovtela.Size = new System.Drawing.Size(67, 26);
            this.prim_spovtela.TabIndex = 42;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label43.Location = new System.Drawing.Point(74, 1226);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(196, 19);
            this.label43.TabIndex = 41;
            this.label43.Text = "Площадь поверхности тела:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(574, 1195);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(52, 19);
            this.label41.TabIndex = 40;
            this.label41.Text = "кг/м^2";
            // 
            // prim_indmasstela
            // 
            this.prim_indmasstela.BackColor = System.Drawing.Color.White;
            this.prim_indmasstela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_indmasstela.Location = new System.Drawing.Point(505, 1191);
            this.prim_indmasstela.Name = "prim_indmasstela";
            this.prim_indmasstela.ReadOnly = true;
            this.prim_indmasstela.Size = new System.Drawing.Size(67, 26);
            this.prim_indmasstela.TabIndex = 39;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label42.Location = new System.Drawing.Point(359, 1195);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(140, 19);
            this.label42.TabIndex = 38;
            this.label42.Text = "Индекс массы тела:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(331, 1195);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(26, 19);
            this.label39.TabIndex = 37;
            this.label39.Text = "см";
            // 
            // prim_rost
            // 
            this.prim_rost.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_rost.Location = new System.Drawing.Point(262, 1191);
            this.prim_rost.Name = "prim_rost";
            this.prim_rost.Size = new System.Drawing.Size(67, 26);
            this.prim_rost.TabIndex = 36;
            this.prim_rost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            this.prim_rost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyUp);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label40.Location = new System.Drawing.Point(213, 1195);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(43, 19);
            this.label40.TabIndex = 35;
            this.label40.Text = "Рост:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(185, 1195);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(22, 19);
            this.label38.TabIndex = 34;
            this.label38.Text = "кг";
            // 
            // prim_ves
            // 
            this.prim_ves.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_ves.Location = new System.Drawing.Point(116, 1191);
            this.prim_ves.Name = "prim_ves";
            this.prim_ves.Size = new System.Drawing.Size(67, 26);
            this.prim_ves.TabIndex = 33;
            this.prim_ves.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            this.prim_ves.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyUp);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(74, 1195);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(36, 19);
            this.label37.TabIndex = 32;
            this.label37.Text = "Вес:";
            // 
            // prim_telosloj
            // 
            this.prim_telosloj.DisplayMember = "нормостеническое";
            this.prim_telosloj.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_telosloj.FormattingEnabled = true;
            this.prim_telosloj.Items.AddRange(new object[] {
            "нормостеническое",
            "гиперстеническое",
            "астеническое"});
            this.prim_telosloj.Location = new System.Drawing.Point(189, 1158);
            this.prim_telosloj.MaxDropDownItems = 2;
            this.prim_telosloj.Name = "prim_telosloj";
            this.prim_telosloj.Size = new System.Drawing.Size(154, 27);
            this.prim_telosloj.TabIndex = 31;
            this.prim_telosloj.TabStop = false;
            this.prim_telosloj.Text = "нормостеническое";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(74, 1161);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 19);
            this.label36.TabIndex = 30;
            this.label36.Text = "Телосложение:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(223, 1129);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(337, 23);
            this.label35.TabIndex = 29;
            this.label35.Text = "РЕВМАТОЛОГИЧЕСКИЙ СТАТУС";
            // 
            // prim_zatrpriglot
            // 
            this.prim_zatrpriglot.DisplayMember = "нет";
            this.prim_zatrpriglot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_zatrpriglot.FormattingEnabled = true;
            this.prim_zatrpriglot.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_zatrpriglot.Location = new System.Drawing.Point(273, 1086);
            this.prim_zatrpriglot.MaxDropDownItems = 2;
            this.prim_zatrpriglot.Name = "prim_zatrpriglot";
            this.prim_zatrpriglot.Size = new System.Drawing.Size(61, 27);
            this.prim_zatrpriglot.TabIndex = 28;
            this.prim_zatrpriglot.TabStop = false;
            this.prim_zatrpriglot.Text = "нет";
            // 
            // prim_chyvstrykholod
            // 
            this.prim_chyvstrykholod.DisplayMember = "нет";
            this.prim_chyvstrykholod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_chyvstrykholod.FormattingEnabled = true;
            this.prim_chyvstrykholod.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_chyvstrykholod.Location = new System.Drawing.Point(420, 1053);
            this.prim_chyvstrykholod.MaxDropDownItems = 2;
            this.prim_chyvstrykholod.Name = "prim_chyvstrykholod";
            this.prim_chyvstrykholod.Size = new System.Drawing.Size(61, 27);
            this.prim_chyvstrykholod.TabIndex = 27;
            this.prim_chyvstrykholod.TabStop = false;
            this.prim_chyvstrykholod.Text = "нет";
            // 
            // prim_syhkojslis
            // 
            this.prim_syhkojslis.DisplayMember = "нет";
            this.prim_syhkojslis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_syhkojslis.FormattingEnabled = true;
            this.prim_syhkojslis.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_syhkojslis.Location = new System.Drawing.Point(339, 1020);
            this.prim_syhkojslis.MaxDropDownItems = 2;
            this.prim_syhkojslis.Name = "prim_syhkojslis";
            this.prim_syhkojslis.Size = new System.Drawing.Size(61, 27);
            this.prim_syhkojslis.TabIndex = 26;
            this.prim_syhkojslis.TabStop = false;
            this.prim_syhkojslis.Text = "нет";
            // 
            // prim_visnasliz
            // 
            this.prim_visnasliz.DisplayMember = "нет";
            this.prim_visnasliz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_visnasliz.FormattingEnabled = true;
            this.prim_visnasliz.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_visnasliz.Location = new System.Drawing.Point(307, 988);
            this.prim_visnasliz.MaxDropDownItems = 2;
            this.prim_visnasliz.Name = "prim_visnasliz";
            this.prim_visnasliz.Size = new System.Drawing.Size(61, 27);
            this.prim_visnasliz.TabIndex = 25;
            this.prim_visnasliz.TabStop = false;
            this.prim_visnasliz.Text = "нет";
            // 
            // prim_izmmastel
            // 
            this.prim_izmmastel.DisplayMember = "нет";
            this.prim_izmmastel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_izmmastel.FormattingEnabled = true;
            this.prim_izmmastel.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_izmmastel.Location = new System.Drawing.Point(246, 954);
            this.prim_izmmastel.MaxDropDownItems = 2;
            this.prim_izmmastel.Name = "prim_izmmastel";
            this.prim_izmmastel.Size = new System.Drawing.Size(61, 27);
            this.prim_izmmastel.TabIndex = 24;
            this.prim_izmmastel.TabStop = false;
            this.prim_izmmastel.Text = "нет";
            // 
            // prim_slab
            // 
            this.prim_slab.DisplayMember = "нет";
            this.prim_slab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_slab.FormattingEnabled = true;
            this.prim_slab.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_slab.Location = new System.Drawing.Point(155, 922);
            this.prim_slab.MaxDropDownItems = 2;
            this.prim_slab.Name = "prim_slab";
            this.prim_slab.Size = new System.Drawing.Size(61, 27);
            this.prim_slab.TabIndex = 23;
            this.prim_slab.TabStop = false;
            this.prim_slab.Text = "нет";
            // 
            // prim_povtemp
            // 
            this.prim_povtemp.DisplayMember = "нет";
            this.prim_povtemp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_povtemp.FormattingEnabled = true;
            this.prim_povtemp.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_povtemp.Location = new System.Drawing.Point(265, 888);
            this.prim_povtemp.MaxDropDownItems = 2;
            this.prim_povtemp.Name = "prim_povtemp";
            this.prim_povtemp.Size = new System.Drawing.Size(61, 27);
            this.prim_povtemp.TabIndex = 22;
            this.prim_povtemp.TabStop = false;
            this.prim_povtemp.Text = "нет";
            // 
            // prim_utrskov
            // 
            this.prim_utrskov.DisplayMember = "нет";
            this.prim_utrskov.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_utrskov.FormattingEnabled = true;
            this.prim_utrskov.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_utrskov.Location = new System.Drawing.Point(244, 856);
            this.prim_utrskov.MaxDropDownItems = 2;
            this.prim_utrskov.Name = "prim_utrskov";
            this.prim_utrskov.Size = new System.Drawing.Size(61, 27);
            this.prim_utrskov.TabIndex = 21;
            this.prim_utrskov.TabStop = false;
            this.prim_utrskov.Text = "нет";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(74, 990);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(227, 19);
            this.label34.TabIndex = 20;
            this.label34.Text = "Высыпания на коже, слизистых:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(74, 1023);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(259, 19);
            this.label33.TabIndex = 19;
            this.label33.Text = "Сухость кожи, слизистых (рот, глаза):";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(74, 1056);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(340, 19);
            this.label32.TabIndex = 18;
            this.label32.Text = "Чувствительность рук к холоду (синдром Рейно):";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(74, 1090);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(193, 19);
            this.label31.TabIndex = 17;
            this.label31.Text = "Затруднения при глотании:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(74, 924);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(75, 19);
            this.label30.TabIndex = 16;
            this.label30.Text = "Слабость:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(74, 957);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(166, 19);
            this.label29.TabIndex = 15;
            this.label29.Text = "Изменение массы тела:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(74, 891);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(185, 19);
            this.label28.TabIndex = 14;
            this.label28.Text = "Повышение температуры:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(74, 858);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 19);
            this.label27.TabIndex = 13;
            this.label27.Text = "Утренняя скованность:";
            // 
            // prim_oteksys
            // 
            this.prim_oteksys.DisplayMember = "нет";
            this.prim_oteksys.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_oteksys.FormattingEnabled = true;
            this.prim_oteksys.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_oteksys.Location = new System.Drawing.Point(227, 822);
            this.prim_oteksys.MaxDropDownItems = 2;
            this.prim_oteksys.Name = "prim_oteksys";
            this.prim_oteksys.Size = new System.Drawing.Size(61, 27);
            this.prim_oteksys.TabIndex = 11;
            this.prim_oteksys.TabStop = false;
            this.prim_oteksys.Text = "нет";
            // 
            // prim_bolvsys
            // 
            this.prim_bolvsys.BackColor = System.Drawing.Color.White;
            this.prim_bolvsys.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.prim_bolvsys.DisplayMember = "нет";
            this.prim_bolvsys.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prim_bolvsys.FormattingEnabled = true;
            this.prim_bolvsys.Items.AddRange(new object[] {
            "нет",
            "да"});
            this.prim_bolvsys.Location = new System.Drawing.Point(199, 789);
            this.prim_bolvsys.MaxDropDownItems = 2;
            this.prim_bolvsys.Name = "prim_bolvsys";
            this.prim_bolvsys.Size = new System.Drawing.Size(61, 27);
            this.prim_bolvsys.TabIndex = 10;
            this.prim_bolvsys.TabStop = false;
            this.prim_bolvsys.Text = "нет";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(74, 825);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(147, 19);
            this.label26.TabIndex = 8;
            this.label26.Text = "Отечность суставов:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(75, 611);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(144, 19);
            this.label25.TabIndex = 7;
            this.label25.Text = "На момент осмотра:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(74, 793);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(119, 19);
            this.label24.TabIndex = 6;
            this.label24.Text = "Боли в суставах:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(359, 575);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 23);
            this.label23.TabIndex = 5;
            this.label23.Text = "ЖАЛОБЫ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(31, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 4670);
            this.panel1.TabIndex = 278;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(286, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(201, 23);
            this.label22.TabIndex = 4;
            this.label22.Text = "ПРИЕМ ПАЦИЕНТА";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(527, 4587);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 44);
            this.button3.TabIndex = 257;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(59, 4592);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 44);
            this.button4.TabIndex = 275;
            this.button4.Text = "Обновить данные";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 8527);
            this.panel3.TabIndex = 279;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(948, 903);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Карточка пациента";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label166);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(31, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 850);
            this.panel2.TabIndex = 19;
            // 
            // label166
            // 
            this.label166.AutoSize = true;
            this.label166.BackColor = System.Drawing.Color.Transparent;
            this.label166.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label166.Location = new System.Drawing.Point(259, 23);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(242, 23);
            this.label166.TabIndex = 19;
            this.label166.Text = "КАРТОЧКА ПАЦИЕНТА";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(514, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 17;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(124, 779);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 18;
            this.button2.TabStop = false;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.ICD10_1);
            this.groupBox1.Controls.Add(this.ICD10);
            this.groupBox1.Controls.Add(this.Gender1);
            this.groupBox1.Controls.Add(this.PolisNum);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SNILS);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MainDisease);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.NamePolis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.Work);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.MidName);
            this.groupBox1.Controls.Add(this.k_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(148, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 707);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(273, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 36;
            this.label9.Text = "№ И/б:";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.Location = new System.Drawing.Point(333, 9);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(100, 26);
            this.id.TabIndex = 35;
            // 
            // ICD10_1
            // 
            this.ICD10_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ICD10_1.Location = new System.Drawing.Point(128, 645);
            this.ICD10_1.Name = "ICD10_1";
            this.ICD10_1.ReadOnly = true;
            this.ICD10_1.Size = new System.Drawing.Size(125, 26);
            this.ICD10_1.TabIndex = 19;
            // 
            // ICD10
            // 
            this.ICD10.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.patientBindingSource4, "ICD10", true));
            this.ICD10.DataSource = this.iCD10BindingSource;
            this.ICD10.DisplayMember = "ICD10";
            this.ICD10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ICD10.Location = new System.Drawing.Point(128, 644);
            this.ICD10.Name = "ICD10";
            this.ICD10.Size = new System.Drawing.Size(125, 27);
            this.ICD10.TabIndex = 27;
            this.ICD10.Visible = false;
            this.ICD10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ICD10_KeyPress);
            // 
            // Gender1
            // 
            this.Gender1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender1.Location = new System.Drawing.Point(160, 141);
            this.Gender1.Name = "Gender1";
            this.Gender1.ReadOnly = true;
            this.Gender1.Size = new System.Drawing.Size(147, 26);
            this.Gender1.TabIndex = 19;
            // 
            // PolisNum
            // 
            this.PolisNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolisNum.Location = new System.Drawing.Point(160, 366);
            this.PolisNum.Mask = "9999999999999999";
            this.PolisNum.Name = "PolisNum";
            this.PolisNum.ReadOnly = true;
            this.PolisNum.Size = new System.Drawing.Size(273, 26);
            this.PolisNum.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Country1);
            this.groupBox2.Controls.Add(this.Сountry);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.House);
            this.groupBox2.Controls.Add(this.Apartment);
            this.groupBox2.Controls.Add(this.Street);
            this.groupBox2.Controls.Add(this.City);
            this.groupBox2.Controls.Add(this.District);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 190);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // Country1
            // 
            this.Country1.Location = new System.Drawing.Point(95, 20);
            this.Country1.Name = "Country1";
            this.Country1.ReadOnly = true;
            this.Country1.Size = new System.Drawing.Size(273, 26);
            this.Country1.TabIndex = 19;
            // 
            // Сountry
            // 
            this.Сountry.BackColor = System.Drawing.Color.White;
            this.Сountry.Items.AddRange(new object[] {
            "Российская Федерация",
            "Абхазия",
            "Австралия",
            "Австрия",
            "Азербайджан",
            "Албания",
            "Алжир",
            "Ангола",
            "Андорра",
            "Антигуа и Барбуда",
            "Аргентина",
            "Армения",
            "Афганистан",
            "Багамские Острова",
            "Бангладеш",
            "Барбадос",
            "Бахрейн",
            "Белиз",
            "Белоруссия",
            "Бельгия",
            "Бенин",
            "Болгария",
            "Боливия",
            "Босния и Герцеговина",
            "Ботсвана",
            "Бразилия",
            "Бруней",
            "Буркина-Фасо",
            "Бурунди",
            "Бутан",
            "Вануату",
            "Ватикан",
            "Великобритания",
            "Венгрия",
            "Венесуэла",
            "Восточный Тимор",
            "Вьетнам",
            "Габон",
            "Гаити",
            "Гайана",
            "Гамбия",
            "Гана",
            "Гватемала",
            "Гвинея",
            "Гвинея-Бисау",
            "Германия\tБерлин",
            "Гондурас\tТегусигальпа",
            "Государство Палестина",
            "Гренада",
            "Греция",
            "Грузия",
            "Дания",
            "Джибути",
            "Доминика",
            "Доминиканская Республика",
            "ДР Конго",
            "Египет",
            "Замбия",
            "Зимбабве\t",
            "Израиль",
            "Индия",
            "Индонезия",
            "Иордания\t",
            "Ирак",
            "Иран",
            "Ирландия\t",
            "Исландия\t",
            "Испания",
            "Италия",
            "Йемен",
            "Кабо-Верде",
            "Казахстан",
            "Камбоджа",
            "Камерун",
            "Канада",
            "Катар",
            "Кения",
            "Кипр",
            "Киргизия",
            "Кирибати",
            "Китай",
            "КНДР",
            "Колумбия",
            "Коморские Острова\t",
            "Коста-Рика",
            "Кот-д\'Ивуар",
            "Куба",
            "Кувейт",
            "Лаос",
            "Латвия",
            "Лесото",
            "Либерия",
            "Ливан",
            "Ливия",
            "Литва",
            "Лихтенштейн",
            "Люксембург",
            "Маврикий",
            "Мавритания",
            "Мадагаскар",
            "Малави",
            "Малайзия",
            "Мали",
            "Мальдивские Острова",
            "Мальта",
            "Марокко",
            "Маршалловы Острова",
            "Мексика",
            "Мозамбик",
            "Молдавия",
            "Монако",
            "Монголия",
            "Мьянма",
            "Намибия",
            "Науру",
            "Непал",
            "Нигер",
            "Нигерия",
            "Нидерланды",
            "Никарагуа",
            "Новая Зеландия",
            "Норвегия",
            "ОАЭ",
            "Оман",
            "Пакистан",
            "Палау",
            "Панама",
            "Папуа - Новая Гвинея",
            "Парагвай",
            "Перу",
            "Польша",
            "Португалия",
            "Республика Конго",
            "Республика Корея",
            "Российская Федерация",
            "Руанда",
            "Румыния",
            "Сальвадор",
            "Самоа",
            "Сан-Марино",
            "Сан-Томе и Принсипи",
            "Саудовская Аравия",
            "Северная Македония",
            "Сейшельские Острова",
            "Сенегал",
            "Сент-Винсент и Гренадины",
            "Сент-Китс и Невис",
            "Сент-Люсия",
            "Сербия",
            "Сингапур",
            "Сирия",
            "Словакия",
            "Словения",
            "Соломоновы Острова",
            "Сомали",
            "Судан",
            "Суринам",
            "США",
            "Сьерра-Леоне",
            "Таджикистан",
            "Таиланд",
            "Танзания",
            "Того",
            "Тонга",
            "Тринидад и Тобаго",
            "Тувалу",
            "Тунис",
            "Туркмения",
            "Турция",
            "Уганда",
            "Узбекистан",
            "Украина",
            "Уругвай",
            "Федеративные Штаты Микронезии",
            "Фиджи",
            "Филиппины",
            "Финляндия",
            "Франция",
            "Хорватия",
            "ЦАР",
            "Чад",
            "Черногория",
            "Чехия",
            "Чили",
            "Швейцария",
            "Швеция",
            "Шри-Ланка",
            "Эквадор",
            "Экваториальная Гвинея",
            "Эритрея",
            "Эсватини",
            "Эстония",
            "Эфиопия",
            "ЮАР",
            "Южная Осетия",
            "Южный",
            "Ямайка",
            "Япония"});
            this.Сountry.Location = new System.Drawing.Point(95, 20);
            this.Сountry.Name = "Сountry";
            this.Сountry.Size = new System.Drawing.Size(273, 27);
            this.Сountry.TabIndex = 24;
            this.Сountry.Visible = false;
            this.Сountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Сountry_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(214, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 19);
            this.label18.TabIndex = 30;
            this.label18.Text = "Квартира";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 19);
            this.label17.TabIndex = 29;
            this.label17.Text = "Дом";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "Улица";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "Город";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Район";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Страна";
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(95, 154);
            this.House.Name = "House";
            this.House.ReadOnly = true;
            this.House.Size = new System.Drawing.Size(102, 26);
            this.House.TabIndex = 14;
            // 
            // Apartment
            // 
            this.Apartment.Location = new System.Drawing.Point(291, 154);
            this.Apartment.Name = "Apartment";
            this.Apartment.ReadOnly = true;
            this.Apartment.Size = new System.Drawing.Size(77, 26);
            this.Apartment.TabIndex = 13;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(95, 122);
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Size = new System.Drawing.Size(273, 26);
            this.Street.TabIndex = 9;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(95, 90);
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Size = new System.Drawing.Size(273, 26);
            this.City.TabIndex = 11;
            // 
            // District
            // 
            this.District.Location = new System.Drawing.Point(95, 56);
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Size = new System.Drawing.Size(273, 26);
            this.District.TabIndex = 10;
            // 
            // SNILS
            // 
            this.SNILS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNILS.Location = new System.Drawing.Point(160, 274);
            this.SNILS.Mask = "999-999-999 99";
            this.SNILS.Name = "SNILS";
            this.SNILS.ReadOnly = true;
            this.SNILS.Size = new System.Drawing.Size(273, 26);
            this.SNILS.TabIndex = 33;
            // 
            // Phone
            // 
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Phone.Location = new System.Drawing.Point(160, 240);
            this.Phone.Mask = "+7 (999) 00-00-000";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Size = new System.Drawing.Size(273, 26);
            this.Phone.TabIndex = 32;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirth.Location = new System.Drawing.Point(160, 171);
            this.DateOfBirth.Mask = "00/00/0000";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            this.DateOfBirth.Size = new System.Drawing.Size(147, 26);
            this.DateOfBirth.TabIndex = 31;
            this.DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 29;
            this.label10.Text = "Телефон";
            // 
            // MainDisease
            // 
            this.MainDisease.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDisease.Location = new System.Drawing.Point(6, 610);
            this.MainDisease.Name = "MainDisease";
            this.MainDisease.ReadOnly = true;
            this.MainDisease.Size = new System.Drawing.Size(427, 26);
            this.MainDisease.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(6, 647);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(116, 19);
            this.label19.TabIndex = 25;
            this.label19.Text = "Код по МКБ-10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 591);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "Основное заболевание";
            // 
            // NamePolis
            // 
            this.NamePolis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NamePolis.Location = new System.Drawing.Point(6, 331);
            this.NamePolis.Name = "NamePolis";
            this.NamePolis.ReadOnly = true;
            this.NamePolis.Size = new System.Drawing.Size(427, 26);
            this.NamePolis.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(368, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Наименование страховой медицинской организации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Полис ОМС №";
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.Gender.Location = new System.Drawing.Point(160, 141);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(147, 27);
            this.Gender.TabIndex = 15;
            this.Gender.Visible = false;
            this.Gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gender_KeyPress);
            // 
            // Work
            // 
            this.Work.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Work.Location = new System.Drawing.Point(160, 206);
            this.Work.Name = "Work";
            this.Work.ReadOnly = true;
            this.Work.Size = new System.Drawing.Size(273, 26);
            this.Work.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "СНИЛС";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(160, 77);
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Size = new System.Drawing.Size(273, 26);
            this.LastName.TabIndex = 8;
            // 
            // MidName
            // 
            this.MidName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MidName.Location = new System.Drawing.Point(160, 111);
            this.MidName.Name = "MidName";
            this.MidName.ReadOnly = true;
            this.MidName.Size = new System.Drawing.Size(273, 26);
            this.MidName.TabIndex = 11;
            // 
            // k_Name
            // 
            this.k_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_Name.Location = new System.Drawing.Point(160, 41);
            this.k_Name.Name = "k_Name";
            this.k_Name.ReadOnly = true;
            this.k_Name.Size = new System.Drawing.Size(273, 26);
            this.k_Name.TabIndex = 7;
            this.k_Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Место работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(308, 49);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(956, 936);
            this.tabControl1.TabIndex = 8;
            // 
            // avtor_fio
            // 
            this.avtor_fio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avtor_fio.BackColor = System.Drawing.Color.White;
            this.avtor_fio.Location = new System.Drawing.Point(1019, 27);
            this.avtor_fio.Name = "avtor_fio";
            this.avtor_fio.ReadOnly = true;
            this.avtor_fio.ShortcutsEnabled = false;
            this.avtor_fio.Size = new System.Drawing.Size(230, 20);
            this.avtor_fio.TabIndex = 9;
            this.avtor_fio.TabStop = false;
            // 
            // label131
            // 
            this.label131.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label131.AutoSize = true;
            this.label131.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label131.Location = new System.Drawing.Point(1019, 8);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(34, 13);
            this.label131.TabIndex = 10;
            this.label131.Text = "Врач-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1264, 981);
            this.Controls.Add(this.label131);
            this.Controls.Add(this.avtor_fio);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "МИС - медицинская информационная система";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCD10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analizeTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analizeTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obshiyAnalizyKroviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mISDataSetBindingSource;
        private MISDataSet mISDataSet;
       
        private System.Windows.Forms.BindingSource patientBindingSource;
        private MISDataSet2 mISDataSet2;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private MISDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem анализыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАнализыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийАнализКровиToolStripMenuItem;
        private MISDataSet4 mISDataSet4;
        private System.Windows.Forms.BindingSource analizeTypeBindingSource;
        private MISDataSet4TableAdapters.AnalizeTypeTableAdapter analizeTypeTableAdapter;
        private System.Windows.Forms.BindingSource obshiyAnalizyKroviBindingSource;
        private MISDataSet4TableAdapters.ObshiyAnalizyKroviTableAdapter obshiyAnalizyKroviTableAdapter;
        private System.Windows.Forms.BindingSource analizeTypeBindingSource1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.BindingSource hospitalizationBindingSource;
        private MISDataSet4TableAdapters.HospitalizationTableAdapter hospitalizationTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private MISDataSet4TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource patientBindingSource4;
        private System.Windows.Forms.BindingSource patientBindingSource5;
        private System.Windows.Forms.BindingSource patientBindingSource3;
        private System.Windows.Forms.BindingSource iCD10BindingSource;
        private MISDataSetTableAdapters.ICD10TableAdapter iCD10TableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox AnalysisType;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox DateOfAnalysis;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox ICD10_1;
        private System.Windows.Forms.TextBox Gender1;
        private System.Windows.Forms.MaskedTextBox PolisNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Country1;
        private System.Windows.Forms.ComboBox Сountry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox House;
        private System.Windows.Forms.TextBox Apartment;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox District;
        private System.Windows.Forms.MaskedTextBox SNILS;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.MaskedTextBox DateOfBirth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ICD10;
        private System.Windows.Forms.TextBox MainDisease;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NamePolis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.TextBox Work;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MidName;
        private System.Windows.Forms.TextBox k_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox prim_bolvsys;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox prim_oteksys;
        private System.Windows.Forms.ComboBox prim_zatrpriglot;
        private System.Windows.Forms.ComboBox prim_chyvstrykholod;
        private System.Windows.Forms.ComboBox prim_syhkojslis;
        private System.Windows.Forms.ComboBox prim_visnasliz;
        private System.Windows.Forms.ComboBox prim_izmmastel;
        private System.Windows.Forms.ComboBox prim_slab;
        private System.Windows.Forms.ComboBox prim_povtemp;
        private System.Windows.Forms.ComboBox prim_utrskov;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox prim_ves;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox prim_telosloj;
        private System.Windows.Forms.Label label36;
        public System.Windows.Forms.TextBox avtor_fio;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox prim_indmasstela;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox prim_rost;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox prim_spovtela;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.ComboBox prim_porokoltkan;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.ComboBox prim_gepatomealg;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ComboBox prim_izmslisobol;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox prim_vnesysproj;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox prim_tynsyndr;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox prim_ytrenskov;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox prim_vash;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox prim_deform;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox prim_chbs;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox prim_chps;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox prim_drygzabrods;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox prim_onkpotrods;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox prim_psorrods;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ComboBox prim_revmzabrod;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox prim_invgr;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ComboBox prim_workstat;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.ComboBox prim_inval;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox prim_bolnichdney;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.ComboBox prim_listnetryd;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox prim_pereosvinv;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox prim_dinaminv;
        private System.Windows.Forms.ComboBox prim_grip;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.ComboBox prim_alerganamn;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.ComboBox prim_kleshi;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.ComboBox prim_malaria;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.ComboBox prim_gepatit;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.ComboBox prim_venzab;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox prim_tyber;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.ComboBox prim_korona;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox prim_pnevmokok;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.ComboBox prim_bityslov;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.ComboBox prim_profvred;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.ComboBox prim_vredprivich;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.ComboBox prim_pitanie;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.ComboBox prim_dvigact;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.RichTextBox prim_anamnzabol;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.ComboBox prim_obhsost;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.TextBox prim_temptela;
        private System.Windows.Forms.ComboBox prim_soznan;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.ComboBox prim_kontact;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.ComboBox prim_teloslojprav;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.ComboBox prim_prostrivrema;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.ComboBox prim_emoclab;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.ComboBox prim_vlagtyrgor;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.ComboBox prim_tyrgor;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox prim_kojokrask;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.ComboBox prim_kojpokr;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.ComboBox prim_kostmishrazv;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.ComboBox prim_okrasvidslisobol;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.ComboBox prim_vidslisobol;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.ComboBox prim_mindal;
        private System.Windows.Forms.ComboBox prim_okraszev;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.ComboBox prim_zev;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.ComboBox prim_dvijvsyst;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox prim_pereferlimf;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.ComboBox prim_oteki;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox prim_mestoteki;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.ComboBox prim_palpatormolochjel;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.ComboBox prim_molochjel;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.ComboBox prim_razmshitovjel;
        private System.Windows.Forms.ComboBox prim_shitovjel;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox prim_chss;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.TextBox prim_artdavl;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.ComboBox prim_shymserdc;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.ComboBox prim_tonserdc;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.ComboBox prim_shymbrahart;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.ComboBox prim_pulsbedr;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.ComboBox prim_patologpyls;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.TextBox prim_chislodih;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.ComboBox prim_actdihmishc;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.ComboBox prim_grydform;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.ComboBox prim_distchrip;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.ComboBox prim_perkytor;
        private System.Windows.Forms.Label label130;
        public System.Windows.Forms.Label label131;
        private System.Windows.Forms.ComboBox prim_shymdyhan;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.ComboBox prim_dyhan;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.ComboBox prim_jziknal;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.ComboBox prim_jivotpripalpac;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.ComboBox prim_poperobodkish;
        private System.Windows.Forms.Label label139;
        private System.Windows.Forms.ComboBox prim_slepkish;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.ComboBox prim_glybpalpackish;
        private System.Windows.Forms.Label label137;
        private System.Windows.Forms.ComboBox prim_poverhpecheni;
        private System.Windows.Forms.Label label142;
        private System.Windows.Forms.ComboBox prim_krayreberdyg;
        private System.Windows.Forms.Label label141;
        private System.Windows.Forms.ComboBox prim_pechen;
        private System.Windows.Forms.Label label140;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.TextBox prim_plotnkrayreberdyg;
        private System.Windows.Forms.ComboBox prim_selezenk;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.ComboBox prim_fiziologotprav;
        private System.Windows.Forms.Label label147;
        private System.Windows.Forms.ComboBox prim_simptpokolach;
        private System.Windows.Forms.Label label146;
        private System.Windows.Forms.Label label145;
        private System.Windows.Forms.RichTextBox prim_predstavobolnom;
        private System.Windows.Forms.Label label148;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label151;
        private System.Windows.Forms.Label label150;
        private System.Windows.Forms.RichTextBox prim_planlecheni;
        private System.Windows.Forms.RichTextBox prim_planobsledov;
        private System.Windows.Forms.Label label149;
        private System.Windows.Forms.TextBox prim_LastName;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.TextBox prim_MidName;
        private System.Windows.Forms.Label label154;
        private System.Windows.Forms.Label label153;
        private System.Windows.Forms.TextBox prim_Work;
        private System.Windows.Forms.Label label152;
        private System.Windows.Forms.TextBox prim_Сountry;
        private System.Windows.Forms.Label label156;
        private System.Windows.Forms.Label label157;
        private System.Windows.Forms.Label label158;
        private System.Windows.Forms.Label label159;
        private System.Windows.Forms.Label label160;
        private System.Windows.Forms.Label label161;
        private System.Windows.Forms.TextBox prim_House;
        private System.Windows.Forms.TextBox prim_Apartment;
        private System.Windows.Forms.TextBox prim_Street;
        private System.Windows.Forms.TextBox prim_City;
        private System.Windows.Forms.TextBox prim_District;
        private System.Windows.Forms.Label label162;
        private System.Windows.Forms.TextBox prim_id;
        private System.Windows.Forms.Label label164;
        private System.Windows.Forms.TextBox prim_Name;
        private System.Windows.Forms.Label label163;
        private System.Windows.Forms.Label label165;
        private System.Windows.Forms.MaskedTextBox prim_DateOfBirth;
        private System.Windows.Forms.RichTextBox prim_jalob;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.MaskedTextBox epizod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label166;
        private System.Windows.Forms.Panel panel3;
    }
}

