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


namespace CHIPTEST
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }
    public partial class lich_kab : Form
    {
        DataBase dataBase= new DataBase();
        int selectedRow;

       
        public lich_kab()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 frm_form1 = new Form1();
            this.Hide();
            frm_form1.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lich_kab frm_lichkab = new lich_kab();
            this.Hide();
            frm_lichkab.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            O_nas frm_onas = new O_nas();
            this.Hide();
            frm_onas.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Kontakts frm_kontakts = new Kontakts();
            this.Hide();
            frm_kontakts.ShowDialog();
            this.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var names = textBox6.Text;
            var yslygi = textBox1.Text;
            var problem = textBox3.Text;
            var dateTime = dateTimePicker1.Text;
          
            if (names.Length > 0)
            {
                var addQuery = $"insert into test_db (names, yslygi, problem, dateTime) values ('{names}','{yslygi}', '{problem}', '{dateTime}')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не создана!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();

        }


        private void lich_kab_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("names", "Ф.И.");
            dataGridView1.Columns.Add("yslygi", "Услуги");
            dataGridView1.Columns.Add("problem", " Проблемы");
            dataGridView1.Columns.Add("dateTime", "Дата заказа");
          
        }

        private void ClearFields()
        {
            textBox6.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from test_db";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
