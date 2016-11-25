using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovik
{
    public partial class InfoPlace : Form
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public static string connection = $"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True";
        private string typePlace;       // тип места
        private decimal avgRatePlace;   //ср значение рейтинга
        public string id;           // id места

        public InfoPlace()
        {
            InitializeComponent();
        }
        private void InfoPlace_Load(object sender, EventArgs e)
        {
            log.Info("************************************************************ Info Place Start *************************************************************");
            getTypePlace();
            getAVGRatePlace();
            getInfo();
            getCountFeedBack();
        }
        private void getInfo()
        {
            Main m = this.Owner as Main;

            if (m != null)
            {
                id = m.listView_place.FocusedItem.SubItems[0].Text;
                label_count.Text = $"Число мест проведения в базе данных: {m.countPlace.ToString()}";
                label_id.Text = $"ID места: {m.listView_place.FocusedItem.SubItems[0].Text}";
                label_name_place.Text = $"Название места проведения:\n{m.listView_place.FocusedItem.SubItems[2].Text}";

                if (m.listView_place.FocusedItem.SubItems[4].Text == "True") { label_pay_card.Text = $"Оплата картой: Есть"; }
                if (m.listView_place.FocusedItem.SubItems[4].Text == "False") { label_pay_card.Text = $"Оплата картой: Нет"; }

                if (m.listView_place.FocusedItem.SubItems[5].Text == "True") { label_parking.Text = $"Парковка: Есть"; }
                if (m.listView_place.FocusedItem.SubItems[5].Text == "False") { label_parking.Text = $"Парковка: Нет"; }

                label_type_place.Text = $"Тип места: {typePlace}";
                label_working_time.Text = $"Время работы: {m.listView_place.FocusedItem.SubItems[6].Text}";
                label_avg_rate.Text = $"Рейтинг: {avgRatePlace.ToString()}";
                selectAddress();
                log.Info($"Загрузка информации прошла успешно. id {id}");
            }
            else
            {
                log.Info("ERROR!\t Ошибка загрузки информации о месте проведения!");
                MessageBox.Show("Неизвестная ошибка #1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }               // информация о заведении
        private void selectAddress()
        {
            Main m = this.Owner as Main;
            SqlConnection connect = new SqlConnection(connection);

            string sql_select = $"select country, city, street, house, tel from address where id = '{m.listView_place.FocusedItem.SubItems[0].Text}'";

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_select, connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label_country.Text = $"Страна: {dr.GetString(0)}";
                    label_city.Text = $"Город: {dr.GetString(1)}";
                    label_street.Text = $"Улица: {dr.GetString(2)}";
                    label_house.Text = $"Дом: {dr.GetString(3)}";
                    label_tel.Text = $"Телефон: {dr.GetString(4)}";
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connect.Close(); }
        }       // адрес заведения
        private void getCountFeedBack()
        {
            Main m = this.Owner as Main;
            SqlConnection connect = new SqlConnection(connection);

            string sql_max_id = $"select count(*) from feedback_place where id_place = '{m.listView_place.FocusedItem.SubItems[0].Text}'";

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_max_id, connect);
                label_count_feedback.Text = $"Количество отзывов: {cmd.ExecuteScalar().ToString()}";
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally
            {
                connect.Close();
            }
        }       // число отзывов
        private void getTypePlace()
        {
            Main m = this.Owner as Main;

            SqlConnection connect = new SqlConnection(connection);

            string sql_type_place = $"select name_type from type_place where id = '{m.listView_place.FocusedItem.SubItems[3].Text.ToString()}'";

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_type_place, connect);
                typePlace = (string)cmd.ExecuteScalar();
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally
            {
                connect.Close();
            }
        }           // тип места
        private void getAVGRatePlace()
        {
            Main m = this.Owner as Main;
            SqlConnection connect = new SqlConnection(connection);
            string sql_avg_place = $"select CAST(AVG(rating_place*1.0) AS NUMERIC(4,1)) from feedback_place where id_place = '{m.listView_place.FocusedItem.SubItems[0].Text}'";
            string sql_count_feedback = $"select count(*) from feedback_place where id_place = '{m.listView_place.FocusedItem.SubItems[0].Text}'";

            int tmp = 0;
            try
            {
                connect.Open();
                SqlCommand cmd_count = new SqlCommand(sql_count_feedback, connect);
                tmp = (int)cmd_count.ExecuteScalar();
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }

            if (tmp != 0)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(sql_avg_place, connect);
                    avgRatePlace = (decimal)cmd.ExecuteScalar();

                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                finally { connect.Close(); }
            }
            else
            {
                avgRatePlace = 0;
            }       // средний рейтинг места
        }       // средний рейтинг места
        private void linkLabel_events_here_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "EventInPlace")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            EventInPlace ip = new EventInPlace();
            ip.Owner = this;
            ip.Show();
        }       // мероприятия в выбранном месте
        private void InfoPlace_FormClosed(object sender, FormClosedEventArgs e)         // перезагружает всю инфу после закрытия формы
        {
            log.Info("************************************************************ Info Place Close *************************************************************");

            Main m = this.Owner as Main;
            m.refreshAllData();
        }
        private void pictureBox_deletePlace_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connection);

            try
            {
                connect.Open();
                string sql_delete_event = $"delete from event where id_place = {id}";
                string sql_delete_place = $"delete from place where id = {id}";
                string sql_delete_address = $"delete from address where id = {id}";

                SqlCommand cmd_e = new SqlCommand(sql_delete_event, connect);
                SqlCommand cmd_p = new SqlCommand(sql_delete_place, connect);
                SqlCommand cmd_a = new SqlCommand(sql_delete_address, connect);

                cmd_e.ExecuteNonQuery();
                cmd_p.ExecuteNonQuery();
                cmd_a.ExecuteNonQuery();

                MessageBox.Show("Место проведения успешно удалено!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }       // кнопка удаления
        private void pictureBox_feedBack_place_Click(object sender, EventArgs e)        // кнопка отзыва
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "FeedBack")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            FeedBackPlace fb = new FeedBackPlace();
            fb.Owner = this;
            fb.Show();
        }
    }
}