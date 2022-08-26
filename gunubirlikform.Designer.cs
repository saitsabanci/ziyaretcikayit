namespace ziyaretcikayit
{
    partial class gunubirlikform
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
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxplaka = new System.Windows.Forms.TextBox();
            this.textBoxadsoyad = new System.Windows.Forms.TextBox();
            this.textBoxtcno = new System.Windows.Forms.TextBox();
            this.maskedTextBoxgiris = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxcikis = new System.Windows.Forms.MaskedTextBox();
            this.textBoxaciklama = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgwGunubirlik = new ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabahDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ogleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aksamDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gunubırlıkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbGunubirlikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunubirlikkayitDataSet = new ziyaretcikayit.gunubirlikkayitDataSet();
            this.dbGunubirlikTableAdapter = new ziyaretcikayit.gunubirlikkayitDataSetTableAdapters.dbGunubirlikTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxsabah = new System.Windows.Forms.CheckBox();
            this.checkBoxogle = new System.Windows.Forms.CheckBox();
            this.checkBoxaksam = new System.Windows.Forms.CheckBox();
            this.checkBoxgunubirlik = new System.Windows.Forms.CheckBox();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttontemizle = new System.Windows.Forms.Button();
            this.buttonexcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGunubirlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGunubirlikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunubirlikkayitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLAKA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AD SOYAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC KİMLİK NUMARASI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "GİRİŞ SAATİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ÇIKIŞ SAATİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "AÇIKLAMALAR";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(144, 212);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(38, 20);
            this.textBoxid.TabIndex = 7;
            // 
            // textBoxplaka
            // 
            this.textBoxplaka.Location = new System.Drawing.Point(144, 277);
            this.textBoxplaka.Name = "textBoxplaka";
            this.textBoxplaka.Size = new System.Drawing.Size(135, 20);
            this.textBoxplaka.TabIndex = 8;
            // 
            // textBoxadsoyad
            // 
            this.textBoxadsoyad.Location = new System.Drawing.Point(144, 311);
            this.textBoxadsoyad.Name = "textBoxadsoyad";
            this.textBoxadsoyad.Size = new System.Drawing.Size(135, 20);
            this.textBoxadsoyad.TabIndex = 9;
            // 
            // textBoxtcno
            // 
            this.textBoxtcno.Location = new System.Drawing.Point(144, 342);
            this.textBoxtcno.MaxLength = 11;
            this.textBoxtcno.Name = "textBoxtcno";
            this.textBoxtcno.Size = new System.Drawing.Size(135, 20);
            this.textBoxtcno.TabIndex = 10;
            // 
            // maskedTextBoxgiris
            // 
            this.maskedTextBoxgiris.Location = new System.Drawing.Point(144, 372);
            this.maskedTextBoxgiris.Mask = "00:00";
            this.maskedTextBoxgiris.Name = "maskedTextBoxgiris";
            this.maskedTextBoxgiris.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBoxgiris.TabIndex = 11;
            // 
            // maskedTextBoxcikis
            // 
            this.maskedTextBoxcikis.Location = new System.Drawing.Point(144, 401);
            this.maskedTextBoxcikis.Mask = "00:00";
            this.maskedTextBoxcikis.Name = "maskedTextBoxcikis";
            this.maskedTextBoxcikis.Size = new System.Drawing.Size(39, 20);
            this.maskedTextBoxcikis.TabIndex = 12;
            // 
            // textBoxaciklama
            // 
            this.textBoxaciklama.Location = new System.Drawing.Point(144, 430);
            this.textBoxaciklama.Name = "textBoxaciklama";
            this.textBoxaciklama.Size = new System.Drawing.Size(135, 20);
            this.textBoxaciklama.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dgwGunubirlik
            // 
            this.dgwGunubirlik.AllowDrop = true;
            this.dgwGunubirlik.AllowUserToAddRows = false;
            this.dgwGunubirlik.AllowUserToDeleteRows = false;
            this.dgwGunubirlik.AutoGenerateColumns = false;
            this.dgwGunubirlik.AutoGenerateContextFilters = true;
            this.dgwGunubirlik.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwGunubirlik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwGunubirlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGunubirlik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.adsoyadDataGridViewTextBoxColumn,
            this.tcnoDataGridViewTextBoxColumn,
            this.girisDataGridViewTextBoxColumn,
            this.cikisDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.sabahDataGridViewCheckBoxColumn,
            this.ogleDataGridViewCheckBoxColumn,
            this.aksamDataGridViewCheckBoxColumn,
            this.gunubırlıkDataGridViewCheckBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dgwGunubirlik.DataSource = this.dbGunubirlikBindingSource;
            this.dgwGunubirlik.DateWithTime = false;
            this.dgwGunubirlik.Location = new System.Drawing.Point(285, 2);
            this.dgwGunubirlik.Name = "dgwGunubirlik";
            this.dgwGunubirlik.ReadOnly = true;
            this.dgwGunubirlik.RowHeadersVisible = false;
            this.dgwGunubirlik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwGunubirlik.Size = new System.Drawing.Size(856, 507);
            this.dgwGunubirlik.StandardTab = true;
            this.dgwGunubirlik.TabIndex = 15;
            this.dgwGunubirlik.TimeFilter = false;
            this.dgwGunubirlik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGunubirlik_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            this.plakaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // adsoyadDataGridViewTextBoxColumn
            // 
            this.adsoyadDataGridViewTextBoxColumn.DataPropertyName = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.HeaderText = "adsoyad";
            this.adsoyadDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.adsoyadDataGridViewTextBoxColumn.Name = "adsoyadDataGridViewTextBoxColumn";
            this.adsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.adsoyadDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tcnoDataGridViewTextBoxColumn
            // 
            this.tcnoDataGridViewTextBoxColumn.DataPropertyName = "tcno";
            this.tcnoDataGridViewTextBoxColumn.HeaderText = "tcno";
            this.tcnoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tcnoDataGridViewTextBoxColumn.Name = "tcnoDataGridViewTextBoxColumn";
            this.tcnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tcnoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tcnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // girisDataGridViewTextBoxColumn
            // 
            this.girisDataGridViewTextBoxColumn.DataPropertyName = "giris";
            this.girisDataGridViewTextBoxColumn.HeaderText = "giris";
            this.girisDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.girisDataGridViewTextBoxColumn.Name = "girisDataGridViewTextBoxColumn";
            this.girisDataGridViewTextBoxColumn.ReadOnly = true;
            this.girisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.girisDataGridViewTextBoxColumn.Width = 50;
            // 
            // cikisDataGridViewTextBoxColumn
            // 
            this.cikisDataGridViewTextBoxColumn.DataPropertyName = "cikis";
            this.cikisDataGridViewTextBoxColumn.HeaderText = "cikis";
            this.cikisDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.cikisDataGridViewTextBoxColumn.Name = "cikisDataGridViewTextBoxColumn";
            this.cikisDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikisDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.cikisDataGridViewTextBoxColumn.Width = 50;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarihDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // sabahDataGridViewCheckBoxColumn
            // 
            this.sabahDataGridViewCheckBoxColumn.DataPropertyName = "sabah";
            this.sabahDataGridViewCheckBoxColumn.FalseValue = "0";
            this.sabahDataGridViewCheckBoxColumn.HeaderText = "sabah";
            this.sabahDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.sabahDataGridViewCheckBoxColumn.Name = "sabahDataGridViewCheckBoxColumn";
            this.sabahDataGridViewCheckBoxColumn.ReadOnly = true;
            this.sabahDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sabahDataGridViewCheckBoxColumn.TrueValue = "1";
            this.sabahDataGridViewCheckBoxColumn.Width = 50;
            // 
            // ogleDataGridViewCheckBoxColumn
            // 
            this.ogleDataGridViewCheckBoxColumn.DataPropertyName = "ogle";
            this.ogleDataGridViewCheckBoxColumn.HeaderText = "ogle";
            this.ogleDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.ogleDataGridViewCheckBoxColumn.Name = "ogleDataGridViewCheckBoxColumn";
            this.ogleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ogleDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ogleDataGridViewCheckBoxColumn.Width = 50;
            // 
            // aksamDataGridViewCheckBoxColumn
            // 
            this.aksamDataGridViewCheckBoxColumn.DataPropertyName = "aksam";
            this.aksamDataGridViewCheckBoxColumn.HeaderText = "aksam";
            this.aksamDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.aksamDataGridViewCheckBoxColumn.Name = "aksamDataGridViewCheckBoxColumn";
            this.aksamDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aksamDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.aksamDataGridViewCheckBoxColumn.Width = 50;
            // 
            // gunubırlıkDataGridViewCheckBoxColumn
            // 
            this.gunubırlıkDataGridViewCheckBoxColumn.DataPropertyName = "gunubırlık";
            this.gunubırlıkDataGridViewCheckBoxColumn.HeaderText = "gunubırlık";
            this.gunubırlıkDataGridViewCheckBoxColumn.MinimumWidth = 22;
            this.gunubırlıkDataGridViewCheckBoxColumn.Name = "gunubırlıkDataGridViewCheckBoxColumn";
            this.gunubırlıkDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gunubırlıkDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gunubırlıkDataGridViewCheckBoxColumn.Width = 50;
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            this.aciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.aciklamaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dbGunubirlikBindingSource
            // 
            this.dbGunubirlikBindingSource.DataMember = "dbGunubirlik";
            this.dbGunubirlikBindingSource.DataSource = this.gunubirlikkayitDataSet;
            // 
            // gunubirlikkayitDataSet
            // 
            this.gunubirlikkayitDataSet.DataSetName = "gunubirlikkayitDataSet";
            this.gunubirlikkayitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbGunubirlikTableAdapter
            // 
            this.dbGunubirlikTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "TARİH";
            // 
            // checkBoxsabah
            // 
            this.checkBoxsabah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxsabah.Location = new System.Drawing.Point(4, 456);
            this.checkBoxsabah.Name = "checkBoxsabah";
            this.checkBoxsabah.Size = new System.Drawing.Size(146, 25);
            this.checkBoxsabah.TabIndex = 17;
            this.checkBoxsabah.Text = "SABAH KAHVALTISI";
            this.checkBoxsabah.UseVisualStyleBackColor = true;
            // 
            // checkBoxogle
            // 
            this.checkBoxogle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxogle.Location = new System.Drawing.Point(151, 456);
            this.checkBoxogle.Name = "checkBoxogle";
            this.checkBoxogle.Size = new System.Drawing.Size(114, 25);
            this.checkBoxogle.TabIndex = 18;
            this.checkBoxogle.Text = "ÖĞLE YEMEĞİ";
            this.checkBoxogle.UseVisualStyleBackColor = true;
            // 
            // checkBoxaksam
            // 
            this.checkBoxaksam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxaksam.Location = new System.Drawing.Point(4, 492);
            this.checkBoxaksam.Name = "checkBoxaksam";
            this.checkBoxaksam.Size = new System.Drawing.Size(127, 25);
            this.checkBoxaksam.TabIndex = 19;
            this.checkBoxaksam.Text = "AKŞAM YEMEĞİ";
            this.checkBoxaksam.UseVisualStyleBackColor = true;
            // 
            // checkBoxgunubirlik
            // 
            this.checkBoxgunubirlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxgunubirlik.Location = new System.Drawing.Point(151, 492);
            this.checkBoxgunubirlik.Name = "checkBoxgunubirlik";
            this.checkBoxgunubirlik.Size = new System.Drawing.Size(118, 25);
            this.checkBoxgunubirlik.TabIndex = 20;
            this.checkBoxgunubirlik.Text = "GÜNÜBİRLİK";
            this.checkBoxgunubirlik.UseVisualStyleBackColor = true;
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(6, 532);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(103, 35);
            this.buttonekle.TabIndex = 21;
            this.buttonekle.Text = "EKLE";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(115, 532);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(103, 35);
            this.buttonsil.TabIndex = 22;
            this.buttonsil.Text = "SİL";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Location = new System.Drawing.Point(4, 573);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(103, 35);
            this.buttonguncelle.TabIndex = 23;
            this.buttonguncelle.Text = "GÜNCELLE";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // buttontemizle
            // 
            this.buttontemizle.Location = new System.Drawing.Point(113, 573);
            this.buttontemizle.Name = "buttontemizle";
            this.buttontemizle.Size = new System.Drawing.Size(103, 35);
            this.buttontemizle.TabIndex = 24;
            this.buttontemizle.Text = "TEMİZLE";
            this.buttontemizle.UseVisualStyleBackColor = true;
            this.buttontemizle.Click += new System.EventHandler(this.buttontemizle_Click);
            // 
            // buttonexcel
            // 
            this.buttonexcel.Location = new System.Drawing.Point(6, 614);
            this.buttonexcel.Name = "buttonexcel";
            this.buttonexcel.Size = new System.Drawing.Size(103, 35);
            this.buttonexcel.TabIndex = 25;
            this.buttonexcel.Text = "EXCEL\'E AKTAR";
            this.buttonexcel.UseVisualStyleBackColor = true;
            this.buttonexcel.Click += new System.EventHandler(this.buttonexcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(346, 543);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "PLAKA ARA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(346, 573);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "AD SOYAD ARA:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 540);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 20);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(450, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(636, 540);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(636, 573);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker3.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 24);
            this.button1.TabIndex = 33;
            this.button1.Text = "TARİH FİLTRELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 599);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 24);
            this.button2.TabIndex = 34;
            this.button2.Text = "TEMİZLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gunubirlikform
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1153, 683);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonexcel);
            this.Controls.Add(this.buttontemizle);
            this.Controls.Add(this.buttonguncelle);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.buttonekle);
            this.Controls.Add(this.checkBoxgunubirlik);
            this.Controls.Add(this.checkBoxaksam);
            this.Controls.Add(this.checkBoxogle);
            this.Controls.Add(this.checkBoxsabah);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgwGunubirlik);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxaciklama);
            this.Controls.Add(this.maskedTextBoxcikis);
            this.Controls.Add(this.maskedTextBoxgiris);
            this.Controls.Add(this.textBoxtcno);
            this.Controls.Add(this.textBoxadsoyad);
            this.Controls.Add(this.textBoxplaka);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "gunubirlikform";
            this.Text = "gunubirlikform";
            this.Load += new System.EventHandler(this.gunubirlikform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwGunubirlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGunubirlikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunubirlikkayitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxplaka;
        private System.Windows.Forms.TextBox textBoxadsoyad;
        private System.Windows.Forms.TextBox textBoxtcno;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxgiris;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxcikis;
        private System.Windows.Forms.TextBox textBoxaciklama;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ADGV.AdvancedDataGridView dgwGunubirlik;
        private gunubirlikkayitDataSet gunubirlikkayitDataSet;
        private System.Windows.Forms.BindingSource dbGunubirlikBindingSource;
        private gunubirlikkayitDataSetTableAdapters.dbGunubirlikTableAdapter dbGunubirlikTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxsabah;
        private System.Windows.Forms.CheckBox checkBoxogle;
        private System.Windows.Forms.CheckBox checkBoxaksam;
        private System.Windows.Forms.CheckBox checkBoxgunubirlik;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttontemizle;
        private System.Windows.Forms.Button buttonexcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sabahDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aksamDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gunubırlıkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
    }
}