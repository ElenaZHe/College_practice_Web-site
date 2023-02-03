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
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.passField.AutoSize=false;
            this.passField.Size = new Size(this.passField.Size.Width, 26);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login.ActiveForm.Hide();
            Admin MyForm2 = new Admin();
            MyForm2.ShowDialog();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVxod_Click(object sender, EventArgs e)
        {
            var loginUser = loginField.Text;
            var passUser = passField.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from polzjvatel where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else 
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sign_up frm_sign = new sign_up();
            frm_sign.Show();
            this.Hide();
        }
    }
}
