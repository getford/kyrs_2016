using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kyrsovik
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer.Interval = 3000;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
