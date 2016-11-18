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
        public static string connection = $"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True";

        private int maxIdPlaceAddress = 0;         // Максимальный id place == id addres
        private int maxIdEvent = 0;

        public int countPlace;
        public int countEvent;

        public Main()
        {
            InitializeComponent();

            comboBox_parking.Items.Add("true");
            comboBox_parking.Items.Add("false");
            /*-----------------------------------------------*/
            comboBox_pay_card.Items.Add("true");
            comboBox_pay_card.Items.Add("false");
            /*-----------------------------------------------*/
            comboBox_type_place.Items.Add("Кинотеатр");
            comboBox_type_place.Items.Add("Ночной клуб");
            comboBox_type_place.Items.Add("Концертная площадка");
            comboBox_type_place.Items.Add("Театр");
            comboBox_type_place.Items.Add("Выставки");
            comboBox_type_place.Items.Add("Боулинг");
            /*-----------------------------------------------*/
            comboBox_age.Items.Add("0");
            comboBox_age.Items.Add("3");
            comboBox_age.Items.Add("12");
            comboBox_age.Items.Add("16");
            comboBox_age.Items.Add("18");
            /*-----------------------------------------------*/

        }
        private void Main_Load(object sender, EventArgs e)
        {
            refreshAllData();
        }
        private void Initialize_List_place()
        {
            listView_place.GridLines = true;
            listView_place.AllowColumnReorder = true;
            listView_place.LabelEdit = false;
            listView_place.FullRowSelect = true;
            listView_place.View = View.Details;// стиль вывода в таблицу
        }// инициализация listview
        private void Initialize_List_event()
        {
            listView_event.GridLines = true;
            listView_event.AllowColumnReorder = true;
            listView_event.LabelEdit = true;
            listView_event.FullRowSelect = true;
            listView_event.View = View.Details; // стиль вывода в таблицу
        }       // инициализация listview
        private void fill_ListView_event()
        {
            Initialize_List_event();
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
            Initialize_List_place();
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
            SqlConnection connect = new SqlConnection(connection);
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
        }               // выборка из Place

        private void getDataEvent()
        {
            SqlConnection connect = new SqlConnection(connection);
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
        }               // выборка из Event

        private void button_add_place_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();

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

                switch (comboBox_type_place.SelectedItem.ToString())
                {
                    case "Кинотеатр": id_type = 0; break;
                    case "Ночной клуб": id_type = 1; break;
                    case "Концертная площадка": id_type = 2; break;
                    case "Театр": id_type = 3; break;
                    case "Выставки": id_type = 4; break;
                    case "Боулинг": id_type = 5; break;
                }

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

                string output = $"Запись успешно добавлена. id: {maxIdPlaceAddress + 1}";

                refreshAllData();

                MessageBox.Show(output, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }           // добавление места

        private void button_add_event_Click(object sender, EventArgs e)             // добавление ивента
        {
            SqlConnection connect = new SqlConnection(connection);

            try
            {
                connect.Open();

                string sql_insert_event = string.Format($"insert into event ([id], [id_place], [name_event], [id_type], [date_event], [age_control]) values (@id, @id_place, @name_event, @id_type, @date_event, @age_control)");

                SqlCommand cmd_insert_event = new SqlCommand(sql_insert_event, connect);

                string select_cb_id_place = comboBox_event_place.SelectedItem.ToString();
                string select_cb_age = comboBox_age.SelectedItem.ToString();
                int id_type_event = 0;


                switch (comboBox_type_event.SelectedItem.ToString())
                {
                    case "Вечеринка": id_type_event = 0; break;
                    case "Концерт": id_type_event = 1; break;
                    case "Спектакль": id_type_event = 2; break;
                    case "Представление": id_type_event = 3; break;
                    case "Кино": id_type_event = 4; break;
                }

                cmd_insert_event.Parameters.AddWithValue("@id", maxIdEvent + 1);
                cmd_insert_event.Parameters.AddWithValue("@id_place", select_cb_id_place);
                cmd_insert_event.Parameters.AddWithValue("@name_event", textBox_name_event.Text);
                cmd_insert_event.Parameters.AddWithValue("@id_type", id_type_event);
                cmd_insert_event.Parameters.AddWithValue("@date_event", dateTimePicker_event.Value);
                cmd_insert_event.Parameters.AddWithValue("@age_control", select_cb_age.ToString());
                cmd_insert_event.ExecuteNonQuery();

                string output = $"Запись успешно добавлена. id: {maxIdEvent + 1}";

                MessageBox.Show(output, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshAllData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }

        public void clearInput()
        {
            textBox_house.Clear();
            textBox_name_event.Clear();
            textBox_name_palce.Clear();
            textBox_street.Clear();
            textBox_tel.Clear();
            textBox_time_work.Clear();
            dateTimePicker_event.Value = DateTime.Now;

            comboBox_age.ResetText();
            comboBox_event_place.ResetText();
            comboBox_parking.ResetText();
            comboBox_pay_card.ResetText();
            comboBox_type_event.ResetText();
            comboBox_type_place.ResetText();
            comboBox_type_event.ResetText();

        }       // очистка полей ввода

        private void getCount()
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_count_place = $"select count(*) from place";
                string sql_count_event = $"select count(*) from event";

                string sql_max_id_place = $"select MAX(id) from place";
                string sql_max_id_event = $"select MAX(id) from event";

                SqlCommand cmd_place = new SqlCommand(sql_count_place, connect);
                SqlCommand cmd_event = new SqlCommand(sql_count_event, connect);

                SqlCommand cmd_id_place = new SqlCommand(sql_max_id_place, connect);
                SqlCommand cmd_id_event = new SqlCommand(sql_max_id_event, connect);

                countPlace = (int)cmd_place.ExecuteScalar();
                countEvent = (int)cmd_event.ExecuteScalar();

                maxIdPlaceAddress = (int)cmd_id_place.ExecuteScalar();
                maxIdEvent = (int)cmd_id_event.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }       // count из таблиц

        private void listView_place_MouseClick(object sender, MouseEventArgs e)         // просмотр инфы о месте
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "InfoPlace")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            InfoPlace ip = new InfoPlace();
            ip.Owner = this;
            ip.Show();

        }

        private void listView_event_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "InfoEvent")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            InfoEvent ie = new InfoEvent();
            ie.Owner = this;
            ie.Show();

        }       // просмотр инфы о мероприятии

        public void refreshAllData()        // загрузка всей инфы (перезагрузка всеё инфы)
        {
            comboBox_event_place.Items.Clear();
            comboBox_type_event.Items.Clear();
            comboBox_type_for_select.Items.Clear();

            clearInput();

            getCount();
            getDataEvent();
            getDataPlace();
            getTypeEvent();

            for (int i = 0; i < countPlace; i++) { comboBox_event_place.Items.Add(i); }
        }

        private void getTypeEvent()     // заполняем список тип мероприятия
        {
            SqlConnection connect = new SqlConnection(connection);
            string sql = $"select name_type from type_event";
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBox_type_for_select.Items.Add(dr.GetString(0));
                    comboBox_type_event.Items.Add(dr.GetString(0));
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }

        private void getEventForType()      // отбор мероприятий по типу
        {
            string type = comboBox_type_for_select.SelectedItem.ToString();
            int id_type_event = 0;
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_select_type = $"select id from type_event where name_type = '{type}'";
                SqlCommand cmd_select_type = new SqlCommand(sql_select_type, connect);
                id_type_event = (int)cmd_select_type.ExecuteScalar();

                string sql_query = $"select * from event where id_type = {id_type_event}";
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
                        if (j == 3)
                        {
                            lvi.SubItems.Add(type);
                        }
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

        private void getEventForRate()          // отбор лучших мероприятий (где оценка > 3)
        {
            if (radioButton_bestEvent.Checked == true)
            {
                SqlConnection connect = new SqlConnection(connection);
                try
                {
                    connect.Open();

                    string sql_query = $"select event.id, id_place, name_event, id_type, date_event, age_control from event inner join feedback_event on event.id = feedback_event.id_event where rating_event > 3";
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
            if(radioButton_for_date.Checked == true)            /// дописать выборку промежутка даты
            {
                SqlConnection connect = new SqlConnection(connection);
                try
                {
                    connect.Open();

                    string sql_query = $"select event.id, id_place, name_event, id_type, date_event, age_control from event inner join feedback_event on event.id = feedback_event.id_event where rating_event > 3";
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
        }

        private void button_select_Click(object sender, EventArgs e)        // кнопка показа мероприятий по запросу
        {
            getEventForType();
        }

        private void button_refresh_Click(object sender, EventArgs e)       // обновление данных
        {
            refreshAllData();
        }

        private void button_selectBestEvent_Click(object sender, EventArgs e)       // кнопка показа лучших мероприятий
        {
            string output = $"Выберите праметр '{radioButton_bestEvent.Text.ToString()}'{Environment.NewLine} или '{radioButton_for_date.Text.ToString()}'";

            if (radioButton_bestEvent.Checked == true || radioButton_for_date.Checked == true)
                getEventForRate();
            else
                MessageBox.Show(output, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
