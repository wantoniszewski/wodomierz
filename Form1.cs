using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wodomierz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            haslo.PasswordChar = '*';
            //haslo.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zaloguj();
        }

        private void zaloguj()
        {
            if ((haslo.Text == "a") | !(haslo.Text == Convert.ToString(1)))
            {
                MessageBox.Show("Błędny login lub hasło.");
            }
            else
            {
                pWynikLogowania.Text = "zalogowano";
                MessageBox.Show("jesteś zalogowany");
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                //dzialanie();
            }

            //throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
