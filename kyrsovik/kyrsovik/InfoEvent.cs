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
    public partial class InfoEvent : Form
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public static string connection = $"Data Source=Vladimir-pc;Initial Catalog=KyrsProject;Integrated Security=True";
        private string typeEvent = string.Empty;       // тип ивента
        private decimal avgRateEvent;   // ср значение
        private int countFeedBack = 0;        // количество отзывов
        public string id = string.Empty; // id мероприятия

        public InfoEvent()
        {
            InitializeComponent();
        }
        private void InfoEvent_Load(object sender, EventArgs e)
        {
            Main m = this.Owner as Main;
            id = m.listView_event.FocusedItem.SubItems[0].Text;
            log.Info("************************************************************ Info Event Start *************************************************************");
            /*-------------------------------*/

            getTypeEvent();
            getAVGRateEvent();
            getInfoEvent();

        }
        public void getInfoEvent()
        {
            Main m = this.Owner as Main;

            if (m != null)
            {
                label_id_event.Text = $"ID мероприятия: {id}";
                label_name_event.Text = $"Название мероприятия:   {m.listView_event.FocusedItem.SubItems[2].Text}";
                label_all_event_count.Text = $"Число мероприятий в базе данных: {m.countEvent.ToString()}";
                label_date_event.Text = $"Дата проведения: {m.listView_event.FocusedItem.SubItems[4].Text}";
                label_type_event.Text = $"Тип мероприятия: {typeEvent}";
                label_age.Text = $"Возрастное ограничение: {m.listView_event.FocusedItem.SubItems[5].Text}";

                label_rate_event.Text = $"Средний рейтинг мероприятия: {avgRateEvent}";
                label_feedback_count.Text = $"Число отзывов: {countFeedBack}";
                log.Info($"Загрузка информации прошла успешно. id {id}");
            }
            else
            {
                log.Info("ERROR!\t Ошибка загрузки информации о мероприятии!");
                MessageBox.Show("Неизвестная ошибка #1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       // информация об ивенте
        private void getTypeEvent()
        {
            Main m = this.Owner as Main;
            SqlConnection connect = new SqlConnection(connection);
            string sql_type_event = $"select name_type from type_event where id = {m.listView_event.FocusedItem.SubItems[3].Text.ToString()}";
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_type_event, connect);
                typeEvent = (string)cmd.ExecuteScalar();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }           // получаем тип ивента
        private void getAVGRateEvent()
        {
            SqlConnection connect = new SqlConnection(connection);

            string sql_avg_event = $"select CAST(AVG(rating_event*1.0) AS NUMERIC(4,1)) from feedback_event where id_event = {id}";
            string sql_count_feedback = $"select count(*) from feedback_event where id_event = {id}";

            try
            {
                connect.Open();
                SqlCommand cmd_count = new SqlCommand(sql_count_feedback, connect);
                if ((int)cmd_count.ExecuteScalar() != 0)
                {
                    countFeedBack = (int)cmd_count.ExecuteScalar();
                }
                else
                {
                    countFeedBack = 0;
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }

            if (countFeedBack != 0)
            {
                try
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(sql_avg_event, connect);
                    avgRateEvent = (decimal)cmd.ExecuteScalar();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                finally { connect.Close(); }
            }
            else { avgRateEvent = 0; }
        }       // Средний рейтинг ивента и количество отзывов
        private void InfoEvent_FormClosed(object sender, FormClosedEventArgs e)     // обновляем данные при закрытии формы
        {
            log.Info("************************************************************ Info Event Close *************************************************************");
            Main m = this.Owner as Main;
            m.refreshAllData();
        }
        private void pictureBox_feedback_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "FeedBackEvent")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            FeedBackEvent fb = new FeedBackEvent();
            fb.Owner = this;
            fb.Show();
        }       // кнопка отзыва
        private void pictureBox_editEvent_Click(object sender, EventArgs e)         // кнопка редактирования мероприятия
        {
            foreach (Form f in Application.OpenForms)            // не разрешаем открыть еще одну форму
            {
                if (f.Name == "EditEvent")
                {
                    MessageBox.Show("Форма уже открыта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            EditEvent ee = new EditEvent();
            ee.Owner = this;
            ee.Show();
        }
    }
}