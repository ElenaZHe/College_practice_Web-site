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
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();
        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var login = textBox1.Text;
            var password = textBox2.Text;

            string querystring = $"insert into polzjvatel(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                Login frm = new Login();
                this.Hide();
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();

        }

        private Boolean checkuser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user from polzjvatel where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }


        }

        private void sign_up_Load(object sender, EventArgs e)
        {
           
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        Point lastPoint;

        private void sign_up_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void sign_up_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
