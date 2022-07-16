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
    public partial class Form5 : Form
    {
        public int authorizationValue;

        public Form5()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Koldun_21")
            {
                switch (authorizationValue)
                {
                    case 1:
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                        break;
                    case 2:
                        Form3 form3 = new Form3();
                        form3.Show();
                        this.Hide();
                        break;
                    case 3:
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Что-то не так с 23 строкой в Form5");
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Введён не верный пароль! Введите пароль повторно!", "Внимание!");
            }
        }
        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1, null);
            }
        }
    }
}