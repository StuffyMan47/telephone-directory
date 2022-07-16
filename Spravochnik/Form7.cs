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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Koldun_210")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }
            else if (textBox1.Text != "Koldun_210")
            {
                MessageBox.Show("Введён не верный пароль! Введите пароль повторно!", "Внимание!");
            }
        }
    }
}
