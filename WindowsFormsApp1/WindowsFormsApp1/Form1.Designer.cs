namespace WindowsFormsApp1
{
    partial class Автомобиль
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonОПрограмме = new System.Windows.Forms.Button();
            this.buttonПереходЧек = new System.Windows.Forms.Button();
            this.buttonУдалитьАвтомобиль = new System.Windows.Forms.Button();
            this.buttonОбновитьАвтомобиль = new System.Windows.Forms.Button();
            this.buttonДобавитьАвтомобиль = new System.Windows.Forms.Button();
            this.textBoxАвтомобиль = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewАвтомобиль = new System.Windows.Forms.DataGridView();
            this.IDАвто = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_телефона = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vin_номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Марка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Модель = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Год = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Государственный_номер = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonУдалитьЗаказ = new System.Windows.Forms.Button();
            this.buttonОбновитьЗаказ = new System.Windows.Forms.Button();
            this.buttonДобавитьЗаказ = new System.Windows.Forms.Button();
            this.textBoxЗаказ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewЗаказ = new System.Windows.Forms.DataGridView();
            this.ID_заказ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Работник_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonУдалитьЗаказУслуг = new System.Windows.Forms.Button();
            this.buttonОбновитьЗаказУслуг = new System.Windows.Forms.Button();
            this.buttonДобавитьЗаказУслуг = new System.Windows.Forms.Button();
            this.dataGridViewЗаказУслуг = new System.Windows.Forms.DataGridView();
            this.ID_заказ_услуг = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заказ_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Автомобиль_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуги_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Запчасти_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_запчастей = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxЗаказУслуг = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonУдалитьУслуги = new System.Windows.Forms.Button();
            this.buttonОбновитьУслуги = new System.Windows.Forms.Button();
            this.buttonДобавитьУслуги = new System.Windows.Forms.Button();
            this.textBoxНазваниеУслуги = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewУслуги = new System.Windows.Forms.DataGridView();
            this.ID_Услуги = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonУдалитьЗапчасти = new System.Windows.Forms.Button();
            this.buttonОбновитьЗапчасти = new System.Windows.Forms.Button();
            this.buttonДобавитьЗапчасти = new System.Windows.Forms.Button();
            this.dataGridViewЗапчасти = new System.Windows.Forms.DataGridView();
            this.ID_Запчасти = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название_Запчасти = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Стоимость_запчасти = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxНазваниеЗапчасти = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonУдалитьРаботник = new System.Windows.Forms.Button();
            this.buttonОбновитьРаботник = new System.Windows.Forms.Button();
            this.buttonДобавитьРаботник = new System.Windows.Forms.Button();
            this.textBoxФамилияРаботник = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewРаботник = new System.Windows.Forms.DataGridView();
            this.ID_Работник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фамилия_работник = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Отчество = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Должность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Номер_телефона_рабтника = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Зарплата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewАвтомобиль)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказ)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказУслуг)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУслуги)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗапчасти)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewРаботник)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(-6, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1209, 634);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage1.Controls.Add(this.buttonОПрограмме);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxАвтомобиль);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewАвтомобиль);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1201, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автомобиль";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonПереходЧек);
            this.groupBox1.Controls.Add(this.buttonУдалитьАвтомобиль);
            this.groupBox1.Controls.Add(this.buttonОбновитьАвтомобиль);
            this.groupBox1.Controls.Add(this.buttonДобавитьАвтомобиль);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(999, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // buttonОПрограмме
            // 
            this.buttonОПрограмме.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОПрограмме.Location = new System.Drawing.Point(1033, 35);
            this.buttonОПрограмме.Name = "buttonОПрограмме";
            this.buttonОПрограмме.Size = new System.Drawing.Size(114, 60);
            this.buttonОПрограмме.TabIndex = 10;
            this.buttonОПрограмме.Text = "О программе";
            this.buttonОПрограмме.UseVisualStyleBackColor = true;
            this.buttonОПрограмме.Click += new System.EventHandler(this.buttonОПрограмме_Click);
            // 
            // buttonПереходЧек
            // 
            this.buttonПереходЧек.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonПереходЧек.Location = new System.Drawing.Point(28, 255);
            this.buttonПереходЧек.Name = "buttonПереходЧек";
            this.buttonПереходЧек.Size = new System.Drawing.Size(114, 60);
            this.buttonПереходЧек.TabIndex = 9;
            this.buttonПереходЧек.Text = "Чек";
            this.buttonПереходЧек.UseVisualStyleBackColor = true;
            this.buttonПереходЧек.Click += new System.EventHandler(this.buttonПереходЧек_Click);
            // 
            // buttonУдалитьАвтомобиль
            // 
            this.buttonУдалитьАвтомобиль.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьАвтомобиль.Location = new System.Drawing.Point(28, 178);
            this.buttonУдалитьАвтомобиль.Name = "buttonУдалитьАвтомобиль";
            this.buttonУдалитьАвтомобиль.Size = new System.Drawing.Size(120, 60);
            this.buttonУдалитьАвтомобиль.TabIndex = 2;
            this.buttonУдалитьАвтомобиль.Text = "Удалить";
            this.buttonУдалитьАвтомобиль.UseVisualStyleBackColor = true;
            this.buttonУдалитьАвтомобиль.Click += new System.EventHandler(this.buttonУдалитьАвтомобиль_Click);
            // 
            // buttonОбновитьАвтомобиль
            // 
            this.buttonОбновитьАвтомобиль.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОбновитьАвтомобиль.Location = new System.Drawing.Point(28, 101);
            this.buttonОбновитьАвтомобиль.Name = "buttonОбновитьАвтомобиль";
            this.buttonОбновитьАвтомобиль.Size = new System.Drawing.Size(120, 60);
            this.buttonОбновитьАвтомобиль.TabIndex = 1;
            this.buttonОбновитьАвтомобиль.Text = "Обновить";
            this.buttonОбновитьАвтомобиль.UseVisualStyleBackColor = true;
            this.buttonОбновитьАвтомобиль.Click += new System.EventHandler(this.buttonОбновитьАвтомобиль_Click);
            // 
            // buttonДобавитьАвтомобиль
            // 
            this.buttonДобавитьАвтомобиль.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьАвтомобиль.Location = new System.Drawing.Point(28, 19);
            this.buttonДобавитьАвтомобиль.Name = "buttonДобавитьАвтомобиль";
            this.buttonДобавитьАвтомобиль.Size = new System.Drawing.Size(120, 60);
            this.buttonДобавитьАвтомобиль.TabIndex = 0;
            this.buttonДобавитьАвтомобиль.Text = "Добавить";
            this.buttonДобавитьАвтомобиль.UseVisualStyleBackColor = true;
            this.buttonДобавитьАвтомобиль.Click += new System.EventHandler(this.buttonДобавитьАвтомобиль_Click);
            // 
            // textBoxАвтомобиль
            // 
            this.textBoxАвтомобиль.Location = new System.Drawing.Point(128, 6);
            this.textBoxАвтомобиль.Name = "textBoxАвтомобиль";
            this.textBoxАвтомобиль.Size = new System.Drawing.Size(170, 23);
            this.textBoxАвтомобиль.TabIndex = 3;
            this.textBoxАвтомобиль.TextChanged += new System.EventHandler(this.textBoxАвтомобиль_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск по марке";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewАвтомобиль
            // 
            this.dataGridViewАвтомобиль.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewАвтомобиль.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewАвтомобиль.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDАвто,
            this.Фамилия,
            this.Номер_телефона,
            this.Vin_номер,
            this.Марка,
            this.Модель,
            this.Год,
            this.Государственный_номер});
            this.dataGridViewАвтомобиль.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewАвтомобиль.Name = "dataGridViewАвтомобиль";
            this.dataGridViewАвтомобиль.Size = new System.Drawing.Size(970, 554);
            this.dataGridViewАвтомобиль.TabIndex = 1;
            // 
            // IDАвто
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDАвто.DefaultCellStyle = dataGridViewCellStyle1;
            this.IDАвто.HeaderText = "ID";
            this.IDАвто.Name = "IDАвто";
            this.IDАвто.Width = 50;
            // 
            // Фамилия
            // 
            this.Фамилия.HeaderText = "Фамилия";
            this.Фамилия.Name = "Фамилия";
            // 
            // Номер_телефона
            // 
            this.Номер_телефона.HeaderText = "Номер телефона";
            this.Номер_телефона.Name = "Номер_телефона";
            this.Номер_телефона.Width = 140;
            // 
            // Vin_номер
            // 
            this.Vin_номер.HeaderText = "Vin номер";
            this.Vin_номер.Name = "Vin_номер";
            this.Vin_номер.Width = 170;
            // 
            // Марка
            // 
            this.Марка.HeaderText = "Марка";
            this.Марка.Name = "Марка";
            // 
            // Модель
            // 
            this.Модель.HeaderText = "Модель";
            this.Модель.Name = "Модель";
            // 
            // Год
            // 
            this.Год.HeaderText = "Год";
            this.Год.Name = "Год";
            // 
            // Государственный_номер
            // 
            this.Государственный_номер.HeaderText = "Государственный_номер";
            this.Государственный_номер.Name = "Государственный_номер";
            this.Государственный_номер.Width = 160;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.textBoxЗаказ);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewЗаказ);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1201, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.photo_1605152276897_4f618f831968;
            this.pictureBox1.Location = new System.Drawing.Point(656, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(501, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonУдалитьЗаказ);
            this.groupBox2.Controls.Add(this.buttonОбновитьЗаказ);
            this.groupBox2.Controls.Add(this.buttonДобавитьЗаказ);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(367, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 260);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // buttonУдалитьЗаказ
            // 
            this.buttonУдалитьЗаказ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьЗаказ.Location = new System.Drawing.Point(26, 173);
            this.buttonУдалитьЗаказ.Name = "buttonУдалитьЗаказ";
            this.buttonУдалитьЗаказ.Size = new System.Drawing.Size(120, 60);
            this.buttonУдалитьЗаказ.TabIndex = 2;
            this.buttonУдалитьЗаказ.Text = "Удалить";
            this.buttonУдалитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonУдалитьЗаказ.Click += new System.EventHandler(this.buttonУдалитьЗаказ_Click);
            // 
            // buttonОбновитьЗаказ
            // 
            this.buttonОбновитьЗаказ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОбновитьЗаказ.Location = new System.Drawing.Point(26, 98);
            this.buttonОбновитьЗаказ.Name = "buttonОбновитьЗаказ";
            this.buttonОбновитьЗаказ.Size = new System.Drawing.Size(120, 60);
            this.buttonОбновитьЗаказ.TabIndex = 1;
            this.buttonОбновитьЗаказ.Text = "Обновить";
            this.buttonОбновитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonОбновитьЗаказ.Click += new System.EventHandler(this.buttonОбновитьЗаказ_Click);
            // 
            // buttonДобавитьЗаказ
            // 
            this.buttonДобавитьЗаказ.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьЗаказ.Location = new System.Drawing.Point(26, 19);
            this.buttonДобавитьЗаказ.Name = "buttonДобавитьЗаказ";
            this.buttonДобавитьЗаказ.Size = new System.Drawing.Size(120, 60);
            this.buttonДобавитьЗаказ.TabIndex = 0;
            this.buttonДобавитьЗаказ.Text = "Добавить";
            this.buttonДобавитьЗаказ.UseVisualStyleBackColor = true;
            this.buttonДобавитьЗаказ.Click += new System.EventHandler(this.buttonДобавитьЗаказ_Click);
            // 
            // textBoxЗаказ
            // 
            this.textBoxЗаказ.Location = new System.Drawing.Point(118, 6);
            this.textBoxЗаказ.Name = "textBoxЗаказ";
            this.textBoxЗаказ.Size = new System.Drawing.Size(170, 23);
            this.textBoxЗаказ.TabIndex = 2;
            this.textBoxЗаказ.TextChanged += new System.EventHandler(this.textBoxЗаказ_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Поиск по дате";
            // 
            // dataGridViewЗаказ
            // 
            this.dataGridViewЗаказ.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewЗаказ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗаказ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_заказ,
            this.Дата,
            this.Работник_ID});
            this.dataGridViewЗаказ.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewЗаказ.Name = "dataGridViewЗаказ";
            this.dataGridViewЗаказ.Size = new System.Drawing.Size(334, 554);
            this.dataGridViewЗаказ.TabIndex = 0;
            // 
            // ID_заказ
            // 
            this.ID_заказ.HeaderText = "ID";
            this.ID_заказ.Name = "ID_заказ";
            this.ID_заказ.Width = 50;
            // 
            // Дата
            // 
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.Width = 130;
            // 
            // Работник_ID
            // 
            this.Работник_ID.HeaderText = "Работник_ID";
            this.Работник_ID.Name = "Работник_ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.dataGridViewЗаказУслуг);
            this.tabPage3.Controls.Add(this.textBoxЗаказУслуг);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1201, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказ услуг";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonУдалитьЗаказУслуг);
            this.groupBox3.Controls.Add(this.buttonОбновитьЗаказУслуг);
            this.groupBox3.Controls.Add(this.buttonДобавитьЗаказУслуг);
            this.groupBox3.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(689, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 260);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // buttonУдалитьЗаказУслуг
            // 
            this.buttonУдалитьЗаказУслуг.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьЗаказУслуг.Location = new System.Drawing.Point(30, 180);
            this.buttonУдалитьЗаказУслуг.Name = "buttonУдалитьЗаказУслуг";
            this.buttonУдалитьЗаказУслуг.Size = new System.Drawing.Size(120, 60);
            this.buttonУдалитьЗаказУслуг.TabIndex = 2;
            this.buttonУдалитьЗаказУслуг.Text = "Удалить";
            this.buttonУдалитьЗаказУслуг.UseVisualStyleBackColor = true;
            this.buttonУдалитьЗаказУслуг.Click += new System.EventHandler(this.buttonУдалитьЗаказУслуг_Click);
            // 
            // buttonОбновитьЗаказУслуг
            // 
            this.buttonОбновитьЗаказУслуг.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОбновитьЗаказУслуг.Location = new System.Drawing.Point(30, 102);
            this.buttonОбновитьЗаказУслуг.Name = "buttonОбновитьЗаказУслуг";
            this.buttonОбновитьЗаказУслуг.Size = new System.Drawing.Size(120, 60);
            this.buttonОбновитьЗаказУслуг.TabIndex = 1;
            this.buttonОбновитьЗаказУслуг.Text = "Обновить";
            this.buttonОбновитьЗаказУслуг.UseVisualStyleBackColor = true;
            this.buttonОбновитьЗаказУслуг.Click += new System.EventHandler(this.buttonОбновитьЗаказУслуг_Click);
            // 
            // buttonДобавитьЗаказУслуг
            // 
            this.buttonДобавитьЗаказУслуг.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьЗаказУслуг.Location = new System.Drawing.Point(30, 19);
            this.buttonДобавитьЗаказУслуг.Name = "buttonДобавитьЗаказУслуг";
            this.buttonДобавитьЗаказУслуг.Size = new System.Drawing.Size(120, 60);
            this.buttonДобавитьЗаказУслуг.TabIndex = 0;
            this.buttonДобавитьЗаказУслуг.Text = "Добавить";
            this.buttonДобавитьЗаказУслуг.UseVisualStyleBackColor = true;
            this.buttonДобавитьЗаказУслуг.Click += new System.EventHandler(this.buttonДобавитьЗаказУслуг_Click);
            // 
            // dataGridViewЗаказУслуг
            // 
            this.dataGridViewЗаказУслуг.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewЗаказУслуг.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗаказУслуг.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_заказ_услуг,
            this.Заказ_ID,
            this.Автомобиль_ID,
            this.Услуги_ID,
            this.Запчасти_ID,
            this.Количество_запчастей});
            this.dataGridViewЗаказУслуг.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewЗаказУслуг.Name = "dataGridViewЗаказУслуг";
            this.dataGridViewЗаказУслуг.Size = new System.Drawing.Size(658, 554);
            this.dataGridViewЗаказУслуг.TabIndex = 2;
            // 
            // ID_заказ_услуг
            // 
            this.ID_заказ_услуг.HeaderText = "ID";
            this.ID_заказ_услуг.Name = "ID_заказ_услуг";
            this.ID_заказ_услуг.Width = 50;
            // 
            // Заказ_ID
            // 
            this.Заказ_ID.HeaderText = "Заказ_ID";
            this.Заказ_ID.Name = "Заказ_ID";
            // 
            // Автомобиль_ID
            // 
            this.Автомобиль_ID.HeaderText = "Автомобиль_ID";
            this.Автомобиль_ID.Name = "Автомобиль_ID";
            // 
            // Услуги_ID
            // 
            this.Услуги_ID.HeaderText = "Услуги_ID";
            this.Услуги_ID.Name = "Услуги_ID";
            // 
            // Запчасти_ID
            // 
            this.Запчасти_ID.HeaderText = "Запчасти_ID";
            this.Запчасти_ID.Name = "Запчасти_ID";
            // 
            // Количество_запчастей
            // 
            this.Количество_запчастей.HeaderText = "Количество_запчастей";
            this.Количество_запчастей.Name = "Количество_запчастей";
            this.Количество_запчастей.Width = 150;
            // 
            // textBoxЗаказУслуг
            // 
            this.textBoxЗаказУслуг.Location = new System.Drawing.Point(239, 6);
            this.textBoxЗаказУслуг.Name = "textBoxЗаказУслуг";
            this.textBoxЗаказУслуг.Size = new System.Drawing.Size(170, 23);
            this.textBoxЗаказУслуг.TabIndex = 1;
            this.textBoxЗаказУслуг.TextChanged += new System.EventHandler(this.textBoxЗаказУслуг_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Поиск по количеству запчастей";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.textBoxНазваниеУслуги);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.dataGridViewУслуги);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1201, 603);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Услуги";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.mintosko_hCDCMCF03TE_unsplash;
            this.pictureBox2.Location = new System.Drawing.Point(839, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 570);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonУдалитьУслуги);
            this.groupBox4.Controls.Add(this.buttonОбновитьУслуги);
            this.groupBox4.Controls.Add(this.buttonДобавитьУслуги);
            this.groupBox4.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(462, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 260);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // buttonУдалитьУслуги
            // 
            this.buttonУдалитьУслуги.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьУслуги.Location = new System.Drawing.Point(27, 179);
            this.buttonУдалитьУслуги.Name = "buttonУдалитьУслуги";
            this.buttonУдалитьУслуги.Size = new System.Drawing.Size(120, 60);
            this.buttonУдалитьУслуги.TabIndex = 2;
            this.buttonУдалитьУслуги.Text = "Удалить";
            this.buttonУдалитьУслуги.UseVisualStyleBackColor = true;
            this.buttonУдалитьУслуги.Click += new System.EventHandler(this.buttonУдалитьУслуги_Click);
            // 
            // buttonОбновитьУслуги
            // 
            this.buttonОбновитьУслуги.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОбновитьУслуги.Location = new System.Drawing.Point(27, 97);
            this.buttonОбновитьУслуги.Name = "buttonОбновитьУслуги";
            this.buttonОбновитьУслуги.Size = new System.Drawing.Size(120, 60);
            this.buttonОбновитьУслуги.TabIndex = 1;
            this.buttonОбновитьУслуги.Text = "Обновить";
            this.buttonОбновитьУслуги.UseVisualStyleBackColor = true;
            this.buttonОбновитьУслуги.Click += new System.EventHandler(this.buttonОбновитьУслуги_Click);
            // 
            // buttonДобавитьУслуги
            // 
            this.buttonДобавитьУслуги.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьУслуги.Location = new System.Drawing.Point(27, 19);
            this.buttonДобавитьУслуги.Name = "buttonДобавитьУслуги";
            this.buttonДобавитьУслуги.Size = new System.Drawing.Size(120, 60);
            this.buttonДобавитьУслуги.TabIndex = 0;
            this.buttonДобавитьУслуги.Text = "Добавить";
            this.buttonДобавитьУслуги.UseVisualStyleBackColor = true;
            this.buttonДобавитьУслуги.Click += new System.EventHandler(this.buttonДобавитьУслуги_Click);
            // 
            // textBoxНазваниеУслуги
            // 
            this.textBoxНазваниеУслуги.Location = new System.Drawing.Point(153, 6);
            this.textBoxНазваниеУслуги.Name = "textBoxНазваниеУслуги";
            this.textBoxНазваниеУслуги.Size = new System.Drawing.Size(170, 23);
            this.textBoxНазваниеУслуги.TabIndex = 2;
            this.textBoxНазваниеУслуги.TextChanged += new System.EventHandler(this.textBoxУслуги_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Поиск по названию";
            // 
            // dataGridViewУслуги
            // 
            this.dataGridViewУслуги.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewУслуги.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewУслуги.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Услуги,
            this.Название,
            this.Цена});
            this.dataGridViewУслуги.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewУслуги.Name = "dataGridViewУслуги";
            this.dataGridViewУслуги.Size = new System.Drawing.Size(406, 554);
            this.dataGridViewУслуги.TabIndex = 0;
            // 
            // ID_Услуги
            // 
            this.ID_Услуги.HeaderText = "ID";
            this.ID_Услуги.Name = "ID_Услуги";
            this.ID_Услуги.Width = 50;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            this.Название.Width = 200;
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage5.Controls.Add(this.pictureBox3);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.dataGridViewЗапчасти);
            this.tabPage5.Controls.Add(this.textBoxНазваниеЗапчасти);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1201, 603);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Запчасти";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.sten_rademaker_UZUzvJEvKnI_unsplash;
            this.pictureBox3.Location = new System.Drawing.Point(825, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(361, 577);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonУдалитьЗапчасти);
            this.groupBox5.Controls.Add(this.buttonОбновитьЗапчасти);
            this.groupBox5.Controls.Add(this.buttonДобавитьЗапчасти);
            this.groupBox5.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(579, 140);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(180, 260);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // buttonУдалитьЗапчасти
            // 
            this.buttonУдалитьЗапчасти.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьЗапчасти.Location = new System.Drawing.Point(29, 180);
            this.buttonУдалитьЗапчасти.Name = "buttonУдалитьЗапчасти";
            this.buttonУдалитьЗапчасти.Size = new System.Drawing.Size(120, 60);
            this.buttonУдалитьЗапчасти.TabIndex = 2;
            this.buttonУдалитьЗапчасти.Text = "Удалить";
            this.buttonУдалитьЗапчасти.UseVisualStyleBackColor = true;
            this.buttonУдалитьЗапчасти.Click += new System.EventHandler(this.buttonУдалитьЗапчасти_Click);
            // 
            // buttonОбновитьЗапчасти
            // 
            this.buttonОбновитьЗапчасти.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОбновитьЗапчасти.Location = new System.Drawing.Point(29, 97);
            this.buttonОбновитьЗапчасти.Name = "buttonОбновитьЗапчасти";
            this.buttonОбновитьЗапчасти.Size = new System.Drawing.Size(120, 60);
            this.buttonОбновитьЗапчасти.TabIndex = 1;
            this.buttonОбновитьЗапчасти.Text = "Обновить";
            this.buttonОбновитьЗапчасти.UseVisualStyleBackColor = true;
            this.buttonОбновитьЗапчасти.Click += new System.EventHandler(this.buttonОбновитьЗапчасти_Click);
            // 
            // buttonДобавитьЗапчасти
            // 
            this.buttonДобавитьЗапчасти.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьЗапчасти.Location = new System.Drawing.Point(29, 19);
            this.buttonДобавитьЗапчасти.Name = "buttonДобавитьЗапчасти";
            this.buttonДобавитьЗапчасти.Size = new System.Drawing.Size(120, 60);
            this.buttonДобавитьЗапчасти.TabIndex = 0;
            this.buttonДобавитьЗапчасти.Text = "Добавить";
            this.buttonДобавитьЗапчасти.UseVisualStyleBackColor = true;
            this.buttonДобавитьЗапчасти.Click += new System.EventHandler(this.buttonДобавитьЗапчасти_Click);
            // 
            // dataGridViewЗапчасти
            // 
            this.dataGridViewЗапчасти.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewЗапчасти.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗапчасти.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Запчасти,
            this.Название_Запчасти,
            this.Стоимость_запчасти,
            this.Описание});
            this.dataGridViewЗапчасти.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewЗапчасти.Name = "dataGridViewЗапчасти";
            this.dataGridViewЗапчасти.Size = new System.Drawing.Size(536, 554);
            this.dataGridViewЗапчасти.TabIndex = 2;
            // 
            // ID_Запчасти
            // 
            this.ID_Запчасти.HeaderText = "ID";
            this.ID_Запчасти.Name = "ID_Запчасти";
            this.ID_Запчасти.Width = 50;
            // 
            // Название_Запчасти
            // 
            this.Название_Запчасти.HeaderText = "Название";
            this.Название_Запчасти.Name = "Название_Запчасти";
            this.Название_Запчасти.Width = 130;
            // 
            // Стоимость_запчасти
            // 
            this.Стоимость_запчасти.HeaderText = "Стоимость, грн";
            this.Стоимость_запчасти.Name = "Стоимость_запчасти";
            this.Стоимость_запчасти.Width = 150;
            // 
            // Описание
            // 
            this.Описание.HeaderText = "Описание";
            this.Описание.Name = "Описание";
            this.Описание.Width = 150;
            // 
            // textBoxНазваниеЗапчасти
            // 
            this.textBoxНазваниеЗапчасти.Location = new System.Drawing.Point(153, 5);
            this.textBoxНазваниеЗапчасти.Name = "textBoxНазваниеЗапчасти";
            this.textBoxНазваниеЗапчасти.Size = new System.Drawing.Size(170, 23);
            this.textBoxНазваниеЗапчасти.TabIndex = 1;
            this.textBoxНазваниеЗапчасти.TextChanged += new System.EventHandler(this.textBoxЗапчасти_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Поиск по названию";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPage6.Controls.Add(this.groupBox6);
            this.tabPage6.Controls.Add(this.textBoxФамилияРаботник);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.dataGridViewРаботник);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1201, 603);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Работник";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonУдалитьРаботник);
            this.groupBox6.Controls.Add(this.buttonОбновитьРаботник);
            this.groupBox6.Controls.Add(this.buttonДобавитьРаботник);
            this.groupBox6.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.Location = new System.Drawing.Point(794, 140);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 260);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            // 
            // buttonУдалитьРаботник
            // 
            this.buttonУдалитьРаботник.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьРаботник.Location = new System.Drawing.Point(31, 178);
            this.buttonУдалитьРаботник.Name = "buttonУдалитьРаботник";
            this.buttonУдалитьРаботник.Size = new System.Drawing.Size(120, 60);
            this.buttonУдалитьРаботник.TabIndex = 2;
            this.buttonУдалитьРаботник.Text = "Удалить";
            this.buttonУдалитьРаботник.UseVisualStyleBackColor = true;
            this.buttonУдалитьРаботник.Click += new System.EventHandler(this.buttonУдалитьРаботник_Click);
            // 
            // buttonОбновитьРаботник
            // 
            this.buttonОбновитьРаботник.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonОбновитьРаботник.Location = new System.Drawing.Point(31, 97);
            this.buttonОбновитьРаботник.Name = "buttonОбновитьРаботник";
            this.buttonОбновитьРаботник.Size = new System.Drawing.Size(120, 60);
            this.buttonОбновитьРаботник.TabIndex = 1;
            this.buttonОбновитьРаботник.Text = "Обновить";
            this.buttonОбновитьРаботник.UseVisualStyleBackColor = true;
            this.buttonОбновитьРаботник.Click += new System.EventHandler(this.buttonОбновитьРаботник_Click);
            // 
            // buttonДобавитьРаботник
            // 
            this.buttonДобавитьРаботник.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьРаботник.Location = new System.Drawing.Point(31, 19);
            this.buttonДобавитьРаботник.Name = "buttonДобавитьРаботник";
            this.buttonДобавитьРаботник.Size = new System.Drawing.Size(120, 60);
            this.buttonДобавитьРаботник.TabIndex = 0;
            this.buttonДобавитьРаботник.Text = "Добавить";
            this.buttonДобавитьРаботник.UseVisualStyleBackColor = true;
            this.buttonДобавитьРаботник.Click += new System.EventHandler(this.buttonДобавитьРаботник_Click);
            // 
            // textBoxФамилияРаботник
            // 
            this.textBoxФамилияРаботник.Location = new System.Drawing.Point(151, 5);
            this.textBoxФамилияРаботник.Name = "textBoxФамилияРаботник";
            this.textBoxФамилияРаботник.Size = new System.Drawing.Size(170, 23);
            this.textBoxФамилияРаботник.TabIndex = 2;
            this.textBoxФамилияРаботник.TextChanged += new System.EventHandler(this.textBoxФамилияРаботник_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Поиск по фамилии";
            // 
            // dataGridViewРаботник
            // 
            this.dataGridViewРаботник.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewРаботник.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewРаботник.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Работник,
            this.Фамилия_работник,
            this.Имя,
            this.Отчество,
            this.Должность,
            this.Номер_телефона_рабтника,
            this.Зарплата});
            this.dataGridViewРаботник.Location = new System.Drawing.Point(7, 35);
            this.dataGridViewРаботник.Name = "dataGridViewРаботник";
            this.dataGridViewРаботник.Size = new System.Drawing.Size(766, 554);
            this.dataGridViewРаботник.TabIndex = 0;
            // 
            // ID_Работник
            // 
            this.ID_Работник.HeaderText = "ID";
            this.ID_Работник.Name = "ID_Работник";
            this.ID_Работник.Width = 50;
            // 
            // Фамилия_работник
            // 
            this.Фамилия_работник.HeaderText = "Фамилия";
            this.Фамилия_работник.Name = "Фамилия_работник";
            // 
            // Имя
            // 
            this.Имя.HeaderText = "Имя";
            this.Имя.Name = "Имя";
            // 
            // Отчество
            // 
            this.Отчество.HeaderText = "Отчество";
            this.Отчество.Name = "Отчество";
            // 
            // Должность
            // 
            this.Должность.HeaderText = "Должность";
            this.Должность.Name = "Должность";
            this.Должность.Width = 130;
            // 
            // Номер_телефона_рабтника
            // 
            this.Номер_телефона_рабтника.HeaderText = "Номер_телефона";
            this.Номер_телефона_рабтника.Name = "Номер_телефона_рабтника";
            this.Номер_телефона_рабтника.Width = 120;
            // 
            // Зарплата
            // 
            this.Зарплата.HeaderText = "Зарплата, грн";
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Width = 120;
            // 
            // Автомобиль
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1198, 630);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Автомобиль";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СТО";
            this.Load += new System.EventHandler(this.Автомобиль_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewАвтомобиль)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказ)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗаказУслуг)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУслуги)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗапчасти)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewРаботник)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewАвтомобиль;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxАвтомобиль;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonУдалитьАвтомобиль;
        private System.Windows.Forms.Button buttonОбновитьАвтомобиль;
        private System.Windows.Forms.Button buttonДобавитьАвтомобиль;
        private System.Windows.Forms.TextBox textBoxЗаказ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewЗаказ;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonУдалитьЗаказ;
        private System.Windows.Forms.Button buttonОбновитьЗаказ;
        private System.Windows.Forms.Button buttonДобавитьЗаказ;
        private System.Windows.Forms.DataGridView dataGridViewЗаказУслуг;
        private System.Windows.Forms.TextBox textBoxЗаказУслуг;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonУдалитьЗаказУслуг;
        private System.Windows.Forms.Button buttonОбновитьЗаказУслуг;
        private System.Windows.Forms.Button buttonДобавитьЗаказУслуг;
        private System.Windows.Forms.TextBox textBoxНазваниеУслуги;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewУслуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Услуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonУдалитьУслуги;
        private System.Windows.Forms.Button buttonОбновитьУслуги;
        private System.Windows.Forms.Button buttonДобавитьУслуги;
        private System.Windows.Forms.DataGridView dataGridViewЗапчасти;
        private System.Windows.Forms.TextBox textBoxНазваниеЗапчасти;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonУдалитьЗапчасти;
        private System.Windows.Forms.Button buttonОбновитьЗапчасти;
        private System.Windows.Forms.Button buttonДобавитьЗапчасти;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Запчасти;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название_Запчасти;
        private System.Windows.Forms.DataGridViewTextBoxColumn Стоимость_запчасти;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
        private System.Windows.Forms.TextBox textBoxФамилияРаботник;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewРаботник;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonУдалитьРаботник;
        private System.Windows.Forms.Button buttonОбновитьРаботник;
        private System.Windows.Forms.Button buttonДобавитьРаботник;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_заказ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Работник_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Работник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия_работник;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Отчество;
        private System.Windows.Forms.DataGridViewTextBoxColumn Должность;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона_рабтника;
        private System.Windows.Forms.DataGridViewTextBoxColumn Зарплата;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_заказ_услуг;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заказ_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Автомобиль_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуги_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Запчасти_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_запчастей;
        private System.Windows.Forms.Button buttonПереходЧек;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDАвто;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер_телефона;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vin_номер;
        private System.Windows.Forms.DataGridViewTextBoxColumn Марка;
        private System.Windows.Forms.DataGridViewTextBoxColumn Модель;
        private System.Windows.Forms.DataGridViewTextBoxColumn Год;
        private System.Windows.Forms.DataGridViewTextBoxColumn Государственный_номер;
        private System.Windows.Forms.Button buttonОПрограмме;
    }
}

