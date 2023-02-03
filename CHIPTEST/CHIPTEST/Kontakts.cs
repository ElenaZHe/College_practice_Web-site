using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHIPTEST
{
    public partial class Kontakts : Form
    {
        public Kontakts()
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

        private void Kontakts_Load(object sender, EventArgs e)
        {
         
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
