using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Npgsql;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УП2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка "Сохранить"
        private void button1_Click(object sender, EventArgs e)
        {

            // Добавление данных

            DataRow data = this.amusement_parkDataSet.Tables[1].NewRow();
            int id = this.dataGridView1.RowCount + 1;
            data[0] = id;
            data[1] = textBox1.Text;
            data[2] = textBox4.Text;
            data[3] = textBox5.Text;
            data[4] = textBox2.Text;
            data[5] = textBox3.Text;

            this.amusement_parkDataSet.Tables[1].Rows.Add(data);
            this.attractionsTableAdapter.Update(this.amusement_parkDataSet.attractions);
            this.amusement_parkDataSet.Tables[1].AcceptChanges();
            this.dataGridView1.Refresh();
            textBox1.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park";
            NpgsqlConnection db_connect = new NpgsqlConnection(path);
            db_connect.Open();
            string query = "select * from attractions order by attraction_code";
            NpgsqlCommand command = new NpgsqlCommand(query, db_connect);

            // Заполнение датагридвью

            int i = 0;
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows[i].Cells[0].Value = reader[0];
                dataGridView1.Rows[i].Cells[1].Value = reader[1];
                dataGridView1.Rows[i].Cells[2].Value = reader[2];
                dataGridView1.Rows[i].Cells[3].Value = reader[3];
                dataGridView1.Rows[i].Cells[4].Value = reader[4];
                dataGridView1.Rows[i].Cells[5].Value = reader[5];
                i++;
            }
            db_connect.Close();
        }
    }
}
