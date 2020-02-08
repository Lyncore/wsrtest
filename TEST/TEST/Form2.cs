using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TEST
{
    public partial class Form2 : Form
    {
          SqlConnection con = new SqlConnection(@"Data Source=30.30.30.243;Initial Catalog=Менеджеры;User ID=wsr-2;Password=xxNTeL9FT2");
          SqlCommand cmd = new SqlCommand("Select * From Менеджеры");

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "менеджерыDataSet.Напоминания". При необходимости она может быть перемещена или удалена.
            this.напоминанияTableAdapter.Fill(this.менеджерыDataSet.Напоминания);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqa = new SqlDataAdapter();
            con.Open();
            DataTable tb = new DataTable();
            sqa.Fill(tb);
            BindingSource bs = new BindingSource();
            bs.DataSource = tb;
            dataGridView1.DataSource = bs;
            con.Close();
        }
    }

}
