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
        public int i=2021;

        // Кнопка "Сохранить"
        private void button1_Click(object sender, EventArgs e)
        {

            // Добавление данных

            try
            {
                string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park";
                using (NpgsqlConnection contact = new NpgsqlConnection(path))
                {
                    contact.Open();
                    NpgsqlCommand insert = new NpgsqlCommand();
                    insert.Connection = contact;
                    insert.CommandText = $"insert into attractions(attraction_code, title, description, limitations, safety, price, locus) values ('{i}','{title.Text}', '{description.Text}', '{limitations.Text}', '{safety.Text}', '{Convert.ToInt32(price.Text)}', '{locus.Text}')";
                    insert.ExecuteNonQuery();
                    int result = insert.ExecuteNonQuery();
                    MessageBox.Show("Количество затронутых строк" + result.ToString());
                    i++;

                    contact.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // При загрузке формы в датагридвью добавляются 7 столбцов
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;

            int i = 0;

            // Заполнение данными из БД

            try
            {
                string path = "Host=localhost;Username=postgres;Password=cxNTVJas;Database=Amusement_park";
                using (NpgsqlConnection contact = new NpgsqlConnection(path))
                {
                    contact.Open();
                    string data = "select * from attractions order by attraction_code";
                    NpgsqlCommand select = new NpgsqlCommand(data, contact);
                    NpgsqlDataReader reader = select.ExecuteReader();

                    while (reader.Read())
                    {
                        dataGridView1.Rows[0].Cells[0].Value = reader.GetInt32(0).ToString();
                        dataGridView1.Rows[0].Cells[1].Value = reader.GetString(1);
                        dataGridView1.Rows[0].Cells[2].Value = reader.GetString(2);
                        dataGridView1.Rows[0].Cells[3].Value = reader.GetString(3);
                        dataGridView1.Rows[0].Cells[4].Value = reader.GetString(4);
                        dataGridView1.Rows[0].Cells[5].Value = reader.GetInt32(5).ToString();
                        dataGridView1.Rows[0].Cells[6].Value = reader.GetString(6);
                    
                    }
                    reader.Close();
                    contact.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
    }


