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
    public partial class FeedBackPlace : Form
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public static string connection = $"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True";
        private int idAuthor;
        private int maxIdFeedBack;
        public FeedBackPlace()
        {
            InitializeComponent();

            comboBox_rate.Items.Add(1);
            comboBox_rate.Items.Add(2);
            comboBox_rate.Items.Add(3);
            comboBox_rate.Items.Add(4);
            comboBox_rate.Items.Add(5);
        }
        private void FeedBack_Load(object sender, EventArgs e)
        {
            log.Info("********************************************************** Feedback Place Start ***********************************************************");
            InfoPlace ip = this.Owner as InfoPlace;
            label_name_place.Text = ip.label_name_place.Text.ToString();
            getAuthors();
        }
        private void addFeedBack()
        {
            string sql_insert_feedback = string.Format($"insert into feedback_place ([id], [id_place], [topic], [text_feedback], [id_authors], [rating_place], [date_feedback]) values (@id, @id_place, @topic, @text_feedback, @id_authors, @rating_place, @date_feedback)");

            InfoPlace ip = this.Owner as InfoPlace;
            SqlConnection connect = new SqlConnection(connection);

            try
            {
                connect.Open();
                SqlCommand cmd_insert = new SqlCommand(sql_insert_feedback, connect);

                getAuthorsId();
                getMaxIdFeedBack();

                cmd_insert.Parameters.AddWithValue("@id", (maxIdFeedBack = maxIdFeedBack + 1).ToString());
                cmd_insert.Parameters.AddWithValue("@id_place", ip.id.ToString());
                cmd_insert.Parameters.AddWithValue("@topic", textBox_topic.Text.ToString());
                cmd_insert.Parameters.AddWithValue("@text_feedback", richTextBox_text_feedback.Text.ToString());
                cmd_insert.Parameters.AddWithValue("@id_authors", idAuthor.ToString());
                cmd_insert.Parameters.AddWithValue("@rating_place", comboBox_rate.Text.ToString());
                cmd_insert.Parameters.AddWithValue("@date_feedback", System.DateTime.Now.ToString());
                cmd_insert.ExecuteNonQuery();

                log.Info($"Отзыв успешно добавлен! id места: {ip.id.ToString()}, id автора: {idAuthor.ToString()}.");
                MessageBox.Show("Запись успешно добавлена", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally
            {
                connect.Close();
            }
        }       // добавить отзыв
        private void getAuthors()
        {
            SqlConnection connect = new SqlConnection(connection);
            string sql_select_authors = $"select surname_author from authors";
            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_select_authors, connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { comboBox_author.Items.Add(dr.GetString(0)); }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }       // список авторов
        private void getAuthorsId()
        {
            SqlConnection connect = new SqlConnection(connection);

            string sql_select_authors_id = $"select id from authors where surname_author = '{comboBox_author.Text.ToString()}'";

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_select_authors_id, connect);
                idAuthor = (int)cmd.ExecuteScalar();
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally
            {
                connect.Close();
            }
        }       // id автора 
        private void getMaxIdFeedBack()
        {
            SqlConnection connect = new SqlConnection(connection);

            string sql_max_id = $"select MAX(id) from feedback_place";

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql_max_id, connect);
                maxIdFeedBack = (int)cmd.ExecuteScalar();
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }       // максимальное значение id в таблице
        private void button_add_feedback_Click(object sender, EventArgs e)
        {
            addFeedBack();
        }       // add feedback
        private void FeedBackPlace_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("********************************************************** Feedback Place Close ***********************************************************");
        }
    }
}