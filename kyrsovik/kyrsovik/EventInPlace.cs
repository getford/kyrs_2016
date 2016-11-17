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
    public partial class EventInPlace : Form
    {
        public static string connection = $"Data Source=GETFORD-PC;Initial Catalog=KyrsProject;Integrated Security=True";

        public EventInPlace()
        {
            InitializeComponent();
        }

        private void EventInPlace_Load(object sender, EventArgs e)
        {
            getEventInPlace();
        }

        private void Initialize_List()
        {
            listView_evantInPlace.GridLines = true;
            listView_evantInPlace.AllowColumnReorder = true;
            listView_evantInPlace.LabelEdit = false;
            listView_evantInPlace.FullRowSelect = true;
            listView_evantInPlace.View = View.Details;// стиль вывода в таблицу
        }// инициализация listview
        private void fill_ListView_event()
        {
            Initialize_List();
            try
            {
                listView_evantInPlace.Columns.Add("id", listView_evantInPlace.Width / 6);
                listView_evantInPlace.Columns.Add("Место", listView_evantInPlace.Width / 6);
                listView_evantInPlace.Columns.Add("Название", listView_evantInPlace.Width / 6);
                listView_evantInPlace.Columns.Add("Тип", listView_evantInPlace.Width / 6);
                listView_evantInPlace.Columns.Add("Дата", listView_evantInPlace.Width / 6);
                listView_evantInPlace.Columns.Add("Возраст", listView_evantInPlace.Width / 6);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }           // инициализация listview (колонки)

        private void getEventInPlace()
        {
            InfoPlace ip = this.Owner as InfoPlace;

            string id_place = ip.id;

            SqlConnection connect = new SqlConnection(connection);
            try
            {
                connect.Open();
                string sql_query = $"select * from event where id_place = {id_place}";
                SqlCommand cmd = new SqlCommand(sql_query, connect);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                listView_evantInPlace.Clear();
                fill_ListView_event();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                    listView_evantInPlace.Items.Add(lvi);
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
