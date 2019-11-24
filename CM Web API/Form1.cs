using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CM_Web_API
{
    public partial class Form1 : Form
    {
        string date;
        string sql;

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql = "select * from booking where ";
            textBox1.Text = date;

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string year = dateTimePicker1.Value.Year.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string date = dateTimePicker1.Value.Day.ToString();
            string time = dateTimePicker1.Value.TimeOfDay.ToString();
            date = year + "-" + month + "-" + date + " " + time;
            textBox1.Text = date;

        }
    }
}
