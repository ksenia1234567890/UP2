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
                    var sql = "select attractions_i" +
                        "" +
                        "(@attraction_code," +
                        "@title," +
                        "@description," +
                        "@limitations," +
                        "@safety," +
                        "@price," +
                        "@locus)";
                    using(var cmd = new NpgsqlCommand(sql,contact))
                    {
                        cmd.Parameters.Add("@attraction_code",NpgsqlTypes.NpgsqlDbType.Numeric).Value = i;
                        cmd.Parameters.Add("@title", NpgsqlTypes.NpgsqlDbType.Varchar).Value= title.Text;
                        cmd.Parameters.Add("@description", NpgsqlTypes.NpgsqlDbType.Varchar).Value = description.Text;
                        cmd.Parameters.Add("@limitations", NpgsqlTypes.NpgsqlDbType.Varchar).Value = limitations.Text;
                        cmd.Parameters.Add("@safety", NpgsqlTypes.NpgsqlDbType.Varchar).Value = safety.Text;
                        cmd.Parameters.Add("@price", NpgsqlTypes.NpgsqlDbType.Numeric).Value = int.Parse(price.Text);
                        cmd.Parameters.Add("@locus", NpgsqlTypes.NpgsqlDbType.Varchar).Value = locus.Text;

                        cmd.ExecuteNonQuery();
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Количество затронутых строк" + result.ToString());
                    }
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
            db.ColumnCount = 7;
            db.RowCount = 21;

            int index = 0;

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
                        db.Rows[index].Cells[0].Value = reader.GetInt32(0).ToString();
                        db.Rows[index].Cells[1].Value = reader.GetString(1);
                        db.Rows[index].Cells[2].Value = reader.GetString(2);
                        db.Rows[index].Cells[3].Value = reader.GetString(3);
                        db.Rows[index].Cells[4].Value = reader.GetString(4);
                        db.Rows[index].Cells[5].Value = reader.GetInt32(5).ToString();
                        db.Rows[index].Cells[6].Value = reader.GetString(6);
                        index++;

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


