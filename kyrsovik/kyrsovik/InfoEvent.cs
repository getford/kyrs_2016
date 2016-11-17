﻿using System;
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
        public static string connection = $"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True";
        private string typeEvent;       // тип ивента
        private decimal avgRateEvent;   // ср значение

        public InfoEvent()
        {
            InitializeComponent();
        }

        private void InfoEvent_Load(object sender, EventArgs e)
        {
            getTypeEvent();
            getAVGRateEvent();
            getInfoEvent();
        }

        private void getInfoEvent()
        {
            Main m = this.Owner as Main;
            if (m != null)
            {
                label_id_event.Text = $"ID мероприятия: {m.listView_event.FocusedItem.SubItems[0].Text}";
                label_name_event.Text = $"Название мероприятия:   {m.listView_event.FocusedItem.SubItems[2].Text}";
                label_all_event_count.Text = $"Число мероприятий в базе данных: {m.countEvent.ToString()}";
                label_date_event.Text = $"Дата проведения: {m.listView_event.FocusedItem.SubItems[4].Text}";
                label_type_event.Text = $"Тип мероприятия: {typeEvent}";
                label_age.Text = $"Возрастное ограничение: {m.listView_event.FocusedItem.SubItems[5].Text}";

                label_rate_event.Text = $"Средний рейтинг мероприятия: {avgRateEvent}";
                label_feedback_count.Text = $"";
            }
            else { MessageBox.Show("Неизвестная ошибка #1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            Main m = this.Owner as Main;
            SqlConnection connect = new SqlConnection(connection);

            string sql_avg_event = $"select CAST(AVG(rating_event*1.0) AS NUMERIC(4,1)) from feedback_event where id_event = '{m.listView_event.FocusedItem.SubItems[0].Text}'";
            string sql_count_feedback = $"select count(rating_event) from feedback_event where id_event = '{m.listView_event.FocusedItem.SubItems[0].Text}'";

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
                    SqlCommand cmd = new SqlCommand(sql_avg_event, connect);
                    avgRateEvent = (decimal)cmd.ExecuteScalar();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                finally { connect.Close(); }
            }
            else { avgRateEvent = 0; }
        }       // Средний рейтинг ивента

        private void InfoEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = this.Owner as Main;
            m.refreshAllData();
        }
    }
}