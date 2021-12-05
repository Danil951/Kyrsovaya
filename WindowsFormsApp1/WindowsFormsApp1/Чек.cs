using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Чек : Form
    {
        public Чек()
        {
            InitializeComponent();
        }

        const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

        private void refreshDataTableЧек()
        {
            string query = "SELECT ID FROM Працівник";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connectionString);
            DataTable source = new DataTable();
            dAdapter.Fill(source);
            comboBoxСотрудник.DataSource = source;

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query4 = "SELECT * FROM Запчастини";
            OleDbCommand dbCommand = new OleDbCommand(query4, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            string query5 = "SELECT * FROM Послуги";
            OleDbCommand dbCommandУслуги = new OleDbCommand(query5, dbConnection);
            OleDbDataReader dbReaderУслуги = dbCommandУслуги.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridViewЗапчасти.Rows.Add(dbReader["ID"], dbReader["Назва"], dbReader["Вартість"], dbReader["Опис"]);
                }
                while (dbReaderУслуги.Read())
                {
                    dataGridViewУслуги.Rows.Add(dbReaderУслуги["ID"], dbReaderУслуги["Назва"], dbReaderУслуги["Ціна"]);
                }
            }

            buttonДобавитьВЧек.Enabled = false;

            dbReader.Close();
            dbReaderУслуги.Close();
            dbConnection.Close();
        }
        private void Чек_Load(object sender, EventArgs e)
        {
            refreshDataTableЧек();
            buttonФормарованиеЧек.Enabled = false;
            buttonУдалитьИзЧека.Enabled = false;
        }

        private void calculateTotalPrice()
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение
            dbConnection.Open();

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Замовлення_чек";
            OleDbCommand tmpDbCommand = new OleDbCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();

            string querySumOfCheck = $@"SELECT Sum(Ціна_по_запису) FROM Замовлення_послуг WHERE Замовлення_ID = {maxID}";
            OleDbCommand dbCommandForCheck = new OleDbCommand(querySumOfCheck, dbConnection);

            double fullPrice = (double)dbCommandForCheck.ExecuteScalar();

            textBoxОбщаяСумма.Text = fullPrice.ToString();

            dbConnection.Close();
        }

        private void buttonПереходАвтомобиль_Click(object sender, EventArgs e)
        {
            Автомобиль Автомобиль = new Автомобиль();
            Автомобиль.ShowDialog();
        }
        private void buttonСоздатьПродажу_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            DateTime dt = DateTime.Now;
            string Працівник_ID = comboBoxСотрудник.Text.ToString();

            string query = $@"INSERT INTO Замовлення_чек (Дата, Працівник_ID) VALUES('{dt}', '{Працівник_ID}')";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                buttonСоздатьПродажу.Enabled = false;
                buttonДобавитьВЧек.Enabled = true;

                return;
            }

            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonДобавитьВЧек_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            textBoxОбщаяСумма.Text = "";

            buttonСоздатьНовыйЧек.Enabled = true;

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Замовлення_чек";
            OleDbCommand tmpDbCommand = new OleDbCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();

            string tmpQueryGetMaxIDАвтомобиль = $@"SELECT MAX(ID) FROM Автомобіль";
            OleDbCommand tmp2DbCommand = new OleDbCommand(tmpQueryGetMaxIDАвтомобиль, dbConnection);
            int maxIDАвтомобиль = (int)tmp2DbCommand.ExecuteScalar();

            int index = dataGridViewЗапчасти.SelectedRows[0].Index;

            string ID_запчастини = dataGridViewЗапчасти.Rows[index].Cells[0].Value.ToString();
            string Ціна_запчастини = dataGridViewЗапчасти.Rows[index].Cells[2].Value.ToString();

            string ID_послуги = dataGridViewУслуги.Rows[index].Cells[0].Value.ToString();
            string Ціна_послуги = dataGridViewУслуги.Rows[index].Cells[2].Value.ToString();

            int Кількість_запчастин = Convert.ToInt32(numericUpDownКоличествоЗапчастей.Value);

            int Ціна_по_запису = (Convert.ToInt32(Ціна_запчастини) + Convert.ToInt32(Ціна_послуги)) * Convert.ToInt32(Кількість_запчастин);

            string query = $@"INSERT INTO Замовлення_послуг (Замовлення_ID, Автомобіль_ID, Послуга_ID, Запчастина_ID, Кількість_запчастин, Ціна_запчастини, Ціна_послуги, Ціна_по_запису)
            VALUES({maxID}, '{maxIDАвтомобиль}', '{ID_послуги}', {ID_запчастини}, {Кількість_запчастин}, {Ціна_запчастини}, {Ціна_послуги}, {Ціна_по_запису})";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
            {
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                return;
            }

            dataGridViewЧек.Rows.Clear();

            string queryReadCheck = $@"SELECT * FROM Замовлення_послуг WHERE Замовлення_ID = {maxID}";
            OleDbCommand dbCommandReadCheck = new OleDbCommand(queryReadCheck, dbConnection);
            OleDbDataReader dbReader = dbCommandReadCheck.ExecuteReader();

            while (dbReader.Read())
            {
                dataGridViewЧек.Rows.Add(dbReader["ID"], dbReader["Замовлення_ID"], dbReader["Автомобіль_ID"],
                    dbReader["Послуга_ID"], dbReader["Запчастина_ID"], dbReader["Кількість_запчастин"], dbReader["Ціна_запчастини"], dbReader["Ціна_послуги"], dbReader["Ціна_по_запису"]);
            }

            calculateTotalPrice();
            dataGridViewЧек.Height += 10;
            buttonФормарованиеЧек.Enabled = true;
            buttonУдалитьИзЧека.Enabled = true;

            dbReader.Close();
            dbConnection.Close();
        }
        private void buttonСоздатьНовыйЧек_Click(object sender, EventArgs e)
        {
            textBoxОбщаяСумма.Text = "";
            dataGridViewЧек.Rows.Clear();
            buttonСоздатьНовыйЧек.Enabled = false;
            buttonСоздатьПродажу.Enabled = true;
            buttonДобавитьВЧек.Enabled = false;
            buttonФормарованиеЧек.Enabled = false;
            buttonУдалитьИзЧека.Enabled = false;
            numericUpDownКоличествоЗапчастей.Value = 1;
        }
        private void buttonУдалитьИзЧека_Click(object sender, EventArgs e)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            if (dataGridViewЧек.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку из чека!", "Внимание!");
                return;
            }
            textBoxОбщаяСумма.Text = "";

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Замовлення_чек";
            OleDbCommand tmpDbCommand = new OleDbCommand(tmpQueryGetMaxID, dbConnection);

            int index = dataGridViewЧек.SelectedRows[0].Index;

            int maxID = (int)tmpDbCommand.ExecuteScalar();
            string ID = dataGridViewЧек.Rows[index].Cells[0].Value.ToString();

            string query = $@"DELETE FROM Замовлення_послуг WHERE Замовлення_ID = {maxID} And ID = {ID}";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() == 1)
            {
                dataGridViewЧек.Rows.RemoveAt(index);
                calculateTotalPrice();
                return;
            }

            MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            dbConnection.Close();
        }
        private void buttonФормарованиеЧек_Click(object sender, EventArgs e)
        {
            printPreviewDialogФормированиеЧека.ShowDialog();
        }
        private void printDocumentЧек_PrintPage(object sender, PrintPageEventArgs e)
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            Bitmap bmp = new Bitmap(dataGridViewЧек.Size.Width + 1225, dataGridViewЧек.Size.Height + 678);

            dataGridViewЧек.DrawToBitmap(bmp, dataGridViewЧек.Bounds);

            string tmpQueryGetMaxID = $@"SELECT MAX(ID) FROM Замовлення_послуг";
            OleDbCommand tmpDbCommand = new OleDbCommand(tmpQueryGetMaxID, dbConnection);
            int maxID = (int)tmpDbCommand.ExecuteScalar();

            e.Graphics.DrawString($"СТО", new Font("Trebuchet", 16, FontStyle.Bold), Brushes.Black, new PointF(380, 25));

            e.Graphics.DrawString($"Чек № {maxID}", new Font("Trebuchet", 16, FontStyle.Bold), Brushes.Black, new PointF(350, 50));
            e.Graphics.DrawString($"Дата: {DateTime.Now}", new Font("Trebuchet", 16, FontStyle.Bold), Brushes.Black, new PointF(50, 100));
            e.Graphics.DrawString($"Сотрудник: {comboBoxСотрудник.Text}", new Font("Trebuchet", 16, FontStyle.Bold), Brushes.Black, new PointF(600, 100));

            e.Graphics.DrawImage(bmp, -5, -200);

            e.Graphics.DrawString($"ОБЩАЯ СУММА:", new Font("Trebuchet", 18, FontStyle.Bold), Brushes.Blue,
            new PointF(dataGridViewЧек.Size.Width - 490, dataGridViewЧек.Size.Height + 225));

            e.Graphics.DrawString(textBoxОбщаяСумма.Text, new Font("Trebuchet", 18, FontStyle.Bold), Brushes.Blue,
            new PointF(dataGridViewЧек.Size.Width - 260, dataGridViewЧек.Size.Height + 225));

            dbConnection.Close();
        }
    }
}