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
    public partial class EditEvent : Form
    {
        public static Logger log = LogManager.GetCurrentClassLogger();                  // логирование
        public static string connection = $"Data Source=VOVA-PC;Initial Catalog=KyrsProject;Integrated Security=True";
        private string id;

        public EditEvent()
        {
            InitializeComponent();
        }
        private void EditEvent_Load(object sender, EventArgs e)
        {
            log.Info("************************************************************ Edit Event Start *************************************************************");
            InfoEvent ie = this.Owner as InfoEvent;
            id = ie.id;
        }
        private void button_editEvent_Click(object sender, EventArgs e)     // изменение инфы
        {
            if (checkBox_editName.Checked == false && checkBox_editType.Checked == false &&
                checkBox_editDate.Checked == false && checkBox_editAge.Checked == false)
            {
                log.Info("Необходим выбрать параметр для изменения");
                MessageBox.Show("Необходим выбрать параметр для изменения", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //название
                if (checkBox_editName.Checked == true && checkBox_editType.Checked == false &&
                    checkBox_editDate.Checked == false && checkBox_editAge.Checked == false)
                {
                    if (textBox_name.Text.ToString() != "") editName();
                    else MessageBox.Show("Поле заполнено некорректно!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // тип
                if (checkBox_editName.Checked == false && checkBox_editType.Checked == true &&
                    checkBox_editDate.Checked == false && checkBox_editAge.Checked == false)
                {
                    if (comboBox_type.Text.ToString() != "") editType();
                    else MessageBox.Show("Поле заполнено некорректно!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // дата
                if (checkBox_editName.Checked == false && checkBox_editType.Checked == false &&
                    checkBox_editDate.Checked == true && checkBox_editAge.Checked == false) { editDate(); }
                // возраст
                if (checkBox_editName.Checked == false && checkBox_editType.Checked == false &&
                    checkBox_editDate.Checked == false && checkBox_editAge.Checked == true)
                {
                    if (comboBox_age.Text.ToString() != "") editAge();
                    else MessageBox.Show("Поле заполнено некорректно!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void editName()     // изменить название    
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_query = $"update event set name_event = '{textBox_name.Text.ToString()}' where id = {id}";
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();
                log.Info($"Название мероприятия id: {id.ToString()} успешно изменено на '{textBox_name.Text.ToString()}'.");
                MessageBox.Show("Название успешно изменнено.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }
        private void editType()     // изменение типа   
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_query = $"update event set id_type = '{comboBox_type.Text.ToString()}' where id = {id}";
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();

                log.Info($"Тип мероприятия id: {id.ToString()} успешно изменен на '{comboBox_type.Text.ToString()}'.");
                MessageBox.Show("Тип мероприятия успешно изменнен.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }
        private void editDate()         // изменение даты   
        {
            DateTime date = DateTime.Parse(dateTimePicker_date.Value.ToString());
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_query = $"update event set date_event = '{date.ToString()}' where id = {id}";
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();

                log.Info($"Дата мероприятия id: {id.ToString()} успешно изменена на '{date.ToString()}'.");
                MessageBox.Show("Дата мероприятия успешно изменнена.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }
        private void editAge() // возрастное ограничение    
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_query = $"update event set age_control = '{comboBox_age.Text.ToString()}' where id = {id}";
                SqlCommand cmd = new SqlCommand(sql_query, connect);
                cmd.ExecuteNonQuery();

                log.Info($"Возрастное ограничение мероприятия id: {id.ToString()} успешно изменено на '{comboBox_age.Text.ToString()}'.");
                MessageBox.Show("Возрастное ограничение успешно изменнено.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }
        private void EditEvent_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("************************************************************ Edit Event Close *************************************************************");

        }
    }
}
