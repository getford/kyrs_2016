using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kyrsovik
{
    public partial class Main : Form
    {

        private int maxIdPlaceAddress = 0;         // Максимальный id place == id addres

        public Main()
        {
            InitializeComponent();

            comboBox_parking.Items.Add("true");
            comboBox_parking.Items.Add("false");

            comboBox_pay_card.Items.Add("true");
            comboBox_pay_card.Items.Add("false");

            comboBox_type_place.Items.Add("Кинотеатр");
            comboBox_type_place.Items.Add("Ночной клуб");
            comboBox_type_place.Items.Add("Концертная площадка");
            comboBox_type_place.Items.Add("Театр");
            comboBox_type_place.Items.Add("Выставки");
            comboBox_type_place.Items.Add("Боулинг");

        }

        private void Main_Load(object sender, EventArgs e)
        {
            getDataEvent();
            getDataPlace();
        }
        private void Initialize_List_place()
        {
            listView_place.GridLines = true;
            listView_place.AllowColumnReorder = true;
            listView_place.LabelEdit = true;
            listView_place.FullRowSelect = true;
            listView_place.View = View.Details;// стиль вывода в таблицу
        }// инициализация listview
        private void Initialize_List()
        {
            listView_event.GridLines = true;
            listView_event.AllowColumnReorder = true;
            listView_event.LabelEdit = true;
            listView_event.FullRowSelect = true;
            listView_event.View = View.Details; // стиль вывода в таблицу
        }       // инициализация listview
        private void fill_ListView_event()
        {
            Initialize_List();
            try
            {
                listView_event.Columns.Add("id", listView_event.Width / 6);
                listView_event.Columns.Add("Место", listView_event.Width / 6);
                listView_event.Columns.Add("Название", listView_event.Width / 6);
                listView_event.Columns.Add("Тип", listView_event.Width / 6);
                listView_event.Columns.Add("Дата", listView_event.Width / 6);
                listView_event.Columns.Add("Возраст", listView_event.Width / 6);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }           // инициализация listview (колонки)

        private void fill_ListView_place()
        {
            Initialize_List();
            try
            {
                listView_place.Columns.Add("id", listView_place.Width / 7);
                listView_place.Columns.Add("Адрес", listView_place.Width / 7);
                listView_place.Columns.Add("Название", listView_place.Width / 7);
                listView_place.Columns.Add("Тип", listView_place.Width / 7);
                listView_place.Columns.Add("Оплата картой", listView_place.Width / 7);
                listView_place.Columns.Add("Парковка", listView_place.Width / 7);
                listView_place.Columns.Add("Время работы", listView_place.Width / 7);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }              // инициализация listview (колонки)

        private void getDataPlace()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True");
            try
            {
                connect.Open();
                string sql_query = $"select * from place";
                SqlCommand cmd = new SqlCommand(sql_query, connect);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                listView_place.Clear();
                fill_ListView_place();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                    listView_place.Items.Add(lvi);
                }
                da.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }

        private void getDataEvent()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True");
            try
            {
                connect.Open();
                string sql_query = $"select * from event";
                SqlCommand cmd = new SqlCommand(sql_query, connect);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                listView_event.Clear();
                fill_ListView_event();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                    listView_event.Items.Add(lvi);
                }
                da.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }

        private void button_add_place_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True");
            try
            {
                connect.Open();
                string sql_max_id = $"select MAX(id) from place";
                SqlCommand cmd_id = new SqlCommand(sql_max_id, connect);
                maxIdPlaceAddress = (int)cmd_id.ExecuteScalar();

                string sql_insert_address = string.Format($"insert into address ([id], [country], [city], [street], [house], [tel]) values (@id, @country, @city, @street, @house, @tel)");
                string sql_insert = string.Format($"insert into place ([id], [id_address], [name_place], [id_type], [pay_card], [parking], [time_work]) values (@id, @id_address, @name_place, @id_type, @pay_card, @parking, @time_work)");

                SqlCommand cmd_insert = new SqlCommand(sql_insert, connect);
                SqlCommand cmd_insert_address = new SqlCommand(sql_insert_address, connect);

                string select_cb_parking = comboBox_parking.SelectedItem.ToString();
                string select_cb_type = comboBox_type_place.SelectedItem.ToString();
                string select_cb_card = comboBox_pay_card.SelectedItem.ToString();

                int id_parking = 0;
                int id_card = 0;
                int id_type = 0;

                if (select_cb_parking.ToString() == "true") { id_parking = 1; }
                if (select_cb_parking.ToString() == "false") { id_parking = 0; }

                if (select_cb_card.ToString() == "true") { id_card = 1; }
                if (select_cb_card.ToString() == "false") { id_card = 0; }

                if (select_cb_type.ToString() == "Кинотеатр") { id_type = 0; }
                if (select_cb_type.ToString() == "Ночной клуб") { id_type = 1; }
                if (select_cb_type.ToString() == "Концертная площадка") { id_type = 2; }
                if (select_cb_type.ToString() == "Театр") { id_type = 3; }
                if (select_cb_type.ToString() == "Выставки") { id_type = 4; }
                if (select_cb_type.ToString() == "Боулинг") { id_type = 5; }

                cmd_insert_address.Parameters.AddWithValue("@id", maxIdPlaceAddress + 1);
                cmd_insert_address.Parameters.AddWithValue("@country", "BLR");
                cmd_insert_address.Parameters.AddWithValue("@city", "Minsk");
                cmd_insert_address.Parameters.AddWithValue("@street", textBox_street.Text.ToString());
                cmd_insert_address.Parameters.AddWithValue("@house", textBox_house.Text.ToString());
                cmd_insert_address.Parameters.AddWithValue("@tel", textBox_tel.Text.ToString());
                cmd_insert_address.ExecuteNonQuery();

                cmd_insert.Parameters.AddWithValue("@id", (maxIdPlaceAddress + 1).ToString());
                cmd_insert.Parameters.AddWithValue("@id_address", (maxIdPlaceAddress + 1).ToString());
                cmd_insert.Parameters.AddWithValue("@name_place", textBox_name_palce.Text.ToString());
                cmd_insert.Parameters.AddWithValue("@id_type", id_type.ToString());
                cmd_insert.Parameters.AddWithValue("@pay_card", id_card.ToString());
                cmd_insert.Parameters.AddWithValue("@parking", id_parking.ToString());
                cmd_insert.Parameters.AddWithValue("@time_work", textBox_time_work.Text.ToString());
                cmd_insert.ExecuteNonQuery();
                getDataPlace();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }
    }
}