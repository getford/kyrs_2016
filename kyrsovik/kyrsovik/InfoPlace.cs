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
        public static string connection = $"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True";
        public int id;
        private string typePlace;

        public InfoPlace()
        {
            InitializeComponent();
        }

        private void InfoPlace_Load(object sender, EventArgs e)
        {
            getTypePlace();
            getInfo();
            getCountFeedBack();
        }

        private void getInfo()
        {
            Main m = this.Owner as Main;
            id = Convert.ToInt16(m.listView_place.FocusedItem.SubItems[0].Text);

            if (m != null)
            {
                label_count.Text = $"Количество мест проведения в базе: {m.countPlace.ToString()}";
                label_id.Text = $"ID места: {m.listView_place.FocusedItem.SubItems[0].Text}";
                label_name_place.Text = $"Название места проведения:\n{m.listView_place.FocusedItem.SubItems[2].Text}";

                //if (m.listView_place.FocusedItem.SubItems[4].Text == "true") { label_pay_card.Text = $"Оплата картой: Есть"; }
                //if (m.listView_place.FocusedItem.SubItems[4].Text == "false") { label_pay_card.Text = $"Оплата картой: Нет"; }

                label_type_place.Text = $"Тип места: {typePlace}";
                label_pay_card.Text = $"Оплата картой: {m.listView_place.FocusedItem.SubItems[4].Text}";
                label_parking.Text = $"Парковка: {m.listView_place.FocusedItem.SubItems[5].Text}";
                label_working_time.Text = $"Время работы: {m.listView_place.FocusedItem.SubItems[6].Text}";
                selectAddress();
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка #1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }               // информация о заведении

        private void selectAddress()
        {
            SqlConnection connect = new SqlConnection(connection);

            string sql_select = $"select country, city, street, house, tel from address where id = '{id}'";

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

        private void linkLabel_feedback_place_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void getCountFeedBack()
        {
            SqlConnection connect = new SqlConnection(connection);

            string sql_max_id = $"select count(*) from feedback_place where id_place = '{id.ToString()}'";

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
        }

    }
}
