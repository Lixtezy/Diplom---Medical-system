
namespace Medical_system
{
    partial class AddPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PolisNum = new System.Windows.Forms.MaskedTextBox();
            this.SNILS = new System.Windows.Forms.MaskedTextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.DateOfBirth = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ICD10 = new System.Windows.Forms.ComboBox();
            this.iCD10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet = new Medical_system.MISDataSet();
            this.MainDisease = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.NamePolis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Work = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.MidName = new System.Windows.Forms.TextBox();
            this.d_Name = new System.Windows.Forms.TextBox();
            this.DiseaseHistory = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.iCD10TableAdapter = new Medical_system.MISDataSetTableAdapters.ICD10TableAdapter();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCD10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Пол*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата рождения*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(523, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "СНИЛС*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Место работы";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(35, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "История болезни";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(718, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PolisNum);
            this.groupBox1.Controls.Add(this.SNILS);
            this.groupBox1.Controls.Add(this.Phone);
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ICD10);
            this.groupBox1.Controls.Add(this.MainDisease);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.NamePolis);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.Work);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.MidName);
            this.groupBox1.Controls.Add(this.d_Name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 382);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные пациента";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PolisNum
            // 
            this.PolisNum.Location = new System.Drawing.Point(160, 316);
            this.PolisNum.Mask = "9999999999999999";
            this.PolisNum.Name = "PolisNum";
            this.PolisNum.Size = new System.Drawing.Size(273, 22);
            this.PolisNum.TabIndex = 34;
            // 
            // SNILS
            // 
            this.SNILS.Location = new System.Drawing.Point(584, 316);
            this.SNILS.Mask = "999-999-999 99";
            this.SNILS.Name = "SNILS";
            this.SNILS.Size = new System.Drawing.Size(275, 22);
            this.SNILS.TabIndex = 33;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(160, 240);
            this.Phone.Mask = "+7 (999) 00-00-000";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(273, 22);
            this.Phone.TabIndex = 32;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(160, 171);
            this.DateOfBirth.Mask = "00/00/0000";
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(147, 22);
            this.DateOfBirth.TabIndex = 31;
            this.DateOfBirth.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Телефон";
            // 
            // ICD10
            // 
            this.ICD10.DataSource = this.iCD10BindingSource;
            this.ICD10.DisplayMember = "ICD10";
            this.ICD10.Location = new System.Drawing.Point(732, 351);
            this.ICD10.Name = "ICD10";
            this.ICD10.Size = new System.Drawing.Size(125, 24);
            this.ICD10.TabIndex = 27;
            this.ICD10.SelectedIndexChanged += new System.EventHandler(this.ICD10_SelectedIndexChanged);
            this.ICD10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ICD10_KeyPress);
            // 
            // iCD10BindingSource
            // 
            this.iCD10BindingSource.DataMember = "ICD10";
            this.iCD10BindingSource.DataSource = this.mISDataSet;
            // 
            // mISDataSet
            // 
            this.mISDataSet.DataSetName = "MISDataSet";
            this.mISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainDisease
            // 
            this.MainDisease.Location = new System.Drawing.Point(176, 351);
            this.MainDisease.Name = "MainDisease";
            this.MainDisease.Size = new System.Drawing.Size(444, 22);
            this.MainDisease.TabIndex = 26;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(626, 354);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 16);
            this.label19.TabIndex = 25;
            this.label19.Text = "Код по МКБ-10*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 354);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 16);
            this.label15.TabIndex = 24;
            this.label15.Text = "Основное заболевание";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(491, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 190);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Место регистрации";
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
            this.Сountry.Size = new System.Drawing.Size(273, 24);
            this.Сountry.TabIndex = 24;
            this.Сountry.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Сountry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(214, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 16);
            this.label18.TabIndex = 30;
            this.label18.Text = "Квартира*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(6, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "Дом*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Улица*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 90);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Город*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Район";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Страна*";
            // 
            // House
            // 
            this.House.Location = new System.Drawing.Point(95, 154);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(102, 22);
            this.House.TabIndex = 14;
            // 
            // Apartment
            // 
            this.Apartment.Location = new System.Drawing.Point(291, 154);
            this.Apartment.Name = "Apartment";
            this.Apartment.Size = new System.Drawing.Size(77, 22);
            this.Apartment.TabIndex = 13;
            // 
            // Street
            // 
            this.Street.Location = new System.Drawing.Point(95, 122);
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(273, 22);
            this.Street.TabIndex = 9;
            // 
            // City
            // 
            this.City.Location = new System.Drawing.Point(95, 90);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(273, 22);
            this.City.TabIndex = 11;
            // 
            // District
            // 
            this.District.Location = new System.Drawing.Point(95, 56);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(273, 22);
            this.District.TabIndex = 10;
            // 
            // NamePolis
            // 
            this.NamePolis.Location = new System.Drawing.Point(369, 277);
            this.NamePolis.Name = "NamePolis";
            this.NamePolis.Size = new System.Drawing.Size(490, 22);
            this.NamePolis.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(362, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Наименование страховой медицинской организации*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Полис ОМС №*";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.Gender.Location = new System.Drawing.Point(160, 141);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(147, 24);
            this.Gender.TabIndex = 15;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            this.Gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gender_KeyPress);
            // 
            // Work
            // 
            this.Work.Location = new System.Drawing.Point(160, 206);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(273, 22);
            this.Work.TabIndex = 14;
            this.Work.TextChanged += new System.EventHandler(this.Work_TextChanged);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(160, 77);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(273, 22);
            this.LastName.TabIndex = 8;
            this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
            this.LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastName_KeyPress);
            // 
            // MidName
            // 
            this.MidName.Location = new System.Drawing.Point(160, 111);
            this.MidName.Name = "MidName";
            this.MidName.Size = new System.Drawing.Size(273, 22);
            this.MidName.TabIndex = 11;
            this.MidName.TextChanged += new System.EventHandler(this.MidName_TextChanged);
            this.MidName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MidName_KeyPress);
            // 
            // d_Name
            // 
            this.d_Name.Location = new System.Drawing.Point(160, 41);
            this.d_Name.Name = "d_Name";
            this.d_Name.Size = new System.Drawing.Size(273, 22);
            this.d_Name.TabIndex = 7;
            this.d_Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            this.d_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_KeyPress);
            // 
            // DiseaseHistory
            // 
            this.DiseaseHistory.Location = new System.Drawing.Point(38, 409);
            this.DiseaseHistory.Name = "DiseaseHistory";
            this.DiseaseHistory.Size = new System.Drawing.Size(831, 129);
            this.DiseaseHistory.TabIndex = 14;
            this.DiseaseHistory.Text = "";
            this.DiseaseHistory.TextChanged += new System.EventHandler(this.DiseaseHistory_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(74, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 36);
            this.button2.TabIndex = 15;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iCD10TableAdapter
            // 
            this.iCD10TableAdapter.ClearBeforeFill = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(9, 596);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(260, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Поля помеченные * обязательны для заполнения";
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 611);
            this.ControlBox = false;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DiseaseHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPatient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление пациента";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iCD10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Work;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox MidName;
        private System.Windows.Forms.TextBox d_Name;
        private System.Windows.Forms.RichTextBox DiseaseHistory;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NamePolis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Сountry;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox House;
        private System.Windows.Forms.TextBox Apartment;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox District;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox MainDisease;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private MISDataSet mISDataSet;
        private System.Windows.Forms.BindingSource iCD10BindingSource;
        private MISDataSetTableAdapters.ICD10TableAdapter iCD10TableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox DateOfBirth;
        private System.Windows.Forms.MaskedTextBox SNILS;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox PolisNum;
        private System.Windows.Forms.ComboBox ICD10;
    }
}