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
        private int id;
        public InfoPlace()
        {
            InitializeComponent();
        }

        private void InfoPlace_Load(object sender, EventArgs e)
        {
            getInfo();
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

                if (m.listView_place.FocusedItem.SubItems[4].Text == "true") { label_pay_card.Text = $"Оплата картой: Есть"; }
                if (m.listView_place.FocusedItem.SubItems[4].Text == "false") { label_pay_card.Text = $"Оплата картой: Нет"; }

                label_parking.Text = $"Парковка: {m.listView_place.FocusedItem.SubItems[5].Text}";
                label_working_time.Text = $"Время работы: {m.listView_place.FocusedItem.SubItems[6].Text}";
                selectAddress();
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка #1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
        }
    }
}
