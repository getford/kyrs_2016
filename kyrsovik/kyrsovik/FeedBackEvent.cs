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
    public partial class FeedBackEvent : Form
    {
        public static Logger log = LogManager.GetCurrentClassLogger();
        public static string connection = $"Data Source=VOVA-PC;Initial Catalog=KyrsProject;Integrated Security=True";
        private int idAuthor;
        private int maxIdFeedBack = 0;

        public FeedBackEvent()
        {
            InitializeComponent();

            comboBox_rate.Items.Add(1);
            comboBox_rate.Items.Add(2);
            comboBox_rate.Items.Add(3);
            comboBox_rate.Items.Add(4);
            comboBox_rate.Items.Add(5);
        }
        private void FeedBackEvent_Load(object sender, EventArgs e)
        {
            log.Info("********************************************************** Feedback Event Start ***********************************************************");
            InfoEvent ie = this.Owner as InfoEvent;
            label_name_event.Text = ie.label_name_event.Text.ToString();
            getAuthors();
        }
        private void addFeedBack()
        {
            getAuthorsId();
            getMaxIdFeedBack();

            InfoEvent ie = this.Owner as InfoEvent;

            string proc = "pr_insertFeedback_event";

            using (SqlConnection connect = new SqlConnection(connection))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(proc, connect);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter id = new SqlParameter
                {
                    ParameterName = @"id",
                    Value = maxIdFeedBack = maxIdFeedBack + 1
                };
                cmd.Parameters.Add(id);
                SqlParameter id_event = new SqlParameter
                {
                    ParameterName = @"id_event",
                    Value = ie.id.ToString()
                };
                cmd.Parameters.Add(id_event);
                SqlParameter topic = new SqlParameter
                {
                    ParameterName = @"topic",
                    Value = textBox_topic.Text.ToString()
                };
                cmd.Parameters.Add(topic);
                SqlParameter text_feedback = new SqlParameter
                {
                    ParameterName = @"text_feedback",
                    Value = richTextBox_text_feedback.Text.ToString()
                };
                cmd.Parameters.Add(text_feedback);
                SqlParameter id_authors = new SqlParameter
                {
                    ParameterName = @"id_authors",
                    Value = idAuthor.ToString()
                };
                cmd.Parameters.Add(id_authors);
                SqlParameter rating_event = new SqlParameter
                {
                    ParameterName = @"rating_event",
                    Value = comboBox_rate.Text.ToString()
                };
                cmd.Parameters.Add(rating_event);
                SqlParameter date_feedback = new SqlParameter
                {
                    ParameterName = @"date_feedback",
                    Value = System.DateTime.Now.ToString()
                };
                cmd.Parameters.Add(date_feedback);

                cmd.ExecuteScalar();

                log.Info($"Отзыв успешно добавлен! id мероприятия: {ie.id.ToString()}, id автора: {idAuthor.ToString()}.");
                MessageBox.Show("Запись успешно добавлена", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                while (dr.Read())
                {
                    comboBox_author.Items.Add(dr.GetString(0));
                }
                dr.Close();
            }

            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally
            {
                connect.Close();
            }
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
            finally { connect.Close(); }
        }       // id автора 
        private void getMaxIdFeedBack()
        {
            SqlConnection connect = new SqlConnection(connection);
            string sql_max_id = $"select MAX(id) from feedback_event";
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
        }           // кнопка добавить отзыв
        private void FeedBackEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("********************************************************** Feedback Event Close ***********************************************************");
        }       // обновляем инфу после закрытия формы
    }
}

/*
string sql_insert_feedback = string.Format($"insert into feedback_event ([id], [id_event], [topic], [text_feedback], [id_authors], [rating_event], [date_feedback]) values (@id, @id_event, @topic, @text_feedback, @id_authors, @rating_event, @date_feedback)");

InfoEvent ie = this.Owner as InfoEvent;

SqlConnection connect = new SqlConnection(connection);

try
{
    connect.Open();
    SqlCommand cmd_insert = new SqlCommand(sql_insert_feedback, connect);

    getAuthorsId();
    getMaxIdFeedBack();

    cmd_insert.Parameters.AddWithValue("@id", (maxIdFeedBack = maxIdFeedBack + 1).ToString());
    cmd_insert.Parameters.AddWithValue("@id_event", ie.id.ToString());
    cmd_insert.Parameters.AddWithValue("@topic", textBox_topic.Text.ToString());
    cmd_insert.Parameters.AddWithValue("@text_feedback", richTextBox_text_feedback.Text.ToString());
    cmd_insert.Parameters.AddWithValue("@id_authors", idAuthor.ToString());
    cmd_insert.Parameters.AddWithValue("@rating_event", comboBox_rate.Text.ToString());
    cmd_insert.Parameters.AddWithValue("@date_feedback", System.DateTime.Now.ToString());
    cmd_insert.ExecuteNonQuery();

    log.Info($"Отзыв успешно добавлен! id мероприятия: {ie.id.ToString()}, id автора: {idAuthor.ToString()}.");
    MessageBox.Show("Запись успешно добавлена", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
catch (SqlException ex) { MessageBox.Show(ex.Message); }
finally { connect.Close(); }
*/
