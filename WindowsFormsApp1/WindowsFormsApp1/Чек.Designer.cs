namespace WindowsFormsApp1
{
    partial class Чек
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Чек));
            this.comboBoxСотрудник = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonДобавитьВЧек = new System.Windows.Forms.Button();
            this.dataGridViewЧек = new System.Windows.Forms.DataGridView();
            this.buttonПереходАвтомобиль = new System.Windows.Forms.Button();
            this.buttonСоздатьПродажу = new System.Windows.Forms.Button();
            this.numericUpDownКоличествоЗапчастей = new System.Windows.Forms.NumericUpDown();
            this.buttonСоздатьНовыйЧек = new System.Windows.Forms.Button();
            this.dataGridViewЗапчасти = new System.Windows.Forms.DataGridView();
            this.ID_Запчасти = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewУслуги = new System.Windows.Forms.DataGridView();
            this.buttonУдалитьИзЧека = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxОбщаяСумма = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonФормарованиеЧек = new System.Windows.Forms.Button();
            this.printPreviewDialogФормированиеЧека = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentЧек = new System.Drawing.Printing.PrintDocument();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заказ_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Автомобиль_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Услуга_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Запчасть_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Количество_запчастей = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_запчасти = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_Услуги = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена_по_записи = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Услуга = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Название2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Цена2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЧек)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownКоличествоЗапчастей)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗапчасти)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУслуги)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxСотрудник
            // 
            this.comboBoxСотрудник.DisplayMember = "ID";
            this.comboBoxСотрудник.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxСотрудник.FormattingEnabled = true;
            this.comboBoxСотрудник.Location = new System.Drawing.Point(958, 22);
            this.comboBoxСотрудник.Name = "comboBoxСотрудник";
            this.comboBoxСотрудник.Size = new System.Drawing.Size(123, 26);
            this.comboBoxСотрудник.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(881, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник";
            // 
            // buttonДобавитьВЧек
            // 
            this.buttonДобавитьВЧек.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonДобавитьВЧек.Location = new System.Drawing.Point(1102, 360);
            this.buttonДобавитьВЧек.Name = "buttonДобавитьВЧек";
            this.buttonДобавитьВЧек.Size = new System.Drawing.Size(123, 86);
            this.buttonДобавитьВЧек.TabIndex = 4;
            this.buttonДобавитьВЧек.Text = "Добавить в чек";
            this.buttonДобавитьВЧек.UseVisualStyleBackColor = true;
            this.buttonДобавитьВЧек.Click += new System.EventHandler(this.buttonДобавитьВЧек_Click);
            // 
            // dataGridViewЧек
            // 
            this.dataGridViewЧек.AllowUserToAddRows = false;
            this.dataGridViewЧек.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewЧек.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewЧек.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЧек.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Заказ_ID,
            this.Автомобиль_ID,
            this.Услуга_ID,
            this.Запчасть_ID,
            this.Количество_запчастей,
            this.Цена_запчасти,
            this.Цена_Услуги,
            this.Цена_по_записи});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewЧек.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewЧек.Location = new System.Drawing.Point(12, 360);
            this.dataGridViewЧек.Name = "dataGridViewЧек";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewЧек.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewЧек.Size = new System.Drawing.Size(782, 277);
            this.dataGridViewЧек.TabIndex = 7;
            // 
            // buttonПереходАвтомобиль
            // 
            this.buttonПереходАвтомобиль.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonПереходАвтомобиль.Location = new System.Drawing.Point(1325, 598);
            this.buttonПереходАвтомобиль.Name = "buttonПереходАвтомобиль";
            this.buttonПереходАвтомобиль.Size = new System.Drawing.Size(105, 39);
            this.buttonПереходАвтомобиль.TabIndex = 8;
            this.buttonПереходАвтомобиль.Text = "Справочник";
            this.buttonПереходАвтомобиль.UseVisualStyleBackColor = true;
            this.buttonПереходАвтомобиль.Click += new System.EventHandler(this.buttonПереходАвтомобиль_Click);
            // 
            // buttonСоздатьПродажу
            // 
            this.buttonСоздатьПродажу.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСоздатьПродажу.Location = new System.Drawing.Point(958, 82);
            this.buttonСоздатьПродажу.Name = "buttonСоздатьПродажу";
            this.buttonСоздатьПродажу.Size = new System.Drawing.Size(123, 86);
            this.buttonСоздатьПродажу.TabIndex = 10;
            this.buttonСоздатьПродажу.Text = "Создать продажу";
            this.buttonСоздатьПродажу.UseVisualStyleBackColor = true;
            this.buttonСоздатьПродажу.Click += new System.EventHandler(this.buttonСоздатьПродажу_Click);
            // 
            // numericUpDownКоличествоЗапчастей
            // 
            this.numericUpDownКоличествоЗапчастей.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownКоличествоЗапчастей.Location = new System.Drawing.Point(980, 392);
            this.numericUpDownКоличествоЗапчастей.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownКоличествоЗапчастей.Name = "numericUpDownКоличествоЗапчастей";
            this.numericUpDownКоличествоЗапчастей.Size = new System.Drawing.Size(89, 23);
            this.numericUpDownКоличествоЗапчастей.TabIndex = 11;
            this.numericUpDownКоличествоЗапчастей.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonСоздатьНовыйЧек
            // 
            this.buttonСоздатьНовыйЧек.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonСоздатьНовыйЧек.Location = new System.Drawing.Point(884, 529);
            this.buttonСоздатьНовыйЧек.Name = "buttonСоздатьНовыйЧек";
            this.buttonСоздатьНовыйЧек.Size = new System.Drawing.Size(123, 86);
            this.buttonСоздатьНовыйЧек.TabIndex = 16;
            this.buttonСоздатьНовыйЧек.Text = "Создать новый чек";
            this.buttonСоздатьНовыйЧек.UseVisualStyleBackColor = true;
            this.buttonСоздатьНовыйЧек.Click += new System.EventHandler(this.buttonСоздатьНовыйЧек_Click);
            // 
            // dataGridViewЗапчасти
            // 
            this.dataGridViewЗапчасти.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewЗапчасти.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewЗапчасти.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewЗапчасти.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Запчасти,
            this.Название,
            this.Цена,
            this.Описание});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewЗапчасти.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewЗапчасти.Location = new System.Drawing.Point(12, 9);
            this.dataGridViewЗапчасти.Name = "dataGridViewЗапчасти";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewЗапчасти.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewЗапчасти.Size = new System.Drawing.Size(447, 327);
            this.dataGridViewЗапчасти.TabIndex = 17;
            // 
            // ID_Запчасти
            // 
            this.ID_Запчасти.HeaderText = "ID";
            this.ID_Запчасти.Name = "ID_Запчасти";
            this.ID_Запчасти.Width = 50;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.Name = "Название";
            this.Название.Width = 150;
            // 
            // Цена
            // 
            this.Цена.HeaderText = "Цена";
            this.Цена.Name = "Цена";
            // 
            // Описание
            // 
            this.Описание.HeaderText = "Описание";
            this.Описание.Name = "Описание";
            // 
            // dataGridViewУслуги
            // 
            this.dataGridViewУслуги.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewУслуги.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewУслуги.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewУслуги.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Услуга,
            this.Название2,
            this.Цена2});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewУслуги.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewУслуги.Location = new System.Drawing.Point(475, 9);
            this.dataGridViewУслуги.Name = "dataGridViewУслуги";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewУслуги.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewУслуги.Size = new System.Drawing.Size(380, 327);
            this.dataGridViewУслуги.TabIndex = 18;
            // 
            // buttonУдалитьИзЧека
            // 
            this.buttonУдалитьИзЧека.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonУдалитьИзЧека.Location = new System.Drawing.Point(1102, 529);
            this.buttonУдалитьИзЧека.Name = "buttonУдалитьИзЧека";
            this.buttonУдалитьИзЧека.Size = new System.Drawing.Size(123, 86);
            this.buttonУдалитьИзЧека.TabIndex = 19;
            this.buttonУдалитьИзЧека.Text = "Удалить запись из чека";
            this.buttonУдалитьИзЧека.UseVisualStyleBackColor = true;
            this.buttonУдалитьИзЧека.Click += new System.EventHandler(this.buttonУдалитьИзЧека_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(833, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Количество запчастей";
            // 
            // textBoxОбщаяСумма
            // 
            this.textBoxОбщаяСумма.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxОбщаяСумма.Location = new System.Drawing.Point(1267, 20);
            this.textBoxОбщаяСумма.Name = "textBoxОбщаяСумма";
            this.textBoxОбщаяСумма.Size = new System.Drawing.Size(154, 23);
            this.textBoxОбщаяСумма.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1114, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Общая сумма по чеку :";
            // 
            // buttonФормарованиеЧек
            // 
            this.buttonФормарованиеЧек.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonФормарованиеЧек.Location = new System.Drawing.Point(1283, 82);
            this.buttonФормарованиеЧек.Name = "buttonФормарованиеЧек";
            this.buttonФормарованиеЧек.Size = new System.Drawing.Size(123, 86);
            this.buttonФормарованиеЧек.TabIndex = 23;
            this.buttonФормарованиеЧек.Text = "Печать чека";
            this.buttonФормарованиеЧек.UseVisualStyleBackColor = true;
            this.buttonФормарованиеЧек.Click += new System.EventHandler(this.buttonФормарованиеЧек_Click);
            // 
            // printPreviewDialogФормированиеЧека
            // 
            this.printPreviewDialogФормированиеЧека.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogФормированиеЧека.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogФормированиеЧека.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialogФормированиеЧека.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogФормированиеЧека.Document = this.printDocumentЧек;
            this.printPreviewDialogФормированиеЧека.Enabled = true;
            this.printPreviewDialogФормированиеЧека.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogФормированиеЧека.Icon")));
            this.printPreviewDialogФормированиеЧека.Name = "printPreviewDialogФормированиеЧека";
            this.printPreviewDialogФормированиеЧека.Visible = false;
            // 
            // printDocumentЧек
            // 
            this.printDocumentЧек.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentЧек_PrintPage);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 60;
            // 
            // Заказ_ID
            // 
            this.Заказ_ID.HeaderText = "Заказ_ID";
            this.Заказ_ID.Name = "Заказ_ID";
            this.Заказ_ID.Visible = false;
            this.Заказ_ID.Width = 70;
            // 
            // Автомобиль_ID
            // 
            this.Автомобиль_ID.HeaderText = "Автомобиль_ID";
            this.Автомобиль_ID.Name = "Автомобиль_ID";
            this.Автомобиль_ID.Width = 105;
            // 
            // Услуга_ID
            // 
            this.Услуга_ID.HeaderText = "Услуга_ID";
            this.Услуга_ID.Name = "Услуга_ID";
            this.Услуга_ID.Width = 75;
            // 
            // Запчасть_ID
            // 
            this.Запчасть_ID.HeaderText = "Запчасть_ID";
            this.Запчасть_ID.Name = "Запчасть_ID";
            this.Запчасть_ID.Width = 90;
            // 
            // Количество_запчастей
            // 
            this.Количество_запчастей.HeaderText = "Количество_запчастей";
            this.Количество_запчастей.Name = "Количество_запчастей";
            this.Количество_запчастей.Width = 150;
            // 
            // Цена_запчасти
            // 
            this.Цена_запчасти.HeaderText = "Цена_запчасти";
            this.Цена_запчасти.Name = "Цена_запчасти";
            this.Цена_запчасти.Width = 105;
            // 
            // Цена_Услуги
            // 
            this.Цена_Услуги.HeaderText = "Цена_Услуги";
            this.Цена_Услуги.Name = "Цена_Услуги";
            this.Цена_Услуги.Width = 95;
            // 
            // Цена_по_записи
            // 
            this.Цена_по_записи.HeaderText = "Цена_по_записи";
            this.Цена_по_записи.Name = "Цена_по_записи";
            this.Цена_по_записи.Width = 115;
            // 
            // ID_Услуга
            // 
            this.ID_Услуга.HeaderText = "ID";
            this.ID_Услуга.Name = "ID_Услуга";
            this.ID_Услуга.Width = 50;
            // 
            // Название2
            // 
            this.Название2.HeaderText = "Название";
            this.Название2.Name = "Название2";
            this.Название2.Width = 180;
            // 
            // Цена2
            // 
            this.Цена2.HeaderText = "Цена";
            this.Цена2.Name = "Цена2";
            // 
            // Чек
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1433, 643);
            this.Controls.Add(this.buttonФормарованиеЧек);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxОбщаяСумма);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonУдалитьИзЧека);
            this.Controls.Add(this.dataGridViewУслуги);
            this.Controls.Add(this.dataGridViewЗапчасти);
            this.Controls.Add(this.buttonСоздатьНовыйЧек);
            this.Controls.Add(this.numericUpDownКоличествоЗапчастей);
            this.Controls.Add(this.buttonСоздатьПродажу);
            this.Controls.Add(this.buttonПереходАвтомобиль);
            this.Controls.Add(this.dataGridViewЧек);
            this.Controls.Add(this.buttonДобавитьВЧек);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxСотрудник);
            this.Name = "Чек";
            this.Text = "Чек";
            this.Load += new System.EventHandler(this.Чек_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЧек)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownКоличествоЗапчастей)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewЗапчасти)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewУслуги)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxСотрудник;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonДобавитьВЧек;
        private System.Windows.Forms.DataGridView dataGridViewЧек;
        private System.Windows.Forms.Button buttonПереходАвтомобиль;
        private System.Windows.Forms.Button buttonСоздатьПродажу;
        private System.Windows.Forms.NumericUpDown numericUpDownКоличествоЗапчастей;
        private System.Windows.Forms.Button buttonСоздатьНовыйЧек;
        private System.Windows.Forms.DataGridView dataGridViewЗапчасти;
        private System.Windows.Forms.DataGridView dataGridViewУслуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Запчасти;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
        private System.Windows.Forms.Button buttonУдалитьИзЧека;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxОбщаяСумма;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonФормарованиеЧек;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogФормированиеЧека;
        private System.Drawing.Printing.PrintDocument printDocumentЧек;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заказ_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Автомобиль_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Услуга_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Запчасть_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Количество_запчастей;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_запчасти;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_Услуги;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена_по_записи;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Услуга;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Цена2;
    }
}