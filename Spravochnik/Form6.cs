using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spravochnik
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Koldun_210")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            else if (textBox1.Text != "Koldun_210")
            {
                MessageBox.Show("Введён не верный пароль! Введите пароль повторно!", "Внимание!");
            }
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }
    }
}
