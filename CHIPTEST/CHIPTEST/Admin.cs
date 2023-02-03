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
    public partial class Admin : Form
    {
        DataBase dataBase = new DataBase();
        public Admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.passField1.AutoSize = false;
            this.passField1.Size = new Size(this.passField1.Size.Width, 26);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = loginField1.Text;
            var passUser = passField1.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from mastera where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Masters frm_masters = new Masters();
                this.Hide();
                frm_masters.ShowDialog();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void close1Button_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void passField1_TextChanged(object sender, EventArgs e)
        {

        }
        Point lastPoint;
        private void Admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sign_up2 frm_sign2 = new sign_up2();
            this.Hide();
            frm_sign2.ShowDialog();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
