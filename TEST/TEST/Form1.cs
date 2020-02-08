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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=30.30.30.243;Initial Catalog=Менеджеры;User ID=wsr-2;Password=xxNTeL9FT2");
            SqlCommand cmd = new SqlCommand("Select * From Менеджеры where  Name='" + comboBox1.Text + "'AND Parol='" + textBox1.Text + "';");
            con.Open();
            cmd.Connection = con;          
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (int.Parse(rd["id"].ToString()) ==1)
                {
                    this.Visible = false;
                    Form2 f2 = new Form2();
                    f2.Show(); ; break;
                } else
                {
                    this.Visible = false;
                    Form3 f3 = new Form3();
                    f3.Show(); ; break;
                }
            }
            rd.Close();
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "менеджерыDataSet.Менеджеры". При необходимости она может быть перемещена или удалена.
            this.менеджерыTableAdapter.Fill(this.менеджерыDataSet.Менеджеры);

        }
    }
}
