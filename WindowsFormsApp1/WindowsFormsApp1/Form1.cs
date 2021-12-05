using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Автомобиль : Form
    {
        public Автомобиль()
        {
            InitializeComponent();
        }

        const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

        private void buttonОПрограмме_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу создал Проценко Данил Александрович РПЗ 19 1/9");
        }


        private void refreshDataTableАвтомобиль()
        {

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Автомобіль";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridViewАвтомобиль.Rows.Add(dbReader["ID"], dbReader["Прізвище"], dbReader["Номер_телефону"], dbReader["Vin_номер"], dbReader["Марка"], dbReader["Модель"], dbReader["Рік"], dbReader["Державний_номер"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }
        private void refreshDataTableЗаказ()
        {

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Замовлення_чек";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("1111Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridViewЗаказ.Rows.Add(dbReader["ID"], dbReader["Дата"], dbReader["Працівник_ID"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }
        private void refreshDataTableЗаказУслуг()
        {

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Замовлення_послуг";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("1111Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridViewЗаказУслуг.Rows.Add(dbReader["ID"], dbReader["Замовлення_ID"], dbReader["Автомобіль_ID"], dbReader["Послуга_ID"], dbReader["Запчастина_ID"], dbReader["Кількість_запчастин"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }
        private void refreshDataTableУслуги()
        {
            OleDbConnection dbConnection = new OleDbConnection(connectionString);


            dbConnection.Open();
            string query = "SELECT * FROM Послуги";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridViewУслуги.Rows.Add(dbReader["ID"], dbReader["Назва"], dbReader["Ціна"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }
        private void refreshDataTableЗапчасти()
        {

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Запчастини";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

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
            }
            dbReader.Close();
            dbConnection.Close();
        }
        private void refreshDataTableРаботник()
        {

            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "SELECT * FROM Працівник";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            OleDbDataReader dbReader = dbCommand.ExecuteReader();

            if (dbReader.HasRows == false)
            {
                MessageBox.Show("Данные не найдены!", "Ошибка!");
            }
            else
            {
                while (dbReader.Read())
                {
                    dataGridViewРаботник.Rows.Add(dbReader["ID"], dbReader["Прізвище"], dbReader["Імя"], dbReader["По_батькові"], dbReader["Посада"], dbReader["Номер_телефону"], dbReader["Заробітна_плата"]);
                }
            }
            dbReader.Close();
            dbConnection.Close();
        }


        private void Автомобиль_Load(object sender, EventArgs e)
        {
            refreshDataTableАвтомобиль();
            refreshDataTableЗаказ();
            refreshDataTableЗаказУслуг();
            refreshDataTableУслуги();
            refreshDataTableЗапчасти();
            refreshDataTableРаботник();
        }


        private void buttonДобавитьАвтомобиль_Click(object sender, EventArgs e)
        {
            if (dataGridViewАвтомобиль.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewАвтомобиль.SelectedRows[0].Index;

            string Прізвище = dataGridViewАвтомобиль.Rows[index].Cells[1].Value.ToString();
            string Номер_телефону = dataGridViewАвтомобиль.Rows[index].Cells[2].Value.ToString();
            string Vin_номер = dataGridViewАвтомобиль.Rows[index].Cells[3].Value.ToString();
            string Марка = dataGridViewАвтомобиль.Rows[index].Cells[4].Value.ToString();
            string Модель = dataGridViewАвтомобиль.Rows[index].Cells[5].Value.ToString();
            string Рік = dataGridViewАвтомобиль.Rows[index].Cells[6].Value.ToString();
            string Державний_номер = dataGridViewАвтомобиль.Rows[index].Cells[7].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = $@"INSERT INTO Автомобіль (Прізвище, Номер_телефону, Vin_номер, Марка, Модель, Рік, Державний_номер)
            VALUES('{Прізвище}', '{Номер_телефону}', '{Vin_номер}', '{Марка}', '{Модель}', '{Рік}', '{Державний_номер}')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
                dataGridViewАвтомобиль.Rows.Clear();
                refreshDataTableАвтомобиль();
            }
            dbConnection.Close();
        }
        private void buttonОбновитьАвтомобиль_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            if (dataGridViewАвтомобиль.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewАвтомобиль.SelectedRows[0].Index;

            int ID = Convert.ToInt32(dataGridViewАвтомобиль.Rows[index].Cells[0].Value.ToString());
            string Прізвище = dataGridViewАвтомобиль.Rows[index].Cells[1].Value.ToString();
            string Номер_телефону = dataGridViewАвтомобиль.Rows[index].Cells[2].Value.ToString();
            string Vin_номер = dataGridViewАвтомобиль.Rows[index].Cells[3].Value.ToString();
            string Марка = dataGridViewАвтомобиль.Rows[index].Cells[4].Value.ToString();
            string Модель = dataGridViewАвтомобиль.Rows[index].Cells[5].Value.ToString();
            string Рік = dataGridViewАвтомобиль.Rows[index].Cells[6].Value.ToString();
            string Державний_номер = dataGridViewАвтомобиль.Rows[index].Cells[7].Value.ToString();

            dbConnection.Open();

            string query = $@"
            UPDATE Автомобіль SET
            [Прізвище] = '{Прізвище}',
            [Номер_телефону] = '{Номер_телефону}',
            [Vin_номер] = '{Vin_номер}',
            [Марка] = '{Марка}',
            [Модель] = '{Модель}',
            [Рік] = '{Рік}',
            [Державний_номер] = '{Державний_номер}'
            WHERE ID = {ID}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
                dataGridViewАвтомобиль.Rows.Clear();
                refreshDataTableАвтомобиль();
            }
            dbConnection.Close();
        }
        private void buttonУдалитьАвтомобиль_Click(object sender, EventArgs e)
        {
            if (dataGridViewАвтомобиль.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewАвтомобиль.SelectedRows[0].Index;

            if (dataGridViewАвтомобиль.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridViewАвтомобиль.Rows[index].Cells[0].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Автомобіль WHERE ID = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                dataGridViewАвтомобиль.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }
        private void textBoxАвтомобиль_TextChanged(object sender, EventArgs e)
        {
            const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            dataGridViewАвтомобиль.Rows.Clear();
            string querry = "SELECT [ID], [Прізвище], [Номер_телефону], [Vin_номер], [Марка], [Модель], [Рік], [Державний_номер]" +
            " FROM [Автомобіль] WHERE [Марка] LIKE '%" + textBoxАвтомобиль.Text + "%'";
            OleDbCommand dbCommand = new OleDbCommand(querry, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                dataGridViewАвтомобиль.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4], dbReader[5], dbReader[6], dbReader[7]);
            }
            while (dbReader.Read())
            {
                dataGridViewАвтомобиль.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4]);
            }
        }


        private void buttonДобавитьЗаказ_Click(object sender, EventArgs e)
        {
            if (dataGridViewЗаказ.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗаказ.SelectedRows[0].Index;

            string Дата = dataGridViewЗаказ.Rows[index].Cells[1].Value.ToString();
            string Працівник_ID = dataGridViewЗаказ.Rows[index].Cells[2].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = $@"INSERT INTO Замовлення_чек (Дата, Працівник_ID)
            VALUES('{Дата}', '{Працівник_ID}')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
                dataGridViewЗаказ.Rows.Clear();
                refreshDataTableЗаказ();
            }

            dbConnection.Close();
        }
        private void buttonОбновитьЗаказ_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            if (dataGridViewЗаказ.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗаказ.SelectedRows[0].Index;

            int ID = Convert.ToInt32(dataGridViewЗаказ.Rows[index].Cells[0].Value.ToString());
            string Дата = dataGridViewЗаказ.Rows[index].Cells[1].Value.ToString();
            string Працівник_ID = dataGridViewЗаказ.Rows[index].Cells[2].Value.ToString();

            dbConnection.Open();

            string query = $@"
            UPDATE Замовлення_чек SET
            [Дата] = '{Дата}',
            [Працівник_ID] = '{Працівник_ID}'
            WHERE ID = {ID}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
                dataGridViewЗаказ.Rows.Clear();
                refreshDataTableЗаказ();
            }

            dbConnection.Close();
        }
        private void buttonУдалитьЗаказ_Click(object sender, EventArgs e)
        {
            if (dataGridViewЗаказ.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗаказ.SelectedRows[0].Index;

            if (dataGridViewЗаказ.Rows[index].Cells[0].Value == null)

            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridViewЗаказ.Rows[index].Cells[0].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);
           
            dbConnection.Open();
            string query = "DELETE FROM Замовлення_чек WHERE ID = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                dataGridViewЗаказ.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }
        private void textBoxЗаказ_TextChanged(object sender, EventArgs e)
        {
            const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            dataGridViewЗаказ.Rows.Clear();
            string querry = "SELECT [ID], [Дата], [Працівник_ID]" +
            " FROM [Замовлення_чек] WHERE [Дата] LIKE '%" + textBoxЗаказ.Text + "%'";
            OleDbCommand dbCommand = new OleDbCommand(querry, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                dataGridViewЗаказ.Rows.Add(dbReader[0], dbReader[1], dbReader[2]);
            }
            while (dbReader.Read())
            {
                dataGridViewЗаказ.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4]);
            }
        }


        private void buttonДобавитьЗаказУслуг_Click(object sender, EventArgs e)
        {
            if (dataGridViewЗаказУслуг.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗаказУслуг.SelectedRows[0].Index;

            string Замовлення_ID = dataGridViewЗаказУслуг.Rows[index].Cells[1].Value.ToString();
            string Автомобіль_ID = dataGridViewЗаказУслуг.Rows[index].Cells[2].Value.ToString();
            string Послуга_ID = dataGridViewЗаказУслуг.Rows[index].Cells[3].Value.ToString();
            string Запчастина_ID = dataGridViewЗаказУслуг.Rows[index].Cells[4].Value.ToString();
            string Кількість_запчастин = dataGridViewЗаказУслуг.Rows[index].Cells[5].Value.ToString();
        
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = $@"INSERT INTO Замовлення_послуг (Замовлення_ID, Автомобіль_ID, Послуга_ID, Запчастина_ID, Кількість_запчастин)
            VALUES('{Замовлення_ID}', '{Автомобіль_ID}', '{Послуга_ID}', '{Запчастина_ID}', '{Кількість_запчастин}')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
                dataGridViewЗаказУслуг.Rows.Clear();
                refreshDataTableЗаказУслуг();
            }
            dbConnection.Close();
        }
        private void buttonОбновитьЗаказУслуг_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            if (dataGridViewЗаказУслуг.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗаказУслуг.SelectedRows[0].Index;

            int ID = Convert.ToInt32(dataGridViewЗаказУслуг.Rows[index].Cells[0].Value.ToString());
            string Замовлення_ID = dataGridViewЗаказУслуг.Rows[index].Cells[1].Value.ToString();
            string Автомобіль_ID = dataGridViewЗаказУслуг.Rows[index].Cells[2].Value.ToString();
            string Послуга_ID = dataGridViewЗаказУслуг.Rows[index].Cells[3].Value.ToString();
            string Запчастина_ID = dataGridViewЗаказУслуг.Rows[index].Cells[4].Value.ToString();
            string Кількість_запчастин = dataGridViewЗаказУслуг.Rows[index].Cells[5].Value.ToString();

            dbConnection.Open();

            string query = $@"
            UPDATE Замовлення_послуг SET
            [Замовлення_ID] = '{Замовлення_ID}',
            [Автомобіль_ID] = '{Автомобіль_ID}',
            [Послуга_ID] = '{Послуга_ID}',
            [Запчастина_ID] = '{Запчастина_ID}',
            [Кількість_запчастин] = '{Кількість_запчастин}'
            WHERE ID = {ID}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
            
            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
                dataGridViewЗаказУслуг.Rows.Clear();
                refreshDataTableЗаказУслуг();
            }
            dbConnection.Close();
        }
        private void buttonУдалитьЗаказУслуг_Click(object sender, EventArgs e)
        {
            if (dataGridViewЗаказУслуг.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗаказУслуг.SelectedRows[0].Index;

            if (dataGridViewЗаказУслуг.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridViewЗаказУслуг.Rows[index].Cells[0].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Замовлення_послуг WHERE ID = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                dataGridViewЗаказУслуг.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }
        private void textBoxЗаказУслуг_TextChanged(object sender, EventArgs e)
        {
            const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            dataGridViewЗаказУслуг.Rows.Clear();
            string querry = "SELECT [ID], [Замовлення_ID], [Автомобіль_ID], [Послуга_ID], [Запчастина_ID], [Кількість_запчастин]" +
            " FROM [Замовлення_послуг] WHERE [Кількість_запчастин] LIKE '%" + textBoxЗаказУслуг.Text + "%'";
            OleDbCommand dbCommand = new OleDbCommand(querry, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                dataGridViewЗаказУслуг.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4], dbReader[5], dbReader[6]);
            }
            while (dbReader.Read())
            {
                dataGridViewЗаказУслуг.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4]);
            }
        }


        private void buttonДобавитьУслуги_Click(object sender, EventArgs e)
        {
            if (dataGridViewУслуги.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }
       
            int index = dataGridViewУслуги.SelectedRows[0].Index;

            string Назва = dataGridViewУслуги.Rows[index].Cells[1].Value.ToString();
            string Ціна = dataGridViewУслуги.Rows[index].Cells[2].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = $@"INSERT INTO Послуги (Назва, Ціна)
            VALUES('{Назва}', '{Ціна}')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
                dataGridViewУслуги.Rows.Clear();
                refreshDataTableУслуги();
            }
            dbConnection.Close();
        }
        private void buttonОбновитьУслуги_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            if (dataGridViewУслуги.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewУслуги.SelectedRows[0].Index;

            int ID = Convert.ToInt32(dataGridViewУслуги.Rows[index].Cells[0].Value.ToString());
            string Назва = dataGridViewУслуги.Rows[index].Cells[1].Value.ToString();
            string Ціна = dataGridViewУслуги.Rows[index].Cells[2].Value.ToString();

            dbConnection.Open();

            string query = $@"
            UPDATE Послуги SET
            [Назва] = '{Назва}',
            [Ціна] = '{Ціна}'
            WHERE ID = {ID}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
                dataGridViewУслуги.Rows.Clear();
                refreshDataTableУслуги();
            }
            dbConnection.Close();
        }
        private void buttonУдалитьУслуги_Click(object sender, EventArgs e)
        {
            if (dataGridViewУслуги.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewУслуги.SelectedRows[0].Index;

            if (dataGridViewУслуги.Rows[index].Cells[0].Value == null)

            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridViewУслуги.Rows[index].Cells[0].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Послуги WHERE ID = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                dataGridViewУслуги.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }
        private void textBoxУслуги_TextChanged(object sender, EventArgs e)
        {
            const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            dataGridViewУслуги.Rows.Clear();
            string querry = "SELECT [ID], [Назва], [Ціна]" +
            " FROM [Послуги] WHERE [Назва] LIKE '%" + textBoxНазваниеУслуги.Text + "%'";
            OleDbCommand dbCommand = new OleDbCommand(querry, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                dataGridViewУслуги.Rows.Add(dbReader[0], dbReader[1], dbReader[2]);
            }
            while (dbReader.Read())
            {
                dataGridViewУслуги.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4]);
            }
        }


        private void buttonДобавитьЗапчасти_Click(object sender, EventArgs e)
        {
            if (dataGridViewЗапчасти.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗапчасти.SelectedRows[0].Index;

            string Назва = dataGridViewЗапчасти.Rows[index].Cells[1].Value.ToString();
            string Вартість = dataGridViewЗапчасти.Rows[index].Cells[2].Value.ToString();
            string Опис = dataGridViewЗапчасти.Rows[index].Cells[3].Value.ToString();


            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = $@"INSERT INTO Запчастини (Назва, Вартість, Опис)
            VALUES('{Назва}', '{Вартість}', '{Опис}')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
                dataGridViewЗапчасти.Rows.Clear();
                refreshDataTableЗапчасти();
            }

            dbConnection.Close();
        }
        private void buttonОбновитьЗапчасти_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            if (dataGridViewЗапчасти.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗапчасти.SelectedRows[0].Index;

            int ID = Convert.ToInt32(dataGridViewЗапчасти.Rows[index].Cells[0].Value.ToString());
            string Назва = dataGridViewЗапчасти.Rows[index].Cells[1].Value.ToString();
            string Вартість = dataGridViewЗапчасти.Rows[index].Cells[2].Value.ToString();
            string Опис = dataGridViewЗапчасти.Rows[index].Cells[3].Value.ToString();

            dbConnection.Open();

            string query = $@"
            UPDATE Запчастини SET
            [Назва] = '{Назва}',
            [Вартість] = '{Вартість}',
            [Опис] = '{Опис}'
            WHERE ID = {ID}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
                dataGridViewЗапчасти.Rows.Clear();
                refreshDataTableЗапчасти();
            }
            dbConnection.Close();
        }
        private void buttonУдалитьЗапчасти_Click(object sender, EventArgs e)
        {
            if (dataGridViewЗапчасти.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewЗапчасти.SelectedRows[0].Index;

            if (dataGridViewЗапчасти.Rows[index].Cells[0].Value == null)

            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridViewЗапчасти.Rows[index].Cells[0].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Запчастини WHERE ID = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                dataGridViewЗапчасти.Rows.RemoveAt(index);
            }
            dbConnection.Close();
        }
        private void textBoxЗапчасти_TextChanged(object sender, EventArgs e)
        {
            const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            dataGridViewЗапчасти.Rows.Clear();
            string querry = "SELECT [ID], [Назва], [Вартість], [Опис]" +
            " FROM [Запчастини] WHERE [Назва] LIKE '%" + textBoxНазваниеЗапчасти.Text + "%'";
            OleDbCommand dbCommand = new OleDbCommand(querry, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                dataGridViewЗапчасти.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3]);
            }
            while (dbReader.Read())
            {
                dataGridViewЗапчасти.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4]);
            }
        }


        private void buttonДобавитьРаботник_Click(object sender, EventArgs e)
        {
            if (dataGridViewРаботник.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewРаботник.SelectedRows[0].Index;

            string Прізвище = dataGridViewРаботник.Rows[index].Cells[1].Value.ToString();
            string Імя = dataGridViewРаботник.Rows[index].Cells[2].Value.ToString();
            string По_батькові = dataGridViewРаботник.Rows[index].Cells[3].Value.ToString();
            string Посада = dataGridViewРаботник.Rows[index].Cells[4].Value.ToString();
            string Номер_телефону = dataGridViewРаботник.Rows[index].Cells[5].Value.ToString();
            string Заробітна_плата = dataGridViewРаботник.Rows[index].Cells[6].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = $@"INSERT INTO Працівник (Прізвище, Імя, По_батькові, Посада, Номер_телефону, Заробітна_плата)
            VALUES('{Прізвище}', '{Імя}', '{По_батькові}', '{Посада}', '{Номер_телефону}', '{Заробітна_плата}')";
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные добавлены!", "Внимание!");
                dataGridViewРаботник.Rows.Clear();
                refreshDataTableРаботник();
            }

            dbConnection.Close();
        }
        private void buttonОбновитьРаботник_Click(object sender, EventArgs e)
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            if (dataGridViewРаботник.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewРаботник.SelectedRows[0].Index;

            int ID = Convert.ToInt32(dataGridViewРаботник.Rows[index].Cells[0].Value.ToString());
            string Прізвище = dataGridViewРаботник.Rows[index].Cells[1].Value.ToString();
            string Імя = dataGridViewРаботник.Rows[index].Cells[2].Value.ToString();
            string По_батькові = dataGridViewРаботник.Rows[index].Cells[3].Value.ToString();
            string Посада = dataGridViewРаботник.Rows[index].Cells[4].Value.ToString();
            string Номер_телефону = dataGridViewРаботник.Rows[index].Cells[5].Value.ToString();
            string Заробітна_плата = dataGridViewРаботник.Rows[index].Cells[6].Value.ToString();

            dbConnection.Open();

            string query = $@"
            UPDATE Працівник SET
            [Прізвище] = '{Прізвище}',
            [Імя] = '{Імя}',
            [По_батькові] = '{По_батькові}',
            [Посада] = '{Посада}',
            [Номер_телефону] = '{Номер_телефону}',
            [Заробітна_плата] = '{Заробітна_плата}'
            WHERE ID = {ID}";

            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                MessageBox.Show("Данные изменены!", "Внимание!");
                dataGridViewРаботник.Rows.Clear();
                refreshDataTableРаботник();
            }
            dbConnection.Close();
        }
        private void buttonУдалитьРаботник_Click(object sender, EventArgs e)
        {
            if (dataGridViewРаботник.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            int index = dataGridViewРаботник.SelectedRows[0].Index;

            if (dataGridViewРаботник.Rows[index].Cells[0].Value == null)
            {
                MessageBox.Show("Не все данные введены!", "Внимание!");
                return;
            }

            string id = dataGridViewРаботник.Rows[index].Cells[0].Value.ToString();

            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection dbConnection = new OleDbConnection(connectionString);

            dbConnection.Open();
            string query = "DELETE FROM Працівник WHERE ID = " + id;
            OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);

            if (dbCommand.ExecuteNonQuery() != 1)
                MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
            else
            {
                dataGridViewРаботник.Rows.RemoveAt(index);
            }

            dbConnection.Close();
        }
        private void textBoxФамилияРаботник_TextChanged(object sender, EventArgs e)
        {
            const string connectionString = "provider=microsoft.jet.oledb.4.0;data source=Database1.mdb";

            OleDbConnection dbConnection = new OleDbConnection(connectionString);
            dbConnection.Open();

            dataGridViewРаботник.Rows.Clear();
            string querry = "SELECT [ID], [Прізвище], [Імя], [По_батькові], [Посада], [Номер_телефону], [Заробітна_плата]" +
            " FROM [Працівник] WHERE [Прізвище] LIKE '%" + textBoxФамилияРаботник.Text + "%'";
            OleDbCommand dbCommand = new OleDbCommand(querry, dbConnection);

            OleDbDataReader dbReader = dbCommand.ExecuteReader();
            while (dbReader.Read())
            {
                dataGridViewРаботник.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4], dbReader[5], dbReader[6]);
            }
            while (dbReader.Read())
            {
                dataGridViewРаботник.Rows.Add(dbReader[0], dbReader[1], dbReader[2], dbReader[3], dbReader[4]);
            }
        }

        private void buttonПереходЧек_Click(object sender, EventArgs e)
        {
            Чек чек = new Чек();
            чек.ShowDialog();
        }
    }
}