
namespace Medical_system
{
    partial class Form5
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
            this.Сancel = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.AnalysisType = new System.Windows.Forms.Label();
            this.PatSel = new System.Windows.Forms.ComboBox();
            this.patientBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet5 = new Medical_system.MISDataSet5();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet4 = new Medical_system.MISDataSet4();
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mISDataSet2 = new Medical_system.MISDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Medical_system.MISDataSet2TableAdapters.PatientTableAdapter();
            this.DateOfAnalysis = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.HGB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.WBC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.RDW_CV = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.PCT = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.PDW = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.P_LCR = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.MPV = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PLT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RDW_SD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.HCT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MCHC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MCH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RBC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patientTableAdapter1 = new Medical_system.MISDataSet4TableAdapters.PatientTableAdapter();
            this.patientBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter2 = new Medical_system.MISDataSet5TableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // Сancel
            // 
            this.Сancel.Location = new System.Drawing.Point(21, 561);
            this.Сancel.Name = "Сancel";
            this.Сancel.Size = new System.Drawing.Size(109, 34);
            this.Сancel.TabIndex = 0;
            this.Сancel.Text = "Отмена";
            this.Сancel.UseVisualStyleBackColor = true;
            this.Сancel.Click += new System.EventHandler(this.Сancel_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(361, 561);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(109, 34);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnalysisType
            // 
            this.AnalysisType.AutoSize = true;
            this.AnalysisType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnalysisType.Location = new System.Drawing.Point(177, 9);
            this.AnalysisType.Name = "AnalysisType";
            this.AnalysisType.Size = new System.Drawing.Size(167, 20);
            this.AnalysisType.TabIndex = 17;
            this.AnalysisType.Text = "Общий анализ крови";
            // 
            // PatSel
            // 
            this.PatSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatSel.FormattingEnabled = true;
            this.PatSel.Location = new System.Drawing.Point(143, 43);
            this.PatSel.Name = "PatSel";
            this.PatSel.Size = new System.Drawing.Size(356, 28);
            this.PatSel.TabIndex = 18;
            this.PatSel.SelectedIndexChanged += new System.EventHandler(this.Patient_SelectedIndexChanged);
            this.PatSel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SNILS_KeyPress);
            // 
            // patientBindingSource5
            // 
            this.patientBindingSource5.DataMember = "Patient";
            this.patientBindingSource5.DataSource = this.mISDataSet5;
            // 
            // mISDataSet5
            // 
            this.mISDataSet5.DataSetName = "MISDataSet5";
            this.mISDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.mISDataSet4;
            // 
            // mISDataSet4
            // 
            this.mISDataSet4.DataSetName = "MISDataSet4";
            this.mISDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Пациент";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.mISDataSet2;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // DateOfAnalysis
            // 
            this.DateOfAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfAnalysis.Location = new System.Drawing.Point(143, 77);
            this.DateOfAnalysis.Mask = "00/00/0000";
            this.DateOfAnalysis.Name = "DateOfAnalysis";
            this.DateOfAnalysis.Size = new System.Drawing.Size(112, 26);
            this.DateOfAnalysis.TabIndex = 33;
            this.DateOfAnalysis.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Дата анализа";
            // 
            // HGB
            // 
            this.HGB.Location = new System.Drawing.Point(334, 26);
            this.HGB.Name = "HGB";
            this.HGB.Size = new System.Drawing.Size(100, 22);
            this.HGB.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.WBC);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.RDW_CV);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.PCT);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.PDW);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.P_LCR);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.MPV);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.PLT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.RDW_SD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.HCT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MCHC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MCH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MCV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.RBC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.HGB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(499, 417);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Показатели";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(440, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 75;
            this.label18.Text = "10^9/L";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 61;
            this.label16.Text = "Лейкоциты";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(440, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(20, 16);
            this.label19.TabIndex = 74;
            this.label19.Text = "%";
            // 
            // WBC
            // 
            this.WBC.Location = new System.Drawing.Point(334, 387);
            this.WBC.Name = "WBC";
            this.WBC.Size = new System.Drawing.Size(100, 22);
            this.WBC.TabIndex = 60;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(440, 364);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(20, 16);
            this.label20.TabIndex = 73;
            this.label20.Text = "%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(325, 16);
            this.label17.TabIndex = 59;
            this.label17.Text = "Ширина распределения эритроцитов по объему";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(440, 336);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 16);
            this.label21.TabIndex = 72;
            this.label21.Text = "%";
            // 
            // RDW_CV
            // 
            this.RDW_CV.Location = new System.Drawing.Point(334, 194);
            this.RDW_CV.Name = "RDW_CV";
            this.RDW_CV.Size = new System.Drawing.Size(100, 22);
            this.RDW_CV.TabIndex = 58;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(440, 308);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 16);
            this.label22.TabIndex = 71;
            this.label22.Text = "%";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 57;
            this.label13.Text = "Тромбокрит";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(440, 280);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 16);
            this.label23.TabIndex = 70;
            this.label23.Text = "fL";
            // 
            // PCT
            // 
            this.PCT.Location = new System.Drawing.Point(334, 359);
            this.PCT.Name = "PCT";
            this.PCT.Size = new System.Drawing.Size(100, 22);
            this.PCT.TabIndex = 56;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(440, 252);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 16);
            this.label24.TabIndex = 69;
            this.label24.Text = "10^9/L";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 334);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(326, 16);
            this.label14.TabIndex = 55;
            this.label14.Text = "Ширина распределения тромбоцитов по объему";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(440, 224);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(27, 16);
            this.label25.TabIndex = 68;
            this.label25.Text = "фл";
            // 
            // PDW
            // 
            this.PDW.Location = new System.Drawing.Point(334, 331);
            this.PDW.Name = "PDW";
            this.PDW.Size = new System.Drawing.Size(100, 22);
            this.PDW.TabIndex = 54;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(440, 171);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 16);
            this.label26.TabIndex = 67;
            this.label26.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(313, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "Отношение крупных тромбоцитов к общ.кол-ву";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(440, 143);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 16);
            this.label27.TabIndex = 66;
            this.label27.Text = "g/dL";
            // 
            // P_LCR
            // 
            this.P_LCR.Location = new System.Drawing.Point(334, 303);
            this.P_LCR.Name = "P_LCR";
            this.P_LCR.Size = new System.Drawing.Size(100, 22);
            this.P_LCR.TabIndex = 52;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(440, 115);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(24, 16);
            this.label28.TabIndex = 65;
            this.label28.Text = "pg";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "Средний объем тромбоцитов";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(440, 87);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(18, 16);
            this.label29.TabIndex = 64;
            this.label29.Text = "fL";
            // 
            // MPV
            // 
            this.MPV.Location = new System.Drawing.Point(334, 275);
            this.MPV.Name = "MPV";
            this.MPV.Size = new System.Drawing.Size(100, 22);
            this.MPV.TabIndex = 50;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(440, 59);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 16);
            this.label30.TabIndex = 63;
            this.label30.Text = "10^12/L";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(440, 31);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 16);
            this.label31.TabIndex = 62;
            this.label31.Text = "g/L";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Тромбоциты";
            // 
            // PLT
            // 
            this.PLT.Location = new System.Drawing.Point(334, 247);
            this.PLT.Name = "PLT";
            this.PLT.Size = new System.Drawing.Size(100, 22);
            this.PLT.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Ширина распределения эритроцитов по объему";
            // 
            // RDW_SD
            // 
            this.RDW_SD.Location = new System.Drawing.Point(334, 222);
            this.RDW_SD.Name = "RDW_SD";
            this.RDW_SD.Size = new System.Drawing.Size(100, 22);
            this.RDW_SD.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Гематокрит";
            // 
            // HCT
            // 
            this.HCT.Location = new System.Drawing.Point(334, 166);
            this.HCT.Name = "HCT";
            this.HCT.Size = new System.Drawing.Size(100, 22);
            this.HCT.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Средняя концентрация гемоглобина в эритр.";
            // 
            // MCHC
            // 
            this.MCHC.Location = new System.Drawing.Point(334, 138);
            this.MCHC.Name = "MCHC";
            this.MCHC.Size = new System.Drawing.Size(100, 22);
            this.MCHC.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(302, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Среднее содержание гемоглобина в 1 эритр.";
            // 
            // MCH
            // 
            this.MCH.Location = new System.Drawing.Point(334, 110);
            this.MCH.Name = "MCH";
            this.MCH.Size = new System.Drawing.Size(100, 22);
            this.MCH.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Средний объем эритроцитов";
            // 
            // MCV
            // 
            this.MCV.Location = new System.Drawing.Point(334, 82);
            this.MCV.Name = "MCV";
            this.MCV.Size = new System.Drawing.Size(100, 22);
            this.MCV.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Эритроциты";
            // 
            // RBC
            // 
            this.RBC.Location = new System.Drawing.Point(334, 54);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(100, 22);
            this.RBC.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Гемоглобин";
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
            // patientBindingSource4
            // 
            this.patientBindingSource4.DataMember = "Patient";
            this.patientBindingSource4.DataSource = this.mISDataSet4;
            // 
            // patientTableAdapter2
            // 
            this.patientTableAdapter2.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 615);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DateOfAnalysis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatSel);
            this.Controls.Add(this.AnalysisType);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Сancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form5";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Общий анализ крови";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mISDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Сancel;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label AnalysisType;
        private System.Windows.Forms.ComboBox PatSel;
        private System.Windows.Forms.Label label2;
        private MISDataSet2 mISDataSet2;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private MISDataSet2TableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.MaskedTextBox DateOfAnalysis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HGB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox WBC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox RDW_CV;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox PCT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox PDW;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox P_LCR;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox MPV;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PLT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RDW_SD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HCT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MCHC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MCH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RBC;
        private System.Windows.Forms.Label label3;
        private MISDataSet4 mISDataSet4;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private MISDataSet4TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.BindingSource patientBindingSource4;
        private System.Windows.Forms.BindingSource patientBindingSource3;
        private MISDataSet5 mISDataSet5;
        private System.Windows.Forms.BindingSource patientBindingSource5;
        private MISDataSet5TableAdapters.PatientTableAdapter patientTableAdapter2;
    }
}