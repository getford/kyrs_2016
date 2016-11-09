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
        public Main()
        {
            InitializeComponent();
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
    }
}
